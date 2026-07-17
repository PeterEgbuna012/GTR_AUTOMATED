using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;



namespace GTR_AUTOMATED.Pages
{
    
    public sealed class CleanMastPOM
    {

        private readonly IWebDriver driver;
        public CleanMastPOM(IWebDriver drv) => driver = drv;

        public void OpenGoToMenu() =>
            AllureLogger.LogStep("Open [Go To] menu", () =>
                SafeActions.Click(driver, By.Id("titlebar-tb_gotoButton"),
                                  "Go To button"));

        public void WorkOrderMenu() =>
            AllureLogger.LogStep("Open Work Order Menu", () =>
                SafeActions.Click(driver, By.Id("menu0_WO_MODULE_a_tnode"),
                                  "Open Work Order Menu"));

        public void CleanMasterApplicationMXR()
        {
            AllureLogger.LogStep("Launch Clean Master Application (MXR)", () =>
            {
               
                SafeActions.Click(
                    driver,
                    By.Id("menu0_WO_MODULE_sub_changeapp_MXRWOCLEANMASTER_a_tnode"),
                    "Launch Clean Master Application (MXR)"
                );
                Task.Delay(25000).Wait();
            });
        }

        public void FilterTableAllUnit(string All377Unit) =>
            AllureLogger.LogStep($"filter table All 377 unit '{All377Unit}'", () =>
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                // STEP 1: Wait for icon → visible → clickable → click
                By iconLocator = By.Id("m9e1854a7_ns_menu_queryMenuItem_3_a_tnode");
                IWebElement iconElement = wait.Until(SeleniumWaits.ElementIsVisible(iconLocator));
                iconElement = wait.Until(SeleniumWaits.ElementToBeClickable(iconLocator));
                iconElement.Click();

                // Optional brief delay only if UI animates
                Task.Delay(30000).Wait();

                // STEP 2: Wait for filter field → visible → clickable
                By filterFieldLocator = By.CssSelector("#md6723283_tfrow_\\[C\\:3\\]_txt-tb");

                IWebElement filterField =
                    wait.Until(SeleniumWaits.ElementIsVisible(filterFieldLocator));

                filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

                // STEP 3: Interact with filter
                filterField.Click();
                filterField.Clear();
                filterField.SendKeys(All377Unit);
                filterField.SendKeys(Keys.Enter);

                // Allow table refresh (short wait only)
                Task.Delay(25000).Wait();

            });


        public void ViewWorkOrderDetails() =>
           AllureLogger.LogStep("I view work order details", () =>
                SafeActions.Click(driver,
                   By.Id("md6723283_tdrow_[C:0]_tgdet-ti[R:0]_img"),
                   "I view work order details"));

            public void VerifyWorkOrderNumber() =>
           AllureLogger.LogStep("I verify work order number", () =>
           {
               try
               {
                   // Wait 5 seconds for the page or element to load
                   Task.Delay(5000).Wait();

                   // Find the Related Work Order element by CSS selector
                   var relatedWorkOrder = driver.FindElement(By.CssSelector("#m1c7a52f1-tb"));

                   // Get the 'value' attribute of the element
                   string workOrderNumber = relatedWorkOrder.GetAttribute("value");

                   // Check if the work order number is null or empty
                   if (string.IsNullOrEmpty(workOrderNumber))
                   {
                       throw new Exception("Rejectd: Work order number is empty or null.");
                   }

                   // Log success with the work order number
                   Console.WriteLine("Success: Work order number is " + workOrderNumber);
               }
               catch (NoSuchElementException ex)
               {
                   Console.WriteLine("Error: Work order element not found - " + ex.Message);
                   throw;
               }
               catch (Exception ex)
               {
                   Console.WriteLine("Error: " + ex.Message);
                   throw;
               }
           });

