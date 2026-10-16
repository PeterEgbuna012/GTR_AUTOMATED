using ClosedXML.Excel;
using Newtonsoft.Json.Linq;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ScottPlot;
using Colors = QuestPDF.Helpers.Colors;

QuestPDF.Settings.License = LicenseType.Community;
Console.WriteLine("Allure Excel and PDF Dashboard Generator Started");

string projectRoot = @"C:\Documents\GTR_AUTOMATED";
string resultsPath = Path.GetFullPath(GetArgument(args, "--results", Path.Combine(projectRoot, "bin", "Debug", "net10.0", "allure-results")));
string excelFile = Path.GetFullPath(GetArgument(args, "--excel-output", Path.Combine(projectRoot, "ExecutionReports", "AutomationResults.xlsx")));
string pdfFile = Path.GetFullPath(GetArgument(args, "--pdf-output", Path.Combine(projectRoot, "ExecutionReports", "ExecutionSummary.pdf")));

Console.WriteLine($"Allure results: {resultsPath}");
Console.WriteLine($"Excel output:   {excelFile}");
Console.WriteLine($"PDF output:     {pdfFile}");

if (!Directory.Exists(resultsPath))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"ERROR: Allure results folder not found: {resultsPath}");
    Console.ResetColor();
    return 1;
}

string[] resultFiles = Directory.GetFiles(resultsPath, "*-result.json", SearchOption.TopDirectoryOnly);
Console.WriteLine($"Allure result files found: {resultFiles.Length}");
if (resultFiles.Length == 0) return 1;

List<AllureTestResult> testResults = new();
foreach (string resultFile in resultFiles)
{
    try
    {
        JObject json = JObject.Parse(File.ReadAllText(resultFile));
        JArray labels = json["labels"] as JArray ?? new JArray();
        JObject? details = json["statusDetails"] as JObject;
        long start = json.Value<long?>("start") ?? 0;
        long stop = json.Value<long?>("stop") ?? start;
        string feature = GetLabel(labels, "feature");
        if (string.IsNullOrWhiteSpace(feature)) feature = GetLabel(labels, "suite");
        if (string.IsNullOrWhiteSpace(feature)) feature = "Not specified";

        AllureTestResult result = new()
        {
            Id = json.Value<string>("uuid") ?? Path.GetFileNameWithoutExtension(resultFile),
            Feature = feature,
            Story = GetLabel(labels, "story"),
            Epic = GetLabel(labels, "epic"),
            Scenario = json.Value<string>("name") ?? "Unnamed scenario",
            FullName = json.Value<string>("fullName") ?? string.Empty,
            Status = NormaliseStatus(json.Value<string>("status") ?? "unknown"),
            Severity = GetLabel(labels, "severity"),
            Owner = GetLabel(labels, "owner"),
            StartTime = start > 0 ? DateTimeOffset.FromUnixTimeMilliseconds(start).LocalDateTime : null,
            DurationSeconds = start > 0 && stop >= start ? Math.Round((stop - start) / 1000d, 2) : 0,
            Description = json.Value<string>("description") ?? string.Empty,
            ErrorMessage = details?.Value<string>("message") ?? string.Empty,
            ErrorTrace = details?.Value<string>("trace") ?? string.Empty,
            SourceJson = Path.GetFileName(resultFile)
        };
        ReadSteps(json["steps"] as JArray, result.Steps, resultsPath, string.Empty, 0);
        ReadAttachments(json["attachments"] as JArray, result.Attachments, resultsPath, "Scenario");
        testResults.Add(result);
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"WARNING: {Path.GetFileName(resultFile)}: {ex.Message}");
        Console.ResetColor();
    }
}

testResults = testResults.OrderBy(x => x.StartTime ?? DateTime.MaxValue).ThenBy(x => x.Feature).ThenBy(x => x.Scenario).ToList();
if (testResults.Count == 0) return 1;

ExecutionSummary summary = BuildSummary(testResults);
List<FeatureSummary> features = BuildFeatures(testResults);
Directory.CreateDirectory(Path.GetDirectoryName(excelFile)!);
Directory.CreateDirectory(Path.GetDirectoryName(pdfFile)!);
if (File.Exists(excelFile)) File.Delete(excelFile);
if (File.Exists(pdfFile)) File.Delete(pdfFile);

