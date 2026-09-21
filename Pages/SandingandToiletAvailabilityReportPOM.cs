using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using Reqnroll;
using GivenAttribute = Reqnroll.GivenAttribute;
using OpenQA.Selenium.Support.UI;

namespace GTR_AUTOMATED.Pages
{
    [Binding]
    public sealed class SandingandToiletAvailabilityReportPOM
    {

          private readonly IWebDriver driver;
          public SandingandToiletAvailabilityReportPOM(IWebDriver drv) => driver = drv;


          public void FilterReportsTableRecords(string Reports) =>
          AllureLogger.LogStep($"I filter table Reports with '{Reports}'", () =>
          {
              WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
              By filterFieldLocator = By.CssSelector("#m8ae1a17c_tfrow_\\[C\\:0\\]_txt-tb");
              IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));
               filterField.Click();
              filterField.Clear();
              filterField.SendKeys(Reports);
              filterField.SendKeys(Keys.Enter);
              Task.Delay(3000).Wait();
          });

          public void SelectNoRecordFromSandingReportsTableRecords(int recordNumber)
          {
              AllureLogger.LogStep($"I Select No {recordNumber} Record From Reports Table Records", () =>
              {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m8ae1a17c_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Reports Table Records");
                Task.Delay(5000).Wait();
              });
          }

        public void EnterArea(string area) =>
          AllureLogger.LogStep($"I enter Area '{area}'", () =>
          {
               WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
               By areaFieldLocator = By.XPath("//label[contains(normalize-space(.),'Area:')]/ancestor::td/following-sibling::td//input");
               IWebElement areaField = wait.Until(SeleniumWaits.ElementToBeClickable(areaFieldLocator));
               areaField.Click();
               areaField.Clear();
               areaField.SendKeys(area);
               Task.Delay(3000).Wait();
          });

          public void SubmitSandingReport() =>
          AllureLogger.LogStep("I submit Sanding Report", () =>
               SafeActions.Click(driver,
                    By.XPath("//button[normalize-space()='Submit']"),
                    "I submit Sanding Report"));

          public void TakeScreenshotOfSandingReport()
          {
              AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-01", () =>
              {
                  try
                  {

                    string originalWindow = driver.CurrentWindowHandle;

                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));

                    // Wait for the report window/tab to open
                    wait.Until(drv => drv.WindowHandles.Count > 1);

                    // Get the newly opened report window
                    string reportWindow = driver.WindowHandles
                        .First(handle => handle != originalWindow);

                    // Switch to report window
                    driver.SwitchTo().Window(reportWindow);

                    // Maximise the window for a full report screenshot
                    driver.Manage().Window.Maximize();

                    // Wait for page load completion
                    wait.Until(drv =>
                        ((IJavaScriptExecutor)drv)
                            .ExecuteScript("return document.readyState")
                            .ToString()
                            .Equals("complete"));

                    // Ensure the report body is visible
                    wait.Until(drv => drv.FindElement(By.TagName("body")).Displayed);

                    // Take screenshot
                    var takeScreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-01.png";

                    takeScreenshot.TakeScreenshot(driver, successPath);

                    Console.WriteLine($"Screenshot saved: {successPath}");

                    // Return to the original window
                    driver.SwitchTo().Window(originalWindow);
                  }
                  catch (Exception ex)
                  {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");


                    var takeScreenshot = new TakeScreenShotPOM(driver);
                    string failurePath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-01_Failure.png";

                    takeScreenshot.TakeScreenshot(driver, failurePath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                  }
              });
          }



        //Toilet Availability Report POM Steps Definitions



          public void FilterReports(string Reports) =>
          AllureLogger.LogStep($"I filter table Reports with '{Reports}'", () =>
          {
              WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
              By filterFieldLocator = By.CssSelector("#m63dd11df_tfrow_\\[C\\:0\\]_txt-tb");
              IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));
              filterField.Click();
              filterField.Clear();
              filterField.SendKeys(Reports);
              filterField.SendKeys(Keys.Enter);
              Task.Delay(3000).Wait();
          });


          public void SelectNoRecordFromTrainToiletAvailabilityReportsTableRecords(int recordNumber)
          {
              AllureLogger.LogStep($"I Select No {recordNumber} Record From Reports Table Records", () =>
              {
                  // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                  int zeroBasedIndex = recordNumber - 1;

                  // Build dynamic Id selector by replacing the row index [R:x]
                  string selector = $"m63dd11df_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                  SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Reports Table Records");
                  Task.Delay(5000).Wait();
              });
          }

          public void SubmitReport() =>
          AllureLogger.LogStep("I submit Report", () =>
              SafeActions.Click(driver,
                 By.XPath("//button[normalize-space()='Submit']"),
                 "I submit Report"));

          public void TakeScreenshotOfToiletAvailabilityReport()
          {
              AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-02", () =>
              {
                  try
                  {

                    string originalWindow = driver.CurrentWindowHandle;

                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));

                    // Wait for the report window/tab to open
                    wait.Until(drv => drv.WindowHandles.Count > 1);

                    // Get the newly opened report window
                    string reportWindow = driver.WindowHandles
                        .First(handle => handle != originalWindow);

                    // Switch to report window
                    driver.SwitchTo().Window(reportWindow);

                    // Maximise the window for a full report screenshot
                    driver.Manage().Window.Maximize();

                    // Wait for page load completion
                    wait.Until(drv =>
                        ((IJavaScriptExecutor)drv)
                            .ExecuteScript("return document.readyState")
                            .ToString()
                            .Equals("complete"));

                    // Ensure the report body is visible
                    wait.Until(drv => drv.FindElement(By.TagName("body")).Displayed);

                    // Take screenshot
                    var takeScreenshot = new TakeScreenShotPOM(driver);
                    string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-02.png";

                    takeScreenshot.TakeScreenshot(driver, successPath);

                    Console.WriteLine($"Screenshot saved: {successPath}");

                    // Return to the original window
                    driver.SwitchTo().Window(originalWindow);
                  }
                  catch (Exception ex)
                  {
                    Console.WriteLine($"Screenshot failed: {ex.Message}");


                    var takeScreenshot = new TakeScreenShotPOM(driver);
                    string failurePath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-02_Failure.png";

                    takeScreenshot.TakeScreenshot(driver, failurePath);

                     throw new Exception("Test failed while taking screenshot.", ex);
                  }
              });
          }



    }
}