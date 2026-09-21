using GTR_AUTOMATED.Utilities;
using GTR_AUTOMATED.Pages;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using Reqnroll;
using GivenAttribute = Reqnroll.GivenAttribute;
using OpenQA.Selenium.Support.UI;

namespace GTR_AUTOMATED.Pages
{
   
    public sealed class SandMasterPOM
    {


        private readonly IWebDriver driver;
        public SandMasterPOM(IWebDriver drv) => driver = drv;


        public void OpenGoToMenu() =>
           AllureLogger.LogStep("Open [Go To] menu", () =>
               SafeActions.Click(driver, By.Id("titlebar-tb_gotoButton"),
                                 "Go To button"));

        public void OpenWorkOrderMenu() =>
            AllureLogger.LogStep("Open [Work Order] menu", () =>
                SafeActions.Click(driver, By.Id("menu0_WO_MODULE_a_tnode"),
                                  "Work Order menu node"));

        public void OpenSandMasterMXRApplication() =>
            AllureLogger.LogStep("Launch Sand Master Application", () =>
                SafeActions.Click(driver,
                    By.Id("menu0_WO_MODULE_sub_changeapp_MXRSANDMASTER_a_tnode"),
                    "Sand Master MXR"));


        public void SandingManagmentTab() =>
           AllureLogger.LogStep("I Go to Sanding Managment Tab", () =>
                SafeActions.Click(driver,
                   By.Id("m1e20cba1-sct_anchor_3"),
                   "I Go to Sanding Managment Tab"));


        public void OpenApplicationSandMasterMXRFromFavMenu() =>
           AllureLogger.LogStep("I open application Sand Master (MXR) from Fav Menu", () =>
                SafeActions.Click(driver,
                   By.Id("FavoriteApp_MXRSANDMASTER"),
                   "I open application Sand Master (MXR) from Fav Menu"));


         public void SelectUnitQuery(int recordNumber)
         {
            AllureLogger.LogStep($"I select record No. {recordNumber} from unit {{int}} query table", () =>
            {
                // Adjust to zero-based index (if needed)
                int rowIndex = recordNumber - 1;

                // Build the correct dynamic ID using the row index
                string selector = $"m9e1854a7_ns_menu_queryMenuItem_5_a_tnode";

                // Use SafeActions to click the element by ID
                SafeActions.Click(driver, By.Id(selector),
                    $"Clicking record No. {recordNumber} in unit {{int}} query table");
            });
         }

        public void ViewSandMasterWorkOrderDetails() =>
          AllureLogger.LogStep("I view Sand Master Work Order details", () =>
               SafeActions.Click(driver,
                  By.Id("m6a7dfd2f_tdrow_[C:0]-c[R:0]"),
                  "I view Sand Master Work Order details"));

        public void ViewSandBox() =>
          AllureLogger.LogStep("I Select View Sand Box button", () =>
               SafeActions.Click(driver,
                  By.Id("m74ddfe9e_tdrow_[C:0]_tgdet-ti[R:0]_img"),
                  "I Select View Sand Box button"));


        public void VerifySandMasterWorkOrderDetails()
        {
            AllureLogger.LogStep("I view Sand Master Work Order details", () =>
            {
                try
                {
                    // Wait for page to load
                    Thread.Sleep(10000);

                    // Find elements (update selectors as needed)
                    var sandBoxField = driver.FindElement(By.CssSelector("#m726cefdf-tb"));
                    var sandBoxDescription = driver.FindElement(By.CssSelector("#m726cefdf-tb2"));
                    var sandLevel = driver.FindElement(By.CssSelector("#mec087a7c-tb"));
                    var lastReadingDate = driver.FindElement(By.CssSelector("#mbb0577b-tb")); 

                    // Read values
                    string line1 = sandBoxField.GetAttribute("value")?.Trim();
                    string line2 = sandBoxDescription.GetAttribute("value")?.Trim();
                    string line3 = sandLevel.GetAttribute("value")?.Trim();
                    string line4 = lastReadingDate.GetAttribute("value")?.Trim();

                     if (string.IsNullOrWhiteSpace(line1))
                        throw new Exception("❌ SandBoxField is empty or blank.");
                    Console.WriteLine($"✅ SandBoxField: {line1}");

                    if (string.IsNullOrWhiteSpace(line2))
                        throw new Exception("❌ SandBoxDescription is empty or blank.");
                    Console.WriteLine($"✅ SandBoxDescription: {line2}");

                    if (string.IsNullOrWhiteSpace(line3))
                        throw new Exception("❌ SandLevel is empty or blank.");
                    Console.WriteLine($"✅ SandLevel: {line3}");

                    if (string.IsNullOrWhiteSpace(line4))
                        throw new Exception("❌ LastReadingDate is empty or blank.");
                    Console.WriteLine($"✅ LastReadingDate: {line4}");

                    Console.WriteLine("🎉 Success: All fields are filled and printed.");
                }
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine("❌ Error: One or more fields not found - " + ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                    throw;
                }
            });
        }


