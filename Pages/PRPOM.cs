using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;

namespace GTR_AUTOMATED.Pages
{
    
    public sealed class PRPOM
    {

        private readonly IWebDriver driver;
        public PRPOM(IWebDriver drv) => driver = drv;


        public void CreateNewPurchaseRequisitionFromQuickInsertMenu() =>
          AllureLogger.LogStep("I select create New Purchase Requisition from quick insert menu", () =>
              SafeActions.Click(driver, By.CssSelector("#QuickInsert_PLUSTPR"),
                                "I select create New Purchase Requisition from quick insert menu"));



          public void RequisitionDescription(string Description) =>
         AllureLogger.LogStep($"I filter CM Work Order table with Description = '{Description}'", () =>
         {
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

             // Adjust column indices as per actual table structure:
             // Description = column 2 → C:2
             // Status = column 10 → C:10

             By DescriptionFilterLocator = By.CssSelector("#m8ee1358-tb2");
         
             IWebElement DescriptionFilter = wait.Until(SeleniumWaits.ElementToBeClickable(DescriptionFilterLocator));
             DescriptionFilter.Click();
             DescriptionFilter.Clear();
             DescriptionFilter.SendKeys(Description);
              

         });


          public void RequiredDate() =>
       AllureLogger.LogStep("I enter Required Date", () =>
       {    // Prepare date and time values
           string todayDate = DateTime.Today.ToString("dd-MM-yyyy");
           string RequiredDate = DateTime.Today.AddDays(0).ToString("dd-MM-yyyy");
           string currentTime = DateTime.Now.ToString("HH:mm:ss");

           // Set Start Date
           var RequiredDateLocator = By.CssSelector("#mcd12264a-tb");
           var RequiredDateBox = driver.FindElement(RequiredDateLocator);
           RequiredDateBox.Clear();
           RequiredDateBox.SendKeys(RequiredDate);
           Task.Delay(1000).Wait();
                                
       });


        public void DetailMenuOfCompanyField() =>
          AllureLogger.LogStep("Detail Menu Of Company Field", () =>
              SafeActions.Click(driver,
                  By.CssSelector("#m6d6a1009-img"),
                  "Detail Menu Of Company Field"));


        public void SelectValueOptionofCompany() =>
            AllureLogger.LogStep("Select Value Option of Company", () =>
                SafeActions.Click(driver, By.Id("NORMAL_normal0_a_tnode"),
                                  "Select Value Option of Company"));

        public void FilterTableCompanyField(string Description) =>
        AllureLogger.LogStep($"I filter CM Work Order table with Description = '{Description}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Adjust column indices as per actual table structure:
            // Description = column 2 → C:2
            // Status = column 10 → C:10

            By DescriptionFilterLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:2\\]_txt-tb");

