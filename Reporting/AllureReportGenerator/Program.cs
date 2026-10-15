using ClosedXML.Excel;
using Newtonsoft.Json.Linq;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ScottPlot;
using Colors = QuestPDF.Helpers.Colors;

QuestPDF.Settings.License = LicenseType.Community;

Console.WriteLine("Allure Excel and PDF Dashboard Generator Started");
Console.WriteLine();

string projectRoot = @"C:\Documents\GTR_AUTOMATED";
string resultsPath = GetArgument(args, "--results", Path.Combine(projectRoot, "bin", "Debug", "net10.0", "allure-results"));
string excelFile = GetArgument(args, "--excel-output", Path.Combine(projectRoot, "ExecutionReports", "AutomationResults.xlsx"));
string pdfFile = GetArgument(args, "--pdf-output", Path.Combine(projectRoot, "ExecutionReports", "ExecutionSummary.pdf"));

resultsPath = Path.GetFullPath(resultsPath);
excelFile = Path.GetFullPath(excelFile);
pdfFile = Path.GetFullPath(pdfFile);

Console.WriteLine($"Allure results: {resultsPath}");
Console.WriteLine($"Excel output:   {excelFile}");
Console.WriteLine($"PDF output:     {pdfFile}");
Console.WriteLine();

if (!Directory.Exists(resultsPath))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"ERROR: Allure results folder not found: {resultsPath}");
    Console.ResetColor();
    return 1;
}

string[] resultFiles = Directory.GetFiles(resultsPath, "*-result.json", SearchOption.TopDirectoryOnly);
Console.WriteLine($"Allure result files found: {resultFiles.Length}");

if (resultFiles.Length == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ERROR: No *-result.json files were found.");
    Console.ResetColor();
    return 1;
}

List<AllureTestResult> testResults = new();

foreach (string resultFile in resultFiles)
{
    try
    {
        JObject json = JObject.Parse(File.ReadAllText(resultFile));
        JArray labels = json["labels"] as JArray ?? new JArray();
        JObject? statusDetails = json["statusDetails"] as JObject;
        long start = json.Value<long?>("start") ?? 0;
        long stop = json.Value<long?>("stop") ?? start;

        string feature = GetLabelValue(labels, "feature");
        if (string.IsNullOrWhiteSpace(feature)) feature = GetLabelValue(labels, "suite");
        if (string.IsNullOrWhiteSpace(feature)) feature = GetLabelValue(labels, "parentSuite");
        if (string.IsNullOrWhiteSpace(feature)) feature = "Not specified";

        AllureTestResult result = new()
        {
            Id = json.Value<string>("uuid") ?? Path.GetFileNameWithoutExtension(resultFile),
            Feature = feature,
            Story = GetLabelValue(labels, "story"),
            Epic = GetLabelValue(labels, "epic"),
            Scenario = json.Value<string>("name") ?? "Unnamed scenario",
            FullName = json.Value<string>("fullName") ?? string.Empty,
            Status = NormaliseStatus(json.Value<string>("status") ?? "unknown"),
            Severity = GetLabelValue(labels, "severity"),
            Owner = GetLabelValue(labels, "owner"),
            StartTime = start > 0 ? DateTimeOffset.FromUnixTimeMilliseconds(start).LocalDateTime : null,
            DurationSeconds = start > 0 && stop >= start ? Math.Round((stop - start) / 1000d, 2) : 0,
            Description = json.Value<string>("description") ?? string.Empty,
            ErrorMessage = statusDetails?.Value<string>("message") ?? string.Empty,
            ErrorTrace = statusDetails?.Value<string>("trace") ?? string.Empty,
            SourceJson = Path.GetFileName(resultFile)
        };

        ReadAllureSteps(json["steps"] as JArray, result.Steps, resultsPath, string.Empty, 0);
        ReadAttachments(json["attachments"] as JArray, result.Attachments, resultsPath, "Scenario");
        testResults.Add(result);
    }
    catch (Exception exception)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"WARNING: Unable to process {Path.GetFileName(resultFile)}: {exception.Message}");
        Console.ResetColor();
    }
}