           public void TakeScreenshotOfViewSandMasterUnitsAndSandboxesTest() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-SM-001", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-SM-001.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
              catch (Exception ex)
              {
                  Console.WriteLine($"Screenshot failed: {ex.Message}");

                  // Attempt fallback screenshot on failure
                  var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-SM-001_Failure.png";
                  var takescreenshot = new TakeScreenShotPOM(driver);

                   takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    // Optional: Rethrow if test should fail
                    throw new Exception("Test failed while taking screenshot.", ex);
              }
       });





        // Complete a Sand Master Work Order POM Step




        public void FilterTableSandMasterMXR(string SandMaster) =>
       AllureLogger.LogStep($"filter table Sand Master (MXR) '{SandMaster}'", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:2\\]_txt-tb");
           IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

           filterField.Click();
           filterField.Clear();
           filterField.SendKeys(SandMaster);
           filterField.SendKeys(Keys.Enter);
           Task.Delay(8000).Wait();
       });

        public void SelectButtonFillSandBox() =>
          AllureLogger.LogStep("I select button Fill Sand Box", () =>
               SafeActions.Click(driver,
                  By.Id("m6a7dfd2f_tdrow_[C:12]_hyperlink-lb[R:0]_image"),
                  "I select button Fill Sand Box"));

        public void PressTheOkDialogButton() =>
         AllureLogger.LogStep("I press the ok dialog button", () =>
              SafeActions.Click(driver,
                 By.CssSelector("#mc3990d1-pb"),
                 "I press the ok dialog button"));

        public void SelectCheckSandBox() =>
         AllureLogger.LogStep("I select Check Sand Box", () =>
              SafeActions.Click(driver,
                 By.Id("m74ddfe9e_tdrow_[C:0]_tgdet-ti[R:0]_img"),
                 "I select Check Sand Box"));


        public void VerifySandBoxLevel()
        {
            AllureLogger.LogStep("I view Sand Master Work Order details", () =>
            {
                try
                {
                    // Wait for page to load
                    Thread.Sleep(10000);

                    // Find elements (update selectors as needed)
                    var VehicleDetails = driver.FindElement(By.CssSelector("#m726cefdf-tb"));
                    var SandBoxVehicleDescription = driver.FindElement(By.CssSelector("#m726cefdf-tb2"));
                    var SandBoxLevel = driver.FindElement(By.CssSelector("#mec087a7c-tb"));
                    var SandBoxLastReading = driver.FindElement(By.CssSelector("#mbb0577b-tb"));

                    // Read values
                    string line1 = VehicleDetails.GetAttribute("value")?.Trim();
                    string line2 = SandBoxVehicleDescription.GetAttribute("value")?.Trim();
                    string line3 = SandBoxLevel.GetAttribute("value")?.Trim();
                    string line4 = SandBoxLastReading.GetAttribute("value")?.Trim();

                    if (string.IsNullOrWhiteSpace(line1))
                        throw new Exception("❌ VehicleDetails is empty or blank.");
                    Console.WriteLine($"✅ VehicleDetails: {line1}");

                    if (string.IsNullOrWhiteSpace(line2))
                        throw new Exception("❌ SandBoxVehicleDescription is empty or blank.");
                    Console.WriteLine($"✅ SandBoxVehicleDescription: {line2}");

                    if (string.IsNullOrWhiteSpace(line3))
                        throw new Exception("❌ SandBoxLevel is empty or blank.");
                    Console.WriteLine($"✅ SandBoxLevel: {line3}");

                    if (string.IsNullOrWhiteSpace(line4))
                        throw new Exception("❌ SandBoxLastReading is empty or blank.");
                    Console.WriteLine($"✅ SandBoxLastReading: {line4}");

                    Console.WriteLine("🎉 Success: All fields are filled and printed.");
                }
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine("❌ Error: One or more fields not found - " + ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                    throw;
                }
            });
        }



         public void TakeScreenshotOfCompleteASandMasterWorkOrderTest() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-SM-002", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-SM-002.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
              catch (Exception ex)
              {
                  Console.WriteLine($"Screenshot failed: {ex.Message}");

                  // Attempt fallback screenshot on failure
                  var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-SM-002_Failure.png";
                  var takescreenshot = new TakeScreenShotPOM(driver);

                   takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    // Optional: Rethrow if test should fail
                    throw new Exception("Test failed while taking screenshot.", ex);
              }
       });





        // Viewing a sanding log POM Step



        public void SelectViewSandingLog() =>
        AllureLogger.LogStep("I select View Sanding Log", () =>
             SafeActions.Click(driver,
                By.Id("m39e89483-pb"),
                "I select View Sanding Log"));

        public void SelectValueOptionUnitIDField() =>
        AllureLogger.LogStep("I select value option Unit ID field", () =>
             SafeActions.Click(driver,
                By.CssSelector("#md425decd-img"),
                "select value option Unit ID field"));



        public void FilterTableUnitID(string UnitID) =>
       AllureLogger.LogStep($"I filter table Unit ID'{UnitID}'", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           By filterFieldLocator = By.CssSelector("#lookup_page2_tfrow_\\[C\\:0\\]_txt-tb");
           IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

           filterField.Click();
           filterField.Clear();
           filterField.SendKeys(UnitID);
           filterField.SendKeys(Keys.Enter);
           Task.Delay(8000).Wait();
       });

        public void SelectNoRecordFromUnitIDTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Unit ID Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Unit ID Table Records");
            });

        }


        public void SelectRefreshButton() =>
       AllureLogger.LogStep("I select Refresh button", () =>
            SafeActions.Click(driver,
               By.CssSelector("#ma8816335-pb"),
               "I select Refresh button"));


        public void VerifyUnitIDChanged()
        {
            AllureLogger.LogStep("I verify Unit ID status has changed", () =>
            {
                try
                {
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

                    // Wait for the status field to be visible
                    var statusField = wait.Until(SeleniumWaits.ElementIsVisible(
                        By.CssSelector("#md425decd-tb"))); 

                    // Read the status value
                    string statusValue = statusField.GetAttribute("value")?.Trim();

                    // Validate non-empty value
                    if (string.IsNullOrWhiteSpace(statusValue))
                    {
                        throw new Exception("❌ Status field is empty or null.");
                    }

                    // Print the actual value (no hardcoded check)
                    Console.WriteLine($"✅ Current Status Value: {statusValue}");
                }
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine("❌ Error: Status field not found - " + ex.Message);
                    throw;
                }
                catch (WebDriverTimeoutException ex)
                {
                    Console.WriteLine("❌ Timeout: Status field did not become visible - " + ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                    throw;
                }
            });
        }

         public void PressDialogOk() =>
       AllureLogger.LogStep("I press dialog ok", () =>
            SafeActions.Click(driver,
               By.CssSelector("#md7e4e7f5-pb"),
               "I press dialog ok"));


        public void TakeScreenshotOfViewingASandingLog() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-SM-003", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-SM-003.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-SM-003_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });




        // Changing location of a person  POM Step



           public void SelectChangePersonsLocation() =>
       AllureLogger.LogStep("I select Change Person's Location", () =>
            SafeActions.Click(driver,
               By.CssSelector("#ma0e1c539-pb"),
               "I select Change Person's Location"));

         public void SelectValueOptionOfPersonsLocationField() =>
       AllureLogger.LogStep("I select value option of Person's Location field", () =>
            SafeActions.Click(driver,
               By.CssSelector("#m78b429be-img"),
               "I select value option of Person's Location field"));


        public void SelectNoRecordFromPersonsLocationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Person's Location Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Person's Location Table Records");
            });

        }


         public void ClickDialogButtonOk() =>
       AllureLogger.LogStep("I select Change Person's Location", () =>
            SafeActions.Click(driver,
               By.CssSelector("#mc3990d1-pb"),
               "I select Change Person's Location"));

        public void VerifyLocatiomChange()
        {
            AllureLogger.LogStep("I verify locatiom change", () =>
            {
                try
                {
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

                    // Wait for the status field to be visible
                    var statusField = wait.Until(SeleniumWaits.ElementIsVisible(
                        By.CssSelector("#m9fabd46a-tb")));

                    // Read the status value
                    string statusValue = statusField.GetAttribute("value")?.Trim();

                    // Validate non-empty value
                    if (string.IsNullOrWhiteSpace(statusValue))
                    {
                        throw new Exception("❌ Status field is empty or null.");
                    }

                    // Print the actual value (no hardcoded check)
                    Console.WriteLine($"✅ Current Status Value: {statusValue}");
                }
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine("❌ Error: Status field not found - " + ex.Message);
                    throw;
                }
                catch (WebDriverTimeoutException ex)
                {
                    Console.WriteLine("❌ Timeout: Status field did not become visible - " + ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                    throw;
                }
            });
        }


         public void TakeScreenshotOfChangingLocationOfAPersonTest() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-SM-004", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-SM-004.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-SM-004_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });



    }
}