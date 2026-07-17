using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;


namespace GTR_AUTOMATED.Pages
{
   
    public sealed class DEFECTIVEASSETMANAGEMENTPOM
    {

        private readonly IWebDriver driver;
        public DEFECTIVEASSETMANAGEMENTPOM(IWebDriver drv) => driver = drv;


         public void SelectAssetsFromProductionDropOffLocationPortlet() =>
         AllureLogger.LogStep("I select assets from production drop-off location portlett", () =>
             SafeActions.Click(driver, By.XPath("//*[@id='rsportletdata_502406']/table/tbody/tr[3]/td[1]/a"),
                         "I select assets from production drop-off location portlet"));
         
          public void SelectAction() =>
         AllureLogger.LogStep("I Select Action", () =>
         {
             SafeActions.Click(driver, By.CssSelector("#toolbar2_tbs_1_tbcb_0_action-img"), "I Select Action");
             Task.Delay(3000).Wait();
         });

         public void MoveAsset() =>
         AllureLogger.LogStep("Move Asset", () =>
             SafeActions.Click(driver, By.Id("menu0_AM39_HEADER_a_tnode"),
                         "Move Asset"));

         public void SelectMoveModifyAsset() =>
         AllureLogger.LogStep("I select Move Modify Assett", () =>
             SafeActions.Click(driver, By.Id("menu0_AM39_HEADER_sub_PLUSTMVAST_OPTION_a_tnode"),
                         "I select Move Modify Asset"));

        
         public void DetailMenuOfLocation() =>
         AllureLogger.LogStep("Detail Menu of location", () =>
             SafeActions.Click(driver, By.CssSelector("#m3aa0526f-img"),
                         "Detail Menu of location"));

        
         public void SelectValueOfLocation() =>
         AllureLogger.LogStep("Select Value of location", () =>
             SafeActions.Click(driver, By.Id("PLUSTLOCATIONS_plustlocations0_a_tnode"),
                         "Select Value of location"));


         public void FilterTableLocation(string location) =>
        AllureLogger.LogStep($"I filter table location with '{location}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By locationLocator = By.CssSelector("#lookup_page2_tfrow_\\[C\\:0\\]_txt-tb");
            IWebElement locationField = wait.Until(SeleniumWaits.ElementToBeClickable(locationLocator));

            locationField.Click();
            locationField.Clear();
            locationField.SendKeys(location);
            locationField.SendKeys(Keys.Enter);
            Task.Delay(5000).Wait();
        });

