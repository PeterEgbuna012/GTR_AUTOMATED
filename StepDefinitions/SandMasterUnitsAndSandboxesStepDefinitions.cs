using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using OpenQA.Selenium;
using Reqnroll;
using System.Diagnostics.Metrics;
using Table = Reqnroll.Table;


namespace GTR_AUTOMATED.StepDefinitions
{
    [Binding]
    public sealed class SandMasterUnitsAndSandboxesStepDefinitions
    {

        private readonly IWebDriver driver;
        private readonly SandMasterPOM pom;

        public SandMasterUnitsAndSandboxesStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new SandMasterPOM(driver);

        }

        [Given("I open application Sand Master \\(MXR)")]
        public void GivenIOpenApplicationSandMasterMXR()
        {
            AllureLogger.LogStep("open Go To menu",
              pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Work Order Menu",
                pom.OpenWorkOrderMenu);
            AllureLogger.LogStep("Launch Sand Master Application",
                pom.OpenSandMasterMXRApplication);
        }


        [Given("I open application Sand Master \\(MXR) from Fav Menu")]
        public void GivenIOpenApplicationSandMasterMXRFromFavMenu()
        {

            AllureLogger.LogStep("I Go to Sanding Managment Tab",
            pom.SandingManagmentTab);
            AllureLogger.LogStep("I open application Sand Master (MXR) from Fav Menu",
             pom.OpenApplicationSandMasterMXRFromFavMenu);
        }

        [Given("I select unit {int} query")]
        public void GivenISelectUnitQuery(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from  unit {{int}} query table records",
            () => pom.SelectUnitQuery(recordNumber));
        }

        [Given("I view Sand Master Work Order details")]
        public void GivenIViewSandMasterWorkOrderDetails()
        {
            AllureLogger.LogStep("I view Sand Master Work Order details",
               pom.ViewSandMasterWorkOrderDetails);
            AllureLogger.LogStep("I Select View Sand Box button",
               pom.ViewSandBox);

        }

        [Given("I verify sand master Work Order details")]
        public void GivenIVerifySandMasterWorkOrderDetails()
        {
            AllureLogger.LogStep("I view Sand Master Work Order details",
                pom.VerifySandMasterWorkOrderDetails);
        }


        [Given("I take screenshot of View Sand Master Units and Sandboxes test")]
        public void GivenITakeScreenshotOfViewSandMasterUnitsAndSandboxesTest()
        {
            AllureLogger.LogStep("I take screenshot of View Sand Master Units and Sandboxes test",
                pom.TakeScreenshotOfViewSandMasterUnitsAndSandboxesTest);
        }





        // Complete a Sand Master Work Order Step Definitions


        [Given("I filter table Sand Master \\(MXR):")]
        public void GivenIFilterTableSandMasterMXR(Table table)
        {
            string SandMaster = table.Rows[0]["ID"];
            AllureLogger.LogStep($"I filter table Sand Master (MXR): {SandMaster}", () =>
                pom.FilterTableSandMasterMXR(SandMaster));
        }

        [Given("I select button Fill Sand Box")]
        public void GivenISelectButtonFillSandBox()
        {
            AllureLogger.LogStep("I select button Fill Sand Box",
               pom.SelectButtonFillSandBox);
        }

        [Given("I press the ok dialog button")]
        public void GivenIPressTheOkDialogButton()
        {
            AllureLogger.LogStep("I press the ok dialog button",
               pom.PressTheOkDialogButton);
        }

        [Given("I select Check Sand Box")]
        public void GivenISelectCheckSandBox()
        {
            AllureLogger.LogStep("I select Check Sand Box",
                pom.SelectCheckSandBox);

        }

        [Given("I verify SandBox level")]
        public void GivenIVerifySandBoxLevel()
        {
            AllureLogger.LogStep("I view SandBox level",
                pom.VerifySandBoxLevel);
        }

        [Given("I take screenshot of Complete a Sand Master Work Order test")]
        public void GivenITakeScreenshotOfCompleteASandMasterWorkOrderTest()
        {
            AllureLogger.LogStep("I take screenshot of Complete a Sand Master Work Order test",
               pom.TakeScreenshotOfCompleteASandMasterWorkOrderTest);
        }




        // Viewing a sanding log Step Definitions



        [Given("I select View Sanding Log")]
        public void GivenISelectViewSandingLog()
        {
            AllureLogger.LogStep("I select View Sanding Log",
                pom.SelectViewSandingLog);
        }

        [Given("I select value option Unit ID field")]
        public void GivenISelectValueOptionUnitIDField()
        {
            AllureLogger.LogStep("I select value option Unit ID field",
                pom.SelectValueOptionUnitIDField);
        }

        [Given("I filter table Unit ID:")]
        public void GivenIFilterTableUnitID(Table table)
        {
            string UnitID = table.Rows[0]["ID"];
            AllureLogger.LogStep($"I filter table Unit ID: {UnitID}", () =>
                pom.FilterTableUnitID(UnitID));
        }

        [Given("I select no. {int} record from Unit ID table records")]
        public void GivenISelectNo_RecordFromUnitIDTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Unit ID table records",
            () => pom.SelectNoRecordFromUnitIDTableRecords(recordNumber));
        }

        [Given("I select Refresh button")]
        public void GivenISelectRefreshButton()
        {
            AllureLogger.LogStep("I select Refresh button",
                pom.SelectRefreshButton);
        }

        [Given("I verify Unit ID changed")]
        public void GivenIVerifyUnitIDChanged()
        {
            AllureLogger.LogStep("I verify Unit ID changed",
              pom.VerifyUnitIDChanged);
        }

        [Given("I press dialog ok")]
        public void GivenIPressDialogOk()
        {
            AllureLogger.LogStep("I press dialog ok",
                pom.PressDialogOk);
        }

        [Given("I take screenshot of Viewing a sanding log")]
        public void GivenITakeScreenshotOfViewingASandingLog()
        {
            AllureLogger.LogStep("I take screenshot of Viewing a sanding log",
               pom.TakeScreenshotOfViewingASandingLog);
        }




        // Changing location of a person Step Definitions



        [Given("I select Change Person's Location")]
        public void GivenISelectChangePersonsLocation()
        {
            AllureLogger.LogStep("I select Change Person's Location",
               pom.SelectChangePersonsLocation);
        }

        [Given("I select value option of Person's Location field")]
        public void GivenISelectValueOptionOfPersonsLocationField()
        {
            AllureLogger.LogStep("I select value option of Person's Location field",
                pom.SelectValueOptionOfPersonsLocationField);
        }

        [Given("I select no. {int} record from Person's Location table records")]
        public void GivenISelectNo_RecordFromPersonsLocationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Person's Location table records",
            () => pom.SelectNoRecordFromPersonsLocationTableRecords(recordNumber));
        }

        [Given("I click dialog button ok")]
        public void GivenIClickDialogButtonOk()
        {
            AllureLogger.LogStep("I select Change Person's Location",
               pom.ClickDialogButtonOk);
        }

        [Given("I verify locatiom change")]
        public void GivenIVerifyLocatiomChange()
        {
            AllureLogger.LogStep("I verify locatiom change",
              pom.VerifyLocatiomChange);
        }

        [Given("I take screenshot of Changing location of a person test")]
        public void GivenITakeScreenshotOfChangingLocationOfAPersonTest()
        {
            AllureLogger.LogStep("I take screenshot of Changing location of a person test",
               pom.TakeScreenshotOfChangingLocationOfAPersonTest);
        }



    }
}