testResults = testResults
    .OrderBy(result => result.StartTime ?? DateTime.MaxValue)
    .ThenBy(result => result.Feature)
    .ThenBy(result => result.Scenario)
    .ToList();

if (testResults.Count == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ERROR: No valid Allure results were read.");
    Console.ResetColor();
    return 1;
}

ExecutionSummary summary = BuildSummary(testResults);
List<FeatureSummary> featureSummaries = BuildFeatureSummaries(testResults);

Directory.CreateDirectory(Path.GetDirectoryName(excelFile)!);
Directory.CreateDirectory(Path.GetDirectoryName(pdfFile)!);
if (File.Exists(excelFile)) File.Delete(excelFile);
if (File.Exists(pdfFile)) File.Delete(pdfFile);

string chartFolder = Path.Combine(Path.GetDirectoryName(excelFile)!, "DashboardCharts_Temp");
if (Directory.Exists(chartFolder)) Directory.Delete(chartFolder, true);
Directory.CreateDirectory(chartFolder);

string statusChartFile = Path.Combine(chartFolder, "StatusDistribution.png");
string featureChartFile = Path.Combine(chartFolder, "FeatureBreakdown.png");
GenerateStatusChart(summary, statusChartFile);
GenerateFeatureChart(featureSummaries, featureChartFile);

Console.WriteLine("Generating Excel dashboard report...");
using (XLWorkbook workbook = new())
{
    CreateDashboardWorksheet(workbook, summary, featureSummaries, statusChartFile, featureChartFile);
    CreateExecutionSummaryWorksheet(workbook, summary);
    CreateTestResultsWorksheet(workbook, testResults);
    CreateAllureStepsWorksheet(workbook, testResults);
    CreateFailedTestsWorksheet(workbook, testResults);
    CreateFeatureBreakdownWorksheet(workbook, featureSummaries);
    workbook.SaveAs(excelFile);
}
Console.WriteLine($"Excel created: {excelFile}");

Console.WriteLine("Generating PDF dashboard report...");
QuestPDF.Fluent.Document.Create(document =>
{
    document.Page(page =>
    {
        page.Size(PageSizes.A4.Landscape());
        page.Margin(25);
        page.DefaultTextStyle(style => style.FontSize(8));

        page.Header().Column(column =>
        {
            column.Item().Text("Automation Test Execution Report").FontSize(20).Bold().FontColor(Colors.Blue.Darken2);
            column.Item().Text($"Generated: {summary.GeneratedOn:dd-MMM-yyyy HH:mm:ss}");
        });

        page.Content().PaddingVertical(10).Column(column =>
        {
            column.Spacing(10);
            column.Item().Text("Dashboard").FontSize(16).Bold().FontColor(Colors.Blue.Darken2);
            column.Item().Border(1).BorderColor(Colors.Grey.Lighten1).Padding(10).Row(row =>
            {
                AddPdfMetric(row, "Total", summary.Total.ToString(), Colors.Blue.Darken2);
                AddPdfMetric(row, "Passed", summary.Passed.ToString(), Colors.Green.Darken2);
                AddPdfMetric(row, "Failed", summary.Failed.ToString(), Colors.Red.Darken2);
                AddPdfMetric(row, "Broken", summary.Broken.ToString(), Colors.Orange.Darken2);
                AddPdfMetric(row, "Skipped", summary.Skipped.ToString(), Colors.Grey.Darken2);
                AddPdfMetric(row, "Pass rate", $"{summary.PassRate:0.00}%", Colors.Blue.Darken2);
            });

            column.Item().Row(row =>
            {
                row.RelativeItem().PaddingRight(5).Image(statusChartFile).FitArea();
                row.RelativeItem().PaddingLeft(5).Image(featureChartFile).FitArea();
            });

            column.Item().PageBreak();
            column.Item().Text("Scenario Details and Allure Steps").FontSize(16).Bold().FontColor(Colors.Blue.Darken2);

            foreach (AllureTestResult result in testResults)
            {
                column.Item().Border(1).BorderColor(GetPdfStatusColour(result.Status)).Padding(8).Column(testColumn =>
                {
                    testColumn.Spacing(4);
                    testColumn.Item().Row(row =>
                    {
                        row.RelativeItem().Text($"{result.Feature} - {result.Scenario}").FontSize(11).Bold();
                        row.ConstantItem(75).AlignRight().Text(result.Status).Bold().FontColor(GetPdfStatusColour(result.Status));
                    });
                    testColumn.Item().Text($"Duration: {FormatDuration(result.DurationSeconds)} | Steps: {result.Steps.Count}");

                    if (!string.IsNullOrWhiteSpace(result.ErrorMessage))
                        testColumn.Item().Background(Colors.Red.Lighten5).Padding(5).Text(LimitText(result.ErrorMessage, 1000)).FontColor(Colors.Red.Darken3);

                    if (result.Steps.Count > 0)
                    {
                        testColumn.Item().PaddingTop(4).Text("Allure Steps").Bold().FontColor(Colors.Blue.Darken2);
                        foreach (AllureStep step in result.Steps)
                        {
                            testColumn.Item().PaddingLeft(step.Level * 12).Row(stepRow =>
                            {
                                stepRow.ConstantItem(20).Text(GetStepSymbol(step.Status)).FontColor(GetPdfStatusColour(step.Status));
                                stepRow.RelativeItem().Text(step.Name);
                                stepRow.ConstantItem(65).AlignRight().Text(FormatDuration(step.DurationSeconds));
                                stepRow.ConstantItem(55).AlignRight().Text(step.Status).Bold().FontColor(GetPdfStatusColour(step.Status));
                            });
                        }
                    }
                });
            }
        });

        page.Footer().AlignCenter().Text(text =>
        {
            text.Span("Page ");
            text.CurrentPageNumber();
            text.Span(" of ");
            text.TotalPages();
        });
    });
}).GeneratePdf(pdfFile);

