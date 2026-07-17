using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Reqnroll;
using System.Text.RegularExpressions;


namespace GTR_AUTOMATED.Pages
{
    
    public sealed class YardMasterPOM
    {
        private readonly IWebDriver driver;
        public YardMasterPOM(IWebDriver drv) => driver = drv;

        /* ---------- Menu navigation ---------- */

        public void OpenGoToMenu() =>
            AllureLogger.LogStep("Open [Go To] menu", () =>
                SafeActions.Click(driver, By.Id("titlebar-tb_gotoButton"),
                                  "Go To button"));

        public void OpenFleetAvailabilityManagementBRDFMenu() =>
           AllureLogger.LogStep("Open Fleet Availability Management(BRDF) Menu", () =>
               SafeActions.Click(driver, By.Id("menu0_BRDF_MODULE_a_tnode"),
                                 "Open Fleet Availability Management(BRDF) Menu"));

        public void OpenDepotManagementBRDF() =>
            AllureLogger.LogStep("Open Depot Management (BRDF)", () =>
                SafeActions.Click(driver,
                    By.Id("menu0_BRDF_MODULE_sub_changeapp_BRDFDM_a_tnode"),
                    "Open Depot Management (BRDF)"));


          public void FilterTableYardAsset(string YardAsset) =>
         AllureLogger.LogStep($"I filter table Yard Asset with '{YardAsset}'", () =>
         {
             By filterFieldYardAsset = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");

             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
             IWebElement YardAssetField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldYardAsset));