            IWebElement DescriptionFilter = wait.Until(SeleniumWaits.ElementToBeClickable(DescriptionFilterLocator));
            DescriptionFilter.Click();
            DescriptionFilter.Clear();
            DescriptionFilter.SendKeys(Description);
            DescriptionFilter.SendKeys(Keys.Enter);

        });

        public void SelectNoRecordFromCompanyTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Company Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Company Table Records");
            });

        }

        public void SelectValueLookupOfContactField() =>
         AllureLogger.LogStep("I select value lookup of Contact field", () =>
             SafeActions.Click(driver,
                 By.CssSelector("#m70853b6f-img"),
                 "I select value lookup of Contact field"));

          public void SelectNoRecordFromContactTableRecord(int recordNumber)
          {
              AllureLogger.LogStep($"I Select No {recordNumber} Record From Contact Table Records", () =>
              {
                  // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                  int zeroBasedIndex = recordNumber - 1;

                  // Build dynamic Id selector by replacing the row index [R:x]
                  string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                  SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Contact Table Records");
              });

          }

             public void GoToPRLinesTab() =>
           AllureLogger.LogStep("I go to PR Lines tab", () =>
               SafeActions.Click(driver, By.Id("mbecdd814-tab_anchor"),
                                 "I go to PR Lines tab"));

            public void SelectVendorItemsButton() =>
          AllureLogger.LogStep("I select Vendor Items button", () =>
              SafeActions.Click(driver, By.Id("mf66f4c27_bg_button_vendorlist-pb"),
                                "I select Vendor Items button"));





           public void FilterTableVendorItems(string VendorItems) =>
        AllureLogger.LogStep($"I filter table Vendor Items with '{VendorItems}'", () =>
        {
             // Step 1: Click the filter icon first (update selector as needed)
              By filterIconLocator = By.CssSelector("#m358684e-lb2");
              WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
              IWebElement filterIcon = wait.Until(SeleniumWaits.ElementToBeClickable(filterIconLocator));
              filterIcon.Click();

              // Step 2: Locate the filter field and enter text
              By filterFieldLocator = By.CssSelector("#m358684e_tfrow_\\[C\\:1\\]_txt-tb");
              IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

             filterField.Click();   
             filterField.Clear();
             filterField.SendKeys(VendorItems);
             filterField.SendKeys(Keys.Enter);
        });

        public void SelectNoRecordFromVendorItemsTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Vendor Items Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m358684e_tdrow_[C:0]_tbselrow-ti[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                  $"I Select No {recordNumber} Record From Vendor Items Table Records");
            });

        }

        public void PressDialogOKButton() =>
       AllureLogger.LogStep("I press dialog OK button", () =>
           SafeActions.Click(driver,
               By.CssSelector("#mcfefec72-pb"),
               "I press dialog OK button"));

        public void DetailMenuOfStoreroomField() =>
        AllureLogger.LogStep("Detail Menu Of Storeroom Field", () =>
            SafeActions.Click(driver,
                By.CssSelector("#m70c74056-img"),
                "Detail Menu Of Storeroom Field"));


        public void SelectValueOptionofStoreroom() =>
            AllureLogger.LogStep("Select Value Option of Storeroom", () =>
                SafeActions.Click(driver, By.CssSelector("#NORMAL_normal0_a_tnode"),
                                  "Select Value Option of Storeroom"));

        public void FilterTableStoreroom(string Storeroom) =>
       AllureLogger.LogStep($"I filter table Storeroom with '{Storeroom}'", () =>
       {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

           filterField.Click();
           filterField.Clear();
           filterField.SendKeys(Storeroom);
           filterField.SendKeys(Keys.Enter);
       });


        public void SelectNoRecordFromStoreroomTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Storeroom Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                  $"I Select No {recordNumber} Record From Storeroom Table Records");
            });

        }

        public void SelectViewPRDetails() =>
         AllureLogger.LogStep("I select view PR details", () =>
             SafeActions.Click(driver, By.Id("mf66f4c27_tdrow_[C:0]_tgdet-ti[R:0]_img"),
                               "I select view PR details"));

        public void IEnterConversionFactor(string ConversionFactor) =>
        AllureLogger.LogStep($"I filter  table with Conversion Factor = '{ConversionFactor}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Adjust column indices as per actual table structure:
            // Description = column 2 → C:2
            // Status = column 10 → C:10

            By ConversionFactorFilterLocator = By.CssSelector("#mb7b0cc5a-tb");

            IWebElement ConversionFactorFilter = wait.Until(SeleniumWaits.ElementToBeClickable(ConversionFactorFilterLocator));
            ConversionFactorFilter.Click();
            ConversionFactorFilter.Clear();
            ConversionFactorFilter.SendKeys(ConversionFactor);


        });


        public void DetailMenuOfStoreroom() =>
        AllureLogger.LogStep("I select value Detail Menu OfS toreroom", () =>
            SafeActions.Click(driver, By.CssSelector("#mc7da38d5-img"),
                              "I select value Detail Menu OfS toreroom"));

        public void SelectValueOptiono() =>
       AllureLogger.LogStep("Select Value Option", () =>
           SafeActions.Click(driver, By.Id("NORMAL_normal0_a"),
                             "Select Value Option"));



        public void GoToTabShipToBillTo() =>
        AllureLogger.LogStep("I go to tab Ship To Bill To", () =>
            SafeActions.Click(driver, By.Id("m11b7f2a2-tab_anchor"),
                              "I go to tab Ship To Bill To"));


           public void VerifyTheShipToAddress() =>
       AllureLogger.LogStep("I Verify the Ship To address", () =>
       {
           try
           {
               // Wait 10 seconds for the page or elements to load
               Task.Delay(10000).Wait();

               // ----------- Ship-To Address Field Checks -----------

               // Replace these selectors with actual ones from your application
               var addressLine1 = driver.FindElement(By.CssSelector("#m9d38f759-tb"));
               var addressLine2 = driver.FindElement(By.CssSelector("#mea3fc7cf-tb"));
               var cityField = driver.FindElement(By.CssSelector("#m745b526c-tb"));
               var countryField = driver.FindElement(By.CssSelector("#m35c62fa-tb"));

               // Read values
               string line1 = addressLine1.GetAttribute("value")?.Trim();
               string line2 = addressLine2.GetAttribute("value")?.Trim();
               string city = cityField.GetAttribute("value")?.Trim();
               string country = countryField.GetAttribute("value")?.Trim();

               // Check if any field is null, empty, or whitespace
               if (string.IsNullOrWhiteSpace(line1))
                throw new Exception("Address Line 1 is empty or blank.");

                if (string.IsNullOrWhiteSpace(line2))
                throw new Exception("Address Line 2 is empty or blank.");

               if (string.IsNullOrWhiteSpace(city))
                throw new Exception("City field is empty or blank.");

               if (string.IsNullOrWhiteSpace(country))
                throw new Exception("Country field is empty or blank.");

               Console.WriteLine("Success: All address fields are filled.");
           }
               catch (NoSuchElementException ex)
               {
                    Console.WriteLine("Error: One or more address fields not found - " + ex.Message);
                     throw;
               }
               catch (Exception ex)
               {
                    Console.WriteLine("Error: " + ex.Message);
                    throw;
               }
       });


         public void VerifyTheBillToAddress() =>
       AllureLogger.LogStep("I Verify the Ship To address", () =>
       {
           try
           {
               // Wait 10 seconds for the page or elements to load
               Task.Delay(10000).Wait();

               // ----------- Ship-To Address Field Checks -----------

               // Replace these selectors with actual ones from your application
               var billingaddress = driver.FindElement(By.CssSelector("#m67718ba-tb2"));
               var addressLine1 = driver.FindElement(By.CssSelector("#m9f7e4900-tb"));
               var addressLine2 = driver.FindElement(By.CssSelector("#me8797996-tb"));
               var cityField = driver.FindElement(By.CssSelector("#m761dec35-tb"));
               var countryField = driver.FindElement(By.CssSelector("#m11adca3-tb"));

               // Read values
               string bill = billingaddress.GetAttribute("value")?.Trim();
               string line1 = addressLine1.GetAttribute("value")?.Trim();
               string line2 = addressLine2.GetAttribute("value")?.Trim();
               string city = cityField.GetAttribute("value")?.Trim();
               string country = countryField.GetAttribute("value")?.Trim();

               // Check if any field is null, empty, or whitespace
               if (string.IsNullOrWhiteSpace(bill))
                   throw new Exception("Address Line 1 is empty or blank.");
               if (string.IsNullOrWhiteSpace(line1))
                throw new Exception("Address Line 1 is empty or blank.");

                if (string.IsNullOrWhiteSpace(line2))
                throw new Exception("Address Line 2 is empty or blank.");

               if (string.IsNullOrWhiteSpace(city))
                throw new Exception("City field is empty or blank.");

               if (string.IsNullOrWhiteSpace(country))
                throw new Exception("Country field is empty or blank.");

               Console.WriteLine("Success: All address fields are filled.");
           }
               catch (NoSuchElementException ex)
               {
                    Console.WriteLine("Error: One or more address fields not found - " + ex.Message);
                     throw;
               }
               catch (Exception ex)
               {
                    Console.WriteLine("Error: " + ex.Message);
                    throw;
               }
       });


        public void SetRadioFieldToSubmitPurchaseRequest() =>
        AllureLogger.LogStep("I set (Radio) field to Submit Purchase Request", () =>
            SafeActions.Click(driver, By.CssSelector("#mb64e0e96-rb"),
                              "I set (Radio) field to Submit Purchase Request"));


        public void SelectOKDialogButton() =>
        AllureLogger.LogStep("I select OK dialog button", () =>
            SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"),
                              "I select OK dialog button"));


        public void IClose() =>
        AllureLogger.LogStep("I close", () =>
            SafeActions.Click(driver, By.CssSelector("#m15f1c9f0-pb"),
                              "I close"));


        public void TakeScreenshotOfNewConsumablePurchaseUnderContractPriceTest() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-TR-PR-001", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-TR-PR-001.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-PR-001_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });


        //New Consumable Purchase Under Contract Price POM Steps

        public void OpenApplicationReceivingTrFromFavMenu() =>
         AllureLogger.LogStep("I open application Receiving (Tr) from Fav Menu", () =>
             SafeActions.Click(driver, By.Id("FavoriteApp_PLUSTREC"),
                               "I open application Receiving (Tr) from Fav Menu"));

        public void FilterReceivingTr(string description, string POStatus, string Receipts) =>
       AllureLogger.LogStep($"I filter Receiving table with Description = '{description}', PO Status = '{POStatus}', and Receipts = '{Receipts}'", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

           // Adjust column indexes if needed
           By descriptionFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");
           By POStatusFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:3\\]_txt-tb");
           By ReceiptsFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:4\\]_txt-tb");

           // Description filter
           IWebElement descriptionFilter = wait.Until(SeleniumWaits.ElementToBeClickable(descriptionFilterLocator));
           descriptionFilter.Click();
           descriptionFilter.Clear();
           descriptionFilter.SendKeys(description);

           // Status filter
           IWebElement statusFilter = wait.Until(SeleniumWaits.ElementToBeClickable(POStatusFilterLocator));
           statusFilter.Click();
           statusFilter.Clear();
           statusFilter.SendKeys(POStatus);

           // Work Type filter
           IWebElement ReceiptsTypeFilter = wait.Until(SeleniumWaits.ElementToBeClickable(ReceiptsFilterLocator));
           ReceiptsTypeFilter.Click();
           ReceiptsTypeFilter.Clear();
           ReceiptsTypeFilter.SendKeys(Receipts);

           // Trigger filter (using Enter on the last field)
           ReceiptsTypeFilter.SendKeys(Keys.Enter);
       });

        public void SelectNoRecordFromPOItemTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From PO Item Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                  $"I Select No {recordNumber} Record From PO Item Table Records");
            });

        }


        public void SelectOrderedItemsButton() =>
         AllureLogger.LogStep("I select Ordered Items button", () =>
             SafeActions.Click(driver, By.Id("m52852ffc_bg_button_selorditem-pb"),
                               "I select Ordered Items button"));

            public void EnterDeliveryNote(string DeliveryNote, string RemarksNote) =>
        AllureLogger.LogStep($"I enter  delivery note Delivery = '{DeliveryNote}', Remarks Note = '{RemarksNote}','", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Adjust column indices as per actual table structure:
            // Description = column 2 → C:2
            // Status = column 10 → C:10

            By DeliveryNoteFilterLocator = By.CssSelector("#m68e69587-tb");
            By RemarksNoteFilterLocator = By.CssSelector("#m77c7fae-tb");

            IWebElement DeliveryNoteFilter = wait.Until(SeleniumWaits.ElementToBeClickable(DeliveryNoteFilterLocator));
            DeliveryNoteFilter.Click();
            DeliveryNoteFilter.SendKeys(DeliveryNote);
                       
            IWebElement RemarksNoteFilter = wait.Until(SeleniumWaits.ElementToBeClickable(RemarksNoteFilterLocator));
            RemarksNoteFilter.Click();
            RemarksNoteFilter.Clear();
            RemarksNoteFilter.SendKeys(RemarksNote);
                    
        });

        public void SelectNoRecordFromPOItemToReceiveTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From PO Item Table Records", () =>
            {
                // Convert to zero-based index
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic ID using the actual format
                string selector = $"mf9bb799f_tdrow_[C:0]_tbselrow-ti[R:{zeroBasedIndex}]_img";

                // Click the checkbox/icon for the specified record
                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From PO Item Table Records");
            });
        }

        public void SelectNoPOItemToReceiveTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From PO Item Table Records", () =>
            {
                // Convert to zero-based index
                int zeroBasedIndex = recordNumber - 1;

                // Use the provided format with dynamic row index
                string selector = $"mf9bb799f_tdrow_[C:0]_tbselrow-ti[R:{zeroBasedIndex}]_img";

                // Perform the click action
                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From PO Item Table Records");
            });
        }




        public void PressOk() =>
         AllureLogger.LogStep("I Press Ok", () =>
             SafeActions.Click(driver, By.CssSelector("#mab71af75-pb"),
                               "I Press Ok"));

        public void ViewItemDetails() =>
        AllureLogger.LogStep("I view Item details", () =>
            SafeActions.Click(driver, By.Id("m52852ffc_tdrow_[C:0]_tgdet-ti[R:0]_img"),
                              "I view Item details"));

        public void TakeScreenshotOfCompletedStatus() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-TR-PR-002", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-TR-PR-002.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-PR-002_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });


        public void SelectAction() =>
       AllureLogger.LogStep("I Select Action", () =>
           SafeActions.Click(driver, By.CssSelector("#toolbar2_tbs_1_tbcb_0_action-img"),
                             "I Select Action"));

        public void RunReport() =>
       AllureLogger.LogStep("I Run Report", () =>
           SafeActions.Click(driver, By.Id("menu0_RUNREPORTS_OPTION_a_tnode"),
                             "I Run Report"));


        public void FilterTableReport(string Report) =>
       AllureLogger.LogStep($"I filter table Report with = '{Report}'", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

           // Adjust column indices as per actual table structure:
           // Report = column 2 → C:2
           

           By ReportFilterLocator = By.CssSelector("#mc2d267e8_tfrow_\\[C\\:0\\]_txt-tb");

           IWebElement ReportFilter = wait.Until(SeleniumWaits.ElementToBeClickable(ReportFilterLocator));
           ReportFilter.Click();
           ReportFilter.Clear();
           ReportFilter.SendKeys(Report);
           ReportFilter.SendKeys(Keys.Enter);
           Task.Delay(5000).Wait();

       });

        public void SelectNoFromReportsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Report Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"mc2d267e8_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                  $"I Select No {recordNumber} Record From Report Table Records");
            });

        }


        public void SelectNoRecordFromReportTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Report Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m139b05b7_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                  $"I Select No {recordNumber} Record From Report Table Records");
            });

        }


          public void RadioFieldToSubmitReport() =>
        AllureLogger.LogStep("I set (Radio) field to submit report", () =>
            SafeActions.Click(driver, By.CssSelector("#m74e8dca8-pb"),
                            "I set (Radio) field to submit report"));


        public void IWaitForPageToLoad()
        {
            AllureLogger.LogStep("I wait for page to load", () =>
            {
                Task.Delay(80000).Wait();
                // Store the original window handle
                string originalWindow = driver.CurrentWindowHandle;

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                // Wait for a new window to appear
                wait.Until(driver => driver.WindowHandles.Count > 1);

                // Switch to the new window
                foreach (var handle in driver.WindowHandles)
                {
                    if (handle != originalWindow)
                    {
                        driver.SwitchTo().Window(handle);
                        break;
                    }
                }

                // Optional: Wait for the page title or URL to stabilize (can be added here if needed)
            });
        }


        

                public void TakeScreenshotOfReceivingNewConsumableMaterialTest() =>
         AllureLogger.LogStep("Capture Screenshot for GTR-TR-PR-002SC02", () =>
         {
                try
                {
                     string originalWindow = driver.CurrentWindowHandle;

                     // Wait for the report window to open
                     WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                     wait.Until(driver => driver.WindowHandles.Count > 1);

                     // Switch to the newly opened window
                    foreach (var handle in driver.WindowHandles)
                    {
                        if (handle != originalWindow)
                        {
                            driver.SwitchTo().Window(handle);
                            break;
                        }
                    }

                      // Take screenshot of the report page
                      var takescreenshot = new TakeScreenShotPOM(driver);
                      string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-TR-PR-002SC02.png";

                      takescreenshot.TakeScreenshot(driver, successPath);
                    }
                    catch (Exception ex)
                    {
                         Console.WriteLine($"Screenshot failed: {ex.Message}");

                         // Attempt fallback screenshot on failure
                        var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-PR-002SC02_Failure.png";
                        var takescreenshot = new TakeScreenShotPOM(driver);

                        takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                        throw new Exception("Test failed while taking screenshot.", ex);
                    }
         });


        // Receiving New Rotating Material POM Steps

          public void TakeScreenshotOfCompletedReceivingNewRotatingMaterial() =>
           AllureLogger.LogStep("Capture Screenshot for GTR-TR-PR-003SC01", () =>
           {
               try
               {
                   var takescreenshot = new TakeScreenShotPOM(driver);
                   string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-TR-PR-003SC01.png";

                   takescreenshot.TakeScreenshot(driver, successPath);
               }
               catch (Exception ex)
               {
                   Console.WriteLine($"Screenshot failed: {ex.Message}");

                   // Attempt fallback screenshot on failure
                   var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-PR-003SC01_Failure.png";
                   var takescreenshot = new TakeScreenShotPOM(driver);

                   takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                   // Optional: Rethrow if test should fail
                   throw new Exception("Test failed while taking screenshot.", ex);
               }
           });



          public void ISelectAction() =>
       AllureLogger.LogStep("I Select Action", () =>
           SafeActions.Click(driver, By.CssSelector("#toolbar2_tbs_1_tbcb_0_action-img"),
                             "I Select Action"));

        public void ReceiveRotatingItems() =>
       AllureLogger.LogStep("Receive Rotating Items", () =>
           SafeActions.Click(driver, By.Id("menu0_ROTASSET_OPTION_a_tnode"),
                             "Receive Rotating Items"));


        public void SelectAutoNumberButton() =>
      AllureLogger.LogStep("I select Auto number button", () =>
          SafeActions.Click(driver, By.Id("mbf8fe76f_bg_button_autoNumberAll-pb"),
                            "I select Auto number button"));


            public void IPressOK() =>
          AllureLogger.LogStep("I Press OK", () =>
          {
                SafeActions.Click(driver, By.CssSelector("#mb77ae077-pb"), "I Press OK");

               // Delay for 2 seconds (2000 milliseconds) after clicking
               Task.Delay(5000).Wait();
          });
  


        public void VerifyStatusCOMP()
        {
            AllureLogger.LogStep("Verify that at least one item completed today has status 'COMP'", () =>
            {
                try
                {
                    Task.Delay(10000).Wait(); 

                    string today = DateTime.Now.ToString("MM/dd/yyyy"); 
                    bool compFound = false;

                    for (int rowIndex = 0; rowIndex < 20; rowIndex++) 
                    {
                        try
                        {
                            
                            string itemDateSelector = $"m52852ffc_tdrow_[C:8]_txt-tb[R:{rowIndex}]";
                            var itemDateField = driver.FindElement(By.Id(itemDateSelector));
                            string itemDateValue = itemDateField.GetAttribute("value")?.Trim();

                            if (string.IsNullOrWhiteSpace(itemDateValue)) continue;

                            if (itemDateValue.Contains(today))
                            {
                                // Get status field (column 7)
                                string statusSelector = $"m52852ffc_tdrow_[C:7]_txt-tb[R:{rowIndex}]";
                                var statusField = driver.FindElement(By.Id(statusSelector));
                                string statusValue = statusField.GetAttribute("value")?.Trim();

                                if (string.IsNullOrEmpty(statusValue))
                                    throw new Exception($"Status is empty at row {rowIndex + 1}");

                                if (statusValue != "COMP")
                                    throw new Exception($"Expected status 'COMP' but found '{statusValue}' at row {rowIndex + 1}");

                                Console.WriteLine($"✅ Success: Row {rowIndex + 1} completed today with status 'COMP'");
                                compFound = true;
                                break;
                            }
                        }
                        catch (NoSuchElementException)
                        {
                            // Row doesn't exist – end loop
                            break;
                        }
                    }

                    if (!compFound)
                        throw new Exception("❌ No item found with today's date and status 'COMP'.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    throw;
                }
            });
        }




    }
}