Console.WriteLine($"PDF created: {pdfFile}");

try { Directory.Delete(chartFolder, true); } catch { }
Console.WriteLine("Excel and PDF dashboard reports generated successfully.");
return 0;

static ExecutionSummary BuildSummary(IReadOnlyCollection<AllureTestResult> results)
{
    int total = results.Count;
    int passed = results.Count(x => x.Status == "Passed");
    int failed = results.Count(x => x.Status == "Failed");
    int broken = results.Count(x => x.Status == "Broken");
    int skipped = results.Count(x => x.Status == "Skipped");
    int unknown = total - passed - failed - broken - skipped;
    return new ExecutionSummary
    {
        Total = total,
        Passed = passed,
        Failed = failed,
        Broken = broken,
        Skipped = skipped,
        Unknown = unknown,
        PassRate = total == 0 ? 0 : Math.Round((double)passed / total * 100, 2),
        TotalDurationSeconds = results.Sum(x => x.DurationSeconds),
        TotalSteps = results.Sum(x => x.Steps.Count),
        ScreenshotCount = results.Sum(x => x.AllAttachments.Count(a => a.IsImage && a.Exists)),
        GeneratedOn = DateTime.Now
    };
}

static List<FeatureSummary> BuildFeatureSummaries(IEnumerable<AllureTestResult> results) => results
    .GroupBy(x => x.Feature)
    .Select(g => new FeatureSummary
    {
        Feature = g.Key,
        Total = g.Count(),
        Passed = g.Count(x => x.Status == "Passed"),
        Failed = g.Count(x => x.Status == "Failed"),
        Broken = g.Count(x => x.Status == "Broken"),
        Skipped = g.Count(x => x.Status == "Skipped"),
        DurationSeconds = g.Sum(x => x.DurationSeconds)
    })
    .OrderByDescending(x => x.Total)
    .ToList();

