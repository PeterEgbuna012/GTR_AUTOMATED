using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;

namespace GTR_AUTOMATED.Pages
{
    
    public class FAULTSPOM
    {
        private readonly IWebDriver driver;
        public FAULTSPOM(IWebDriver drv) => driver = drv;


        public void RelationshipFieldHasValueFOLLOWUP() =>
          AllureLogger.LogStep("Relationship field has value FOLLOWUP", () =>
          {

              try
              {
                  // Wait 10 seconds for the page or element to load
                  Task.Delay(10000).Wait();

                  // Find the Status field element by CSS selector (update selector if needed)
                  var statusField = driver.FindElement(By.CssSelector("#ma7e0763-tb"));

                  // Get the 'value' attribute of the element
                  string statusValue = statusField.GetAttribute("value");

                  // Validate the value is "FOLLOWUP"
                  if (string.IsNullOrEmpty(statusValue))
                  {
                      throw new Exception("Status field is empty or null.");
                  }

                  if (statusValue != "FOLLOWUP")
                  {
                      throw new Exception($"Expected status value FOLLOWUP but found '{statusValue}'.");
                  }

                  Console.WriteLine("Success: Status field value is FOLLOWUP.");
              }
              catch (NoSuchElementException ex)
              {
                  Console.WriteLine("Error: Status field not found - " + ex.Message);
                  throw;
              }
              catch (Exception ex)
              {
                  Console.WriteLine("Error: " + ex.Message);
                  throw;
              }

          });

          public void TakeScreenshotOfRaisingAFaultTest() =>
         AllureLogger.LogStep("Capture Screenshot for GTRDFR-REG-001", () =>
         {
             try
             {
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDFR-REG-001.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDFR-REG-001_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });



        //Raising a duplicate Fault in Fault Reporting POM Steps


         public void FilterTableLocation(string location) =>
      AllureLogger.LogStep($"I filter table Location with '{location}'", () =>
      {
          By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
          IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(location);
          filterField.SendKeys(Keys.Enter);
      });



           public void TakeScreenshotOfRaisingADuplicateFaultInFaultReportingTest() =>
         AllureLogger.LogStep("Capture Screenshot for GTRDFR-REG-002", () =>
         {
             try
             {
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDFR-REG-002.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDFR-REG-002_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });



        // Fault Raised and closed by Fault Reporter POM Steps


        public void PressDialogButtonCancel() =>
       AllureLogger.LogStep("I press dialog button cancel", () =>
           SafeActions.Click(driver, By.XPath("//*[@id='mae982abe-pb']"),
                             "I press dialog button cancel"));

        public void SelectAction() =>
       AllureLogger.LogStep("I Select Action", () =>
           SafeActions.Click(driver, By.CssSelector("#toolbar2_tbs_1_tbcb_0_action-tb"),
                             "I Select Action"));

        public void CreateWorkOrderMenu() =>
       AllureLogger.LogStep("I Create Work Order Menu", () =>
           SafeActions.Click(driver, By.Id("menu0_AM160_HEADER_a_tnode"),
                             "I Create Work Order Menu"));


        public void CreateWorkOrderButton() =>
      AllureLogger.LogStep("I Create Work Order Menu", () =>
          SafeActions.Click(driver, By.Id("menu0_AM160_HEADER_sub_CREATEWO_OPTION_a_tnode"),
                            "I Create Work Order Menu"));


          public void DetailMenuOfRepairFacility() =>
       AllureLogger.LogStep("I Create Work Order Menu", () =>
           SafeActions.Click(driver, By.CssSelector("#mafa143a8-img"),
                             "I Create Work Order Menu"));


          public void SelectValueOfRepairFacility() =>
       AllureLogger.LogStep("I Create Work Order Menu", () =>
           SafeActions.Click(driver, By.Id("REPFACILITY_repfacility0_a_tnode"),
                             "I Create Work Order Menu"));

        public void SelectNoFromRepairFacilityTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Repair Facility Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Repair Facility Table Records");
            });

        }


        public void PressDialogButtonOk()
        {
            AllureLogger.LogStep("I press dialog button ok", () =>
                SafeActions.Click(driver, By.XPath("//*[@id='m9868cff1-pb']"),
                     "I press dialog button ok"));
                      Task.Delay(5000).Wait();
        }


        public void TakeScreenshotOfFaultRaisedAndClosedByFaultReporterTest() =>
         AllureLogger.LogStep("Capture Screenshot for GTRDFR-REG-003", () =>
         {
             try
             {
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDFR-REG-003.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDFR-REG-003_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });




        //Complete Fault Work Order Assignments POM Steps


             public void FilterTable(string description, string status) =>
           AllureLogger.LogStep(
                $"I filter PM table with Description = '{description}', Status = '{status}'",
               () =>
               {
                   SafeActions.EnterText(
                      driver,
                      By.XPath("//input[contains(@id,'tfrow_[C:2]_txt-tb')]"),
                      description,
                      "Description Filter");
                       Task.Delay(1000).Wait();

                   SafeActions.EnterText(
                      driver,
                      By.XPath("//input[contains(@id,'tfrow_[C:11]_txt-tb')]"),
                      status,
                      "Status Filter");
                      Task.Delay(1000).Wait();

                     driver.FindElement(
                     By.XPath("//input[contains(@id,'tfrow_[C:11]_txt-tb')]"))
                     .SendKeys(Keys.Enter);
                     Task.Delay(5000).Wait();
               });


            public void GoToLogTab() =>
        AllureLogger.LogStep("I go to Log tab", () =>
             SafeActions.Click(driver, By.Id("m8f3f68c5-tab_anchor"),
                            "I go to Log tab"));


          public void CauseCodes() =>
        AllureLogger.LogStep("I select cause codes", () =>
            SafeActions.Click(driver, By.Id("mc36b05ed_tdrow_[C:0]_ttxt-lb[R:0]"),
                            "I select cause codes"));

          public void RemedyCodes() =>
        AllureLogger.LogStep("I select remedy codes", () =>
        {
            SafeActions.Click(driver, By.Id("mc36b05ed_tdrow_[C:0]_ttxt-lb[R:0]"), "I select remedy codes");
            //Task.Delay(30000).Wait();
        });



        public void TakeScreenshotOfCompleteFaultWorkOrderAssignmentsScenarioOne() =>
         AllureLogger.LogStep("Capture Screenshot for GTRDFR-REG-004SC01", () =>
         {
             try
             {
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDFR-REG-004SC01.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDFR-REG-004SC01_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });


           public void TakeScreenshotOfCompleteFaultWorkOrderAssignmentsScenariotwo() =>
         AllureLogger.LogStep("Capture Screenshot for GTRDFR-REG-004SC02", () =>
         {
             try
             {
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDFR-REG-004SC02.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDFR-REG-004SC02_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });




    }
}