using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using Reqnroll;


namespace GTR_AUTOMATED.StepDefinitions
{
    [Binding]

    public class FaultsStepDefinitions
    {

        private readonly IWebDriver driver;
        private readonly FAULTSPOM pom;

        public FaultsStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new FAULTSPOM(driver);

        }
                                 
                
        [Then("Relationship field has value FOLLOWUP")]
        public void ThenRelationshipFieldHasValueFOLLOWUP()
        {
            AllureLogger.LogStep("Relationship field has value FOLLOWUP",
                 pom.RelationshipFieldHasValueFOLLOWUP);
        }


        [Then("I take screenshot of Raising a Fault Test")]
        public void ThenITakeScreenshotOfRaisingAFaultTest()
        {
            AllureLogger.LogStep("I take screenshot of Raising a Fault Test",
              pom.TakeScreenshotOfRaisingAFaultTest);
        }


        //Raising a duplicate Fault in Fault Reporting Step Definitions



        [When("I filter table location:")]
        public void WhenIFilterTableLocation(Table table)
        {
            string location = table.Rows[0]["Location"];
            AllureLogger.LogStep($"I filter table Location: {location}", () =>
                pom.FilterTableLocation(location));
        }

        [Then("I take screenshot of Raising a duplicate Fault in Fault Reporting test")]
        public void ThenITakeScreenshotOfRaisingADuplicateFaultInFaultReportingTest()
        {
            AllureLogger.LogStep("I take screenshot of Raising a duplicate Fault in Fault Reporting test",
               pom.TakeScreenshotOfRaisingADuplicateFaultInFaultReportingTest);
        }


        //Fault Raised and closed by Fault Reporter Step Definitions


        [When("I press dialog button cancel")]
        public void WhenIPressDialogButtonCancel()
        {
            AllureLogger.LogStep("I press dialog button cancel",
             pom.PressDialogButtonCancel);
        }

        [When("I select action Create Work Order")]
        public void WhenISelectActionCreateWorkOrder()
        {
            AllureLogger.LogStep("I Select Actionl",
            pom.SelectAction);
            AllureLogger.LogStep("I Create Work Order Menu",
            pom.CreateWorkOrderMenu);
            AllureLogger.LogStep("I Create Work Order Menu",
           pom.CreateWorkOrderButton);
        }

        [When("I choose Select Value from Detail Menu of Repair Facility")]
        public void WhenIChooseSelectValueFromDetailMenuOfRepairFacility()
        {
            AllureLogger.LogStep("I Detail Menu of Repair Facility",
             pom.DetailMenuOfRepairFacility);
            AllureLogger.LogStep("I Select Value of Repair Facility",
            pom.SelectValueOfRepairFacility);
        }

        [When("I select no. {int} from Repair Facility table records")]
        public void WhenISelectNo_FromRepairFacilityTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Repair Facility table records",
           () => pom.SelectNoFromRepairFacilityTableRecords(recordNumber));
        }

        [When("I press dialog button ok")]
        public void WhenIPressDialogButtonOk()
        {
            AllureLogger.LogStep("I press dialog button ok",
             pom.PressDialogButtonOk);
        }

        [Then("I take screenshot of Fault Raised and closed by Fault Reporter Test")]
        public void ThenITakeScreenshotOfFaultRaisedAndClosedByFaultReporterTest()
        {
            AllureLogger.LogStep("I take screenshot of Fault Raised and closed by Fault Reporter Test",
               pom.TakeScreenshotOfFaultRaisedAndClosedByFaultReporterTest);
        }



        //Complete Fault Work Order Assignments Step Definitions


        [Given("I filter table:")]
        public void GivenIFilterTable(Table table)
        {
            string description = table.Rows[0]["Description"];
            string status = table.Rows[0]["Status"];
            pom.FilterTable(description, status);
        }

        [Given("I select Fault Work Order Faliure Informations")]
        public void GivenISelectFaultWorkOrderFaliureInformations()
        {
            AllureLogger.LogStep("I select cause codes",
            pom.CauseCodes);
            AllureLogger.LogStep("I select remedy codes",
            pom.RemedyCodes);
        }

        [Given("I go to Log Tab")]
        public void GivenIGoToLogTab()
        {
            AllureLogger.LogStep("I go to Log Tab",
             pom.GoToLogTab);
        }
        

        [Then("I take screenshot of Complete Fault Work Order Assignments Scenario one")]
        public void ThenITakeScreenshotOfCompleteFaultWorkOrderAssignmentsScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Complete Fault Work Order Assignments Scenario one",
               pom.TakeScreenshotOfCompleteFaultWorkOrderAssignmentsScenarioOne);
        }

        [Given("I take screenshot of Complete Fault Work Order Assignments Scenario two")]
        public void GivenITakeScreenshotOfCompleteFaultWorkOrderAssignmentsScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Complete Fault Work Order Assignments Scenario one",
              pom.TakeScreenshotOfCompleteFaultWorkOrderAssignmentsScenariotwo);
        }

                








    }
}