static void GenerateStatusChart(ExecutionSummary summary, string output)
{
    ScottPlot.Plot plot = new();
    double[] values = { summary.Passed, summary.Failed, summary.Broken, summary.Skipped, summary.Unknown };
    var pie = plot.Add.Pie(values);
    string[] labels = { "Passed", "Failed", "Broken", "Skipped", "Unknown" };
    for (int i = 0; i < pie.Slices.Count; i++)
        pie.Slices[i].Label = $"{labels[i]}: {values[i]:0}";
    plot.ShowLegend(ScottPlot.Alignment.UpperRight);
    plot.Title("Status Distribution");
    plot.Axes.Frameless();
    plot.HideGrid();
    plot.SavePng(output, 900, 500);
}

static void GenerateFeatureChart(IReadOnlyCollection<FeatureSummary> features, string output)
{
    List<FeatureSummary> top = features.Take(10).Reverse().ToList();
    ScottPlot.Plot plot = new();
    double[] values = top.Select(x => (double)x.Total).ToArray();
    var bars = plot.Add.Bars(values);
    bars.Horizontal = true;
    for (int i = 0; i < bars.Bars.Count; i++)
        bars.Bars[i].Label = $"{Shorten(top[i].Feature, 25)}: {top[i].Total}";
    bars.ValueLabelStyle.Bold = true;
    bars.ValueLabelStyle.FontSize = 12;
    plot.Title("Top Features by Test Count");
    plot.Axes.Margins(left: 0, right: .35);
    plot.SavePng(output, 1000, 600);
}

