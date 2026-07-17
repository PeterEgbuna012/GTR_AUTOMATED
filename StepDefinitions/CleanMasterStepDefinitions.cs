using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using Reqnroll;
using System.Diagnostics.Metrics;

namespace GTR_AUTOMATED.StepDefinitions
{
    [Binding]
    public sealed class CleanMasterStepDefinitions
    {

        private readonly IWebDriver driver;
        private readonly CleanMastPOM pom;

        public CleanMasterStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new CleanMastPOM(driver);

        }
               
        [Given("I open application Clean Master Application \\(MXR)")]
        public void GivenIOpenApplicationCleanMasterApplicationMXR()
        {
            AllureLogger.LogStep("Open GoTO Menu Bar",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Work Order Menu",
                pom.WorkOrderMenu);
            AllureLogger.LogStep("Launch Clean Master Application (MXR)",
                pom.CleanMasterApplicationMXR);
        }

        [Given("I filter table All Unit:")]
        public void GivenIFilterTableAllUnit(Table table)
        {
            string All377Unit = table.Rows[0]["All 377 Unit"];
            AllureLogger.LogStep($"I filter table All {{int}} unit: {All377Unit}", () =>
                pom.FilterTableAllUnit(All377Unit));
        }
                    
       
        [Given("I view work order details")]
        public void GivenIViewWorkOrderDetails()
        {
            AllureLogger.LogStep("I view work order details",
             pom.ViewWorkOrderDetails);
        }

        [Given("I verify work order number")]
        public void GivenIVerifyWorkOrderNumber()
        {
            AllureLogger.LogStep("I verify work order number",
               pom.VerifyWorkOrderNumber);
        }

        [Given("I take screenshot of Clean Master - View Clean Master Work Orders test")]
        public void GivenITakeScreenshotOfCleanMaster_ViewCleanMasterWorkOrdersTest()
        {
            AllureLogger.LogStep("I take screenshot of Clean Master - View Clean Master Work Orders test",
            pom.TakeScreenshotOfCleanMaster_ViewCleanMasterWorkOrdersTest);
        }

        [Given("I close work order details")]
        public void GivenICloseWorkOrderDetails()
        {
            AllureLogger.LogStep("I view work order details",
             pom.CloseWorkOrderDetails);
        }




        // Clean Master - Complete a Clean Master Work Order Step Definitions



        [Given("I filter table clean master:")]
        public void GivenIFilterTableCleanMaster(Table table)
        {
            string CleanMaster = table.Rows[0]["Clean Master"];
            string CleanMasterDescription = table.Rows[0]["Description"];
            AllureLogger.LogStep($"I filter table clean master: {CleanMaster}", () =>
             pom.FilterTableCleanMaster(CleanMaster, CleanMasterDescription));
        }

        [Given("I complete clean master task")]
        public void GivenICompleteCleanMasterTask()
        {
            AllureLogger.LogStep("I complete clean master task",
             pom.CompleteCleanMasterTask);
        }

        [Given("I recomplete clean master task")]
        public void GivenIRecompleteCleanMasterTask()
        {
            AllureLogger.LogStep("I recomplete clean master task",
              pom.RecompleteCleanMasterTask);
        }

        [Given("I press dialog Ok  button")]
        public void GivenIPressDialogOkButton()
        {
            AllureLogger.LogStep("I press dialog Ok  button",
              pom.PressDialogOkButton);
        }

        [Given("I confirm task completion")]
        public void GivenIConfirmTaskCompletion()
        {
            AllureLogger.LogStep("I confirm task completion",
               pom.ConfirmTaskCompletion);
        }

        [Given("I take screenshot of Clean Master - Complete a Clean Master Work Order test")]
        public void GivenITakeScreenshotOfCleanMaster_CompleteACleanMasterWorkOrderTest()
        {
            AllureLogger.LogStep("I take screenshot of Clean Master - Complete a Clean Master Work Order test",
            pom.TakeScreenshotOfCleanMasterCompleteACleanMasterWorkOrderTest);
        }






        //Clean Master - Automatically Close a Clean Master Work Order Step Definitions





        [Given("I select no. {int} record from Search field table records")]
        public void GivenISelectNo_RecordFromSearchFieldTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from  Search field table records",
             () => pom.SelectNoRecordFromSearchFieldTableRecords(recordNumber));
        }



        [Given("I enter Escalations time:")]
        public void GivenIEnterEscalationsTime(Table table)
        {
            string EscalationsTime = table.Rows[0]["Time"];
            AllureLogger.LogStep($"I enter Escalations time: {EscalationsTime}", () =>
                pom.EnterEscalationsTime(EscalationsTime));
        }

        [Given("I click ok dailog button")]
        public void GivenIClickOkDailogButton()
        {
            AllureLogger.LogStep("I click ok dailog button",
               pom.ClickOkDailogButton);
        }
               

        [Given("I filter table Work Order Tracking \\(BRDA):")]
        public void GivenIFilterTableWorkOrderTrackingBRDA(Table table)
        {
            string WorkOrderDescription = table.Rows[0]["Description"];
            AllureLogger.LogStep($"I filter table Work Order Tracking (BRDA): {WorkOrderDescription}", () =>
                pom.FilterTableWorkOrderTrackingBRDA(WorkOrderDescription));
        }

        [Given("I take screenshot of Clean Master - Automatically Close a Clean Master Work Order test")]
        public void GivenITakeScreenshotOfCleanMaster_AutomaticallyCloseACleanMasterWorkOrderTest()
        {
            AllureLogger.LogStep("I take screenshot of Clean Master - Automatically Close a Clean Master Work Order test",
            pom.TakeScreenshotOfCleanMasterAutomaticallyCloseACleanMasterWorkOrderTest);
        }





        // Clean Master - Remove Labour Actuals from Clean Master Work Order Step Definitions





        [Given("I filter Work Type field:")]
        public void GivenIFilterWorkTypeField(Table table)
        {
            string WorkTypeField = table.Rows[0]["Work Type"];
            AllureLogger.LogStep($"I filter Work Type field: {WorkTypeField}", () =>
                pom.FilterWorkTypeField(WorkTypeField));
        }

        [Given("I select no. {int} record from Clean Master table records")]
        public void GivenISelectNo_RecordFromCleanMasterTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from  Clean Master table records",
             () => pom.SelectNoRecordFromCleanMasterTableRecords(recordNumber));
        }

        [Given("I remove labor assignments")]
        public void GivenIRemoveLaborAssignments()
        {
            AllureLogger.LogStep("I remove labor assignments",
               pom.RemoveLaborAssignments);
        }

        [Given("I take screenshot of Clean Master - Remove Labour Actuals from Clean Master Work Order test")]
        public void GivenITakeScreenshotOfCleanMaster_RemoveLabourActualsFromCleanMasterWorkOrderTest()
        {
            AllureLogger.LogStep("I take screenshot of Clean Master - Remove Labour Actuals from Clean Master Work Order test",
            pom.TakeScreenshotOfCleanMasterRemoveLabourActualsFromCleanMasterWorkOrderTest);
        }





    }
}