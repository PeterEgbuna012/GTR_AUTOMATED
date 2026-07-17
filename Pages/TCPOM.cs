using GTR_AUTOMATED.Utilities;
using GTR_AUTOMATED.Pages;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using Reqnroll;
using GivenAttribute = Reqnroll.GivenAttribute;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;


namespace GTR_AUTOMATED.Pages
{
    
    public sealed class TCPOM
    {
        private readonly IWebDriver driver;

        public TCPOM(IWebDriver drv) => driver = drv;

        public void OpenGoToMenu() =>
           AllureLogger.LogStep("Open [Go To] menu", () =>
               SafeActions.Click(driver, By.Id("titlebar-tb_gotoButton"),
                                 "Go To button"));

        public void OpenWorkOrderMenu() =>
            AllureLogger.LogStep("Open [Work Order] menu", () =>
                SafeActions.Click(driver, By.Id("menu0_WO_MODULE_a_tnode"),
                                  "Work Order menu node"));

          public void OpenApplicationToiletCheckerMXR() =>
        AllureLogger.LogStep("Launch application Toilet Checker", () =>
        {
            SafeActions.Click(driver,
               By.Id("menu0_WO_MODULE_sub_changeapp_MXRTOILETCHECKER_a"),
               "Launch application Toilet Checker");
             Task.Delay(8000).Wait();
        });


         public void FilterTableToiletChecker(string ToiletChecker) =>
        AllureLogger.LogStep($"I filter table Toilet Checker with '{ToiletChecker}'", () =>
        {
          By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:0\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
          IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(ToiletChecker);
          filterField.SendKeys(Keys.Enter);
        });


        public void SelectViewDetailsArrow()
        {
            AllureLogger.LogStep("I select View Details arrow", () =>
            {
                SafeActions.Click(driver, By.Id("m6ef0bfaf_tdrow_[C:0]_tgdet-ti[R:0]_img"), "I select View Details arrow");
                Task.Delay(8000).Wait();
            });
        }