static void CreateDashboardWorksheet(XLWorkbook workbook, ExecutionSummary summary, IReadOnlyCollection<FeatureSummary> features, string statusChart, string featureChart)
{
    IXLWorksheet ws = workbook.Worksheets.Add("Dashboard");
    ws.Cell("A1").Value = "Allure Automation Dashboard";
    ws.Range("A1:L2").Merge();
    ws.Range("A1:L2").Style.Fill.BackgroundColor = XLColor.FromHtml("#1F4E78");
    ws.Range("A1:L2").Style.Font.FontColor = XLColor.White;
    ws.Range("A1:L2").Style.Font.Bold = true;
    ws.Range("A1:L2").Style.Font.FontSize = 22;
    ws.Range("A1:L2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

    string[] labels = { "Total", "Passed", "Failed", "Broken", "Skipped", "Pass Rate" };
    object[] values = { summary.Total, summary.Passed, summary.Failed, summary.Broken, summary.Skipped, summary.PassRate / 100 };
    string[] colours = { "#4472C4", "#70AD47", "#C00000", "#ED7D31", "#A5A5A5", "#5B9BD5" };
    for (int i = 0; i < labels.Length; i++)
    {
        int col = 1 + i * 2;
        ws.Range(4, col, 4, col + 1).Merge().Value = labels[i];
        ws.Range(5, col, 6, col + 1).Merge().Value = XLCellValue.FromObject(values[i]);
        ws.Range(4, col, 6, col + 1).Style.Fill.BackgroundColor = XLColor.FromHtml(colours[i]);
        ws.Range(4, col, 6, col + 1).Style.Font.FontColor = XLColor.White;
        ws.Range(4, col, 6, col + 1).Style.Font.Bold = true;
        ws.Range(4, col, 6, col + 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
        ws.Range(4, col, 6, col + 1).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
        if (i == 5) ws.Range(5, col, 6, col + 1).Style.NumberFormat.Format = "0.00%";
    }

    ws.AddPicture(statusChart).MoveTo(ws.Cell("A8"));
    ws.AddPicture(featureChart).MoveTo(ws.Cell("G8"));

    ws.Cell("A35").Value = "Feature";
    ws.Cell("B35").Value = "Total";
    ws.Cell("C35").Value = "Passed";
    ws.Cell("D35").Value = "Failed";
    ws.Cell("E35").Value = "Broken";
    ws.Cell("F35").Value = "Skipped";
    FormatHeader(ws.Range("A35:F35"));
    int row = 36;
    foreach (FeatureSummary feature in features)
    {
        ws.Cell(row, 1).Value = feature.Feature;
        ws.Cell(row, 2).Value = feature.Total;
        ws.Cell(row, 3).Value = feature.Passed;
        ws.Cell(row, 4).Value = feature.Failed;
        ws.Cell(row, 5).Value = feature.Broken;
        ws.Cell(row, 6).Value = feature.Skipped;
        row++;
    }
    ws.Columns("A:L").Width = 14;
    ws.Column("A").Width = 35;
    ws.SheetView.FreezeRows(2);
}

static void CreateExecutionSummaryWorksheet(XLWorkbook workbook, ExecutionSummary summary)
{
    IXLWorksheet ws = workbook.Worksheets.Add("Execution Summary");
    ws.Cell("A1").Value = "Automation Test Execution Summary";
    ws.Range("A1:D1").Merge();
    ws.Range("A1:D1").Style.Fill.BackgroundColor = XLColor.FromHtml("#1F4E78");
    ws.Range("A1:D1").Style.Font.FontColor = XLColor.White;
    ws.Range("A1:D1").Style.Font.Bold = true;
    ws.Range("A1:D1").Style.Font.FontSize = 18;
    ws.Cell("A3").Value = "Generated"; ws.Cell("B3").Value = summary.GeneratedOn;
    ws.Cell("A5").Value = "Metric"; ws.Cell("B5").Value = "Value";
    object[,] rows = { { "Total tests", summary.Total }, { "Passed", summary.Passed }, { "Failed", summary.Failed }, { "Broken", summary.Broken }, { "Skipped", summary.Skipped }, { "Unknown", summary.Unknown }, { "Pass rate", summary.PassRate / 100 }, { "Combined duration", FormatDuration(summary.TotalDurationSeconds) }, { "Total Allure steps", summary.TotalSteps }, { "Screenshot attachments", summary.ScreenshotCount } };
    for (int i = 0; i < rows.GetLength(0); i++) { ws.Cell(6 + i, 1).Value = rows[i, 0].ToString(); ws.Cell(6 + i, 2).Value = XLCellValue.FromObject(rows[i, 1]); }
    ws.Cell("B12").Style.NumberFormat.Format = "0.00%";
    FormatHeader(ws.Range("A5:B5"));
    ws.Columns("A:D").AdjustToContents();
}

static void CreateTestResultsWorksheet(XLWorkbook workbook, IReadOnlyCollection<AllureTestResult> results)
{
    IXLWorksheet ws = workbook.Worksheets.Add("Test Results");
    string[] headers = { "No.", "Feature", "Story", "Scenario", "Status", "Start Time", "Duration", "Severity", "Owner", "Step Count", "Screenshots", "Error Message", "Source JSON" };
    WriteHeaders(ws, headers);
    int row = 2, no = 1;
    foreach (AllureTestResult result in results)
    {
        ws.Cell(row, 1).Value = no++; ws.Cell(row, 2).Value = result.Feature; ws.Cell(row, 3).Value = result.Story; ws.Cell(row, 4).Value = result.Scenario; ws.Cell(row, 5).Value = result.Status;
        if (result.StartTime.HasValue) ws.Cell(row, 6).Value = result.StartTime.Value;
        ws.Cell(row, 7).Value = FormatDuration(result.DurationSeconds); ws.Cell(row, 8).Value = result.Severity; ws.Cell(row, 9).Value = result.Owner; ws.Cell(row, 10).Value = result.Steps.Count;
        ws.Cell(row, 11).Value = result.AllAttachments.Count(x => x.IsImage && x.Exists); ws.Cell(row, 12).Value = result.ErrorMessage; ws.Cell(row, 13).Value = result.SourceJson;
        ApplyStatusStyle(ws.Cell(row, 5), result.Status); row++;
    }
    FormatDataWorksheet(ws, headers.Length, row - 1);
    ws.Column(2).Width = 35; ws.Column(4).Width = 60; ws.Column(12).Width = 80;
}

static void CreateAllureStepsWorksheet(XLWorkbook workbook, IReadOnlyCollection<AllureTestResult> results)
{
    IXLWorksheet ws = workbook.Worksheets.Add("Allure Steps");
    string[] headers = { "Feature", "Scenario", "Scenario Status", "Step No.", "Level", "Parent Step", "Step", "Step Status", "Duration", "Attachments", "Error Message" };
    WriteHeaders(ws, headers);
    int row = 2;
    foreach (AllureTestResult result in results)
    {
        int no = 1;
        foreach (AllureStep step in result.Steps)
        {
            ws.Cell(row, 1).Value = result.Feature; ws.Cell(row, 2).Value = result.Scenario; ws.Cell(row, 3).Value = result.Status; ws.Cell(row, 4).Value = no++; ws.Cell(row, 5).Value = step.Level;
            ws.Cell(row, 6).Value = step.ParentStep; ws.Cell(row, 7).Value = new string(' ', step.Level * 4) + step.Name; ws.Cell(row, 8).Value = step.Status; ws.Cell(row, 9).Value = FormatDuration(step.DurationSeconds);
            ws.Cell(row, 10).Value = step.Attachments.Count; ws.Cell(row, 11).Value = step.ErrorMessage; ApplyStatusStyle(ws.Cell(row, 8), step.Status); row++;
        }
    }
    FormatDataWorksheet(ws, headers.Length, Math.Max(row - 1, 1));
    ws.Column(2).Width = 60; ws.Column(7).Width = 80; ws.Column(11).Width = 80;
}

static void CreateFailedTestsWorksheet(XLWorkbook workbook, IReadOnlyCollection<AllureTestResult> results)
{
    IXLWorksheet ws = workbook.Worksheets.Add("Failed Tests");
    string[] headers = { "Feature", "Scenario", "Status", "Duration", "Failed Step", "Error Message", "Error Trace" };
    WriteHeaders(ws, headers);
    int row = 2;
    foreach (AllureTestResult result in results.Where(x => x.Status is "Failed" or "Broken"))
    {
        List<AllureStep> failedSteps = result.Steps.Where(x => x.Status is "Failed" or "Broken").ToList();
        if (failedSteps.Count == 0) failedSteps.Add(new AllureStep { Name = "Scenario failure", Status = result.Status, ErrorMessage = result.ErrorMessage });
        foreach (AllureStep step in failedSteps)
        {
            ws.Cell(row, 1).Value = result.Feature; ws.Cell(row, 2).Value = result.Scenario; ws.Cell(row, 3).Value = result.Status; ws.Cell(row, 4).Value = FormatDuration(result.DurationSeconds);
            ws.Cell(row, 5).Value = step.Name; ws.Cell(row, 6).Value = string.IsNullOrWhiteSpace(step.ErrorMessage) ? result.ErrorMessage : step.ErrorMessage; ws.Cell(row, 7).Value = result.ErrorTrace;
            ApplyStatusStyle(ws.Cell(row, 3), result.Status); row++;
        }
    }
    FormatDataWorksheet(ws, headers.Length, Math.Max(row - 1, 1));
    ws.Column(2).Width = 60; ws.Column(5).Width = 70; ws.Column(6).Width = 90; ws.Column(7).Width = 100;
}

static void CreateFeatureBreakdownWorksheet(XLWorkbook workbook, IReadOnlyCollection<FeatureSummary> features)
{
    IXLWorksheet ws = workbook.Worksheets.Add("Feature Breakdown");
    string[] headers = { "Feature", "Total", "Passed", "Failed", "Broken", "Skipped", "Pass Rate", "Duration" };
    WriteHeaders(ws, headers);
    int row = 2;
    foreach (FeatureSummary f in features)
    {
        ws.Cell(row, 1).Value = f.Feature; ws.Cell(row, 2).Value = f.Total; ws.Cell(row, 3).Value = f.Passed; ws.Cell(row, 4).Value = f.Failed; ws.Cell(row, 5).Value = f.Broken; ws.Cell(row, 6).Value = f.Skipped;
        ws.Cell(row, 7).Value = f.Total == 0 ? 0 : (double)f.Passed / f.Total; ws.Cell(row, 7).Style.NumberFormat.Format = "0.00%"; ws.Cell(row, 8).Value = FormatDuration(f.DurationSeconds); row++;
    }
    FormatDataWorksheet(ws, headers.Length, row - 1); ws.Column(1).Width = 50;
}

static string GetArgument(IReadOnlyList<string> arguments, string name, string defaultValue)
{
    for (int i = 0; i < arguments.Count - 1; i++) if (string.Equals(arguments[i], name, StringComparison.OrdinalIgnoreCase)) return arguments[i + 1].Trim('"');
    return defaultValue;
}

static string GetLabelValue(JArray labels, string name) => labels.OfType<JObject>().FirstOrDefault(x => string.Equals(x.Value<string>("name"), name, StringComparison.OrdinalIgnoreCase))?.Value<string>("value") ?? string.Empty;
static string NormaliseStatus(string status) => status.Trim().ToLowerInvariant() switch { "passed" => "Passed", "failed" => "Failed", "broken" => "Broken", "skipped" => "Skipped", _ => "Unknown" };

static void ReadAllureSteps(JArray? steps, ICollection<AllureStep> output, string resultsDirectory, string parentStep, int level)
{
    if (steps is null) return;
    foreach (JObject item in steps.OfType<JObject>())
    {
        long start = item.Value<long?>("start") ?? 0, stop = item.Value<long?>("stop") ?? start;
        JObject? details = item["statusDetails"] as JObject;
        string name = item.Value<string>("name") ?? "Unnamed step";
        AllureStep step = new() { Name = name, ParentStep = parentStep, Level = level, Status = NormaliseStatus(item.Value<string>("status") ?? "unknown"), DurationSeconds = start > 0 && stop >= start ? Math.Round((stop - start) / 1000d, 2) : 0, ErrorMessage = details?.Value<string>("message") ?? string.Empty };
        ReadAttachments(item["attachments"] as JArray, step.Attachments, resultsDirectory, name); output.Add(step);
        ReadAllureSteps(item["steps"] as JArray, output, resultsDirectory, name, level + 1);
    }
}

static void ReadAttachments(JArray? attachments, ICollection<AllureAttachment> output, string resultsDirectory, string stepName)
{
    if (attachments is null) return;
    foreach (JObject item in attachments.OfType<JObject>())
    {
        string source = item.Value<string>("source") ?? string.Empty, type = item.Value<string>("type") ?? string.Empty, fullPath = Path.Combine(resultsDirectory, source);
        output.Add(new AllureAttachment { Name = item.Value<string>("name") ?? Path.GetFileName(source), Source = source, Type = type, FullPath = fullPath, StepName = stepName, Exists = File.Exists(fullPath), IsImage = type.StartsWith("image/", StringComparison.OrdinalIgnoreCase) || IsImageFile(fullPath) });
    }
}

static bool IsImageFile(string path) => Path.GetExtension(path).ToLowerInvariant() is ".png" or ".jpg" or ".jpeg" or ".bmp" or ".gif";
static string Shorten(string value, int max) => value.Length <= max ? value : value[..max] + "...";
static void WriteHeaders(IXLWorksheet ws, IReadOnlyList<string> headers) { for (int i = 0; i < headers.Count; i++) ws.Cell(1, i + 1).Value = headers[i]; }
static void FormatHeader(IXLRange header) { header.Style.Font.Bold = true; header.Style.Font.FontColor = XLColor.White; header.Style.Fill.BackgroundColor = XLColor.FromHtml("#1F4E78"); header.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; }
static void FormatDataWorksheet(IXLWorksheet ws, int lastColumn, int lastRow) { FormatHeader(ws.Range(1, 1, 1, lastColumn)); IXLRange range = ws.Range(1, 1, Math.Max(lastRow, 1), lastColumn); range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin; range.Style.Border.InsideBorder = XLBorderStyleValues.Thin; range.Style.Alignment.WrapText = true; ws.SheetView.FreezeRows(1); if (lastRow > 1) range.SetAutoFilter(); }
static void ApplyStatusStyle(IXLCell cell, string status) { cell.Style.Font.Bold = true; cell.Style.Fill.BackgroundColor = status switch { "Passed" => XLColor.LightGreen, "Failed" => XLColor.LightPink, "Broken" => XLColor.LightSalmon, "Skipped" => XLColor.LightYellow, _ => XLColor.LightGray }; }
static void AddPdfMetric(RowDescriptor row, string label, string value, string colour) => row.RelativeItem().AlignCenter().Column(c => { c.Item().AlignCenter().Text(label).FontColor(Colors.Grey.Darken2); c.Item().AlignCenter().Text(value).FontSize(14).Bold().FontColor(colour); });
static string GetPdfStatusColour(string status) => status switch { "Passed" => Colors.Green.Darken2, "Failed" => Colors.Red.Darken2, "Broken" => Colors.Orange.Darken2, "Skipped" => Colors.Grey.Darken2, _ => Colors.Black };
static string GetStepSymbol(string status) => status switch { "Passed" => "OK", "Failed" => "X", "Broken" => "!", "Skipped" => "-", _ => "?" };
static string FormatDuration(double seconds) { TimeSpan d = TimeSpan.FromSeconds(seconds); return d.TotalHours >= 1 ? $"{(int)d.TotalHours:00}:{d.Minutes:00}:{d.Seconds:00}" : $"{d.Minutes:00}:{d.Seconds:00}"; }
static string LimitText(string value, int max) { if (string.IsNullOrWhiteSpace(value)) return string.Empty; string cleaned = value.Replace("\r", " ").Replace("\n", " ").Trim(); return cleaned.Length <= max ? cleaned : cleaned[..max] + "..."; }

internal sealed class AllureTestResult
{
    public string Id { get; init; } = string.Empty; public string Feature { get; init; } = string.Empty; public string Story { get; init; } = string.Empty; public string Epic { get; init; } = string.Empty;
    public string Scenario { get; init; } = string.Empty; public string FullName { get; init; } = string.Empty; public string Status { get; init; } = string.Empty; public string Severity { get; init; } = string.Empty;
    public string Owner { get; init; } = string.Empty; public DateTime? StartTime { get; init; }
    public double DurationSeconds { get; init; }
    public string Description { get; init; } = string.Empty;
    public string ErrorMessage { get; init; } = string.Empty; public string ErrorTrace { get; init; } = string.Empty; public string SourceJson { get; init; } = string.Empty;
    public List<AllureStep> Steps { get; } = new(); public List<AllureAttachment> Attachments { get; } = new(); public List<AllureAttachment> AllAttachments => Attachments.Concat(Steps.SelectMany(x => x.Attachments)).ToList();
}

internal sealed class AllureStep { public string Name { get; init; } = string.Empty; public string ParentStep { get; init; } = string.Empty; public int Level { get; init; } public string Status { get; init; } = string.Empty; public double DurationSeconds { get; init; } public string ErrorMessage { get; init; } = string.Empty; public List<AllureAttachment> Attachments { get; } = new(); }
internal sealed class AllureAttachment { public string Name { get; init; } = string.Empty; public string Source { get; init; } = string.Empty; public string Type { get; init; } = string.Empty; public string FullPath { get; init; } = string.Empty; public string StepName { get; init; } = string.Empty; public bool Exists { get; init; } public bool IsImage { get; init; } }
internal sealed class ExecutionSummary { public int Total { get; init; } public int Passed { get; init; } public int Failed { get; init; } public int Broken { get; init; } public int Skipped { get; init; } public int Unknown { get; init; } public int TotalSteps { get; init; } public int ScreenshotCount { get; init; } public double PassRate { get; init; } public double TotalDurationSeconds { get; init; } public DateTime GeneratedOn { get; init; } }
internal sealed class FeatureSummary { public string Feature { get; init; } = string.Empty; public int Total { get; init; } public int Passed { get; init; } public int Failed { get; init; } public int Broken { get; init; } public int Skipped { get; init; } public double DurationSeconds { get; init; } }
