using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;

namespace GTR_AUTOMATED.Pages
{
    
    public sealed class WorkOrderTrackingReportsPOM
    {


        private readonly IWebDriver driver;
        public WorkOrderTrackingReportsPOM(IWebDriver drv) => driver = drv;



          public void WaitForReportPageToLoad() =>
        AllureLogger.LogStep("I wait for Report page to load", () =>
        {
            Task.Delay(10000).Wait();
           
        });

         public void FilterTableReports(string Report) =>
        AllureLogger.LogStep($"I filter table Reports with '{Report}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By filterFieldLocator = By.CssSelector("#mb15db073_tfrow_\\[C\\:0\\]_txt-tb");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(Report);
            filterField.SendKeys(Keys.Enter);
            Task.Delay(3000).Wait();
        });

         public void SelectNoRecordFromReportsTableRecords(int recordNumber)
         {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Reports Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"mb15db073_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Reports Table Records");
                Task.Delay(5000).Wait();
            });
         }


        public void SetRadioImmediateFieldToYes() =>
          AllureLogger.LogStep("I set (Radio) Immediate field to Yes", () =>
              SafeActions.Click(driver, By.CssSelector("#m40f1acbb-rb"),
                                "I set (Radio) Immediate field to Yes"));

         public void SubmitWorkOrderDetailsReport() =>
          AllureLogger.LogStep("I submit Work Order Details Report", () =>
              SafeActions.Click(driver, By.CssSelector("#m2c288cb0-pb"),
                                "I submit Work Order Details Report"));

        public void TakeScreenshotOfWorkOrderDetailsReport()
        {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-01", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-01.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-01_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
        }





        // Campaigns Overview POM Steps Definitions






         public void EnterPeriodCount(string periodcount) =>
        AllureLogger.LogStep($"I period count '{periodcount}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By filterFieldLocator = By.CssSelector("#mfbb63873-ta");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(periodcount);
            Task.Delay(3000).Wait();
        });

         public void SubmitCampaignsOverviewReport() =>
          AllureLogger.LogStep("I submit Work Order Details Report", () =>
              SafeActions.Click(driver, By.CssSelector("#mf5089e1c-pb"),
                                "I submit Work Order Details Report"));

        public void TakeScreenshotOfCampaignsOverview()
        {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-02", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-02.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-02_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
        }





        // Compliance Overview POM Steps Definitions
         




         public void EnterComplianceDetails(string PeriodCount, string AssetGroup) =>
        AllureLogger.LogStep($"I Enter Compliance Details Period Count = '{PeriodCount}', Asset Group = '{AssetGroup}','", () =>
        {
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

             // Adjust column indices as per actual table structure:
             // Description = column 2 → C:2
             // Status = column 10 → C:10

             By PeriodCountFilterLocator = By.CssSelector("#m814e9c-ta");
             By AssetGroupLocator = By.CssSelector("#m84684181-tb");

             IWebElement PeriodCountFilter = wait.Until(SeleniumWaits.ElementToBeClickable(PeriodCountFilterLocator));
            PeriodCountFilter.Click();
            PeriodCountFilter.Clear();
            PeriodCountFilter.SendKeys(PeriodCount);

             IWebElement AssetGroupFilter = wait.Until(SeleniumWaits.ElementToBeClickable(AssetGroupLocator));
            AssetGroupFilter.Click();
            AssetGroupFilter.Clear();
            AssetGroupFilter.SendKeys(AssetGroup);
            Task.Delay(2000).Wait();
        });


         public void SubmitComplianceOverviewReport() =>
          AllureLogger.LogStep("I submit compliance overview report", () =>
              SafeActions.Click(driver, By.CssSelector("#ma862824a-pb"),
                                "I submit compliance overview report"));


         public void TakeScreenshotOfComplianceOverviewReport()
         {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-03", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-03.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-03_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
         }





        // Fleet PM Overview Report POM Steps Definitions



          public void EnterClassOfVehicle(string ClassOfVehicle) =>
        AllureLogger.LogStep($"I enter Class Of Vehicle'{ClassOfVehicle}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By filterFieldLocator = By.CssSelector("#m8a0b5172-tb");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(ClassOfVehicle);
            Task.Delay(3000).Wait();
        });

         public void SubmitFleetPMOverviewReport() =>
          AllureLogger.LogStep("I submit fleet PM overview report", () =>
              SafeActions.Click(driver, By.CssSelector("#m94c3bf9b-pb"),
                                "I submit fleet PM overview report"));


         public void TakeScreenshotOfFleetPMOverviewReport()
         {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-04", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-04.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-04_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
         }





        // Fleet Status Report POM Steps Definitions
        


         public void OpenSelectValueLookupForDepotField() =>
          AllureLogger.LogStep("I open Select Value lookup for Depot field", () =>
              SafeActions.Click(driver, By.CssSelector("#m74e140d5-img"),
                                "I open Select Value lookup for Depot field"));


         public void FilterDepotTable(string Depot) =>
        AllureLogger.LogStep($"I filter Depot table'{Depot}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By filterFieldLocator = By.CssSelector("#lookup_page3_tfrow_\\[C\\:0\\]_txt-tb");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(Depot);
            filterField.SendKeys(Keys.Enter);
            Task.Delay(3000).Wait();
        });


         public void SelectNoRecordFromDepotTableRecords(int recordNumber)
         {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Depot Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page3_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Depot Table Records");
                Task.Delay(5000).Wait();
            });
         }


         public void SubmitFleetStatusReport() =>
          AllureLogger.LogStep("I submit fleet status report", () =>
              SafeActions.Click(driver, By.CssSelector("#m69d08ca8-pb"),
                                "I submit fleet status report"));


         public void TakeScreenshotOfFleetStatusReport()
         {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-05", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-05.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-05_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
         }






        // Frequency Based Maintenance Plan POM Steps Definitions
        
         

          public void SubmitFrequencyBasedMaintenancePlanReport() =>
          AllureLogger.LogStep("I submit frequency based maintenance plan report", () =>
              SafeActions.Click(driver, By.CssSelector("#m248cbb23-pb"),
                                "I submit frequency based maintenance plan report"));


         public void TakeScreenshotOfFrequencyBasedMaintenancePlanReport()
         {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-06", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-06.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-06_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
         }

        public void EnterNextWorkType(string NextWorkType) =>
        AllureLogger.LogStep($"I enter Next Work Type'{NextWorkType}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By filterFieldLocator = By.CssSelector("#mae99d256-ta");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(NextWorkType);
            Task.Delay(3000).Wait();
        });




        // Frequency Based PM Overview Report POM Steps Definitions




        public void EnterWorkType(string WorkType) =>
        AllureLogger.LogStep($"I enter Work Type'{WorkType}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By filterFieldLocator = By.CssSelector("#mecc4da-ta");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(WorkType);
            Task.Delay(3000).Wait();
        });

        public void SubmitFrequencyBasedPMOverviewReport() =>
         AllureLogger.LogStep("I submit Frequency Based PM Overview report", () =>
             SafeActions.Click(driver, By.CssSelector("#m3dca458e-pb"),
                               "I submit Frequency Based PM Overview report"));


         public void TakeScreenshotOfFrequencyBasedPMOverviewReport()
         {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-07", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-07.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-07_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
         }







        // Incompetent Labour Reports POM Steps Definitions



          public void EnterWorkTypeCategory(string WorkType) =>
        AllureLogger.LogStep($"I enter Work Type Category'{WorkType}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By filterFieldLocator = By.CssSelector("#m77b29ebe-tb");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(WorkType);
            Task.Delay(3000).Wait();
        });


         public void EnterStartAndEndDate(string StartDate, string EndDate) =>
        AllureLogger.LogStep($"I Enter Start Date = '{StartDate}', End Date = '{EndDate}','", () =>
        {
             
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
             By StartDateLocator = By.CssSelector("#m293bf868-tb");
             By EndDateLocator = By.CssSelector("#m361e3a38-tb");

             IWebElement StartDateFilter = wait.Until(SeleniumWaits.ElementToBeClickable(StartDateLocator));
            StartDateFilter.Click();
            StartDateFilter.Clear();
            StartDateFilter.SendKeys(StartDate);

             IWebElement EndDateFilter = wait.Until(SeleniumWaits.ElementToBeClickable(EndDateLocator));
            EndDateFilter.Click();
            EndDateFilter.Clear();
            EndDateFilter.SendKeys(EndDate);
            Task.Delay(2000).Wait();
        });


         public void SubmitIncompetentLabourReport() =>
         AllureLogger.LogStep("I submit incompetent labour report", () =>
             SafeActions.Click(driver, By.CssSelector("#mef6dfa18-pb"),
                               "I submit incompetent labour report"));

        public void TakeScreenshotOfIncompetentLabourReports()
        {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-08", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-08.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-08_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
        }






        // Fleet Meter Based PM overview POM Steps Definitions
        
         

         public void EnterClass(string Class) =>
        AllureLogger.LogStep($"I enter Class'{Class}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By filterFieldLocator = By.CssSelector("#mae99d256-ta");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(Class);
            Task.Delay(3000).Wait();
        });

         public void SubmitFrequencyBasedMaintenancePlan() =>
         AllureLogger.LogStep("I submit Frequency Based Maintenance Plan report", () =>
             SafeActions.Click(driver, By.CssSelector("#m248cbb23-pb"),
                               "I submit Frequency Based Maintenance Plan report"));


        public void TakeScreenshotOfFleetMeterBasedPMOverviewReport()
        {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-010", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-010.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-010_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
        }






        // Mobile Work Order Completion Summary Report POM Steps Definitions
        
         
        
         public void SetStartAndEndDate(string StartDate, string EndDate) =>
        AllureLogger.LogStep($"I set Start Date = '{StartDate}', End Date = '{EndDate}','", () =>
        {
             
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
             By StartDateLocator = By.CssSelector("#m62513f62-tb");
             By EndDateLocator = By.CssSelector("#m72b81d1a-tb");

             IWebElement StartDateFilter = wait.Until(SeleniumWaits.ElementToBeClickable(StartDateLocator));
            StartDateFilter.Click();
            StartDateFilter.Clear();
            StartDateFilter.SendKeys(StartDate);

             IWebElement EndDateFilter = wait.Until(SeleniumWaits.ElementToBeClickable(EndDateLocator));
            EndDateFilter.Click();
            EndDateFilter.Clear();
            EndDateFilter.SendKeys(EndDate);
            Task.Delay(2000).Wait();
        });


         public void SubmitMobileWorkOrderCompletionSummaryReport() =>
         AllureLogger.LogStep("I submit mobile work order completion summary report", () =>
             SafeActions.Click(driver, By.CssSelector("#m1a4ac643-pb"),
                               "I submit mobile work order completion summary report"));


         public void TakeScreenshotOfMobileWorkOrderCompletionSummaryReport()
         {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-011", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-011.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-011_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
         }






        // New WO vs Close WO over time POM Steps Definitions
        
         
        
         


          public void SetReportStartAndEndDate(string StartDate, string EndDate) =>
        AllureLogger.LogStep($"I set Start Date = '{StartDate}', End Date = '{EndDate}','", () =>
        {
             
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
             By StartDateLocator = By.CssSelector("#m97e261c4-tb");
             By EndDateLocator = By.CssSelector("#m1244c119-tb");

             IWebElement StartDateFilter = wait.Until(SeleniumWaits.ElementToBeClickable(StartDateLocator));
            StartDateFilter.Click();
            StartDateFilter.Clear();
            StartDateFilter.SendKeys(StartDate);

             IWebElement EndDateFilter = wait.Until(SeleniumWaits.ElementToBeClickable(EndDateLocator));
            EndDateFilter.Click();
            EndDateFilter.Clear();
            EndDateFilter.SendKeys(EndDate);
            Task.Delay(2000).Wait();
        });


         public void EnterReportDetails(string WorkType, string Location) =>
        AllureLogger.LogStep($"I Enter Report Details = '{WorkType}', Location = '{Location}','", () =>
        {
             
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
             By WorkTypeLocator = By.CssSelector("#m4a5d6051-tb");
             By LocationLocator = By.CssSelector("#m4e923103-tb");

             IWebElement WorkTypeFilter = wait.Until(SeleniumWaits.ElementToBeClickable(WorkTypeLocator));
            WorkTypeFilter.Click();
            WorkTypeFilter.Clear();
            WorkTypeFilter.SendKeys(WorkType);

             IWebElement LocationFilter = wait.Until(SeleniumWaits.ElementToBeClickable(LocationLocator));
            LocationFilter.Click();
            LocationFilter.Clear();
            LocationFilter.SendKeys(Location);
            Task.Delay(2000).Wait();
        });


        public void SubmitNewWOVsCloseWOOverTimeReport() =>
        AllureLogger.LogStep("I submit new WO vs close WO over time report", () =>
            SafeActions.Click(driver, By.CssSelector("#m44a4a81-pb"),
                              "I submit new WO vs close WO over time report"));


         public void TakeScreenshotOfNewWOVsCloseWOOverTimeReport()
         {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-012", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-012.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-012_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
         }






        // Work Orders Awaiting Material POM Steps Definitions





        public void EnterReportStartAndEndDate(string StartDate, string EndDate) =>
        AllureLogger.LogStep($"I set Start Date = '{StartDate}', End Date = '{EndDate}','", () =>
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By StartDateLocator = By.CssSelector("#m74dde736-tb");
            By EndDateLocator = By.CssSelector("#m42d24d74-tb");

            IWebElement StartDateFilter = wait.Until(SeleniumWaits.ElementToBeClickable(StartDateLocator));
            StartDateFilter.Click();
            StartDateFilter.Clear();
            StartDateFilter.SendKeys(StartDate);

            IWebElement EndDateFilter = wait.Until(SeleniumWaits.ElementToBeClickable(EndDateLocator));
            EndDateFilter.Click();
            EndDateFilter.Clear();
            EndDateFilter.SendKeys(EndDate);
            Task.Delay(2000).Wait();
        });


          public void EnterLocation(string Location) =>
        AllureLogger.LogStep($"I enter Class'{Location}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By filterFieldLocator = By.CssSelector("#m26a3aa80-tb");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(Location);
            Task.Delay(3000).Wait();
        });


         public void SubmitNumberOfWorkOrdersAwaitingMaterialsAndAverageTimeOpenReport() =>
        AllureLogger.LogStep("I submit Number of Work Orders Awaiting Materials and Average Time Open report", () =>
            SafeActions.Click(driver, By.CssSelector("#m4caa44e5-pb"),
                              "I submit Number of Work Orders Awaiting Materials and Average Time Open report"));


         public void TakeScreenshotOfWorkOrdersAwaitingMaterialReport()
         {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-013", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-013.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-013_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
         }





        // Repeat Failure Report POM Steps Definitions
        
         
        
        

         public void EnterTargetDate(string TargetDate) =>
        AllureLogger.LogStep($"I enter Target Date'{TargetDate}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By filterFieldLocator = By.CssSelector("#m8937c0d7-tb");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(TargetDate);
            Task.Delay(3000).Wait();
        });


        public void EnterRepeatFailureReportDetails(string PeriodCount, string LocationClass) =>
        AllureLogger.LogStep($"I enter repeat failure report details Period Count = '{PeriodCount}', Location Class = '{LocationClass}','", () =>
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By PeriodCountLocator = By.CssSelector("#m1946d2d-ta");
            By LocationClassLocator = By.CssSelector("#me9b43106-ta");

            IWebElement PeriodCountFilter = wait.Until(SeleniumWaits.ElementToBeClickable(PeriodCountLocator));
            PeriodCountFilter.Click();
            PeriodCountFilter.Clear();
            PeriodCountFilter.SendKeys(PeriodCount);

            IWebElement LocationClassFilter = wait.Until(SeleniumWaits.ElementToBeClickable(LocationClassLocator));
            LocationClassFilter.Click();
            LocationClassFilter.Clear();
            LocationClassFilter.SendKeys(LocationClass);
            Task.Delay(2000).Wait();
        });


         public void SubmitFailureReport() =>
        AllureLogger.LogStep("I submit Failure Report", () =>
            SafeActions.Click(driver, By.CssSelector("#m4f12ab46-pb"),
                              "I submit Failure Report"));


         public void TakeScreenshotOfRepeatFailureReport()
         {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-015", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-015.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-015_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
         }





        // Staff Productivity POM Steps Definitions
        
         
        
         



         public void EnterStartDateAndEndDate(string StartDate, string EndDate) =>
        AllureLogger.LogStep($"I enter Start Date = '{StartDate}', End Date = '{EndDate}','", () =>
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By StartDateLocator = By.CssSelector("#m58324139-tb");
            By EndDateLocator = By.CssSelector("#ma4088499-tb");

            IWebElement StartDateFilter = wait.Until(SeleniumWaits.ElementToBeClickable(StartDateLocator));
            StartDateFilter.Click();
            StartDateFilter.Clear();
            StartDateFilter.SendKeys(StartDate);

            IWebElement EndDateFilter = wait.Until(SeleniumWaits.ElementToBeClickable(EndDateLocator));
            EndDateFilter.Click();
            EndDateFilter.Clear();
            EndDateFilter.SendKeys(EndDate);
            Task.Delay(2000).Wait();
        });


         public void SubmitStaffProductivityReport() =>
        AllureLogger.LogStep("I submit Staff Productivity Report", () =>
            SafeActions.Click(driver, By.CssSelector("#mf890a301-pb"),
                              "I submit Staff Productivity Report"));


         public void TakeScreenshotOfStaffProductivityReport()
         {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-017", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-017.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-017_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
         }






        // Total time per exam/block/task POM Steps Definitions
        
         
        
         
         
         public void EnterReportStartDateAndEndDate(string StartDate, string EndDate) =>
        AllureLogger.LogStep($"I enter Start Date = '{StartDate}', End Date = '{EndDate}','", () =>
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By StartDateLocator = By.CssSelector("#m92f130f-tb");
            By EndDateLocator = By.CssSelector("#m3d432b9d-tb");

            IWebElement StartDateFilter = wait.Until(SeleniumWaits.ElementToBeClickable(StartDateLocator));
            StartDateFilter.Click();
            StartDateFilter.Clear();
            StartDateFilter.SendKeys(StartDate);

            IWebElement EndDateFilter = wait.Until(SeleniumWaits.ElementToBeClickable(EndDateLocator));
            EndDateFilter.Click();
            EndDateFilter.Clear();
            EndDateFilter.SendKeys(EndDate);
            Task.Delay(2000).Wait();
        });


         public void SubmitTotalTimePerTaskBlockExamReport() =>
        AllureLogger.LogStep("I submit Total Time per Task Block Exam Report", () =>
            SafeActions.Click(driver, By.CssSelector("#m7626cd-pb"),
                              "I submit Total Time per Task Block Exam Report"));

         public void TakeScreenshotOfTotalTimePerExamBlockTaskReport()
         {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-018", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-018.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-018_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
         }








        // Unit Mileage & Last Service Date  POM Steps Definitions





        public void EnterReportClass(string Class) =>
        AllureLogger.LogStep($"I enter Class'{Class}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By filterFieldLocator = By.CssSelector("#me01fb551-tb");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(Class);
            Task.Delay(3000).Wait();
        });


          public void SubmitUnitMileageLastServiceDateReport() =>
        AllureLogger.LogStep("I submit Unit Mileage & Last Service Date Report", () =>
            SafeActions.Click(driver, By.CssSelector("#m5c1c5c59-pb"),
                              "I submit Unit Mileage & Last Service Date Report"));

          public void TakeScreenshotOfUnitMileageLastServiceDateReport()
          {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-019", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-019.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-019_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
          }





        // Work Undertaken by Individual POM Steps Definitions






         public void IEnterReportStartDateAndEndDate(string StartDate, string EndDate) =>
        AllureLogger.LogStep($"I enter Start Date = '{StartDate}', End Date = '{EndDate}','", () =>
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By StartDateLocator = By.CssSelector("#m5e817516-tb");
            By EndDateLocator = By.CssSelector("#m24435eb5-tb");

            IWebElement StartDateFilter = wait.Until(SeleniumWaits.ElementToBeClickable(StartDateLocator));
            StartDateFilter.Click();
            StartDateFilter.Clear();
            StartDateFilter.SendKeys(StartDate);

            IWebElement EndDateFilter = wait.Until(SeleniumWaits.ElementToBeClickable(EndDateLocator));
            EndDateFilter.Click();
            EndDateFilter.Clear();
            EndDateFilter.SendKeys(EndDate);
            Task.Delay(2000).Wait();
        });


         public void EnterMaintainer(string maintainer) =>
        AllureLogger.LogStep($"I enter maintainer'{maintainer}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By filterFieldLocator = By.CssSelector("#m14df8614-tb");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(maintainer);
            Task.Delay(3000).Wait();
        });


          public void SubmitWorkUndertakenByIndividualReport() =>
        AllureLogger.LogStep("I submit Unit Mileage & Last Service Date Report", () =>
            SafeActions.Click(driver, By.CssSelector("#m7750330b-pb"),
                              "I submit Unit Mileage & Last Service Date Report"));


          public void TakeScreenshotOfWorkUndertakenByIndividualReport()
          {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-020", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-020.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-020_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
          }




        // Work Order List Report POM Steps Definitions
        
         
        
         
         

         public void FilterTableWorkOrder(string WorkType, string Status, string RepairFacility) =>
        AllureLogger.LogStep($"I enter Start Date = '{WorkType}', End Date = '{Status}', Repair Facility = '{RepairFacility}'", () =>
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By WorkTypeLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:4\\]_txt-tb");
            By StatusLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:10\\]_txt-tb");
            By RepairFacilityLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:16\\]_txt-tb");

            IWebElement WorkTypeFilter = wait.Until(SeleniumWaits.ElementToBeClickable(WorkTypeLocator));
            WorkTypeFilter.Click();
            WorkTypeFilter.Clear();
            WorkTypeFilter.SendKeys(WorkType);
            Task.Delay(500).Wait();

            IWebElement StatusFilter = wait.Until(SeleniumWaits.ElementToBeClickable(StatusLocator));
            StatusFilter.Click();
            StatusFilter.Clear();
            StatusFilter.SendKeys(Status);
            Task.Delay(500).Wait();

            IWebElement RepairFacilityFilter = wait.Until(SeleniumWaits.ElementToBeClickable(RepairFacilityLocator));
            RepairFacilityFilter.Click();
            RepairFacilityFilter.Clear();
            RepairFacilityFilter.SendKeys(RepairFacility);
            RepairFacilityFilter.SendKeys(Keys.Enter);
            Task.Delay(10000).Wait();
        });

         public void SubmitWorkOrderListReport() =>
        AllureLogger.LogStep("I submit Work Order List Report", () =>
            SafeActions.Click(driver, By.CssSelector("#m769f9783-pb"),
                              "I submit Work Order List Report"));


          public void TakeScreenshotOfWorkOrderListReport()
          {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-021", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-021.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-021_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
          }






        // Work Arising Report POM Steps Definitions
        
         
        
         
          public void SubmitWorkArisingReport() =>
        AllureLogger.LogStep("I submit Work Arising Report", () =>
            SafeActions.Click(driver, By.CssSelector("#m90b65cc7-pb"),
                              "I submit Work Arising Report"));


          public void TakeScreenshotOfWorkArisingReport()
          {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-022", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-022.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-022_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
          }







        // Work Bank Size Report POM Steps Definitions
        
         
        
         
         public void WorkBankSizeReportDetails(string OwnerGroup, string RepairFacility, string WorkType) =>
        AllureLogger.LogStep($"I enter Work Bank Size Report Details Owner Group = '{OwnerGroup}', Repair Facility = '{RepairFacility}', Work Type = '{WorkType}'", () =>
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By OwnerGroupLocator = By.CssSelector("#m96a131a5-tb");
            By RepairFacilityLocator = By.CssSelector("#mfd21042-ta");
            By WorkTypeLocator = By.CssSelector("#mf4b5fa56-ta");

            IWebElement OwnerGroupFilter = wait.Until(SeleniumWaits.ElementToBeClickable(OwnerGroupLocator));
            OwnerGroupFilter.Click();
            OwnerGroupFilter.Clear();
            OwnerGroupFilter.SendKeys(OwnerGroup);
            Task.Delay(500).Wait();

            IWebElement RepairFacilityFilter = wait.Until(SeleniumWaits.ElementToBeClickable(RepairFacilityLocator));
            RepairFacilityFilter.Click();
            RepairFacilityFilter.Clear();
            RepairFacilityFilter.SendKeys(RepairFacility);
            Task.Delay(500).Wait();

            IWebElement WorkTypeFilter = wait.Until(SeleniumWaits.ElementToBeClickable(WorkTypeLocator));
            WorkTypeFilter.Click();
            WorkTypeFilter.Clear();
            WorkTypeFilter.SendKeys(WorkType);
            Task.Delay(2000).Wait();
        });


         public void SubmitWorkBankSizeSummaryReport() =>
        AllureLogger.LogStep("I submit Work Bank Size Summary Report", () =>
            SafeActions.Click(driver, By.CssSelector("#m23c184bd-pb"),
                              "I submit Work Bank Size Summary Report"));

          public void TakeScreenshotOfWorkBankSizeReport()
          {
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-023", () =>
            {
                try
                {
                    // Store the current window handle
                    string originalWindow = driver.CurrentWindowHandle;

                    // Switch to the newly opened window (report page)
                    foreach (string windowHandle in driver.WindowHandles)
                    {
                        if (windowHandle != originalWindow)
                        {
                            driver.SwitchTo().Window(windowHandle);
                            break;
                        }
                    }

                    // Optional: Wait for the report page to fully load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    wait.Until(drv => ((IJavaScriptExecutor)drv)
                        .ExecuteScript("return document.readyState").Equals("complete"));

                    // Take screenshot
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-023.png";
                    takescreenshot.TakeScreenshot(driver, successPath);

                    // Switch back to the original window if needed
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-023_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
            });
          }


         





    }
}