string tempFolder = Path.Combine(Path.GetDirectoryName(excelFile)!, "ReportAssets_Temp");
if (Directory.Exists(tempFolder)) Directory.Delete(tempFolder, true);
Directory.CreateDirectory(tempFolder);
PrepareImages(testResults, tempFolder);

Console.WriteLine($"Screenshots detected: {testResults.Sum(x => x.AllAttachments.Count(a => a.IsImage))}");
Console.WriteLine($"Screenshots available: {testResults.Sum(x => x.AllAttachments.Count(a => a.IsImage && a.Exists && File.Exists(a.RenderPath)))}");

string statusChart = Path.Combine(tempFolder, "StatusDistribution.png");
string featureChart = Path.Combine(tempFolder, "FeatureBreakdown.png");
GenerateStatusChart(summary, statusChart);
GenerateFeatureChart(features, featureChart);

using (XLWorkbook workbook = new())
{
    CreateDashboard(workbook, summary, features, statusChart, featureChart);
    CreateSummary(workbook, summary);
    CreateResults(workbook, testResults);
    CreateSteps(workbook, testResults);
    CreateFailures(workbook, testResults);
    CreateFeatureBreakdown(workbook, features);
    CreateScreenshots(workbook, testResults);
    workbook.SaveAs(excelFile);
}
Console.WriteLine($"Excel created: {excelFile}");

QuestPDF.Fluent.Document.Create(document =>
{
    document.Page(page =>
    {
        page.Size(PageSizes.A4.Landscape());
        page.Margin(24);
        page.DefaultTextStyle(x => x.FontSize(8));
        page.Header().Column(c =>
        {
            c.Item().Text("Automation Test Execution Report").FontSize(20).Bold().FontColor(Colors.Blue.Darken2);
            c.Item().Text($"Generated: {summary.GeneratedOn:dd-MMM-yyyy HH:mm:ss}");
        });
        page.Content().PaddingVertical(8).Column(column =>
        {
            column.Spacing(10);
            column.Item().Text("Dashboard").FontSize(16).Bold().FontColor(Colors.Blue.Darken2);
            column.Item().Border(1).BorderColor(Colors.Grey.Lighten1).Padding(8).Row(row =>
            {
                AddMetric(row, "Total", summary.Total.ToString(), Colors.Blue.Darken2);
                AddMetric(row, "Passed", summary.Passed.ToString(), Colors.Green.Darken2);
                AddMetric(row, "Failed", summary.Failed.ToString(), Colors.Red.Darken2);
                AddMetric(row, "Broken", summary.Broken.ToString(), Colors.Orange.Darken2);
                AddMetric(row, "Skipped", summary.Skipped.ToString(), Colors.Grey.Darken2);
                AddMetric(row, "Pass rate", $"{summary.PassRate:0.00}%", Colors.Blue.Darken2);
            });
            column.Item().Row(row =>
            {
                row.RelativeItem().PaddingRight(4).Image(statusChart).FitArea();
                row.RelativeItem().PaddingLeft(4).Image(featureChart).FitArea();
            });
            column.Item().PageBreak();
            column.Item().Text("Scenario Details, Allure Steps and Screenshots").FontSize(16).Bold().FontColor(Colors.Blue.Darken2);

            foreach (AllureTestResult result in testResults)
            {
                column.Item().Border(1).BorderColor(StatusColour(result.Status)).Padding(7).Column(test =>
                {
                    test.Spacing(4);
                    test.Item().Row(row =>
                    {
                        row.RelativeItem().Text($"{result.Feature} - {result.Scenario}").FontSize(11).Bold();
                        row.ConstantItem(70).AlignRight().Text(result.Status).Bold().FontColor(StatusColour(result.Status));
                    });
                    test.Item().Text($"Duration: {FormatDuration(result.DurationSeconds)} | Steps: {result.Steps.Count}");
                    if (!string.IsNullOrWhiteSpace(result.ErrorMessage))
                        test.Item().Background(Colors.Red.Lighten5).Padding(4).Text(Limit(result.ErrorMessage, 1000)).FontColor(Colors.Red.Darken3);

                    if (result.Steps.Count > 0)
                    {
                        test.Item().Text("Allure Steps").Bold().FontColor(Colors.Blue.Darken2);
                        foreach (AllureStep step in result.Steps)
                        {
                            test.Item().PaddingLeft(step.Level * 10).Row(row =>
                            {
                                row.ConstantItem(18).Text(StepSymbol(step.Status)).FontColor(StatusColour(step.Status));
                                row.RelativeItem().Text(step.Name);
                                row.ConstantItem(58).AlignRight().Text(FormatDuration(step.DurationSeconds));
                                row.ConstantItem(52).AlignRight().Text(step.Status).FontColor(StatusColour(step.Status));
                            });
                        }
                    }

                    List<AllureAttachment> screenshots = result.AllAttachments.Where(a => a.IsImage && a.Exists && File.Exists(a.RenderPath)).ToList();
                    if (screenshots.Count > 0)
                    {
                        test.Item().PaddingTop(6).Text("Screenshots").Bold().FontColor(Colors.Blue.Darken2);
                        foreach (AllureAttachment screenshot in screenshots)
                        {
                            test.Item().Text($"{screenshot.StepName} - {screenshot.Name}").Bold();
                            test.Item().MaxHeight(310).Image(screenshot.RenderPath).FitArea();
                        }
                    }
                });
            }
        });
        page.Footer().AlignCenter().Text(x => { x.Span("Page "); x.CurrentPageNumber(); x.Span(" of "); x.TotalPages(); });
    });
}).GeneratePdf(pdfFile);

