using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using Reqnroll;


namespace GTR_AUTOMATED.StepDefinitions
{
    [Binding]
    public sealed class EMWorkOrderStepDefinitions
    {

        private readonly IWebDriver driver;
        private readonly EMWOPOM pom;

        public EMWorkOrderStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new EMWOPOM(driver);
        }
                
        [When("I open application Work Orders, Fault Reporting \\(BRDA)")]
        public void WhenIOpenApplicationWorkOrdersFaultReportingBRDA()
        {
            AllureLogger.LogStep("Open GoTO Menu Bar",
               pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Work Order Menu",
                pom.WorkOrder);
            AllureLogger.LogStep("Launch Fault Reporting (BRDA)",
                pom.OpenFaultReportingBRDA);
        }

        [When("I choose Select Value from Detail Menu of Location field")]
        public void WhenIChooseSelectValueFromDetailMenuOfLocationField()
        {
            AllureLogger.LogStep("Detail Menu Of Location Field",
               pom.DetailMenuOfLocationField);
            AllureLogger.LogStep("Select Value Option",
                pom.SelectValueOption);
        }

        [When("I filter table Location:")]
        public void WhenIFilterTableLocation(Table table)
        {
            string Location = table.Rows[0]["Location"];
            AllureLogger.LogStep($"I filter table Location: {Location}", () =>
                pom.FilterTableLocation(Location));
        }

