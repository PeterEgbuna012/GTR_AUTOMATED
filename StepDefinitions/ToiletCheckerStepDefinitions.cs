using GTR_AUTOMATED.Utilities;
using GTR_AUTOMATED.Pages;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using Reqnroll;
using GivenAttribute = Reqnroll.GivenAttribute;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace GTR_AUTOMATED.StepDefinitions
{
    [Binding]

    public class ToiletCheckerStepDefinitions
    {
        private readonly IWebDriver driver;
        private readonly TCPOM pom;
        private readonly ScenarioContext scenarioContext;


        public ToiletCheckerStepDefinitions(IWebDriver drv, Reqnroll.ScenarioContext scenarioContext)
        {
            driver = drv;
            pom = new TCPOM(driver);
            this.scenarioContext = scenarioContext;
        }

        public ToiletCheckerStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new TCPOM(driver);

        }


        [Given("I open application Toilet Checker \\(MXR)")]
        public void GivenIOpenApplicationToiletCheckerMXR()
        {
            AllureLogger.LogStep("Open [Go To] menu Bar",
               pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Work Order Menu",
                pom.OpenWorkOrderMenu);
            AllureLogger.LogStep("Launch application Toilet Checker (MXR)",
                pom.OpenApplicationToiletCheckerMXR);
        }

        [Given("I filter table Toilet Checker:")]
        public void GivenIFilterTableToiletChecker(Table table)
        {
            string ToiletChecker = table.Rows[0]["Toilet Checker"];
            AllureLogger.LogStep($"I filter table Asset Group: {ToiletChecker}", () =>
                pom.FilterTableToiletChecker(ToiletChecker));
        }
                     

        [Given("I select View Details arrow")]
        public void GivenISelectViewDetailsArrow()
        {
            AllureLogger.LogStep("I select View Details arrow",
              pom.SelectViewDetailsArrow);
        }

        [Given("I verify toilet number")]
        public void GivenIVerifyToiletNumber()
        {
            AllureLogger.LogStep("I verify toilet number",
               pom.VerifyToiletNumber);
        }

        [Given("I verify toilet description")]
        public void GivenIVerifyToiletDescription()
        {
            AllureLogger.LogStep("I verify toilet number",
              pom.VerifyToiletDescription);
        }

        [Given("I verify toilet Status")]
        public void GivenIVerifyToiletStatus()
        {
            AllureLogger.LogStep("I verify toilet number",
              pom.VerifyToiletStatus);
        }
        
        [Given("I verify toilet unavailability reason")]
        public void GivenIVerifyToiletUnavailabilityReason()
        {
            AllureLogger.LogStep("I verify toilet number",
              pom.VerifyToiletUnavailabilityReason);
        }

        [Given("I verify toilet locked")]
        public void GivenIVerifyToiletLocked()
        {
            AllureLogger.LogStep("I verify toilet locked",
              pom.VerifyToiletLocked);
        }

        [Given("I verify toilet checked date")]
        public void GivenIVerifyToiletCheckedDate()
        {
            AllureLogger.LogStep("I verify toilet locked",
              pom.VerifyToiletCheckedDate);
        }

        [Given("I select the Close Details arrow")]
        public void GivenISelectTheCloseDetailsArrow()
        {
            AllureLogger.LogStep("I select the Close Details arrow",
             pom.SelectTheCloseDetailsArrow);
        }

        [Given("I take screenshot of View Toilet Status")]
        public void GivenITakeScreenshotOfViewToiletStatus()
        {
            AllureLogger.LogStep("I take screenshot of View Toilet Status",
                pom.TakeScreenshotOfViewToiletStatus);
        }




        //Change status of a Toilet Asset Step Definitions 


        [Given("I select change toilet asset statuse button")]
        public void GivenISelectChangeToiletAssetStatuseButton()
        {
            AllureLogger.LogStep("I select change toilet asset statuse button",
              pom.SelectChangeToiletAssetStatuseButton);
        }

        [Given("I Click on the status dropdown")]
        public void GivenIClickOnTheStatusDropdown()
        {
            AllureLogger.LogStep("I Click on the status dropdown",
             pom.ClickOnTheStatusDropdown);
        }

        [Given("I select unavailable")]
        public void GivenISelectUnavailable()
        {
            AllureLogger.LogStep("I select unavailable",
             pom.SelectUnavailable);
        }

        [Given("I filter table Toilet Unavailable Reason:")]
        public void GivenIFilterTableToiletUnavailableReason(Table table)
        {
            string ToiletCheckerunavailableReason = table.Rows[0]["Toilet Checker"];
            AllureLogger.LogStep($"I filter table Asset Group: {ToiletCheckerunavailableReason}", () =>
                pom.FilterTableToiletUnavailableReason(ToiletCheckerunavailableReason));
        }
                   

        [Given("I press button ok")]
        public void GivenIPressButtonOk()
        {
            AllureLogger.LogStep("I press button ok",
              pom.PressButtonOk);
        }

        [Given("I select available")]
        public void GivenISelectAvailable()
        {
            AllureLogger.LogStep("I select available",
            pom.SelectAvailable);
        }


        [Given("I take screenshot of Change status of a Toilet Asset")]
        public void GivenITakeScreenshotOfChangeStatusOfAToiletAsset()
        {
            AllureLogger.LogStep("I take screenshot of Change status of a Toilet Asset",
                 pom.TakeScreenshotOfChangeStatusOfAToiletAsset);
        }


        //Lock/ Unlock a Toilet Asset Step Definitions


        [Given("I take screenshot of toilet Status Unlock")]
        public void GivenITakeScreenshotOfToiletStatusUnlock()
        {
            AllureLogger.LogStep("I take screenshot of toilet Status Unlock",
                pom.TakeScreenshotOfToiletStatusUnlock);
        }


        [Given("I press button Lock\\/Unlock a Toilet Asset")]
        public void GivenIPressButtonLockUnlockAToiletAsset()
        {
            AllureLogger.LogStep("I press button Lock\\/Unlock a Toilet Asset",
            pom.PressButtonLockUnlockAToiletAsset);
        }

        [Given("I enter following Toilet Checker data:")]
        public void GivenIEnterFollowingToiletCheckerData(Table table)
        {
            string Comment = table.Rows[0]["Comment"];
            AllureLogger.LogStep($"I enter following Toilet Checker data: {Comment}", () =>
                pom.EnterFollowingToiletCheckerData(Comment));
        }
        
        [Given("I press ok button")]
        public void GivenIPressOkButton()
        {
            AllureLogger.LogStep("I press ok button",
            pom.PressOkButton);
        }

        [Given("I press dialog button no")]
        public void GivenIPressDialogButtonNo()
        {
            AllureLogger.LogStep("I press dialog button no",
           pom.PressDialogButtonNo);
        }

        [Given("I press dialog button yes")]
        public void GivenIPressDialogButtonYes()
        {
            AllureLogger.LogStep("I press dialog button yes",
           pom.PressDialogButtonYes);
        }

        [Given("I take screenshot of Lock\\/ Unlock a Toilet Asset Test")]
        public void GivenITakeScreenshotOfLockUnlockAToiletAssetTest()
        {
            AllureLogger.LogStep("I take screenshot of Lock\\/ Unlock a Toilet Asset Test",
                 pom.TakeScreenshotOfChangeStatusOfAToiletAsset);
        }



        //Check audit logs Step Definitions

        [Given("I press button View Audit Log")]
        public void GivenIPressButtonViewAuditLog()
        {
            AllureLogger.LogStep("I press button View Audit Log",
           pom.PressButtonViewAuditLog);
        }

        [Given("I take screenshot of Audit Log")]
        public void GivenITakeScreenshotOfAuditLog()
        {
            AllureLogger.LogStep("I take screenshot of Audit Log",
                 pom.TakeScreenshotOfAuditLog);
        }

        [Given("I press OK button")]
        public void GivenIPressOKButton()
        {
            AllureLogger.LogStep("I press OK button",
                    pom.PressOKButton);
        }

        // Audit Log Updates Step Definitions

        [Given("I take screenshot of Audit Log Updates")]
        public void GivenITakeScreenshotOfAuditLogUpdates()
        {
            AllureLogger.LogStep("I take screenshot of Audit Log",
                 pom.TakeScreenshotOfAuditLogUpdates);
        }

        //Update status of  locked Toilet Asset Step Definitions

        [Given("I change toilet asset statuse button")]
        public void GivenIChangeToiletAssetStatuseButton()
        {
            AllureLogger.LogStep("I change toilet asset statuse button",
               pom.ChangeToiletAssetStatuseButton);
        }


        [Given("I press ok dialog system message button")]
        public void GivenIPressOkDialogSystemMessageButton()
        {
            AllureLogger.LogStep("I press ok dialog system message button",
           pom.PressOkDialogSystemMessageButton);
        }

        [Given("I take screenshot of Update status of  locked Toilet Asset Test")]
        public void GivenITakeScreenshotOfUpdateStatusOfLockedToiletAssetTest()
        {
            AllureLogger.LogStep("I take screenshot of Update status of  locked Toilet Asset Test",
                 pom.TakeScreenshotOfUpdateStatusOfLockedToiletAssetTest);
        }


        //Toilet Asset Setup Step Definitions

        [Given("I open application Assets\\(Tr)")]
        public void GivenIOpenApplicationAssetsTr()
        {
            AllureLogger.LogStep("Open [Go To] menu Bar",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Asset Menu Bar",
                pom.OpenAssetMenu);
            AllureLogger.LogStep("Launch application Asset (TR)",
                pom.OpenApplicationAssetTr);
        }

        [Given("I filter table Assets:")]
        public void GivenIFilterTableAssets(Table table)
        {
            string Asset = table.Rows[0]["Asset"];
            AllureLogger.LogStep($"I filter table Assets: {Asset}", () =>
                pom.FilterTableAssets(Asset));
        }
        
        [Given("I select no. {int} record from Assets table records")]
        public void GivenISelectNo_RecordFromAssetsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Location table records",
               () => pom.SelectNoRecordFromAssetsTableRecords(recordNumber));
        }

        [Given("I go to Tab Specifications")]
        public void GivenIGoToTabSpecifications()
        {
            AllureLogger.LogStep("I go to Tab Specifications",
            pom.GoToTabSpecifications);
        }

        [Given("I add new record in Specifications section")]
        public void GivenIAddNewRecordInSpecificationsSection()
        {
            AllureLogger.LogStep("I add new record in Specifications section",
                 pom.AddNewRecordInSpecificationsSection);
        }

        [Given("I open Select Value lookup for attribute field")]
        public void GivenIOpenSelectValueLookupForAttributeField()
        {
            AllureLogger.LogStep("I open Select Value lookup for attribute field",
            pom.OpenSelectValueLookupForAttributeField);
        }

        [Given("I select no. {int} record from attribute table records")]
        public void GivenISelectNo_RecordFromAttributeTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from attribute table records",
               () => pom.SelectNoRecordFromAttributeTableRecords(recordNumber));
        }

        [Given("I open Select Value lookup for alphanumeric value field")]
        public void GivenIOpenSelectValueLookupForAlphanumericValueField()
        {
            AllureLogger.LogStep("I open Select Value lookup for alphanumeric value field",
                 pom.OpenSelectValueLookupForAlphanumericValueField);
        }

        [Given("I select no. {int} record from alphanumeric value table records")]
        public void GivenISelectNo_RecordFromAlphanumericValueTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from alphanumeric table records",
               () => pom.SelectNoRecordFromAlphanumericValueTableRecords(recordNumber));
        }

        [Given("I take screenshot of Update status of Toilet Asset Setup Test")]
        public void GivenITakeScreenshotOfUpdateStatusOfToiletAssetSetupTest()
        {

            AllureLogger.LogStep("I take screenshot of Update status of Toilet Asset Setup Test",
                 pom.TakeScreenshotOfUpdateStatusOfToiletAssetSetupTest);
        }

        [Given("I take screenshot of Validate Toilet Asset Setup Test")]
        public void GivenITakeScreenshotOfValidateToiletAssetSetupTest()
        {

            AllureLogger.LogStep("I take screenshot of Validate Toilet Asset Setup Test",
                 pom.TakeScreenshotOfValidateToiletAssetSetupTest);
        }

        //View Clean Master Work orders Step Definitions

        [Given("I refresh Toilet Checker table records")]
        public void GivenIRefreshToiletCheckerTableRecords()
        {
            AllureLogger.LogStep("I refresh Toilet Checker table records",
               pom.RefreshToiletCheckerTableRecords);
        }

        [Given("I select no. {int} record from Toilet Checker table records")]
        public void GivenISelectNo_RecordFromToiletCheckerTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Toilet Checker table records",
               () => pom.SelectNoRecordFromToiletCheckerTableRecords(recordNumber));
        }

        [Given("I select View clean master work orders option")]
        public void GivenISelectViewCleanMasterWorkOrdersOption()
        {
            AllureLogger.LogStep("I select View clean master work orders option",
                pom.ViewCleanMasterWorkOrdersOption);
        }

        [Given("I select complete clean master task button")]
        public void GivenISelectCompleteCleanMasterTaskButton()
        {
            AllureLogger.LogStep("I select complete clean master task button",
              pom.SelectCompleteCleanMasterTaskButton);
        }

        [Given("I take screenshot of View Clean Master Work")]
        public void GivenITakeScreenshotOfViewCleanMasterWork()
        {
            AllureLogger.LogStep("I take screenshot of View Clean Master Work",
                  pom.TakeScreenshotOfViewCleanMasterWork);
        }

        [Given("I press ok")]
        public void GivenIPressOk()
        { 
             AllureLogger.LogStep("I press OK button",
                  pom.PressOk);
        }

        [Given("I take screenshot of View Clean Master Work orders Test")]
        public void GivenITakeScreenshotOfViewCleanMasterWorkOrdersTest()
        {
            AllureLogger.LogStep("I take screenshot of View Clean Master Work orders Test",
                 pom.TakeScreenshotOfViewCleanMasterWorkOrdersTest);
        }




        //Calculate Risk When “Days Left = 1” Step Definitions

        [Given("I verify toilet locked Comments")]
        public void GivenIVerifyToiletLockedComments()
        {
            AllureLogger.LogStep("I verify toilet locked Comments",
              pom.VerifyToiletLockedComments);
        }

        [Given("I take screenshot of Toliet Checker Details")]
        public void GivenITakeScreenshotOfTolietCheckerDetails()
        {
            AllureLogger.LogStep("I take screenshot of Toliet Checker Details",
                pom.TakeScreenshotOfTolietCheckerDetails);
        }

        [Given("I filter clean master:")]
        public void GivenIFilterCleanMaster(Table table)
        {
            string Location = table.Rows[0]["Location"];
            string WorkType = table.Rows[0]["Work Type"];
            AllureLogger.LogStep($"I filter table clean master: {Location}", () =>
             pom.FilterCleanMaster(Location, WorkType));
        }

        [Given("I verify CET Days Left")]
        public void GivenIVerifyCETDaysLeft()
        {
            AllureLogger.LogStep("I verify CET Days Left",
              pom.VerifyCETDaysLeft);
        }

        [Given("I verify WTF Days Left")]
        public void GivenIVerifyWTFDaysLeft()
        {
            AllureLogger.LogStep("I verify WTF Days Left",
              pom.VerifyWTFDaysLeft);
        }

        [Given("I take screenshot of Clean Master Details")]
        public void GivenITakeScreenshotOfCleanMasterDetails()
        {
            AllureLogger.LogStep("I take screenshot of Toliet Clean Master Details",
                pom.TakeScreenshotOfCleanMasterDetails);
        }

        [Given("I open application Rail Units \\(BRDF)")]
        public void GivenIOpenApplicationRailUnitsBRDF()
        {
            AllureLogger.LogStep("Open Go To Menu)",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Fleet Availability Management(BRDF) Menu",
                pom.OpenFleetAvailabilityManagementBRDFMenu);
            AllureLogger.LogStep("Open Rail Units (BRDF) ",
                pom.OpenRailUnitsBRDF);
        }

        [Given("I filter table Rail Units:")]
        public void GivenIFilterTableRailUnits(Table table)
        {
            string RailUnits = table.Rows[0]["Rail Units"];
            AllureLogger.LogStep($"I filter table Rail Units: {RailUnits}", () =>
                pom.FilterTableRailUnits(RailUnits));
        }

        [Given("I select no. {int} record from Rail Units table records")]
        public void GivenISelectNo_RecordFromRailUnitsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Rail Units table records",
               () => pom.SelectNoRecordFromRailUnitsTableRecords(recordNumber));
        }

        [Given("I verify unit in service")]
        public void GivenIVerifyUnitInService()
        {
            AllureLogger.LogStep("I verify unit in service",
              pom.VerifyUnitInService);
        }

        [Given("I take screenshot of Rail Units Details")]
        public void GivenITakeScreenshotOfRailUnitsDetails()
        {
            AllureLogger.LogStep("I take screenshot of Rail Units Details",
                pom.TakeScreenshotOfRailUnitsDetails);
        }

        [Given("I select Run Reports")]
        public void GivenISelectRunReports()
        {
            AllureLogger.LogStep("I select Run Reports",
                  pom.SelectRunReports);
        }

        [Given("I filter table Toilet Checker Reports:")]
        public void GivenIFilterTableToiletCheckerReports(Table table)
        {
            string Reports = table.Rows[0]["Reports"];
            AllureLogger.LogStep($"I filter table Reports: {Reports}", () =>
                pom.FilterTableToiletCheckerReports(Reports));
        }

        [Given("I select no. {int} record from Toilet Checker Reports table record")]
        public void GivenISelectNo_RecordFromToiletCheckerReportsTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Toilet Checker Reports table records",
              () => pom.SelectNoRecordFromToiletCheckerReportsTableRecord(recordNumber));
        }


        [Given("I open Select Value lookup of Area")]
        public void GivenIOpenSelectValueLookupOfArea()
        {
            AllureLogger.LogStep("I open Select Value lookup of Area",
                  pom.OpenSelectValueLookupOfArea);
        }

        [Given("I select no. {int} record from Area lookup table records")]
        public void GivenISelectNo_RecordFromAreaLookupTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Area lookup table records",
              () => pom.SelectNoRecordFromAreaLookupTableRecords(recordNumber));
        }

        [Given("I submit report")]
        public void GivenISubmitReport()
        {
            AllureLogger.LogStep("I submit report",
                  pom.SubmitReport);
        }

        [Given("I take screenshot of Toilet Checker Report test")]
        public void GivenITakeScreenshotOfToiletCheckerReportTest()
        {
            AllureLogger.LogStep("I take screenshot of Toilet Checker Report test",
                pom.TakeScreenshotOfToiletCheckerReportTest);
        }



        //Automatically create a fault ticket when toilet asset set to unavailable for a technical reason Step Definitions


        [When("I filter table Fault Reporting \\(BRDA):")]
        public void WhenIFilterTableFaultReportingBRDA(Table table)
        {

            string Summary = table.Rows[0]["Summary"];
            string Location = table.Rows[0]["Location"];
            AllureLogger.LogStep($"I filter table Fault Reporting: {Location}", () =>
             pom.FilterTableFaultReportingBRDA(Summary, Location));


            
        }

        [When("I select no. {int} record from Fault Reporting table records")]
        public void WhenISelectNo_RecordFromFaultReportingTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Fault Reporting table records",
               () => pom.SelectNoRecordFromFaultReportingTableRecords(recordNumber));
        }

        [When("I verify Fault ID")]
        public void WhenIVerifyFaultID()
        {
            AllureLogger.LogStep("I verify Fault ID",
             pom.VerifyFaultID);
        }

        [When("I verify Fault Status")]
        public void WhenIVerifyFaultStatus()
        {
            AllureLogger.LogStep("I verify Fault Status",
             pom.VerifyFaultStatus);
        }

        [When("I verify Fault Location")]
        public void WhenIVerifyFaultLocation()
        {
            AllureLogger.LogStep("I verify Fault Location",
             pom.VerifyFaultLocation);
        }

        [When("I verify Fault Summary")]
        public void WhenIVerifyFaultSummary()
        {
            AllureLogger.LogStep("I verify Fault Summary",
             pom.VerifyFaultSummary);
        }

        [When("I take screenshot of Automatically create a fault ticket when toilet asset set to unavailable for a technical reason Test")]
        public void WhenITakeScreenshotOfAutomaticallyCreateAFaultTicketWhenToiletAssetSetToUnavailableForATechnicalReasonTest()
        {
            AllureLogger.LogStep("I take screenshot of Automatically create a fault ticket when toilet asset set to unavailable for a technical reason Test",
                pom.TakeScreenshotOfAutomaticallyCreateAFaultTicketWhenToiletAssetSetToUnavailableForATechnicalReasonTest);
        }


        //Email notification to TOC for change of status for toilet asset Step Definitions


        [Given("I select no. {int} record to view detials")]
        public void GivenISelectNo_RecordToViewDetials(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record to view detials",
              () => pom.SelectNoRecordToViewDetials(recordNumber));
        }

        [Given("I add Email Details:")]
        public void GivenIAddEmailDetails(Table table)
        {
            string Email = table.Rows[0]["Email"];
            AllureLogger.LogStep($"I add Email Address: {Email}", () =>
                pom.AddEmailDetails(Email));
        }
              

        [Given("I take screenshot of Email notification to TOC for change of status for toilet asset test")]
        public void GivenITakeScreenshotOfEmailNotificationToTOCForChangeOfStatusForToiletAssetTest()
        {
            AllureLogger.LogStep("I take screenshot of Email notification to TOC for change of status for toilet asset test",
                pom.TakeScreenshotOfEmailNotificationToTOCForChangeOfStatusForToiletAssetTest);
        }

        [Given("I take screenshot of Modify Email notification to TOC for change of status for toilet asset test")]
        public void GivenITakeScreenshotOfModifyEmailNotificationToTOCForChangeOfStatusForToiletAssetTest()
        {
            AllureLogger.LogStep("I take screenshot of Modify Email notification to TOC for change of status for toilet asset test",
                pom.TakeScreenshotOfModifyEmailNotificationToTOCForChangeOfStatusForToiletAssetTest);
        }





        // Toilet Checker Email Notification to Downstream Locations with Turnaround Capability and Stop Time Over 10 Minutes Step Definitions


        [Given("I take screenshot of View Toilet Status Test")]
        public void GivenITakeScreenshotOfViewToiletStatusTest()
        {
            AllureLogger.LogStep("I take screenshot of View Toilet Status Test",
                 pom.TakeScreenshotOfViewToiletStatusTest);
        }

        [Given("I open application Service Management \\(BRDF)")]
        public void GivenIOpenApplicationServiceManagementBRDF()
        {
            AllureLogger.LogStep("Open Go To Menu)",
               pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Fleet Availability Management(BRDF) Menu",
                pom.OpenFleetAvailabilityManagementBRDFMenu);
            AllureLogger.LogStep("Open Service Management (BRDF) ",
                pom.OpenServiceManagementBRDF);
        }

        [Given("I filter table Service Management:")]
        public void GivenIFilterTableServiceManagement(Table table)
        {
            string YardAsset = table.Rows[0]["Yard Asset"];
            AllureLogger.LogStep($"I filter table Service Management: {YardAsset}", () =>
                pom.FilterTableServiceManagement(YardAsset));
        }

        [Given("I select no.{int} record Service Management table records")]
        public void GivenISelectNo_RecordServiceManagementTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Service Management table records",
             () => pom.SelectNoRecordServiceManagementTableRecords(recordNumber));
        }

        [Given("I filter table Unit:")]
        public void GivenIFilterTableUnit(Table table)
        {
            string Unit = table.Rows[0]["Unit"];
            AllureLogger.LogStep($"I filter table Unit: {Unit}", () =>
                pom.FilterTableUnit(Unit));
        }

        [Given("I select no.{int} record Unit table records")]
        public void GivenISelectNo_RecordUnitTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Unit table records",
             () => pom.SelectNoRecordUnitTableRecords(recordNumber));
        }

        [Given("I view Unit record")]
        public void GivenIViewUnitRecord()
        {
            AllureLogger.LogStep("I view Unit record",
             pom.ViewUnitRecord);
        }


        [Given("I verify Unit Run Number")]
        public void GivenIVerifyUnitRunNumber()
        {
            AllureLogger.LogStep("I verify Unit Run number",
               pom.VerifyUnitRunNumber);
        }


        [Given(@"I copy (.*)")]
        public void GivenICopyField(string UnitRunNumber)
        {
            AllureLogger.LogStep($"I copy {UnitRunNumber}", () =>
            {
                string value = pom.CopyField(UnitRunNumber);
                scenarioContext[UnitRunNumber] = value;
            });
        }

        [Given("I press dialog button OK")]
        public void GivenIPressDialogButtonOK()
        {
            AllureLogger.LogStep("I press dialog button OK",
                 pom.PressDialogButtonOK);
        }
                 

        [Given("I open application Diagrams \\(BRDF)")]
        public void GivenIOpenApplicationDiagramsBRDF()
        {
            AllureLogger.LogStep("Open Go To Menu)",
               pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Fleet Availability Management(BRDF) Menu",
                pom.OpenFleetAvailabilityManagementBRDFMenu);
            AllureLogger.LogStep("Open Diagrams (BRDF) ",
                pom.OpenApplicationDiagramsBRDF);
        }

        [Given("I filter table Diagrams:")]
        public void GivenIFilterTableDiagrams(Table table)
        {
            string Diagrams = table.Rows[0]["Status"];
            AllureLogger.LogStep($"I filter table Diagrams: {Diagrams}", () =>
                pom.FilterTableDiagrams(Diagrams));
        }

        [Given("I select no.{int} record Diagrams table records")]
        public void GivenISelectNo_RecordDiagramsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Diagrams table records",
               () => pom.SelectNoRecordDiagramsTableRecords(recordNumber));
        }

        [Given("I select Filter Table option")]
        public void GivenISelectFilterTableOption()
        {
            AllureLogger.LogStep("I select Filter Table option",
                 pom.SelectFilterTableOption);
        }

        [When(@"I set Diagram ID field to (.*)")]
        [Given(@"I set Diagram ID field to (.*)")]
        public void SetDiagramIDFieldTo(string unitRunNumberKey)
        {
            AllureLogger.LogStep($"I set Diagram ID field using value from key: {unitRunNumberKey}", () =>
            {
                // ✅ Validate key exists
                if (!scenarioContext.TryGetValue(unitRunNumberKey, out object storedValue) || storedValue == null)
                {
                    throw new KeyNotFoundException(
                        $"No value found in ScenarioContext for key '{unitRunNumberKey}'. " +
                        $"Ensure the copy step executed successfully before this step.");
                }

                // ✅ Convert safely
                string copiedValue = storedValue.ToString().Trim();

                if (string.IsNullOrEmpty(copiedValue))
                    throw new Exception($"Stored value for key '{unitRunNumberKey}' is empty.");

                // ✅ Use POM method
                pom.SetDiagramId(copiedValue);
            });
        }

        [Given("I select no.{int} record Diagram ID records to view details")]
        public void GivenISelectNo_RecordDiagramIDRecordsToViewDetails(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Diagrams ID records to view details",
              () => pom.SelectNoRecordDiagramIDRecordsToViewDetails(recordNumber));
        }

        [Given("I select no.{int} record Diagram legs records to view details")]
        public void GivenISelectNo_RecordDiagramLegsRecordsToViewDetails(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Diagram legs records to view details",
              () => pom.SelectNoRecordDiagramLegsRecordsToViewDetails(recordNumber));
        }

        [Given("I take screenshot of Diagram Lines details")]
        public void GivenITakeScreenshotOfDiagramLinesDetails()
        {
            AllureLogger.LogStep("I take screenshot of Diagram Lines details",
                 pom.TakeScreenshotOfDiagramLinesDetails);
        }

        [Given("I filter table MXRMAILLIST:")]
        public void GivenIFilterTableMXRMAILLIST(Table table)
        {
            string MXRMAILLIST = table.Rows[0]["MXRMAILLIST"];
            AllureLogger.LogStep($"I filter table MXRMAILLIST: {MXRMAILLIST}", () =>
                pom.FilterTableMXRMAILLIST(MXRMAILLIST));
        }

        [Given("I select no. {int} record from MXRMAILLIST table records")]
        public void GivenISelectNo_RecordFromMXRMAILLISTTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from MXRMAILLIST table records",
             () => pom.SelectNoRecordFromMXRMAILLISTTableRecords(recordNumber));
        }

        [Given("I add following details:")]
        public void GivenIAddFollowingDetails(Table table)
        {
            string Email = table.Rows[0]["Email"];
            AllureLogger.LogStep($"I add Email details: {Email}", () =>
                pom.IAddEmailDetails(Email));
        }
                      

        [Given("I take screenshot of added email details")]
        public void GivenITakeScreenshotOfAddedEmailDetails()
        {
            AllureLogger.LogStep("I take screenshot of added email details",
                 pom.TakeScreenshotOfAddedEmailDetails);
        }

        [Given("I Unchecked the Needs Checking box")]
        public void GivenIUncheckedTheNeedsCheckingBox()
        {
            AllureLogger.LogStep("I Unchecked the Needs Checking box",
                pom.UncheckedTheNeedsCheckingBox);
        }

        [Given("I take screenshot of Unchecked the Needs Checking box")]
        public void GivenITakeScreenshotOfUncheckedTheNeedsCheckingBox()
        {
            AllureLogger.LogStep("I take screenshot of Unchecked the Needs Checking box",
                pom.TakeScreenshotOfUncheckedTheNeedsCheckingBox);
        }

        [Given("I checked the Needs Checking box")]
        public void GivenICheckedTheNeedsCheckingBox()
        {
            AllureLogger.LogStep("I Unchecked the Needs Checking box",
                pom.checkedTheNeedsCheckingBox);
        }

        [Given("I take screenshot of Checked the Needs Checking box")]
        public void GivenITakeScreenshotOfCheckedTheNeedsCheckingBox()
        {
            AllureLogger.LogStep("I take screenshot of Needs Checking box",
                pom.TakeScreenshotOfCheckedTheNeedsCheckingBox);
        }

        [Given("I take screenshot of Modify Email details")]
        public void GivenITakeScreenshotOfModifyEmailDetails()
        {
            AllureLogger.LogStep("I take screenshot of Modify Email details",
                pom.TakeScreenshotOfModifyEmailDetails);
        }










    }
}