Console.WriteLine($"PDF created: {pdfFile}");
try { Directory.Delete(tempFolder, true); } catch { }
Console.WriteLine("Excel and PDF reports generated successfully.");
return 0;

static string GetArgument(IReadOnlyList<string> values, string name, string fallback)
{
    for (int i = 0; i < values.Count - 1; i++) if (string.Equals(values[i], name, StringComparison.OrdinalIgnoreCase)) return values[i + 1].Trim('"');
    return fallback;
}

static string GetLabel(JArray labels, string name) => labels.OfType<JObject>().FirstOrDefault(x => string.Equals(x.Value<string>("name"), name, StringComparison.OrdinalIgnoreCase))?.Value<string>("value") ?? string.Empty;
static string NormaliseStatus(string value) => value.Trim().ToLowerInvariant() switch { "passed" => "Passed", "failed" => "Failed", "broken" => "Broken", "skipped" => "Skipped", _ => "Unknown" };

static void ReadSteps(JArray? steps, ICollection<AllureStep> output, string resultsPath, string parent, int level)
{
    if (steps is null) return;
    foreach (JObject json in steps.OfType<JObject>())
    {
        long start = json.Value<long?>("start") ?? 0;
        long stop = json.Value<long?>("stop") ?? start;
        JObject? details = json["statusDetails"] as JObject;
        string name = json.Value<string>("name") ?? "Unnamed step";
        AllureStep step = new()
        {
            Name = name,
            ParentStep = parent,
            Level = level,
            Status = NormaliseStatus(json.Value<string>("status") ?? "unknown"),
            DurationSeconds = start > 0 && stop >= start ? Math.Round((stop - start) / 1000d, 2) : 0,
            ErrorMessage = details?.Value<string>("message") ?? string.Empty
        };
        ReadAttachments(json["attachments"] as JArray, step.Attachments, resultsPath, name);
        output.Add(step);
        ReadSteps(json["steps"] as JArray, output, resultsPath, name, level + 1);
    }
}

static void ReadAttachments(JArray? attachments, ICollection<AllureAttachment> output, string resultsPath, string stepName)
{
    if (attachments is null) return;
    foreach (JObject json in attachments.OfType<JObject>())
    {
        string source = json.Value<string>("source") ?? string.Empty;
        string type = json.Value<string>("type") ?? string.Empty;
        string fullPath = Path.Combine(resultsPath, source);
        output.Add(new AllureAttachment
        {
            Name = json.Value<string>("name") ?? Path.GetFileName(source),
            Source = source,
            Type = type,
            FullPath = fullPath,
            RenderPath = fullPath,
            StepName = stepName,
            Exists = File.Exists(fullPath),
            IsImage = type.StartsWith("image/", StringComparison.OrdinalIgnoreCase)
        });
    }
}