        [When("I select no. {int} record from Location table records")]
        public void WhenISelectNo_RecordFromLocationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Location table records",
              () => pom.SelectNoRecordFromAssetTableRecords(recordNumber));
        }

        [When("I open Select Value lookup for Failure Group field")]
        public void WhenIOpenSelectValueLookupForFailureGroupField()
        {
            AllureLogger.LogStep("I open Select Value lookup for Failure Group field",
              pom.SelectValueLookupForFailureGroupField);
            
        }

        [When("I select no. {int} record from Failure Group table")]
        public void WhenISelectNo_RecordFromFailureGroupTable(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Failure Group table records",
               () => pom.SelectNoRecordFromFailureGroupTable(recordNumber));
        }

        [When("I open Select Value lookup for Failure Code field")]
        public void WhenIOpenSelectValueLookupForFailureCodeField()
        {
            AllureLogger.LogStep("I open Select Value lookup for Failure Code field",
              pom.SelectValueLookupForFailureCodeField);
        }

        [When("I select no. {int} record from Failure Code table")]
        public void WhenISelectNo_RecordFromFailureCodeTable(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Failure Code table records",
              () => pom.SelectNoRecordFromFailureCodeTable(recordNumber));
        }

        [When("I open Select Value lookup for Problem Code field")]
        public void WhenIOpenSelectValueLookupForProblemCodeField()
        {
            AllureLogger.LogStep("I open Select Value lookup for Problem Code field",
              pom.SelectValueLookupForProblemCodeField);
        }

        [When("I select no. {int} record from Problem Code table")]
        public void WhenISelectNo_RecordFromProblemCodeTable(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Problem Code table records",
             () => pom.SelectNoRecordFromProblemCodeTable(recordNumber));
        }

        [When("I open Select Value lookup for Repair Facility field")]
        public void WhenIOpenSelectValueLookupForRepairFacilityField()
        {
            AllureLogger.LogStep("I open Select Value lookup for Repair Facility field",
             pom.OpenSelectValueLookupForRepairFacilityField);
        }

        [When("I filter table Repair Facility:")]
        public void WhenIFilterTableRepairFacility(Table table)
        {
            string RepairFacility = table.Rows[0]["Repair Facility"];
            AllureLogger.LogStep($"I filter table Repair Facility: {RepairFacility}", () =>
                pom.FilterTableRepairFacility(RepairFacility));
        }

        [When("I select no. {int} record from Repair Facility table")]
        public void WhenISelectNo_RecordFromRepairFacilityTable(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Repair Facility table records",
             () => pom.SelectNoRecordFromRepairFacilityTable(recordNumber));
        }

        [When("I open Select Value lookup for Reported Priority")]
        public void WhenIOpenSelectValueLookupForReportedPriority()
        {
            AllureLogger.LogStep("I open Select Value lookup for Reported Priority field",
            pom.SelectValueLookupForReportedPriority);
        }

        [When("I filter table Reported Priority:")]
        public void WhenIFilterTableReportedPriority(Table table)
        {
            string ReportedPriority = table.Rows[0]["Reported Priority"];
            AllureLogger.LogStep($"I filter table Reported Priority: {ReportedPriority}", () =>
            pom.FilterTableReportedPriority(ReportedPriority));
        }


        [When("I select no. {int} record from Reported Priority table")]
        public void WhenISelectNo_RecordFromReportedPriorityTable(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Reported Priority table records",
            () => pom.SelectNoRecordFromReportedPriorityTable(recordNumber));
        }

        [When("I enter following data to Headcode:")]
        public void WhenIEnterFollowingDataToHeadcode(Table table)
        {
            string Headcode = table.Rows[0]["Headcode"];
            AllureLogger.LogStep($"I filter table Headcode: {Headcode}", () =>
                pom.EnterFollowingData(Headcode));
        }

        [When("I enter following data:")]
        public void WhenIEnterFollowingData(Table table)
        {
            string Summary = table.Rows[0]["Summary"];
            string Details = table.Rows[0]["Details"];


            pom.EnterFollowingData(Summary, Details);
        }


        [When("I enter following:")]
        public void WhenIEnterFollowing(Table table)
        {
            string Summary = table.Rows[0]["Summary"];
            string Details = table.Rows[0]["Details"];


            pom.EnterFollowing(Summary, Details);
        }
               
        [When("I route the workflow")]
        public void WhenIRouteTheWorkflow()
        {
            AllureLogger.LogStep("I route the workflow",
             pom.RouteTheWorkflow);
        }

        [When("I press Ok button")]
        public void WhenIPressOkButton()
        {
            AllureLogger.LogStep("I press Ok button",
            pom.PressOkButton);
        }

        [When("I press dialog button of Show Duplicate Tickets")]
        public void WhenIPressDialogButtonOfShowDuplicateTickets()
        {
            AllureLogger.LogStep("I press dialog button of Show Duplicate Tickets",
            pom.PressDialogButtonOfShowDuplicateTickets);
        }
                     

        [Then("I press dialog button OK")]
        public void ThenIPressDialogButtonOK()
        {
            AllureLogger.LogStep("I press Ok button",
            pom.IPressDialogButtonOK);
        }

        [When("I go to Related Records tab")]
        public void WhenIGoToRelatedRecordsTab()
        {
            AllureLogger.LogStep("I go to Related Records tab",
           pom.IGoToRelatedRecordsTab);
        }

        [When("I view Related Work Order")]
        public void WhenIViewRelatedWorkOrder()
        {
            AllureLogger.LogStep("I view Related Work Order",
              pom.ViewRelatedWorkOrder);
        }

        [Then("field Status has value WAIT-REV")]
        public void ThenFieldStatusHasValueWAIT_REV()
        {
            AllureLogger.LogStep("work order Status field has value WAIT-REV",
                pom.FieldStatusHasValueWAITREV);
        }

        [Then("I take screenshot of Create a EM Work Order test")]
        public void ThenITakeScreenshotOfCreateAEMWorkOrderTest()
        {
            AllureLogger.LogStep("I take screenshot of Create a EM Work Order test",
               pom.TakeScreenshotOfCreateAEMWorkOrderTest);
        }


        //Accepting An EM Work Order into the Work Bank Step Definitions

        [Then("I take screenshot of Accepting An EM Work Order into the Work Bank scenario one")]
        public void ThenITakeScreenshotOfAcceptingAnEMWorkOrderIntoTheWorkBankScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Accepting An EM Work Order into the Work Bank scenario one",
              pom.TakeScreenshotOfAcceptingAnEMWorkOrderIntoTheWorkBankScenarioOne);
        }

        [Given("I open application Work Order Tracking BRDA from Fav Menu")]
        public void GivenIOpenApplicationWorkOrderTrackingBRDAFromFavMenu()
        {
            AllureLogger.LogStep("I open application Work Order Tracking BRDA from Fav Menu",
           pom.OpenApplicationWorkOrderTrackingBRDAFromFavMenu);
        }
               
        [When("I filter table EM:")]
        public void WhenIFilterTableEM(Table table)
        {
            string description = table.Rows[0]["Description"];
            string status = table.Rows[0]["Status"];
            string WorkType = table.Rows[0]["Work Type"];
            pom.FilterTableEM(description, status, WorkType);
        }

        [When("I select no. {int} record from EM table")]
        public void WhenISelectNo_RecordFromEMTable(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from EM table records",
             () => pom.SelectNoRecordFromEMTable(recordNumber));
        }

        [When(@"I set \(Radio\) field to ""(.*)""")]
        public void WhenISetRadioFieldTo(string radioValue)
        {
            AllureLogger.LogStep(
                $"I set (Radio) field to {radioValue}",
                () => pom.SetRadioField(radioValue));
        }
                     
               
        [When("work order Status field has value REVIEWED")]
        public void WhenWorkOrderStatusFieldHasValueREVIEWED()
        {
            AllureLogger.LogStep("work order Status field has value REVIEWED",
                 pom.StatusFieldHasValueREVIEWED);
        }

        [When("I take screenshot of Accepting An EM Work Order into the Work Bank scenario two")]
        public void WhenITakeScreenshotOfAcceptingAnEMWorkOrderIntoTheWorkBankScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Accepting An EM Work Order into the Work Bank scenario two",
             pom.TakeScreenshotOfAcceptingAnEMWorkOrderIntoTheWorkBankScenariotwo);
        }

        //Rejecting An EM Work Order form the Work Bank Step Definitions

        [Then("I take screenshot of Rejecting An EM Work Order form the Work Bank scenario one")]
        public void ThenITakeScreenshotOfRejectingAnEMWorkOrderFormTheWorkBankScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Rejecting An EM Work Order form the Work Bank scenario one",
             pom.TakeScreenshotOfRejectingAnEMWorkOrderFormTheWorkBankScenarioOne);
        }
              

        [When("work order Status field has value CANCELLED")]
        public void WhenWorkOrderStatusFieldHasValueCANCELLED()
        {
            AllureLogger.LogStep("work order Status field has value CANCELLED",
                pom.StatusFieldHasValueCANCELLED);
        }


        [When("I take screenshot of Rejecting An EM Work Order form the Work Bank scenario two")]
        public void WhenITakeScreenshotOfRejectingAnEMWorkOrderFormTheWorkBankScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Rejecting An EM Work Order form the Work Bank scenario two",
            pom.TakeScreenshotOfRejectingAnEMWorkOrderFormTheWorkBankScenariotwo);
        }



        // Assigning an EM Work Order Step Definitions


        [Then("I take screenshot of Assigning an EM Work Order scenario one")]
        public void ThenITakeScreenshotOfAssigningAnEMWorkOrderScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Assigning an EM Work Order scenario one",
           pom.TakeScreenshotOfAssigningAnEMWorkOrderScenarioOne);
        }

        [When("I take screenshot of Assigning an EM Work Order scenario two")]
        public void WhenITakeScreenshotOfAssigningAnEMWorkOrderScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Assigning an EM Work Order scenario two",
           pom.TakeScreenshotOfAssigningAnEMWorkOrderScenariotwo);
        }

        [When("I go to Assignment tab")]
        public void WhenIGoToAssignmentTab()
        {
            AllureLogger.LogStep("I go to Assignment tab",
             pom.GoToAssignmentTab);
        }

        [When("I press add new row under Assignments tab")]
        public void WhenIPressAddNewRowUnderAssignmentsTab()
        {
            AllureLogger.LogStep("I press add new row under Assignments tab",
             pom.AddNewRowUnderAssignmentsTab);
        }

        [When("I select Value lookup for Labor field")]
        public void WhenISelectValueLookupForLaborField()
        {
            AllureLogger.LogStep("I select Value lookup for Labor field",
             pom.SelectValueLookupForLaborField);
        }

        [When("I filter table labor:")]
        public void WhenIFilterTableLabor(Table table)
        {
            string labor = table.Rows[0]["labor"];
            AllureLogger.LogStep($"I filter table labor: {labor}", () =>
                pom.FilterTableLabor(labor));
        }

        [When("I select no.{int} from labor table record")]
        public void WhenISelectNo_FromLaborTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from labor table records",
            () => pom.SelectNoFromLaborTableRecord(recordNumber));
        }

        [When("I pree Ok dialog system message button")]
        public void WhenIPreeOkDialogSystemMessageButton()
        {
            AllureLogger.LogStep("I pree Ok dialog system message button",
            pom.PreeOkDialogSystemMessageButton);
        }


        [When("I save")]
        public void WhenISave()
        {
            AllureLogger.LogStep("I save",
            pom.ISave);
        }
                      

        [When("I click OK dialog button")]
        public void WhenIClickOKDialogButton()
        {
            AllureLogger.LogStep("I click OK dialog button",
           pom.ClickOKDialogButton);
        }

        [When("I verify Status field has value SCHEDULED")]
        public void WhenIVerifyStatusFieldHasValueSCHEDULED()
        {
            AllureLogger.LogStep("work order Status field has value SCHEDULED",
               pom.StatusFieldHasValueSCHEDULED);
        }

        [When("I take screenshot of Assigning an EM Work Order scenario three")]
        public void WhenITakeScreenshotOfAssigningAnEMWorkOrderScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Assigning an EM Work Order scenario three",
             pom.TakeScreenshotOfAssigningAnEMWorkOrderScenariothree);
        }




        // Pausing an EM Work Order Step Definitions

        [Then("I take screenshot of Pausing an EM Work Order scenario one")]
        public void ThenITakeScreenshotOfPausingAnEMWorkOrderScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Pausing an EM Work Order scenario one",
             pom.TakeScreenshotOfPausingAnEMWorkOrderScenarioOne);
        }

        [When("I take screenshot of Pausing an EM Work Order scenario two")]
        public void WhenITakeScreenshotOfPausingAnEMWorkOrderScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Pausing an EM Work Order scenario two",
             pom.TakeScreenshotOfPausingAnEMWorkOrderScenariotwo);
        }

        [When("I take screenshot of Pausing an EM Work Order scenario three")]
        public void WhenITakeScreenshotOfPausingAnEMWorkOrderScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Pausing an EM Work Order scenario three",
              pom.TakeScreenshotOfPausingAnEMWorkOrderScenariothree);
        }
             

        [When("I press dialog Ok")]
        public void WhenIPressDialogOk()
        {
            AllureLogger.LogStep("I press dialog Ok",
            pom.PressDialogOk);
        }

        [When("I verify Work Order status has value INPRG")]
        public void WhenIVerifyWorkOrderStatusHasValueINPRG()
        {
            AllureLogger.LogStep("work order Status field has value INPRG",
                 pom.VerifyWorkOrderStatusHasValueINPRG);
        }

        [When("I open application Work Order Tracking BRDA from Fav Menu")]
        public void WhenIOpenApplicationWorkOrderTrackingBRDAFromFavMenu()
        {
            AllureLogger.LogStep("I open application Work Order Tracking BRDA from Fav Menu",
            pom.OpenApplicationWorkOrderTrackingBRDAFromFavMenu);
        }

        [When("I click dialog Ok")]
        public void WhenIClickDialogOk()
        {
            AllureLogger.LogStep("I click dialog Ok",
            pom.ClickDialogOk);
        }

        [When("I verify Status field has value INPRG-HOLD")]
        public void WhenIVerifyStatusFieldHasValueINPRG_HOLD()
        {
            AllureLogger.LogStep("work order Status field has value INPRG-HOLD",
                 pom.VerifyStatusFieldHasValueINPRGHOLD);
        }

        [When("I take screenshot of Pausing an EM Work Order test test scenario four")]
        public void WhenITakeScreenshotOfPausingAnEMWorkOrderTestTestScenarioFour()
        {
            AllureLogger.LogStep("I take screenshot of Pausing an EM Work Order scenario four",
               pom.TakeScreenshotOfPausingAnEMWorkOrderScenariofour);
        }



        // Completing an EM Work Order for Review Step Definitions



        [Then("I take screenshot of Completing an EM Work Order for Review scenario one")]
        public void ThenITakeScreenshotOfCompletingAnEMWorkOrderForReviewScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Completing an EM Work Order for Review scenario one",
               pom.TakeScreenshotOfCompletingAnEMWorkOrderForReviewScenarioOne);
        }

        [When("I take screenshot of Completing an EM Work Order for Review scenario two")]
        public void WhenITakeScreenshotOfCompletingAnEMWorkOrderForReviewScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Completing an EM Work Order for Review scenario two",
                pom.TakeScreenshotOfCompletingAnEMWorkOrderForReviewScenariotwo);
        }

        [When("I take screenshot of Completing an EM Work Order for Review scenario three")]
        public void WhenITakeScreenshotOfCompletingAnEMWorkOrderForReviewScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Completing an EM Work Order for Review scenario three",
               pom.TakeScreenshotOfCompletingAnEMWorkOrderForReviewScenariothree);
        }

        [When("I take screenshot of Completing an EM Work Order for Review test scenario four")]
        public void WhenITakeScreenshotOfCompletingAnEMWorkOrderForReviewTestScenarioFour()
        {
            AllureLogger.LogStep("I take screenshot of Completing an EM Work Order for Review scenario four",
               pom.TakeScreenshotOfCompletingAnEMWorkOrderForReviewScenariofour);
        }

        [Given("I open application Quick Work Order BRDA from Fav Menu")]
        public void GivenIOpenApplicationQuickWorkOrderBRDAFromFavMenu()
        {
            AllureLogger.LogStep("I open application Quick Work Order BRDA from Fav Menuk",
            pom.OpenApplicationQuickWorkOrderBRDAFromFavMenu);
        }

        [Given("I open application Quick Work Order \\(BRDA)")]
        public void GivenIOpenApplicationQuickWorkOrderBRDA()
        {
            AllureLogger.LogStep("Open GoTO Menu Bar",
               pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Work Order Menu",
                pom.WorkOrder);
            AllureLogger.LogStep("Open Quick Work Order (BRDA)",
                pom.OpenQuickWorkOrderBRDA);
        }


        [When("I filter table Quick Work Order:")]
        public void WhenIFilterTableQuickWorkOrder(Table table)
        {
            string description = table.Rows[0]["Description"];
            string status = table.Rows[0]["Status"];
            string WorkType = table.Rows[0]["Work Type"];

            pom.FilterTableQuickWorkOrder(description, status, WorkType);
        }
                      

        [When("I press dialog Ok button of system message")]
        public void WhenIPressDialogOkButtonOfSystemMessage()
        {
            AllureLogger.LogStep("I press dialog Ok button of system message",
            pom.PressDialogOkButtonOfSystemMessage);
        }


        [When("I press dialog button close")]
        public void WhenIPressDialogButtonClose()
        {
            AllureLogger.LogStep("I press dialog button close",
            pom.PressDialogButtonClose);
        }

        [When("I go to labor tab")]
        public void WhenIGoToLaborTab()
        {
            AllureLogger.LogStep("I go to labor tab",
             pom.GoToLaborTab);
        }

        [When("I press add new row button")]
        public void WhenIPressAddNewRowButton()
        {
            AllureLogger.LogStep("I press add new row button",
            pom.PressAddNewRowButton);
        }

        [When("I choose Select Value from Detail Menu labor field")]
        public void WhenIChooseSelectValueFromDetailMenuLaborField()
        {
            AllureLogger.LogStep("Detail Menu Of labor Field",
               pom.DetailMenuOflaborField);
            AllureLogger.LogStep("Select Value Option",
                pom.SelectValueOptionoflaborField);
        }

        [When("I filter table Record labor:")]
        public void WhenIFilterTableRecordLabor(Table table)
        {
            string labor = table.Rows[0]["Labor"];
            AllureLogger.LogStep($"I filter table Labor: {labor}", () =>
                pom.FilterTableRecordLabor(labor));
        }

        [When("I select no. {int} record from labor table records")]
        public void WhenISelectNo_RecordFromLaborTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from labor table records",
             () => pom.SelectNoRecordFromLaborTableRecords(recordNumber));
        }

        [When("I set labor Start and End time")]
        public void WhenISetLaborStartAndEndTime()
        {
            AllureLogger.LogStep("I select Start and End time",
              pom.ISetStartAndEndTime);
        }

        [When("I go to Failure Reporting Tab")]
        public void WhenIGoToFailureReportingTab()
        {
            AllureLogger.LogStep("I go to Failure Reporting Tab",
            pom.GoToFailureReportingTab);
        }

        [When("I press the button Select Failure Codes")]
        public void WhenIPressTheButtonSelectFailureCodes()
        {
            AllureLogger.LogStep("I press the button Select Failure Codes",
           pom.PressTheButtonSelectFailureCodes);
        }

        [When("I filter table Failure Codes:")]
        public void WhenIFilterTableFailureCodes(Table table)
        {
            string FailureCodes = table.Rows[0]["Failure Codes"];
            AllureLogger.LogStep($"I filter table Failure Codes: {FailureCodes}", () =>
                pom.FilterTableFailureCodes(FailureCodes));
        }

        [When("I select Faliure Informations")]
        public void WhenISelectFaliureInformations()
        {
           
            AllureLogger.LogStep("I select cause codes",
             pom.CauseCodes);

            AllureLogger.LogStep("I select remedy codes",
           pom.RemedyCodes);
        }

        [When("I go to Log Tab")]
        public void WhenIGoToLogTab()
        {
            AllureLogger.LogStep("I go to Log Tab",
              pom.GoToLogTab);
        }

        [When("I add new row Button")]
        public void WhenIAddNewRowButton()
        {
            AllureLogger.LogStep("I add new row Button",
              pom.AddNewRowButton);
        }

        [When("I Click dialog Ok button")]
        public void WhenIClickDialogOkButton()
        {
            AllureLogger.LogStep("I Click dialog Ok button",
            pom.ClickDialogOkButton);
        }

        [When("I Status field has value COMP-WREV")]
        public void WhenIStatusFieldHasValueCOMP_WREV()
        {
            AllureLogger.LogStep("work order Status field has value COMP-WREV",
               pom.StatusFieldHasValueCOMPWREV);
        }

        [When("I take screenshot of Rejecting an EM Work Order test scenario four")]
        public void WhenITakeScreenshotOfRejectingAnEMWorkOrderTestScenarioFour()
        {
            AllureLogger.LogStep("I take screenshot of Completing an EM Work Order for Review scenario four",
            pom.TakeScreenshotOfCompletingAnEMWorkOrderForReviewScenariofour);
        }

                             

        
        // Rejecting an EM Work Order Step Definitions


        [Then("I take screenshot of Rejecting an EM Work Order scenario one")]
        public void ThenITakeScreenshotOfRejectingAnEMWorkOrderScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Rejecting an EM Work Order scenario one",
               pom.TakeScreenshotOfRejectingAnEMWorkOrderScenarioOne);
        }

        [When("I take screenshot of Rejecting an EM Work Order scenario two")]
        public void WhenITakeScreenshotOfRejectingAnEMWorkOrderScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Rejecting an EM Work Order scenario two",
               pom.TakeScreenshotOfRejectingAnEMWorkOrderScenariotwo);
        }

        [When("I take screenshot of Rejecting an EM Work Order scenario three")]
        public void WhenITakeScreenshotOfRejectingAnEMWorkOrderScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Rejecting an EM Work Order scenario three",
               pom.TakeScreenshotOfRejectingAnEMWorkOrderScenariothree);
        }

        [Then("I take screenshot of Rejecting an EM Work Order test scenario four")]
        public void ThenITakeScreenshotOfRejectingAnEMWorkOrderTestScenarioFour()
        {
            AllureLogger.LogStep("I take screenshot of Rejecting an EM Work Order scenario four",
                pom.TakeScreenshotOfRejectingAnEMWorkOrderScenariofour);
        }

       
        [When("I press OK button")]
        public void WhenIPressOKButton()
        {
            AllureLogger.LogStep("I press OK button",
            pom.PressOKButton);
        }

        [When("I Status field has value INPRG-HOLD")]
        public void WhenIStatusFieldHasValueINPRG_HOLD()
        {
            AllureLogger.LogStep("work order Status field has value INPRG-HOLD",
                pom.StatusFieldHasValueINPRGHOLD);
        }

        [When("I take screenshot of Rejecting an EM Work Order test scenario five")]
        public void WhenITakeScreenshotOfRejectingAnEMWorkOrderTestScenarioFive()
        {
            AllureLogger.LogStep("I take screenshot of Rejecting an EM Work Order scenario five",
                 pom.TakeScreenshotOfRejectingAnEMWorkOrderScenariofive);
        }


        //Approving an EM Work Order Step Definitions

        [Then("I take screenshot of Approving an EM Work Order scenario one")]
        public void ThenITakeScreenshotOfApprovingAnEMWorkOrderScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Approving an EM Work Order scenario one",
                pom.TakeScreenshotOfApprovingAnEMWorkOrderScenarioOne);
        }

        [When("I take screenshot of Approving an EM Work Order scenario two")]
        public void WhenITakeScreenshotOfApprovingAnEMWorkOrderScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Approving an EM Work Order scenario two",
               pom.TakeScreenshotOfApprovingAnEMWorkOrderScenariotwo);
        }

        [When("I take screenshot of Approving an EM Work Order scenario three")]
        public void WhenITakeScreenshotOfApprovingAnEMWorkOrderScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Approving an EM Work Order scenario three",
               pom.TakeScreenshotOfApprovingAnEMWorkOrderScenariothree);
        }

        [When("I take screenshot of Approving an EM Work Order test scenario four")]
        public void WhenITakeScreenshotOfApprovingAnEMWorkOrderTestScenarioFour()
        {
            AllureLogger.LogStep("I take screenshot of Approving an EM Work Order scenario four",
              pom.TakeScreenshotOfApprovingAnEMWorkOrderScenariofour);
        }

        [When("I Status field has value COMP")]
        public void WhenIStatusFieldHasValueCOMP()
        {
            AllureLogger.LogStep("work order Status field has value COMP",
               pom.StatusFieldHasValueCOMP);
        }

        [When("I take screenshot of Approving an EM Work Order test scenario five")]
        public void WhenITakeScreenshotOfApprovingAnEMWorkOrderTestScenarioFive()
        {
            AllureLogger.LogStep("I take screenshot of Approving an EM Work Order scenario five",
                pom.TakeScreenshotOfApprovingAnEMWorkOrderScenariofive);
        }









        // MWE Work Order Step Definitions





        [When("I go to Plans tab")]
        public void WhenIGoToPlansTab()
        {
            AllureLogger.LogStep("I go to Plans tab",
            pom.GoToPlansTab);
        }

        [When("I press add new row under Task for work order section")]
        public void WhenIPressAddNewRowUnderTaskForWorkOrderSection()
        {
            AllureLogger.LogStep("I press add new row under Task for work order section",
           pom.PressAddNewRowUnderTaskForWorkOrderSection);
        }

        [When("I enter Task Description:")]
        public void WhenIEnterTaskDescription(Table table)
        {
            string TaskDescription = table.Rows[0]["Description"];
            AllureLogger.LogStep($"I enter Task Description: {TaskDescription}", () =>
                pom.EnterTaskDescription(TaskDescription));
        }

        [When("I open Select Value lookup for Task Requires Tools or Comments field")]
        public void WhenIOpenSelectValueLookupForTaskRequiresToolsOrCommentsField()
        {
            AllureLogger.LogStep("I open Select Value lookup for Task Requires Tools or Comments field",
            pom.OpenSelectValueLookupForTaskRequiresToolsOrCommentsField);
        }

        [When("I select Y")]
        public void WhenISelectY()
        {
            AllureLogger.LogStep("I select Y",
            pom.SelectY);
        }
               
        [When("I choose Select Value from Detail Menu of Measurement Point field")]
        public void WhenIChooseSelectValueFromDetailMenuOfMeasurementPointField()
        {
            AllureLogger.LogStep("Detail Menu Of Measurement Point Field",
               pom.DetailMenuOfMeasurementPointField);
            AllureLogger.LogStep("Select Value Option of Measurement Point",
                pom.SelectValueOptionofMeasurementPointField);
        }

        [When("I open Select Value lookup for Measurement Point field")]
        public void WhenIOpenSelectValueLookupForMeasurementPointField()
        {
            AllureLogger.LogStep("Detail Menu Of Measurement Point Field",
                pom.DetailMenuOfMeasurementPointField);
        }


        [When("I filter table Measurement Point:")]
        public void WhenIFilterTableMeasurementPoint(Table table)
        {
            string MeasurementPoint = table.Rows[0]["Measurement Point"];
            AllureLogger.LogStep($"I filter table Measurement Point: {MeasurementPoint}", () =>
                pom.FilterTableMeasurementPoint(MeasurementPoint));
        }

        [When("I select no. {int} record from Measurement Point table")]
        public void WhenISelectNo_RecordFromMeasurementPointTable(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Measurement Point table records",
             () => pom.SelectNoRecordFromMeasurementPointTable(recordNumber));
        }













    }
}