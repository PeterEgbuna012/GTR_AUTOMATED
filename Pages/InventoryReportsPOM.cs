using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;

namespace GTR_AUTOMATED.Pages
{
   
    public sealed class InventoryReportsPOM
    {

        private readonly IWebDriver driver;
        public InventoryReportsPOM(IWebDriver drv) => driver = drv;


        public void FilterTableReports(string Reports) =>
        AllureLogger.LogStep($"I filter table Reports with '{Reports}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By filterFieldLocator = By.CssSelector("#m48482eee_tfrow_\\[C\\:0\\]_txt-tb");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(Reports);
            filterField.SendKeys(Keys.Enter);
            Task.Delay(2000).Wait();
        });


        public void SelectNoRecordFromReportsTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Reports Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m48482eee_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                  $"I Select No {recordNumber} Record From Reports Table Records");
                Task.Delay(8000).Wait();
            });

        }

        public void ISetStartAndEndTime() =>
       AllureLogger.LogStep("Set Scheduled Start and End Date/Time", () =>
       {    // Prepare date and time values
           string todayDate = DateTime.Today.ToString("dd-MM-yyyy");
           string startDate = DateTime.Today.AddDays(-60).ToString("dd-MM-yyyy");
           string endDate = DateTime.Today.AddDays(0).ToString("dd-MM-yyyy");
           string currentTime = DateTime.Now.ToString("HH:mm:ss");

           // Set Start Date
           var startDateLocator = By.CssSelector("#m6538ee78-tb");
           var startDateBox = driver.FindElement(startDateLocator);
           startDateBox.Clear();
           startDateBox.SendKeys(startDate);
           Task.Delay(1000).Wait();
                     
           // Set End Date
           var endDateLocator = By.CssSelector("#md42eac63-tb");
           var endDateBox = driver.FindElement(endDateLocator);
           endDateBox.Clear();
           endDateBox.SendKeys(endDate);
           Task.Delay(1000).Wait();
                    
       });

           public void SubmitFirstTimePickrateReport() =>
         AllureLogger.LogStep("I submit First time Pickrate Report", () =>
               SafeActions.Click(driver, By.CssSelector("#m3bd3ab92-pb"),
                     "I submit First time Pickrate Report"));

        public void TakeScreenshotOfInterDepotTransfer() =>
      AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-024", () =>
      {
          try
          {
              string screenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-024.png";
              string failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-024_Failure.png";

              var takescreenshot = new TakeScreenShotPOM(driver);
              string originalWindow = driver.CurrentWindowHandle;

              // Wait until a new window is available
              WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
              wait.Until(d => d.WindowHandles.Count > 1);

              // Switch to the new window
              foreach (var handle in driver.WindowHandles)
              {
                  if (handle != originalWindow)
                  {
                      driver.SwitchTo().Window(handle);
                      break;
                  }
              }

              // Take the screenshot in the new window
              takescreenshot.TakeScreenshot(driver, screenshotPath);

              // Optional: Switch back to the original window
              driver.SwitchTo().Window(originalWindow);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-024_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });





        // FOS Report POM Step Definitions




          public void EnterItemNumber(string ItemNumber) =>
        AllureLogger.LogStep($"I enter Item number '{ItemNumber}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By filterFieldLocator = By.CssSelector("#maa2cebf4-tb");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(ItemNumber);
            Task.Delay(2000).Wait();
        });


        public void SubmitFOSReport() =>
        AllureLogger.LogStep("I submit FOS Report", () =>
              SafeActions.Click(driver, By.CssSelector("#m585ee09-pb"),
                    "I submit FOS Report"));

        public void TakeScreenshotOfFOSReportTest() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-200SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-200SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-200SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void ITakeScreenshotOfFOSReportTest() =>
      AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-025", () =>
      {
          try
          {
              string screenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-025.png";
              string failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-025_Failure.png";

              var takescreenshot = new TakeScreenShotPOM(driver);
              string originalWindow = driver.CurrentWindowHandle;

              // Wait until a new window is available
              WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
              wait.Until(d => d.WindowHandles.Count > 1);

              // Switch to the new window
              foreach (var handle in driver.WindowHandles)
              {
                  if (handle != originalWindow)
                  {
                      driver.SwitchTo().Window(handle);
                      break;
                  }
              }

              // Take the screenshot in the new window
              takescreenshot.TakeScreenshot(driver, screenshotPath);

              // Optional: Switch back to the original window
              driver.SwitchTo().Window(originalWindow);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-025_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });






        //  Historic Stock Value Report POM Step Definitions



         public void FilterTableHistoricStockReportStoreroom(string Storeroom) =>
       AllureLogger.LogStep($"I filter table Historic Stock Report Storeroom with '{Storeroom}'", () =>
       {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By filterFieldLocator = By.CssSelector("#m50c9c46a-ta");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

           filterField.Click();
           filterField.Clear();
           filterField.SendKeys(Storeroom);
          
       });



        public void SetStartDateAndEndDate() =>
       AllureLogger.LogStep("Set Scheduled Start and End Date/Time", () =>
       {    // Prepare date and time values
           string todayDate = DateTime.Today.ToString("dd-MM-yyyy");
           string startDate = DateTime.Today.AddDays(-60).ToString("dd-MM-yyyy");
           string endDate = DateTime.Today.AddDays(0).ToString("dd-MM-yyyy");
           string currentTime = DateTime.Now.ToString("HH:mm:ss");

           // Set Start Date
           var startDateLocator = By.CssSelector("#m38ac9b10-tb");
           var startDateBox = driver.FindElement(startDateLocator);
           startDateBox.Clear();
           startDateBox.SendKeys(startDate);
           Task.Delay(1000).Wait();

           // Set End Date
           var endDateLocator = By.CssSelector("#ma7a6010-tb");
           var endDateBox = driver.FindElement(endDateLocator);
           endDateBox.Clear();
           endDateBox.SendKeys(endDate);
           Task.Delay(1000).Wait();

       });


        public void SelectNoRecordFromStoreroomTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From storeroom Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m48482eee_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                  $"I Select No {recordNumber} Record From storeroom Table Records");
                Task.Delay(5000).Wait();
            });

        }


         public void SubmitHistoricStockValueReport() =>
        AllureLogger.LogStep("I submit Historic Stock Value Report", () =>
              SafeActions.Click(driver, By.CssSelector("#mf779ab0c-pb"),
                    "I submit Historic Stock Value Report"));


         public void TakeScreenshotOfHistoricStockValueReportTest() =>
      AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-026", () =>
      {
          try
          {
              string screenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-026.png";
              string failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-026_Failure.png";

              var takescreenshot = new TakeScreenShotPOM(driver);
              string originalWindow = driver.CurrentWindowHandle;

              // Wait until a new window is available
              WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
              wait.Until(d => d.WindowHandles.Count > 1);

              // Switch to the new window
              foreach (var handle in driver.WindowHandles)
              {
                  if (handle != originalWindow)
                  {
                      driver.SwitchTo().Window(handle);
                      break;
                  }
              }

              // Take the screenshot in the new window
              takescreenshot.TakeScreenshot(driver, screenshotPath);

              // Optional: Switch back to the original window
              driver.SwitchTo().Window(originalWindow);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-026_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });





        // Inventory ABC Analysis Report POM Step Definitions




         public void EnterStoreroom(string Storeroom) =>
       AllureLogger.LogStep($"I enter Storeroom'{Storeroom}'", () =>
       {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By filterFieldLocator = By.CssSelector("#m861cadf8-tb");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

           filterField.Click();
           filterField.Clear();
           filterField.SendKeys(Storeroom);
          
       });


         public void SubmitInventoryABCAnalysisReport() =>
        AllureLogger.LogStep("I submit Inventory ABC Analysis Report", () =>
              SafeActions.Click(driver, By.CssSelector("#m5577cf42-pb"),
                    "I submit Inventory ABC Analysis Report"));


          public void TakeScreenshotOfInventoryABCAnalysisReportTest() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-027", () =>
       {
           string screenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-027.png";
           string failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-027_Failure.png";

           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string originalWindow = driver.CurrentWindowHandle;

               // Wait until a new window opens
               WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
               wait.Until(d => d.WindowHandles.Count > 1);

               // Switch to the new window
               string reportWindow = driver.WindowHandles.First(h => h != originalWindow);
               driver.SwitchTo().Window(reportWindow);

               // Optional: wait for the report page to fully load
               Thread.Sleep(3000); // or better: wait for a specific element

               // Maximize window to try to capture more of the page
               driver.Manage().Window.Maximize();

               // Take the screenshot
               takescreenshot.TakeScreenshot(driver, screenshotPath);

               // Switch back to original window
               driver.SwitchTo().Window(originalWindow);
               }
               catch (Exception ex)
               {
                  Console.WriteLine($"Screenshot failed: {ex.Message}");

                  // Fallback screenshot in original window
                 var takescreenshot = new TakeScreenShotPOM(driver);
                  takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                  throw new Exception("Test failed while taking screenshot.", ex);
               }
       });





        //Inventory Balance Report POM Step Definitions





        public void EnterInventoryBalanceReportStoreroom(string Storeroom) =>
       AllureLogger.LogStep($"I enter Inventory Balance Report Storeroom'{Storeroom}'", () =>
       {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By filterFieldLocator = By.CssSelector("#m914b0577-ta");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

           filterField.Click();
           filterField.Clear();
           filterField.SendKeys(Storeroom);
          
       });


         public void SubmitInventoryBalanceReport() =>
        AllureLogger.LogStep("I submit Inventory Balance Report", () =>
              SafeActions.Click(driver, By.CssSelector("#ma78b8a47-pb"),
                    "I submit Inventory Balance Report"));


         public void TakeScreenshotOfInventoryBalanceReport() =>
      AllureLogger.LogStep("Capture Screenshot for GTRDWM-REP-029", () =>
      {
          try
          {
              string screenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REP-029.png";
              string failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-029_Failure.png";

              var takescreenshot = new TakeScreenShotPOM(driver);
              string originalWindow = driver.CurrentWindowHandle;

              // Wait until a new window is available
              WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
              wait.Until(d => d.WindowHandles.Count > 1);

              // Switch to the new window
              foreach (var handle in driver.WindowHandles)
              {
                  if (handle != originalWindow)
                  {
                      driver.SwitchTo().Window(handle);
                      break;
                  }
              }

              // Take the screenshot in the new window
              takescreenshot.TakeScreenshot(driver, screenshotPath);

              // Optional: Switch back to the original window
              driver.SwitchTo().Window(originalWindow);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REP-029_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });


    }
}