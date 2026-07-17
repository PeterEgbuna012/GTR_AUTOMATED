using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;


namespace GTR_AUTOMATED.Pages
{
    
    public sealed class ItemMasterPOM
    {

        private readonly IWebDriver driver;
        public ItemMasterPOM(IWebDriver drv) => driver = drv;


        public void OpenApplicationItemMasterFromFavMenu() =>
        AllureLogger.LogStep("I open application Item Master from Fav Menu", () =>
            SafeActions.Click(driver, By.Id("FavoriteApp_ITEM"),
                        "I open application Item Master from Fav Menu"));

        public void FilterTableLocation(string ItemMaster) =>
       AllureLogger.LogStep($"I filter table Item Master with '{ItemMaster}'", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
           By ItemMasterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");
           IWebElement ItemMasterField = wait.Until(SeleniumWaits.ElementToBeClickable(ItemMasterLocator));

           ItemMasterField.Click();
           ItemMasterField.Clear();
           ItemMasterField.SendKeys(ItemMaster);
           ItemMasterField.SendKeys(Keys.Enter);
           Task.Delay(3000).Wait();
       });

        public void SelectValueLookupForRepairableItemField()
        {
            AllureLogger.LogStep("I open Select Value lookup for Repairable item field", () =>
            {
                SafeActions.Click(driver, By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:8\\]_txt-img"),
                                  "I open Select Value lookup for Repairable item field");
                                  Task.Delay(2000).Wait();
            });
        }


        public void SelectYFromTableRecord() =>
        AllureLogger.LogStep("I select Y from table record", () =>
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(30));
            By cellLocator = By.Id("lookup_page1_tdrow_[C:1]_ttxt-lb[R:1]");
            IWebElement element = driver.FindElement(cellLocator);
            element.Click();
            Task.Delay(3000).Wait();

        });

           public void PartNumberField() =>
        AllureLogger.LogStep("I click into the Part Number field and press Enter", () =>
        {
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
             By partNumberLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:2\\]_txt-tb");
             IWebElement partNumberField = wait.Until(
             SeleniumWaits.ElementToBeClickable(partNumberLocator));
             partNumberField.Click();
             partNumberField.SendKeys(Keys.Enter);
             Task.Delay(5000).Wait();
        });



        public void SelectNoRecordFromItemMasterTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Item Master Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Item Master Table Records");
            });
        }

          public void ReviewItemInformation() =>
         AllureLogger.LogStep("I review Item information", () =>
         {
             try
             {
               // Wait 10 seconds for the page or elements to load
               Task.Delay(10000).Wait();

               // ----------- Ship-To Address Field Checks -----------

               // Replace these selectors with actual ones from your application
               var ItemMasterDescription = driver.FindElement(By.CssSelector("#maa8ad01-tb2"));
               var ItemMasterCommodityGroup = driver.FindElement(By.CssSelector("#me4a6cc2d-tb2"));
               var ItemMasterPartNumber = driver.FindElement(By.CssSelector("#mcd507dae-tb"));
             
               // Read values
               string line1 = ItemMasterDescription.GetAttribute("value")?.Trim();
               string line2 = ItemMasterCommodityGroup.GetAttribute("value")?.Trim();
               string line3 = ItemMasterPartNumber.GetAttribute("value")?.Trim();
             

               // Check if any field is null, empty, or whitespace
               if (string.IsNullOrWhiteSpace(line1))
                throw new Exception("Item Master Description Line 1 is empty or blank.");

                if (string.IsNullOrWhiteSpace(line2))
                throw new Exception("Item Master Commodity Group Line 2 is empty or blank.");

               if (string.IsNullOrWhiteSpace(line3))
                throw new Exception("Item Master Part Number field is empty or blank.");
                

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

         public void GoToTabSpecifications() =>
        AllureLogger.LogStep("I go to tab Specifications", () =>
            SafeActions.Click(driver, By.Id("me3f1a9a-tab_anchor"),
                        "I go to tab Specifications"));

        public void SelectSpecificationsTableFilterOption() =>
        AllureLogger.LogStep("I select Specifications table filter option", () =>
            SafeActions.Click(driver, By.Id("m846a9adc-lb2"),
                        "I select Specifications table filter option"));

        public void FilterSpecificationsTableRecords(string Attribute) =>
         AllureLogger.LogStep($"I filter table Attribute with '{Attribute}'", () =>
         {
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
             By AttributeLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:1\\]_txt-tb");
             IWebElement AttributeField = wait.Until(SeleniumWaits.ElementToBeClickable(AttributeLocator));

             AttributeField.Click();
             AttributeField.Clear();
             AttributeField.SendKeys(Attribute);
             AttributeField.SendKeys(Keys.Enter);
         });

         public void SelectValueLookupForAttributeField() =>
        AllureLogger.LogStep("I open Select Value lookup for Attribute field", () =>
            SafeActions.Click(driver, By.CssSelector("#m846a9adc_tfrow_\\[C\\:1\\]_txt-img"),
                        "I open Select Value lookup for Attribute field"));


        public void SelectNoRecordFromAttributeTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select record No {recordNumber} from Attribute Table Records", () =>
            {
                int zeroBasedIndex = recordNumber - 1;

                string selector = $"lookup_page1_tdrow_[C:0]_tbselrow-ti[R:{zeroBasedIndex}]_img";

                SafeActions.Click(driver, By.Id(selector),
                    $"Clicked record No {recordNumber} from Attribute Table Records");
            });
        }



        public void PressOKButton() =>
       AllureLogger.LogStep("I Press OK button", () =>
           SafeActions.Click(driver, By.CssSelector("#meb82bc79-pb"),
                       "I Press OK button"));

        public void OpenApplicationInventoryFavMenu() =>
       AllureLogger.LogStep("I open application Inventory Fav Menu", () =>
           SafeActions.Click(driver, By.Id("FavoriteApp_INVENTOR"),
                       "I open application Inventory Fav Menu"));

        public void FilterTableInventor(string storeroom) =>
        AllureLogger.LogStep($"I filter Inventory = '{storeroom}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            By storeroomFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:3\\]_txt-tb");

            IWebElement storeroomFilter = wait.Until(SeleniumWaits.ElementToBeClickable(storeroomFilterLocator));
            storeroomFilter.Click();
            storeroomFilter.Clear();
            storeroomFilter.SendKeys(storeroom);

            // Press Enter on the last filter field to trigger filtering
            storeroomFilter.SendKeys(Keys.Enter);
        });


        public void SelectNoRecordFromInventoryTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Attribute Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Attribute Table Records");
            });
        }


         public void ViewDetailsButton() =>
       AllureLogger.LogStep("I View Details Button", () =>
           SafeActions.Click(driver, By.Id("ma1a38afd_tdrow_[C:0]_tgdet-ti[R:0]_img"),
                       "I View Details Button"));

        public void VerifyInventoryBalances() =>
       AllureLogger.LogStep("I verify Inventory Balance field is populated", () =>
       {
           try
           {
               WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

               // Wait until the balance field is visible
               var balanceField = wait.Until(SeleniumWaits.ElementIsVisible(
                By.CssSelector("#m33dae99c-tb")));

               // Get the value from the field
               string fieldValue = balanceField.GetAttribute("value")?.Trim();

               // Log the actual value found
               AllureLogger.LogInfo($"Inventory Balance field value: '{fieldValue}'");

               // Validate that it's not empty or null
               if (string.IsNullOrWhiteSpace(fieldValue))
               {
                   throw new Exception("Inventory Balance field is empty or null.");
               }

                 AllureLogger.LogInfo("Success: Inventory Balance field contains a valid value.");
               }
               catch (NoSuchElementException ex)
               {
                  throw new Exception("Inventory Balance field not found.", ex);
               }
               catch (Exception ex)
               {
                   AllureLogger.LogError("Inventory Balance verification failed.", ex);
                   throw;
               }
       });

         public void GoToReorderDetailsTab() =>
       AllureLogger.LogStep("I Press OK button", () =>
           SafeActions.Click(driver, By.Id("mf50f8cf5-tab_anchor"),
                       "I Press OK button"));


        public void VerifyPrimaryVendorDetails() =>
        AllureLogger.LogStep("I verify Primary Vendor details", () =>
        {
            try
            {
                // Wait 10 seconds for the page or elements to load
                Task.Delay(10000).Wait();

               
                var PrimaryVendorNumber = driver.FindElement(By.CssSelector("#m7051a054-tb"));
                var PrimaryVendorDescription = driver.FindElement(By.CssSelector("#m7051a054-tb2"));
                var PartNumber = driver.FindElement(By.CssSelector("#m9e5fc178-tb"));

                // Read values
                string line1 = PrimaryVendorNumber.GetAttribute("value")?.Trim();
                string line2 = PrimaryVendorDescription.GetAttribute("value")?.Trim();
                string line3 = PartNumber.GetAttribute("value")?.Trim();


                // Check if any field is null, empty, or whitespace
                if (string.IsNullOrWhiteSpace(line1))
                    throw new Exception("Item Master Description Line 1 is empty or blank.");

                if (string.IsNullOrWhiteSpace(line2))
                    throw new Exception("Item Master Commodity Group Line 2 is empty or blank.");

                if (string.IsNullOrWhiteSpace(line3))
                    throw new Exception("Item Master Part Number field is empty or blank.");


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

          public void TakeScreenshotOfNavigateInTheInventoryAndItemMasterApplicationsTest() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-TR-IM-001", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-TR-IM-001.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-IM-001_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });




        // Issue Rotating Assets to a Work Order POM Steps



           public void OpenApplicationInventoryUsageFromFavMenu() =>
         AllureLogger.LogStep("I open application Inventory Usage from Fav Menu", () =>
             SafeActions.Click(driver, By.Id("FavoriteApp_INVUSAGE"),
                       "I open application Inventory Usage from Fav Menu"));


            public void SelectCreateNewInventoryUsage() =>
         AllureLogger.LogStep("I select create New Inventory usage", () =>
           SafeActions.Click(driver, By.Id("toolactions_INSERT-tbb_anchor"),
                       "I select create New Inventory usage"));


          public void EnterAssetDescription(string AssetDescription) =>
         AllureLogger.LogStep($"I enter asset description '{AssetDescription}'", () =>
         {
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
             By AssetDescriptionLocator = By.CssSelector("#mb50065c1-tb2");
             IWebElement AssetDescriptionField = wait.Until(SeleniumWaits.ElementToBeClickable(AssetDescriptionLocator));

             AssetDescriptionField.Click();
             AssetDescriptionField.Clear();
             AssetDescriptionField.SendKeys(AssetDescription);
          
         });
         
           public void DetailMenuForStoreroom() =>
         AllureLogger.LogStep("I Select Detail Menu for Storeroom", () =>
           SafeActions.Click(driver, By.CssSelector("#m2c09347b-img"),
                       "I Select Detail Menu for Storeroom"));

           public void SelectValueForStoreroom() =>
        AllureLogger.LogStep("I Select Value for Storeroom", () =>
           SafeActions.Click(driver, By.Id("NORMAL_normal0_a_tnode"),
                       "I Select Value for Storeroom"));

          public void SelectNewRowButtonUnderTheUsageLines() =>
        AllureLogger.LogStep("I select New Row button under the Usage Lines", () =>
          SafeActions.Click(driver, By.CssSelector("#m6ea76bb8_bg_button_addrow-pb"),
                      "I select New Row button under the Usage Lines"));

          public void DropdownMenuOption() =>
        AllureLogger.LogStep("I Select Drop Down Menu Option", () =>
          SafeActions.Click(driver, By.CssSelector("#m7b79b971-img"),
                      "I Select Drop Down Menu Option"));

          public void SetUsageTypeFieldToISSUE() =>
        AllureLogger.LogStep("I set Usage Type field to ISSUE", () =>
          SafeActions.Click(driver, By.Id("menu0_ISSUE_OPTION_a_tnode"),
                      "I set Usage Type field to ISSUE"));


          public void DetailMenuForItem() =>
        AllureLogger.LogStep("I Select Detail Menu for Item", () =>
          SafeActions.Click(driver, By.CssSelector("#me916fd86-img"),
                      "I Select Detail Menu for Item"));

          public void SelectValueForItem() =>
        AllureLogger.LogStep("I Select Value for Item", () =>
          SafeActions.Click(driver, By.Id("ITEM_item0_a_tnode"),
                      "I Select Value for Item"));


         public void SelectDetailMenuOfWorkOrderField() =>
        AllureLogger.LogStep("I Select Detail Menu for Work Order field", () =>
          SafeActions.Click(driver, By.CssSelector("#m1a5bc3ea-img"),
                      "I Select Detail Menu for Work Order field"));

         public void SelectValueOptionOfWorkOrderField() =>
        AllureLogger.LogStep("Select Value Option Of Work Order field", () =>
          SafeActions.Click(driver, By.Id("WORKORDER_workorder1_a_tnode"),
                      "Select Value Option Of Work Order field"));

          public void FilterWorkOrderTable(string WorkOrderDescription) =>
        AllureLogger.LogStep($"I filter work Order table '{WorkOrderDescription}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            By WorkOrderDescriptionfilter = By.CssSelector("#lookup_page1_tfrow_\\[C\\:1\\]_txt-tb");
            IWebElement WorkOrderDescriptionField = wait.Until(SeleniumWaits.ElementToBeClickable(WorkOrderDescriptionfilter));
            WorkOrderDescriptionField.Click();
            WorkOrderDescriptionField.Clear();
            WorkOrderDescriptionField.SendKeys(WorkOrderDescription);
            WorkOrderDescriptionField.SendKeys(Keys.Enter);

        });

        
        public void WaitForWorkOrderRecords()
        {
            AllureLogger.LogStep("I wait for Work order records", () =>
            {
                Task.Delay(60000).Wait();

            });
        }

        public void SelectNoFromWorkOrderTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From work Order Table Records", () =>
            {
                
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                  $"I Select No {recordNumber} Record From work Order Table Records");
            });

        }


        public void SelectChangeStatus() =>
        AllureLogger.LogStep("I Select Change status", () =>
            SafeActions.Click(driver, By.Id("toolactions_STATUS-tbb_anchor"),
                      "I Select Change status"));

        public void IChangeStatus() =>
        AllureLogger.LogStep("I Change status", () =>
            SafeActions.Click(driver, By.Id("md86fe08f_ns_menu_STATUS_OPTION_a_tnode"),
                      "I Change status"));

        public void DropdownMenuOptionOfNewStatusField() =>
        AllureLogger.LogStep("I Select dropdown menu option of New Status", () =>
           SafeActions.Click(driver, By.CssSelector("#m7443943f-img"),
                      "I Select dropdown menu option of New Status"));

         public void SelectComplete() =>
        AllureLogger.LogStep("I Select Complete", () =>
           SafeActions.Click(driver, By.Id("menu0_COMPLETE_OPTION_a_tnode"),
                      "I Select Complete"));

         public void SetRadioFieldToUseTheDefaultStageBinForEachInventoryItem() =>
        AllureLogger.LogStep("I set (Radio) field to Use the default stage bin for each inventory item", () =>
           SafeActions.Click(driver, By.CssSelector("#md71e6c37-rb"),
                      "I set (Radio) field to Use the default stage bin for each inventory item"));

         public void PressTheDialogButtonOK() =>
        AllureLogger.LogStep("I press the dialog button OK", () =>
           SafeActions.Click(driver, By.CssSelector("#m23260e47-pb"),
                      "I press the dialog button OK"));

         public void SelectNewRowButtonUnderSelectRotatingAssetsSection() =>
        AllureLogger.LogStep("I Select New Row button under Select Rotating Assets Section", () =>
           SafeActions.Click(driver, By.CssSelector("#mc6de0b96_bg_button_addrow-pb"),
                      "I Select New Row button under Select Rotating Assets Section"));

         public void OpenSelectValueLookupForAssetField() =>
        AllureLogger.LogStep("I open Select Value lookup for Asset field", () =>
           SafeActions.Click(driver, By.CssSelector("#mc6de0b96_tdrow_\\[C\\:3\\]_txt-img\\[R\\:0\\]"),
                      "I open Select Value lookup for Asset field"));


        public void SelectNoRecordFromRotatingAssetTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Rotating Asset Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                  $"I Select No {recordNumber} Record From Rotating Asset Table Records");
            });

        }

         public void VerifyAssetSerialNumber() =>
       AllureLogger.LogStep("I verify Asset serial number", () =>
       {
           try
           {
               WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

               // Wait until the balance field is visible
               var balanceField = wait.Until(SeleniumWaits.ElementIsVisible(
                By.CssSelector("#mc6de0b96_tdrow_\\[C\\:5\\]_txt-tb\\[R\\:0\\]")));

               // Get the value from the field
               string fieldValue = balanceField.GetAttribute("value")?.Trim();

               // Log the actual value found
               AllureLogger.LogInfo($"Asset serial number field value: '{fieldValue}'");

               // Validate that it's not empty or null
               if (string.IsNullOrWhiteSpace(fieldValue))
               {
                   throw new Exception("Asset serial number field is empty or null.");
               }

                 AllureLogger.LogInfo("Success: Asset serial number field contains a valid value.");
               }
               catch (NoSuchElementException ex)
               {
                  throw new Exception("Asset serial number field not found.", ex);
               }
               catch (Exception ex)
               {
                   AllureLogger.LogError("Asset serial number verification failed.", ex);
                   throw;
               }
       });

        public void RotatingAssetsStatusFieldHasValueCOMPLETE() =>
        AllureLogger.LogStep("Rotating Assets Status field has value COMPLETE", () =>
        {

            try
            {
                // Wait 10 seconds for the page or element to load
                Task.Delay(20000).Wait();

                // Find the Status field element by CSS selector (update selector if needed)
                var statusField = driver.FindElement(By.CssSelector("#mb684b1af-tb"));

                // Get the 'value' attribute of the element
                string statusValue = statusField.GetAttribute("value");

                // Validate the value is "COMPLETE"
                if (string.IsNullOrEmpty(statusValue))
                {
                    throw new Exception("Status field is empty or null.");
                }

                if (statusValue != "COMPLETE")
                {
                    throw new Exception($"Expected status value COMPLETE but found '{statusValue}'.");
                }

                Console.WriteLine("Success: Status field value is COMPLETE.");
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


        public void ClickTheDialogButtonOK() =>
        AllureLogger.LogStep("I click the dialog button OK", () =>
           SafeActions.Click(driver, By.CssSelector("#m54b49a22-pb"),
                      "I click the dialog button OK"));

        public void OpenGoToMenu() =>
         AllureLogger.LogStep("Open [Go To] menu", () =>
             SafeActions.Click(driver, By.Id("titlebar-tb_gotoButton"),
                               "Go To button"));

        public void AssetMenuButton() =>
        AllureLogger.LogStep("Open Assets Menu", () =>
           SafeActions.Click(driver, By.Id("menu0_ASSET_MODULE_a_tnode"),
                      "Open Assets Menu"));

        public void AssetApplication() =>
        AllureLogger.LogStep("Launch Assets Application", () =>
           SafeActions.Click(driver, By.Id("menu0_ASSET_MODULE_sub_changeapp_PLUSTASSET_a_tnode"),
                      "Launch Assets Application"));


         public void FilterAssetTable(string Asset) =>
       AllureLogger.LogStep($"I filter table Asset with '{Asset}'", () =>
       {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By AssetLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");
            IWebElement AssetField = wait.Until(SeleniumWaits.ElementToBeClickable(AssetLocator));
           AssetField.Click();
           AssetField.Clear();
           AssetField.SendKeys(Asset);
           AssetField.SendKeys(Keys.Enter);
       });

        public void SelectNoRecordFromAssetTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Asset Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                  $"I Select No {recordNumber} Record From Asset Table Records");
            });

        }

         public void TakeScreenshotOfIssueRotatingAssetsToAWorkOrderTest() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-TR-IM-002SC02", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-TR-IM-002SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-IM-002SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });


        public void TakeScreenshotOfFaultWorkOrder() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-TR-IM-002SC01", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-TR-IM-002SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-IM-002SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });






        //Issuing Consumable Materials to a Work Order POM Steps

                 


         public void FilterTableStoreroom(string Storeroom, string Item) =>
       AllureLogger.LogStep($"I filter table storeroom = '{Storeroom}', Item = '{Item}','", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           By StoreroomFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:3\\]_txt-tb");
           By ItemFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");

           IWebElement StoreroomFilter = wait.Until(SeleniumWaits.ElementToBeClickable(StoreroomFilterLocator));
           StoreroomFilter.Click();
           StoreroomFilter.Clear();
           StoreroomFilter.SendKeys(Storeroom);
           
           IWebElement ItemFilter = wait.Until(SeleniumWaits.ElementToBeClickable(ItemFilterLocator));
           ItemFilter.Click();
           ItemFilter.Clear();
           ItemFilter.SendKeys(Item);
           ItemFilter.SendKeys(Keys.Enter);

       });

         public void FilterItemTableRecords(string Description, string Item) =>
       AllureLogger.LogStep($"I filter table Description = '{Description}', Item = '{Item}','", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           By DescriptionFilterLocator = By.XPath("//*[@id='lookup_page1_tfrow_[C:1]_txt-tb']");
           By ItemFilterLocator = By.XPath("//*[@id='lookup_page1_tfrow_[C:0]_txt-tb']");

           IWebElement DescriptionFilter = wait.Until(SeleniumWaits.ElementToBeClickable(DescriptionFilterLocator));
           DescriptionFilter.Click();
           DescriptionFilter.Clear();
           DescriptionFilter.SendKeys(Description);
           
           IWebElement ItemFilter = wait.Until(SeleniumWaits.ElementToBeClickable(ItemFilterLocator));
           ItemFilter.Click();
           ItemFilter.Clear();
           ItemFilter.SendKeys(Item);
           ItemFilter.SendKeys(Keys.Enter);

       });


        public void SelectDetailMenuOflocationField() =>
       AllureLogger.LogStep("I Select Detail Menu for location field", () =>
         SafeActions.Click(driver, By.CssSelector("#m7cfd1dff-img"),
                     "I Select Detail Menu for location field"));

        public void SelectValueOptionOflocationField() =>
       AllureLogger.LogStep("Select Value Option Of location field", () =>
         SafeActions.Click(driver, By.Id("LOCATIONS_locations0_a_tnode"),
                     "Select Value Option Of location field"));

         public void FilterTableStoreroom(string location) =>
       AllureLogger.LogStep($"I filter table location with '{location}'", () =>
       {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By locationFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");
            IWebElement locationField = wait.Until(SeleniumWaits.ElementToBeClickable(locationFieldLocator));

           locationField.Click();
           locationField.Clear();
           locationField.SendKeys(location);
           locationField.SendKeys(Keys.Enter);
       });


        public void SelectNoRecordFromLocationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From location Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                  $"I Select No {recordNumber} Record From location Table Records");
            });

        }

         public void SelectViewItemDetails() =>
       AllureLogger.LogStep("I select view Item details", () =>
         SafeActions.Click(driver, By.CssSelector("#m6ea76bb8_tdrow_\\[C\\:0\\]_tgdet-ti\\[R\\:1\\]_img"),
                     "I select view Item details"));

         public void SelectNewRowButtonUnderTheUsageLine() =>
       AllureLogger.LogStep("I select New Row button under the Usage Line", () =>
         SafeActions.Click(driver, By.CssSelector("#m6ea76bb8_bg_button_addrow-pb"),
                     "I select New Row button under the Usage Line"));


         public void FilterLocationsTableRecords(string location, string Type) =>
       AllureLogger.LogStep($"I filter table locations = '{location}', Type = '{Type}','", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           By locationFilterLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");
           By TypeFilterLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:2\\]_txt-tb");

           IWebElement locationFilter = wait.Until(SeleniumWaits.ElementToBeClickable(locationFilterLocator));
           locationFilter.Click();
           locationFilter.Clear();
           locationFilter.SendKeys(location);
           
           IWebElement TypeFilter = wait.Until(SeleniumWaits.ElementToBeClickable(TypeFilterLocator));
           TypeFilter.Click();
           TypeFilter.Clear();
           TypeFilter.SendKeys(Type);
           TypeFilter.SendKeys(Keys.Enter);

       });


          public void OpenSelectValueLookupOfIssueToField() =>
       AllureLogger.LogStep("I open Select Value lookup of Issue To field", () =>
         SafeActions.Click(driver, By.CssSelector("#m7efc1065-img"),
                     "I open Select Value lookup of Issue To field"));


         public void FilterIssueToTable(string IssueTo) =>
       AllureLogger.LogStep($"I filter table Issue To with '{IssueTo}'", () =>
       {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            By IssueToFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");
            IWebElement IssueToField = wait.Until(SeleniumWaits.ElementToBeClickable(IssueToFieldLocator));

           IssueToField.Click();
           IssueToField.Clear();
           IssueToField.SendKeys(IssueTo);
           IssueToField.SendKeys(Keys.Enter);
       });

         public void SelectNoRecordFromPersonRecords(int recordNumber)
         {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From person Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                  $"I Select No {recordNumber} Record From person Table Records");
            });

         }

           public void VerifyStatusChangedToCOMPLETE() =>
        AllureLogger.LogStep("I verify status changed to COMPLETE", () =>
        {

            try
            {
                // Wait 10 seconds for the page or element to load
                Task.Delay(20000).Wait();

                // Find the Status field element by CSS selector (update selector if needed)
                var statusField = driver.FindElement(By.CssSelector("#mb684b1af-tb"));

                // Get the 'value' attribute of the element
                string statusValue = statusField.GetAttribute("value");

                // Validate the value is "COMPLETE"
                if (string.IsNullOrEmpty(statusValue))
                {
                    throw new Exception("Status field is empty or null.");
                }

                if (statusValue != "COMPLETE")
                {
                    throw new Exception($"Expected status value COMPLETE but found '{statusValue}'.");
                }

                Console.WriteLine("Success: Status field value is COMPLETE.");
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


         public void TakeScreenshotOfIssuingConsumableMaterialsTest() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-TR-IM-003", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-TR-IM-003.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-IM-003_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });




        // Returning Items to Inventory POM Steps
         



         public void SelectItemsForReturnButton() =>
       AllureLogger.LogStep("I select Items for Return button", () =>
         SafeActions.Click(driver, By.Id("m6ea76bb8_bg_button_selectitemsforreturnissue-pb"),
                     "I select Items for Return button"));

            public void FilterTableItemsForReturn(string Item) =>
        AllureLogger.LogStep($"I filter table Items for Return '{Item}'", () =>
        {
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

            // Step 1: Click the filter icon (update the selector as needed)
            By filterIcon = By.Id("mc8010645-lb2"); 
            IWebElement iconElement = wait.Until(SeleniumWaits.ElementToBeClickable(filterIcon));
            iconElement.Click();

             // Step 2: Now interact with the filter field
             By filterItem = By.CssSelector("#mc8010645_tfrow_\\[C\\:1\\]_txt-tb");
             IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterItem));
             filterField.Click();
             filterField.Clear();
             filterField.SendKeys(Item);
             filterField.SendKeys(Keys.Enter);
        });

        public void SelectNoRecordFromItemsForReturnTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Items for Return Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"mc8010645_tdrow_[C:0]_tbselrow-ti[R:{zeroBasedIndex}]_img";

                SafeActions.Click(driver, By.Id(selector),
                  $"I Select No {recordNumber} Record From Items for Return Table Records");
            });

        }


        public void PressOK() =>
       AllureLogger.LogStep("I press OK", () =>
         SafeActions.Click(driver, By.CssSelector("#m48ec74c2-pb"),
                     "I press OK"));

        public void TakeScreenshotOfCompleteStatus() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-TR-IM-004SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-TR-IM-004SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-IM-004SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

        public void GoToMaterialsTab() =>
       AllureLogger.LogStep("I go to materials Tab", () =>
         SafeActions.Click(driver, By.Id("m341ae71c-tab_anchor"),
                     "I go to materials Tab"));



           public void VerifyIssuedMaterials() =>
       AllureLogger.LogStep("I verify issued materials", () =>
       {
           try
           {
               // Wait 10 seconds for the page or elements to load
               Task.Delay(10000).Wait();

               // ----------- Ship-To Address Field Checks -----------

               // Replace these selectors with actual ones from your application
               var ItemNumber = driver.FindElement(By.CssSelector("#m5c83df34_tdrow_\\[C\\:2\\]_txt-tb\\[R\\:0\\]"));
               var ItemDescription = driver.FindElement(By.CssSelector("#m5c83df34_tdrow_\\[C\\:4\\]_txt-tb\\[R\\:0\\]"));
               var Storeroom = driver.FindElement(By.CssSelector("#m5c83df34_tdrow_\\[C\\:6\\]_txt-tb\\[R\\:0\\]"));
              

               // Read values
               string line1 = ItemNumber.GetAttribute("value")?.Trim();
               string line2 = ItemDescription.GetAttribute("value")?.Trim();
               string line3 = Storeroom.GetAttribute("value")?.Trim();
               

               // Check if any field is null, empty, or whitespace
               if (string.IsNullOrWhiteSpace(line1))
                throw new Exception("Address Line 1 is empty or blank.");

                if (string.IsNullOrWhiteSpace(line2))
                throw new Exception("Address Line 2 is empty or blank.");

               if (string.IsNullOrWhiteSpace(line3))
                throw new Exception("City field is empty or blank.");
                              
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


         public void TakeScreenshotOfReturningItemsTest() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-TR-IM-004SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-TR-IM-004SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-IM-004SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });




        // Internal Transfers POM Steps



        public void SetUsageTypeFieldToTransfer() =>
       AllureLogger.LogStep("I set Usage Type field to Transfer", () =>
         SafeActions.Click(driver, By.Id("menu0_TRANSFER_OPTION_a_tnode"),
                     "I set Usage Type field to Transfer"));


         public void DetailMenuForStoreroomFieldUnderTransferDetails() =>
         AllureLogger.LogStep("I Select Detail Menu for Storeroom FieldUnderTransferDetails", () =>
           SafeActions.Click(driver, By.CssSelector("#m3399b715-img"),
                       "I Select Detail Menu for Storeroom FieldUnderTransferDetails"));

           public void SelectValueForStoreroomFieldUnderTransferDetails() =>
        AllureLogger.LogStep("I Select Value for Storeroom FieldUnderTransferDetails", () =>
           SafeActions.Click(driver, By.Id("NORMAL_normal0_a_tnode"),
                       "I Select Value for Storeroom FieldUnderTransferDetails"));


         public void IFilterStoreroom(string Storeroom) =>
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


         public void OpenApplicationInventoryFromFavMenu() =>
       AllureLogger.LogStep("I set Usage Type field to Transfer", () =>
         SafeActions.Click(driver, By.Id("FavoriteApp_INVENTOR"),
                     "I set Usage Type field to Transfer"));


         public void FilterInventory(string Inventory) =>
       AllureLogger.LogStep($"I filter table Inventory with '{Inventory}'", () =>
       {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:0\\]_txt-tb");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

           filterField.Click();
           filterField.Clear();
           filterField.SendKeys(Inventory);
           filterField.SendKeys(Keys.Enter);
       });


        public void SelectNoRecordFromInventoryTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Inventory Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                  $"I Select No {recordNumber} Record From Inventory Table Records");
            });

        }

           public void VerifyInventoryBalance() =>
       AllureLogger.LogStep("I verify inventory balance", () =>
       {
           try
           {
               // Wait 25 seconds for page or element to load
               Task.Delay(25000).Wait();

               // Find the balance field element by CSS selector
               var balanceField = driver.FindElement(By.CssSelector("#mbc8dc186-tb"));

               // Get the 'value' attribute or fallback to visible text
               string balanceValue = balanceField.GetAttribute("value");
               if (string.IsNullOrEmpty(balanceValue))
               {
                   balanceValue = balanceField.Text;
               }

               if (string.IsNullOrEmpty(balanceValue))
               {
                  throw new Exception("Balance field is empty or null.");
               }

               Console.WriteLine($"Balance field text value: '{balanceValue}'.");
               }
               catch (NoSuchElementException ex)
               {
                   Console.WriteLine("Error: Balance field not found - " + ex.Message);
                   throw;
               }
               catch (Exception ex)
               {
                   Console.WriteLine("Error: " + ex.Message);
                   throw;
               }
       });

         public void TakeScreenshotOfInternalTransfersTest() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-TR-IM-005", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-TR-IM-005.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-IM-005_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });




        //Inter-depot Transfer POM Steps
         

         public void SelectShipped() =>
        AllureLogger.LogStep("I Select Shipped", () =>
           SafeActions.Click(driver, By.Id("menu0_SHIPPED_OPTION_a_tnode"),
                      "I Select Shipped"));

         public void OpenSelectValueLookupOfShipToField() =>
       AllureLogger.LogStep("I open Select Value lookup of Ship To field", () =>
         SafeActions.Click(driver, By.CssSelector("#m16c0dfa8-img"),
                     "I open Select Value lookup of Ship To field"));

         public void FilterShipTo(string ShipTo) =>
       AllureLogger.LogStep($"I filter table Ship To with '{ShipTo}'", () =>
       {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By filterFieldLocator = By.CssSelector("#lookup_page2_tfrow_\\[C\\:0\\]_txt-tb");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

           filterField.Click();
           filterField.Clear();
           filterField.SendKeys(ShipTo);
           filterField.SendKeys(Keys.Enter);
       });

        public void SelectNoRecordFromShipToTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Ship To Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                  $"I Select No {recordNumber} Record From Ship To Table Records");
            });

        }

        public void PressOKDialogButton() =>
       AllureLogger.LogStep("I Press OK dialog button", () =>
         SafeActions.Click(driver, By.CssSelector("#m7f6dbd9-pb"),
                     "I Press OK dialog button"));

         public void SelectAction() =>
       AllureLogger.LogStep("I select action", () =>
         SafeActions.Click(driver, By.CssSelector("#toolbar2_tbs_1_tbcb_0_action-img"),
                     "I select action"));

         public void RunReports() =>
       AllureLogger.LogStep("I Run Reports", () =>
         SafeActions.Click(driver, By.Id("menu0_RUNREPORTS_OPTION_a_tnode"),
                     "I Run Reports"));

         public void FilterTableShipmentReports(string ShipmentReports) =>
       AllureLogger.LogStep($"I filter table Shipment Reports with '{ShipmentReports}'", () =>
       {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By filterFieldLocator = By.CssSelector("#ma3255eb6_tfrow_\\[C\\:0\\]_txt-tb");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

           filterField.Click();
           filterField.Clear();
           filterField.SendKeys(ShipmentReports);
           filterField.SendKeys(Keys.Enter);
       });


        public void SelectNoRecordFromShipmentReportsTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Shipment Reports Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"ma3255eb6_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                  $"I Select No {recordNumber} Record From Shipment Reports Table Records");
            });

        }

         public void SubmitReports() =>
       AllureLogger.LogStep("I Submit Reports", () =>
         SafeActions.Click(driver, By.CssSelector("#m7e2dd5b1-pb"),
                     "I Submit Reports"));

          public void TakeScreenshotOfInterDepotTransfer() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-TR-IM-006", () =>
       {
            try
            {
               string screenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-TR-IM-006.png";
               string failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-IM-006_Failure.png";

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

                    var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-IM-006_Failure.png";
                    var takescreenshot = new TakeScreenShotPOM(driver);
 
                    takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                    throw new Exception("Test failed while taking screenshot.", ex);
                }
       });






        //Receiving Shipments POM Steps
         
         


         public void OpenApplicationShipmentReceivingFromFavMenu() =>
       AllureLogger.LogStep("I open application shipment receiving from Fav Menu", () =>
         SafeActions.Click(driver, By.Id("FavoriteApp_SHIPREC"),
                     "I open application shipment receiving from Fav Menu"));

         public void FilterTableShipmentReceiving(string ShipmentReceiving) =>
       AllureLogger.LogStep($"I filter table Shipment Reports with '{ShipmentReceiving}'", () =>
       {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

           filterField.Click();
           filterField.Clear();
           filterField.SendKeys(ShipmentReceiving);
           filterField.SendKeys(Keys.Enter);
       });

        public void SelectNoRecordFromShipmentReceivingTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From shipment receiving Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                  $"I Select No {recordNumber} Record From Shipment Reports Table Records");
            });

        }

        public void SelectShippedItemsButton() =>
       AllureLogger.LogStep("I select Shipped Items button", () =>
         SafeActions.Click(driver, By.Id("mbdf37fb6_bg_button_selorditem-pb"),
                     "I select Shipped Items button"));



        public void SelectNoRecordFromShippedItemsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Shipped Items Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"mf9bb799f_ttrow_[C:0]_ttselallrows-ti_img";

                SafeActions.Click(driver, By.Id(selector),
                  $"I Select No {recordNumber} Record From Shipped Items Table Records");
            });

        }


        public void ClickOk() =>
       AllureLogger.LogStep("I click ok", () =>
         SafeActions.Click(driver, By.CssSelector("#mab71af75-pb"),
                     "I click ok"));


         public void TakeScreenshotOfReceivingShipmentsTest() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-TR-IM-007", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-TR-IM-007.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-TR-IM-007_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });



    }
}