           public void TakeScreenshotOfCleanMaster_ViewCleanMasterWorkOrdersTest() =>
         AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CM-001", () =>
         {
              try
              {
                   var takescreenshot = new TakeScreenShotPOM(driver);
                   string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CM-001.png";

                   takescreenshot.TakeScreenshot(driver, successPath);
              }
                   catch (Exception ex)
                   {
                        Console.WriteLine($"Screenshot failed: {ex.Message}");

                        // Attempt fallback screenshot on failure
                        var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CM-001_Failure.png";
                        var takescreenshot = new TakeScreenShotPOM(driver);

                        takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                        // Optional: Rethrow if test should fail
                        throw new Exception("Test failed while taking screenshot.", ex);
                   }
         });

        public void CloseWorkOrderDetails() =>
          AllureLogger.LogStep("I view work order details", () =>
              SafeActions.Click(driver,
                  By.Id("md6723283_tdrow_[C:0]_tgdet-ti[R:0]_img"),
                  "I view work order details"));





        // Clean Master - Complete a Clean Master Work Order POM Steps




        public void FilterTableCleanMaster(string cleanMaster, string cleanMasterDescription)
        {
            AllureLogger.LogStep($"I filter table clean master with values - Clean Master: '{cleanMaster}', Description: '{cleanMasterDescription}'", () =>
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                bool isAnyFilterApplied = false;

                // Filter by Clean Master if provided
                if (!string.IsNullOrWhiteSpace(cleanMaster))
                {
                    var cleanMasterLocator = By.CssSelector("#md6723283_tfrow_\\[C\\:1\\]_txt-tb");
                    var cleanMasterField = wait.Until(SeleniumWaits.ElementToBeClickable(cleanMasterLocator));

                    cleanMasterField.Click();
                    cleanMasterField.Clear();
                    cleanMasterField.SendKeys(cleanMaster);
                    cleanMasterField.SendKeys(Keys.Enter);

                    Console.WriteLine($"🔍 Filter applied on Clean Master: {cleanMaster}");
                    isAnyFilterApplied = true;
                    Task.Delay(3000).Wait();
                }

                // Filter by Description if provided
                if (!string.IsNullOrWhiteSpace(cleanMasterDescription))
                {
                    var descriptionLocator = By.CssSelector("#md6723283_tfrow_\\[C\\:3\\]_txt-tb");
                    var descriptionField = wait.Until(SeleniumWaits.ElementToBeClickable(descriptionLocator));

                    descriptionField.Click();
                    descriptionField.Clear();
                    descriptionField.SendKeys(cleanMasterDescription);
                    descriptionField.SendKeys(Keys.Enter);
                    Task.Delay(60000).Wait();

                    Console.WriteLine($"🔍 Filter applied on Description: {cleanMasterDescription}");
                    isAnyFilterApplied = true;
                    
                }

                if (!isAnyFilterApplied)
                {
                    Console.WriteLine("⚠ No filter value was provided. No action taken.");
                    return;
                }
                
            });
        }




        public void CompleteCleanMasterTask() =>
         AllureLogger.LogStep("I complete clean master task", () =>
         {
             Task.Delay(50000).Wait();
             var locator = By.Id("md6723283_tdrow_[C:9]_hyperlink-lb[R:0]_image");
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
             IWebElement element = wait.Until(SeleniumWaits.ElementToBeClickable(locator));
             element.Click();
             Task.Delay(5000).Wait();
         });

        public void RecompleteCleanMasterTask() =>
        AllureLogger.LogStep("I recomplete clean master task", () =>
        {
            Task.Delay(10000).Wait();
            var locator = By.Id("md6723283_tdrow_[C:9]_hyperlink-lb[R:0]_image");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
            IWebElement element = wait.Until(SeleniumWaits.ElementToBeClickable(locator));
            element.Click();
            Task.Delay(5000).Wait();
        });
        
         public void PressDialogOkButton() =>
          AllureLogger.LogStep("I press dialog Ok  button", () =>
              SafeActions.Click(driver,
                  By.CssSelector("#m88dbf6ce-pb"),
                  "I press dialog Ok  button"));


        public void ConfirmTaskCompletion()
        {
            AllureLogger.LogStep("I confirm task completion", () =>
            {
                try
                {
                    // Wait for 10 seconds to allow the table to load
                    Thread.Sleep(10000);

                    // Find the table rows (adjust selector as needed to match actual table row pattern)
                    var tableRows = driver.FindElements(By.Id("m6798a95d_tdrow_[C:0]-c[R:0]"));

                    // Check if any rows are present
                    if (tableRows == null || tableRows.Count == 0)
                    {
                        throw new Exception("No records found in the table.");
                    }

                    Console.WriteLine($"✅ Success: Table has {tableRows.Count} record(s).");
                }
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine("❌ Error: Table or rows not found - " + ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                    throw;
                }
            });
        }


        public void TakeScreenshotOfCleanMasterCompleteACleanMasterWorkOrderTest() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CM-002", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CM-002.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CM-002_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });






        // Clean Master - Automatically Close a Clean Master Work Order POM Step 



        public void SelectNoRecordFromSearchFieldTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From  Search field Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"nav_search_fld_menu_navSearchItemm7f8f3e49_ns_menu_UTIL_MODULE_sub_MOD11130_HEADER_sub_changeapp_ESCALATION_a_a";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Search field Table Records");
            });

        }



        public void EnterEscalationsTime(string escalationsTime)
        {
            AllureLogger.LogStep($"I enter Escalations time '{escalationsTime}'", () =>
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

                try
                {
                    // Step 1: Click on the icon (adjust selector as needed)
                    By iconLocator = By.CssSelector("#m9163e8f4-img");
                    IWebElement iconElement = wait.Until(SeleniumWaits.ElementToBeClickable(iconLocator));
                    iconElement.Click();
                    Console.WriteLine("✅ Clicked on the icon to activate the time input field.");

                    // Optional: Wait for time field to become visible/clickable
                    By timeFieldLocator = By.CssSelector("#m9a3b6233-tb"); 
                    IWebElement timeField = wait.Until(SeleniumWaits.ElementToBeClickable(timeFieldLocator));

                    // Step 2: Enter value into the time field
                    timeField.Click();
                    timeField.Clear();
                    timeField.SendKeys(escalationsTime);
                    timeField.SendKeys(Keys.Enter);

                    Console.WriteLine($"✅ Entered escalation time: {escalationsTime}");

                    // Optional wait after input
                    Task.Delay(8000).Wait();
                }
                catch (WebDriverTimeoutException ex)
                {
                    Console.WriteLine("❌ Timeout while waiting for icon or field: " + ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error during entering escalation time: " + ex.Message);
                    throw;
                }
            });
        }

          public void ClickOkDailogButton() =>
           AllureLogger.LogStep("I click ok dailog button", () =>
               SafeActions.Click(driver, By.CssSelector("#m7bd6e15a-pb"),
                                 "I click ok dailog button"));



          public void FilterTableWorkOrderTrackingBRDA(string WorkOrderDescription) =>
        AllureLogger.LogStep($"I filter table Work Order Tracking (BRDA) '{WorkOrderDescription}'", () =>
        {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:2\\]_txt-tb");
           IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

           filterField.Click();
           filterField.Clear();
           filterField.SendKeys(WorkOrderDescription);
           filterField.SendKeys(Keys.Enter);
           Task.Delay(8000).Wait();
        });


        public void TakeScreenshotOfCleanMasterAutomaticallyCloseACleanMasterWorkOrderTest() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CM-003", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CM-003.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CM-003_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });





        // Clean Master - Remove Labour Actuals from Clean Master Work Order POM Steps




        public void FilterWorkTypeField(string WorkTypeField) =>
       AllureLogger.LogStep($"I filter Work Type field '{WorkTypeField}'", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           By filterFieldLocator = By.CssSelector("#md6723283_tfrow_\\[C\\:2\\]_txt-tb");
           IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

           filterField.Click();
           filterField.Clear();
           filterField.SendKeys(WorkTypeField);
           filterField.SendKeys(Keys.Enter);
           Task.Delay(8000).Wait();
       });


        public void SelectNoRecordFromCleanMasterTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select record No. {recordNumber} from Clean Master table", () =>
            {
                // Adjust to zero-based index (if needed)
                int rowIndex = recordNumber - 1;

                // Build the correct dynamic ID using the row index
                string selector = $"md6723283_tdrow_[C:0]_tgdet-ti[R:{rowIndex}]_img";

                // Use SafeActions to click the element by ID
                SafeActions.Click(driver, By.Id(selector),
                    $"Clicking record No. {recordNumber} in Clean Master table");
            });
        }


        public void RemoveLaborAssignments()
        {
            AllureLogger.LogStep("I remove labor assignments", () =>
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                By toggleImageLocator = By.Id("m6798a95d_tdrow_[C:7]_toggleimage-ti[R:0]_img");

                // Wait until element is visible and clickable
                IWebElement element = wait.Until(SeleniumWaits.ElementToBeClickable(toggleImageLocator));

                // Scroll the element into view using JavaScript
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);

                // Optionally wait a little after scrolling
                Thread.Sleep(1000);

                // Now click the element using SafeActions
                SafeActions.Click(driver, toggleImageLocator, "I remove labor assignments");
            });
        }


         public void TakeScreenshotOfCleanMasterRemoveLabourActualsFromCleanMasterWorkOrderTest() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CM-004", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CM-004.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CM-004_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });









    }
}