        public void VerifyToiletNumber() =>
           AllureLogger.LogStep("I verify toilet number", () =>
           {
                try
                {
                      // Wait 5 seconds for the page or element to load
                      Task.Delay(5000).Wait();

                     // Find the Related Work Order element by CSS selector
                     var relatedWorkOrder = driver.FindElement(By.CssSelector("#m7ec1f31b-tb"));

                    // Get the 'value' attribute of the element
                    string workOrderNumber = relatedWorkOrder.GetAttribute("value");

                     // Check if the work order number is null or empty
                     if (string.IsNullOrEmpty(workOrderNumber))
                     {
                          throw new Exception("Work Order: Work order number is empty or null.");
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


        public void VerifyToiletDescription() =>
       AllureLogger.LogStep("I verify toilet number", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(5000).Wait();

               // Find the Related Work Order element by CSS selector
               var relatedWorkOrder = driver.FindElement(By.CssSelector("#m7ec1f31b-tb2"));

               // Get the 'value' attribute of the element
               string workOrderNumber = relatedWorkOrder.GetAttribute("value");

               // Check if the work order number is null or empty
               if (string.IsNullOrEmpty(workOrderNumber))
               {
                   throw new Exception("Work Order: Work order number is empty or null.");
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

         public void VerifyToiletStatus() =>
       AllureLogger.LogStep("I verify toilet number", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(5000).Wait();

               // Find the Related Work Order element by CSS selector
               var relatedWorkOrder = driver.FindElement(By.CssSelector("#m90cf9237-tb"));

               // Get the 'value' attribute of the element
               string workOrderNumber = relatedWorkOrder.GetAttribute("value");

               // Check if the work order number is null or empty
               if (string.IsNullOrEmpty(workOrderNumber))
               {
                   throw new Exception("Status: reason is empty or null.");
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

        public void VerifyToiletUnavailabilityReason() =>
       AllureLogger.LogStep("I verify toilet unavailability reason", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(5000).Wait();

               // Find the Related Work Order element by CSS selector
               var relatedWorkOrder = driver.FindElement(By.CssSelector("#meab0794-tb"));

               // Get the 'value' attribute of the element
               string workOrderNumber = relatedWorkOrder.GetAttribute("value");

               // Check if the work order number is null or empty
               if (string.IsNullOrEmpty(workOrderNumber))
               {
                   throw new Exception("reason: reason is empty or null.");
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


          public void VerifyToiletLocked() =>
       AllureLogger.LogStep("I verify toilet locked", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(5000).Wait();

               // Find the Toilet Locked element by CSS selector
               var ToiletLocked = driver.FindElement(By.CssSelector("#me0a566b8-tb"));

               // Get the 'value' attribute of the element
               string ToiletAsset = ToiletLocked.GetAttribute("value");

               // Check if the Toilet Locked is null or empty
               if (string.IsNullOrEmpty(ToiletAsset))
               {
                   throw new Exception("Status: reason is empty or null.");
               }

               // Log success with the Toilet Locked
               Console.WriteLine("Success: Toilet Locked " + ToiletAsset);
           }
           catch (NoSuchElementException ex)
           {
               Console.WriteLine("Error: Toilet Locked not found - " + ex.Message);
               throw;
           }
           catch (Exception ex)
           {
               Console.WriteLine("Error: " + ex.Message);
               throw;
           }
       });


            public void VerifyToiletCheckedDate() =>
       AllureLogger.LogStep("I verify toilet locked", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(5000).Wait();

               // Find the Related Work Order element by CSS selector
               var relatedWorkOrder = driver.FindElement(By.CssSelector("#meab0794-tb"));

               // Get the 'value' attribute of the element
               string workOrderNumber = relatedWorkOrder.GetAttribute("value");

               // Check if the work order number is null or empty
               if (string.IsNullOrEmpty(workOrderNumber))
               {
                   throw new Exception("Toilet Checked Date: reason is empty or null.");
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



        public void SelectTheCloseDetailsArrow() =>
        AllureLogger.LogStep("I select the Close Details arrow", () =>
            SafeActions.Click(driver, By.Id("m6ef0bfaf_tdrow_[C:0]_tgdet-ti[R:0]_img"),
                              "I select the Close Details arrow"));


         public void TakeScreenshotOfViewToiletStatus() =>
       AllureLogger.LogStep("Capture Screenshot for UAT-TAS-001", () =>
       {
           try
           {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-001.png";

                takescreenshot.TakeScreenshot(driver, successPath);
           }
                catch (Exception ex)
                {
                     Console.WriteLine($"Screenshot failed: {ex.Message}");

                     // Attempt fallback screenshot on failure
                     var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-001_Failure.png";
                     var takescreenshot = new TakeScreenShotPOM(driver);

                     takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                     // Optional: Rethrow if test should fail
                      throw new Exception("Test failed while taking screenshot.", ex);
                }
       });



        //Change status of a Toilet Asset POM Steps


        public void SelectChangeToiletAssetStatuseButton() =>
        AllureLogger.LogStep("I select change toilet asset statuse button", () =>
            SafeActions.Click(driver, By.Id("m6a7dfd2f_tdrow_[C:8]_hyperlink-lb[R:0]_image"),
                              "I select change toilet asset statuse button"));


        public void ClickOnTheStatusDropdown() =>
        AllureLogger.LogStep("I Click on the status dropdown", () =>
            SafeActions.Click(driver, By.Id("m1c9ae976-img"),
                              "I Click on the status dropdown"));

        public void SelectUnavailable() =>
        AllureLogger.LogStep("I select unavailable", () =>
            SafeActions.Click(driver, By.Id("menu0_UNAVAILABLE_OPTION_a_tnode"),
                              "I select unavailable"));

         public void FilterTableToiletUnavailableReason(string ToiletCheckerunavailableReason) =>
      AllureLogger.LogStep($"I filter table Toilet Unavailable Reason with '{ToiletCheckerunavailableReason}'", () =>
      {
          Task.Delay(2000).Wait();
          By filterFieldLocator = By.CssSelector("#m8593b8cc-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
          IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(ToiletCheckerunavailableReason);
         
      });

        public void PressButtonOk() =>
        AllureLogger.LogStep("I press button ok", () =>
            SafeActions.Click(driver, By.CssSelector("#m5f66e129-pb"),
                              "I press button ok"));

        public void SelectAvailable() =>
        AllureLogger.LogStep("I select available", () =>
            SafeActions.Click(driver, By.Id("menu0_AVAILABLE_OPTION_a_tnode"),
                              "I select available"));


        public void TakeScreenshotOfChangeStatusOfAToiletAsset() =>
       AllureLogger.LogStep("Capture Screenshot for UAT-TAS-002SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-002SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-002SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        //Lock/ Unlock a Toilet Asset POM Steps


        public void TakeScreenshotOfToiletStatusUnlock() =>
      AllureLogger.LogStep("Capture Screenshot for UAT-TAS-002SC01", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-002SC01.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-002SC01_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });


        public void PressButtonLockUnlockAToiletAsset() =>
          AllureLogger.LogStep("I press button Lock\\/Unlock a Toilet Asset", () =>
          {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
                var element = wait.Until(SeleniumWaits.ElementToBeClickable(
                By.Id("m6ef0bfaf_tdrow_[C:13]_hyperlink-lb[R:0]_image")));

                // Optional: Scroll into view to avoid element not interactable errors
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);

                // Use Actions to move and click
                Actions actions = new Actions(driver);
                actions.MoveToElement(element).Click().Perform();
                Task.Delay(8000).Wait();
          });


        public void EnterFollowingToiletCheckerData(string Comment) =>
      AllureLogger.LogStep($"I enter following Toilet Checker data '{Comment}'", () =>
      {
          By filterFieldLocator = By.CssSelector("#m78f8c09b-ta");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
          IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(Comment);
          filterField.SendKeys(Keys.Enter);
      });


        public void PressOkButton() =>
        AllureLogger.LogStep("I press ok button", () =>
            SafeActions.Click(driver, By.CssSelector("#m42896c82-pb"),
                              "I press ok button"));


        public void PressDialogButtonNo() =>
        AllureLogger.LogStep("I press dialog button no", () =>
            SafeActions.Click(driver, By.CssSelector("#m96ad0396-pb"),
                              "I press dialog button no"));

        public void PressDialogButtonYes() =>
        AllureLogger.LogStep("I press dialog button yes", () =>
            SafeActions.Click(driver, By.CssSelector("#me1720906-pb"),
                              "I press dialog button yes"));


        //Check audit logs POM Steps


        public void PressButtonViewAuditLog() =>
        AllureLogger.LogStep("I press button View Audit Log", () =>
            SafeActions.Click(driver, By.CssSelector("#m39e89483-pb"),
                              "I press button View Audit Log"));

        public void TakeScreenshotOfAuditLog() =>
      AllureLogger.LogStep("Capture Screenshot for UAT-TAS-004", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-004.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-004_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });

        public void PressOKButton() =>
        AllureLogger.LogStep("I press OK button", () =>
            SafeActions.Click(driver, By.CssSelector("#m11fb890d-pb"),
                              "I press OK button"));


        // Audit Log Updates POM Steps


          public void TakeScreenshotOfAuditLogUpdates() =>
      AllureLogger.LogStep("Capture Screenshot for UAT-TAS-005", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-005.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-005_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });


        //Update status of  locked Toilet Asset POM Steps


        public void PressOkDialogSystemMessageButton() =>
       AllureLogger.LogStep("I press ok dialog system message button", () =>
           SafeActions.Click(driver, By.CssSelector("#m88dbf6ce-pb"),
                             "I press ok dialog system message button"));


         public void TakeScreenshotOfUpdateStatusOfLockedToiletAssetTest() =>
      AllureLogger.LogStep("Capture Screenshot for UAT-TAS-006", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-006.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-006_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });

              public void ChangeToiletAssetStatuseButton() =>
          AllureLogger.LogStep("I change toilet asset statuse button", () =>
          {
               SafeActions.Click(driver, By.Id("m6ef0bfaf_tdrow_[C:12]_hyperlink-lb[R:0]_image"),
                          "I change toilet asset statuse button");
               Task.Delay(5000).Wait();
          });



        //Toilet Asset Setup POM Steps


        public void OpenAssetMenu() =>
            AllureLogger.LogStep("Asset Menu Bar", () =>
                SafeActions.Click(driver, By.Id("menu0_ASSET_MODULE_a"),
                                  "Asset Menu node"));

        public void SelectNoRecordFromAssetsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Asset Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Asset Table Records");
                Task.Delay(5000).Wait();

            });
        }
        
        public void OpenApplicationAssetTr() =>
            AllureLogger.LogStep("Launch application Asset (TR)", () =>
                SafeActions.Click(driver, By.Id("menu0_ASSET_MODULE_sub_changeapp_PLUSTASSET_a_tnode"),
                                  "Launch application Asset (TR)"));


         public void FilterTableAssets(string Asset) =>
      AllureLogger.LogStep($"I filter table Asset with '{Asset}'", () =>
      {
          By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
          IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(Asset);
          filterField.SendKeys(Keys.Enter);
      });

                public void GoToTabSpecifications() =>
      AllureLogger.LogStep("I go to Tab Specifications", () =>
          SafeActions.Click(driver, By.Id("mbda8a4b-tab_anchor"),
                            "I go to Tab Specifications"));



        public void AddNewRecordInSpecificationsSection() =>
            AllureLogger.LogStep("I add new record in Specifications section", () =>
                SafeActions.Click(driver, By.CssSelector("#mc8d54871_bg_button_addrow-pb"),
                                  "I add new record in Specifications section"));

        public void OpenSelectValueLookupForAttributeField() =>
           AllureLogger.LogStep("I open Select Value lookup for attribute field", () =>
               SafeActions.Click(driver, By.CssSelector("#m92e4efeb-img"),
                                 "I open Select Value lookup for attribute field"));

        public void SelectNoRecordFromAttributeTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From attribute Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From attribute Table Records");
            });

        }

        public void OpenSelectValueLookupForAlphanumericValueField() =>
          AllureLogger.LogStep("I open Select Value lookup for alphanumeric value field", () =>
              SafeActions.Click(driver, By.CssSelector("#m9ab0008-img"),
                                "I open Select Value lookup for alphanumeric value field"));

        public void SelectNoRecordFromAlphanumericValueTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From alphanumeric Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From alphanumeric Table Records");
            });

        }


         public void TakeScreenshotOfUpdateStatusOfToiletAssetSetupTest() =>
      AllureLogger.LogStep("Capture Screenshot for UAT-TAS-007SC01", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-007SC01.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-007SC01_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });

           public void TakeScreenshotOfValidateToiletAssetSetupTest() =>
      AllureLogger.LogStep("Capture Screenshot for UAT-TAS-007SC02", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-007SC02.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-007SC02_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });



        //View Clean Master Work orders POM Steps

        public void RefreshToiletCheckerTableRecords() =>
         AllureLogger.LogStep("I refresh Toilet Checker table records", () =>
         {
               By textFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:0\\]_txt-tb");

              // Wait for the field to be visible and interactable
              WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
              IWebElement textField = wait.Until(SeleniumWaits.ElementToBeClickable(textFieldLocator));

              // Click the field
               textField.Click();

              // Send ENTER key
              textField.SendKeys(Keys.Enter);
         });

        public void SelectNoRecordFromToiletCheckerTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Toilet Checker Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:0]-c[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Toilet Checker Table Records");
            });

        }


        public void ViewCleanMasterWorkOrdersOption() =>
       AllureLogger.LogStep("I select View clean master work orders option", () =>
           SafeActions.Click(driver, By.Id("m6a7dfd2f_tdrow_[C:6]_hyperlink-lb[R:0]_image"),
                             "I select View clean master work orders option"));

        public void SelectCompleteCleanMasterTaskButton() =>
       AllureLogger.LogStep("I select complete clean master task button", () =>
           SafeActions.Click(driver, By.Id("md6723283_tdrow_[C:7]_hyperlink-lb[R:0]_image"),
                             "I select complete clean master task button"));

         public void TakeScreenshotOfViewCleanMasterWork() =>
      AllureLogger.LogStep("Capture Screenshot for UAT-TAS-008SC01", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-008SC01.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-008SC01_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });

        public void PressOk() =>
       AllureLogger.LogStep("I press OK button", () =>
           SafeActions.Click(driver, By.CssSelector("#mbc7bd441-pb"),

                             "I press OK button"));

        

          public void TakeScreenshotOfViewCleanMasterWorkOrdersTest() =>
        AllureLogger.LogStep("Capture Screenshot for UAT-TAS-008SC02", () =>
        {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-008SC02.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-008SC02_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
        });




        //Calculate Risk When “Days Left = 1” POM Steps


           public void VerifyToiletLockedComments() =>
         AllureLogger.LogStep("I verify toilet locked Comments", () =>
         {
            try
            {
               // Wait 5 seconds for the page or element to load
               Task.Delay(6000).Wait();

               // Find the Related Work Order element by CSS selector
               var ToiletLockedComments = driver.FindElement(By.CssSelector("#m97a2562e-ta"));

               // Get the 'value' attribute of the element
               string ToiletLocked = ToiletLockedComments.GetAttribute("value");

               // Check if the work order number is null or empty
               if (string.IsNullOrEmpty(ToiletLocked))
               {
                   throw new Exception("Status: reason is empty or null.");
               }

               // Log success with the work order number
               Console.WriteLine("Success: Toilet Locked Comments " + ToiletLocked);
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Error: Toilet Locked Comments not found - " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
               Console.WriteLine("Error: " + ex.Message);
               throw;
            }
         });


         public void TakeScreenshotOfTolietCheckerDetails() =>
        AllureLogger.LogStep("Capture Screenshot for UAT-TAS-009SC01", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-009SC01.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
              catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");
 
                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-009SC01_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });

          public void FilterCleanMaster(string Location, string WorkType) =>
        AllureLogger.LogStep($"I filter CM Work Order table with Location = '{Location}', Status = '{WorkType}','", () =>
        {
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

             // Adjust column indices as per actual table structure:
             // Description = column 2 → C:2
             // Status = column 10 → C:10

             By LocationFilterLocator = By.CssSelector("#md6723283_tfrow_\\[C\\:1\\]_txt-tb");
             By WorkTypeFilterLocator = By.CssSelector("#md6723283_tfrow_\\[C\\:2\\]_txt-tb");

             IWebElement LocationFilter = wait.Until(SeleniumWaits.ElementToBeClickable(LocationFilterLocator));
            LocationFilter.Click();
            LocationFilter.Clear();
            LocationFilter.SendKeys(Location);

             IWebElement WorkTypeFilter = wait.Until(SeleniumWaits.ElementToBeClickable(WorkTypeFilterLocator));
            WorkTypeFilter.Click();
            WorkTypeFilter.Clear();
            WorkTypeFilter.SendKeys(WorkType);
            WorkTypeFilter.SendKeys(Keys.Enter);
             Task.Delay(10000).Wait();

        });


        public void VerifyCETDaysLeft()
        {
            AllureLogger.LogStep("I verify CET Days Left", () =>
            {
                try
                {
                    // Wait for cell to be available
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    var cetDaysElement = wait.Until(d =>
                        d.FindElement(By.Id("md6723283_tdrow_[C:8]-c[R:0]"))
                    );

                    // Get text from the cell (NOT value attribute)
                    string cetDaysLeft = cetDaysElement.Text.Trim();

                    if (string.IsNullOrWhiteSpace(cetDaysLeft))
                    {
                        throw new Exception("CET Days Left cell is empty or null.");
                    }

                    // Print the value
                    Console.WriteLine("CET Days Left: " + cetDaysLeft);
                }
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine("Error: CET Days Left cell not found - " + ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    throw;
                }
            });
        }





        public void VerifyWTFDaysLeft()
        {
            AllureLogger.LogStep("I verify WTF Days Left", () =>
            {
                try
                {
                    // Wait for the cell to be present
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
                    var wtfDaysElement = wait.Until(d =>
                        d.FindElement(By.Id("md6723283_tdrow_[C:8]-c[R:1]"))
                    );

                    // Get visible text from the cell
                    string wtfDaysLeft = wtfDaysElement.Text.Trim();

                    if (string.IsNullOrWhiteSpace(wtfDaysLeft))
                    {
                        throw new Exception("WTF Days Left cell is empty or null.");
                    }

                    // Print the value
                    Console.WriteLine("WTF Days Left: " + wtfDaysLeft);
                }
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine("Error: WTF Days Left cell not found - " + ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    throw;
                }
            });
        }




        public void TakeScreenshotOfCleanMasterDetails() =>
        AllureLogger.LogStep("Capture Screenshot for UAT-TAS-009SC02", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-009SC02.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
              catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");
 
                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-009SC02_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });


        public void OpenFleetAvailabilityManagementBRDFMenu() =>
          AllureLogger.LogStep("I Open Fleet Availability Management BRDF Menu", () =>
              SafeActions.Click(driver, By.Id("menu0_BRDF_MODULE_a_tnode"),
                                "I Open Fleet Availability Management BRDF Menu"));

        public void OpenRailUnitsBRDF()
        {
            AllureLogger.LogStep("I Open Rail Units (BRDF)", () =>
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
                wait.Until(SeleniumWaits.ElementIsVisible(
                        By.Id("menu0_BRDF_MODULE_sub_changeapp_BRDFRU_a_tnode")));

                SafeActions.Click(
                    driver,
                    By.Id("menu0_BRDF_MODULE_sub_changeapp_BRDFRU_a_tnode"),
                    "I Open Rail Units (BRDF)"
                );
                Task.Delay(10000).Wait();
            });
        }




        public void FilterTableRailUnits(string RailUnits) =>
        AllureLogger.LogStep($"I filter table Rail Units with '{RailUnits}'", () =>
        {
          By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
          IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(RailUnits);
          filterField.SendKeys(Keys.Enter);
          Task.Delay(10000).Wait();
        });


        public void SelectNoRecordFromRailUnitsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Rail Units Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Rail Units Table Records");
                Task.Delay(5000).Wait();
            });

        }

         public void VerifyUnitInService() =>
       AllureLogger.LogStep("I Verify Unit In Service", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(8000).Wait();

               // Find the Unit In Service element by CSS selector
               var UnitInService = driver.FindElement(By.CssSelector("#m7f7b53ec-tb"));

               // Get the 'value' attribute of the element
               string RailUnits = UnitInService.GetAttribute("value");

               // Check if the Unit In Service is null or empty
               if (string.IsNullOrEmpty(RailUnits))
               {
                   throw new Exception("Status: reason is empty or null.");
               }

               // Log success with the Unit In Service
               Console.WriteLine("Success: Unit In Service " + RailUnits);
           }
           catch (NoSuchElementException ex)
           {
               Console.WriteLine("Error: Unit In Service element not found - " + ex.Message);
               throw;
           }
           catch (Exception ex)
           {
               Console.WriteLine("Error: " + ex.Message);
               throw;
           }
       });

        public void TakeScreenshotOfRailUnitsDetails() =>
       AllureLogger.LogStep("Capture Screenshot for UAT-TAS-009SC03", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-009SC03.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-009SC03_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void SelectRunReports() =>
      AllureLogger.LogStep("I select Run Reports", () =>
          SafeActions.Click(driver, By.Id("m74daaf83_ns_menu_RUNREPORTS_OPTION_a_tnode"),
                            "I select Run Reports"));

         public void FilterTableToiletCheckerReports(string Reports) =>
        AllureLogger.LogStep($"I filter table Reports with '{Reports}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
            By filterFieldLocator = By.CssSelector("#m63dd11df_tfrow_\\[C\\:0\\]_txt-tb");
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(Reports);
            filterField.SendKeys(Keys.Enter);
            Task.Delay(3000).Wait();
        });

        public void SelectNoRecordFromToiletCheckerReportsTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Toilet Checker Reports Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m63dd11df_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Toilet Checker Reports Table Records");
                Task.Delay(5000).Wait();
            });

        }

          public void OpenSelectValueLookupOfArea() =>
         AllureLogger.LogStep("I open Select Value lookup of Area", () =>
           SafeActions.Click(driver, By.CssSelector("#mc7c26280-img"),
                            "I open Select Value lookup of Area"));

         public void SelectNoRecordFromAreaLookupTableRecords(int recordNumber)
         {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Toilet Checker Reports Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page3_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Toilet Checker Reports Table Records");
                Task.Delay(5000).Wait();
            });

         }


           public void SubmitReport() =>
         AllureLogger.LogStep("I submit report", () =>
            SafeActions.Click(driver, By.CssSelector("#m60efa8f3-pb"),
                            "I submit report"));


        public void TakeScreenshotOfToiletCheckerReportTest()
        {
            AllureLogger.LogStep("Capture Screenshot of report in new window", () =>
            {
                try
                {
                    // Store original window
                    string originalWindow = driver.CurrentWindowHandle;

                    // Wait until a new window is opened
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    wait.Until(d => d.WindowHandles.Count > 1);

                    // Switch to the new window
                    string reportWindow = driver.WindowHandles
                                                 .First(handle => handle != originalWindow);
                    driver.SwitchTo().Window(reportWindow);

                    // Take screenshot of the report window
                    var takescreenshot = new TakeScreenShotPOM(driver);
                    string screenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-009SC04_Report.png";

                    takescreenshot.TakeScreenshot(driver, screenshotPath);

                    Console.WriteLine("Screenshot taken of report window.");

                    // Optional: switch back to original window
                    driver.SwitchTo().Window(originalWindow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to take screenshot of report window: {ex.Message}");
                    throw;
                }
            });
        }


        // Automatically create a fault ticket when toilet asset set to unavailable for a technical reason POM Steps


        public void FilterTableFaultReportingBRDA(string Summary, string Location) =>
       AllureLogger.LogStep($"I filter CM Work Order table with Summary = '{Summary}', Location = '{Location}','", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

           // Adjust column indices as per actual table structure:
           // Description = column 2 → C:2
           // Status = column 10 → C:10

           By SummaryFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:6\\]_txt-tb");
           By LocationFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:7\\]_txt-tb");

           IWebElement SummaryFilter = wait.Until(SeleniumWaits.ElementToBeClickable(SummaryFilterLocator));
           SummaryFilter.Click();
           SummaryFilter.Clear();
           SummaryFilter.SendKeys(Summary);

           IWebElement LocationFilter = wait.Until(SeleniumWaits.ElementToBeClickable(LocationFilterLocator));
           LocationFilter.Click();
           LocationFilter.Clear();
           LocationFilter.SendKeys(Location);
           LocationFilter.SendKeys(Keys.Enter);
           Task.Delay(5000).Wait();
       });
               
        public void SelectNoRecordFromFaultReportingTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Fault Reporting Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Fault Reporting Table Records");
            });

        }

         public void VerifyFaultID() =>
       AllureLogger.LogStep("I verify Fault ID", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(5000).Wait();

               // Find the Fault ID element by CSS selector
               var FaultID = driver.FindElement(By.CssSelector("#ma884ccfa-tb"));

               // Get the 'value' attribute of the element
               string VerifyFault = FaultID.GetAttribute("value");

               // Check if the Fault ID is null or empty
               if (string.IsNullOrEmpty(VerifyFault))
               {
                   throw new Exception("Status: reason is empty or null.");
               }

               // Log success with the work order number
               Console.WriteLine("Success: Fault ID is " + VerifyFault);
           }
           catch (NoSuchElementException ex)
           {
               Console.WriteLine("Error: Fault ID element not found - " + ex.Message);
               throw;
           }
           catch (Exception ex)
           {
               Console.WriteLine("Error: " + ex.Message);
               throw;
           }
       });

         public void VerifyFaultStatus() =>
       AllureLogger.LogStep("I verify Fault Status", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(5000).Wait();

               // Find the Fault Status element by CSS selector
               var FaultStatus = driver.FindElement(By.CssSelector("#maac272a3-tb"));

               // Get the 'value' attribute of the element
               string VerifyFault = FaultStatus.GetAttribute("value");

               // Check if the Fault Status is null or empty
               if (string.IsNullOrEmpty(VerifyFault))
               {
                   throw new Exception("Status: reason is empty or null.");
               }

               // Log success with the Fault Status
               Console.WriteLine("Success: Fault Status is " + VerifyFault);
           }
           catch (NoSuchElementException ex)
           {
               Console.WriteLine("Error: Fault Status not found - " + ex.Message);
               throw;
           }
           catch (Exception ex)
           {
               Console.WriteLine("Error: " + ex.Message);
               throw;
           }
       });

         public void VerifyFaultLocation() =>
       AllureLogger.LogStep("I verify Fault Location", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(5000).Wait();

               // Find the Fault Location element by CSS selector
               var FaultLocation = driver.FindElement(By.CssSelector("#ma4936596-tb"));

               // Get the 'value' attribute of the element
               string LocationNumber = FaultLocation.GetAttribute("value");

               // Check if the Fault Location number is null or empty
               if (string.IsNullOrEmpty(LocationNumber))
               {
                   throw new Exception("Status: reason is empty or null.");
               }

               // Log success with the Fault Location number
               Console.WriteLine("Success: Fault Location number is " + LocationNumber);
           }
           catch (NoSuchElementException ex)
           {
               Console.WriteLine("Error: Fault Location element not found - " + ex.Message);
               throw;
           }
           catch (Exception ex)
           {
               Console.WriteLine("Error: " + ex.Message);
               throw;
           }
       });

         public void VerifyFaultSummary() =>
       AllureLogger.LogStep("I verify Fault Summary", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(5000).Wait();

               // Find the Fault Summary element by CSS selector
               var FaultSummary = driver.FindElement(By.CssSelector("#m992c666e-tb"));

               // Get the 'value' attribute of the element
               string Summary = FaultSummary.GetAttribute("value");

               // Check if the Fault Summary is null or empty
               if (string.IsNullOrEmpty(Summary))
               {
                   throw new Exception("Status: reason is empty or null.");
               }

               // Log success with the Fault Summary
               Console.WriteLine("Success: Fault Summary is " + Summary);
           }
           catch (NoSuchElementException ex)
           {
               Console.WriteLine("Error: Fault Summary element not found - " + ex.Message);
               throw;
           }
           catch (Exception ex)
           {
               Console.WriteLine("Error: " + ex.Message);
               throw;
           }
       });

        public void TakeScreenshotOfAutomaticallyCreateAFaultTicketWhenToiletAssetSetToUnavailableForATechnicalReasonTest() =>
        AllureLogger.LogStep("Capture Screenshot for UAT-TAS-010SC01", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-010SC01.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-010SC01_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });



        //Email notification to TOC for change of status for toilet asset POM Steps



        public void SelectNoRecordToViewDetials(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} record to view detials", () =>
            {
                // Convert to zero-based index
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic selector using the new pattern
                string selector = $"m26aedc28_tdrow_[C:0]_tgdet-ti[R:{zeroBasedIndex}]_img";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} record to view detials");
            });
        }


         public void AddEmailDetails(string Email) =>
        AllureLogger.LogStep($"I add Email Address'{Email}'", () =>
        {
          By filterFieldLocator = By.CssSelector("#m745d0874-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
          IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(Email);
          
        });


        public void TakeScreenshotOfEmailNotificationToTOCForChangeOfStatusForToiletAssetTest() =>
        AllureLogger.LogStep("Capture Screenshot for UAT-TAS-011SC01", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-011SC01.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-011SC01_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });


        public void TakeScreenshotOfModifyEmailNotificationToTOCForChangeOfStatusForToiletAssetTest() =>
        AllureLogger.LogStep("Capture Screenshot for UAT-TAS-011SC02", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-011SC02.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-011SC02_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });





        // Toilet Checker Email Notification to Downstream Locations with Turnaround Capability and Stop Time Over 10 Minutes POM Steps




        public void TakeScreenshotOfViewToiletStatusTest() =>
        AllureLogger.LogStep("Capture Screenshot for UAT-TAS-012SC01", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-012SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-012SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });

        public void OpenServiceManagementBRDF()
        {
            AllureLogger.LogStep("I Open Service Management (BRDF)", () =>
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
                wait.Until(SeleniumWaits.ElementToBeClickable(
                    By.Id("menu0_BRDF_MODULE_sub_changeapp_BRDFSM_a")));

                SafeActions.Click(
                    driver,
                    By.Id("menu0_BRDF_MODULE_sub_changeapp_BRDFSM_a"),
                    "I Open Service Management (BRDF)"
                );
                Task.Delay(10000).Wait();
            });
        }

          public void FilterTableServiceManagement(string YardAsset) =>
        AllureLogger.LogStep($"I filter table Service Management with '{YardAsset}'", () =>
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

        public void SelectNoRecordServiceManagementTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Service Management Table Records", () =>
            {
                 // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                 int zeroBasedIndex = recordNumber - 1;

                 // Build dynamic Id selector by replacing the row index [R:x]
                 string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                 SafeActions.Click(driver, By.Id(selector),
                     $"I Select No {recordNumber} Record From Service Management Table Records");
                Task.Delay(3000).Wait();
            });
        }



        public void FilterTableUnit(string Unit) =>
        AllureLogger.LogStep($"I filter table Unit with '{Unit}'", () =>
        {
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

             // Unit filter input - using 3rd filter cell, no dynamic ID
             By filterFieldLocator = By.XPath(
                "(//div[contains(concat(' ', normalize-space(@class), ' '), ' hdrcell ') " +
                "and contains(concat(' ', normalize-space(@class), ' '), ' filter ')]//input[@type='text'])[2]"
             );

             IWebElement filterField = wait.Until(driver =>
             {
                var elements = driver.FindElements(filterFieldLocator);

                return elements
               .FirstOrDefault(e => e.Displayed && e.Enabled);
             });

             ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView({block:'center'});", filterField);

              filterField.Click();

               // More reliable than Clear() for Dojo inputs
              filterField.SendKeys(Keys.Control + "a");
              filterField.SendKeys(Keys.Delete);

              filterField.SendKeys(Unit);
              filterField.SendKeys(Keys.Enter);
              Task.Delay(3000).Wait();
        });

        public void SelectNoRecordUnitTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Unit Table Records", () =>
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                // Select the row based on index (starts from 1 in XPath)
                By rowLocator = By.XPath($"(//tr[contains(@class,'dhx')])[{recordNumber}]");

                IWebElement row = wait.Until(
                    SeleniumWaits.ElementToBeClickable(rowLocator));

                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView({block:'center'});", row);

                row.Click();
                Task.Delay(3000).Wait();
            });
        }

        public void ViewUnitRecord()
        {
            AllureLogger.LogStep("I view Unit record", () =>
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                // Selected unit row
                By selectedRowLocator = By.XPath("//tr[contains(@class,'rowselected')]");

                IWebElement selectedRow = wait.Until(
                    SeleniumWaits.ElementIsVisible(selectedRowLocator));

                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView({block:'center'});", selectedRow);

                // Right-click selected unit row
                Actions actions = new Actions(driver);
                actions.ContextClick(selectedRow).Perform();

                // Best locator: dynamic id-safe + exact View Info text
                By viewInfoLocator = By.XPath(
                    "//tr[contains(@id,'viewinfoservice')]//div[contains(@class,'sub_item_text') and normalize-space()='View Info']"
                );

                IWebElement viewInfoOption = wait.Until(driver =>
                {
                    var elements = driver.FindElements(viewInfoLocator);
                    return elements.FirstOrDefault(e => e.Displayed && e.Enabled);
                });

                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView({block:'center'});", viewInfoOption);

                viewInfoOption.Click();
            });
        }



        public void VerifyUnitRunNumber() =>
         AllureLogger.LogStep("I verify Unit Run Number", () =>
         {
            try
            {
               // Wait 5 seconds for the page or element to load
               Task.Delay(5000).Wait();

                // Find the Unit Run Number element by CSS selector
                var UnitRun = driver.FindElement(By.CssSelector("#mcb7f36f9-tb"));

               // Get the 'value' attribute of the element
               string UnitRunNumber = UnitRun.GetAttribute("value");

                // Check if the Unit Run Number is null or empty
                if (string.IsNullOrEmpty(UnitRunNumber))
                {
                   throw new Exception("Unit Run Number: Unit Run Number is empty or null.");
                }

               // Log success with the work order number
               Console.WriteLine("Success: Unit Run Number is " + UnitRunNumber);
            }
            catch (NoSuchElementException ex)
            {
               Console.WriteLine("Error: Unit Run Number element not found - " + ex.Message);
               throw;
            }
            catch (Exception ex)
            {
               Console.WriteLine("Error: " + ex.Message);
               throw;
            }
         });


        public string CopyField(string UnitRunNumber)
        {
            string value = string.Empty;

            AllureLogger.LogStep($"Copy [{UnitRunNumber}] value", () =>
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                // Dynamic locator for readonly textbox (run number field)
                By locator = By.XPath("//input[@type='text' and @readonly='readonly' and @maxlength='10']");

                IWebElement field = wait.Until(
                    SeleniumWaits.ElementIsVisible(locator));

                // ✅ Get value from 'value' attribute (not Text)
                value = field.GetAttribute("value");
            });

            return value;
        }

        private By GetLocatorByFieldName(string fieldName)
        {
            return fieldName switch
            {
                "Unit Run Number" => By.CssSelector("#mcb7f36f9-tb"),
                _ => throw new ArgumentException($"No locator defined for {fieldName}")
            };
        }

          public void PressDialogButtonOK() =>
        AllureLogger.LogStep("I press dialog button OK", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            // Robust locator using button text + class
            By okButtonLocator = By.XPath("//button[contains(@class,'pb') and normalize-space()='OK']");

            IWebElement okButton = wait.Until(
            SeleniumWaits.ElementToBeClickable(okButtonLocator));

            okButton.Click();
        });

        public void OpenApplicationDiagramsBRDF()
        {
            AllureLogger.LogStep("I Open Diagrams (BRDF)", () =>
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
                wait.Until(SeleniumWaits.ElementToBeClickable(
                    By.Id("menu0_BRDF_MODULE_sub_changeapp_BRDFDIAGRAM_a_tnode")));

                SafeActions.Click(
                    driver,
                    By.Id("menu0_BRDF_MODULE_sub_changeapp_BRDFDIAGRAM_a_tnode"),
                    "I Open Diagrams (BRDF)"
                );
                Task.Delay(10000).Wait();
            });
        }


         public void FilterTableDiagrams(string Diagrams) =>
        AllureLogger.LogStep($"I filter table Diagrams with '{Diagrams}'", () =>
        {
          By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:8\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
          IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(Diagrams);
          filterField.SendKeys(Keys.Enter);
        });

        public void SelectNoRecordDiagramsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Diagrams Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Diagrams Table Records");
                Task.Delay(8000).Wait();
            });

        }

           public void SelectFilterTableOption() =>
         AllureLogger.LogStep("I select Filter Table option", () =>
            SafeActions.Click(driver, By.Id("md6470200-lb2"),
                             "I select Filter Table option"));

        public void SetDiagramId(string UnitRunNumber)
        {
            AllureLogger.LogStep("I enter Diagram ID", () =>
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                // ✅ Use stable ID pattern + class (based on your element)
                By diagramIdLocator = By.XPath(
                    "//input[contains(@id,'_tfrow_[C:1]_txt-tb') and contains(@class,'tablefilterfield') and @type='text']"
                );

                IWebElement field = wait.Until(d =>
                {
                    var el = d.FindElements(diagramIdLocator)
                              .FirstOrDefault(e => e.Displayed && e.Enabled);
                    return el;
                });

                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView({block:'center'});", field);

                field.Click();

                // ✅ Dojo-safe clear
                field.SendKeys(Keys.Control + "a");
                field.SendKeys(Keys.Delete);

                field.SendKeys(UnitRunNumber);
                field.SendKeys(Keys.Enter);
            });
        }

        public void SelectNoRecordDiagramIDRecordsToViewDetails(int recordNumber)
        {
            AllureLogger.LogStep(
                $"I Select No {recordNumber} Record From Diagrams ID records to view details",
                () =>
                {
                    int zeroBasedIndex = recordNumber - 1;

                    // Updated dynamic selector
                    string selector =
                        $"md6470200_tdrow_[C:0]_tgdet-ti[R:{zeroBasedIndex}]_img";

                    SafeActions.Click(
                        driver,
                        By.Id(selector),
                        $"I Select No {recordNumber} Record From Diagrams ID records to view details");

                    Task.Delay(5000).Wait();
                });
        }

        public void SelectNoRecordDiagramLegsRecordsToViewDetails(int recordNumber)
        {
            AllureLogger.LogStep(
                $"I Select No {recordNumber} Record From Diagrams ID records to view details",
                () =>
                {
                    int zeroBasedIndex = recordNumber - 1;

                    // Updated dynamic selector
                    string selector =
                        $"m8b79dfae_tdrow_[C:0]_tgdet-ti[R:{zeroBasedIndex}]_img";

                    SafeActions.Click(
                        driver,
                        By.Id(selector),
                        $"I Select No {recordNumber} Record From Diagrams ID records to view details");

                    Task.Delay(5000).Wait();
                });
        }


         public void TakeScreenshotOfDiagramLinesDetails() =>
        AllureLogger.LogStep("Capture Screenshot for UAT-TAS-012SC02", () =>
        {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-012SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-012SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
        });

            public void FilterTableMXRMAILLIST(string MXRMAILLIST) =>
        AllureLogger.LogStep($"I filter table MXRMAILLIST with '{MXRMAILLIST}'", () =>
        {
            // Step 1: Click to activate filter
            By clickLocator = By.Id("m26aedc28-lb2");
            WebDriverWait clickWait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            IWebElement clickElement = clickWait.Until(SeleniumWaits.ElementToBeClickable(clickLocator));
            clickElement.Click();

            // Step 2: Enter value into filter field
            By filterFieldLocator = By.CssSelector("#m26aedc28_tfrow_\\[C\\:2\\]_txt-tb");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(MXRMAILLIST);
            filterField.SendKeys(Keys.Enter);
        });


        public void SelectNoRecordFromMXRMAILLISTTableRecords(int recordNumber)
        {
            AllureLogger.LogStep(
                $"I select no.{recordNumber} record from MXRMAILLIST table records",
                () =>
                {
                    int zeroBasedIndex = recordNumber - 1;

                    // Updated dynamic selector
                    string selector =
                        $"m26aedc28_tdrow_[C:0]_tgdet-ti[R:{zeroBasedIndex}]_img";

                    SafeActions.Click(
                        driver,
                        By.Id(selector),
                        $"I select no.{recordNumber} record from MXRMAILLIST table records");

                    Task.Delay(5000).Wait();
                });
        }


         public void IAddEmailDetails(string Email) =>
        AllureLogger.LogStep($"I add Email details '{Email}'", () =>
        {
                      
            By filterFieldLocator = By.CssSelector("#m745d0874-tb");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            IWebElement filterField = wait.Until(SeleniumWaits.ElementToBeClickable(filterFieldLocator));
            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(Email);
            
        });


        public void TakeScreenshotOfAddedEmailDetails() =>
        AllureLogger.LogStep("Capture Screenshot for UAT-TAS-012SC03", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-012SC03.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-012SC03_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });


        public void UncheckedTheNeedsCheckingBox() =>
        AllureLogger.LogStep("I Unchecked the Needs Checking box", () =>
           SafeActions.Click(driver, By.Id("m6ef0bfaf_tdrow_[C:6]_checkbox-cb[R:0]_img"),
                            "I Unchecked the Needs Checking box"));


        public void TakeScreenshotOfUncheckedTheNeedsCheckingBox() =>
       AllureLogger.LogStep("Capture Screenshot for UAT-TAS-012SC04", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-012SC04.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-012SC04_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

         public void checkedTheNeedsCheckingBox() =>
       AllureLogger.LogStep("I Unchecked the Needs Checking box", () =>
         SafeActions.Click(driver, By.Id("m6ef0bfaf_tdrow_[C:6]_checkbox-cb[R:0]_img"),
                          "I Unchecked the Needs Checking box"));

         public void TakeScreenshotOfCheckedTheNeedsCheckingBox() =>
       AllureLogger.LogStep("Capture Screenshot for UAT-TAS-012SC05", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-012SC05.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-012SC05_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void TakeScreenshotOfModifyEmailDetails() =>
      AllureLogger.LogStep("Capture Screenshot for UAT-TAS-012SC06", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-012SC06.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-012SC06_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });






    }





}




