using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OpenQA.Selenium;
using Reqnroll;
using Table = Reqnroll.Table;


namespace GTR_AUTOMATED.StepDefinitions
{
    [Binding]
    public sealed class CMWorkOrderStepDefinitions
    {
        private readonly IWebDriver driver;
        private readonly CMWOPOM pom;

        public CMWorkOrderStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new CMWOPOM(driver);
        }
           

        [Given("I open application Work Order Tracking \\(BRDA)")]
        public void GivenIOpenApplicationWorkOrderTrackingBRDA()
        {
            AllureLogger.LogStep("Open Work Order Tracking (BRDA)",
                pom.OpenGoToMenu);   
            AllureLogger.LogStep("Open Work Order Menu",
                pom.OpenWorkOrderMenu);
            AllureLogger.LogStep("Launch Tracking screen",
                pom.OpenWorkOrderTrackingBRDA);
        }

        [Given("I select create new record")]
        public void GivenISelectCreateNewRecord()
        {
            AllureLogger.LogStep("Click [New Record]",
                 pom.ClickCreateNewRecord);
        }

        
        [Given("I choose Select Value from Detail Menu of Location field")]
        public void GivenIChooseSelectValueFromDetailMenuOfLocationField()
        {
            AllureLogger.LogStep("Detail Menu Of Location Field",
                 pom.DetailMenuOfLocationField);
            AllureLogger.LogStep("Select Value Option",
                pom.SelectValueOption);
        }
        
        [Given("I filter table Location:")]
        public void GivenIFilterTableLocation(Table table)
        {
            string location = table.Rows[0]["Location"];
            AllureLogger.LogStep($"I filter table Location: {location}", () =>
                pom.FilterTableLocation(location));
        }