             YardAssetField.Click();
             YardAssetField.Clear();
             YardAssetField.SendKeys(YardAsset);
             YardAssetField.SendKeys(Keys.Enter);
             Task.Delay(5000).Wait();
         });

        public void SelectNoRecordYardAssetTableRecords(int recordNumber) =>
       AllureLogger.LogStep($"I Select No {recordNumber} From Yard Asset Table Records", () =>
       {
           // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
           int zeroBasedIndex = recordNumber - 1;

           // Build dynamic Id selector by replacing the row index [R:x]
           string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

           SafeActions.Click(driver, By.Id(selector),
               $"I Select No {recordNumber} Record From Yard Asset Table Records");
           Task.Delay(8000).Wait();
       });

        public void TakeScreenshotOfDepotYardView() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-000-SC00", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-000-SC00.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-000-SC00_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });


        public void SetToggleKioskMode()
        {
            AllureLogger.LogStep("I set Toggle Kiosk Mode", () =>
            {
                SafeActions.Click(
                    driver,
                    By.XPath("//td[normalize-space()='Toggle Kiosk Mode']"),
                    "Toggle Kiosk Mode");

                Task.Delay(3000).Wait();
            });
        }


        public void TakeScreenshotOfKioskMode() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-000-SC01", () =>
        {
           try
           {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-000-SC01.png";

              takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-000-SC01_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
           }
        });

        public void SelectToggleVirtualHoldingRoad()
        {
            AllureLogger.LogStep("I select Toggle Virtual Holding Road", () =>
            {
                SafeActions.Click(
                    driver,
                    By.XPath("//td[normalize-space()='Toggle Virtual Holding Road']"),
                    "Toggle Virtual Holding Road");

                Task.Delay(3000).Wait();
            });
        }

        public void TakeScreenshotOfVirtualHoldingRoad() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-000-SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-000-SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-000-SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

        public void SelectReturnToDepotSelector()
        {
            AllureLogger.LogStep("I select Return to Depot Selector", () =>
            {
                var locator = By.XPath("//td[normalize-space()='Return to Depot Selector']");

                SafeActions.Click(
                    driver,
                    locator,
                    "I select Return to Depot Selector");

                Task.Delay(5000).Wait();

                driver.SwitchTo().ActiveElement().SendKeys(Keys.Enter);

                Task.Delay(5000).Wait();
            });
        }

        public void TakeScreenshotOfDepotsAndSidingsTable() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-000-SC03", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-000-SC03.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-000-SC03_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });



        public void SelectNoGapOnRoadBlockDiagram(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Gap on Road Block diagram", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

                // ✅ 1. Dynamic Road / Platform locator (from your HTML)
                By roadLocator = By.XPath(
                    "//span[starts-with(@id,'ROAD_') and contains(@id,'_label') and contains(normalize-space(.),'Platform')]"
                );

                // ✅ 2. Find Road element
                var roadElement = wait.Until(
                    SeleniumWaits.ElementExists(roadLocator)
                );

                // ✅ 3. Expand only if collapsed
                if (roadElement.GetAttribute("aria-expanded") != "true")
                {
                    roadElement = wait.Until(
                        SeleniumWaits.ElementToBeClickable(roadLocator)
                    );

                    roadElement.Click();

                    // Wait until expanded
                    wait.Until(d =>
                    {
                        var refreshed = d.FindElement(roadLocator);
                        return refreshed.GetAttribute("aria-expanded") == "true";
                    });
                }

                // ✅ 4. Re-fetch element to avoid stale reference
                roadElement = wait.Until(
                    SeleniumWaits.ElementExists(roadLocator)
                );

                // ✅ 5. Extract dynamic Road ID (e.g. ROAD_19177_label → 19177)
                string roadIdRaw = roadElement.GetAttribute("id");

                var match = Regex.Match(roadIdRaw, @"ROAD_(\d+)");
                if (!match.Success)
                {
                    throw new Exception($"Unable to extract Road ID from: {roadIdRaw}");
                }

                string roadId = match.Groups[1].Value;

                // ✅ 6. Build dynamic Gap locator (your original working structure)
                string gapXpath = $"//*[@id='RAILUNITEMPTY_ROAD_{roadId}_{recordNumber}']/div[1]/span[3]/span[1]";
                By gapLocator = By.XPath(gapXpath);

                // ✅ 7. Wait for Gap element
                var gapElement = wait.Until(
                    SeleniumWaits.ElementToBeClickable(gapLocator)
                );

                // ✅ 8. Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center'});", gapElement);

                // ✅ 9. Click Gap (with fallback)
                try
                {
                    SafeActions.Click(driver, gapLocator, $"Select Gap no {recordNumber}");
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", gapElement);
                }
            });
        }


        public void SelectNoRoad(int recordNumber)
        {
            AllureLogger.LogStep($"I Select first Road", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException), typeof(NoSuchElementException));

                // ✅ 1. Correct selector for ROAD (not unit, not gap)
                By roadLocator = By.CssSelector("span.dijitTreeLabel[id^='ROAD_'][id$='_label']");

                // ✅ 2. Wait for visible roads and sort visually (left → right)
                var roads = wait.Until(d =>
                {
                    var elements = d.FindElements(roadLocator)
                                    .Where(e => e.Displayed)
                                    .OrderBy(e => e.Location.X)
                                    .ToList();

                    return elements.Count > 0 ? elements : null;
                });

                if (roads == null || roads.Count == 0)
                {
                    throw new Exception("No visible roads found.");
                }

                // ✅ 3. ALWAYS select FIRST road (leftmost)
                var firstRoad = roads[0];

                // ✅ 4. Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center', inline:'center'});", firstRoad);

                // ✅ 5. Click road
                try
                {
                    firstRoad.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", firstRoad);
                }

                // ✅ 6. Optional wait until selected/expanded
                wait.Until(d =>
                {
                    var refreshed = d.FindElements(roadLocator)
                                     .Where(e => e.Displayed)
                                     .OrderBy(e => e.Location.X)
                                     .FirstOrDefault();

                    if (refreshed == null) return false;

                    return refreshed.GetAttribute("aria-selected") == "true"
                           || refreshed.GetAttribute("aria-expanded") == "true";
                });
            });
        }

        public void AddGapToTheRoad()
        {
            AllureLogger.LogStep("I add Gap to the Road", () =>
            {
                // 1) Locate the road element using the new XPath
                var roadElement = driver.FindElement(
                    By.XPath("//span[starts-with(@id,'RAILUNITEMPTY_ROAD_') and contains(@id,'_label')]")

                );

                // 2) Right-click on the road element
                var actions = new OpenQA.Selenium.Interactions.Actions(driver);
                actions.ContextClick(roadElement).Perform();

                // 3) Wait for the context menu item "Add Gap" to appear
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
                var menuItemLocator = By.XPath("//td[normalize-space()='Add Gap']");
                wait.Until(
                    SeleniumWaits.ElementToBeClickable(menuItemLocator)
                );

                // 4) Click the menu item
                driver.FindElement(menuItemLocator).Click();

                // 5) Optional wait
                Task.Delay(5000).Wait();
            });
        }


        public void EnterGapDetails(string GapMemo, string Poistion) =>
        AllureLogger.LogStep($"I enter Gap Details = '{GapMemo}', Poistion = '{Poistion}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

            // Adjust column indexes if needed
            By GapMemoLocator = By.CssSelector("#m113704d9-tb");
            By PoistionLocator = By.CssSelector("#m165ac0c0-tb");

            // Description filter
            IWebElement GapMemoFilter = wait.Until(SeleniumWaits.ElementToBeClickable(GapMemoLocator));
            GapMemoFilter.Click();
            GapMemoFilter.Clear();
            GapMemoFilter.SendKeys(GapMemo);

            // Status filter
            IWebElement PoistionFilter = wait.Until(SeleniumWaits.ElementToBeClickable(PoistionLocator));
            PoistionFilter.Click();
            PoistionFilter.Clear();
            PoistionFilter.SendKeys(Poistion);
            Task.Delay(5000).Wait();

        });


            public void SelectOkDialogButton() =>
         AllureLogger.LogStep("I select ok dialog button", () =>
         {
            By okButtonLocator = By.XPath("//button[contains(@class,'pb') and normalize-space()='OK']");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            IWebElement okButton = wait.Until(
            SeleniumWaits.ElementToBeClickable(okButtonLocator));

            okButton.Click();
         });




        public void TakeScreenshotOfGapAddedToTheRoad() =>
      AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-001-SC01", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-001-SC01.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-001-SC01_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });


        public void ViewGapDetails()
        {
            AllureLogger.LogStep("I View Gap details", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // 1) Wait for element to exist
                var gapLocator = By.XPath("//span[starts-with(@id,'GAP_ROAD_') and contains(@id,'_label')]");

                var gapElement = wait.Until(
                    SeleniumWaits.ElementExists(gapLocator)
                );

                // 2) Ensure it's interactable
                wait.Until(d => gapElement.Displayed && gapElement.Enabled);

                // 3) Right-click
                var actions = new OpenQA.Selenium.Interactions.Actions(driver);
                actions.MoveToElement(gapElement).ContextClick(gapElement).Perform();

                // 4) Wait for menu
                var menuLocator = By.XPath("//td[normalize-space()='View Info']");

                var menuItem = wait.Until(
                    SeleniumWaits.ElementToBeClickable(menuLocator)
                );

                // 5) Click menu
                menuItem.Click();
            });
        }


        public void TakeScreenshotOfViewedGapDetailsOne() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-001-SC02", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-001-SC02.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-001-SC02_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });


        public void ClickOKDialogButton()
        {
            AllureLogger.LogStep("I click OK dialog button", () =>
            {
                // Click the OK dialog button
                SafeActions.Click(driver,
                    By.CssSelector("#m2c07bc9e-pb"),
                    "I click OK dialog button");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(5000).Wait();
            });
        }

        public void DeleteGap()
        {
            AllureLogger.LogStep("I delete Gap", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // 1) Locate Gap element
                var gapLocator = By.XPath(
                    "(//span[starts-with(@id,'GAP_ROAD_') and contains(@id,'_label')])[1]");

                var gapElement = wait.Until(
                    SeleniumWaits.ElementIsVisible(gapLocator));

                // 2) Scroll Gap into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block: 'center', inline: 'center'});",
                    gapElement);

                Task.Delay(1000).Wait();

                // 3) Re-find Gap element after scroll
                gapElement = wait.Until(
                    SeleniumWaits.ElementIsVisible(gapLocator));

                // 4) Right-click Gap
                try
                {
                    new OpenQA.Selenium.Interactions.Actions(driver)
                        .MoveToElement(gapElement)
                        .ContextClick(gapElement)
                        .Perform();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript(@"
                var event = new MouseEvent('contextmenu', {
                    bubbles: true,
                    cancelable: true,
                    view: window,
                    button: 2
                });
                arguments[0].dispatchEvent(event);
            ", gapElement);
                }

                Task.Delay(1000).Wait();

                // 5) Locate Delete menu item using provided element
                var deleteMenuItem = By.XPath(
                    "//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Delete']");

                var deleteElement = wait.Until(d =>
                {
                    var elements = d.FindElements(deleteMenuItem);

                    return elements.FirstOrDefault(e =>
                        e.Displayed &&
                        e.Text.Trim().Equals("Delete", StringComparison.OrdinalIgnoreCase));
                });

                if (deleteElement == null)
                {
                    throw new NoSuchElementException("Delete menu item was not visible after right-click.");
                }

                // 6) Move to Delete option and click
                try
                {
                    new OpenQA.Selenium.Interactions.Actions(driver)
                        .MoveToElement(deleteElement)
                        .Click(deleteElement)
                        .Perform();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript(
                        "arguments[0].click();",
                        deleteElement);
                }

                Task.Delay(12000).Wait();
            });
        }

        public void TakeScreenshotOfDeletedGap() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-001-SC03", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-001-SC03.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-001-SC03_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });




        // Depot View Tab - Adding and Removing a Block on a Road POM Steps



        public void AddBlockToTheRoad(int gapIndex = 1)
        {
            AllureLogger.LogStep($"I add Block to the Road", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

                // 1) Find the Road / Platform node dynamically
                By roadLocator = By.XPath(
                    "//span[starts-with(@id,'ROAD_') and contains(@id,'_label') and contains(normalize-space(.),'Platform')]"
                );

                var roadElement = wait.Until(
                    SeleniumWaits.ElementExists(roadLocator)
                );

                // 2) Expand Road / Platform if collapsed
                if (roadElement.GetAttribute("aria-expanded") != "true")
                {
                    roadElement = wait.Until(
                        SeleniumWaits.ElementToBeClickable(roadLocator)
                    );

                    ((IJavaScriptExecutor)driver).ExecuteScript(
                        "arguments[0].scrollIntoView({block:'center'});", roadElement);

                    roadElement.Click();

                    wait.Until(d =>
                    {
                        var refreshedRoad = d.FindElement(roadLocator);
                        return refreshedRoad.GetAttribute("aria-expanded") == "true";
                    });
                }

                // 3) Re-fetch road element after expansion
                roadElement = wait.Until(
                    SeleniumWaits.ElementExists(roadLocator)
                );

                // 4) Extract Road ID from ROAD_19177_label
                string roadIdAttribute = roadElement.GetAttribute("id");
                var roadMatch = Regex.Match(roadIdAttribute, @"ROAD_(\d+)_label");

                if (!roadMatch.Success)
                {
                    throw new Exception($"Unable to extract Road ID from element id: {roadIdAttribute}");
                }

                string roadId = roadMatch.Groups[1].Value;

                // 5) Build dynamic Gap container locator
                // This follows your original working DOM pattern, but makes roadId dynamic
                string gapClickableXpath =
                    $"//*[@id='RAILUNITEMPTY_ROAD_{roadId}_{gapIndex}']/div[1]/span[3]/span[1]";

                By gapLocator = By.XPath(gapClickableXpath);

                var gapElement = wait.Until(
                    SeleniumWaits.ElementExists(gapLocator)
                );

                // 6) Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center'});", gapElement);

                // 7) Right-click gap element
                var actions = new OpenQA.Selenium.Interactions.Actions(driver);
                actions.MoveToElement(gapElement)
                       .Pause(TimeSpan.FromMilliseconds(500))
                       .ContextClick(gapElement)
                       .Perform();

                // 8) Wait for "Add Block" menu item
                By menuItemLocator = By.XPath("//td[normalize-space()='Add Block']");

                var menuItem = wait.Until(
                    SeleniumWaits.ElementToBeClickable(menuItemLocator)
                );

                // 9) Click menu item
                try
                {
                    menuItem.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", menuItem);
                }

                Task.Delay(3000).Wait();
            });
        }


        public void EnterBlockDetails(string Memo, string Poistion) =>
        AllureLogger.LogStep($"I enter Gap Details = '{Memo}', Poistion = '{Poistion}'", () =>
        {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Adjust column indexes if needed
                By MemoLocator = By.CssSelector("#md64503f4-tb");
                By PoistionLocator = By.CssSelector("#md128c7ed-tb");

               // Description filter
                IWebElement MemoFilter = wait.Until(SeleniumWaits.ElementToBeClickable(MemoLocator));
                MemoFilter.Click();
                MemoFilter.Clear();
                MemoFilter.SendKeys(Memo);

                // Status filter
                IWebElement PoistionFilter = wait.Until(SeleniumWaits.ElementToBeClickable(PoistionLocator));
                PoistionFilter.Click();
                PoistionFilter.Clear();
                PoistionFilter.SendKeys(Poistion);
                Task.Delay(5000).Wait();

        });


        public void SelectDialogOkButton()
        {
            AllureLogger.LogStep("I select dialog ok button", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#md23cb50f-pb"),
                    "I select dialog ok button");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(8000).Wait();
            });
        }


        public void TakeScreenshotOfBlockAddedToTheRoad() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-002-SC01", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-002-SC01.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-002-SC01_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });


        public void ViewBlockDetails()
        {
            AllureLogger.LogStep("I View Block details", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                var blockLocator = By.CssSelector("#BLOCK_ROAD_19177_1_label");
                var menuLocator = By.XPath("//td[normalize-space()='View Info']");

                int attempts = 0;

                while (attempts < 3)
                {
                    try
                    {
                        // 1) Re-locate block element every time (IMPORTANT)
                        var blockElement = wait.Until(
                            SeleniumWaits.ElementToBeClickable(blockLocator)
                        );

                        // 2) Right-click
                        var actions = new OpenQA.Selenium.Interactions.Actions(driver);
                        actions.MoveToElement(blockElement).ContextClick(blockElement).Perform();

                        // 3) Re-locate menu after opening (IMPORTANT)
                        var menuItem = wait.Until(
                            SeleniumWaits.ElementToBeClickable(menuLocator)
                        );

                        // 4) Click View Info
                        menuItem.Click();

                        return; // success, exit method
                    }
                    catch (StaleElementReferenceException)
                    {
                        attempts++;
                    }
                    catch (ElementClickInterceptedException)
                    {
                        attempts++;
                    }
                    Task.Delay(8000).Wait();
                }

                throw new Exception("Failed to click 'View Info' after multiple attempts.");
                
            });
        }


        public void TakeScreenshotOfViewedBlockDetails() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-002-SC02", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-002-SC02.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-002-SC02_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });

        public void DeleteBlock()
        {
            AllureLogger.LogStep("I delete Block", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // 1) Locate the Block element
                var blockLocator = By.XPath(
                    "(//span[contains(@class,'brdfYardAssetLabel') and contains(normalize-space(.),'Block')])[1]");

                var blockElement = wait.Until(
                    SeleniumWaits.ElementIsVisible(blockLocator));

                // 2) Scroll Block into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block: 'center', inline: 'center'});",
                    blockElement);

                Task.Delay(1000).Wait();

                // 3) Re-find element after scroll
                blockElement = wait.Until(
                    SeleniumWaits.ElementIsVisible(blockLocator));

                // 4) Right-click on Block
                try
                {
                    new OpenQA.Selenium.Interactions.Actions(driver)
                        .MoveToElement(blockElement)
                        .ContextClick(blockElement)
                        .Perform();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript(@"
                var event = new MouseEvent('contextmenu', {
                    bubbles: true,
                    cancelable: true,
                    view: window,
                    button: 2
                });
                arguments[0].dispatchEvent(event);
            ", blockElement);
                }

                Task.Delay(1000).Wait();

                // 5) Locate Delete menu item using provided element
                var deleteMenuLocator = By.XPath(
                    "//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Delete']");

                var deleteElement = wait.Until(d =>
                {
                    var elements = d.FindElements(deleteMenuLocator);

                    return elements.FirstOrDefault(e =>
                        e.Displayed &&
                        e.Text.Trim().Equals("Delete", StringComparison.OrdinalIgnoreCase));
                });

                if (deleteElement == null)
                {
                    throw new NoSuchElementException("Delete menu item was not visible after right-click.");
                }

                // 6) Click Delete
                try
                {
                    new OpenQA.Selenium.Interactions.Actions(driver)
                        .MoveToElement(deleteElement)
                        .Click(deleteElement)
                        .Perform();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript(
                        "arguments[0].click();",
                        deleteElement);
                }

                Task.Delay(12000).Wait();
            });
        }


        public void TakeScreenshotOfDeletedBlock() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-002-SC03", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-002-SC03.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-002-SC03_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });





        //Depot View Tab -  Block all the roads in a Depot (Emergency) POM STEPS


        public void SelectDepotMenuOptionChangeStatus()
        {
            AllureLogger.LogStep("I select Allocate Departure Timetable", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Wait until at least one action menu exists
                wait.Until(d => d.FindElements(By.CssSelector("#depotMenuTrigger")).Count > 0);

                // Get the first visible action menu
                var actionMenus = driver.FindElements(By.CssSelector("#depotMenuTrigger"));
                var actionMenu = actionMenus.FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                // Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center'});", actionMenu);
                Task.Delay(500).Wait();

                // Click action menu (with fallback)
                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", actionMenu);
                }

                // Wait for "Change Status" option
                var changeStatusOption = wait.Until(
                    SeleniumWaits.ElementToBeClickable(
                        By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Change Status']")));

                // Click the option
                changeStatusOption.Click();

                // Wait for menu to disappear
                wait.Until(SeleniumWaits.InvisibilityOfElementLocated(
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Change Status']")));
            });
        }

        public void SelectDepotMenuOption()
        {
            AllureLogger.LogStep("I select Depot Menu Option", () =>
            {
                try
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                    var locator = By.Id("depotMenuTrigger");

                    var element = wait.Until(drv =>
                    {
                        var elements = drv.FindElements(locator);
                        return elements.FirstOrDefault(e => e.Displayed && e.Enabled);
                    });

                    if (element == null)
                    {
                        throw new Exception("Failure: Depot Menu trigger not found.");
                    }

                    try
                    {
                        element.Click();
                    }
                    catch
                    {
                        // ✅ JS fallback (handles Dojo overlays)
                        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);
                    }
                }
                catch (WebDriverTimeoutException)
                {
                    throw new Exception("Failure: Depot Menu was not clickable within timeout.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                    throw;
                }
            });
        }

        public void SelectChangeStatus()
        {
            AllureLogger.LogStep("I Select Change Status", () =>
            {
                try
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                    var locator = By.XPath(
                        "//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Change Status']");

                    var element = wait.Until(drv =>
                    {
                        var elements = drv.FindElements(locator);
                        return elements.FirstOrDefault(e => e.Displayed && e.Enabled);
                    });

                    if (element == null)
                    {
                        throw new Exception("Failure: Change Status menu item not found.");
                    }

                    try
                    {
                        element.Click();
                    }
                    catch
                    {
                        // ✅ JS fallback for Dojo menu issues
                        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);
                    }

                    // ✅ Wait until menu disappears (action completed)
                    wait.Until(drv => drv.FindElements(locator).Count == 0);
                }
                catch (WebDriverTimeoutException)
                {
                    throw new Exception("Failure: Change Status menu item was not clickable within timeout.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                    throw;
                }
                Task.Delay(5000).Wait();
            });
        }

           public void EnterMemo(string memo) =>
        AllureLogger.LogStep($"I enter Memo = '{memo}'", () =>
        {
              try
              {
                   var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                   var locator = By.CssSelector("#mc3b9dd33-tb");

                   var element = wait.Until(drv =>
                   {
                       var elements = drv.FindElements(locator);
                       return elements.FirstOrDefault(e => e.Displayed && e.Enabled);
                   });

                   if (element == null)
                   {
                        throw new Exception("Failure: Memo input field is not available.");
                   }

                    element.Click();
                    element.Clear();
                    element.SendKeys(memo);

                   // ✅ Optional: ensure text is entered (useful for flaky Dojo inputs)
                   wait.Until(drv => element.GetAttribute("value") == memo);
                   }
                   catch (WebDriverTimeoutException)
                   {
                       throw new Exception("Failure: Memo field was not interactable within timeout.");
                   }
                   catch (Exception ex)
                   {
                       Console.WriteLine("❌ Error: " + ex.Message);
                       throw;
                   }
        });

        public void SelectStatusAsBLOCKED()
        {
            AllureLogger.LogStep("I select Status as BLOCKED", () =>
            {
                try
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                    // ✅ Step 1: Click dropdown safely
                    var dropdownLocator = By.Id("m8b0ad9f-img");

                    var dropdown = wait.Until(drv =>
                    {
                        var elements = drv.FindElements(dropdownLocator);
                        return elements.FirstOrDefault(e => e.Displayed && e.Enabled);
                    });

                    if (dropdown == null)
                        throw new Exception("Failure: Status dropdown not found.");

                    try
                    {
                        dropdown.Click();
                    }
                    catch
                    {
                        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", dropdown);
                    }

                    // ✅ Step 2: Use your exact element (span) but make it robust
                    var optionLocator = By.XPath(
                        "//span[normalize-space()='Blocked (BLOCKED)']");

                    var blockedOption = wait.Until(drv =>
                    {
                        var elements = drv.FindElements(optionLocator);
                        return elements.FirstOrDefault(e => e.Displayed);
                    });

                    if (blockedOption == null)
                        throw new Exception("Failure: BLOCKED option not found in dropdown.");

                    try
                    {
                        blockedOption.Click();
                    }
                    catch
                    {
                        // ✅ JS fallback for Dojo menu
                        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", blockedOption);
                    }

                }
                catch (WebDriverTimeoutException)
                {
                    throw new Exception("Failure: Unable to select BLOCKED status within timeout.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                    throw;
                }
                Task.Delay(5000).Wait();
            });
        }



        public void PressOKDialogButton()
        {
            AllureLogger.LogStep("I press OK dialog button", () =>
            {
                try
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                    var locator = By.CssSelector("#m3090fd36-pb");

                    var element = wait.Until(drv =>
                    {
                        var elements = drv.FindElements(locator);
                        return elements.FirstOrDefault(e => e.Displayed && e.Enabled);
                    });

                    if (element == null)
                    {
                        throw new Exception("Failure: OK button not found in dialog.");
                    }

                    try
                    {
                        element.Click();
                    }
                    catch
                    {
                        // ✅ JS fallback (important for Dojo dialog buttons)
                        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);
                    }

                    // ✅ Wait for dialog to disappear (critical stability fix)
                    wait.Until(drv =>
                        drv.FindElements(locator).Count == 0);

                }
                catch (WebDriverTimeoutException)
                {
                    throw new Exception("Failure: OK button was not clickable or dialog did not close.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                    throw;
                }
                Task.Delay(12000).Wait();
            });
        }



         public void TakeScreenshotOfBlockedRoads() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-003-SC01", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-003-SC01.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-003-SC01_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });

        public void ChangeStatus()
        {
            AllureLogger.LogStep("I change Status", () =>
            {
                try
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

                    var locator = By.XPath(
                        "//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Change Status']");

                    var element = wait.Until(drv =>
                    {
                        var elements = drv.FindElements(locator);
                        return elements.FirstOrDefault(e => e.Displayed && e.Enabled);
                    });

                    if (element == null)
                    {
                        throw new Exception("Failure: Change Status element not found.");
                    }

                    try
                    {
                        element.Click();
                    }
                    catch
                    {
                        // ✅ JS fallback for Dojo menu
                        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);
                    }
                }
                catch (WebDriverTimeoutException)
                {
                    throw new Exception("Failure: Change Status element was not clickable within timeout.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                    throw;
                }
            });
        }


        public void SelectStatusAsACTIVE()
        {
            AllureLogger.LogStep("I select Status as ACTIVE", () =>
            {
                try
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

                    // ✅ Step 1: Click dropdown
                    var dropdownLocator = By.Id("m8b0ad9f-img");

                    var dropdown = wait.Until(drv =>
                    {
                        var elements = drv.FindElements(dropdownLocator);
                        return elements.FirstOrDefault(e => e.Displayed && e.Enabled);
                    });

                    if (dropdown == null)
                        throw new Exception("Failure: Status dropdown not found.");

                    try
                    {
                        dropdown.Click();
                    }
                    catch
                    {
                        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", dropdown);
                    }

                    // ✅ Step 2: Select Active (ACTIVE) using span element (stable)
                    var optionLocator = By.XPath(
                        "//span[normalize-space()='Active (ACTIVE)']");

                    var activeOption = wait.Until(drv =>
                    {
                        var elements = drv.FindElements(optionLocator);
                        return elements.FirstOrDefault(e => e.Displayed);
                    });

                    if (activeOption == null)
                        throw new Exception("Failure: ACTIVE option not found in dropdown.");

                    try
                    {
                        activeOption.Click();
                    }
                    catch
                    {
                        // ✅ JS fallback for Dojo menu
                        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", activeOption);
                    }

                }
                catch (WebDriverTimeoutException)
                {
                    throw new Exception("Failure: Unable to select ACTIVE status within timeout.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                    throw;
                }
            });
        }


            public void EnterMemoDetails(string memo) =>
         AllureLogger.LogStep($"I enter Memo Details = '{memo}'", () =>
         {
               try
               {
                   var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                   var locator = By.Id("mc3b9dd33-tb");

                   IWebElement element = null;

                   wait.Until(drv =>
                   {
                        try
                        {
                            var elements = drv.FindElements(locator);
                            element = elements.FirstOrDefault(e => e.Displayed && e.Enabled);
                            return element != null;
                        }
                        catch (StaleElementReferenceException)
                        {
                           return false;
                        }
               });

                        if (element == null)
                        {
                            throw new Exception("Failure: Memo input field is not available.");
                        }

                        try
                        {
                            element.Click();
                            element.Clear();
                            element.SendKeys(memo);
                            }
                            catch (StaleElementReferenceException)
                            {
                            // Re-find and retry once if field refreshes
                                 element = wait.Until(drv =>
                                 {
                                    var elements = drv.FindElements(locator);
                                    return elements.FirstOrDefault(e => e.Displayed && e.Enabled);
                                 });

                                 if (element == null)
                                 {
                                    throw new Exception("Failure: Memo input field became stale and could not be re-located.");
                                 }

                                     element.Click();
                                     element.Clear();
                                    element.SendKeys(memo);
                            }

                                 // ✅ Re-locate when validating to avoid stale reference
                        wait.Until(drv =>
                        {
                             try
                             {
                                 var current = drv.FindElements(locator)
                                 .FirstOrDefault(e => e.Displayed && e.Enabled);

                                  return current != null && current.GetAttribute("value")?.Trim() == memo;
                             }
                                 catch (StaleElementReferenceException)
                                 {
                                    return false;
                                 }
                        });
                                 }
                                 catch (WebDriverTimeoutException)
                                 {
                                    throw new Exception("Failure: Memo field was not interactable within timeout.");
                                 }
                                 catch (Exception ex)
                                 {
                                     Console.WriteLine("❌ Error: " + ex.Message);
                                     throw;
                                 }
         });



         public void TakeScreenshotOfUnBlockedRoads() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-003-SC02", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-003-SC02.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-003-SC02_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });





        // Depot View Tab - Block an Entire Road in Depot POM STEPS



        public void AddRoadAttribute()
        {
            AllureLogger.LogStep("I Add Road Attribute", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException), typeof(NoSuchElementException));

                // ✅ 1. Correct ROAD locator (dynamic)
                By roadLocator = By.CssSelector("span.dijitTreeLabel[id^='ROAD_'][id$='_label']");

                // ✅ 2. Get first visible road (leftmost)
                var roadElement = wait.Until(d =>
                {
                    var roads = d.FindElements(roadLocator)
                                 .Where(e => e.Displayed)
                                 .OrderBy(e => e.Location.X)
                                 .ToList();

                    return roads.Count > 0 ? roads[0] : null;
                });

                if (roadElement == null)
                {
                    throw new Exception("Road element not found.");
                }

                // ✅ 3. Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center', inline:'center'});", roadElement);

                // ✅ 4. Right-click on ROAD
                var actions = new OpenQA.Selenium.Interactions.Actions(driver);
                actions.MoveToElement(roadElement)
                       .ContextClick(roadElement)
                       .Perform();

                // ✅ 5. Wait for context menu item
                By menuItemLocator = By.XPath("//td[normalize-space()='Add Road Attribute']");

                var menuItem = wait.Until(
                    SeleniumWaits.ElementToBeClickable(menuItemLocator)
                );

                // ✅ 6. Click menu item (safe click)
                try
                {
                    menuItem.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", menuItem);
                }

                // ✅ 7. Optional wait
                Task.Delay(3000).Wait();
            });
        }



        public void SelectNewRowButtonUnderFleetAvailabilityAttributes()
        {
            AllureLogger.LogStep("I select New Row button under Fleet Availability Attributes", () =>
            {
                
                SafeActions.Click(driver,
                    By.Id("mfbfe1f43_bg_button_addrow-pb"),
                    "I select New Row button under Fleet Availability Attributes");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void SelectValueLookupOfAttributeField()
        {
            AllureLogger.LogStep("I  select Value lookup of Attribute field", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#m9d41a70b-img"),
                    "I  select Value lookup of Attribute field");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }

        public void FilterAttributes(string Attributes) =>
         AllureLogger.LogStep($"I filter table Attributes with '{Attributes}'", () =>
         {
             By filterFieldAttributes = By.CssSelector("#lookup_page2_tfrow_\\[C\\:0\\]_txt-tb");

             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
             IWebElement AttributesField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldAttributes));

             AttributesField.Click();
             AttributesField.Clear();
             AttributesField.SendKeys(Attributes);
             AttributesField.SendKeys(Keys.Enter);
             Task.Delay(5000).Wait();
         });


        public void SelectNoRecordAttributeTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Attribute Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Attribute Table Records");
            });

        }


        public void ClickOKDialogButtonOfAttributeDropdownList()
        {
            AllureLogger.LogStep("I click OK dialog button of Attribute dropdown list", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#m6f5654c7-pb"),
                    "I click OK dialog button of Attribute dropdown list");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(25000).Wait();
            });
        }
              

        public void TakeScreenshotOfBlockedRoadAddedToTheRoad() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-004-SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-004-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-004-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void SelectBlockedRoad()
        {
            AllureLogger.LogStep("I Select Blocked road", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException), typeof(NoSuchElementException));

                // 1. Locate ROAD elements dynamically
                By roadLocator = By.CssSelector("span.dijitTreeLabel[id^='ROAD_'][id$='_label']");

                // 2. Get the first visible road (leftmost)
                var roadElement = wait.Until(d =>
                {
                    var roads = d.FindElements(roadLocator)
                                 .Where(e => e.Displayed)
                                 .OrderBy(e => e.Location.X)
                                 .ToList();

                    return roads.Count > 0 ? roads[0] : null;
                });

                if (roadElement == null)
                {
                    throw new Exception("Road element not found.");
                }

                // 3. Scroll road into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({ block: 'center', inline: 'center' });",
                    roadElement);

                // 4. Click road
                try
                {
                    roadElement.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", roadElement);
                }

                // 5. Optional: wait until road is selected or expanded
                wait.Until(d =>
                {
                    var roads = d.FindElements(roadLocator)
                                 .Where(e => e.Displayed)
                                 .OrderBy(e => e.Location.X)
                                 .ToList();

                    if (roads.Count == 0)
                        return false;

                    var refreshedRoad = roads[0];

                    var ariaSelected = refreshedRoad.GetAttribute("aria-selected");
                    var ariaExpanded = refreshedRoad.GetAttribute("aria-expanded");

                    return string.Equals(ariaSelected, "true", StringComparison.OrdinalIgnoreCase)
                           || string.Equals(ariaExpanded, "true", StringComparison.OrdinalIgnoreCase);
                });
            });
        }


        public void DeleteRoadAttribute()
        {
            AllureLogger.LogStep("I Delete Road Attribute", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
                wait.IgnoreExceptionTypes(
                    typeof(StaleElementReferenceException),
                    typeof(NoSuchElementException),
                    typeof(ElementClickInterceptedException)
                );

                // 1. Locate first visible ROAD
                By roadLocator = By.CssSelector("span.dijitTreeLabel[id^='ROAD_'][id$='_label']");

                var roadElement = wait.Until(d =>
                {
                    var roads = d.FindElements(roadLocator)
                                 .Where(e => e.Displayed)
                                 .OrderBy(e => e.Location.X)
                                 .ToList();

                    return roads.Count > 0 ? roads.First() : null;
                });

                if (roadElement == null)
                {
                    throw new Exception("Road element not found.");
                }

                // 2. Scroll road into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({ block: 'center', inline: 'center' });",
                    roadElement);

                // 3. Click once to focus/select the road first
                try
                {
                    roadElement.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", roadElement);
                }

                // 4. Re-locate road after focus/select to avoid stale DOM
                roadElement = wait.Until(d =>
                {
                    var roads = d.FindElements(roadLocator)
                                 .Where(e => e.Displayed)
                                 .OrderBy(e => e.Location.X)
                                 .ToList();

                    return roads.Count > 0 ? roads.First() : null;
                });

                // 5. Right-click the road
                var actions = new OpenQA.Selenium.Interactions.Actions(driver);
                actions.MoveToElement(roadElement)
                       .Pause(TimeSpan.FromMilliseconds(500))
                       .ContextClick(roadElement)
                       .Perform();

                // 6. Wait for Add Road Attribute menu item to become visible
                By addRoadAttributeLocator = By.XPath(
                    "//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Add Road Attribute']"
                );

                var addRoadAttributeMenu = wait.Until(d =>
                {
                    var items = d.FindElements(addRoadAttributeLocator)
                                 .Where(e => e.Displayed)
                                 .ToList();

                    return items.Count > 0 ? items.First() : null;
                });

                if (addRoadAttributeMenu == null)
                {
                    throw new Exception("'Add Road Attribute' menu item was not found after right-click.");
                }

                // 7. Scroll the menu item into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({ block: 'center', inline: 'center' });",
                    addRoadAttributeMenu);

                // 8. Click Add Road Attribute using multiple fallbacks
                bool addClicked = false;

                try
                {
                    addRoadAttributeMenu.Click();
                    addClicked = true;
                }
                catch
                {
                    // ignore and try next approach
                }

                if (!addClicked)
                {
                    try
                    {
                        new OpenQA.Selenium.Interactions.Actions(driver)
                            .MoveToElement(addRoadAttributeMenu)
                            .Pause(TimeSpan.FromMilliseconds(200))
                            .Click()
                            .Perform();

                        addClicked = true;
                    }
                    catch
                    {
                        // ignore and try JS
                    }
                }

                if (!addClicked)
                {
                    try
                    {
                        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", addRoadAttributeMenu);
                        addClicked = true;
                    }
                    catch
                    {
                        // ignore
                    }
                }

                if (!addClicked)
                {
                    throw new Exception("Unable to click 'Add Road Attribute' after right-click.");
                }

                // 9. Wait for popup/grid to appear
                By deleteIconLocator = By.XPath("//*[self::img or self::span][contains(@id,'toggleimage')]");

                var deleteIcon = wait.Until(d =>
                {
                    var icons = d.FindElements(deleteIconLocator)
                                 .Where(e => e.Displayed && e.Enabled)
                                 .ToList();

                    return icons.Count > 0 ? icons.First() : null;
                });

                if (deleteIcon == null)
                {
                    throw new Exception("Delete icon not found after opening 'Add Road Attribute'.");
                }

                // 10. Scroll delete icon into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({ block: 'center', inline: 'center' });",
                    deleteIcon);

                // 11. Click delete icon
                try
                {
                    deleteIcon.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", deleteIcon);
                }
            });
        }


        public void TakeScreenshotOfDeletedBlockedRoad() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-004-SC02", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-004-SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-004-SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });



        // Depot View Tab - Add Attributes to the Road POM STEPS



          public void TakeScreenshotOfLowSpeedAttribute() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-005-SC01", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-005-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-005-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });

         public void TakeScreenshotOfDeletedLowSpeedAttribute() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-005-SC02", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-005-SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-005-SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });





        // Depot View Tab - Add Attributes to the Block POM STEPS



        public void AddRoadComment()
        {
            AllureLogger.LogStep("I Add Road Comment", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
                wait.IgnoreExceptionTypes(
                    typeof(StaleElementReferenceException),
                    typeof(NoSuchElementException),
                    typeof(ElementClickInterceptedException)
                );

                // ✅ 1. Locate ROAD dynamically
                By roadLocator = By.CssSelector("span.dijitTreeLabel[id^='ROAD_'][id$='_label']");

                var roadElement = wait.Until(d =>
                {
                    var roads = d.FindElements(roadLocator)
                                 .Where(e => e.Displayed)
                                 .OrderBy(e => e.Location.X)
                                 .ToList();

                    return roads.Count > 0 ? roads.First() : null;
                });

                if (roadElement == null)
                    throw new Exception("Road element not found.");

                // ✅ 2. Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center'});", roadElement);

                // ✅ 3. Click once to focus (IMPORTANT for context menu)
                try
                {
                    roadElement.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", roadElement);
                }

                // ✅ 4. Right-click ROAD
                var actions = new Actions(driver);
                actions.MoveToElement(roadElement)
                       .Pause(TimeSpan.FromMilliseconds(500))
                       .ContextClick(roadElement)
                       .Perform();

                // ✅ 5. Locate "Add Comment" menu item (visibility based)
                By menuLocator = By.XPath(
                    "//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Add Comment']"
                );

                var menuItem = wait.Until(d =>
                {
                    var items = d.FindElements(menuLocator)
                                 .Where(e => e.Displayed)
                                 .ToList();

                    return items.Count > 0 ? items.First() : null;
                });

                if (menuItem == null)
                    throw new Exception("'Add Comment' menu item not found after right-click.");

                // ✅ 6. Scroll menu into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center'});", menuItem);

                // ✅ 7. Click menu item (robust approach)
                bool clicked = false;

                try
                {
                    menuItem.Click();
                    clicked = true;
                }
                catch { }

                if (!clicked)
                {
                    try
                    {
                        new Actions(driver)
                            .MoveToElement(menuItem)
                            .Click()
                            .Perform();
                        clicked = true;
                    }
                    catch { }
                }

                if (!clicked)
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", menuItem);
                    clicked = true;
                }

                if (!clicked)
                    throw new Exception("Failed to click 'Add Comment' menu item.");
            });
        }

        public void EnterComment(string Comment) =>
        AllureLogger.LogStep($"I enter Comment '{Comment}'", () =>
        {
            By filterFieldComment = By.CssSelector("#m2ebc32e0-ta");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement CommentField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldComment));

            CommentField.Click();
            CommentField.Clear();
            CommentField.SendKeys(Comment);
            Task.Delay(3000).Wait();
        });


        public void ClickOKDialogButtonOfAddCommentDialog()
        {
            AllureLogger.LogStep("I click OK dialog button of Add Comment dialog", () =>
            {
               
                SafeActions.Click(driver,
                    By.CssSelector("#m6e123afd-pb"),
                    "I click OK dialog button of Add Comment dialog");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(8000).Wait();
            });
        }


        public void TakeScreenshotOfAddedComment() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-006-SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-006-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-006-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);

           }
       });


        public void ModifyRoadComment()
        {
            AllureLogger.LogStep("I Modify Road Comment", () =>
            {
                try
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
                    wait.IgnoreExceptionTypes(
                        typeof(StaleElementReferenceException),
                        typeof(NoSuchElementException),
                        typeof(ElementClickInterceptedException)
                    );

                    By roadLocator = By.CssSelector("span.dijitTreeLabel[id^='ROAD_'][id$='_label']");
                    By menuLocator = By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Add Comment']");

                    IWebElement GetFirstVisible(By locator)
                    {
                        return wait.Until(d =>
                        {
                            var elements = d.FindElements(locator)
                                            .Where(e => e.Displayed)
                                            .OrderBy(e => e.Location.X)
                                            .ToList();

                            return elements.Count > 0 ? elements.First() : null;
                        });
                    }

                    // ✅ 1. Find road
                    var roadElement = GetFirstVisible(roadLocator);

                    if (roadElement == null)
                        throw new Exception("Failure: Road element not found.");

                    // ✅ 2. Scroll into view
                    ((IJavaScriptExecutor)driver).ExecuteScript(
                        "arguments[0].scrollIntoView({block:'center'});", roadElement);

                    // ✅ 3. Click once to focus
                    try
                    {
                        roadElement.Click();
                    }
                    catch
                    {
                        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", roadElement);
                    }

                    // ✅ 4. Re-find ROAD before right-click (important stale fix)
                    roadElement = GetFirstVisible(roadLocator);

                    if (roadElement == null)
                        throw new Exception("Failure: Road element became unavailable before right-click.");

                    ((IJavaScriptExecutor)driver).ExecuteScript(
                        "arguments[0].scrollIntoView({block:'center'});", roadElement);

                    // ✅ 5. Right-click ROAD with retry + JS fallback
                    bool contextClicked = false;

                    try
                    {
                        new Actions(driver)
                            .MoveToElement(roadElement)
                            .Pause(TimeSpan.FromMilliseconds(300))
                            .ContextClick(roadElement)
                            .Perform();

                        contextClicked = true;
                    }
                    catch (StaleElementReferenceException)
                    {
                        roadElement = GetFirstVisible(roadLocator);

                        if (roadElement != null)
                        {
                            new Actions(driver)
                                .MoveToElement(roadElement)
                                .Pause(TimeSpan.FromMilliseconds(300))
                                .ContextClick(roadElement)
                                .Perform();

                            contextClicked = true;
                        }
                    }
                    catch
                    {
                        // JS contextmenu fallback
                        ((IJavaScriptExecutor)driver).ExecuteScript(@"
                    var evt = new MouseEvent('contextmenu', {
                        bubbles: true,
                        cancelable: true,
                        view: window,
                        button: 2
                    });
                    arguments[0].dispatchEvent(evt);", roadElement);

                        contextClicked = true;
                    }

                    if (!contextClicked)
                        throw new Exception("Failure: Unable to open context menu on road.");

                    // ✅ 6. Wait for 'Add Comment' menu item
                    var menuItem = wait.Until(d =>
                    {
                        var items = d.FindElements(menuLocator)
                                     .Where(e => e.Displayed)
                                     .ToList();

                        return items.Count > 0 ? items.First() : null;
                    });

                    if (menuItem == null)
                        throw new Exception("Failure: 'Add Comment' menu item not found after right-click.");

                    // ✅ 7. Scroll menu into view
                    ((IJavaScriptExecutor)driver).ExecuteScript(
                        "arguments[0].scrollIntoView({block:'center'});", menuItem);

                    // ✅ 8. Click menu item with stale-safe retry
                    bool clicked = false;

                    try
                    {
                        menuItem.Click();
                        clicked = true;
                    }
                    catch (StaleElementReferenceException)
                    {
                        menuItem = wait.Until(d =>
                        {
                            var items = d.FindElements(menuLocator)
                                         .Where(e => e.Displayed)
                                         .ToList();

                            return items.Count > 0 ? items.First() : null;
                        });

                        if (menuItem != null)
                        {
                            menuItem.Click();
                            clicked = true;
                        }
                    }
                    catch
                    {
                    }

                    if (!clicked)
                    {
                        try
                        {
                            menuItem = GetFirstVisible(menuLocator);

                            new Actions(driver)
                                .MoveToElement(menuItem)
                                .Click()
                                .Perform();

                            clicked = true;
                        }
                        catch
                        {
                        }
                    }

                    if (!clicked)
                    {
                        menuItem = GetFirstVisible(menuLocator);

                        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", menuItem);
                        clicked = true;
                    }

                    if (!clicked)
                        throw new Exception("Failure: Failed to click 'Add Comment' menu item.");

                    // ✅ Optional: wait for context menu to close
                    wait.Until(d => !d.FindElements(menuLocator).Any(e => e.Displayed));
                }
                catch (WebDriverTimeoutException)
                {
                    throw new Exception("Failure: Timed out while opening Road context menu or clicking 'Add Comment'.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                    throw;
                }
            });
        }


        public void ModifyComment(string Comment) =>
        AllureLogger.LogStep($"I Modify Comment '{Comment}'", () =>
        {
            By filterFieldComment = By.CssSelector("#m2ebc32e0-ta");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement CommentField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldComment));

            CommentField.Click();
            CommentField.Clear();
            CommentField.SendKeys(Comment);
            Task.Delay(3000).Wait();
        });


        public void ClickOKDialogButtonOfModifyCommentDialog()
        {
            AllureLogger.LogStep("I click OK dialog button of Modify Comment dialog", () =>
            {
                try
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

                    var locator = By.Id("m6e123afd-pb");

                    var element = wait.Until(drv =>
                    {
                        var elements = drv.FindElements(locator);
                        return elements.FirstOrDefault(e => e.Displayed && e.Enabled);
                    });

                    if (element == null)
                        throw new Exception("Failure: OK button not found in Modify Comment dialog.");

                    try
                    {
                        element.Click();
                    }
                    catch
                    {
                        // ✅ JS fallback for Dojo dialog
                        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);
                    }

                    // ✅ Wait for dialog to close (important stability fix)
                    wait.Until(drv => drv.FindElements(locator).Count == 0);
                }
                catch (WebDriverTimeoutException)
                {
                    throw new Exception("Failure: OK button was not clickable or dialog did not close.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                    throw;
                }
            });
        }


        public void RemoveRoadComment()
        {
            AllureLogger.LogStep("I Remove Road Comment", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
                wait.IgnoreExceptionTypes(
                    typeof(StaleElementReferenceException),
                    typeof(NoSuchElementException),
                    typeof(ElementClickInterceptedException)
                );

                // ✅ 1. Locate ROAD
                By roadLocator = By.CssSelector("span.dijitTreeLabel[id^='ROAD_'][id$='_label']");

                var roadElement = wait.Until(d =>
                {
                    var roads = d.FindElements(roadLocator)
                                 .Where(e => e.Displayed)
                                 .OrderBy(e => e.Location.X)
                                 .ToList();

                    return roads.Count > 0 ? roads.First() : null;
                });

                if (roadElement == null)
                    throw new Exception("Road element not found.");

                // ✅ 2. Scroll + focus
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center'});", roadElement);

                try { roadElement.Click(); }
                catch { ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", roadElement); }

                // ✅ 3. Right-click
                new Actions(driver)
                    .MoveToElement(roadElement)
                    .Pause(TimeSpan.FromMilliseconds(500))
                    .ContextClick(roadElement)
                    .Perform();

                // ✅ 4. Click "Add Comment"
                By menuLocator = By.XPath(
                    "//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Add Comment']"
                );

                var menuItem = wait.Until(d =>
                {
                    var items = d.FindElements(menuLocator)
                                 .Where(e => e.Displayed)
                                 .ToList();

                    return items.Count > 0 ? items.First() : null;
                });

                if (menuItem == null)
                    throw new Exception("Add Comment menu not found.");

                try { menuItem.Click(); }
                catch { ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", menuItem); }

                // ✅ 5. Wait for comment input field (IMPORTANT)
                // Adjust selector if needed based on your UI

                By commentInputLocator = By.XPath("//textarea | //input[contains(@id,'comment')]");

                var commentInput = wait.Until(d =>
                {
                    var fields = d.FindElements(commentInputLocator)
                                  .Where(e => e.Displayed)
                                  .ToList();

                    return fields.Count > 0 ? fields.First() : null;
                });

                if (commentInput == null)
                    throw new Exception("Comment input field not found.");

                // ✅ 6. Clear existing text
                commentInput.Clear();

                // ✅ Optional: send empty string explicitly (some frameworks need it)
                commentInput.SendKeys("");

                // ✅ 7. Click OK / Save (if required)
                By okButtonLocator = By.XPath("//span[normalize-space()='OK'] | //button[normalize-space()='OK']");

                var okButton = driver.FindElements(okButtonLocator)
                                     .FirstOrDefault(e => e.Displayed);

                if (okButton != null)
                {
                    try { okButton.Click(); }
                    catch { ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", okButton); }
                    Task.Delay(30000).Wait();
                }
            });
        }

        public void TakeScreenshotOfDeletedComment() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-006-SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-006-SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-006-SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });






        // Depot View Tab - Stopping Units in the Depot POM STEPS



        public void SelectUnitOnRoads()
        {
            AllureLogger.LogStep("I select first Unit on Roads", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                var firstUnit = wait.Until(SeleniumWaits.ElementToBeClickable(
                    By.XPath("(//span[contains(@class,'brdfYardAssetLabel') and starts-with(@id,'RAILUNIT_') and contains(@id,'_label')])[1]")));

                firstUnit.Click();

                Task.Delay(3000).Wait();
            });
        }


        public void ChangeUnitStatus()
        {
            AllureLogger.LogStep("I change Status", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Locate the element to right-click
                var element = wait.Until(SeleniumWaits.ElementToBeClickable(
                    By.XPath("//span[contains(@class,'brdfYardAssetLabel') and starts-with(@id,'RAILUNIT_') and contains(@id,'_label')]")));

                // Perform right-click (context click)
                Actions actions = new Actions(driver);
                actions.ContextClick(element).Perform();

                // Wait for the context menu item and click "Change Status"
                var changeStatusOption = wait.Until(SeleniumWaits.ElementToBeClickable(
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Change Status']")));

                changeStatusOption.Click();

                // Optional wait if UI needs time to update
                Task.Delay(3000).Wait();
            });
        }

        public void SelectSTOPPED()
        {
            AllureLogger.LogStep("I select Status as STOPPED", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                // Click dropdown
                var dropdown = wait.Until(d => d.FindElement(By.CssSelector("#m212b6e73-img")));
                dropdown.Click();

                // Wait and click BLOCKED option
                var blockedOption = wait.Until(d => d.FindElement(By.Id("menu0_STOPPED_OPTION_a_tnode")));
                blockedOption.Click();
                Task.Delay(3000).Wait();
            });
        }


         public void EnterUnitMemo(string Memo) =>
        AllureLogger.LogStep($"I enter unit Memo = '{Memo}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            // Adjust column indexes if needed
            By MemoLocator = By.CssSelector("#m331fdb42-tb");
           

            // Description filter
            IWebElement MemoFilter = wait.Until(SeleniumWaits.ElementToBeClickable(MemoLocator));
            MemoFilter.Click();
            MemoFilter.Clear();
            MemoFilter.SendKeys(Memo);
            Task.Delay(3000).Wait();

        });


        public void SelectValueLookupOfStopCodeField()
        {
            AllureLogger.LogStep("I select value lookup of stop code field", () =>
            {
               
                SafeActions.Click(driver,
                    By.CssSelector("#m817aaa46-img"),
                    "I select value lookup of stop code field");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void FilterStopCode(string StopCode) =>
        AllureLogger.LogStep($"I filter table Stop Code with '{StopCode}'", () =>
        {
            By filterFieldStopCode = By.CssSelector("#lookup_page2_tfrow_\\[C\\:0\\]_txt-tb");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement StopCodeField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldStopCode));

            StopCodeField.Click();
            StopCodeField.Clear();
            StopCodeField.SendKeys(StopCode);
            StopCodeField.SendKeys(Keys.Enter);
            Task.Delay(5000).Wait();
        });


         public void SelectNoRecordFromStopCodeTable(int recordNumber) =>
        AllureLogger.LogStep($"I Select No {recordNumber} From Stop Code Table Records", () =>
        {
           // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
           int zeroBasedIndex = recordNumber - 1;

           // Build dynamic Id selector by replacing the row index [R:x]
           string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

           SafeActions.Click(driver, By.Id(selector),
               $"I Select No {recordNumber} Record From Stop Code Table Records");
        });

          public void SetStopDate() =>
        AllureLogger.LogStep("I set Stop Date", () =>
        {
              var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

              // Open Stop Date picker
              var stopDatePickerIcon = By.CssSelector("#m1873fbfc-img");
              wait.Until(SeleniumWaits.ElementToBeClickable(stopDatePickerIcon)).Click();

             // Get today's day (e.g. "30")
             string todayDay = DateTime.Today.Day.ToString();

            // Updated selector using your new base structure
            var todayDateCell = By.XPath(
               $"//*[@id='m1873fbfc-tb_popup_date']//td[not(contains(@class,'dijitCalendarDisabledDate'))]/span[text()='{todayDay}']"
            );

             wait.Until(SeleniumWaits.ElementToBeClickable(todayDateCell)).Click();

               // Click OK button
               var okButton = By.XPath("//*[@id='m1873fbfc-tb_popup']//button[1]");
               wait.Until(SeleniumWaits.ElementToBeClickable(okButton)).Click();
        });


           public void SetStopEstimatedReleaseDate() =>
        AllureLogger.LogStep("I set Stop Estimated Release Date", () =>
        {
             var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Open Stop Estimated Release Date picker
            var stopDatePickerIcon = By.CssSelector("#m6f74cb6a-img");
            wait.Until(SeleniumWaits.ElementToBeClickable(stopDatePickerIcon)).Click();

            // Get today's day (e.g. "30")
            string todayDay = DateTime.Today.Day.ToString();

              // Updated selector with correct popup ID
             var todayDateCell = By.XPath(
                $"//*[@id='m6f74cb6a-tb_popup_date']//td[not(contains(@class,'dijitCalendarDisabledDate'))]/span[text()='{todayDay}']"
             );

               wait.Until(SeleniumWaits.ElementToBeClickable(todayDateCell)).Click();

              // Click OK button (also updated popup ID for consistency)
              var okButton = By.XPath("//*[@id='m6f74cb6a-tb_popup']//button[1]");
              wait.Until(SeleniumWaits.ElementToBeClickable(okButton)).Click();
        });

        public void ClickDialogOKButtonOfChangeUnitStatus()
        {
            AllureLogger.LogStep("I click dialog OK button of change unit status", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#m547a2e22-pb"),
                    "I click dialog OK button of change unit status");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(12000).Wait();
            });
        }

        public void TakeScreenshotOfStoppedUnitInDepot() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-007-SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-007-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-007-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void SelectAvailableForService()
        {
            AllureLogger.LogStep("I select Available for Service", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                // Click dropdown
                var dropdown = wait.Until(d => d.FindElement(By.CssSelector("#m212b6e73-img")));
                dropdown.Click();

                // Wait and click Available for Service option
                var blockedOption = wait.Until(d => d.FindElement(By.Id("menu0_AFS_OPTION_a_tnode")));
                blockedOption.Click();
                Task.Delay(3000).Wait();
            });
        }

         public void TakeScreenshotOfDepotToActive() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-007-SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-007-SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-007-SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });




        // Depot View Tab - View Units in the Yard POM STEPS


        public void SelectViewDetails()
        {
            AllureLogger.LogStep("I select View Details", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                var roadElement = wait.Until(SeleniumWaits.ElementToBeClickable(
                    By.XPath("(//span[contains(@class,'brdfYardAssetLabel') and starts-with(@id,'RAILUNIT_') and contains(@id,'_label')])[1]")));

                var actions = new OpenQA.Selenium.Interactions.Actions(driver);
                actions.ContextClick(roadElement).Perform();

                SafeActions.Click(driver,
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='View Details']"),
                    "I click View Details");

                Task.Delay(3000).Wait();
            });
        }

        public void GoToVehicleTab()
        {
            AllureLogger.LogStep("I go to Vehicle tab", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#medfa617-tab_anchor"),
                    "I go to Vehicle tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


         public void TakeScreenshotOfVehicleTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-008-SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-008-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-008-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void GoToServiceLineTab()
        {
            AllureLogger.LogStep("I go to Service Line Tab", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#m238fa1c2-tab_anchor"),
                    "I go to Service Line Tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void TakeScreenshotOfServiceLineTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-008-SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-008-SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-008-SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

        public void GoToSandingTab()
        {
            AllureLogger.LogStep("I go to Sanding tab", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#m78df9623-tab_anchor"),
                    "I go to Sanding tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void TakeScreenshotOfSandingTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-008-SC03", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-008-SC03.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-008-SC03_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void GoToToiletAvailabilityTab()
        {
            AllureLogger.LogStep("I go to Availability tab", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#m36a8f720-tab_anchor"),
                    "I go to Availability tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


         public void TakeScreenshotOfToiletAvailabilityTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-008-SC04", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-008-SC04.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-008-SC04_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void GoToStatusHistoryTab()
        {
            AllureLogger.LogStep("I go to Status History tab", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#mccc32762-tab_anchor"),
                    "I go to History tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }

         public void TakeScreenshotOfStatusHistoryTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-008-SC05", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-008-SC05.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-008-SC05_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void GoToMileageHistoryTab()
        {
            AllureLogger.LogStep("I go to Mileage History tab", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#m1bf45dcd-tab_anchor"),
                    "I go to Mileage History tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


         public void TakeScreenshotOfMileageHistoryTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-008-SC06", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-008-SC06.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-008-SC06_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

        public void GoToWorkOrdersTab()
        {
            AllureLogger.LogStep("I go to Work Orders tab", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#ma71b55a-tab_anchor"),
                    "I go to Work Orders tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void TakeScreenshotOfWorkOrdersTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-008-SC07", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-008-SC07.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-008-SC07_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

        public void PressDialogOkButton()
        {
            AllureLogger.LogStep("I press dialog Ok button", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#md96348f9-pb"),
                    "I press dialog Ok button");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(5000).Wait();
            });
        }

        public void FilterUnit(string Unit) =>
         AllureLogger.LogStep($"I filter table Unit with '{Unit}'", () =>
         {
             By filterFieldUnit = By.CssSelector("#treeSearchBox");

             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
             IWebElement UnitField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldUnit));

             UnitField.Click();
             UnitField.Clear();
             UnitField.SendKeys(Unit);
             UnitField.SendKeys(Keys.Enter);
             Task.Delay(5000).Wait();
         });


         public void TakeScreenshotOfFilteredUnit() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-008-SC08", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-008-SC08.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-008-SC08_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });





        // Depot View Tab - Create a Move Request POM STEPS



        public void SelectCreateMoveRequest()
        {
            AllureLogger.LogStep("I select Create Move Request", () =>
            {
                // 1) Locate the road element to right-click on
                var roadElement = driver.FindElement(By.XPath(
                    "(//span[contains(@class,'brdfYardAssetLabel') and starts-with(@id,'RAILUNIT_') and contains(@id,'_label')])[1]"));

                // 2) Right-click on the road element
                var actions = new OpenQA.Selenium.Interactions.Actions(driver);
                actions.ContextClick(roadElement).Perform();

                // 3) Wait for the context menu item "Create Move Request" to appear
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
                var menuItemLocator = By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Create Move Request']");
                wait.Until(SeleniumWaits.ElementToBeClickable(menuItemLocator));

                // 4) Click the menu item
                driver.FindElement(menuItemLocator).Click();

                // 5) Optional: wait a little after clicking
                Task.Delay(3000).Wait();
            });
        }



        public void SelectValueLookupOfRoadField()
        {
            AllureLogger.LogStep("I select value lookup of Road field", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#ma1c7c0b2-img"),
                    "I select value lookup of Road field");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void FilterRoad(string Road) =>
        AllureLogger.LogStep($"I filter table Road with '{Road}'", () =>
        {
            By filterFieldRoad = By.CssSelector("#lookup_page2_tfrow_\\[C\\:0\\]_txt-tb");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement RoadField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldRoad));

            RoadField.Click();
            RoadField.Clear();
            RoadField.SendKeys(Road);
            RoadField.SendKeys(Keys.Enter);
            Task.Delay(5000).Wait();
        });


        public void SelectNoRecordFromRoadTable(int recordNumber) =>
       AllureLogger.LogStep($"I Select No {recordNumber} From Road Table Records", () =>
       {
           // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
           int zeroBasedIndex = recordNumber - 1;

           // Build dynamic Id selector by replacing the row index [R:x]
           string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

           SafeActions.Click(driver, By.Id(selector),
               $"I Select No {recordNumber} Record From Road Table Records");
           Task.Delay(3000).Wait();
       });


        public void SetMoveByDate() =>
        AllureLogger.LogStep("I set Move By Date", () =>
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            // Open Stop Date picker
            var stopDatePickerIcon = By.CssSelector("#m5c07fb-img");
            wait.Until(SeleniumWaits.ElementToBeClickable(stopDatePickerIcon)).Click();

            // Get today's day (e.g. "30")
            string todayDay = DateTime.Today.Day.ToString();

            // Updated selector using your new base structure
            var todayDateCell = By.XPath(
               $"//*[@id='m5c07fb-tb_popup_date']//td[not(contains(@class,'dijitCalendarDisabledDate'))]/span[text()='{todayDay}']"
            );

            wait.Until(SeleniumWaits.ElementToBeClickable(todayDateCell)).Click();

            // Click OK button
            var okButton = By.XPath("//*[@id=\"m5c07fb-tb_popup\"]/tbody/tr[2]/td/button[1]");
            wait.Until(SeleniumWaits.ElementToBeClickable(okButton)).Click();
            Task.Delay(3000).Wait();
        });


        public void ClickOkDailogButtonOfCreateMoveRequest()
        {
            AllureLogger.LogStep("I click ok dailog button of Create Move Request", () =>
            {
                // Click the OK dialog button
                SafeActions.Click(driver,
                    By.CssSelector("#m44dc6a5d-pb"),
                    "I click ok dailog button of Create Move Request");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(20000).Wait();
            });
        }


        public void TakeScreenshotOfCreateMoveRequest() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-009-SC01", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-009-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-009-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });


        public void GoToAtLocationTab()
        {
            AllureLogger.LogStep("I go to At Location Tab", () =>
            {
                // Click the OK dialog button
                SafeActions.Click(driver,
                    By.XPath("//button[normalize-space()='At Location']"),
                    "I go to At Location Tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }

        public void ClickActionCreateMoveRequest()
        {
            AllureLogger.LogStep("I click action Create Move Request", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Wait for Action menu to exist
                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Any());

                var actionMenu = driver.FindElements(By.CssSelector("span.action-menu"))
                                       .FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView({block:'center'});", actionMenu);

                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver)
                        .ExecuteScript("arguments[0].click();", actionMenu);
                }

                Task.Delay(1000).Wait();

                // Use stable text-based Dojo menu locator instead of dynamic ID
                var createMoveRequestLocator = By.XPath(
                    "//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Create Move Request']");

                var createMoveRequestOption = wait.Until(d =>
                {
                    var element = d.FindElements(createMoveRequestLocator)
                                   .FirstOrDefault(e => e.Displayed && e.Enabled);

                    return element;
                });

                if (createMoveRequestOption == null)
                    throw new NoSuchElementException("Create Move Request option was not found.");

                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView({block:'center'});", createMoveRequestOption);

                try
                {
                    createMoveRequestOption.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver)
                        .ExecuteScript("arguments[0].click();", createMoveRequestOption);
                }

                Task.Delay(3000).Wait();
            });
        }

        public void SelectActionCreateMoveRequest()
        {
            AllureLogger.LogStep("I select action Create Move Request", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Wait until at least one action menu exists in DOM
                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                // Get the first displayed action menu
                var actionMenu = driver.FindElements(By.CssSelector("span.action-menu"))
                                       .FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                // Scroll into view
                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView({block:'center'});", actionMenu);

                Task.Delay(500).Wait();

                // Click action menu (with fallback)
                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver)
                        .ExecuteScript("arguments[0].click();", actionMenu);
                }

                // ✅ Wait for menu items to be present
                wait.Until(d => d.FindElements(By.CssSelector("td.dijitMenuItemLabel")).Count > 0);

                IWebElement createMoveRequestOption = null;

                // ✅ Try ID first (your provided element)
                try
                {
                    createMoveRequestOption = wait.Until(
                        SeleniumWaits.ElementToBeClickable(
                            By.Id("dijit_MenuItem_60_text")));
                }
                catch
                {
                    // ✅ Fallback to text-based XPath (same as sample approach)
                    createMoveRequestOption = wait.Until(
                        SeleniumWaits.ElementToBeClickable(
                            By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Create Move Request']")));
                }

                // Scroll into view before clicking
                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView(true);", createMoveRequestOption);

                // Click with fallback
                try
                {
                    createMoveRequestOption.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver)
                        .ExecuteScript("arguments[0].click();", createMoveRequestOption);
                }

                // Wait for menu item to disappear
                wait.Until(d =>
                    !d.FindElements(By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Create Move Request']"))
                      .Any(e => e.Displayed));
            });
        }

        public void SelectCreateMoveRequestFromTheActionMenuOptions()
        {
            AllureLogger.LogStep("I select Create Move Request from the action menu options", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                var actionMenu = driver.FindElements(By.CssSelector("span.action-menu"))
                                       .FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView({ block: 'center' });", actionMenu);

                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver)
                        .ExecuteScript("arguments[0].click();", actionMenu);
                }

                wait.Until(d => d.FindElements(By.CssSelector("td.dijitMenuItemLabel")).Count > 0);

                IWebElement createMoveRequestOption = null;

                
                try
                {
                    createMoveRequestOption = wait.Until(
                        SeleniumWaits.ElementToBeClickable(
                            By.Id("dijit_MenuItem_8_text")));
                }
                catch
                {
                    // ✅ Stable fallback
                    createMoveRequestOption = wait.Until(
                        SeleniumWaits.ElementToBeClickable(
                            By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Create Move Request']")));
                }

                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView(true);", createMoveRequestOption);

                try
                {
                    createMoveRequestOption.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver)
                        .ExecuteScript("arguments[0].click();", createMoveRequestOption);
                }

                wait.Until(d =>
                    !d.FindElements(By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Create Move Request']"))
                      .Any(e => e.Displayed));
            });
        }

        public void ClickSelectActionMenuCreateMoveRequest()
        {
            AllureLogger.LogStep("I click select action menu Create Move Request", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                var actionMenu = driver.FindElements(By.CssSelector("span.action-menu"))
                                       .FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView({ block: 'center' });", actionMenu);

                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver)
                        .ExecuteScript("arguments[0].click();", actionMenu);
                }

                wait.Until(d => d.FindElements(By.CssSelector("td.dijitMenuItemLabel")).Count > 0);

                IWebElement createMoveRequestOption = null;

                // ✅ Updated ID based on provided element
                try
                {
                    createMoveRequestOption = wait.Until(
                        SeleniumWaits.ElementToBeClickable(
                            By.Id("dijit_MenuItem_64_text")));
                }
                catch
                {
                    // ✅ Stable fallback
                    createMoveRequestOption = wait.Until(
                        SeleniumWaits.ElementToBeClickable(
                            By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Create Move Request']")));
                }

                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView(true);", createMoveRequestOption);

                try
                {
                    createMoveRequestOption.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver)
                        .ExecuteScript("arguments[0].click();", createMoveRequestOption);
                }

                wait.Until(d =>
                    !d.FindElements(By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Create Move Request']"))
                      .Any(e => e.Displayed));
            });
        }

        public void SelectActionManageMoveRequest()
        {
            AllureLogger.LogStep("I select action Manage Move Request", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Wait until at least one action menu exists in DOM
                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                // Get the first displayed action menu
                var actionMenus = driver.FindElements(By.CssSelector("span.action-menu"));
                var actionMenu = actionMenus.FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                // Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView({block:'center'});", actionMenu);
                Task.Delay(500).Wait();

                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", actionMenu);
                }

                // Wait for "Manage Move Request" menu item and click it
                var manageMoveRequestOption = wait.Until(
                    SeleniumWaits.ElementToBeClickable(
                        By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Manage Move Request']")));

                manageMoveRequestOption.Click();

                // Wait for menu item to disappear
                wait.Until(SeleniumWaits.InvisibilityOfElementLocated(
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Manage Move Request']")));
            });
        }

        public void ModifyMoveByDate() =>
        AllureLogger.LogStep("I modify Move By Date", () =>
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            // Open Stop Date picker
            var stopDatePickerIcon = By.CssSelector("#m5c07fb-img");
            wait.Until(SeleniumWaits.ElementToBeClickable(stopDatePickerIcon)).Click();

            // Get tomorrow's day
             string tomorrowDay = DateTime.Today.AddDays(1).Day.ToString();
 
             var tomorrowDateCell = By.XPath(
                  $"//*[@id='m5c07fb-tb_popup_date']//td[not(contains(@class,'dijitCalendarDisabledDate'))]/span[text()='{tomorrowDay}']"
             );

                    wait.Until(SeleniumWaits.ElementToBeClickable(tomorrowDateCell)).Click();

              // Click OK button
              var okButton = By.XPath("//*[@id=\"m5c07fb-tb_popup\"]/tbody/tr[2]/td/button[1]");
              wait.Until(SeleniumWaits.ElementToBeClickable(okButton)).Click();
        });


        public void ClickOkDailogButtonOfMoveRequestDetails()
        {
            AllureLogger.LogStep("I click ok dailog button of Move Request Details", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#m44dc6a5d-pb"),
                    "I click ok dailog button of Move Request Details");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(20000).Wait();
            });
        }


        public void TakeScreenshotOfMoveRequestDetails() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-009-SC02", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-009-SC02.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-009-SC02_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });


        public void GoToPreppingTab()
        {
            AllureLogger.LogStep("I go to Prepping Tab", () =>
            {
                
                SafeActions.Click(driver,
                    By.XPath("//button[normalize-space()='Prepping']"),
                    "I go to Prepping Tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void SelectActionPrepConsist()
        {
            AllureLogger.LogStep("I select action Prep Consist", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Wait until at least one action menu exists in DOM
                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                // Get the first displayed action menu
                var actionMenus = driver.FindElements(By.CssSelector("span.action-menu"));
                var actionMenu = actionMenus.FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                // Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView({block:'center'});", actionMenu);
                Task.Delay(500).Wait();

                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", actionMenu);
                }

                // Wait for "Prep Consist" menu item and click it
                var prepConsistOption = wait.Until(
                    SeleniumWaits.ElementToBeClickable(
                        By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Prep Consist']")));

                prepConsistOption.Click();

                // Wait for menu item to disappear
                wait.Until(SeleniumWaits.InvisibilityOfElementLocated(
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Prep Consist']")));
            });
        }



        public void SetChooseADate() =>
        AllureLogger.LogStep("I set Choose a Date", () =>
        {
              var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
 
              // Open Date picker
             var stopDatePickerIcon = By.CssSelector("#m98b419bb-img");
             wait.Until(SeleniumWaits.ElementToBeClickable(stopDatePickerIcon)).Click();

             // Get today's day
             string todayDay = DateTime.Today.Day.ToString();

            // Dynamic selector for today's date (UPDATED popup ID)
            var todayDateCell = By.XPath(
                $"//*[@id='m98b419bb-tb_popup_date']//td[not(contains(@class,'dijitCalendarDisabledDate'))]/span[text()='{todayDay}']"
            );

                wait.Until(SeleniumWaits.ElementToBeClickable(todayDateCell)).Click();

              // Click OK button
              var okButton = By.XPath("//*[@id='m98b419bb-tb_popup']/tbody/tr[2]/td/button[1]");
               wait.Until(SeleniumWaits.ElementToBeClickable(okButton)).Click();
        });


        public void SelectValueLookupOfPreppedByField()
        {
            AllureLogger.LogStep("I select value lookup of Prepped By field", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#mee956baa-img"),
                    "I select value lookup of Prepped By field");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void FilterPerson(string Person) =>
        AllureLogger.LogStep($"I filter table Person with '{Person}'", () =>
        {
            By filterFieldPerson = By.CssSelector("#lookup_page2_tfrow_\\[C\\:0\\]_txt-tb");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement PersonField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldPerson));

            PersonField.Click();
            PersonField.Clear();
            PersonField.SendKeys(Person);
            PersonField.SendKeys(Keys.Enter);
            Task.Delay(5000).Wait();
        });


         public void SelectNoRecordFromPersonTable(int recordNumber) =>
       AllureLogger.LogStep($"I Select No {recordNumber} From Person Table Records", () =>
       {
           // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
           int zeroBasedIndex = recordNumber - 1;

           // Build dynamic Id selector by replacing the row index [R:x]
           string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

           SafeActions.Click(driver, By.Id(selector),
               $"I Select No {recordNumber} Record From Person Table Records");
       });


        public void EnterAdditionalInfo(string AdditionalInfo) =>
       AllureLogger.LogStep($"I enter Additional info '{AdditionalInfo}'", () =>
       {
           By filterFieldAdditionalInfo = By.CssSelector("#mab4a902a-ta");

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           IWebElement AdditionalInfoField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldAdditionalInfo));

           AdditionalInfoField.Click();
           AdditionalInfoField.Clear();
           AdditionalInfoField.SendKeys(AdditionalInfo);
           Task.Delay(5000).Wait();
       });


        public void ClickConfirmDailogButton()
        {
            AllureLogger.LogStep("I click Confirm dailog button", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#mc552b4c4-pb"),
                    "I click Confirm dailog button");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(20000).Wait();
            });
        }


        public void TakeScreenshotOfPrepConsist() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-009-SC03", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-009-SC03.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-009-SC03_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });

        public void TakeScreenshotOfMoveRequestInAtLocationTab() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-009-SC04", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-009-SC04.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-009-SC04_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });


        public void GoToMoveRequestTab()
        {
            AllureLogger.LogStep("I go to At Move Request Tab", () =>
            {
                
                SafeActions.Click(driver,
                    By.XPath("//button[normalize-space()='Move Requests (2)']"),
                    "I go to At Move Request Tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }

        public void SelectActionCancelMoveRequest()
        {
            AllureLogger.LogStep("I select action Cancel Move Request", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                var actionMenu = driver.FindElements(By.CssSelector("span.action-menu"))
                                       .FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView({block:'center'});", actionMenu);

                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver)
                        .ExecuteScript("arguments[0].click();", actionMenu);
                }

                wait.Until(d => d.FindElements(By.CssSelector("td.dijitMenuItemLabel")).Count > 0);

                IWebElement cancelMoveRequestOption = null;

                // ✅ Updated ID based on provided element
                try
                {
                    cancelMoveRequestOption = wait.Until(
                        SeleniumWaits.ElementToBeClickable(
                            By.Id("dijit_MenuItem_6_text")));
                }
                catch
                {
                    // ✅ Stable fallback
                    cancelMoveRequestOption = wait.Until(
                        SeleniumWaits.ElementToBeClickable(
                            By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Cancel Move Request']")));
                }

                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView(true);", cancelMoveRequestOption);

                try
                {
                    cancelMoveRequestOption.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver)
                        .ExecuteScript("arguments[0].click();", cancelMoveRequestOption);
                }

                wait.Until(d =>
                    !d.FindElements(By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Cancel Move Request']"))
                      .Any(e => e.Displayed));
            });
        }



        public void SelectActionChangeStatus()
        {
            AllureLogger.LogStep("I select action Change Status", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Locate and click the element directly
                var element = wait.Until(SeleniumWaits.ElementToBeClickable(
                    By.XPath("(//span[@data-grid='unknownGrid'][contains(text(),'⋮')])[1]")
                ));
                element.Click();

                // Click "Change Status"
                var changeStatusOption = wait.Until(SeleniumWaits.ElementToBeClickable(
                    By.XPath("//td[@id='dijit_MenuItem_6_text']")
                ));
                changeStatusOption.Click();

                // Replace with a real wait condition if possible
                wait.Until(d => changeStatusOption.Displayed == false);
            });
        }


        public void SelectCancelled()
        {
            AllureLogger.LogStep("I select Cancelled", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Locate the element to right-click
                var element = wait.Until(SeleniumWaits.ElementToBeClickable(
                    By.CssSelector("#ma3826107-img")));

                // Perform right-click (context click)
                Actions actions = new Actions(driver);
                actions.ContextClick(element).Perform();

                // Wait for the context menu item and click "Cancelled"
                var changeStatusOption = wait.Until(SeleniumWaits.ElementToBeClickable(
                    By.Id("menu0_CAN_OPTION_a")));

                changeStatusOption.Click();

                // Optional wait if UI needs time to update
                Task.Delay(3000).Wait();
            });
        }

        public void EnterMemoNotes(string MemoNotes) =>
        AllureLogger.LogStep($"I enter Memo Notes: {MemoNotes}", () =>
        {
            By filterFieldMemoNotes = By.CssSelector("#mad6cfe7d-tb");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement MemoNotesField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldMemoNotes));

            MemoNotesField.Click();
            MemoNotesField.Clear();
            MemoNotesField.SendKeys(MemoNotes);
            Task.Delay(5000).Wait();
        });

        public void ClickOkDailogButtonOfChangeMoveRequestStatus()
        {
            AllureLogger.LogStep("I click ok dailog button of Create Move Request", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#mebf9785c-pb"),
                    "I click ok dailog button of Create Move Request");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(20000).Wait();
            });
        }


        public void TakeScreenshotOfCancelledMoveRequest() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-009-SC05", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-009-SC05.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-009-SC05_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });





        // Depot View Tab - Actioning a Move Request POM STEPS



        public void ClickOkDailogButtonOfMoveRequest()
        {
            AllureLogger.LogStep("I click ok dailog button of Move Request", () =>
            {
               
                SafeActions.Click(driver,
                    By.CssSelector("#ma3b4d197-pb"),
                    "I click ok dailog button of Move Request");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(25000).Wait();
            });
        }

        public void TakeScreenshotOfCreateMoveRequestTest() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-010-SC01", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-010-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-010-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });


        public void GoToTabMoveRequest()
        {
            AllureLogger.LogStep("I go to At Move Request Tab", () =>
            {
                
                SafeActions.Click(driver,
                    By.XPath("//button[normalize-space()='Move Requests (1)']"),
                    "I go to At Move Request Tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void GoToDepotViewTab()
        {
            AllureLogger.LogStep("I go to At Depot View Tab", () =>
            {
               
                SafeActions.Click(driver,
                    By.XPath("//button[normalize-space()='Depot View']"),
                    "I go to At Depot View");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void MoveUnitToNextRoad()
        {
            AllureLogger.LogStep("I Move Unit to second empty Road", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                var sourceElement = wait.Until(
                    SeleniumWaits.ElementIsVisible(
                        By.XPath("(//span[contains(@class,'brdfYardAssetLabel') and starts-with(@id,'RAILUNIT_') and contains(@id,'_label')]/ancestor::div[contains(@class,'dijitTreeRow')])[1]")));

                var emptyRoads = wait.Until(driver =>
                {
                    var elements = driver.FindElements(By.XPath(
                        "//span[contains(@class,'brdfYardAssetLabel') and starts-with(@id,'RAILUNITEMPTY_ROAD_') and contains(@id,'_label')]/ancestor::div[contains(@class,'dijitTreeRow')]"));
                    return elements.Count > 0 ? elements : null;
                });

                var sourceX = sourceElement.Location.X;

                var matchingRoads = emptyRoads
                    .Where(e => e.Displayed && e.Location.X > sourceX)
                    .OrderBy(e => e.Location.X)
                    .ToList();

                if (matchingRoads.Count < 2)
                {
                    throw new NoSuchElementException("Less than two empty roads were found to the right of the source unit.");
                }

                IWebElement targetElement = matchingRoads[1]; // second empty road

                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView({block:'center'});", sourceElement);
                Task.Delay(500).Wait();

                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView({block:'center'});", targetElement);
                Task.Delay(500).Wait();

                var actions = new OpenQA.Selenium.Interactions.Actions(driver);
                actions
                    .MoveToElement(sourceElement)
                    .ClickAndHold(sourceElement)
                    .Pause(TimeSpan.FromMilliseconds(1000))
                    .MoveToElement(targetElement)
                    .Pause(TimeSpan.FromMilliseconds(1200))
                    .Release()
                    .Build()
                    .Perform();

                Task.Delay(3000).Wait();
            });
        }
               
        public void ClickYesDailogButtonOfSystemMessage()
        {
            AllureLogger.LogStep("I click Yes dailog button of system message", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#me1720906-pb"),
                    "I click Yes dailog button of system message");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(8000).Wait();
            });
        }


          public void SetActualMoveByDate() =>
         AllureLogger.LogStep("I set Actual Move By Date to Today", () =>
         {
               var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

               // Open Date picker
               var stopDatePickerIcon = By.CssSelector("#m2e9183f-img");
               wait.Until(SeleniumWaits.ElementToBeClickable(stopDatePickerIcon)).Click();

               // Get today's day
               string todayDay = DateTime.Today.Day.ToString();

               // Select today's date (ignoring disabled dates)
              var todayDateCell = By.XPath(
                   $"//*[@id='m2e9183f-tb_popup_date']//td[not(contains(@class,'dijitCalendarDisabledDate'))]/span[text()='{todayDay}']"
              );

               wait.Until(SeleniumWaits.ElementToBeClickable(todayDateCell)).Click();

              // Click OK button
              var okButton = By.XPath("//*[@id=\"m2e9183f-tb_popup\"]/tbody/tr[2]/td/button[1]");
              wait.Until(SeleniumWaits.ElementToBeClickable(okButton)).Click();
         });


        public void SelectValueLookupOfActualMovedByField()
        {
            AllureLogger.LogStep("I select value lookup of Actual Moved By field", () =>
            {
              
                SafeActions.Click(driver,
                    By.CssSelector("#m25bb4a0-img"),
                    "I select value lookup of Actual Moved By field");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void FilterActualPerson(string ActualPerson) =>
        AllureLogger.LogStep($"I filter table Actual Person with '{ActualPerson}'", () =>
        {
            By filterFieldActualPerson = By.CssSelector("#lookup_page2_tfrow_\\[C\\:0\\]_txt-tb");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement ActualPersonField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldActualPerson));

            ActualPersonField.Click();
            ActualPersonField.Clear();
            ActualPersonField.SendKeys(ActualPerson);
            ActualPersonField.SendKeys(Keys.Enter);
            Task.Delay(5000).Wait();
        });


         public void SelectNoRecordFromActualPersonTable(int recordNumber) =>
       AllureLogger.LogStep($"I Select No {recordNumber} From Actual Person Table Records", () =>
       {
           // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
           int zeroBasedIndex = recordNumber - 1;

           // Build dynamic Id selector by replacing the row index [R:x]
           string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

           SafeActions.Click(driver, By.Id(selector),
               $"I Select No {recordNumber} Record From Actual Person Table Records");
       });


        public void ClickOkDailogButtonOfConfirmRequest()
        {
            AllureLogger.LogStep("I click ok dailog button of Confirm Request", () =>
            {


                SafeActions.Click(driver,
                    By.XPath("//button[contains(@class,'pb') and normalize-space()='Confirm Request']"),
                    "I click Confirm Request button");

                Task.Delay(8000).Wait();
            });

        }


        public void TakeScreenshotOfMovedUnitInDepotViewTab() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-010-SC02", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-010-SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-010-SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });





        // Prepping Tab Viewing Prepping / Prepping a Train POM STEPS




          public void TakeScreenshotOfCreatedMoveRequest() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-011-SC01", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-011-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-011-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });


        public void TakeScreenshotOfMoveRequestInPreppingTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-011-SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-011-SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-011-SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void SelectPreppedSubTab()
        {
            AllureLogger.LogStep("I select prepped sub tab", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#preppingContainer_tablist_preppedTab"),
                    "I select prepped sub tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }

        public void SelectNoPrepRequiredSubTab()
        {
            AllureLogger.LogStep("I select No Prep Required sub Tab", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#preppingContainer_tablist_noPrepReqTab"),
                    "I select No Prep Required sub Tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void SelectUnpreppedSubTab()
        {
            AllureLogger.LogStep("I select unprepped sub Tab", () =>
            {
              
                SafeActions.Click(driver,
                    By.CssSelector("#preppingContainer_tablist_unPreppedTab"),
                    "I select unprepped sub Tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void TakeScreenshotOfCompletedPrepConsist() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-011-SC03", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-011-SC03.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-011-SC03_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

        public void SelectActionUnprepConsist()
        {
            AllureLogger.LogStep("I select action Unprep Consist", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Wait until at least one action menu exists in DOM
                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                // Get the first displayed action menu
                var actionMenus = driver.FindElements(By.CssSelector("span.action-menu"));
                var actionMenu = actionMenus.FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                // Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView({block:'center'});", actionMenu);
                Task.Delay(500).Wait();

                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", actionMenu);
                }

                // Wait for "Unprep Consist" menu item and click it
                var unprepConsistOption = wait.Until(
                    SeleniumWaits.ElementToBeClickable(
                        By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Un-Prep Consist']")));

                unprepConsistOption.Click();

                // Wait for menu item to disappear
                wait.Until(SeleniumWaits.InvisibilityOfElementLocated(
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Un-Prep Consist']")));
            });
        }

        public void SelectDialogYesButtomOfSystemMessage()
        {
            AllureLogger.LogStep("I select dialog Yes buttom of system message", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#m837dea79-pb"),
                    "I select dialog Yes buttom of system message");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(20000).Wait();
            });
        }


        public void TakeScreenshotOfUnprepConsist() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-011-SC04", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-011-SC04.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-011-SC04_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void SelectActionNoPrepRequired()
        {
            AllureLogger.LogStep("I select action No Prep Required", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Wait until at least one action menu exists in DOM
                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                // Get the first displayed action menu
                var actionMenus = driver.FindElements(By.CssSelector("span.action-menu"));
                var actionMenu = actionMenus.FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                // Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView({block:'center'});", actionMenu);
                Task.Delay(500).Wait();

                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", actionMenu);
                }

                // Wait for "No Prep Required" menu item and click it
                var noPrepRequiredOption = wait.Until(
                    SeleniumWaits.ElementToBeClickable(
                        By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='No Prep Required']")));

                noPrepRequiredOption.Click();

                // Wait for menu item to disappear
                wait.Until(SeleniumWaits.InvisibilityOfElementLocated(
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='No Prep Required']")));
            });
        }

        public void SelectYesDialogButtonOfSystemMessage()
        {
            AllureLogger.LogStep("I select Yes dialog button of system message", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#m862b5a7c-pb"),
                    "I select Yes dialog button of system message");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(20000).Wait();
            });
        }


        public void GoToNoPrepRequiredSubTab()
        {
            AllureLogger.LogStep("I go to No Prep Required sub tab", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#preppingContainer_tablist_noPrepReqTab"),
                    "I go to No Prep Required sub tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void TakeScreenshotOfNoPrepRequired() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-011-SC05", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-011-SC05.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-011-SC05_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });







        // In Service / Arriving Tab - View Planned Arrivals POM STEPS 



        public void GoToInServiceArrivingTab()
        {
            AllureLogger.LogStep("I go to In Service \\/ Arriving Tab", () =>
            {
                
                SafeActions.Click(driver,
                    By.XPath("//button[normalize-space()='In Service / Arriving']"),
                    "I go to In Service \\/ Arriving Tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


         public void TakeScreenshotOfPlannedArrivalsInInServiceArrivingTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-012-SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-012-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-012-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void SelectInServiceArrivalsSubTab()
        {
            AllureLogger.LogStep("I select In Service Arrivals sub tab", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#arrivalsContainer_tablist_inServiceTab"),
                    "I select In Service Arrivals sub tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


         public void TakeScreenshotOfInServiceSubTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-012-SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-012-SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-012-SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void SelectRecentlyArriveSubTab()
        {
            AllureLogger.LogStep("I select Recently Arrive sub tab", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#arrivalsContainer_tablist_recentlyArrivedTab"),
                    "I select Recently Arrive sub tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(5000).Wait();
            });
        }


        public void TakeScreenshotOfRecentlyArriveSubTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-012-SC03", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-012-SC03.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-012-SC03_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void SelectNoShowSubTab()
        {
            AllureLogger.LogStep("I select No Show sub tab", () =>
            {
                 Task.Delay(8000).Wait();
                 SafeActions.Click(driver,
                    By.CssSelector("#arrivalsContainer_tablist_noshowTab"),
                    "I select No Show sub tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void TakeScreenshotOfNoShowSubTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-012-SC04", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-012-SC04.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-012-SC04_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });






        // In Service / Arriving Tab - Action an Unplanned Arrival POM STEPS


        public void clickOnTheUnplannedArrivalButton()
        {
            AllureLogger.LogStep("I click on the Unplanned Arrival button", () =>
            {
               
                SafeActions.Click(driver,
                    By.XPath("//*[@id=\"arrivals\"]/div/div[1]/span[2]/button"),
                    "I click on the Unplanned Arrival button");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void TakeScreenshotOfUnplannedArrivalDialog() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-013-SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-013-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-013-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


            public void SelectNoRecordFromUnplannedArrivalTable(int recordNumber) =>
         AllureLogger.LogStep($"I Select No {recordNumber} From Unplanned Arrival Table Records", () =>
         {
             // Convert to zero-based index
             int zeroBasedIndex = recordNumber - 1;

             // Build dynamic Id selector using new pattern
             string selector = $"m1e2d5537_tdrow_[C:0]_tbselrow-ti[R:{zeroBasedIndex}]_img";

             SafeActions.Click(driver, By.Id(selector),
            $"I Select No {recordNumber} Record From Unplanned Arrival Table Records");
         });


        public void SelectOKButton()
        {
            AllureLogger.LogStep("I select OK button", () =>
            {
               
                SafeActions.Click(driver,
                    By.CssSelector("#mafd625d8-pb"),
                    "I select OK button");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(8000).Wait();
            });
        }

         public void TakeScreenshotOfUnplannedArrivalServiceAddedToPlannedArrivals() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-013-SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-013-SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-013-SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

        public void SelectActionArriveToRoad()
        {
            AllureLogger.LogStep("I select Arrive to Road", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
                By actionMenuLocator = By.CssSelector("span.action-menu");
                By arriveToRoadLocator = By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Arrive to road']");

                // Wait until at least one action menu exists in DOM
                wait.Until(d => d.FindElements(actionMenuLocator).Count > 0);

                IWebElement actionMenu = null;

                // Retry to handle stale element issues
                for (int attempt = 0; attempt < 3; attempt++)
                {
                    try
                    {
                        // Re-find the first visible action menu each time
                        actionMenu = driver.FindElements(actionMenuLocator)
                                           .FirstOrDefault(x => x.Displayed);

                        if (actionMenu == null)
                            throw new NoSuchElementException("No visible action menu was found.");

                        // Scroll into view
                        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView({block:'center'});", actionMenu);
                        Task.Delay(500).Wait();

                        // Click action menu
                        try
                        {
                            actionMenu.Click();
                        }
                        catch
                        {
                            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", actionMenu);
                        }

                        // Exit retry loop if successful
                        break;
                    }
                    catch (StaleElementReferenceException)
                    {
                        if (attempt == 2)
                            throw;

                        Task.Delay(500).Wait();
                    }
                }

                // Wait for "Arrive to Road" menu item and click it
                var arriveToRoadOption = wait.Until(
                    SeleniumWaits.ElementToBeClickable(arriveToRoadLocator));

                arriveToRoadOption.Click();

                // Wait for menu item to disappear
                wait.Until(SeleniumWaits.InvisibilityOfElementLocated(arriveToRoadLocator));
            });
        }

        public void SelectValueLookupOfArrivalRoadField()
        {
            AllureLogger.LogStep("I select value lookup of Arrival Road field", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#m64daaac4-img"),
                    "I select value lookup of Arrival Road field");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }

        
        public void FilterArrivalRoad(string ArrivalRoad) =>
        AllureLogger.LogStep($"I filter table Arrival Road with '{ArrivalRoad}'", () =>
        {
            By filterFieldArrivalRoad = By.CssSelector("#lookup_page2_tfrow_\\[C\\:0\\]_txt-tb");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement ArrivalRoadField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldArrivalRoad));

            ArrivalRoadField.Click();
            ArrivalRoadField.Clear();
            ArrivalRoadField.SendKeys(ArrivalRoad);
            ArrivalRoadField.SendKeys(Keys.Enter);
            Task.Delay(5000).Wait();
        });


         public void SelectNoRecordFromArrivalRoadTable(int recordNumber) =>
       AllureLogger.LogStep($"I Select No {recordNumber} From Arrival Road Table Records", () =>
       {
           // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
           int zeroBasedIndex = recordNumber - 1;

           // Build dynamic Id selector by replacing the row index [R:x]
           string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

           SafeActions.Click(driver, By.Id(selector),
               $"I Select No {recordNumber} Record From Arrival Road Table Records");
       });


        public void SetArrived()
        {
            AllureLogger.LogStep("I set Arrived", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                // Open DateTime picker
                var dateTimePickerIcon = By.CssSelector("#mce152038-img");
                wait.Until(SeleniumWaits.ElementToBeClickable(dateTimePickerIcon)).Click();

                // ---- DATE ----
                string todayDay = DateTime.Today.Day.ToString();

                var todayDateCell = By.XPath(
                    $"//*[@id='mce152038-tb_popup_date']//td[not(contains(@class,'dijitCalendarDisabledDate'))]/span[text()='{todayDay}']"
                );
                wait.Until(SeleniumWaits.ElementToBeClickable(todayDateCell)).Click();

                // ---- TIME (last enabled of the day) ----
                var lastTimeOption = By.XPath(
                    "(//*[@id='mce152038-tb_popup_time']//div[contains(@class,'dijitTimePickerItem') and not(contains(@class,'dijitTimePickerItemDisabled'))])[last()]"
                );
                wait.Until(SeleniumWaits.ElementToBeClickable(lastTimeOption)).Click();

                // ---- OK ----
                var okButton = By.XPath("//*[@id='mce152038-tb_popup']//button[1]");
                wait.Until(SeleniumWaits.ElementToBeClickable(okButton)).Click();
            });
        }


        public void SetAccepted()
        {
            AllureLogger.LogStep("I set Accepted", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                // Open DateTime picker
                var dateTimePickerIcon = By.CssSelector("#mfce55f68-img");
                wait.Until(SeleniumWaits.ElementToBeClickable(dateTimePickerIcon)).Click();

                // ---- DATE ----
                string todayDay = DateTime.Today.Day.ToString();

                var todayDateCell = By.XPath(
                    $"//*[@id='mfce55f68-tb_popup_date']//td[not(contains(@class,'dijitCalendarDisabledDate'))]/span[text()='{todayDay}']"
                );
                wait.Until(SeleniumWaits.ElementToBeClickable(todayDateCell)).Click();

                // ---- TIME (last available, not disabled) ----
                var lastTimeOption = By.XPath(
                    "(//*[@id='mfce55f68-tb_popup_time']//div[contains(@class,'dijitTimePickerItem') and not(contains(@class,'dijitTimePickerItemDisabled'))])[last()]"
                );
                wait.Until(SeleniumWaits.ElementToBeClickable(lastTimeOption)).Click();

                // ---- OK ----
                var okButton = By.XPath("//*[@id='mfce55f68-tb_popup']//button[1]");
                wait.Until(SeleniumWaits.ElementToBeClickable(okButton)).Click();
            });
        }

        public void SetYard() =>
        AllureLogger.LogStep("I set Arrived", () =>
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            // Open Date picker
            var stopDatePickerIcon = By.CssSelector("#m42bff135-img");
            wait.Until(SeleniumWaits.ElementToBeClickable(stopDatePickerIcon)).Click();

            // Get today's day
            string todayDay = DateTime.Today.Day.ToString();

            // Select today's date
           var todayDateCell = By.XPath(
               $"//*[@id='m42bff135-tb_popup_date']//td[not(contains(@class,'dijitCalendarDisabledDate'))]/span[text()='{todayDay}']"
           );
            wait.Until(SeleniumWaits.ElementToBeClickable(todayDateCell)).Click();

           // Select LAST available time dynamically
           var lastTimeOption = By.XPath(
               "//*[@id='m42bff135-tb_popup_time']/div[not(contains(@class,'dijitTimePickerItemDisabled'))][last()]"
           );
            wait.Until(SeleniumWaits.ElementToBeClickable(lastTimeOption)).Click();

            // Click OK button
            var okButton = By.XPath("//*[@id='m42bff135-tb_popup']/tbody/tr[2]/td/button[1]");
            wait.Until(SeleniumWaits.ElementToBeClickable(okButton)).Click();
            Task.Delay(3000).Wait();
        });

        public void SelectDialogArriveServiceButton()
        {
            AllureLogger.LogStep("I select dialog Arrive Service button", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#m3e7d5b40-pb"),
                    "I select dialog Arrive Service button");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(30000).Wait();
            });
        }



        public void TakeScreenshotOfArriveService() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-013-SC03", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-013-SC03.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-013-SC03_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });





        // In Service / Arriving Tab - Manually Allocating Units (If TRENT Integration is not available) POM STEPS



        public void SelectGenerateButton()
        {
            AllureLogger.LogStep("I select Generate button", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#brdfsmcontrol_div_dhtmlx > div.dhxlayout_cont > div:nth-child(2) > div.dhx_cell_cont_layout.dhx_cell_cont_no_borders > div > div > div:nth-child(1) > div.dhx_cell_cont_layout.dhx_cell_cont_no_borders > div > div > div:nth-child(1) > div.dhx_cell_ribbon_def > div > div > div > div:nth-child(1) > div.dhxrb_block_items > div:nth-child(1)"),
                    "I select Generate button");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(5000).Wait();
            });
        }


        public void SelectValueLookupOfTimetableNameField()
        {
            AllureLogger.LogStep("I select value lookup of Timetable Name field", () =>
            {
               
                SafeActions.Click(driver,
                    By.CssSelector("#m51920565-img"),
                    "I select value lookup of Timetable Name field");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


      
         public void SelectNoRecordFromTimetableNameTableRecords(int recordNumber) =>
       AllureLogger.LogStep($"I Select No {recordNumber} From Timetable Name Table Records", () =>
       {
           // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
           int zeroBasedIndex = recordNumber - 1;

           // Build dynamic Id selector by replacing the row index [R:x]
           string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

           SafeActions.Click(driver, By.Id(selector),
               $"I Select No {recordNumber} Record From Timetable Name Table Records");
       });


        public void PressDialogOKButtonOfGenerateDailyService()
        {
            AllureLogger.LogStep("I press dialog OK button of Generate Daily Service", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#m1790e1a3-pb"),
                    "I press dialog OK button of Generate Daily Service");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void TakeScreenshotOfServiceManagementDailyServiceGenerated() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-014-SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-014-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-014-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

        public void SelectServiceLinesFromTableRecords()
        {
            AllureLogger.LogStep("I Service lines from table records", () =>
            {
               
                SafeActions.Click(driver,
                    By.XPath("//body[1]/form[1]/div[1]/table[2]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[2]/td[1]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[2]/td[1]/table[1]/tbody[1]/tr[2]/td[1]/div[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/table[1]/tbody[1]/tr[2]/td[1]"),
                    "I Service lines from table records");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }

        public void SelectAddLineButton()
        {
            AllureLogger.LogStep("I select Add Line button", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#brdfsmcontrol_div_dhtmlx > div.dhxlayout_cont > div:nth-child(2) > div.dhx_cell_cont_layout.dhx_cell_cont_no_borders > div > div > div:nth-child(1) > div.dhx_cell_cont_layout.dhx_cell_cont_no_borders > div > div > div:nth-child(1) > div.dhx_cell_ribbon_def > div > div > div > div:nth-child(1) > div.dhxrb_block_items > div.dhxrb_3rows_block > div:nth-child(1) > div"),
                    "I select Add Line button");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void SelectValueLookupOfDestinationField()
        {
            AllureLogger.LogStep("I select value lookup of Destination field", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#mc1cb3a7d-img"),
                    "I select value lookup of Destination field");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }

        public void FilterDestination(string Destination) =>
        AllureLogger.LogStep($"I filter table Destination with '{Destination}'", () =>
        {
            By filterFieldDestination = By.CssSelector("#lookup_page2_tfrow_\\[C\\:0\\]_txt-tb");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement DestinationField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldDestination));

            DestinationField.Click();
            DestinationField.Clear();
            DestinationField.SendKeys(Destination);
            DestinationField.SendKeys(Keys.Enter);
            Task.Delay(5000).Wait();
        });


        public void SelectNoRecordFromDestinationTableRecords(int recordNumber) =>
       AllureLogger.LogStep($"I Select No {recordNumber} From Destination Table Records", () =>
       {
           // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
           int zeroBasedIndex = recordNumber - 1;

           // Build dynamic Id selector by replacing the row index [R:x]
           string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

           SafeActions.Click(driver, By.Id(selector),
               $"I Select No {recordNumber} Record From Destination Table Records");
       });

        public void EnterRunNumber(string RunNumber) =>
       AllureLogger.LogStep($"I filter table Run Number with '{RunNumber}'", () =>
       {
           By filterFieldRunNumber = By.CssSelector("#mc9c5ec08-tb");

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           IWebElement RunNumberField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldRunNumber));

           RunNumberField.Click();
           RunNumberField.Clear();
           RunNumberField.SendKeys(RunNumber);
           Task.Delay(3000).Wait();
       });


          public void EnterAddAServiceLineMemo(string Memo) =>
        AllureLogger.LogStep($"I enter Memo = '{Memo}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

            // Adjust column indexes if needed
            By MemoLocator = By.CssSelector("#mbec2dc9e-ta");
           

            // Description filter
            IWebElement MemoFilter = wait.Until(SeleniumWaits.ElementToBeClickable(MemoLocator));
            MemoFilter.Click();
            MemoFilter.Clear();
            MemoFilter.SendKeys(Memo);
                      
        });


        public void SetDepartureTime(string DepartureTime) =>
        AllureLogger.LogStep($"I set Departure Time = '{DepartureTime}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

            // Adjust column indexes if needed
            By DepartureTimeLocator = By.CssSelector("#mbf7a46c0-tb");


            // Description filter
            IWebElement DepartureTimeFilter = wait.Until(SeleniumWaits.ElementToBeClickable(DepartureTimeLocator));
            DepartureTimeFilter.Click();
            DepartureTimeFilter.Clear();
            DepartureTimeFilter.SendKeys(DepartureTime);

        });


        public void SetArrivalTime(string ArrivalTime) =>
        AllureLogger.LogStep($"I set Arrival Time = '{ArrivalTime}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

            // Adjust column indexes if needed
            By ArrivalTimeLocator = By.CssSelector("#mc87d7656-tb");


            // Description filter
            IWebElement ArrivalTimeFilter = wait.Until(SeleniumWaits.ElementToBeClickable(ArrivalTimeLocator));
            ArrivalTimeFilter.Click();
            ArrivalTimeFilter.Clear();
            ArrivalTimeFilter.SendKeys(ArrivalTime);

        });


        public void PressDialogOKButtonOfAddAServiceLine()
        {
            AllureLogger.LogStep("I press dialog OK button of Add a Service Line", () =>
            {
               
                SafeActions.Click(driver,
                    By.CssSelector("#m5645eeec-pb"),
                    "I press dialog OK button of Add a Service Line");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(12000).Wait();
            });
        }

       
        public void TakeScreenshotOfDestinationTableWithNewServiceLineAdded() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-014-SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-014-SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-014-SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void SelectServiceLinesToPrep()
        {
            AllureLogger.LogStep("I select Service lines to prep", () =>
            {

                SafeActions.Click(driver,
                    By.XPath("/html/body/form/div/table[2]/tbody/tr/td/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[2]/td/div/table/tbody/tr/td/div/table/tbody/tr/td/table/tbody/tr/td/div/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr[2]/td/div/table/tbody/tr[3]/td/table/tbody/tr/td/div/table/tbody/tr/td/div/table/tbody/tr/td/table/tbody/tr/td/div/div[1]/div[3]/div[2]/div[2]/div/div/div[1]/div[2]/div/div/div[2]/div[2]/div/div/div/div[2]/div[1]/div/div[2]/table/tbody/tr[2]/td[1]"),
                    "I select Service lines to prep");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(10000).Wait();
            });
        }


        public void SelectPrepButton()
        {
            AllureLogger.LogStep("I select Prep button", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                var locator = By.XPath("//*[@id=\"brdfsmcontrol_div_dhtmlx\"]/div[1]/div[2]/div[2]/div/div/div[1]/div[2]/div/div/div[1]/div[2]/div/div/div/div[1]/div[1]/div[2]/img");

                var element = wait.Until(SeleniumWaits.ElementToBeClickable(locator));

                element.Click();
                Task.Delay(10000).Wait();

            });
        }


        public void SelectServiceLinesToDepart()
        {
            AllureLogger.LogStep("I select Service lines to depart", () =>
            {

                SafeActions.Click(driver,
                    By.XPath("/html/body/form/div/table[2]/tbody/tr/td/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[2]/td/div/table/tbody/tr/td/div/table/tbody/tr/td/table/tbody/tr/td/div/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr[2]/td/div/table/tbody/tr[3]/td/table/tbody/tr/td/div/table/tbody/tr/td/div/table/tbody/tr/td/table/tbody/tr/td/div/div[1]/div[5]/div[2]/div[2]/div/div/div[1]/div[2]/div/div/div[2]/div[2]/div/div/div/div[2]/div[1]/div/div[2]/table/tbody/tr[2]/td[4]"),
                    "I select Service lines to depart");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(20000).Wait();
            });
        }

        public void SelectPrepUnitFromTableRecords()
        {
            AllureLogger.LogStep("I select Prep unit from table records", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));

                var locator = By.XPath("//body/form/div/table[2]/tbody/tr/td/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[2]/td/div/table/tbody/tr/td/div/table/tbody/tr/td/table/tbody/tr/td/div/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr[2]/td/div/table/tbody/tr[3]/td/table/tbody/tr/td/div/table/tbody/tr/td/div/table/tbody/tr/td/table/tbody/tr/td/div/div[1]/div[3]/div[2]/div[2]/div/div/div[1]/div[2]/div/div/div[2]/div[2]/div/div/div/div[2]/div[1]/div/div[2]/table/tbody/tr[2]/td[1]");

                var element = wait.Until(SeleniumWaits.ElementToBeClickable(locator));

                element.Click();
                Task.Delay(5000).Wait();
            });
        }


        public void SelectDepartButton()
        {
            AllureLogger.LogStep("I select Depart button", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                var locator = By.XPath("/html/body/form/div/table[2]/tbody/tr/td/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[2]/td/div/table/tbody/tr/td/div/table/tbody/tr/td/table/tbody/tr/td/div/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr[2]/td/div/table/tbody/tr[3]/td/table/tbody/tr/td/div/table/tbody/tr/td/div/table/tbody/tr/td/table/tbody/tr/td/div/div[1]/div[3]/div[2]/div[2]/div/div/div[1]/div[2]/div/div/div[1]/div[2]/div/div/div/div[2]/div[1]/div[1]/div");

                var element = wait.Until(SeleniumWaits.ElementToBeClickable(locator));

                element.Click();
                Task.Delay(5000).Wait();
            });
        }


        public void SelectValueLookupOfDelayCodeField()
        {
            AllureLogger.LogStep("I select value lookup of Delay Code field", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#mf7d21bb1_tdrow_\\[C\\:5\\]_txt-img\\[R\\:0\\]"),
                    "I select value lookup of Delay Code field");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }

         public void FilterTableDelayCode(string DelayCode) =>
       AllureLogger.LogStep($"I filter table Delay Code = '{DelayCode}'", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

           // Adjust column indexes if needed
           By DelayCodeLocator = By.CssSelector("#lookup_page2_tfrow_\\[C\\:0\\]_txt-tb");


           // Description filter
           IWebElement DelayCodeFilter = wait.Until(SeleniumWaits.ElementToBeClickable(DelayCodeLocator));
           DelayCodeFilter.Click();
           DelayCodeFilter.Clear();
           DelayCodeFilter.SendKeys(DelayCode);
           DelayCodeFilter.SendKeys(Keys.Enter);
           Task.Delay(5000).Wait();

       });

        public void SelectNoRecordDelayCodeTableRecords(int recordNumber) =>
       AllureLogger.LogStep($"I Select No {recordNumber} From Delay Code Table Records", () =>
       {
           // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
           int zeroBasedIndex = recordNumber - 1;

           // Build dynamic Id selector by replacing the row index [R:x]
           string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

           SafeActions.Click(driver, By.Id(selector),
               $"I Select No {recordNumber} Record From Delay Code Table Records");
           Task.Delay(5000).Wait();
       });

        public void EnterFollowingData(string DelayReason, string DepartureTimeChangeReason) =>
       AllureLogger.LogStep($"I enter following Depart Run details Delay Reason = '{DelayReason}', Departure Time Change Reason = '{DepartureTimeChangeReason}','", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

           // Adjust column indices as per actual table structure:
           // Description = column 2 → C:2
           // Status = column 10 → C:10

           By DelayReasonFilterLocator = By.CssSelector("#mf7d21bb1_tdrow_\\[C\\:6\\]_txt-tb\\[R\\:0\\]");
           By DepartureTimeChangeReasonFilterLocator = By.CssSelector("#mf7d21bb1_tdrow_\\[C\\:7\\]_txt-tb\\[R\\:0\\]");

           IWebElement DelayReasonFilter = wait.Until(SeleniumWaits.ElementToBeClickable(DelayReasonFilterLocator));
           DelayReasonFilter.Click();
           DelayReasonFilter.Clear();
           DelayReasonFilter.SendKeys(DelayReason);
           
           IWebElement DepartureTimeChangeReasonFilter = wait.Until(SeleniumWaits.ElementToBeClickable(DepartureTimeChangeReasonFilterLocator));
           DepartureTimeChangeReasonFilter.Click();
           DepartureTimeChangeReasonFilter.Clear();
           DepartureTimeChangeReasonFilter.SendKeys(DepartureTimeChangeReason);
           Task.Delay(3000).Wait();

       });

        public void PressDialogOKButtonOfDepartRun()
        {
            AllureLogger.LogStep("I press dialog OK button of Depart Run", () =>
            {
                // Click the OK dialog button
                SafeActions.Click(driver,
                    By.CssSelector("#m3e275b38-pb"),
                    "I press dialog OK button of Depart Run");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }

        public void GoToInServiceTab()
        {
            AllureLogger.LogStep("I go to In Service Tab", () =>
            {
                // Click the OK dialog button
                SafeActions.Click(driver,
                    By.CssSelector("#brdfsmcontrol_div_dhtmlx > div.dhxlayout_cont > div:nth-child(2) > div.dhx_cell_cont_layout.dhx_cell_cont_no_borders > div > div > div:nth-child(1) > div.dhx_cell_cont_layout.dhx_cell_cont_no_borders > div > div > div:nth-child(2) > div.dhx_cell_cont_layout.dhx_cell_cont_no_borders > div > div > div > div.dhxtabbar_tabs.dhxtabbar_tabs_top > div.dhxtabbar_tabs_base > div > div:nth-child(4)"),
                    "I go to In Service Tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }

         public void TakeScreenshotOfServiceTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-014-SC03", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-014-SC03.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-014-SC03_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

        public void SelectListViewButton()
        {
            AllureLogger.LogStep("I select List View button", () =>
            {
                // Click the OK dialog button
                SafeActions.Click(driver,
                    By.Id("m397b0593-tabs_middle"),
                    "I select List View button");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(5000).Wait();
            });
        }

        public void GoToScheduledArrivalsTab()
        {
            AllureLogger.LogStep("I go to Scheduled Arrivals Tab", () =>
            {
                // Click the OK dialog button
                SafeActions.Click(driver,
                    By.CssSelector("#brdfsmcontrol_div_dhtmlx > div.dhxlayout_cont > div:nth-child(2) > div.dhx_cell_cont_layout.dhx_cell_cont_no_borders > div > div > div:nth-child(1) > div.dhx_cell_cont_layout.dhx_cell_cont_no_borders > div > div > div:nth-child(2) > div.dhx_cell_cont_layout.dhx_cell_cont_no_borders > div > div > div > div.dhxtabbar_tabs.dhxtabbar_tabs_top > div.dhxtabbar_tabs_base > div > div.dhxtabbar_tab.dhxtabbar_tab_actv"),
                    "I go to Scheduled Arrivals Tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }

        public void TakeScreenshotOfScheduledArrivalsTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-014-SC04", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-014-SC04.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-014-SC04_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

         public void TakeScreenshotOfArriveServiceTest() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-015-SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-015-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-015-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


         public void TakeScreenshotOfDepotViewTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-015-SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-015-SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-015-SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void ICoupleUnit()
        {
            AllureLogger.LogStep("I couple unit", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                // 1) Locate the first source unit row
                var sourceElement = wait.Until(
                    SeleniumWaits.ElementIsVisible(
                        By.XPath("(//span[contains(@class,'brdfYardAssetLabel') and starts-with(@id,'RAILUNIT_') and contains(@id,'_label')]/ancestor::div[contains(@class,'dijitTreeRow')])[1]")));

                // 2) Locate the second unit row as the target
                var targetElement = wait.Until(
                    SeleniumWaits.ElementIsVisible(
                        By.XPath("(//span[contains(@class,'brdfYardAssetLabel') and starts-with(@id,'RAILUNIT_') and contains(@id,'_label')]/ancestor::div[contains(@class,'dijitTreeRow')])[2]")));

                // 3) Scroll both elements into view
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView({block:'center'});", sourceElement);
                Task.Delay(500).Wait();

                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView({block:'center'});", targetElement);
                Task.Delay(500).Wait();

                // 4) Perform drag-and-drop from first unit to second unit
                var actions = new OpenQA.Selenium.Interactions.Actions(driver);
                actions
                    .MoveToElement(sourceElement)
                    .ClickAndHold(sourceElement)
                    .Pause(TimeSpan.FromMilliseconds(1000))
                    .MoveToElement(targetElement)
                    .Pause(TimeSpan.FromMilliseconds(1200))
                    .Release()
                    .Build()
                    .Perform();

                // 5) Optional wait after action
                Task.Delay(30000).Wait();
            });
        }


        public void TakeScreenshotOfCoupledUnit() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-014-SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-014-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-014-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
           Task.Delay(20000).Wait();
       });


        public void IUncoupleUnit()
        {
            AllureLogger.LogStep("I uncouple unit", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                var js = (IJavaScriptExecutor)driver;

                // Wait for loader overlay to disappear
                wait.Until(d =>
                {
                    try
                    {
                        var overlay = d.FindElement(By.Id("wait"));
                        return !overlay.Displayed;
                    }
                    catch (NoSuchElementException) { return true; }
                    catch (StaleElementReferenceException) { return true; }
                });

                // Locate the first available unit label
                var unitLabel = wait.Until(
                    SeleniumWaits.ElementIsVisible(
                        By.XPath("(//span[contains(@class,'brdfYardAssetLabel') and starts-with(@id,'RAILUNIT_')])[1]")));

                string unitId = unitLabel.GetAttribute("id");

                // Use the row node / tree node for better right-click stability
                var unitRow = wait.Until(
                    SeleniumWaits.ElementExists(
                        By.XPath($"//span[@id='{unitId}']/ancestor::div[contains(@class,'dijitTreeRow')]")));

                js.ExecuteScript("arguments[0].scrollIntoView({block:'center'});", unitRow);
                Task.Delay(500).Wait();

                // Select the unit first
                try
                {
                    unitLabel.Click();
                }
                catch
                {
                    js.ExecuteScript("arguments[0].click();", unitLabel);
                }

                Task.Delay(1000).Wait();

                // Wait again for overlay after selection
                wait.Until(d =>
                {
                    try
                    {
                        var overlay = d.FindElement(By.Id("wait"));
                        return !overlay.Displayed;
                    }
                    catch (NoSuchElementException) { return true; }
                    catch (StaleElementReferenceException) { return true; }
                });

                // Re-find row after DOM refresh
                unitRow = wait.Until(
                    SeleniumWaits.ElementExists(
                        By.XPath($"//span[@id='{unitId}']/ancestor::div[contains(@class,'dijitTreeRow')]")));

                js.ExecuteScript("arguments[0].scrollIntoView({block:'center'});", unitRow);
                Task.Delay(500).Wait();

                // Right-click the row, not the label
                new Actions(driver)
                    .MoveToElement(unitRow)
                    .ContextClick(unitRow)
                    .Perform();

                Task.Delay(1000).Wait();

                // Wait for a visible Dijit menu to appear
                wait.Until(d =>
                {
                    var menus = d.FindElements(By.XPath("//div[contains(@class,'dijitMenu') and not(contains(@style,'display: none'))]"));
                    return menus.Count > 0;
                });

                // Locate the Uncouple option more robustly
                var uncoupleOption = wait.Until(d =>
                {
                    var elements = d.FindElements(By.XPath(
                        "//td[contains(@class,'dijitMenuItemLabel') and contains(normalize-space(.),'Uncouple')] | " +
                        "//div[contains(@class,'dijitMenuItem')]//td[contains(normalize-space(.),'Uncouple')] | " +
                        "//div[contains(@class,'dijitMenuItem')]//*[self::td or self::span][contains(normalize-space(.),'Uncouple')]"));

                    return elements.FirstOrDefault(e => e.Displayed);
                });

                if (uncoupleOption == null)
                    throw new NoSuchElementException("Uncouple option was not found in the visible context menu.");

                js.ExecuteScript("arguments[0].scrollIntoView({block:'center'});", uncoupleOption);
                Task.Delay(300).Wait();

                try
                {
                    uncoupleOption.Click();
                }
                catch
                {
                    js.ExecuteScript("arguments[0].click();", uncoupleOption);
                }

                // Wait for UI update
                Task.Delay(30000).Wait();
            });
        }


        public void TakeScreenshotOfUncoupledUnit() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-014-SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-014-SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-014-SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });




        // In Service / Arriving Tab - Un-Arrive a Recently Arrived Train POM STEPS





        public void SelectActionUnArrive()
        {
            AllureLogger.LogStep("I select action Un-arrive", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Wait until at least one action menu exists in DOM
                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                // Get the first displayed action menu
                var actionMenus = driver.FindElements(By.CssSelector("span.action-menu"));
                var actionMenu = actionMenus.FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                // Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView({block:'center'});", actionMenu);
                Task.Delay(500).Wait();

                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", actionMenu);
                }

                // Wait for "Un-arrive" menu item and click it
                var unArriveOption = wait.Until(
                    SeleniumWaits.ElementToBeClickable(
                        By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Un-arrive']")));

                unArriveOption.Click();

                // Wait for menu item to disappear
                wait.Until(SeleniumWaits.InvisibilityOfElementLocated(
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Un-arrive']")));
            });
        }


        public void TakeScreenshotOfUnArriveARecentlyArrivedTrainDialog() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-016-SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-016-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-016-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });




        // In Service / Arriving Tab - Mark a Unit as No Show or Delayed POM STEPS



        public void SelectActionManageNonArrival()
        {
            AllureLogger.LogStep("I select action Manage Non-Arrival", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Wait until at least one action menu exists in DOM
                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                // Get the first displayed action menu
                var actionMenus = driver.FindElements(By.CssSelector("span.action-menu"));
                var actionMenu = actionMenus.FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                // Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView({block:'center'});", actionMenu);
                Task.Delay(500).Wait();

                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", actionMenu);
                }

                // Wait for "Manage Non-Arrival" menu item and click it
                var manageNonArrivalOption = wait.Until(
                    SeleniumWaits.ElementToBeClickable(
                        By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Manage Non-Arrival']")));

                manageNonArrivalOption.Click();

                // Wait for menu item to disappear
                wait.Until(SeleniumWaits.InvisibilityOfElementLocated(
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Manage Non-Arrival']")));
            });
        }

        public void AddMemo(string Comment) =>
       AllureLogger.LogStep($"I Add Memo '{Comment}'", () =>
       {
           By filterFieldComment = By.CssSelector("#mb0c3892c-ta");

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           IWebElement CommentField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldComment));

           CommentField.Click();
           CommentField.Clear();
           CommentField.SendKeys(Comment);
           Task.Delay(3000).Wait();
       });


        public void SelectConfirmNonArrivalButton()
        {
            AllureLogger.LogStep("I select Confirm Non-Arrival button", () =>
            {
               
                SafeActions.Click(driver,
                    By.CssSelector("#md84e25e6-pb"),
                    "I select Confirm Non-Arrival button");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(12000).Wait();
            });
        }

         public void TakeScreenshotOfNoShow() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-017-SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-017-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-017-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });




        // In Service / Arriving Tab Mark as Delayed POM STEPS



        public void SelectActionManageDelay()
        {
            AllureLogger.LogStep("I select action Manage Delay", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                // Wait until at least one action menu exists in DOM
                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                // Get the first displayed action menu
                var actionMenus = driver.FindElements(By.CssSelector("span.action-menu"));
                var actionMenu = actionMenus.FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                // Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView({block:'center'});", actionMenu);
                Task.Delay(500).Wait();

                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", actionMenu);
                }

                // Wait for "Manage Delay" menu item and click it
                var manageDelayOption = wait.Until(
                    SeleniumWaits.ElementToBeClickable(
                        By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Manage Delay']")));

                manageDelayOption.Click();

                // Wait for menu item to disappear
                wait.Until(SeleniumWaits.InvisibilityOfElementLocated(
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Manage Delay']")));
            });
        }


        public void SetExpectedArrivalTime(string ExpectedArrivalTime) =>
       AllureLogger.LogStep($"I set Expected Arrival Time '{ExpectedArrivalTime}'", () =>
       {
           By filterFieldExpectedArrivalTime = By.CssSelector("#m8efe1e60-tb");

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           IWebElement ExpectedArrivalTimeField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldExpectedArrivalTime));

           ExpectedArrivalTimeField.Click();
           ExpectedArrivalTimeField.Clear();
           ExpectedArrivalTimeField.SendKeys(ExpectedArrivalTime);
           Task.Delay(3000).Wait();
       });


        public void SelectValueLookupOfArrivalDelayCodeField()
        {
            AllureLogger.LogStep("I select value lookup of Arrival Delay Code field", () =>
            {
                
                SafeActions.Click(driver,
                    By.CssSelector("#md64040f2-img"),
                    "I select value lookup of Arrival Delay Code field");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


          public void FilterTableArrivalDelayCode(string ArrivalDelayCode) =>
         AllureLogger.LogStep($"I filter table Arrival Delay Code '{ArrivalDelayCode}'", () =>
         {
             By filterFieldArrivalDelayCode = By.CssSelector("#lookup_page2_tfrow_\\[C\\:0\\]_txt-tb");

             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
             IWebElement ArrivalDelayCodeField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldArrivalDelayCode));

             ArrivalDelayCodeField.Click();
             ArrivalDelayCodeField.Clear();
             ArrivalDelayCodeField.SendKeys(ArrivalDelayCode);
             ArrivalDelayCodeField.SendKeys(Keys.Enter);
             Task.Delay(5000).Wait();
         });


         public void SelectNoRecordArrivalDelayCodeTableRecords(int recordNumber) =>
       AllureLogger.LogStep($"I Select No {recordNumber} From Arrival Delay Code Table Records", () =>
       {
           // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
           int zeroBasedIndex = recordNumber - 1;

           // Build dynamic Id selector by replacing the row index [R:x]
           string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

           SafeActions.Click(driver, By.Id(selector),
               $"I Select No {recordNumber} Record From Arrival Delay Code Table Records");
           Task.Delay(8000).Wait();
       });


        public void EnterArrivalDelayReason(string ArrivalDelayReason) =>
        AllureLogger.LogStep($"I filter table Arrival Delay Code '{ArrivalDelayReason}'", () =>
        {
            By filterFieldArrivalDelayReason = By.CssSelector("#m79cf5cae-ta");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            IWebElement ArrivalDelayReasonField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldArrivalDelayReason));

            ArrivalDelayReasonField.Click();
            ArrivalDelayReasonField.Clear();
            ArrivalDelayReasonField.SendKeys(ArrivalDelayReason);
            Task.Delay(5000).Wait();
        });


        public void PressDialogOKButtonOfManageDelay()
        {
            AllureLogger.LogStep("I press dialog OK button of Manage Delay", () =>
            {
               
                SafeActions.Click(driver,
                    By.CssSelector("#mb6a23101-pb"),
                    "I press dialog OK button of Manage Delay");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(20000).Wait();
            });
        }

        public void TakeScreenshotOfDelayedTrainInServiceArrivalsSubTab() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-018-SC01", () =>
        {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-018-SC01.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-018-SC01_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
        });


        public void SelectArrivedOnTimeButton()
        {
            AllureLogger.LogStep("I select Arrived on Time button", () =>
            {
               
                SafeActions.Click(driver,
                    By.CssSelector("#m8f03c361-pb"),
                    "I select Arrived on Time button");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(12000).Wait();
            });
        }

        public void TakeScreenshotOfRemovedDelay() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-018-SC02", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-018-SC02.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-018-SC02_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });






        // Available for Service Tab - Allocate a Unit to a Service POM STEPS




        public void GoToAvailableForServiceTab()
        {
            AllureLogger.LogStep("I go to Available for Service Tab", () =>
            {

                SafeActions.Click(driver,
                    By.XPath("(//button[normalize-space()='Available for Service'])[1]"),
                    "I go to Available for Service Tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(5000).Wait();
            });
        }

        public void SelectActionAllocateDepartureTimetable()
        {
            AllureLogger.LogStep("I select Allocate Departure Timetable", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Wait until at least one action menu exists
                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                // Get the first visible action menu
                var actionMenus = driver.FindElements(By.CssSelector("span.action-menu"));
                var actionMenu = actionMenus.FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                // Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center'});", actionMenu);
                Task.Delay(500).Wait();

                // Click action menu (with fallback)
                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", actionMenu);
                }

                // Wait for "Allocate Departure Timetable" option
                var allocateDepartureOption = wait.Until(
                    SeleniumWaits.ElementToBeClickable(
                        By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Allocate Departure Timetable']")));

                // Click the option
                allocateDepartureOption.Click();

                // Wait for menu to disappear
                wait.Until(SeleniumWaits.InvisibilityOfElementLocated(
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Allocate Departure Timetable']")));
            });
        }



        public void SelectNoRecordAllocateDepartureTimetableTableRecords(int recordNumber)
        {
            AllureLogger.LogStep(
                $"I Select No {recordNumber} Record From Allocate Departure Timetable Table Records",
                () =>
                {
                    // Convert to zero-based row index
                    int zeroBasedIndex = recordNumber - 1;

                    // Build selector using the new pattern
                    string selector =
                        $"m58ca38fc_tdrow_[C:0]_tbselrow-ti[R:{zeroBasedIndex}]_img";

                    SafeActions.Click(
                        driver,
                        By.Id(selector),
                        $"I Select No {recordNumber} Record From Allocate Departure Timetable Table Records"
                    );
                });
        }



        public void SelectAllocateDepartureService()
        {
            AllureLogger.LogStep("I select Allocate Departure Service", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#mb1cfa261-pb"),
                    "I select Allocate Departure Service");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(20000).Wait();
            });
        }


        public void TakeScreenshotOfAllocateDepartureService() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-019-SC01", () =>
       {
           try
           {
               Task.Delay(10000).Wait();
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-019-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-019-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);
               Task.Delay(10000).Wait();

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);

           }
       });


        public void TakeScreenshotOfAllocatedUnitInDepotViewTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-019-SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-019-SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-019-SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });





        // Available for Service Tab - Change Unit Status POM STEPS




        public void SelectActionChangeUnitStatus()
        {
            AllureLogger.LogStep("I select action Change Unit Status", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Wait until at least one action menu exists in DOM
                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                // Get the first displayed action menu
                var actionMenus = driver.FindElements(By.CssSelector("span.action-menu"));
                var actionMenu = actionMenus.FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                // Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center'});", actionMenu);
                Task.Delay(500).Wait();

                // Click action menu (with fallback)
                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", actionMenu);
                }

                // Wait for "Change Status" menu item
                var changeStatusOption = wait.Until(
                    SeleniumWaits.ElementToBeClickable(
                        By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Change Status']")));

                // Click the option
                changeStatusOption.Click();

                // Wait for menu item to disappear
                wait.Until(SeleniumWaits.InvisibilityOfElementLocated(
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Change Status']")));
            });
        }


        public void SelectOKDialogButtonOfChangeStatusOfRailUnit()
        {
            AllureLogger.LogStep("I select OK dialog button of Change Status of Rail Unit", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#m547a2e22-pb"),
                    "I select OK dialog button of Change Status of Rail Unit");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(10000).Wait();
            });
        }


        public void TakeScreenshotOfStoppedStatusInAvailableForServiceTab() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-020-SC01", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-020-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-020-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });




        // Available for Service Tab - Un-assign Train from Service POM STEPS




        public void SelectActionUnAssignTrain()
        {
            AllureLogger.LogStep("I select action Un-assign Train", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Wait until at least one action menu exists in DOM
                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                // Get the first displayed action menu
                var actionMenus = driver.FindElements(By.CssSelector("span.action-menu"));
                var actionMenu = actionMenus.FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                // Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center'});", actionMenu);
                Task.Delay(500).Wait();

                // Click action menu (with fallback)
                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", actionMenu);
                }

                // Wait for "Un-assign Train" menu item
                var unassignTrainOption = wait.Until(
                    SeleniumWaits.ElementToBeClickable(
                        By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Un-assign Train']")));

                // Click the option
                unassignTrainOption.Click();

                // Wait for menu item to disappear
                wait.Until(SeleniumWaits.InvisibilityOfElementLocated(
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Un-assign Train']")));
                Task.Delay(8000).Wait();
            });
        }


        public void TakeScreenshotOfAllocatedUnitInDepotViewTabTest() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-021-SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-021-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-021-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void TakeScreenshotOfUnAssignedTrainInAvailableForServiceTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-021-SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-021-SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-021-SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });





        // Available for Service Tab - Cancel a Service POM STEPS



        public void GoToDeparturesSubTab()
        {
            AllureLogger.LogStep("I go to Departures sub tab", () =>
            {

                SafeActions.Click(driver,
                    By.XPath("(//span[@id='availTabContainer_tablist_departuresTab'])[1]"),
                    "I go to Departures sub tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }

        public void GoToAvailableForServiceSubTab()
        {
            AllureLogger.LogStep("I go to Available for Service sub tab", () =>
            {

                SafeActions.Click(driver,
                    By.XPath("(//span[@id='availTabContainer_tablist_availableTab'])[1]"),
                    "I go to Available for Service sub tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void SelectActionCancelServiceLine()
        {
            AllureLogger.LogStep("I select action Cancel Service Line", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Wait until at least one action menu exists in DOM
                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                // Get the first displayed action menu
                var actionMenus = driver.FindElements(By.CssSelector("span.action-menu"));
                var actionMenu = actionMenus.FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                // Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center'});", actionMenu);
                Task.Delay(500).Wait();

                // Click action menu (with fallback)
                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", actionMenu);
                }

                // Wait for "Cancel Service Line" menu item
                var cancelServiceLineOption = wait.Until(
                    SeleniumWaits.ElementToBeClickable(
                        By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Cancel Service Line']")));

                // Click the option
                cancelServiceLineOption.Click();

                // Wait for menu item to disappear
                wait.Until(SeleniumWaits.InvisibilityOfElementLocated(
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Cancel Service Line']")));
            });
        }



        public void SelectOKDialogButtonOfCancelServiceLine()
        {
            AllureLogger.LogStep("I select OK dialog button of Cancel Service Line", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#mda4e956e-pb"),
                    "I select OK dialog button of Cancel Service Line");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(10000).Wait();
            });
        }

        public void SelectOkDialogSystemMessageOfCancelServiceLine()
        {
            AllureLogger.LogStep("I select Ok dialog system message of Cancel Service Line", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#m88dbf6ce-pb"),
                    "I select Ok dialog system message of Cancel Service Line");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(5000).Wait();
            });
        }

        public void TakeScreenshotOfCanceledServiceInAvailableForServiceTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-022-SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-022-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-022-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });




        // Available for Service Tab - Depart a Service POM STEPS




        public void SelectActionDepartTrain()
        {
            AllureLogger.LogStep("I select action Depart Train", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Wait until at least one action menu exists in DOM
                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                // Get the first displayed action menu
                var actionMenus = driver.FindElements(By.CssSelector("span.action-menu"));
                var actionMenu = actionMenus.FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                // Scroll element into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center'});", actionMenu);
                Task.Delay(500).Wait();

                // Click action menu (with fallback)
                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver)
                        .ExecuteScript("arguments[0].click();", actionMenu);
                }

                // Wait for "Depart Train" menu item
                var departTrainOption = wait.Until(
                    SeleniumWaits.ElementToBeClickable(
                        By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Depart Train']")));

                // Click the option
                departTrainOption.Click();

                // Wait for menu item to disappear
                wait.Until(SeleniumWaits.InvisibilityOfElementLocated(
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Depart Train']")));
            });
        }

        public void SelectValueLookupOfDelayCode()
        {
            AllureLogger.LogStep("I select value lookup of Delay Code", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#m9f37c214-img"),
                    "I select value lookup of Delay Code");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void FilterDelayCode(string DelayCode) =>
       AllureLogger.LogStep($"I filter table Delay Code with '{DelayCode}'", () =>
       {
           By filterFieldDelayCode = By.CssSelector("#lookup_page2_tfrow_\\[C\\:0\\]_txt-tb");

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           IWebElement DelayCodeField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldDelayCode));

           DelayCodeField.Click();
           DelayCodeField.Clear();
           DelayCodeField.SendKeys(DelayCode);
           DelayCodeField.SendKeys(Keys.Enter);
           Task.Delay(5000).Wait();
       });


          public void SelectNoRecordFromDelayCodeTableRecords(int recordNumber) =>
       AllureLogger.LogStep($"I Select No {recordNumber} From Delay Code Table Records", () =>
       {
           // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
           int zeroBasedIndex = recordNumber - 1;

           // Build dynamic Id selector by replacing the row index [R:x]
           string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

           SafeActions.Click(driver, By.Id(selector),
               $"I Select No {recordNumber} Record From Delay Code Table Records");
       });

         public void FilterDelayReason(string DelayReason) =>
       AllureLogger.LogStep($"I filter table Delay Reason with '{DelayReason}'", () =>
       {
           By filterFieldDelayReason = By.CssSelector("#mbd7c73af-tb");

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           IWebElement DelayReasonField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldDelayReason));

           DelayReasonField.Click();
           DelayReasonField.Clear();
           DelayReasonField.SendKeys(DelayReason);
           Task.Delay(5000).Wait();
       });

        public void ClickOKDialogButtonOfDepartTrain()
        {
            AllureLogger.LogStep("I click OK dialog button of Depart Train", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#m10ba48d3-pb"),
                    "I click OK dialog button of Depart Train");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(8000).Wait();
            });
        }


        public void TakeScreenshotOfDepartedTrain() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-023-SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-023-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-023-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void GoToRecentlyDepartedSubTab()
        {
            AllureLogger.LogStep("I go to Recently Departed sub tab", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#availTabContainer_tablist_recentDeparturesTab"),
                    "I go to Recently Departed sub tab");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void TakeScreenshotOfRecentlyDepartedSubTab() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-023-SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-023-SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-023-SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void SelectActionRevokeDepartTrain()
        {
            AllureLogger.LogStep("I select action Revoke Depart Train", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Wait until at least one action menu exists in DOM
                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                // Get the first displayed action menu
                var actionMenus = driver.FindElements(By.CssSelector("span.action-menu"));
                var actionMenu = actionMenus.FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                // Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center'});", actionMenu);
                Task.Delay(500).Wait();

                // Click action menu (with fallback)
                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", actionMenu);
                }

                // ✅ FIXED locator (was incorrectly using By.Id with XPath)
                var revokeDepartOption = wait.Until(
                    SeleniumWaits.ElementToBeClickable(
                        By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Revoke Depart Train']")));

                // Click the option
                revokeDepartOption.Click();

                // Wait for menu item to disappear
                wait.Until(SeleniumWaits.InvisibilityOfElementLocated(
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Revoke Depart Train']")));
            });
        }



        public void SelectValueLookupOfReturnRoad()
        {
            AllureLogger.LogStep("I select value lookup of Return Road", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#m53517043-img"),
                    "I select value lookup of Return Road");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


         public void FilterReturnRoad(string ReturnRoad) =>
       AllureLogger.LogStep($"I filter table Return Road with '{ReturnRoad}'", () =>
       {
           By filterFieldReturnRoad = By.CssSelector("#lookup_page2_tfrow_\\[C\\:0\\]_txt-tb");

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           IWebElement ReturnRoadField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldReturnRoad));

           ReturnRoadField.Click();
           ReturnRoadField.Clear();
           ReturnRoadField.SendKeys(ReturnRoad);
           ReturnRoadField.SendKeys(Keys.Enter);
           Task.Delay(5000).Wait();
       });


         public void SelectNoRecordFromReturnRoadTableRecords(int recordNumber) =>
       AllureLogger.LogStep($"I Select No {recordNumber} From Return Road Table Records", () =>
       {
           // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
           int zeroBasedIndex = recordNumber - 1;

           // Build dynamic Id selector by replacing the row index [R:x]
           string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

           SafeActions.Click(driver, By.Id(selector),
               $"I Select No {recordNumber} Record From Return Road Table Records");
       });


        public void FilterReturnPosition(string ReturnPosition) =>
       AllureLogger.LogStep($"I filter table Return Position with '{ReturnPosition}'", () =>
       {
           By filterFieldReturnPosition = By.CssSelector("#me28af9e6-tb");

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           IWebElement ReturnPositionField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldReturnPosition));

           ReturnPositionField.Click();
           ReturnPositionField.Clear();
           ReturnPositionField.SendKeys(ReturnPosition);
           Task.Delay(5000).Wait();
       });


        public void ClickOKDialogButtonOfRevokeDeparture()
        {
            AllureLogger.LogStep("I click OK dialog button of Revoke Departure", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#m5b0410ed-pb"),
                    "I click OK dialog button of Revoke Departure");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(12000).Wait();
            });
        }


         public void TakeScreenshotOfRecentlyRevokeDeparture() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-023-SC03", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-023-SC03.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-023-SC03_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });



        //Available for Service Tab - Add a New Service Line POM STEPS




        public void SelectAddANewServiceLine()
        {
            AllureLogger.LogStep("I select Add a New Service Line", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#departuresTabContent > span"),
                    "I select Add a New Service Line");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void SelectValueLookupOfDestination()
        {
            AllureLogger.LogStep("I select value lookup of Destination", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#mc1cb3a7d-img"),
                    "I select value lookup of Destination");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }

        public void FilterTableDestination(string Destination) =>
       AllureLogger.LogStep($"I filter table Destination with '{Destination}'", () =>
       {
           By filterFieldDestination = By.CssSelector("#lookup_page2_tfrow_\\[C\\:0\\]_txt-tb");

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           IWebElement DestinationField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldDestination));

           DestinationField.Click();
           DestinationField.Clear();
           DestinationField.SendKeys(Destination);
           DestinationField.SendKeys(Keys.Enter);
           Task.Delay(5000).Wait();
       });

         public void FilterDirection(string Direction) =>
       AllureLogger.LogStep($"I filter table Direction with '{Direction}'", () =>
       {
           By filterFieldDirection = By.CssSelector("#lookup_page2_tfrow_\\[C\\:0\\]_txt-tb");

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           IWebElement DirectionField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldDirection));

           DirectionField.Click();
           DirectionField.Clear();
           DirectionField.SendKeys(Direction);
           DirectionField.SendKeys(Keys.Enter);
           Task.Delay(5000).Wait();
       });


         public void SelectNoRecordDestinationTableRecords(int recordNumber) =>
       AllureLogger.LogStep($"I Select No {recordNumber} From Destination Table Records", () =>
       {
           // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
           int zeroBasedIndex = recordNumber - 1;

           // Build dynamic Id selector by replacing the row index [R:x]
           string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

           SafeActions.Click(driver, By.Id(selector),
               $"I Select No {recordNumber} Record From Destination Table Records");
       });

        public void SelectValueLookupOfDirection()
        {
            AllureLogger.LogStep("I select value lookup of Direction", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#m58c26bc7-img"),
                    "I select value lookup of Direction");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }

         public void SelectNoRecordDirectionTableRecords(int recordNumber) =>
       AllureLogger.LogStep($"I Select No {recordNumber} From Direction Table Records", () =>
       {
           // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
           int zeroBasedIndex = recordNumber - 1;

           // Build dynamic Id selector by replacing the row index [R:x]
           string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

           SafeActions.Click(driver, By.Id(selector),
               $"I Select No {recordNumber} Record From Direction Table Records");
       });


        public void EnterDepartureAndArrivalTime(string DepartureTime, string ArrivalTime) =>
        AllureLogger.LogStep($"I enter Departure and Arrival Time = '{DepartureTime}', Arrival Time = '{ArrivalTime}','", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            // Adjust column indices as per actual table structure:
            // Description = column 2 → C:2
            // Status = column 10 → C:10

            By DepartureTimeFilterLocator = By.CssSelector("#mbf7a46c0-tb");
            By ArrivalTimeFilterLocator = By.CssSelector("#mc87d7656-tb");

            IWebElement DepartureTimeFilter = wait.Until(SeleniumWaits.ElementToBeClickable(DepartureTimeFilterLocator));
            DepartureTimeFilter.Click();
            DepartureTimeFilter.Clear();
            DepartureTimeFilter.SendKeys(DepartureTime);

            IWebElement ArrivalTimeFilter = wait.Until(SeleniumWaits.ElementToBeClickable(ArrivalTimeFilterLocator));
            ArrivalTimeFilter.Click();
            ArrivalTimeFilter.Clear();
            ArrivalTimeFilter.SendKeys(ArrivalTime);
            Task.Delay(2000).Wait();

        });


        public void EnterServiceLineDetails(string RunNumber, string Memo, string DutyNumber) =>
        AllureLogger.LogStep($"I filter CM Work Order table with Run Number = '{RunNumber}', Memo = '{Memo}', Duty Number = '{DutyNumber}','", () =>
        {
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

             // Adjust column indices as per actual table structure:
             // Description = column 2 → C:2
             // Status = column 10 → C:10

             By RunNumberFilterLocator = By.CssSelector("#m7ee0d47b-tb");
             By MemoFilterLocator = By.CssSelector("#m10233e27-ta");
             By DutyNumberFilterLocator = By.CssSelector("#mc9c5ec08-tb");

             IWebElement RunNumberFilter = wait.Until(SeleniumWaits.ElementToBeClickable(RunNumberFilterLocator));
             RunNumberFilter.Click();
             RunNumberFilter.Clear();
             RunNumberFilter.SendKeys(RunNumber);
                         
            IWebElement MemoFilter = wait.Until(SeleniumWaits.ElementToBeClickable(MemoFilterLocator));
            MemoFilter.Click();
            MemoFilter.Clear();
            MemoFilter.SendKeys(Memo);

            IWebElement DutyNumberFilter = wait.Until(SeleniumWaits.ElementToBeClickable(DutyNumberFilterLocator));
            DutyNumberFilter.Click();
            DutyNumberFilter.Clear();
            DutyNumberFilter.SendKeys(DutyNumber);
            Task.Delay(2000).Wait();

        });

        public void SelectOKDialogButtonOfAddANewServiceLine()
        {
            AllureLogger.LogStep("I select OK dialog button of Add a New Service Line", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#m5645eeec-pb"),
                    "I select OK dialog button of Add a New Service Line");

                // Wait for 8 seconds (or whatever delay you need)
                Task.Delay(20000).Wait();
            });
        }

        public void TakeScreenshotOfNewServiceLine() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-024-SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-024-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-024-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });




        // Available for Service Tab - Edit a Service Line POM STEPS



        public void SelectActionEditServiceLine()
        {
            AllureLogger.LogStep("I select action Edit Service Line", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Wait until at least one action menu exists in DOM
                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                // Get the first displayed action menu
                var actionMenus = driver.FindElements(By.CssSelector("span.action-menu"));
                var actionMenu = actionMenus.FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                // Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center'});", actionMenu);
                Task.Delay(500).Wait();

                // Click action menu (with fallback)
                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver)
                        .ExecuteScript("arguments[0].click();", actionMenu);
                }

                // Wait for "Edit Service Line" menu item
                var editServiceLineOption = wait.Until(
                    SeleniumWaits.ElementToBeClickable(
                        By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Edit Service Line']")));

                // Click the option
                editServiceLineOption.Click();

                // Wait for menu item to disappear
                wait.Until(SeleniumWaits.InvisibilityOfElementLocated(
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Edit Service Line']")));
            });
        }

        public void SelectValueLookupOfServiceLineDestinationField()
        {
            AllureLogger.LogStep("I select value lookup of Service Line Destination field", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#m4b7d91d8-img"),
                    "I select value lookup of Service Line Destination field");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void SelectValueLookupOfServiceLineDirectionField()
        {
            AllureLogger.LogStep("I select value lookup of Service Line Direction field", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#mf041d15-img"),
                    "I select value lookup of Service Line Direction field");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


         public void SetDepartureAndArrivalTime(string DepartureTime, string ArrivalTime) =>
        AllureLogger.LogStep($"I set Departure and Arrival Time = '{DepartureTime}', Arrival Time = '{ArrivalTime}','", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            // Adjust column indices as per actual table structure:
            // Description = column 2 → C:2
            // Status = column 10 → C:10

            By DepartureTimeFilterLocator = By.CssSelector("#me46afb59-tb");
            By ArrivalTimeFilterLocator = By.CssSelector("#mcc65c596-tb");

            IWebElement DepartureTimeFilter = wait.Until(SeleniumWaits.ElementToBeClickable(DepartureTimeFilterLocator));
            DepartureTimeFilter.Click();
            DepartureTimeFilter.Clear();
            DepartureTimeFilter.SendKeys(DepartureTime);

            IWebElement ArrivalTimeFilter = wait.Until(SeleniumWaits.ElementToBeClickable(ArrivalTimeFilterLocator));
            ArrivalTimeFilter.Click();
            ArrivalTimeFilter.Clear();
            ArrivalTimeFilter.SendKeys(ArrivalTime);
            Task.Delay(2000).Wait();

        });


        public void EditServiceLineDetails(string Memo, string Notes, string DutyNumber) =>
        AllureLogger.LogStep($"I filter CM Work Order table with Memo = '{Memo}', Notes = '{Notes}', Duty Number = '{DutyNumber}','", () =>
        {
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

             // Adjust column indices as per actual table structure:
             // Description = column 2 → C:2
             // Status = column 10 → C:10

             By MemoFilterLocator = By.CssSelector("#m374ae7c3-ta");
             By NotesFilterLocator = By.CssSelector("#m5b81df87-ta");
             By DutyNumberFilterLocator = By.CssSelector("#ma14f9986-tb");

             IWebElement MemoFilter = wait.Until(SeleniumWaits.ElementToBeClickable(MemoFilterLocator));
             MemoFilter.Click();
             MemoFilter.Clear();
             MemoFilter.SendKeys(Memo);
                         
            IWebElement NotesFilter = wait.Until(SeleniumWaits.ElementToBeClickable(NotesFilterLocator));
            NotesFilter.Click();
            NotesFilter.Clear();
            NotesFilter.SendKeys(Notes);

            IWebElement DutyNumberFilter = wait.Until(SeleniumWaits.ElementToBeClickable(DutyNumberFilterLocator));
            DutyNumberFilter.Click();
            DutyNumberFilter.Clear();
            DutyNumberFilter.SendKeys(DutyNumber);
            Task.Delay(2000).Wait();

        });


        public void ClickOKDialogButtonOfEditServiceLine()
        {
            AllureLogger.LogStep("I click OK dialog button of Edit Service Line", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#m1e7f25d0-pb"),
                    "I click OK dialog button of Edit Service Line");

                // Wait for 8 seconds (or whatever delay you need)
                Task.Delay(15000).Wait();
            });
        }


        public void TakeScreenshotOfEditedServiceLine() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-025-SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-025-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-025-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void ClearNotes()
        {
            AllureLogger.LogStep("I clear Notes", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                var notesField = wait.Until(
                    SeleniumWaits.ElementIsVisible(
                        By.CssSelector("#m5b81df87-ta")));

                // Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center'});", notesField);

                // Click to focus
                notesField.Click();

                // Clear using standard method
                notesField.Clear();

                // Fallback (in case .Clear() fails)
                if (!string.IsNullOrEmpty(notesField.GetAttribute("value")))
                {
                    notesField.SendKeys(Keys.Control + "a");
                    notesField.SendKeys(Keys.Delete);
                }

                // Optional small wait for stability
                Task.Delay(3000).Wait();
            });
        }




        // Available for Service Tab - Add a Sliding Comment to the Departure Service Line POM STEPS


        public void EnterNotes(string Notes,string Memo) =>
       AllureLogger.LogStep($"I enter Notes 'Memo = '{Memo}',{Notes}'", () =>
       {

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
           By filterFieldNotes = By.CssSelector("#m5b81df87-ta");
           By MemoFilterLocator = By.CssSelector("#m374ae7c3-ta");

           IWebElement MemoFilter = wait.Until(SeleniumWaits.ElementToBeClickable(MemoFilterLocator));
           MemoFilter.Click();
           MemoFilter.Clear();
           MemoFilter.SendKeys(Memo);

           IWebElement NotesFilter = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldNotes));
           NotesFilter.Click();
           NotesFilter.Clear();
           NotesFilter.SendKeys(Notes);
           Task.Delay(2000).Wait();
                      
       });


         public void TakeScreenshotOfNoteAddedToServiceLine() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-026-SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-026-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-026-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });




        // Move Request Tab - View Move Requests POM STEPS



          public void TakeScreenshotOfMoveRequestDetailsTestScenario() =>
         AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-027-SC01", () =>
         {
             try
             {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-027-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-027-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
             }
         });


              public void VerifyStatus() =>
          AllureLogger.LogStep("Verify Status", () =>
          {
               try
               {
                   var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

                   var expectedStatuses = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
                    {
                       "AFS",
                       "INS",
                       "STOPPED"
               };

                    var statusElement = wait.Until(drv =>
                    {
                        var cells = drv.FindElements(By.XPath(
                       "//td[@role='gridcell' and contains(@class,'dojoxGridCell')]"));

                        return cells.FirstOrDefault(e =>
                             e.Displayed &&
                             !string.IsNullOrWhiteSpace(e.Text) &&
                             expectedStatuses.Contains(e.Text.Trim()));
                    });

                         if (statusElement == null)
                         {
                            throw new Exception("Failure: None of the expected statuses (STOPPED, INS, AFS) are displayed.");
                         }

                      string actualStatus = statusElement.Text.Trim();

                              Console.WriteLine($"✅ Success: Status '{actualStatus}' is displayed.");
                      }
                      catch (WebDriverTimeoutException)
                      {
                          throw new Exception("Failure: Timed out waiting for status to be displayed.");
                      }
                      catch (Exception ex)
                      {
                          Console.WriteLine("❌ Error: " + ex.Message);
                          throw;
                      }
          });



              public void VerifyLocation() =>
          AllureLogger.LogStep("Verify Location", () =>
          {
               try
               {
                   var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

                   var expectedLocations = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
                   {
                       "Platform 1","Platform 2","Platform 3","Platform 4",
                       "1 Road","2 Road","3 Road","4 Road","5 Road",
                       "6 Road","7 Road","8 Road","9 Road","10 Road",
                       "2 Up CS",
                       "1 Inspection Shed","2 Inspection Shed","3 Inspection Shed",
                       "4 Inspection Shed","5 Inspection Shed","6 Inspection Shed"
                   };

                   var locationElement = wait.Until(drv =>
                   {
                        var cells = drv.FindElements(By.XPath(
                        "//td[@role='gridcell' and contains(@class,'dojoxGridCell')]"));

                        return cells.FirstOrDefault(e =>
                            e.Displayed &&
                            !string.IsNullOrWhiteSpace(e.Text) &&
                            expectedLocations.Contains(e.Text.Trim()));
                   });

                        if (locationElement == null)
                        {
                            throw new Exception("Failure: None of the expected locations were found.");
                        }

                          string actualLocation = locationElement.Text.Trim();

                         if (string.IsNullOrEmpty(actualLocation))
                         {
                             throw new Exception("Failure: Location is displayed but text is empty.");
                         }

                         Console.WriteLine($"✅ Success: Location '{actualLocation}' is displayed.");
                         }
                         catch (WebDriverTimeoutException)
                         {
                            throw new Exception("Failure: Timed out waiting for location to be displayed.");
                         }
                         catch (Exception ex)
                         {
                         Console.WriteLine("❌ Error: " + ex.Message);
                         throw;
                         }
          });




          public void VerifyMoveTo() =>
          AllureLogger.LogStep("Verify Move To", () =>
          {
               try
               {
                   var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

                   var expectedLocations = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
               {
                   "Platform 1", "Platform 2", "Platform 3", "Platform 4", "Platform 5",
                   "Platform 6", "Platform 7", "Platform 8", "Platform 9", "Platform 10",
                   "1 Road", "2 Road", "3 Road", "4 Road", "5 Road",
                   "6 Road", "7 Road", "8 Road", "9 Road", "10 Road"
               };

               var matchingElement = wait.Until(drv =>
               {
                    var elements = drv.FindElements(By.XPath(
                   "//td[@role='gridcell' and contains(@class,'dojoxGridCell')]"));

                      return elements
                    .FirstOrDefault(e =>
                       e.Displayed &&
                       !string.IsNullOrWhiteSpace(e.Text) &&
                       expectedLocations.Contains(e.Text.Trim()));
               });

                    if (matchingElement == null)
                    {
                        throw new Exception(
                           $"Failure: None of the expected Move To locations are displayed. " +
                           $"Expected one of: {string.Join(", ", expectedLocations)}");
                    }

                         string moveToValue = matchingElement.Text.Trim();

                        Console.WriteLine($"✅ Success: Move To value '{moveToValue}' is displayed.");
                   }
                   catch (WebDriverTimeoutException)
                   {
                        throw new Exception("Failure: Timed out waiting for a valid Move To location to be displayed.");
                   }
                   catch (Exception ex)
                   {
                        Console.WriteLine("❌ Error: " + ex.Message);
                        throw;
                   }
          });


           public void VerifyRequested() =>
          AllureLogger.LogStep("Verify Requested", () =>
          {
               try
               {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

                     var requestedElement = wait.Until(drv =>
                     {
                         var cells = drv.FindElements(By.XPath(
                         "//td[@role='gridcell' and contains(@class,'dojoxGridCell')]"));

                         return cells.FirstOrDefault(e =>
                            e.Displayed &&
                            !string.IsNullOrWhiteSpace(e.Text) &&
                            (e.Text.Contains("/") || e.Text.Contains(":"))); // handles date or datetime
                     });

                          if (requestedElement == null)
                          {
                              throw new Exception("Failure: Requested value is not displayed in the grid.");
                          }

                           string displayedValue = requestedElement.Text?.Trim();

                          if (string.IsNullOrEmpty(displayedValue))
                          {
                              throw new Exception("Failure: Requested displayed value is empty or null.");
                          }

                            // Get attributes
                           string idx = requestedElement.GetAttribute("idx");
                           string role = requestedElement.GetAttribute("role");
                           string className = requestedElement.GetAttribute("class");

                           // Logs
                          Console.WriteLine($"✅ Success: Requested Value = {displayedValue}");
                          Console.WriteLine("📌 Element Stats:");
                          Console.WriteLine($"   - idx   : {idx}");
                          Console.WriteLine($"   - role  : {role}");
                          Console.WriteLine($"   - class : {className}");
                          }
                          catch (WebDriverTimeoutException)
                          {
                              throw new Exception("Failure: Timed out waiting for Requested value to be displayed.");
                          }
                          catch (Exception ex)
                          {
                              Console.WriteLine("❌ Error: " + ex.Message);
                              throw;
                          }
          });


            public void VerifyMoveByDate() =>
          AllureLogger.LogStep("Verify Move By Date", () =>
          {
              try
              {
                 // Wait 10 seconds for the page or element to load
                 Task.Delay(10000).Wait();

                 // Find the Requested element (dynamic date/time cell)
                 var requestedElement = driver.FindElement(
                      By.XPath("(//td[@role='gridcell' and contains(normalize-space(), '/')])[2]")
                 );

                 // Get displayed text (actual value shown in UI)
                 string displayedValue = requestedElement.Text?.Trim();

                 if (string.IsNullOrEmpty(displayedValue))
                 {
                     throw new Exception("Failure: Requested displayed value is empty or null.");
                 }

                 // Get element attribute "stats"
                 string idx = requestedElement.GetAttribute("idx");
                 string role = requestedElement.GetAttribute("role");
                 string className = requestedElement.GetAttribute("class");

                 // Log results
                 Console.WriteLine($"✅ Success: Requested Value = {displayedValue}");
                 Console.WriteLine($"📌 Element Stats:");
                 Console.WriteLine($"   - idx   : {idx}");
                 Console.WriteLine($"   - role  : {role}");
                 Console.WriteLine($"   - class : {className}");
                 }
                 catch (NoSuchElementException ex)
                 {
                    Console.WriteLine("❌ Error: Requested element not found - " + ex.Message);
                    throw;
                 }
                 catch (Exception ex)
                 {
                    Console.WriteLine("❌ Error: " + ex.Message);
                    throw;
                 }
          });


             public void VerifyDetails() =>
          AllureLogger.LogStep("Verify Details", () =>
          {
              try
              {
                 // Wait for page / grid to load
                 Task.Delay(5000).Wait();

                 // Dictionary of statuses and their selectors
                 var statusSelectors = new Dictionary<string, string>
                  {
                  { "Move Request 1", "(//td[normalize-space()='Move Request for rail unit U171806'])[1]" },
                  { "Move Request 2",  "(//td[normalize-space()='Move Request for rail unit U171201'])[1]" },
                  { "Move Request 3", "(//td[normalize-space()='Move Request for rail unit U171202'])[1]" },
                  { "Move Request 4", "(//td[normalize-space()='Move Request for rail unit U171203'])[1]" },
                  { "Move Request 5", "(//td[normalize-space()='Move Request for rail unit U379011'])[1]" },
                  };

                   bool statusFound = false;

                  foreach (var status in statusSelectors)
                  {
                     var elements = driver.FindElements(By.XPath(status.Value));

                      if (elements.Count > 0)
                      {
                         string statusValue = elements[0].Text?.Trim();

                         if (string.IsNullOrEmpty(statusValue))
                         {
                             throw new Exception($"Failure: {status.Key} status is displayed but value is empty.");
                         }

                         Console.WriteLine($"✅ Success: Status '{statusValue}' found using selector: {status.Value}");
                         statusFound = true;
                         break;
                      }
                  }

                 if (!statusFound)
                 {
                     throw new Exception("Failure: None of the expected statuses (STOPPED, INS, AFS) are displayed.");
                 }
                 }
                 catch (Exception ex)
                 {
                    Console.WriteLine("❌ Error: " + ex.Message);
                    throw;
                 }
          });


           public void TakeScreenshotOfMoveRequestDetailsTab() =>
          AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-027-SC01", () =>
          {
               try
               {
                  var takescreenshot = new TakeScreenShotPOM(driver);
                  string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-027-SC01.png";

                  takescreenshot.TakeScreenshot(driver, successPath);
               }
               catch (Exception ex)
               {
                   Console.WriteLine($"Screenshot failed: {ex.Message}");

                   // Attempt fallback screenshot on failure
                   var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-027-SC01_Failure.png";
                   var takescreenshot = new TakeScreenShotPOM(driver);

                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    // Optional: Rethrow if test should fail
                    throw new Exception("Test failed while taking screenshot.", ex);
               }
          });





           // Move Request Tab - Update an Existing Move Request POM STEPS



          public void TakeScreenshotOfCreateAMoveRequestTestScenario() =>
         AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-028-SC01", () =>
         {
             try
             {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-028-SC01.png";

                takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-028-SC01_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });

            public void ModifyMoveByDateField() =>
         AllureLogger.LogStep("I modify Move By Date field", () =>
         {
             var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

             // Open Stop Date picker
             var stopDatePickerIcon = By.CssSelector("#m20fc6152-img");
             wait.Until(SeleniumWaits.ElementToBeClickable(stopDatePickerIcon)).Click();

             // Get today's day (e.g. "30")
             string todayDay = DateTime.Today.Day.ToString();

             // Updated selector using your new base structure
             var todayDateCell = By.XPath(
                $"//*[@id='m20fc6152-tb_popup_date']//td[not(contains(@class,'dijitCalendarDisabledDate'))]/span[text()='{todayDay}']"
             );

             wait.Until(SeleniumWaits.ElementToBeClickable(todayDateCell)).Click();

             // Click OK button
             var okButton = By.XPath("//*[@id=\"m20fc6152-tb_popup\"]/tbody/tr[2]/td/button[1]");
             wait.Until(SeleniumWaits.ElementToBeClickable(okButton)).Click();
         });


         public void OpenSelectValueLookupOfDestination()
         {
            AllureLogger.LogStep("I open value lookup of Destination field", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#me944ada6-img"),
                    "I open value lookup of Destination field");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
         }


          public void TakeScreenshotOfUpdateMoveRequestDetailsTestScenario() =>
         AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-028-SC02", () =>
         {
             try
             {
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-028-SC02.png";

                  takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-028-SC02_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
             }
         });



        // Move Request Tab - Cancel a Move Request POM STEPS


         public void TakeScreenshotOfCreateMoveRequestTestScenario() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-029-SC01", () =>
        {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-029-SC01.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-029-SC01_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
        });


        public void TakeScreenshotOfCancelledMoveRequestTestScenario() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-029-SC02", () =>
        {
            try
            {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-029-SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-029-SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
            }
        });



        // At Location Tab - Allocate Unit to Service POM STEPS



          public void TakeScreenshotOfAllocatedUnitToServiceTestScenario() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-030-SC01", () =>
        {
           try
           {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-030-SC01.png";

              takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-030-SC01_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
           }
        });



        // At Location Tab - View Units in the Yard POM STEPS



         public void TakeScreenshotOfViewUnitsInTheYardTestScenario() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-031-SC01", () =>
        {
           try
           {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-031-SC01.png";

              takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-031-SC01_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
           }
        });



        // At Location Tab - Create Move Requests POM STEPS



        public void TakeScreenshotOfMoveRequestTestScenario() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-032-SC01", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-032-SC01.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-032-SC01_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });




        // Verifying a Unit After its Arrival to the Yard POM STEPS

        public void IAddUnitAttributes()
        {
            AllureLogger.LogStep("I Add Unit Attributes", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                var roadElement = wait.Until(SeleniumWaits.ElementToBeClickable(
                    By.XPath("(//span[contains(@class,'brdfYardAssetLabel') and starts-with(@id,'RAILUNIT_') and contains(@id,'_label')])[1]")));

                var actions = new OpenQA.Selenium.Interactions.Actions(driver);
                actions.ContextClick(roadElement).Perform();

                SafeActions.Click(driver,
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Unit Attributes']"),
                    "I click Unit Attributes");

                Task.Delay(3000).Wait();
            });
        }


        public void SelectUnitAttributes()
        {
            AllureLogger.LogStep("I select Unit Attributes", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#m4f262e2e_tdrow_\\[C\\:0\\]_checkbox-cb\\[R\\:0\\]_img"),
                    "I select Unit Attributes");

                // Wait for 8 seconds (or whatever delay you need)
                Task.Delay(3000).Wait();
            });
        }


        public void SelectDialogButtonContinue()
        {
            AllureLogger.LogStep("I select dialog button Continue", () =>
            {

                SafeActions.Click(driver,
                    By.CssSelector("#m5861c8c-pb"),
                    "I select dialog button Continue");

                // Wait for 8 seconds (or whatever delay you need)
                Task.Delay(20000).Wait();
            });
        }

        public void TakeScreenshotOfVerifiedUnit() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-033-SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-033-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-033-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });




        // View Tab - Block to a Unit POM STEPS


        public void AddABlockToAUnit()
        {
            AllureLogger.LogStep("I Add a block to a unit", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                var roadElement = wait.Until(SeleniumWaits.ElementToBeClickable(
                    By.XPath("(//span[contains(@class,'brdfYardAssetLabel') and starts-with(@id,'RAILUNIT_') and contains(@id,'_label')])[1]")));

                var actions = new OpenQA.Selenium.Interactions.Actions(driver);
                actions.ContextClick(roadElement).Perform();

                SafeActions.Click(driver,
                    By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Block/Unblock Unit']"),
                    "I Add a block to a unit");

                Task.Delay(10000).Wait();
            });
        }

         public void TakeScreenshotOfBlockedUnit() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-034-SC01", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-034-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-034-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });

        public void RemoveBlockFromAUnit()
        {
            AllureLogger.LogStep("I remove block from a unit", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                wait.IgnoreExceptionTypes(
                    typeof(NoSuchElementException),
                    typeof(StaleElementReferenceException),
                    typeof(ElementClickInterceptedException));

                // Locator for the first visible rail unit
                var railUnitLocator = By.XPath(
                    "(//span[contains(@class,'brdfYardAssetLabel') " +
                    "and starts-with(@id,'RAILUNIT_') " +
                    "and contains(@id,'_label')])[1]");

                // Wait until rail unit is visible and clickable
                var unitElement = wait.Until(d =>
                {
                    var element = d.FindElements(railUnitLocator)
                                   .FirstOrDefault(e =>
                                   {
                                       try
                                       {
                                           return e.Displayed && e.Enabled;
                                       }
                                       catch
                                       {
                                           return false;
                                       }
                                   });

                    return element;
                });

                if (unitElement == null)
                    throw new NoSuchElementException("Rail unit element was not visible or clickable.");

                // Scroll rail unit into view
                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView({block:'center'});", unitElement);

                Task.Delay(1000).Wait();

                // Open context menu
                new OpenQA.Selenium.Interactions.Actions(driver)
                    .MoveToElement(unitElement)
                    .ContextClick()
                    .Perform();

                Task.Delay(1000).Wait();

                // Stable locator using menu text
                var blockUnblockUnitLocator = By.XPath(
                    "//td[normalize-space()='Block/Unblock Unit']");

                // Wait until Block/Unblock Unit menu option is visible
                var menuTextCell = wait.Until(d =>
                {
                    return d.FindElements(blockUnblockUnitLocator)
                            .FirstOrDefault(e =>
                            {
                                try
                                {
                                    return e.Displayed && e.Enabled;
                                }
                                catch
                                {
                                    return false;
                                }
                            });
                });

                if (menuTextCell == null)
                    throw new NoSuchElementException(
                        "Block/Unblock Unit menu option was not visible or clickable.");

                // Scroll into view
                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView({block:'center'});", menuTextCell);

                Task.Delay(500).Wait();

                try
                {
                    var clickableMenuItem = wait.Until(d =>
                    {
                        try
                        {
                            var textCell = d.FindElement(blockUnblockUnitLocator);
                            var row = textCell.FindElement(By.XPath("./ancestor::tr[1]"));

                            return row.Displayed && row.Enabled ? row : null;
                        }
                        catch
                        {
                            return null;
                        }
                    });

                    new OpenQA.Selenium.Interactions.Actions(driver)
                        .MoveToElement(clickableMenuItem)
                        .Click()
                        .Perform();
                }
                catch
                {
                    // Fallback JS click
                    ((IJavaScriptExecutor)driver)
                        .ExecuteScript("arguments[0].click();", menuTextCell);
                }

                // Wait until menu disappears
                wait.Until(d =>
                {
                    var remaining = d.FindElements(blockUnblockUnitLocator)
                                     .Where(e =>
                                     {
                                         try
                                         {
                                             return e.Displayed;
                                         }
                                         catch
                                         {
                                             return false;
                                         }
                                     });

                    return !remaining.Any();
                });

                Task.Delay(20000).Wait();
            });
        }


        public void TakeScreenshotOfUnblockedUnit() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-034-SC02", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-034-SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-034-SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });




        // In Service / Arriving Tab - Arrive a Consist POM STEPS

         public void SelectActionManageConsist()
         {
             AllureLogger.LogStep("I select action Manage Consist", () =>
             {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Wait for action menus
                wait.Until(d => d.FindElements(By.CssSelector("span.action-menu")).Count > 0);

                var actionMenu = driver.FindElements(By.CssSelector("span.action-menu"))
                                       .FirstOrDefault(x => x.Displayed);

                if (actionMenu == null)
                    throw new NoSuchElementException("No visible action menu was found.");

                // Scroll into view
                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView({block:'center'});", actionMenu);

                Task.Delay(500).Wait();

                // Click action menu
                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver)
                        .ExecuteScript("arguments[0].click();", actionMenu);
                }

                // Wait for Manage Consist menu item to appear
                wait.Until(d => d.FindElements(By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Manage Consist']")).Count > 0);

                IWebElement manageConsistOption = null;

                // ✅ Try ID first (updated to your new element)
                try
                {
                    manageConsistOption = wait.Until(
                        SeleniumWaits.ElementToBeClickable(
                            By.Id("dijit_MenuItem_9_text")));
                }
                catch
                {
                    // ✅ Fallback (dynamic & stable)
                    manageConsistOption = wait.Until(
                        SeleniumWaits.ElementToBeClickable(
                            By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Manage Consist']")));
                }

                // Scroll into view
                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView(true);", manageConsistOption);

                Task.Delay(300).Wait();

                // Click menu option
                try
                {
                    manageConsistOption.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver)
                        .ExecuteScript("arguments[0].click();", manageConsistOption);
                }

                // Wait for menu to disappear
                wait.Until(d =>
                    !d.FindElements(By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Manage Consist']"))
                      .Any(e => e.Displayed));
             });
         }


               public void FilterConsist(string yardAsset, string status) =>
          AllureLogger.LogStep($"I filter table with Yard Asset '{yardAsset}' and Status '{status}'", () =>
          {
                try
                {
                     var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
 
                     // ✅ Step 1: Click Filter menu
                     var filterMenuLocator = By.Id("mec9848de-lb2");

                     var filterMenu = wait.Until(drv =>
                     {
                        var elements = drv.FindElements(filterMenuLocator);
                        return elements.FirstOrDefault(e => e.Displayed && e.Enabled);
                     });

                      if (filterMenu == null)
                      throw new Exception("Failure: Filter menu not found.");

                     try
                     {
                        filterMenu.Click();
                     }
                     catch
                     {
                         ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", filterMenu);
                     }

                       // ✅ Step 2: Enter Yard Asset (Column C:0)
                       var yardAssetLocator = By.CssSelector("#mec9848de_tfrow_\\[C\\:0\\]_txt-tb");

                       var yardAssetField = wait.Until(drv =>
                       {
                           var elements = drv.FindElements(yardAssetLocator);
                           return elements.FirstOrDefault(e => e.Displayed && e.Enabled);
                       });

                          if (yardAssetField == null)
                          throw new Exception("Failure: Yard Asset field not available.");

                          yardAssetField.Click();
                          yardAssetField.Clear();
                          yardAssetField.SendKeys(yardAsset);
 
                        // ✅ Step 3: Enter Status (Column C:1)
                        var statusLocator = By.CssSelector("#mec9848de_tfrow_\\[C\\:1\\]_txt-tb");

                        var statusField = wait.Until(drv =>
                        {
                            var elements = drv.FindElements(statusLocator);
                            return elements.FirstOrDefault(e => e.Displayed && e.Enabled);
                        });

                         if (statusField == null)
                         throw new Exception("Failure: Status field not available.");

                         statusField.Click();
                         statusField.Clear();
                         statusField.SendKeys(status);
                         statusField.SendKeys(Keys.Enter); // ✅ trigger filter

                         // ✅ Step 4: Wait for grid refresh
                        wait.Until(drv =>
                        {
                           var cells = drv.FindElements(By.XPath("//td[@role='gridcell']"));
                           return cells.Any(e => e.Displayed);
                        });
                        }
                        catch (WebDriverTimeoutException)
                        {
                           throw new Exception("Failure: Unable to apply filters within timeout.");
                        }
                        catch (Exception ex)
                        {
                           Console.WriteLine("❌ Error: " + ex.Message);
                           throw;
                        }
          });

            public void SelectNoRecordConsistTableRecords(int recordNumber) =>
          AllureLogger.LogStep($"I Select No {recordNumber} From Consist Table Records", () =>
          {
              // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
              int zeroBasedIndex = recordNumber - 1;

              // Build dynamic Id selector by replacing the row index [R:x]
              string selector = $"mec9848de_tdrow_[C:3]_button_NONE-pb[R:{zeroBasedIndex}]";

               SafeActions.Click(driver, By.Id(selector),
               $"I Select No {recordNumber} Record From Consist Table Records");
               Task.Delay(8000).Wait();
          });

          public void RemoveNoUnarrivedUnits(int recordNumber) =>
          AllureLogger.LogStep($"I Remove No {recordNumber} Unarrived Units", () =>
          {
              // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
              int zeroBasedIndex = recordNumber - 1;

              // Build dynamic Id selector by replacing the row index [R:x]
              string selector = $"m75911964_tdrow_[C:4]_button_NONE-pb[R:{zeroBasedIndex}]";

              SafeActions.Click(driver, By.Id(selector),
              $"I Remove No {recordNumber} Unarrived Units");
              Task.Delay(8000).Wait();
          });


          public void UpdateConsist()
          {
              AllureLogger.LogStep("I Update Consist", () =>
              {

                SafeActions.Click(driver,
                    By.CssSelector("#m3eff89ef-pb"),
                    "I Update Consist");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(8000).Wait();
              });
          }




        // Available for Service Tab - View the Units that are Available for Service POM STEPS




        public void TakeScreenshotOfAvailableForServiceTab() =>
         AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-036-SC01", () =>
         {
           try
           {
                Task.Delay(8000).Wait();
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-036-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-036-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
         });



        //  Depot View - Update Traincare Work Orders POM STEPS



        public void SelectViewTraincareWorkOrdersFromTheActionMenu()
        {
            AllureLogger.LogStep("Select View Train Care Work Orders from Action Menu", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

                // Find first visible Unit dynamically
                By unitLocator = By.XPath(
                    "//span[starts-with(@id,'RAILUNIT_') and contains(@id,'_label')]"
                );

                var unitElement = wait.Until(
                    SeleniumWaits.ElementExists(unitLocator)
                );

                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center'});", unitElement);

                wait.Until(
                    SeleniumWaits.ElementToBeClickable(unitLocator)
                );

                // Right-click the Unit
                var actions = new OpenQA.Selenium.Interactions.Actions(driver);
                actions.MoveToElement(unitElement)
                       .Pause(TimeSpan.FromMilliseconds(500))
                       .ContextClick(unitElement)
                       .Perform();

                // Wait for "View Train Care Work Orders" menu item
                By menuItemLocator = By.XPath(
                    "//td[normalize-space()='View Train Care Work Orders']"
                );

                var menuItem = wait.Until(
                    SeleniumWaits.ElementToBeClickable(menuItemLocator)
                );

                // Click menu item
                try
                {
                    menuItem.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript(
                        "arguments[0].click();", menuItem);
                }

                Task.Delay(3000).Wait();
            });
        }

         public void CompleteNoCleaningTaskInTheTraincareWorkOrdersTable(int recordNumber) =>
        AllureLogger.LogStep($"I complete no.{recordNumber} cleaning task in the Traincare work orders table", () =>
        {
            int zeroBasedIndex = recordNumber - 1;
 
             var locator = By.XPath(
             $"//img[contains(@id,'_tdrow_[C:7]_hyperlink-lb[R:{zeroBasedIndex}]_image') and @alt='Complete Cleaning Task']");

              SafeActions.Click(
                 driver,
                 locator,
                 $"I complete no.{recordNumber} cleaning task in the Traincare work orders table");

                   Task.Delay(3000).Wait();
        });


        public void ClickDialogOKButtonOfViewTraincareWorkOrders()
        {
            AllureLogger.LogStep("I click dialog OK button of View Traincare work orders", () =>
            {
                // Click the OK dialog button
                SafeActions.Click(driver,
                    By.CssSelector("#mbc7bd441-pb"),
                    "I click OK dialog button");

                // Wait for 2 seconds (or whatever delay you need)
                Task.Delay(5000).Wait();
            });
        }

        public void TakeScreenshotOfUpdateTraincareWorkOrdersTest() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-037-SC01", () =>
        {
            try
            {
                Task.Delay(8000).Wait();
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-037-SC01.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-037-SC01_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });


        public void TakeScreenshotOfCompletedCleaningTaskInTheTraincareWorkOrdersTable() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-037-SC02", () =>
        {
            try
            {
                Task.Delay(8000).Wait();
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-037-SC02.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-037-SC02_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });




        // Depot View - Verify by engineer POM STEPS

        public void SelectAPinkBackgroundUnitOnTheAtLocationTab()
        {
            AllureLogger.LogStep("I select a pink background unit on the At Location Tab", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                var unit = wait.Until(
                    SeleniumWaits.ElementExists(
                        By.XPath("//span[contains(@class,'train-unitsincompo')]")));

                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center'});", unit);

                try
                {
                    unit.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver)
                        .ExecuteScript("arguments[0].click();", unit);
                }

                Task.Delay(3000).Wait();
            });
        }


        public void SelectActionAddUnitAttributesToPinkBackgroundUnit()
        {
            AllureLogger.LogStep("I select Action > Unit Attributes for the pink background unit", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

                // Locate the pink unit row
                var pinkUnit = wait.Until(
                    SeleniumWaits.ElementExists(
                        By.XPath("//span[contains(@class,'train-unitsincompo')]")));

                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView({block:'center'});", pinkUnit);

                // Find the action menu associated with the same row
                var actionMenu = pinkUnit.FindElement(
                    By.XPath("./ancestor::tr//span[contains(@class,'action-menu')]"));

                wait.Until(d => actionMenu.Displayed && actionMenu.Enabled);

                try
                {
                    actionMenu.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver)
                        .ExecuteScript("arguments[0].click();", actionMenu);
                }

                // Select Unit Attributes
                var unitAttributes = wait.Until(
                    SeleniumWaits.ElementToBeClickable(
                        By.XPath("//td[contains(@class,'dijitMenuItemLabel') and normalize-space()='Unit Attributes']")));

                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView(true);", unitAttributes);

                try
                {
                    unitAttributes.Click();
                }
                catch
                {
                    ((IJavaScriptExecutor)driver)
                        .ExecuteScript("arguments[0].click();", unitAttributes);
                }

                Task.Delay(3000).Wait();
            });
        }

        public void TakeScreenshotOfVerifyByEngineer() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-038-SC01", () =>
       {
           try
           {
               Task.Delay(8000).Wait();
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-038-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-038-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });




        // Depot View - Managing Placeholders POM STEPS


        public void TakeScreenshotOfManagingPlaceholders() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-RTS-040-SC01", () =>
       {
           try
           {
               Task.Delay(8000).Wait();
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-RTS-040-SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-RTS-040-SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });




    }



}