         public void SelectNoRecordFromLocationTableRecord(int recordNumber)
         {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From location Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From location Table Records");
                Task.Delay(3000).Wait();
            });

         }
         
         public void SelectApplyButton() =>
         AllureLogger.LogStep("I select apply button", () =>
             SafeActions.Click(driver, By.Id("ma28b578c-pb"),
                         "I select apply button"));

         public void PressOk() =>
         AllureLogger.LogStep("I press Ok", () =>
             SafeActions.Click(driver, By.CssSelector("#m18300ad8-pb"),
                         "I press Ok"));

         public void PressOkDilaogToCloseSystemMessage() =>
         AllureLogger.LogStep("I press Ok dilaog to close system message", () =>
             SafeActions.Click(driver, By.CssSelector("#m88dbf6ce-pb"),
                         "I press Ok dilaog to close system message"));

        public void TakeScreenshotOfMoveDefectiveAssetFromDrop_OffLocationTest() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-TR-DA-001", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-TR-DA-001.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-DA-001_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });




        // Raising a Warranty Claim POM Steps 

        public void OpenGoToMenu() =>
           AllureLogger.LogStep("Open [Go To] menu", () =>
               SafeActions.Click(driver, By.Id("titlebar-tb_gotoButton"),
                                 "Go To button"));

         public void WarranityMenu() =>
            AllureLogger.LogStep("Open Warranity menu", () =>
                SafeActions.Click(driver, By.Id("menu0_PLUSTWARR_MODULE_a_tnode"),
                                  "Open Warranity menu"));

         public void WarrantyClaimsTr() =>
            AllureLogger.LogStep("Launch Warranty Claims Tr", () =>
                SafeActions.Click(driver, By.Id("menu0_PLUSTWARR_MODULE_sub_changeapp_PLUSTCLAIM_a_tnode"),
                                  "Launch Warranty Claims Tr"));

           public void SelectCreateNewClamsButton() =>
         AllureLogger.LogStep("I select create new clams button", () =>
             SafeActions.Click(driver, By.Id("toolactions_INSERT-tbb_image"),
                         "I select create new clams button"));


          public void FilterTableClams(string Clams) =>
        AllureLogger.LogStep($"I enter Clams Details '{Clams}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By ClamsLocator = By.CssSelector("#ma7159db6-tb2");
            IWebElement ClamsField = wait.Until(SeleniumWaits.ElementToBeClickable(ClamsLocator));

            ClamsField.Click();
            ClamsField.Clear();
            ClamsField.SendKeys(Clams);
           
        });

          public void DetailMenuOfAsset() =>
         AllureLogger.LogStep("Detail Menu Of Asset", () =>
             SafeActions.Click(driver, By.CssSelector("#m4afe84cd-img"),
                         "Detail Menu Of Asset"));

          public void SelectValueOfAsset() =>
         AllureLogger.LogStep("I Select Value Of Asset", () =>
             SafeActions.Click(driver, By.Id("PLUSTASSETMAIN_plustassetmain0_a_tnode"),
                         "I Select Value Of Asset"));

           public void FilterTableAsset(string asset, string Location) =>
       AllureLogger.LogStep($"I filter table Asset using Asset: '{asset}' or Location: '{Location}'", () =>
       {
               WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

           if (!string.IsNullOrWhiteSpace(asset))
           {
                By assetLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");
                IWebElement assetField = wait.Until(SeleniumWaits.ElementToBeClickable(assetLocator));
                assetField.Click();
                assetField.Clear();
                assetField.SendKeys(asset);
                assetField.SendKeys(Keys.Enter);
               Task.Delay(2000).Wait();
           }

           if (!string.IsNullOrWhiteSpace(Location))
           {
                By LocationLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:3\\]_txt-tb");
                IWebElement LocationField = wait.Until(SeleniumWaits.ElementToBeClickable(LocationLocator));
                LocationField.Click();
                LocationField.Clear();
                LocationField.SendKeys(Location);
                LocationField.SendKeys(Keys.Enter);
               Task.Delay(2000).Wait();
           }
       });



        public void SelectNoRecordFromAssetTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From asset Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From asset Table Records");
                Task.Delay(3000).Wait();
            });

        }

        public void SetRadioFieldToSubmitClaim() =>
        AllureLogger.LogStep("I set (Radio) field to Submit Claim", () =>
            SafeActions.Click(driver, By.CssSelector("#mb64e0e96-rb"),
                        "I set (Radio) field to Submit Claim"));


        public void PressDialogButtonOK() =>
        AllureLogger.LogStep("I Press dialog button OK", () =>
            SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"),
                        "I Press dialog button OK"));


        public void ChangeClamsStatus() =>
        AllureLogger.LogStep("I Change Clams Status", () =>
            SafeActions.Click(driver, By.Id("toolactions_STATUS-tbb_image"),
                        "I Change Clams Status"));


        public void DropDownOption() =>
        AllureLogger.LogStep("DropDown Option button", () =>
            SafeActions.Click(driver, By.XPath("//*[@id='mc927149a-img']"),
                        "DropDown Option button"));


        public void StatusToWaitingOnApprovalWAPPR() =>
        AllureLogger.LogStep("I Select Status Waiting On Approval WAPPR", () =>
            SafeActions.Click(driver, By.Id("menu0_WAPPR_OPTION_a_tnode"),
                        "I Select Status Waiting On Approval WAPPR"));

        public void PressDialogButtonOKSystemMessage() =>
        AllureLogger.LogStep("I press dialog button OK system message", () =>
            SafeActions.Click(driver, By.CssSelector("#m60bd6d91-pb"),
                        "I press dialog button OK system message"));

        public void GoToClamsLogTab() =>
        AllureLogger.LogStep("I go to clams Log tab", () =>
            SafeActions.Click(driver, By.Id("m8f3f68c5-tab_anchor"),
                        "I go to clams Log tab"));

        public void SelectTheNewRowButton() =>
        AllureLogger.LogStep("I select the New Row button", () =>
            SafeActions.Click(driver, By.CssSelector("#m524afe2e_bg_button_addrow-pb"),
                        "I select the New Row button"));

            public void EnterFollowingClaimLogs(string Summary, string Details) =>
        AllureLogger.LogStep($"I enter following claim logs = '{Summary}', Details = '{Details}','", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            By SummaryFilterLocator = By.CssSelector("#m344e2d37-tb");
            By DetailsFilterLocator = By.Id("dijitEditorBody");

            IWebElement SummaryFilter = wait.Until(SeleniumWaits.ElementToBeClickable(SummaryFilterLocator));
            SummaryFilter.Click();
            SummaryFilter.Clear();
            SummaryFilter.SendKeys(Summary);

            var iframe = driver.FindElement(By.Id("m43491da1-rte_iframe"));
            driver.SwitchTo().Frame(iframe);

            IWebElement DetailsFilter = wait.Until(SeleniumWaits.ElementToBeClickable(DetailsFilterLocator));
            DetailsFilter.Click();
            DetailsFilter.Clear();
            DetailsFilter.SendKeys(Details);

            // Switch back to the main document
            driver.SwitchTo().DefaultContent();

        });

         public void GoToClaimTab() =>
        AllureLogger.LogStep("I go to claim tab", () =>
            SafeActions.Click(driver, By.Id("mbf28cd64-tab_anchor"),
                        "I go to claim tab"));

        public void EnterFollowingClaimData(string RMAReference, string MissedPeaks) =>
        AllureLogger.LogStep(
            $"I enter following claim data = '{RMAReference}', Details = '{MissedPeaks}'",
            () =>
            {
               WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

               By RMAReferenceFilterLocator = By.CssSelector("#m88088f8e-tb");
               By MissedPeaksFilterLocator = By.CssSelector("#mf4f7a6-tb");

               IWebElement RMAReferenceFilter = wait.Until(driver =>
               {
                  var element = driver.FindElement(RMAReferenceFilterLocator);
                  return element.Displayed && element.Enabled ? element : null;
               });

               RMAReferenceFilter.Click();
               RMAReferenceFilter.Clear();
               RMAReferenceFilter.SendKeys(RMAReference);

               IWebElement MissedPeaksFilter = wait.Until(driver =>
               {
                 var element = driver.FindElement(MissedPeaksFilterLocator);
                 return element.Displayed && element.Enabled ? element : null;
               });

               MissedPeaksFilter.Click();
               MissedPeaksFilter.Clear();
               MissedPeaksFilter.SendKeys(MissedPeaks);
            });


        public void DetailMenuOfContract() =>
        AllureLogger.LogStep("Detail Menu Of Contract", () =>
            SafeActions.Click(driver, By.CssSelector("#m4348c8e6-img"),
                        "Detail Menu Of Contract"));

         public void SelectValueOfContract() =>
        AllureLogger.LogStep("Select Value Of Contract", () =>
            SafeActions.Click(driver, By.Id("NORMAL_normal0_a_tnode"),
                        "Select Value Of Contract"));

        public void FilterTableContract(string Contract) =>
       AllureLogger.LogStep($"I filter table location with '{Contract}'", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           By ContractLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:1\\]_txt-tb");
           IWebElement ContractField = wait.Until(SeleniumWaits.ElementToBeClickable(ContractLocator));

           ContractField.Click();
           ContractField.Clear();
           ContractField.SendKeys(Contract);
           ContractField.SendKeys(Keys.Enter);
       });


        public void SelectNoRecordFromContractTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From contract Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From contract Table Records");
            });

        }

         public void EnterClaimData(string Cost, string ClaimedAmount) =>
        AllureLogger.LogStep($"I enter following claim logs = '{Cost}', Details = '{ClaimedAmount}','", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            By CostFilterLocator = By.CssSelector("#m59c3fca9-tb");
            By ClaimedAmountFilterLocator = By.CssSelector("#mc0caad13-tb");

            IWebElement CostFilter = wait.Until(SeleniumWaits.ElementToBeClickable(CostFilterLocator));
            CostFilter.Click();
            CostFilter.Clear();
            CostFilter.SendKeys(Cost);
                        
            IWebElement ClaimedAmountFilter = wait.Until(SeleniumWaits.ElementToBeClickable(ClaimedAmountFilterLocator));
            ClaimedAmountFilter.Click();
            ClaimedAmountFilter.Clear();
            ClaimedAmountFilter.SendKeys(ClaimedAmount);
                       
        });

        public void SelectApproveClaim() =>
        AllureLogger.LogStep("I select Approve claim", () =>
            SafeActions.Click(driver, By.CssSelector("#mb64e0e96-rb"),
                        "I select Approve claim"));


        public void ClickDialogOKButton() =>
        AllureLogger.LogStep("I select Approve claim", () =>
            SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"),
                        "I select Approve claim"));

        public void VerifyClaimsStatus() =>
       AllureLogger.LogStep("I verify SUBMITTED Status", () =>
       {


           try
           {
               // Wait 10 seconds for the page or element to load
               Task.Delay(10000).Wait();

               // Find the Status field element by CSS selector (update selector if needed)
               var statusField = driver.FindElement(By.CssSelector("#me5309acb-tb"));

               // Get the 'value' attribute of the element
               string statusValue = statusField.GetAttribute("value");

               // Validate the value is "APPR"
               if (string.IsNullOrEmpty(statusValue))
               {
                   throw new Exception("Status field is empty or null.");
               }

               if (statusValue != "SUBMITTED")
               {
                   throw new Exception($"Expected status value SUBMITTED but found '{statusValue}'.");
               }

               Console.WriteLine("Success: Status field value is SUBMITTED.");
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


        public void TakeScreenshotOfRaisingAWarrantyClaim() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-TR-DA-002", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-TR-DA-002.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-DA-002_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });




        // Sending assets away on a Despatch record POM Steps 



         public void SelectNewMXRDESPATCH() =>
         AllureLogger.LogStep("I select new MXRDESPATCH", () =>
             SafeActions.Click(driver, By.Id("QuickInsert_MXRDESPATCH"),
                         "I select new MXRDESPATCH"));

         public void EnterDespatchDetails(string DespatchDescription) =>
        AllureLogger.LogStep($"I enter Despatch Details '{DespatchDescription}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By DespatchDescriptionLocator = By.CssSelector("#mb8a01cd-tb2");
            IWebElement DespatchDescriptionField = wait.Until(SeleniumWaits.ElementToBeClickable(DespatchDescriptionLocator));

            DespatchDescriptionField.Click();
            DespatchDescriptionField.Clear();
            DespatchDescriptionField.SendKeys(DespatchDescription);
           
        });

        public void DetailMenuOfDespatchLocation() =>
        AllureLogger.LogStep("Detail Menu of location", () =>
            SafeActions.Click(driver, By.CssSelector("#m14a68428-img"),
                        "Detail Menu of location"));

        public void SelectValueOfDespatchLocation() =>
        AllureLogger.LogStep("Detail Menu of location", () =>
            SafeActions.Click(driver, By.Id("LOCATIONS_locations0_a_tnode"),
                        "Detail Menu of location"));

        public void FilterTableDespatchLocation(string location) =>
        AllureLogger.LogStep($"I filter table Despatch location '{location}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By locationLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");
            IWebElement locationField = wait.Until(SeleniumWaits.ElementToBeClickable(locationLocator));

            locationField.Click();
            locationField.Clear();
            locationField.SendKeys(location);
            locationField.SendKeys(Keys.Enter);
            Task.Delay(3000).Wait();
        });

        public void SelectNoRecordFromDespatchLocationTableRecord(int recordNumber)
         {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Despatch location Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Despatch location Table Records");
            });

         }


        public void EnterVendorData(string VendorItems) =>
        AllureLogger.LogStep($"I enter Vendor data '{VendorItems}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By VendorItemsLocator = By.CssSelector("#mdef29216-tb");
            IWebElement VendorItemsField = wait.Until(SeleniumWaits.ElementToBeClickable(VendorItemsLocator));

            VendorItemsField.Click();
            VendorItemsField.Clear();
            VendorItemsField.SendKeys(VendorItems);

        });

        public void DetailMenuOfVendorLocation() =>
       AllureLogger.LogStep("Detail Menu of Vendor location", () =>
           SafeActions.Click(driver, By.CssSelector("#md88aaaa7-img"),
                       "Detail Menu of Vendor location"));

        public void SelectValueOfVendorLocation() =>
       AllureLogger.LogStep("Detail Menu of Vendor location", () =>
           SafeActions.Click(driver, By.Id("NORMAL_normal0_a_tnode"),
                       "Detail Menu of Vendor location"));

          public void FilterTableVendorLocation(string Vendorlocation) =>
        AllureLogger.LogStep($"I filter table Vendor location '{Vendorlocation}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By VendorlocationLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");
            IWebElement VendorlocationField = wait.Until(SeleniumWaits.ElementToBeClickable(VendorlocationLocator));

            VendorlocationField.Click();
            VendorlocationField.Clear();
            VendorlocationField.SendKeys(Vendorlocation);
            VendorlocationField.SendKeys(Keys.Enter);
            Task.Delay(3000).Wait();
        });


        public void SelectNoRecordFromVendorLocationTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Vendor location Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Vendor location Table Records");
            });

        }

         public void DetailMenuOfReturnLocation() =>
       AllureLogger.LogStep("Detail Menu of Return location", () =>
           SafeActions.Click(driver, By.CssSelector("#m68d927e5-img"),
                       "Detail Menu of Return location"));

         public void SelectValueOfReturnLocation() =>
       AllureLogger.LogStep("Detail Menu of Return location", () =>
           SafeActions.Click(driver, By.Id("NORMAL_normal0_a_tnode"),
                       "Detail Menu of Return location"));

        public void FilterTableReturnLocation(string Returnlocation) =>
       AllureLogger.LogStep($"I filter table Return location '{Returnlocation}'", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           By ReturnlocationLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");
           IWebElement ReturnlocationField = wait.Until(SeleniumWaits.ElementToBeClickable(ReturnlocationLocator));

           ReturnlocationField.Click();
           ReturnlocationField.Clear();
           ReturnlocationField.SendKeys(Returnlocation);
           ReturnlocationField.SendKeys(Keys.Enter);
           Task.Delay(3000).Wait();
       });

          public void SelectNoRecordFromReturnLocationTableRecord(int recordNumber)
          {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Return location Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Return location Table Records");
            });

          }



        public void GoToDespatchLinesTab() =>
         AllureLogger.LogStep("I go to Despatch Lines tab", () =>
             SafeActions.Click(driver, By.Id("m549ef671-tab_anchor"),
                         "I go to Despatch Lines tab"));

         public void SelectNewRowButton() =>
         AllureLogger.LogStep("I select new row button", () =>
             SafeActions.Click(driver, By.CssSelector("#m5ea641a9_bg_button_addrow-pb"),
                         "I select new row button"));

         public void DetailMenuForAsset() =>
         AllureLogger.LogStep("Detail Menu For Asset", () =>
             SafeActions.Click(driver, By.CssSelector("#m536b20dc-img"),
                         "Detail Menu For Asset"));

        
        public void SelectValueForAsset() =>
         AllureLogger.LogStep("I Select Value For Asset", () =>
             SafeActions.Click(driver, By.Id("ASSETMAIN_assetmain0_a_tnode"),
                         "I Select Value For Asset"));


        public void SelectChangeStatus() =>
         AllureLogger.LogStep("I select change status", () =>
             SafeActions.Click(driver, By.Id("toolactions_STATUS-tbb_image"),
                         "I select change status"));

         public void StatusDropdwonMenuOption() =>
         AllureLogger.LogStep("Status Dropdwon Menu", () =>
             SafeActions.Click(driver, By.CssSelector("#mc927149a-img"),
                         "Status Dropdwon Menu"));

        public void SetRadioFieldToDespatched() =>
         AllureLogger.LogStep("I set (Radio) field to Despatched", () =>
             SafeActions.Click(driver, By.Id("menu0_DESPATCHED_OPTION_a_tnode"),
                         "I set (Radio) field to Despatched"));

        public void ClickTheOKDialogButton() =>
         AllureLogger.LogStep("I click the OK dialog button", () =>
             SafeActions.Click(driver, By.CssSelector("#m60bd6d91-pb"),
                         "I click the OK dialog button"));

          public void TakeScreenshotOfDESPATCHEDStatus() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-TR-DA-003SC01", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-TR-DA-003SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-DA-003SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });


        public void RunReport() =>
         AllureLogger.LogStep("I Run Report", () =>
             SafeActions.Click(driver, By.Id("menu0_RUNREPORTS_OPTION_a_tnode"),
                         "I Run Report"));

         public void FilterReport(string Report) =>
        AllureLogger.LogStep($"I filter table Report with '{Report}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By ReportLocator = By.CssSelector("#m139b05b7_tfrow_\\[C\\:0\\]_txt-tb");
            IWebElement ReportField = wait.Until(SeleniumWaits.ElementToBeClickable(ReportLocator));

            ReportField.Click();
            ReportField.Clear();
            ReportField.SendKeys(Report);
            ReportField.SendKeys(Keys.Enter);
            Task.Delay(3000).Wait();
        });

         public void SelectNoRecordFromDespatchReportTableRecord(int recordNumber)
         {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Return location Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m139b05b7_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Return location Table Records");
            });

         }

        public void SubmitDespatchReport() =>
         AllureLogger.LogStep("I Submit Despatch Report", () =>
             SafeActions.Click(driver, By.CssSelector("#m1a4cb878-pb"),
                         "I Submit Despatch Report"));


           public void TakeScreenshotOfSendingAssetsAwayOnADespatchRecordTest() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-TR-DA-003SC02", () =>
       {
            try
            {
               string screenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-TR-DA-003SC02.png";
               string failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-DA-003SC02_Failure.png";

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

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-DA-003SC02_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);
 
                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
       });



        // Returning assets on a Despatch record POM Steps

        public void OpenApplicationDespatchesMXRFromFavMenu() =>
         AllureLogger.LogStep("I open application Despatches (MXR) from Fav Menu", () =>
             SafeActions.Click(driver, By.Id("FavoriteApp_MXRDESPATCH"),
                         "I open application Despatches (MXR) from Fav Menu"));

         public void FilterTableDespatches(string Despatches, string Status) =>
       AllureLogger.LogStep($"I filter table Despatches with '{Despatches}', Status: '{Status}'", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
           By StatusLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:16\\]_txt-tb");
           By DespatchesLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:9\\]_txt-tb");

           IWebElement StatusFilter = wait.Until(SeleniumWaits.ElementToBeClickable(StatusLocator));
           StatusFilter.Click();
           StatusFilter.Clear();
           StatusFilter.SendKeys(Status);


           
           IWebElement DespatchesField = wait.Until(SeleniumWaits.ElementToBeClickable(DespatchesLocator));

           DespatchesField.Click();
           DespatchesField.Clear();
           DespatchesField.SendKeys(Despatches);
           DespatchesField.SendKeys(Keys.Enter);
       });


        public void SelectNoRecordFromDespatchesTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Despatches Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Despatches Table Records");
            });

        }

          public void ReturnDespatchedAssets() =>
         AllureLogger.LogStep("I Select Return Despatched Assets", () =>
             SafeActions.Click(driver, By.Id("menu0_MXRRETASSETS_OPTION_a_tnode"),
                         "I Select Return Despatched Assets"));


          public void SetRadioFieldReturnAssetTrue() =>
         AllureLogger.LogStep("I set (Radio) field Return Asset True", () =>
             SafeActions.Click(driver, By.CssSelector("#m92043a4a_tdrow_\\[C\\:7\\]_checkbox-cb\\[R\\:0\\]_img"),
                         "I set (Radio) field Return Asset True"));


          public void SelectTheOKDialogButton() =>
         AllureLogger.LogStep("I select the OK dialog button", () =>
             SafeActions.Click(driver, By.CssSelector("#m29a0c237-pb"),
                         "I select the OK dialog button"));


          public void SelectOkDialogSystemMessage() =>
         AllureLogger.LogStep("I select Ok dialog system message", () =>
             SafeActions.Click(driver, By.CssSelector("#m88dbf6ce-pb"),
                         "I select Ok dialog system message"));


          public void VerifyStatusChangedToRETURNED() =>
        AllureLogger.LogStep("I verify RETURNED Status", () =>
        {


            try
            {
                // Wait 10 seconds for the page or element to load
                Task.Delay(10000).Wait();

                // Find the Status field element by CSS selector (update selector if needed)
                var statusField = driver.FindElement(By.CssSelector("#ma895b15-tb")); 

                // Get the 'value' attribute of the element
                string statusValue = statusField.GetAttribute("value");

                // Validate the value is "RETURNED"
                if (string.IsNullOrEmpty(statusValue))
                {
                    throw new Exception("Status field is empty or null.");
                }

                if (statusValue != "RETURNED")
                {
                    throw new Exception($"Expected status value RETURNED but found '{statusValue}'.");
                }

                Console.WriteLine("Success: Status field value is RETURNED.");
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


          public void TakeScreenshotOfReturningAssetsOnADespatchRecordTest() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-TR-DA-004", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-TR-DA-004.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-DA-004_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });






    }
}