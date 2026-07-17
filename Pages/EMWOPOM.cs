using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;


namespace GTR_AUTOMATED.Pages
{
    
    public sealed class EMWOPOM
    {

        private IWebDriver driver;
        public EMWOPOM(IWebDriver drv) => driver = drv;

        private readonly By _acceptWorkOrderIntoWorkBankRadio = By.Id("mb64e0e96-rb");


        public void OpenGoToMenu() =>
           AllureLogger.LogStep("Open [Go To] menu", () =>
               SafeActions.Click(driver, By.Id("titlebar-tb_gotoButton"),
                                 "Go To button"));

        public void WorkOrder() =>
            AllureLogger.LogStep("Open Work Order Menu", () =>
                SafeActions.Click(driver, By.Id("menu0_WO_MODULE_a_tnode"),
                                  "Open Work Order node"));

        public void OpenQuickWorkOrderBRDA() =>
            AllureLogger.LogStep("Open Quick Work Order (BRDA)", () =>
                SafeActions.Click(driver, By.Id("menu0_WO_MODULE_sub_changeapp_BRDAQW_a_tnode"),
                                  "Open Quick Work Order (BRDA) node"));

        public void OpenFaultReportingBRDA() =>
            AllureLogger.LogStep("Launch Fault Reporting (BRDA)", () =>
                SafeActions.Click(driver,
                    By.Id("menu0_WO_MODULE_sub_changeapp_BRDAFR_a_tnode"),
                    "Fault Reporting (BRDA)"));

        public void DetailMenuOfLocationField() =>
           AllureLogger.LogStep("Detail Menu Of Location Field", () =>
               SafeActions.Click(driver,
                   By.CssSelector("#ma4936596-img"),
                   "Detail Menu Of Location Field"));


        public void SelectValueOption() =>
            AllureLogger.LogStep("Select Value Option", () =>
                SafeActions.Click(driver, By.Id("MXRLOCATIONS_mxrlocations0_a_tnode"),
                                  "Select Value Option"));

         public void FilterTableLocation(string Location) =>
      AllureLogger.LogStep($"I filter table Location with '{Location}'", () =>
      {
          By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
          IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(Location);
          filterField.SendKeys(Keys.Enter);
      });

        public void SelectNoRecordFromAssetTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Location Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Location Table Records");
            });

        }

        public void SelectValueLookupForFailureGroupField() =>
            AllureLogger.LogStep("I open Select Value lookup for Failure Group field", () =>
                SafeActions.Click(driver, By.CssSelector("#mc5867e05-img"),
                                  "I open Select Value lookup for Failure Group field"));

        public void SelectNoRecordFromFailureGroupTable(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Failure Group Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Failure Group Table Records");
            });

        }


        public void SelectValueLookupForFailureCodeField() =>
            AllureLogger.LogStep("I open Select Value lookup for Failure Code field", () =>
                SafeActions.Click(driver, By.CssSelector("#m5d07ee1f-img"),
                                  "I open Select Value lookup for Failure Code field"));

        public void SelectNoRecordFromFailureCodeTable(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Failure Code Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Failure Code Table Records");
            });

        }

        public void SelectValueLookupForProblemCodeField() =>
            AllureLogger.LogStep("I open Select Value lookup for Problem Code field", () =>
                SafeActions.Click(driver, By.CssSelector("#m9f693d84-img"),
                                  "I open Select Value lookup for Problem Code field"));

        public void SelectNoRecordFromProblemCodeTable(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Problem Code Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Problem Code Table Records");
            });

        }

        public void OpenSelectValueLookupForRepairFacilityField() =>
          AllureLogger.LogStep("I open Select Value lookup for Repair Facility field", () =>
              SafeActions.Click(driver, By.CssSelector("#ma9fd2572-img"),
                                "I open Select Value lookup for Repair Facility field"));


         public void FilterTableRepairFacility(string RepairFacility) =>
        AllureLogger.LogStep($"I filter table Repair Facility with '{RepairFacility}'", () =>
        {
            By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(RepairFacility);
            filterField.SendKeys(Keys.Enter);
        });


        public void SelectNoRecordFromRepairFacilityTable(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Repair Facility Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Repair Facility Table Records");
            });

        }


        public void SelectValueLookupForReportedPriority() =>
         AllureLogger.LogStep("I open Select Value lookup for Reported Priority field", () =>
             SafeActions.Click(driver, By.CssSelector("#m70a3924-img"),
                               "I open Select Value lookup for Reported Priority field"));

        public void FilterTableReportedPriority(string ReportedPriority) =>
        AllureLogger.LogStep($"I filter table Reported Priority with '{ReportedPriority}'", () =>
        {
            By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:1\\]_txt-tb");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(ReportedPriority);
            filterField.SendKeys(Keys.Enter);
        });



         public void SelectNoRecordFromReportedPriorityTable(int recordNumber)
         {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Reported Priority Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Reported Priority Table Records");
            });

         }

          public void EnterFollowingData(string Headcode) =>
        AllureLogger.LogStep($"I enter following data to '{Headcode}'", () =>
        {
            By filterFieldLocator = By.CssSelector("#m7b9b039d-tb");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(Headcode);
            filterField.SendKeys(Keys.Enter);
        });

        public void EnterFollowingData(string Summary, string Details) =>
       AllureLogger.LogStep($"I filter CM Work Order table with Description = '{Summary}', Details = '{Details}','", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

           // Adjust column indices as per actual table structure:
           // Description = column 2 → C:2
           // Status = column 10 → C:10

           By SummaryFilterLocator = By.CssSelector("#m992c666e-tb");
           By DetailsFilterLocator = By.Id("dijitEditorBody");

           IWebElement SummaryFilter = wait.Until(SeleniumWaits.ElementToBeClickable(SummaryFilterLocator));
           SummaryFilter.Click();
           SummaryFilter.Clear();
           SummaryFilter.SendKeys(Summary);

           var iframe = driver.FindElement(By.Id("m1f7bb5c6-rte_iframe"));
           driver.SwitchTo().Frame(iframe);

           IWebElement DetailsFilter = wait.Until(SeleniumWaits.ElementToBeClickable(DetailsFilterLocator));
           DetailsFilter.Click();
           DetailsFilter.Clear();
           DetailsFilter.SendKeys(Details);

           // Switch back to the main document
           driver.SwitchTo().DefaultContent();

       });


        public void EnterFollowing(string Summary, string Details) =>
        AllureLogger.LogStep($"I filter CM Work Order table with Description = '{Summary}', Details = '{Details}','", () =>
        {
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

             // Adjust column indices as per actual table structure:
             // Description = column 2 → C:2
             // Status = column 10 → C:10

             By SummaryFilterLocator = By.CssSelector("#ma6ef8ebc-tb");
             By DetailsFilterLocator = By.Id("dijitEditorBody");

             IWebElement SummaryFilter = wait.Until(SeleniumWaits.ElementToBeClickable(SummaryFilterLocator));
             SummaryFilter.Click();
             SummaryFilter.Clear();
             SummaryFilter.SendKeys(Summary);

             var iframe = driver.FindElement(By.Id("md1e8be2a-rte_iframe"));
             driver.SwitchTo().Frame(iframe);

             IWebElement DetailsFilter = wait.Until(SeleniumWaits.ElementToBeClickable(DetailsFilterLocator));
             DetailsFilter.Click();
             DetailsFilter.Clear();
             DetailsFilter.SendKeys(Details);

             // Switch back to the main document
             driver.SwitchTo().DefaultContent();

        });
 
        public void RouteTheWorkflow() =>
        AllureLogger.LogStep("I route the workflow", () =>
            SafeActions.Click(driver, By.CssSelector("#ROUTEWF__-tbb_image"),
                              "I route the workflow"));


        public void PressOkButton() =>
        AllureLogger.LogStep("I press Ok button", () =>
            SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"),
                              "I press Ok button"));

        public void PressDialogButtonOfShowDuplicateTickets() =>
       AllureLogger.LogStep("I press dialog button of Show Duplicate Tickets", () =>
           SafeActions.Click(driver, By.CssSelector("#me4e0462a-pb"),
                             "I press dialog button of Show Duplicate Tickets"));
              

        public void IPressDialogButtonOK() =>
       AllureLogger.LogStep("I press Ok button", () =>
       {
            SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"), "I press Ok button");
            Task.Delay(20000).Wait();
       });


        public void IGoToRelatedRecordsTab() =>
      AllureLogger.LogStep("I go to Related Records tab", () =>
          SafeActions.Click(driver, By.Id("m4326cf1d-tab_anchor"),
                            "I go to Related Records tab"));

        public void ViewRelatedWorkOrder() =>
      AllureLogger.LogStep("I view Related Work Order", () =>
          SafeActions.Click(driver, By.Id("mdb9534e9_tdrow_[C:0]_tgdet-ti[R:0]_img"),
                            "I view Related Work Order"));


        public void FieldStatusHasValueWAITREV() =>
           AllureLogger.LogStep("work order Status field has value WAIT-REV", () =>
           {

               try
               {
                   // Wait 10 seconds for the page or element to load
                   Task.Delay(10000).Wait();

                   // Find the Status field element by CSS selector (update selector if needed)
                   var statusField = driver.FindElement(By.CssSelector("#m7d7937f5-tb"));

                   // Get the 'value' attribute of the element
                   string statusValue = statusField.GetAttribute("value");

                   // Validate the value is "WAIT-REV"
                   if (string.IsNullOrEmpty(statusValue))
                   {
                       throw new Exception("Status field is empty or null.");
                   }

                   if (statusValue != "WAIT-REV")
                   {
                       throw new Exception($"Expected status value WAIT-REV but found '{statusValue}'.");
                   }

                   Console.WriteLine("Success: Status field value is WAIT-REV.");
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

        public void TakeScreenshotOfCreateAEMWorkOrderTest() =>
         AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-000", () =>
         {
             try
             {
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-000.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-000_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });



        // Accepting An EM Work Order into the Work Bank PON Steps

         public void TakeScreenshotOfAcceptingAnEMWorkOrderIntoTheWorkBankScenarioOne() =>
         AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-001SC01", () =>
         {
             try
             {
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-001SC01.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-001SC01_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });

           public void FilterTableEM(string description, string status, string workType) =>
         AllureLogger.LogStep(
            $"I filter EM table with Description = '{description}', Status = '{status}', WorkType = '{workType}'",
            () =>
            {
               WebDriverWait wait = new(driver, TimeSpan.FromSeconds(20));
               By descriptionFilterLocator = By.CssSelector("input.tablefilterfield[id*='[C:2]']");
               By statusFilterLocator = By.CssSelector("input.tablefilterfield[id*='[C:11]']");
               By workTypeFilterLocator = By.CssSelector("input.tablefilterfield[id*='[C:4]']");

               // Handle ~Null~ token
               if (workType.Trim().Equals("~Null~",
                  StringComparison.OrdinalIgnoreCase))
               {
                  workType = string.Empty;
               }

                IWebElement descriptionFilter =
                wait.Until(SeleniumWaits.ElementToBeClickable(descriptionFilterLocator));

                descriptionFilter.Click();
                descriptionFilter.Clear();
                descriptionFilter.SendKeys(description);
                IWebElement statusFilter = wait.Until(SeleniumWaits.ElementToBeClickable(statusFilterLocator));
                statusFilter.Click();
                statusFilter.Clear();
                statusFilter.SendKeys(status);
                IWebElement workTypeFilter = wait.Until(SeleniumWaits.ElementToBeClickable(workTypeFilterLocator));
                workTypeFilter.Click();
                workTypeFilter.Clear();
                workTypeFilter.SendKeys(workType);
                workTypeFilter.SendKeys(Keys.Enter);
                Task.Delay(2000).Wait();
                wait.Until(SeleniumWaits.ElementToBeClickable(workTypeFilterLocator));

            });

        public void SelectNoRecordFromEMTable(int recordNumber)
        { 
            AllureLogger.LogStep($"I Select No {recordNumber} Record From EM Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From EM Table Records");
            });

        }



            public void OpenApplicationWorkOrderTrackingBRDAFromFavMenu() =>
         AllureLogger.LogStep("I open application Work Order Tracking BRDA from Fav Menu", () =>
         {
                   SafeActions.Click(driver, By.Id("FavoriteApp_BRDAWO"),
                      "I open application Work Order Tracking BRDA from Fav Menu");

                    // Wait 5 seconds after clicking
                   Task.Delay(3000).Wait();
         });

        public void SetRadioField(string radioValue)
        {
            AllureLogger.LogStep(
                $"I set (Radio) field to {radioValue}",
                () =>
                {
                    By radioButtonLocator = By.XPath(
                        $"//td[normalize-space()='{radioValue}']/preceding-sibling::td//input[@type='radio']");

                    SafeActions.Click(
                        driver,
                        radioButtonLocator,
                        $"Radio field: {radioValue}");

                    Task.Delay(2000).Wait();
                });
        }

        public void StatusFieldHasValueREVIEWED() =>
          AllureLogger.LogStep("work order Status field has value REVIEWED", () =>
          {

              try
              {
                  // Wait 10 seconds for the page or element to load
                  Task.Delay(25000).Wait();

                  // Find the Status field element by CSS selector (update selector if needed)
                  var statusField = driver.FindElement(By.CssSelector("#md3801d08-tb"));

                  // Get the 'value' attribute of the element
                  string statusValue = statusField.GetAttribute("value");

                  // Validate the value is "REVIEWED"
                  if (string.IsNullOrEmpty(statusValue))
                  {
                      throw new Exception("Status field is empty or null.");
                  }

                  if (statusValue != "REVIEWED")
                  {
                      throw new Exception($"Expected status value REVIEWED but found '{statusValue}'.");
                  }

                  Console.WriteLine("Success: Status field value is REVIEWED.");
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

          public void TakeScreenshotOfAcceptingAnEMWorkOrderIntoTheWorkBankScenariotwo() =>
         AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-001SC02", () =>
         {
             try
             {
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-001SC02.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-001SC02_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });




        //Rejecting An EM Work Order form the Work Bank POM Steps



        public void TakeScreenshotOfRejectingAnEMWorkOrderFormTheWorkBankScenarioOne() =>
        AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-002SC01", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-002SC01.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-002SC01_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });

          public void StatusFieldHasValueCANCELLED() =>
          AllureLogger.LogStep("work order Status field has value CANCELLED", () =>
          {

              try
              {
                  // Wait 10 seconds for the page or element to load
                  Task.Delay(25000).Wait();

                  // Find the Status field element by CSS selector (update selector if needed)
                  var statusField = driver.FindElement(By.CssSelector("#md3801d08-tb"));

                  // Get the 'value' attribute of the element
                  string statusValue = statusField.GetAttribute("value");

                  // Validate the value is "CAN"
                  if (string.IsNullOrEmpty(statusValue))
                  {
                      throw new Exception("Status field is empty or null.");
                  }

                  if (statusValue != "CAN")
                  {
                      throw new Exception($"Expected status value CAN but found '{statusValue}'.");
                  }

                  Console.WriteLine("Success: Status field value is CAN.");
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


        public void TakeScreenshotOfRejectingAnEMWorkOrderFormTheWorkBankScenariotwo() =>
        AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-002SC02", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-002SC02.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-002SC02_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });




        // Assigning an EM Work Order Depot POM Steps



         public void TakeScreenshotOfAssigningAnEMWorkOrderScenarioOne() =>
        AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-003SC01", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-003SC01.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-003SC01_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });


        public void TakeScreenshotOfAssigningAnEMWorkOrderScenariotwo() =>
        AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-003SC02", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-003SC02.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-003SC02_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });


        public void GoToAssignmentTab() =>
     AllureLogger.LogStep("I go to Assignment tab", () =>
         SafeActions.Click(driver, By.Id("m308a50dd-tab_anchor"),
                           "I go to Assignment tab"));

        public void AddNewRowUnderAssignmentsTab() =>
     AllureLogger.LogStep("I press add new row under Assignments tab", () =>
         SafeActions.Click(driver, By.CssSelector("#m6798a95d_bg_button_addrow-pb"),
                           "I press add new row under Assignments tab"));

        public void SelectValueLookupForLaborField() =>
     AllureLogger.LogStep("I select Value lookup for Labor field", () =>
         SafeActions.Click(driver, By.CssSelector("#m5080505d-img"),
                           "I select Value lookup for Labor field"));

        public void FilterTableLabor(string labor) =>
       AllureLogger.LogStep($"I filter table Repair Facility with '{labor}'", () =>
       {
           By filterFieldLocator = By.CssSelector("#m825a12a1_tfrow_\\[C\\:0\\]_txt-tb");

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

           filterField.Click();
           filterField.Clear();
           filterField.SendKeys(labor);
           filterField.SendKeys(Keys.Enter);
       });


        public void SelectNoFromLaborTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From labor Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m825a12a1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From labor Table Records");
                Task.Delay(5000).Wait();
            });

        }

         public void PreeOkDialogSystemMessageButton() =>
        AllureLogger.LogStep("I pree Ok dialog system message button", () =>
            SafeActions.Click(driver, By.CssSelector("#m88dbf6ce-pb"),
                          "I pree Ok dialog system message button"));



        public void ISave()
        {
            AllureLogger.LogStep("I Save Record", () =>
                SafeActions.Click(driver, By.Id("toolactions_SAVE-tbb_anchor"), "I Save Record"));
                Task.Delay(8000).Wait();

        }
                  

        public void ClickOKDialogButton() =>
       AllureLogger.LogStep("I click OK dialog button", () =>
           SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"),
                         "I click OK dialog button"));

        public void StatusFieldHasValueSCHEDULED() =>
          AllureLogger.LogStep("work order Status field has value SCHEDULED", () =>
          {

              try
              {
                  // Wait 10 seconds for the page or element to load
                  Task.Delay(25000).Wait();

                  // Find the Status field element by CSS selector (update selector if needed)
                  var statusField = driver.FindElement(By.CssSelector("#mefe31dd8-tb"));

                  // Get the 'value' attribute of the element
                  string statusValue = statusField.GetAttribute("value");

                  // Validate the value is "SCHEDULED"
                  if (string.IsNullOrEmpty(statusValue))
                  {
                      throw new Exception("Status field is empty or null.");
                  }

                  if (statusValue != "SCHEDULED")
                  {
                      throw new Exception($"Expected status value SCHEDULED but found '{statusValue}'.");
                  }

                  Console.WriteLine("Success: Status field value is SCHEDULED.");
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
          


             public void TakeScreenshotOfAssigningAnEMWorkOrderScenariothree() =>
        AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-003SC03", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-003SC03.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-003SC03_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });



        //Pausing an EM Work Order POM Steps



          public void TakeScreenshotOfPausingAnEMWorkOrderScenarioOne() =>
        AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-004SC01", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-004SC01.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-004SC01_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });

        public void TakeScreenshotOfPausingAnEMWorkOrderScenariotwo() =>
        AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-004SC02", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-004SC02.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-004SC02_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });

        public void TakeScreenshotOfPausingAnEMWorkOrderScenariothree() =>
        AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-004SC03", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-004SC03.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-004SC03_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });
             

        public void PressDialogOk()
        {
            AllureLogger.LogStep("I press dialog Ok", () =>
                SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"), "I press dialog Ok"));
                Task.Delay(10000).Wait();
        }


        public void VerifyWorkOrderStatusHasValueINPRG() =>
          AllureLogger.LogStep("work order Status field has value INPRG", () =>
          {

              try
              {
                  // Wait 10 seconds for the page or element to load
                  Task.Delay(10000).Wait();

                  // Find the Status field element by CSS selector (update selector if needed)
                  var statusField = driver.FindElement(By.CssSelector("#md3801d08-tb"));

                  // Get the 'value' attribute of the element
                  string statusValue = statusField.GetAttribute("value");

                  // Validate the value is "INPRG"
                  if (string.IsNullOrEmpty(statusValue))
                  {
                      throw new Exception("Status field is empty or null.");
                  }

                  if (statusValue != "INPRG")
                  {
                      throw new Exception($"Expected status value INPRG but found '{statusValue}'.");
                  }

                  Console.WriteLine("Success: Status field value is INPRG.");
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

                    
          public void ClickDialogOk() =>
         AllureLogger.LogStep("I click dialog Ok", () =>
         {
             SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"),
                          "I click dialog Ok");
             Task.Delay(10000).Wait();
         });



        public void VerifyStatusFieldHasValueINPRGHOLD() =>
         AllureLogger.LogStep("work order Status field has value INPRG-HOLD", () =>
         {

             try
             {
                 // Wait 10 seconds for the page or element to load
                 Task.Delay(10000).Wait();

                 // Find the Status field element by CSS selector (update selector if needed)
                 var statusField = driver.FindElement(By.CssSelector("#md3801d08-tb"));

                 // Get the 'value' attribute of the element
                 string statusValue = statusField.GetAttribute("value");

                 // Validate the value is "INPRG-HOLD"
                 if (string.IsNullOrEmpty(statusValue))
                 {
                     throw new Exception("Status field is empty or null.");
                 }

                 if (statusValue != "INPRG-HOLD")
                 {
                     throw new Exception($"Expected status value INPRG-HOLD but found '{statusValue}'.");
                 }

                 Console.WriteLine("Success: Status field value is INPRG-HOLD.");
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

         public void TakeScreenshotOfPausingAnEMWorkOrderScenariofour() =>
        AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-004SC04", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-004SC04.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-004SC04_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });



        //  Completing an EM Work Order for Review POM Steps



          public void TakeScreenshotOfCompletingAnEMWorkOrderForReviewScenarioOne() =>
        AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-005SC01", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-005SC01.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-005SC01_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });


        public void TakeScreenshotOfCompletingAnEMWorkOrderForReviewScenariotwo() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-005SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-005SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-005SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

        public void TakeScreenshotOfCompletingAnEMWorkOrderForReviewScenariothree() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-005SC03", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-005SC03.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-005SC03_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

        public void FilterTableQuickWorkOrder(string description, string status, string WorkType) =>
         AllureLogger.LogStep($"I filter PM table with Description = '{description}', Status = '{status}', WorkType = '{WorkType}'", () =>
         {
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

             // Adjust column indices as per actual table structure:
             // Example assumptions:
             // Description = column 1 → C:1
             // Status = column 3 → C:3
             // Parent = column 4 → C:4

             By descriptionFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:2\\]_txt-tb");
             By statusFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:7\\]_txt-tb");
             By WorkTypeFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:3\\]_txt-tb");

             // Handle ~Null~ token as empty string
             if (WorkType.Trim().Equals("~Null~", StringComparison.OrdinalIgnoreCase))
             {
                 WorkType = "";
             }

             IWebElement descriptionFilter = wait.Until(SeleniumWaits.ElementToBeClickable(descriptionFilterLocator));
             descriptionFilter.Click();
             descriptionFilter.Clear();
             descriptionFilter.SendKeys(description);

             IWebElement statusFilter = wait.Until(SeleniumWaits.ElementToBeClickable(statusFilterLocator));
             statusFilter.Click();
             statusFilter.Clear();
             statusFilter.SendKeys(status);

             IWebElement WorkTypeFilter = wait.Until(SeleniumWaits.ElementToBeClickable(WorkTypeFilterLocator));
             WorkTypeFilter.Click();
             WorkTypeFilter.Clear();
             WorkTypeFilter.SendKeys(WorkType);

             // Press Enter on the last filter field to trigger filtering
             WorkTypeFilter.SendKeys(Keys.Enter);
         });


        public void OpenApplicationQuickWorkOrderBRDAFromFavMenu() =>
       AllureLogger.LogStep("I open application Quick Work Order BRDA from Fav Menu", () =>
           SafeActions.Click(driver, By.Id("FavoriteApp_BRDAQW"),
                          "I open application Quick Work Order BRDA from Fav Menu"));
               
        public void PressDialogOkButtonOfSystemMessage() =>
       AllureLogger.LogStep("I press dialog Ok button of system message", () =>
           SafeActions.Click(driver, By.CssSelector("#m88dbf6ce-pb"),
                          "I press dialog Ok button of system message"));

        public void PressDialogButtonClose() =>
       AllureLogger.LogStep("I press dialog button close", () =>
           SafeActions.Click(driver, By.CssSelector("#m15f1c9f0-pb"),
                          "I press dialog button close"));


        public void GoToLaborTab() =>
       AllureLogger.LogStep("I go to labor tab", () =>
           SafeActions.Click(driver, By.Id("m5ff7dbee-tab_anchor"),
                          "I go to labor tab"));

        public void PressAddNewRowButton() =>
       AllureLogger.LogStep("I press add new row button", () =>
           SafeActions.Click(driver, By.CssSelector("#m6054d85d_bg_button_addrow-pb"),
                          "I press add new row button"));


        public void DetailMenuOflaborField() =>
         AllureLogger.LogStep("Detail Menu Of labor Field", () =>
             SafeActions.Click(driver,
                 By.CssSelector("#m52473e68-img"),
                 "Detail Menu Of Location Field"));

        public void SelectValueOptionoflaborField() =>
         AllureLogger.LogStep("Select Value Option", () =>
             SafeActions.Click(driver,
                 By.Id("LABORCRAFTRATE_LABORCRAFTRATE1_a_tnode"),
                 "Select Value Option"));

          public void FilterTableRecordLabor(string labor) =>
        AllureLogger.LogStep($"I filter table Repair Facility with '{labor}'", () =>
        {
            By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(labor);
            filterField.SendKeys(Keys.Enter);
        });


        public void SelectNoRecordFromLaborTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From labor Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From labor Table Records");
                Task.Delay(5000).Wait();
            });

        }

             public void ISetStartAndEndTime() =>
        AllureLogger.LogStep("Set Scheduled Start and End Date/Time", () =>
        {    // Prepare date and time values
         string todayDate = DateTime.Today.ToString("dd-MM-yyyy");
         string startDate = DateTime.Today.AddDays(-2).ToString("dd-MM-yyyy");
         string endDate = DateTime.Today.AddDays(-5).ToString("dd-MM-yyyy");
         string currentTime = DateTime.Now.ToString("HH:mm:ss");

         // Set Start Date
         var startDateLocator = By.CssSelector("#me8b034e0-tb");
         var startDateBox = driver.FindElement(startDateLocator);
         startDateBox.Clear();
         startDateBox.SendKeys(startDate);
         Task.Delay(1000).Wait();

         // Set Start Time
         var startTimePickerIcon = By.CssSelector("#m4673eb05-img");
         var startTimeCell = By.XPath("//*[@id=\"m4673eb05-tb_popup\"]/div[9]/div");

         // 1️⃣ Click to open time picker
         driver.FindElement(startTimePickerIcon).Click();
         Task.Delay(1000).Wait();

         // 2️⃣ Click specific time cell from the time picker
         var startimeCell = driver.FindElement(startTimeCell);
         startimeCell.Click();
         Task.Delay(1000).Wait();


         // Set End Date
         var endDateLocator = By.CssSelector("#m92706780-tb");
         var endDateBox = driver.FindElement(endDateLocator);
         endDateBox.Clear();
         endDateBox.SendKeys(endDate);
         Task.Delay(1000).Wait();

         // Select End Time from Time Picker Table
         var endTimePickerIcon = By.CssSelector("#m76d4a143-img");
         var endTimeCell = By.XPath("//*[@id=\"m76d4a143-tb_popup\"]/div[17]/div");

         // 1️⃣ Click to open time picker
         driver.FindElement(endTimePickerIcon).Click();
         Task.Delay(1000).Wait();

         // 2️⃣ Click specific time cell from the time picker
         var timeCell = driver.FindElement(endTimeCell);
         timeCell.Click();
         Task.Delay(3000).Wait();

        });


        public void GoToFailureReportingTab() =>
      AllureLogger.LogStep("I go to Failure Reporting Tab", () =>
          SafeActions.Click(driver, By.Id("m820ba5de-tab_anchor"),
                         "I go to Failure Reporting Tab"));

         public void PressTheButtonSelectFailureCodes() =>
      AllureLogger.LogStep("I press the button Select Failure Codes", () =>
          SafeActions.Click(driver, By.Id("mb030af35_bg_button_listfailurecodes-pb"),
                         "I press the button Select Failure Codes"));


         public void FilterTableFailureCodes(string FailureCodes) =>
      AllureLogger.LogStep($"I filter table Failure Codes with '{FailureCodes}'", () =>
      {
          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

          // Step 1: Click on the filter/search icon first
          By filterIconLocator = By.CssSelector("#mc36b05ed-lb2"); // Update selector as needed
          IWebElement filterIcon = wait.Until(SeleniumWaits.ElementToBeClickable(filterIconLocator));
          filterIcon.Click();
          Task.Delay(2000).Wait();

          // Step 2: Interact with the filter input field
          By filterFieldLocator = By.CssSelector("#mc36b05ed_tfrow_\\[C\\:0\\]_txt-tb");
          IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));
          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(FailureCodes);
          filterField.SendKeys(Keys.Enter);

      });

        
        public void CauseCodes() =>
       AllureLogger.LogStep("I select cause codes", () =>
           SafeActions.Click(driver, By.Id("mc36b05ed_tdrow_[C:0]_ttxt-lb[R:0]"),
                             "I select cause codes"));

        public void RemedyCodes() =>
        AllureLogger.LogStep("I select remedy codes", () =>
        {
            SafeActions.Click(driver, By.Id("mc36b05ed_tdrow_[C:0]_ttxt-lb[R:0]"), "I select remedy codes");
            Task.Delay(3000).Wait();
        });

        public void GoToLogTab() =>
        AllureLogger.LogStep("I go to Log Tab", () =>
             SafeActions.Click(driver, By.CssSelector("#m8f3f68c5-tab_anchor"),
                        "I go to Log Tab"));

        public void AddNewRowButton() =>
       AllureLogger.LogStep("I add new row Button", () =>
            SafeActions.Click(driver, By.CssSelector("#m295a70c1_bg_button_addrow-pb"),
                       "I add new row Button"));

        public void ClickDialogOkButton() =>
       AllureLogger.LogStep("I Click dialog Ok button", () =>
            SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"),
                       "I Click dialog Ok button"));


        public void StatusFieldHasValueCOMPWREV() =>
         AllureLogger.LogStep("work order Status field has value COMP-WREV", () =>
         {

             try
             {
                 // Wait 10 seconds for the page or element to load
                 Task.Delay(25000).Wait();

                 // Find the Status field element by CSS selector (update selector if needed)
                 var statusField = driver.FindElement(By.CssSelector("#me6e07274-tb"));

                 // Get the 'value' attribute of the element
                 string statusValue = statusField.GetAttribute("value");

                 // Validate the value is "COMP-WREV"
                 if (string.IsNullOrEmpty(statusValue))
                 {
                     throw new Exception("Status field is empty or null.");
                 }

                 if (statusValue != "COMP-WREV")
                 {
                     throw new Exception($"Expected status value COMP-WREV but found '{statusValue}'.");
                 }

                 Console.WriteLine("Success: Status field value is COMP-WREV.");
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

         public void TakeScreenshotOfCompletingAnEMWorkOrderForReviewScenariofour() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-005SC04", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-005SC04.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-005SC04_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        //Rejecting an EM Work Order POM Steps



         public void TakeScreenshotOfRejectingAnEMWorkOrderScenarioOne() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-006SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-006SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-006SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

               
         public void TakeScreenshotOfRejectingAnEMWorkOrderScenariotwo() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-006SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-006SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-006SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

         public void TakeScreenshotOfRejectingAnEMWorkOrderScenariothree() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-006SC03", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-006SC03.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-006SC03_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


          public void TakeScreenshotOfRejectingAnEMWorkOrderScenariofour() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-006SC04", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-006SC04.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-006SC04_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });
        
          public void PressOKButton() =>
       AllureLogger.LogStep("I press OK button", () =>
           SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"),
                          "I press OK button"));


         public void StatusFieldHasValueINPRGHOLD() =>
         AllureLogger.LogStep("work order Status field has value INPRG-HOLD", () =>
         {

             try
             {
                 // Wait 10 seconds for the page or element to load
                 Task.Delay(10000).Wait();

                 // Find the Status field element by CSS selector (update selector if needed)
                 var statusField = driver.FindElement(By.CssSelector("#md3801d08-tb"));

                 // Get the 'value' attribute of the element
                 string statusValue = statusField.GetAttribute("value");

                 // Validate the value is "INPRG-HOLD"
                 if (string.IsNullOrEmpty(statusValue))
                 {
                     throw new Exception("Status field is empty or null.");
                 }

                 if (statusValue != "INPRG-HOLD")
                 {
                     throw new Exception($"Expected status value INPRG-HOLD but found '{statusValue}'.");
                 }

                 Console.WriteLine("Success: Status field value is INPRG-HOLD.");
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

          
          public void TakeScreenshotOfRejectingAnEMWorkOrderScenariofive() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-006SC05", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-006SC05.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-006SC05_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });



        //Approving an EM Work Order POM Steps

         public void TakeScreenshotOfApprovingAnEMWorkOrderScenarioOne() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-007SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-007SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-007SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

        public void TakeScreenshotOfApprovingAnEMWorkOrderScenariotwo() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-007SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-007SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-007SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

        public void TakeScreenshotOfApprovingAnEMWorkOrderScenariothree() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-007SC03", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-007SC03.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-007SC03_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void TakeScreenshotOfApprovingAnEMWorkOrderScenariofour() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-007SC04", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-007SC04.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-007SC04_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void TakeScreenshotOfApprovingAnEMWorkOrderScenariofive() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-007SC05", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-007SC05.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-007SC05_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });
           public void StatusFieldHasValueCOMP() =>
           AllureLogger.LogStep("work order Status field has value COMP", () =>
           {

               try
               {
                   // Wait 10 seconds for the page or element to load
                   Task.Delay(10000).Wait();

                   // Find the Status field element by CSS selector (update selector if needed)
                   var statusField = driver.FindElement(By.CssSelector("#md3801d08-tb"));

                   // Get the 'value' attribute of the element
                   string statusValue = statusField.GetAttribute("value");

                   // Validate the value is "COMP"
                   if (string.IsNullOrEmpty(statusValue))
                   {
                       throw new Exception("Status field is empty or null.");
                   }

                   if (statusValue != "COMP")
                   {
                       throw new Exception($"Expected status value COMP but found '{statusValue}'.");
                   }

                   Console.WriteLine("Success: Status field value is COMP.");
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











        //MWE POM Steps



          public void GoToPlansTab() =>
       AllureLogger.LogStep("I go to Plans tab", () =>
           SafeActions.Click(driver, By.Id("m356798d1-tab_anchor"),
                          "I go to Plans tab"));


           public void PressAddNewRowUnderTaskForWorkOrderSection() =>
        AllureLogger.LogStep("I press add new row under Task for work order section", () =>
        {
             SafeActions.Click(driver, By.CssSelector("#mbb442a0c_bg_button_addrow-pb"),
                          "I press add new row under Task for work order section");

            // ⏳ Wait for 2 seconds after the click (adjust as needed)
             Task.Delay(5000).Wait();
        });



          public void EnterTaskDescription(string TaskDescription) =>
        AllureLogger.LogStep($"I enter Task Description '{TaskDescription}'", () =>
        {
            By filterFieldLocator = By.CssSelector("#mb804724a-tb2");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(TaskDescription);
            Task.Delay(2000).Wait();
        });


        
          public void OpenSelectValueLookupForTaskRequiresToolsOrCommentsField() =>
       AllureLogger.LogStep("I open Select Value lookup for Task Requires Tools or Comments field", () =>
           SafeActions.Click(driver, By.CssSelector("#me1871065-img"),
                          "I open Select Value lookup for Task Requires Tools or Comments field"));


        public void SelectY()
        {
            AllureLogger.LogStep("I select 'Y' from the table", () =>
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var cellLocator = By.Id("lookup_page1_tdrow_[C:1]_ttxt-lb[R:1]");
                var resultTextFieldLocator = By.CssSelector("#me1871065-tb"); 

                // Step 1: Wait for and click the Y cell in the table
                wait.Until(SeleniumWaits.ElementToBeClickable(cellLocator));
                SafeActions.Click(driver, cellLocator, "I select 'Y' from the table");

                // Step 2: Wait for the text field to reflect the selection of 'Y'
                wait.Until(driver =>
                {
                    try
                    {
                        var textField = driver.FindElement(resultTextFieldLocator);
                        return textField.Displayed && textField.GetAttribute("value").Trim() == "Y";
                    }
                    catch
                    {
                        return false;
                    }
                });

                // Step 3: Validate the field really contains 'Y'
                var resultField = driver.FindElement(resultTextFieldLocator);
                string actualValue = resultField.GetAttribute("value").Trim();

                if (actualValue != "Y")
                {
                    throw new Exception($"Expected 'Y' in the result field, but found '{actualValue}'");
                }
                Task.Delay(3000).Wait();
            });
        }



        public void DetailMenuOfMeasurementPointField() =>
           AllureLogger.LogStep("Detail Menu Of Measurement Point Field", () =>
               SafeActions.Click(driver,
                   By.CssSelector("#mc9acecf2-img"),
                   "Detail Menu Of Measurement Point Field"));


        public void SelectValueOptionofMeasurementPointField() =>
            AllureLogger.LogStep("Select Value Option of Measurement Point Field", () =>
                SafeActions.Click(driver, By.Id("NORMAL_normal0_a_tnode"),
                                  "Select Value Option of Measurement Point Field"));

          public void FilterTableMeasurementPoint(string measurementPoint) =>
        AllureLogger.LogStep($"I filter table by Measurement Point '{measurementPoint}'", () =>
        {
           var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            var filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");

            // Wait until the filter field is clickable
            var filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            // Perform filter action
            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(measurementPoint);
            filterField.SendKeys(Keys.Enter);
        });



        public void SelectNoRecordFromMeasurementPointTable(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Measurement Point Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Measurement Point Table Records");
                Task.Delay(5000).Wait();
            });

        }











    }
}