        [Given("I select no. {int} from Location table records")]
        public void GivenISelectNo_FromLocationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Location table records",
              () => pom.SelectNoFromLocationTableRecords(recordNumber));
        }
                      

        [Given("I select no. {int} record from Location table records")]
        public void GivenISelectNo_RecordFromLocationTableRecords(int recordNumber)
        {

            AllureLogger.LogStep($"I select no.{recordNumber} record from Location table records",
              () => pom.ISelectNo_RecordFromLocationTableRecords(recordNumber));
        }

        [Given("I open Select Value lookup for Work Type field")]
        public void GivenIOpenSelectValueLookupForWorkTypeField()
        {
            AllureLogger.LogStep("I Select Value lookup for Work Type field",
                pom.SelectValueLookupForWorkTypeField);
        }

        [Given("I filter table Work Type:")]
        public void GivenIFilterTableWorkType(Table table)
        {
            string WorkType = table.Rows[0]["Type"];
            AllureLogger.LogStep($"I filter table Work Type: {WorkType}", () =>
                pom.FilterTableWorkType(WorkType));
        }

        [Given("I select no. {int} from Work Type table records")]
        public void GivenISelectNo_FromWorkTypeTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Work Type table records",
            () => pom.SelectNoFromWorkTypeTableRecords(recordNumber));
        }



        [Given("I choose Select Value from Detail Menu of Repair Facility")]
        public void GivenIChooseSelectValueFromDetailMenuOfRepairFacility()
        {
            AllureLogger.LogStep("Detail Menu Of Repair Facility",
                  pom.DetailMenuOfRepairFacility);
            AllureLogger.LogStep("Select Value Option Of Repair Facility",
                pom.SelectValueOptionOfRepairFacility);
        }

        [Given("I filter table Repair Facility:")]
        public void GivenIFilterTableRepairFacility(Table table)
        {
            string RepairFacility = table.Rows[0]["Repair Facility"];
            AllureLogger.LogStep($"I filter table Repair Facility: {RepairFacility}", () =>
                pom.FilterTableRepairFacility(RepairFacility));
        }
                      

        [Given("I select no. {int} record from Repair Facility table records")]
        public void GivenISelectNo_RecordFromRepairFacilityTableRecords(int p0)
        {
            AllureLogger.LogStep($"I select no.{p0} record from Location table records",
              () => pom.ISelectNo_RecordFromRepairFacilityTableRecords(p0));
        }

        [Given("I open Select Value lookup for Priority field")]
        public void GivenIOpenSelectValueLookupForPriorityField()
        {
            AllureLogger.LogStep("I Select Value lookup for Work Type field",
               pom.OpenSelectValueLookupForPriorityField);
        }

        [Given("I filter table Priority field:")]
        public void GivenIFilterTablePriorityField(Table table)
        {
            string RepairFacility = table.Rows[0]["Value"];
            AllureLogger.LogStep($"I filter table Priority: {RepairFacility}", () =>
                pom.FilterTablePriorityField(RepairFacility));
        }
                       

        [Given("I select no. {int} record from Priority table records")]
        public void GivenISelectNo_RecordFromPriorityTableRecords(int p0)
        {
            AllureLogger.LogStep($"I select no.{p0} record from Priority table records",
             () => pom.GivenISelectPriority(p0));
        }
        
        [Given("I Scheduled Start Date to today's date")]
        public void GivenIScheduledStartDateToTodaysDate()
        {
            AllureLogger.LogStep("I Set Scheduled Start",
                pom.SetScheduledStart);
        }


        [Given("I save CM record")]
        public void GivenISaveCMRecord()
        {
            AllureLogger.LogStep("I Save CM Record",
               pom.ISaveCMRecord);
        }

        [Given("I verify CM work order generated")]
        public void GivenIVerifyCMWorkOrderGenerated()
        {

            AllureLogger.LogStep("I Verify Generated Work Order Number",
               pom.VerifyCMWorkOrderGenerated);
        }


        [Given("I verify generated work order number")]
        public void GivenIVerifyGeneratedWorkOrderNumber()
        {
            AllureLogger.LogStep("I Verify Generated Work Order Number",
               pom.VerifyGeneratedWorkOrderNumber);
        }

        [Given("I take screenshot of Assigning a CM Work Order Test Scenario one")]
        public void GivenITakeScreenshotOfAssigningACMWorkOrderTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Assigning a CM Work Order Test Scenario one",
               pom.TakeScreenshotOfAssigningACMWorkOrderTestScenarioOne);
        }

        [Given("I take screenshot of Assigning a CM Work Order Test Scenario two")]
        public void GivenITakeScreenshotOfAssigningACMWorkOrderTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Assigning a CM Work Order Test Scenario two",
               pom.TakeScreenshotOfAssigningACMWorkOrderTestScenariotwo);
        }


        [Given("I take screenshot of Create a CM Work Order test")]
        public void GivenITakeScreenshotOfCreateACMWorkOrderTest()
        {
            AllureLogger.LogStep("I Take Screenshot Of Create A CM Work Order Test",
                pom.ITakeScreenshotOfCreateACMWorkOrderTest);
        }


        // Assigning a CM Work Order Step Definitions 

        
        [Given("I open application Work Order Tracking BRDA from Favorite Menu")]
        public void GivenIOpenApplicationWorkOrderTrackingBRDAFromFavoriteMenu()
        {
            AllureLogger.LogStep("I open application Work Order Tracking BRDA from Favorite Menu",
               pom.IOpenApplicationWorkOrderTrackingBRDAFromFavoriteMenu);
        }
                                

        [Given("I select no. {int} record from CM Work Order table records")]
        public void GivenISelectNo_RecordFromCMWorkOrderTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from CM Work Order table records",
              () => pom.ISelectCMWorkOrderFromTableRecords(recordNumber));
        }


        [Given("I press route the workflow button")]
        public void GivenIPressRouteTheWorkflowButton()
        {
            AllureLogger.LogStep("I press route the workflow button",
              pom.PressRouteTheWorkflowButton);
        }

        [Given(@"I set \(Radio\) field to ""(.*)""")]
        public void GivenISetRadioFieldTo(string radioValue)
        {
            AllureLogger.LogStep(
                $"I set (Radio) field to {radioValue}",
                () => pom.SetRadioField(radioValue));
        }

                
        [Given("I select dialog button ok")]
        public void GivenISelectDialogButtonOk()
        {
            AllureLogger.LogStep("I select dialog button ok",
               pom.ISelectDialogButtonOk);
        }
               
        [Given("I select Ok dialog button")]
        public void GivenISelectOkDialogButton()
        {
            AllureLogger.LogStep("I select dialog button ok",
              pom.ISelectOkDialogButton);
        }

        [Given("I go to Assignments Tab")]
        public void GivenIGoToAssignmentsTab()
        {
            AllureLogger.LogStep("I go to Assignments Tab",
             pom.IGoToAssignmentsTab);
        }

        [Given("I add new row in Assignments Tab")]
        public void GivenIAddNewRowInAssignmentsTab()
        {
            AllureLogger.LogStep("I add new row in Assignments Tab",
             pom.AddNewRowInAssignmentsTab);
        }

        [Given("I open Select Value lookup for Labor field")]
        public void GivenIOpenSelectValueLookupForLaborField()
        {
            AllureLogger.LogStep("I open Select Value lookup for Labor field",
             pom.OpenSelectValueLookupForLaborField);
        }

        [Given("I filter table Labor:")]
        public void GivenIFilterTableLabor(Table table)
        {
            string Labor = table.Rows[0]["Labor"];
            AllureLogger.LogStep($"I filter table Labor: {Labor}", () =>
                pom.FilterTableLabor(Labor));
        }
        
        [Given("I select no. {int} record from Labor table records")]
        public void GivenISelectNo_RecordFromLaborTableRecords(int p1)
        {
            AllureLogger.LogStep($"I select no.{p1} record from Labor table records",
              () => pom.ISelectLabor(p1));
        }

        [Given("I pree Ok dialog system message button")]
        public void GivenIPreeOkDialogSystemMessageButton()
        {
            AllureLogger.LogStep("I pree Ok dialog system message button",
                pom.IPreeOkDialogSystemMessageButton);
        }


        [Given("I save record")]
        public void GivenISaveRecord()
        {
            AllureLogger.LogStep("I Save CM Record",
                pom.ISaveRecord);
        }

        [Given("I verify Rejecting an CM Work Order generated number")]
        public void GivenIVerifyRejectingAnCMWorkOrderGeneratedNumber()
        {
            AllureLogger.LogStep("I verify Rejecting an CM Work Order generated number",
               pom.VerifyRejectingAnCMWorkOrderGeneratedNumber);
        }


        [Given("I verify assigned work order details")]
        public void GivenIVerifyAssignedWorkOrderDetails()
        {
            AllureLogger.LogStep("I Verify Generated Work Order Number",
               pom.VerifyAssignedWorkOrderDetails);
        }



        [Given("I take screenshot of Assigning a CM Work Order")]
        public void GivenITakeScreenshotOfAssigningACMWorkOrder()
        {
            AllureLogger.LogStep("I Take Screenshot Of Create A CM Work Order Test",
                pom.ITakeScreenshotOfAssigningACMWorkOrder);
        }


        [Given("I take screenshot of Assigning a CM Work Order test")]
        public void GivenITakeScreenshotOfAssigningACMWorkOrderTest()
        {
            AllureLogger.LogStep("I Take Screenshot Of Create A CM Work Order Test",
                pom.ITakeScreenshotOfAssigningACMWorkOrderTest);
        }

        [Given("I take screenshot of Creating a Found it Fixed it Work Order test Scenario one")]
        public void GivenITakeScreenshotOfCreatingAFoundItFixedItWorkOrderTestScenarioone()
        {
            AllureLogger.LogStep("I take screenshot of Creating a Found it Fixed it Work Order test Scenario one",
               pom.TakeScreenshotOfCreatingAFoundItFixedItWorkOrderTestScenarioone);
        }


        [Given("I take screenshot of Creating a Found it Fixed it Work Order test Scenario two")]
        public void GivenITakeScreenshotOfCreatingAFoundItFixedItWorkOrderTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Creating a Found it Fixed it Work Order test Scenario two",
                pom.TakeScreenshotOfCreatingAFoundItFixedItWorkOrderTestScenarioTwo);
        }

        [Then("I take screenshot of Creating a Found it Fixed it Work Order test Scenario three")]
        public void ThenITakeScreenshotOfCreatingAFoundItFixedItWorkOrderTestScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Creating a Found it Fixed it Work Order test Scenario three",
                pom.TakeScreenshotOfCreatingAFoundItFixedItWorkOrderTestScenariothree);
        }



        // Creating a Follow On Work Order Step Definitions


        [Given("I take screenshot of Creating a Follow On Work Order Scenario one")]
        public void GivenITakeScreenshotOfCreatingAFollowOnWorkOrderScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Creating a Follow On Work Order Scenario one",
                pom.TakeScreenshotOfCreatingAFollowOnWorkOrderScenarioOne);
        }

        [Given("I take screenshot of Creating a Follow On Work Order Scenario two")]
        public void GivenITakeScreenshotOfCreatingAFollowOnWorkOrderScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Creating a Follow On Work Order Scenario two",
                pom.TakeScreenshotOfCreatingAFollowOnWorkOrderScenarioTwo);
        }

        [Given("I take screenshot of Creating a Follow On Work Order Scenario three")]
        public void GivenITakeScreenshotOfCreatingAFollowOnWorkOrderScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Creating a Follow On Work Order Scenario three",
                pom.TakeScreenshotOfCreatingAFollowOnWorkOrderScenarioThree);
        }



        // Creating a Found it Fixed it Work Order Step Definitions


        [Given("I open application Quick Work Order Tracking \\(BRDA)")]
        public void GivenIOpenApplicationQuickWorkOrderTrackingBRDA()
        {
            AllureLogger.LogStep("Open Work Order Tracking (BRDA)",
               pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Work Order Menu",
                pom.OpenWorkOrderMenu);
            AllureLogger.LogStep("Launch Tracking screen",
                pom.QuickWorkOrderTrackingBRDA);
        }

        [Given("I filter table Quick Work Order:")]
        public void GivenIFilterTableQuickWorkOrder(Table table)
        {
            string description = table.Rows[0]["Description"];
            string status = table.Rows[0]["Status"];
            string workType = table.Rows[0]["Work Type"];
            pom.FilterTableQuickWorkOrder(description, status, workType);
        }

        [Given("I select no. {int} record from Quick Work Order table records")]
        public void GivenISelectNo_RecordFromQuickWorkOrderTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Quick Work Order table records",
              () => pom.SelectNoRecordFromQuickWorkOrderTableRecords(recordNumber));
        }
                      

        [Given("I select Ok button")]
        public void GivenISelectOkButton()
        {
            AllureLogger.LogStep("I select Ok button",
                pom.SelectOkButton);
        }

        [Given("I select action")]
        public void GivenISelectAction()
        {
            AllureLogger.LogStep("I select action",
                pom.SelectAction);
        }

        [Given("I select Create Work Order")]
        public void GivenISelectCreateWorkOrder()
        {
            AllureLogger.LogStep("I select Create Work Order",
                pom.SelectCreateWorkOrder);
        }

        [Given("I Select Value lookup for Work Type field")]
        public void GivenISelectValueLookupForWorkTypeField()
        {
            AllureLogger.LogStep("I Select Value lookup for Work Type",
                pom.SelectValueLookupForWorkType);
        }

        [Given("I filter table Follow on Work Type:")]
        public void GivenIFilterTableFollowOnWorkType(Table table)
        {
            string WorkType = table.Rows[0]["Type"];
            AllureLogger.LogStep($"I filter table Follow on Work Type: {WorkType}", () =>
                pom.FilterTableFollowOnWorkType(WorkType));
        }
                    

        [Given("I select no. {int} record from Work Type table records")]
        public void GivenISelectNo_RecordFromWorkTypeTableRecords(int recordNumber)
        {

            AllureLogger.LogStep($"I select no.{recordNumber} record from Work Type table records",
             () => pom.SelectNoRecordFromWorkTypeTableRecords(recordNumber));
                        
        }


        [Given("I go to labour Tab")]
        public void GivenIGoToLabourTab()
        {
            AllureLogger.LogStep("I go to labour Tab",
                pom.GoToLabourTab);
        }

        [Given("I press new row under Labor Tab")]
        public void GivenIPressNewRowUnderLaborTab()
        {
            AllureLogger.LogStep("I press new row under Labor Tab",
                pom.PressNewRowUnderLaborTab);
        }

        [Given("I Select Value from Detail Menu of Labor field")]
        public void GivenISelectValueFromDetailMenuOfLaborField()
        {
            AllureLogger.LogStep("I Select Value from Detail Menu of Labor field",
                pom.SelectValueFromDetailMenuOfLaborField);
        }
        

        [Given("I select no. {int} record from table records")]
        public void GivenISelectNo_RecordFromTableRecords(int p0)
        {
            AllureLogger.LogStep($"I select no.{p0} record from Labor table records",
              () => pom.SelectNo_RecordFromTableRecords(p0));
        }

        [Given("I select Start and End time")]
        public void GivenISelectStartAndEndTime()
        {
            AllureLogger.LogStep("I select Start and End time",
              pom.SelectStartAndEndTime);
        }
              

        [Then("I save record")]
        public void ThenISaveRecord()
        {
            AllureLogger.LogStep("I save record",
               pom.SaveRecord);
        }


        [Then("I go to failure reporting tab")]
        public void ThenIGoToFailureReportingTab()
        {
            AllureLogger.LogStep("I go to failure reporting tab",
              pom.GoToFailureReportingTab);
        }

        [Then("I press the button select Failure Codes")]
        public void ThenIPressTheButtonSelectFailureCodes()
        {
            AllureLogger.LogStep("I press the button select Failure Codes",
              pom.PressTheButtonSelectFailureCodes);
        }

        [Then("I filter table Follow on Failure Codes:")]
        public void ThenIFilterTableFollowOnFailureCodes(Table table)
        {
            string FailureCodes = table.Rows[0]["Failure Codes"];
            AllureLogger.LogStep($"I filter table Failure Codes: {FailureCodes}", () =>
                pom.FilterTableFollowOnFailureCodes(FailureCodes));
        }

        
        [Then("I select faliure codes")]
        public void ThenISelectFaliureCodes()
        {
            AllureLogger.LogStep("I select faliure codes",
             pom.SelectFaliureCodes);
        }

        [Then("I select problem codes")]
        public void ThenISelectProblemCodes()
        {
            AllureLogger.LogStep("I select problem codes",
             pom.SelectProblemCodes);
        }

        [Then("I select cause codes")]
        public void ThenISelectCauseCodes()
        {
            AllureLogger.LogStep("I select cause codes",
             pom.SelectCauseCodes);
        }

        [Then("I select remedy codes")]
        public void ThenISelectRemedyCodes()
        {
            AllureLogger.LogStep("I select remedy codes",
            pom.SelectRemedyCodes);
        }

        [Then("I go to Log tab")]
        public void ThenIGoToLogTab()
        {
            AllureLogger.LogStep("I go to Log tab",
           pom.GoToLogtab);
        }
              

        [Then("I press add new row under Log")]
        public void ThenIPressAddNewRowUnderLog()
        {
            AllureLogger.LogStep("I press add new row under Log",
           pom.PressAddNewRowUnderLog);
        }
        
        [Then("I press route the workflow button")]
        public void ThenIPressRouteTheWorkflowButton()
        {
            AllureLogger.LogStep("I press route the workflow button",
              pom.PressRouteTheWorkflowButton);
        }

        
        [Then("I press ok dialog button")]
        public void ThenIPressOkDialogButton()
        {
            AllureLogger.LogStep("I press ok dialog button",
              pom.PressOkDialogButton);
        }

        

        //Creating a Found it Fixed it Work Order Step Definitions


       
        [Given("I take screenshot of Creating a Found it Fixed it Work Order Scenario one")]
        public void GivenITakeScreenshotOfCreatingAFoundItFixedItWorkOrderScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Creating a Found it Fixed it Work Order test Scenario one",
                pom.TakeScreenshotOfCreatingAFoundItFixedItWorkOrderScenarioOne);
        }

        [Given("I filter table CM Work Order:")]
        public void GivenIFilterTableCMWorkOrder(Table table)
        {
            string description = table.Rows[0]["Description"];
            string status = table.Rows[0]["Status"];
            pom.FilterTableCMWorkOrder(description, status);
        }
                     

        [Given("I take screenshot of Creating a Found it Fixed it Work Order Scenario two")]
        public void GivenITakeScreenshotOfCreatingAFoundItFixedItWorkOrderScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Creating a Found it Fixed it Work Order test Scenario two",
               pom.TakeScreenshotOfCreatingAFoundItFixedItWorkOrderScenariotwo);
        }

        [Given("I go to failure reporting tab")]
        public void GivenIGoToFailureReportingTab()
        {
            AllureLogger.LogStep("I go to failure reporting tab",
               pom.GoToFailureReportingTab);
        }

        [Given("I press the button select Failure Codes")]
        public void GivenIPressTheButtonSelectFailureCodes()
        {
            AllureLogger.LogStep("I press the button select Failure Codes",
              pom.PressTheButtonSelectFailureCodes);
        }

        [Given("I filter table Follow on Failure Codes:")]
        public void GivenIFilterTableFollowOnFailureCodes(Table table)
        {
            string FailureCodes = table.Rows[0]["Failure Codes"];
            AllureLogger.LogStep($"I filter table Failure Codes: {FailureCodes}", () =>
                pom.FilterTableFollowOnFailureCodes(FailureCodes));
        }
                       

        [Given("I select faliure codes")]
        public void GivenISelectFaliureCodes()
        {
            AllureLogger.LogStep("I select faliure codes",
             pom.SelectFaliureCodes);
        }

        [Given("I select problem codes")]
        public void GivenISelectProblemCodes()
        {
            AllureLogger.LogStep("I select problem codes",
             pom.SelectProblemCodes);
        }

        [Given("I select cause codes")]
        public void GivenISelectCauseCodes()
        {
            AllureLogger.LogStep("I select cause codes",
            pom.SelectCauseCodes);
        }

        [Given("I select remedy codes")]
        public void GivenISelectRemedyCodes()
        {
            AllureLogger.LogStep("I select remedy codes",
            pom.SelectRemedyCodes);
        }

        [Given("I go to Log tab")]
        public void GivenIGoToLogTab()
        {
            AllureLogger.LogStep("I go to Log tab",
            pom.GoToLogtab);
        }
               

        [Given("I press add new row under Log")]
        public void GivenIPressAddNewRowUnderLog()
        {
            AllureLogger.LogStep("I press add new row under Log",
            pom.PressAddNewRowUnderLog);
        }

        [Given("I enter following data:")]
        public void GivenIEnterFollowingData(Table table)
        {
            string Summary = table.Rows[0]["Summary"];
            string Details = table.Rows[0]["Details"];
            pom.EnterFollowingData(Summary, Details);
        }

        [Given("I filter table work Log:")]
        public void GivenIFilterTableWorkLog(Table table)
        {
            string workLogType = table.Rows[0]["Value"];
            AllureLogger.LogStep($"I filter table work Log Type: {workLogType}", () =>
                pom.FilterTableWorkLog(workLogType));
        }

        [Given("I select no. {int} record from work Log table records")]
        public void GivenISelectNo_RecordFromWorkLogTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Work Type table records",
             () => pom.SelectNoRecordFromWorkLogTableRecords(recordNumber));
        }



        [Given("I open Select Value lookup of Type")]
        public void GivenIOpenSelectValueLookupOfType()
        {
            AllureLogger.LogStep("I open Select Value lookup of Type",
                pom.SelectValueLookupOfType);
        }
               
        [Given("I Select UPDATE")]
        public void GivenISelectUPDATE()
        {
            AllureLogger.LogStep("I Select Drop Down Menu Button",
                  pom.DropdownMenu);
            AllureLogger.LogStep("I Select Drop Down Menu Button",
                pom.SelectUPDATE);
        }

        [Given("Work log Status field has value UPDATE")]
        public void GivenWorkLogStatusFieldHasValueUPDATE()
        {
            AllureLogger.LogStep("Work log Status field has value UPDATE",
               pom.LogStatusFieldHasValueUPDATE);
        }
        

        [Given("I verify COMP-WREV Status")]
        public void GivenIVerifyCOMP_WREVStatus()
        {
            AllureLogger.LogStep("I verify COMP-WREV Status",
              pom.VerifyCOMPWREVStatus);
        }

        [Given("I take screenshot of Creating a Found it Fixed it Work Order Scenario three")]
        public void GivenITakeScreenshotOfCreatingAFoundItFixedItWorkOrderScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Creating a Found it Fixed it Work Order test Scenario three",
                pom.TakeScreenshotOfCreatingAFoundItFixedItWorkOrderScenariothree);
        }


        [Given("I take screenshot of Creating a Found it Fixed it Work Order test Scenario three")]
        public void GivenITakeScreenshotOfCreatingAFoundItFixedItWorkOrderTestScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Creating a Found it Fixed it Work Order test Scenario three",
                pom.TakeScreenshotOfCreatingAFoundItFixedItWorkOrderScenariothree);
        }



        // Completing a CM Work Order for Review Step Definitions


        [Given("I take screenshot of Completing a CM Work Order for Review test Scenario two")]
        public void GivenITakeScreenshotOfCompletingACMWorkOrderForReviewTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Completing a CM Work Order for Review test Scenario two",
                pom.TakeScreenshotOfCompletingACMWorkOrderForReviewTestScenarioTwo);
        }

        [Given("I take screenshot of Completing a CM Work Order for Review test Scenario one")]
        public void GivenITakeScreenshotOfCompletingACMWorkOrderForReviewTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Completing a CM Work Order for Review test Scenario one",
                pom.TakeScreenshotOfCompletingACMWorkOrderForReviewTestScenarioone);
        }

        [Given("I filter table CM:")]
        public void GivenIFilterTableCM(Table table)
        {
            string description = table.Rows[0]["Description"];
            string status = table.Rows[0]["Status"];
            string workType = table.Rows[0]["Work Type"];
            pom.FilterTableCM(description, status, workType);
        }
                     

        [Given("I press the button Ok")]
        public void GivenIPressTheButtonOk()
        {
            AllureLogger.LogStep("I press the button Ok",
               pom.PressTheButtonOk);
        }

        [Given("I press the button Close")]
        public void GivenIPressTheButtonClose()
        {
            AllureLogger.LogStep("I press the button Close",
               pom.PressTheButtonClose);
        }

        [Given("I go to actuals Tab")]
        public void GivenIGoToActualsTab()
        {
            AllureLogger.LogStep("I go to actuals Tab",
               pom.GoToActualsTab);
        }

        [Given("I select new row under labor section")]
        public void GivenISelectNewRowUnderLaborSection()
        {
            AllureLogger.LogStep("I select new row under labor section",
               pom.SelectNewRowUnderLaborSection);
        }

        [Given("I choose select value from detail menu of labor field")]
        public void GivenIChooseSelectValueFromDetailMenuOfLaborField()
        {
            AllureLogger.LogStep("I select value of labor field",
               pom.SelectValueOfLaborField);

            AllureLogger.LogStep("I select detail menu of labor field",
               pom.ChooseDetailMenuOfLaborField);
        }

        [Given("I filter table actuals labor:")]
        public void GivenIFilterTableActualsLabor(Table table)
        {
            string Labor = table.Rows[0]["Labor"];
            AllureLogger.LogStep($"I filter table actuals Labor: {Labor}", () =>
                pom.FilterTableActualsLabor(Labor));
        }


        [Given("I select no. {int} record from Labor table record")]
        public void GivenISelectNo_RecordFromLaborTableRecord(int p0)
        {
            AllureLogger.LogStep($"I select no.{p0} record from Labor table records",
              () => pom.SelectLabor(p0));
        }

        [Given("I set Start and End time")]
        public void GivenISetStartAndEndTime()
        {
            AllureLogger.LogStep("I select Start and End time",
             pom.ISetStartAndEndTime);
        }

        [Given("I go to Failure Reporting")]
        public void GivenIGoToFailureReporting()
        {
            AllureLogger.LogStep("I go to failure reporting",
              pom.GoToFailureReporting);
        }

        [Given("I press dialog button Select Failure Codes")]
        public void GivenIPressDialogButtonSelectFailureCodes()
        {
            AllureLogger.LogStep("I press the button select Failure Codes",
             pom.PressDialogButtonSelectFailureCodes);
        }

        [Given("I filter table Failure Codes:")]
        public void GivenIFilterTableFailureCodes(Table table)
        {
            string FailureCodes = table.Rows[0]["Failure Codes"];
            AllureLogger.LogStep($"I filter table Failure Codes: {FailureCodes}", () =>
                pom.FilterTableFailureCodes(FailureCodes));
        }

        [Given("I select Faliure Informations")]
        public void GivenISelectFaliureInformations()
        {
            AllureLogger.LogStep("I select Failure Codes",
           pom.FailureCodes);

            AllureLogger.LogStep("I select problem codes",
            pom.ProblemCodes);

            AllureLogger.LogStep("I select cause codes",
             pom.CauseCodes);

            AllureLogger.LogStep("I select remedy codes",
           pom.RemedyCodes);
        }

        [Given("I go to tab Log")]
        public void GivenIGoToTabLog()
        {
            AllureLogger.LogStep("I go to Log tab",
              pom.GoToTabLog);
        }


        [Given("I press add new row button under Log section")]
        public void GivenIPressAddNewRowButtonUnderLogSection()
        {
            AllureLogger.LogStep("I press add new row under Log",
            pom.AddNewRowButtonUnderLogSection);
        }
        
        [Then("I enter following data:")]
        public void ThenIEnterFollowingData(Table table)
        {
            string Summary = table.Rows[0]["Summary"];
            string Details = table.Rows[0]["Details"];
            pom.EnterFollowingData(Summary, Details);
        }
                      

        [Then("I press the button Ok")]
        public void ThenIPressTheButtonOk()
        {
            AllureLogger.LogStep("I press ok dialog button",
               pom.IPressTheButtonOk);
        }

        [Given("work order Status field has value COMP-WREV")]
        public void GivenWorkOrderStatusFieldHasValueCOMP_WREV()
        {
            AllureLogger.LogStep("I verify COMP-WREV Status",
               pom.WorkOrderStatusFieldHasValueCOMPWREV);
        }


        [Given("I take screenshot of Completing a CM Work Order for Review test Scenario three")]
        public void GivenITakeScreenshotOfCompletingACMWorkOrderForReviewTestScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Completing a CM Work Order for Review test Scenario three",
               pom.TakeScreenshotOfCompletingACMWorkOrderForReviewTestScenarioThree);
        }

      

        //Rejecting an CM Work Order Step Definitions


        [Given("I take screenshot of Rejecting an CM Work Order test Scenario one")]
        public void GivenITakeScreenshotOfRejectingAnCMWorkOrderTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Completing a CM Work Order for Review test Scenario three",
                pom.TakeScreenshotOfRejectingAnCMWorkOrderTestScenarioOne);
        }
                

        [Given("I take screenshot of Rejecting an CM Work Order test Scenario two")]
        public void GivenITakeScreenshotOfRejectingAnCMWorkOrderTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Completing a CM Work Order for Review test Scenario three",
                pom.TakeScreenshotOfRejectingAnCMWorkOrderTestScenariotwo);
        }

        [Given("I take screenshot of Rejecting an CM Work Order test Scenario three")]
        public void GivenITakeScreenshotOfRejectingAnCMWorkOrderTestScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Completing a CM Work Order for Review test Scenario three",
                pom.TakeScreenshotOfRejectingAnCMWorkOrderTestScenariothree);
        }
               
    
        [Given("I press dialog button ok")]
        public void GivenIPressDialogButtonOk()
        {
            AllureLogger.LogStep("I select dialog button ok",
             pom.PressDialogButtonOk);
        }

        [Given("work order Status field has value INPRG-HOLD")]
        public void GivenWorkOrderStatusFieldHasValueINPRG_HOLD()
        {
            AllureLogger.LogStep("work order Status field has value INPRG-HOLD",
               pom.StatusFieldHasValueINPRG_HOLD);
        }

        [Given("I verify generated Rejectd work order number")]
        public void GivenIVerifyGeneratedRejectdWorkOrderNumber()
        {
            AllureLogger.LogStep("I verify generated Rejectd work order number",
               pom.VerifyGeneratedRejectdWorkOrderNumber);
        }

        [Given("I return to Maintainer Start Center")]
        public void GivenIReturnToMaintainerStartCenter()
        {
            AllureLogger.LogStep("I return to Maintainer Start Center",
             pom.ReturnToMaintainerStartCenter);
        }

        [Given("I take screenshot of Rejecting an CM Work Order test Scenario four")]
        public void GivenITakeScreenshotOfRejectingAnCMWorkOrderTestScenarioFour()
        {
            AllureLogger.LogStep("I take screenshot of Completing a CM Work Order for Review test Scenario four",
               pom.TakeScreenshotOfCompletingACMWorkOrderForReviewTestScenariofour);
        }





        //Approving an CM Work Order Step Definitions


        [Given("I take screenshot of Approving an CM Work Order test Scenario one")]
        public void GivenITakeScreenshotOfApprovingAnCMWorkOrderTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Approving an CM Work Order test Scenario one",
              pom.TakeScreenshotOfApprovingAnCMWorkOrderTestScenarioOne);
        }

        [Given("I verify Approving an CM Work Order generated number")]
        public void GivenIVerifyApprovingAnCMWorkOrderGeneratedNumber()
        {
            AllureLogger.LogStep("I verify Approving an CM Work Order generated number",
               pom.VerifyApprovingAnCMWorkOrderGeneratedNumber);
        }

        [Given("I take screenshot of Approving an CM Work Order test Scenario two")]
        public void GivenITakeScreenshotOfApprovingAnCMWorkOrderTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Approving an CM Work Order test Scenario two",
               pom.TakeScreenshotOfApprovingAnCMWorkOrderTestScenariotwo);
        }

        [Given("I take screenshot of Approving an CM Work Order test Scenario three")]
        public void GivenITakeScreenshotOfApprovingAnCMWorkOrderTestScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Approving an CM Work Order test Scenario three",
               pom.TakeScreenshotOfApprovingAnCMWorkOrderTestScenariothree);
        }
                     

        [Given("work order Status field has value COMP")]
        public void GivenWorkOrderStatusFieldHasValueCOMP()
        {
            AllureLogger.LogStep("work order Status field has value COMP",
              pom.WorkOrderStatusFieldHasValueCOMP);
        }

        [Given("I verify generated Approved work order number")]
        public void GivenIVerifyGeneratedApprovedWorkOrderNumber()
        {
            AllureLogger.LogStep("I verify generated Approved work order number",
                pom.IVerifyGeneratedApprovedWorkOrderNumber);
        }


        [Given("I take screenshot of Approving an CM Work Order test Scenario four")]
        public void GivenITakeScreenshotOfApprovingAnCMWorkOrderTestScenarioFour()
        {
            AllureLogger.LogStep("I take screenshot of Approving an CM Work Order test Scenario four",
                pom.TakeScreenshotOfApprovingAnCMWorkOrderTestScenarioFour);
        }



        //Automatic work order status transition to WMATL Step Definitions

        [Given("I open application Inventory")]
        public void GivenIOpenApplicationInventory()
        {
            AllureLogger.LogStep("Open [Go To] menu Bar",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Inventory menu",
                pom.OpenInventoryMenu);
            AllureLogger.LogStep("Launch application Inventory",
                pom.OpenApplicationInventory);
        }

        [Given("I filter table Inventory:")]
        public void GivenIFilterTableInventory(Table table)
        {
            string Item = table.Rows[0]["Inventory"];
            string storeroom = table.Rows[0]["storeroom"];


            pom.FilterTableInventor(Item, storeroom);
        }
                     

        [Given("I go to Team Leader Arising Tab")]
        public void GivenIGoToTeamLeaderArisingTab()
        {
            AllureLogger.LogStep("I go to Team Leader Arising Tab",
            pom.GoToTeamLeaderArisingTab);
        }

        [Given("I filter table Team Leader Arising Tab Work Type:")]
        public void GivenIFilterTableTeamLeaderArisingTabWorkType(Table table)
        {
            string WorkType = table.Rows[0]["Type"];
            AllureLogger.LogStep($"I filter table Team Leader Arising Tab Work Type: {WorkType}", () =>
                pom.FilterTableTeamLeaderArisingTabWorkType(WorkType));
        }

        [Given("I select CM Work Order from table records")]
        public void GivenISelectCMWorkOrderFromTableRecords()
        {
            AllureLogger.LogStep("I select CM Work Order from table records",
            pom.SelectCMWorkOrderFromTableRecords);
        }
               
        [Given("I go to tab Plan")]
        public void GivenIGoToTabPlan()
        {
            AllureLogger.LogStep("I go to tab Plan",
            pom.GoToTabPlan);
        }

        [Given("I go to tab materials")]
        public void GivenIGoToTabMaterials()
        {
            AllureLogger.LogStep("I go to tab materials",
            pom.GoToTabmaterials);
        }

        [Given("I press add new row under materials tab")]
        public void GivenIPressAddNewRowUnderMaterialsTab()
        {
            AllureLogger.LogStep("I press add new row under materials tab",
            pom.PressAddNewRowUnderMaterialsTab);
        }

        [Given("I choose Select Value from Detail Menu of Item field")]
        public void GivenIChooseSelectValueFromDetailMenuOfItemField()
        {
            
            AllureLogger.LogStep("Detail Menu Of Item field",
                 pom.ChooseSelectValueFromDetailMenuOfItemField);
            AllureLogger.LogStep("Select Value Option Of Item field",
                pom.SelectValueOptionOfItemfield);
        }

        [Given("I filter table Item:")]
        public void GivenIFilterTableItem(Table table)
        {
            string Item = table.Rows[0]["Item"];
            AllureLogger.LogStep($"I filter table Item: {Item}", () =>
                pom.FilterTableItem(Item));
        }
        

        [Given("I select no. {int} record from Item table records")]
        public void GivenISelectNo_RecordFromItemTableRecords(int p0)
        {
            AllureLogger.LogStep($"I select no.{p0} record from Item table records",
             () => pom.SelectNoRecordFromItemTableRecords(p0));
        }

        [Given("I choose Select Value from Detail Menu of Storeroom field")]
        public void GivenIChooseSelectValueFromDetailMenuOfStoreroomField()
        {
           
            AllureLogger.LogStep("Detail Menu Of Storeroom field",
                 pom.SelectDetailMenuOfStoreroomField);
            AllureLogger.LogStep("Select Value Option Of Storeroom field",
                pom.SelectValueOptionOfStoreroomfield);
        }

        [Given("I select no. {int} record from Storeroom table records")]
        public void GivenISelectNo_RecordFromStoreroomTableRecords(int p0)
        {
            AllureLogger.LogStep($"I select no.{p0} record from Storeroom table records",
             () => pom.SelectNoRecordFromStoreroomTableRecords(p0));
        }

        [Given("I set Direct Issue active")]
        public void GivenISetDirectIssueActive()
        {
            AllureLogger.LogStep("I set Direct Issue active",
           pom.SetDirectIssueActive);
        }
        
        [Given("I press ok dialog button")]
        public void GivenIPressOkDialogButton()
        {
            AllureLogger.LogStep("I press ok dialog button",
           pom.IPressOkDialogButton);
        }

        [Given("I verify Status field has value WMATL")]
        public void GivenIVerifyStatusFieldHasValueWMATL()
        {
            AllureLogger.LogStep("I verify Status field has value WMATL",
              pom.VerifyStatusFieldHasValueWMATL);
        }

        [Given("I verify generated WMATL work order number")]
        public void GivenIVerifyGeneratedWMATLWorkOrderNumber()
        {
            AllureLogger.LogStep("I verify generated WMATL work order number",
                pom.VerifyGeneratedWMATLWorkOrderNumber);
        }


        [Given("I take screenshot of Automatic work order status transition to WMATL test")]
        public void GivenITakeScreenshotOfAutomaticWorkOrderStatusTransitionToWMATLTest()
        {
            AllureLogger.LogStep("I take screenshot of Automatic work order status transition to WMATL test",
               pom.TakeScreenshotOfAutomaticWorkOrderStatusTransitionToWMATLTest);
        }






        //MWE Work Order Step Definitions




        [Given("I go to Plans tab")]
        public void GivenIGoToPlansTab()
        {
            AllureLogger.LogStep("I go to Plans tab",
            pom.GoToPlansTab);
        }

        [Given("I press add new row under Task for work order section")]
        public void GivenIPressAddNewRowUnderTaskForWorkOrderSection()
        {
            AllureLogger.LogStep("I press add new row under Task for work order section",
             pom.PressAddNewRowUnderTaskForWorkOrderSection);
        }

        [Given("I enter CM Task Description:")]
        public void GivenIEnterCMTaskDescription(Table table)
        {
            string TaskDescription = table.Rows[0]["Description"];
            AllureLogger.LogStep($"I enter Task Description: {TaskDescription}", () =>
                pom.EnterTaskDescription(TaskDescription));
        }

        [Given("I open Select Value lookup for Task Requires Tools or Comments field")]
        public void GivenIOpenSelectValueLookupForTaskRequiresToolsOrCommentsField()
        {
            AllureLogger.LogStep("I open Select Value lookup for Task Requires Tools or Comments field",
            pom.OpenSelectValueLookupForTaskRequiresToolsOrCommentsField);
        }

        [Given("I select Y")]
        public void GivenISelectY()
        {
            AllureLogger.LogStep("I select Y",
            pom.SelectY);
        }

        [Given("I choose Select Value from Detail Menu of Measurement Point field")]
        public void GivenIChooseSelectValueFromDetailMenuOfMeasurementPointField()
        {
            AllureLogger.LogStep("Detail Menu Of Measurement Point Field",
               pom.DetailMenuOfMeasurementPointField);
            AllureLogger.LogStep("Select Value Option of Measurement Point",
                pom.SelectValueOptionofMeasurementPointField);
        }

        [Given("I open Select Value lookup for Measurement Point field")]
        public void GivenIOpenSelectValueLookupForMeasurementPointField()
        {
            AllureLogger.LogStep("Detail Menu Of Measurement Point Field",
                 pom.DetailMenuOfMeasurementPointField);
        }
                       

        [Given("I filter table Measurement Point:")]
        public void GivenIFilterTableMeasurementPoint(Table table)
        {
            string MeasurementPoint = table.Rows[0]["Measurement Point"];
            AllureLogger.LogStep($"I filter table Measurement Point: {MeasurementPoint}", () =>
                pom.FilterTableMeasurementPoint(MeasurementPoint));
        }

        [Given("I select no. {int} record from Measurement Point table")]
        public void GivenISelectNo_RecordFromMeasurementPointTable(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Measurement Point table records",
             () => pom.SelectNoRecordFromMeasurementPointTable(recordNumber));
        }


        [Given("I go to Tab actuals")]
        public void GivenIGoToTabActuals()
        {
            AllureLogger.LogStep("I go to Tab actuals",
             pom.GoToTabActuals);
        }

        [Given("I select materials sub tab")]
        public void GivenISelectMaterialsSubTab()
        {
            AllureLogger.LogStep("I select materials sub tab",
             pom.SelectMaterialsSubTab);
        }

        [Given("I add new row in materials tab")]
        public void GivenIAddNewRowInMaterialsTab()
        {
            AllureLogger.LogStep("I add new row in materials tab",
            pom.AddNewRowInMaterialsTab);
        }

        [Given("I choose select value from detail menu of materials item field")]
        public void GivenIChooseSelectValueFromDetailMenuOfMaterialsItemField()
        {
            AllureLogger.LogStep("Detail Menu Of materials item Field",
                 pom.DetailMenuOfMaterialsItemField);
            AllureLogger.LogStep("Select Value Option of materials item",
                pom.SelectValueOptionofMaterialsItem);
        }

        [Given("I filter table item:")]
        public void GivenIFilterTableitem(Table table)
        {
            string item = table.Rows[0]["item"];
            AllureLogger.LogStep($"I filter table item: {item}", () =>
                pom.IFilterTableitem(item));
        }

        [Given("I select no. {int} from item table records")]
        public void GivenISelectNo_FromItemTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from item table records",
              () => pom.SelectNoFromItemTableRecords(recordNumber));
        }

        [Given("I choose select value from detail menu of materials storeroom field")]
        public void GivenIChooseSelectValueFromDetailMenuOfMaterialsStoreroomField()
        {
            AllureLogger.LogStep("Detail Menu Of materials storeroom Field",
                  pom.DetailMenuOfMaterialsstoreroomField);
            AllureLogger.LogStep("Select Value Option of materials storeroom",
                pom.SelectValueOptionofMaterialsstoreroom);
        }

        [Given("I filter storeroom:")]
        public void GivenIFilterStoreroom(Table table)
        {
            string storeroom = table.Rows[0]["storeroom"];
            AllureLogger.LogStep($"I filter table storeroom: {storeroom}", () =>
                pom.FilterStoreroom(storeroom));
        }

        [Given("I select no. {int} from materials storeroom table records")]
        public void GivenISelectNo_FromMaterialsStoreroomTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from materials storeroom table records",
               () => pom.SelectNoFromMaterialsStoreroomTableRecords(recordNumber));
        }

        [Given("I choose select value from detail menu of rotating asset field")]
        public void GivenIChooseSelectValueFromDetailMenuOfRotatingAssetField()
        {
            AllureLogger.LogStep("Detail Menu Of rotating asset Field",
                 pom.DetailMenuOfRotatingAssetField);
            AllureLogger.LogStep("Select Value Option of rotating asset",
                pom.SelectValueOptionofRotatingAsset);
        }

        [Given("I select no. {int} record from rotating asset table records")]
        public void GivenISelectNo_RecordFromRotatingAssetTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from rotating asset table records",
              () => pom.SelectNoRecordFromRotatingAssetTableRecords(recordNumber));
        }


        [Given("I take screenshot of Asset Swap Work Order Test Scenario one")]
        public void GivenITakeScreenshotOfAssetSwapWorkOrderTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Asset Swap Work Order Test Scenario one",
                pom.TakeScreenshotOfAssetSwapWorkOrderTestScenarioOne);
        }

        [Given("I take screenshot of Asset Swap Work Order Test Scenario two")]
        public void GivenITakeScreenshotOfAssetSwapWorkOrderTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Asset Swap Work Order Test Scenario two",
                pom.TakeScreenshotOfAssetSwapWorkOrderTestScenariotwo);
        }






    }
}