static void PrepareImages(IEnumerable<AllureTestResult> results, string tempFolder)
{
    string folder = Path.Combine(tempFolder, "AllureImages");
    Directory.CreateDirectory(folder);
    foreach (AllureAttachment image in results.SelectMany(x => x.AllAttachments).Where(x => x.IsImage && x.Exists))
    {
        string extension = GetImageExtension(image.Type, image.Name);
        string safeName = string.Concat(Path.GetFileNameWithoutExtension(image.Source).Select(c => Path.GetInvalidFileNameChars().Contains(c) ? '_' : c));
        string destination = Path.Combine(folder, safeName + extension);
        File.Copy(image.FullPath, destination, true);
        image.RenderPath = destination;
    }
}

static string GetImageExtension(string mimeType, string name)
{
    string extension = Path.GetExtension(name);
    if (!string.IsNullOrWhiteSpace(extension)) return extension.ToLowerInvariant();
    return mimeType.ToLowerInvariant() switch { "image/jpeg" or "image/jpg" => ".jpg", "image/gif" => ".gif", "image/bmp" => ".bmp", "image/webp" => ".webp", _ => ".png" };
}

static ExecutionSummary BuildSummary(IReadOnlyCollection<AllureTestResult> results)
{
    int total = results.Count, passed = results.Count(x => x.Status == "Passed"), failed = results.Count(x => x.Status == "Failed"), broken = results.Count(x => x.Status == "Broken"), skipped = results.Count(x => x.Status == "Skipped");
    return new ExecutionSummary { Total = total, Passed = passed, Failed = failed, Broken = broken, Skipped = skipped, Unknown = total - passed - failed - broken - skipped, PassRate = total == 0 ? 0 : Math.Round((double)passed / total * 100, 2), TotalDurationSeconds = results.Sum(x => x.DurationSeconds), TotalSteps = results.Sum(x => x.Steps.Count), ScreenshotCount = results.Sum(x => x.AllAttachments.Count(a => a.IsImage && a.Exists)), GeneratedOn = DateTime.Now };
}

static List<FeatureSummary> BuildFeatures(IEnumerable<AllureTestResult> results) => results.GroupBy(x => x.Feature).Select(g => new FeatureSummary { Feature = g.Key, Total = g.Count(), Passed = g.Count(x => x.Status == "Passed"), Failed = g.Count(x => x.Status == "Failed"), Broken = g.Count(x => x.Status == "Broken"), Skipped = g.Count(x => x.Status == "Skipped"), DurationSeconds = g.Sum(x => x.DurationSeconds) }).OrderByDescending(x => x.Total).ToList();

static void GenerateStatusChart(ExecutionSummary s, string output)
{
    ScottPlot.Plot plot = new();
    double[] values = { s.Passed, s.Failed, s.Broken, s.Skipped, s.Unknown };
    string[] labels = { "Passed", "Failed", "Broken", "Skipped", "Unknown" };
    var pie = plot.Add.Pie(values);
    for (int i = 0; i < pie.Slices.Count; i++) pie.Slices[i].Label = $"{labels[i]}: {values[i]:0}";
    plot.Title("Status Distribution"); plot.ShowLegend(ScottPlot.Alignment.UpperRight); plot.Axes.Frameless(); plot.HideGrid(); plot.SavePng(output, 900, 500);
}

static void GenerateFeatureChart(IReadOnlyCollection<FeatureSummary> source, string output)
{
    List<FeatureSummary> top = source.Take(10).Reverse().ToList();
    ScottPlot.Plot plot = new();
    var bars = plot.Add.Bars(top.Select(x => (double)x.Total).ToArray());
    bars.Horizontal = true;
    for (int i = 0; i < bars.Bars.Count; i++) bars.Bars[i].Label = $"{Shorten(top[i].Feature, 25)}: {top[i].Total}";
    bars.ValueLabelStyle.Bold = true; plot.Title("Top Features by Test Count"); plot.Axes.Margins(left: 0, right: .35); plot.SavePng(output, 1000, 600);
}

static void CreateDashboard(XLWorkbook book, ExecutionSummary summary, IReadOnlyCollection<FeatureSummary> features, string statusChart, string featureChart)
{
    IXLWorksheet ws = book.Worksheets.Add("Dashboard");
    ws.Cell("A1").Value = "Allure Automation Dashboard"; ws.Range("A1:L2").Merge();
    ws.Range("A1:L2").Style.Fill.BackgroundColor = XLColor.FromHtml("#1F4E78"); ws.Range("A1:L2").Style.Font.FontColor = XLColor.White; ws.Range("A1:L2").Style.Font.Bold = true; ws.Range("A1:L2").Style.Font.FontSize = 22; ws.Range("A1:L2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
    string[] labels = { "Total", "Passed", "Failed", "Broken", "Skipped", "Pass Rate" }; object[] values = { summary.Total, summary.Passed, summary.Failed, summary.Broken, summary.Skipped, summary.PassRate / 100 }; string[] colours = { "#4472C4", "#70AD47", "#C00000", "#ED7D31", "#A5A5A5", "#5B9BD5" };
    for (int i = 0; i < 6; i++) { int c = 1 + i * 2; ws.Range(4, c, 4, c + 1).Merge().Value = labels[i]; ws.Range(5, c, 6, c + 1).Merge().Value = XLCellValue.FromObject(values[i]); ws.Range(4, c, 6, c + 1).Style.Fill.BackgroundColor = XLColor.FromHtml(colours[i]); ws.Range(4, c, 6, c + 1).Style.Font.FontColor = XLColor.White; ws.Range(4, c, 6, c + 1).Style.Font.Bold = true; ws.Range(4, c, 6, c + 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; if (i == 5) ws.Range(5, c, 6, c + 1).Style.NumberFormat.Format = "0.00%"; }
    ws.AddPicture(statusChart).MoveTo(ws.Cell("A8")); ws.AddPicture(featureChart).MoveTo(ws.Cell("G8")); ws.Columns("A:L").Width = 14; ws.Column("A").Width = 35;
}

static void CreateSummary(XLWorkbook book, ExecutionSummary s)
{
    IXLWorksheet ws = book.Worksheets.Add("Execution Summary"); ws.Cell("A1").Value = "Automation Test Execution Summary"; ws.Range("A1:D1").Merge(); FormatTitle(ws.Range("A1:D1"));
    ws.Cell("A3").Value = "Generated"; ws.Cell("B3").Value = s.GeneratedOn; ws.Cell("A5").Value = "Metric"; ws.Cell("B5").Value = "Value";
    object[,] data = { { "Total tests", s.Total }, { "Passed", s.Passed }, { "Failed", s.Failed }, { "Broken", s.Broken }, { "Skipped", s.Skipped }, { "Unknown", s.Unknown }, { "Pass rate", s.PassRate / 100 }, { "Combined duration", FormatDuration(s.TotalDurationSeconds) }, { "Total Allure steps", s.TotalSteps }, { "Screenshots", s.ScreenshotCount } };
    for (int i = 0; i < data.GetLength(0); i++) { ws.Cell(6 + i, 1).Value = data[i, 0].ToString(); ws.Cell(6 + i, 2).Value = XLCellValue.FromObject(data[i, 1]); }
    ws.Cell("B12").Style.NumberFormat.Format = "0.00%"; FormatHeader(ws.Range("A5:B5")); ws.Columns().AdjustToContents();
}

static void CreateResults(XLWorkbook book, IReadOnlyCollection<AllureTestResult> results)
{
    IXLWorksheet ws = book.Worksheets.Add("Test Results"); string[] headers = { "No.", "Feature", "Story", "Scenario", "Status", "Start Time", "Duration", "Severity", "Owner", "Steps", "Screenshots", "Error Message", "Source JSON" }; WriteHeaders(ws, headers); int row = 2, no = 1;
    foreach (AllureTestResult x in results) { ws.Cell(row, 1).Value = no++; ws.Cell(row, 2).Value = x.Feature; ws.Cell(row, 3).Value = x.Story; ws.Cell(row, 4).Value = x.Scenario; ws.Cell(row, 5).Value = x.Status; if (x.StartTime.HasValue) ws.Cell(row, 6).Value = x.StartTime.Value; ws.Cell(row, 7).Value = FormatDuration(x.DurationSeconds); ws.Cell(row, 8).Value = x.Severity; ws.Cell(row, 9).Value = x.Owner; ws.Cell(row, 10).Value = x.Steps.Count; ws.Cell(row, 11).Value = x.AllAttachments.Count(a => a.IsImage && a.Exists); ws.Cell(row, 12).Value = x.ErrorMessage; ws.Cell(row, 13).Value = x.SourceJson; ApplyStatus(ws.Cell(row, 5), x.Status); row++; }
    FormatSheet(ws, headers.Length, row - 1); ws.Column(2).Width = 35; ws.Column(4).Width = 60; ws.Column(12).Width = 80;
}

static void CreateSteps(XLWorkbook book, IReadOnlyCollection<AllureTestResult> results)
{
    IXLWorksheet ws = book.Worksheets.Add("Allure Steps"); string[] headers = { "Feature", "Scenario", "Scenario Status", "Step No.", "Level", "Parent Step", "Step", "Step Status", "Duration", "Attachments", "Error Message" }; WriteHeaders(ws, headers); int row = 2;
    foreach (AllureTestResult result in results) { int no = 1; foreach (AllureStep step in result.Steps) { ws.Cell(row, 1).Value = result.Feature; ws.Cell(row, 2).Value = result.Scenario; ws.Cell(row, 3).Value = result.Status; ws.Cell(row, 4).Value = no++; ws.Cell(row, 5).Value = step.Level; ws.Cell(row, 6).Value = step.ParentStep; ws.Cell(row, 7).Value = new string(' ', step.Level * 4) + step.Name; ws.Cell(row, 8).Value = step.Status; ws.Cell(row, 9).Value = FormatDuration(step.DurationSeconds); ws.Cell(row, 10).Value = step.Attachments.Count; ws.Cell(row, 11).Value = step.ErrorMessage; ApplyStatus(ws.Cell(row, 8), step.Status); row++; } }
    FormatSheet(ws, headers.Length, Math.Max(row - 1, 1)); ws.Column(2).Width = 60; ws.Column(7).Width = 80; ws.Column(11).Width = 80;
}

static void CreateFailures(XLWorkbook book, IReadOnlyCollection<AllureTestResult> results)
{
    IXLWorksheet ws = book.Worksheets.Add("Failed Tests"); string[] headers = { "Feature", "Scenario", "Status", "Duration", "Failed Step", "Error Message", "Error Trace" }; WriteHeaders(ws, headers); int row = 2;
    foreach (AllureTestResult result in results.Where(x => x.Status is "Failed" or "Broken")) { List<AllureStep> steps = result.Steps.Where(x => x.Status is "Failed" or "Broken").ToList(); if (steps.Count == 0) steps.Add(new AllureStep { Name = "Scenario failure", Status = result.Status, ErrorMessage = result.ErrorMessage }); foreach (AllureStep step in steps) { ws.Cell(row, 1).Value = result.Feature; ws.Cell(row, 2).Value = result.Scenario; ws.Cell(row, 3).Value = result.Status; ws.Cell(row, 4).Value = FormatDuration(result.DurationSeconds); ws.Cell(row, 5).Value = step.Name; ws.Cell(row, 6).Value = string.IsNullOrWhiteSpace(step.ErrorMessage) ? result.ErrorMessage : step.ErrorMessage; ws.Cell(row, 7).Value = result.ErrorTrace; ApplyStatus(ws.Cell(row, 3), result.Status); row++; } }
    FormatSheet(ws, headers.Length, Math.Max(row - 1, 1)); ws.Column(2).Width = 60; ws.Column(5).Width = 70; ws.Column(6).Width = 90; ws.Column(7).Width = 100;
}

static void CreateFeatureBreakdown(XLWorkbook book, IReadOnlyCollection<FeatureSummary> features)
{
    IXLWorksheet ws = book.Worksheets.Add("Feature Breakdown"); string[] headers = { "Feature", "Total", "Passed", "Failed", "Broken", "Skipped", "Pass Rate", "Duration" }; WriteHeaders(ws, headers); int row = 2;
    foreach (FeatureSummary x in features) { ws.Cell(row, 1).Value = x.Feature; ws.Cell(row, 2).Value = x.Total; ws.Cell(row, 3).Value = x.Passed; ws.Cell(row, 4).Value = x.Failed; ws.Cell(row, 5).Value = x.Broken; ws.Cell(row, 6).Value = x.Skipped; ws.Cell(row, 7).Value = x.Total == 0 ? 0 : (double)x.Passed / x.Total; ws.Cell(row, 7).Style.NumberFormat.Format = "0.00%"; ws.Cell(row, 8).Value = FormatDuration(x.DurationSeconds); row++; }
    FormatSheet(ws, headers.Length, row - 1); ws.Column(1).Width = 50;
}

static void CreateScreenshots(XLWorkbook book, IReadOnlyCollection<AllureTestResult> results)
{
    IXLWorksheet ws = book.Worksheets.Add("Screenshots"); string[] headers = { "Feature", "Scenario", "Status", "Step", "Attachment", "Screenshot" }; WriteHeaders(ws, headers); int row = 2;
    foreach (AllureTestResult result in results)
    {
        foreach (AllureAttachment image in result.AllAttachments.Where(a => a.IsImage && a.Exists && File.Exists(a.RenderPath)))
        {
            ws.Cell(row, 1).Value = result.Feature; ws.Cell(row, 2).Value = result.Scenario; ws.Cell(row, 3).Value = result.Status; ws.Cell(row, 4).Value = image.StepName; ws.Cell(row, 5).Value = image.Name; ApplyStatus(ws.Cell(row, 3), result.Status);
            try
            {
                ws.Row(row).Height = 225;
                var picture = ws.AddPicture(image.RenderPath); picture.MoveTo(ws.Cell(row, 6));
                double scale = Math.Min(1d, Math.Min(picture.Width > 0 ? 360d / picture.Width : 1d, picture.Height > 0 ? 280d / picture.Height : 1d)); picture.Scale(scale);
            }
            catch (Exception ex) { ws.Cell(row, 6).Value = $"Unable to embed screenshot: {ex.Message}"; }
            row++;
        }
    }
    if (row == 2) { ws.Cell("A2").Value = "No screenshot attachments were found."; ws.Range("A2:F2").Merge(); }
    FormatSheet(ws, headers.Length, Math.Max(row - 1, 2)); ws.Column(1).Width = 35; ws.Column(2).Width = 55; ws.Column(4).Width = 65; ws.Column(5).Width = 55; ws.Column(6).Width = 52;
}

static void WriteHeaders(IXLWorksheet ws, IReadOnlyList<string> headers) { for (int i = 0; i < headers.Count; i++) ws.Cell(1, i + 1).Value = headers[i]; }
static void FormatTitle(IXLRange range) { range.Style.Fill.BackgroundColor = XLColor.FromHtml("#1F4E78"); range.Style.Font.FontColor = XLColor.White; range.Style.Font.Bold = true; range.Style.Font.FontSize = 18; }
static void FormatHeader(IXLRange range) { range.Style.Fill.BackgroundColor = XLColor.FromHtml("#1F4E78"); range.Style.Font.FontColor = XLColor.White; range.Style.Font.Bold = true; }
static void FormatSheet(IXLWorksheet ws, int cols, int rows) { FormatHeader(ws.Range(1, 1, 1, cols)); IXLRange range = ws.Range(1, 1, Math.Max(rows, 1), cols); range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin; range.Style.Border.InsideBorder = XLBorderStyleValues.Thin; range.Style.Alignment.WrapText = true; ws.SheetView.FreezeRows(1); if (rows > 1) range.SetAutoFilter(); }
static void ApplyStatus(IXLCell cell, string status) { cell.Style.Font.Bold = true; cell.Style.Fill.BackgroundColor = status switch { "Passed" => XLColor.LightGreen, "Failed" => XLColor.LightPink, "Broken" => XLColor.LightSalmon, "Skipped" => XLColor.LightYellow, _ => XLColor.LightGray }; }
static void AddMetric(RowDescriptor row, string label, string value, string colour) => row.RelativeItem().AlignCenter().Column(c => { c.Item().Text(label).AlignCenter().FontColor(Colors.Grey.Darken2); c.Item().Text(value).AlignCenter().FontSize(14).Bold().FontColor(colour); });
static string StatusColour(string status) => status switch { "Passed" => Colors.Green.Darken2, "Failed" => Colors.Red.Darken2, "Broken" => Colors.Orange.Darken2, "Skipped" => Colors.Grey.Darken2, _ => Colors.Black };
static string StepSymbol(string status) => status switch { "Passed" => "OK", "Failed" => "X", "Broken" => "!", "Skipped" => "-", _ => "?" };
static string FormatDuration(double seconds) { TimeSpan value = TimeSpan.FromSeconds(seconds); return value.TotalHours >= 1 ? $"{(int)value.TotalHours:00}:{value.Minutes:00}:{value.Seconds:00}" : $"{value.Minutes:00}:{value.Seconds:00}"; }
static string Limit(string value, int max) { string cleaned = (value ?? string.Empty).Replace("\r", " ").Replace("\n", " ").Trim(); return cleaned.Length <= max ? cleaned : cleaned[..max] + "..."; }
static string Shorten(string value, int max) => value.Length <= max ? value : value[..max] + "...";

internal sealed class AllureTestResult
{
    public string Id { get; init; } = string.Empty; public string Feature { get; init; } = string.Empty; public string Story { get; init; } = string.Empty; public string Epic { get; init; } = string.Empty; public string Scenario { get; init; } = string.Empty; public string FullName { get; init; } = string.Empty; public string Status { get; init; } = string.Empty; public string Severity { get; init; } = string.Empty; public string Owner { get; init; } = string.Empty; public DateTime? StartTime { get; init; }
    public double DurationSeconds { get; init; }
    public string Description { get; init; } = string.Empty; public string ErrorMessage { get; init; } = string.Empty; public string ErrorTrace { get; init; } = string.Empty; public string SourceJson { get; init; } = string.Empty; public List<AllureStep> Steps { get; } = new(); public List<AllureAttachment> Attachments { get; } = new(); public List<AllureAttachment> AllAttachments => Attachments.Concat(Steps.SelectMany(x => x.Attachments)).ToList();
}
internal sealed class AllureStep { public string Name { get; init; } = string.Empty; public string ParentStep { get; init; } = string.Empty; public int Level { get; init; } public string Status { get; init; } = string.Empty; public double DurationSeconds { get; init; } public string ErrorMessage { get; init; } = string.Empty; public List<AllureAttachment> Attachments { get; } = new(); }
internal sealed class AllureAttachment { public string Name { get; init; } = string.Empty; public string Source { get; init; } = string.Empty; public string Type { get; init; } = string.Empty; public string FullPath { get; init; } = string.Empty; public string RenderPath { get; set; } = string.Empty; public string StepName { get; init; } = string.Empty; public bool Exists { get; init; } public bool IsImage { get; init; } }
internal sealed class ExecutionSummary { public int Total { get; init; } public int Passed { get; init; } public int Failed { get; init; } public int Broken { get; init; } public int Skipped { get; init; } public int Unknown { get; init; } public int TotalSteps { get; init; } public int ScreenshotCount { get; init; } public double PassRate { get; init; } public double TotalDurationSeconds { get; init; } public DateTime GeneratedOn { get; init; } }
internal sealed class FeatureSummary { public string Feature { get; init; } = string.Empty; public int Total { get; init; } public int Passed { get; init; } public int Failed { get; init; } public int Broken { get; init; } public int Skipped { get; init; } public double DurationSeconds { get; init; } }
