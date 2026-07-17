using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using OpenQA.Selenium;
using Reqnroll;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GTR_AUTOMATED.StepDefinitions
{

    [Binding]
    public sealed class InventoryReportsStepDefinitions
    {

        private readonly IWebDriver driver;
        private readonly InventoryReportsPOM pom;

        public InventoryReportsStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new InventoryReportsPOM(driver);

        }


        [Given("I filter table Reports:")]
        public void GivenIFilterTableReports(Table table)
        {
            string Reports = table.Rows[0]["Reports"];
            AllureLogger.LogStep($"I filter table Reports: {Reports}", () =>
                pom.FilterTableReports(Reports));
        }

        [Given("I select no. {int} record from Reports table record")]
        public void GivenISelectNo_RecordFromReportsTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Reports table records",
            () => pom.SelectNoRecordFromReportsTableRecord(recordNumber));
        }

        [Given("I select start date and end date")]
        public void GivenISelectStartDateAndEndDate()
        {
            AllureLogger.LogStep("I select Start and End time",
            pom.ISetStartAndEndTime);
        }

        [Given("I submit First time Pickrate Report")]
        public void GivenISubmitFirstTimePickrateReport()
        {
            AllureLogger.LogStep("I submit First time Pickrate Report",
            pom.SubmitFirstTimePickrateReport);
        }

        [Given("I take screenshot of First time Pickrate Report test")]
        public void GivenITakeScreenshotOfFirstTimePickrateReportTest()
        {
            AllureLogger.LogStep("I take screenshot of First time Pickrate Report test",
            pom.TakeScreenshotOfInterDepotTransfer);
        }



        // FOS Report Step Definitions

        [Given("I filter table Historic Stock Report Storeroom:")]
        public void GivenIFilterTableHistoricStockReportStoreroom(Table table)
        {
            string Storeroom = table.Rows[0]["Storeroom"];
            AllureLogger.LogStep($"I filter table Historic Stock Report Storeroom: {Storeroom}", () =>
                pom.FilterTableHistoricStockReportStoreroom(Storeroom));
        }



        [Given("I enter Item number:")]
        public void GivenIEnterItemNumber(Table table)
        {
            string ItemNumber = table.Rows[0]["Item Number"];
            AllureLogger.LogStep($"I enter Item number: {ItemNumber}", () =>
                pom.EnterItemNumber(ItemNumber));
        }

        [Given("I submit FOS Report")]
        public void GivenISubmitFOSReport()
        {
            AllureLogger.LogStep("I submit FOS Report",
            pom.SubmitFOSReport);
        }

        [Given("I take screenshot of FOS Report test")]
        public void GivenITakeScreenshotOfFOSReportTest()
        {
            AllureLogger.LogStep("I take screenshot of First time Pickrate Report test",
            pom.ITakeScreenshotOfFOSReportTest);
        }





        //  Historic Stock Value Report Step Definitions


        [Given("I set start date and end date")]
        public void GivenISetStartDateAndEndDate()
        {
            AllureLogger.LogStep("I select Start and End time",
           pom.SetStartDateAndEndDate);
        }



        [Given("I select no. {int} record from storeroom table record")]
        public void GivenISelectNo_RecordFromStoreroomTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from storeroom table records",
            () => pom.SelectNoRecordFromStoreroomTableRecord(recordNumber));
        }

        [Given("I submit Historic Stock Value Report")]
        public void GivenISubmitHistoricStockValueReport()
        {
            AllureLogger.LogStep("I submit Historic Stock Value Report",
            pom.SubmitHistoricStockValueReport);
        }

        [Given("I take screenshot of Historic Stock Value Report test")]
        public void GivenITakeScreenshotOfHistoricStockValueReportTest()
        {
            AllureLogger.LogStep("I take screenshot of Historic Stock Value Report test",
            pom.TakeScreenshotOfHistoricStockValueReportTest);
        }




        // Inventory ABC Analysis Report Step Definitions


        [Given("I enter Storeroom:")]
        public void GivenIEnterStoreroom(Table table)
        {
            string Storeroom = table.Rows[0]["Storeroom"];
            AllureLogger.LogStep($"I enter Storeroom: {Storeroom}", () =>
                pom.EnterStoreroom(Storeroom));
        }

        [Given("I submit Inventory ABC Analysis Report")]
        public void GivenISubmitInventoryABCAnalysisReport()
        {
            AllureLogger.LogStep("I submit Inventory ABC Analysis Report",
            pom.SubmitInventoryABCAnalysisReport);
        }

        [Given("I take screenshot of Inventory ABC Analysis Report test")]
        public void GivenITakeScreenshotOfInventoryABCAnalysisReportTest()
        {
            AllureLogger.LogStep("I take screenshot of Inventory ABC Analysis Report test",
            pom.TakeScreenshotOfInventoryABCAnalysisReportTest);
        }




        // Inventory Balance Report Step Definitions



        [Given("I enter Inventory Balance Report Storeroom:")]
        public void GivenIEnterInventoryBalanceReportStoreroom(Table table)
        {
            string Storeroom = table.Rows[0]["Storeroom"];
            AllureLogger.LogStep($"I enter Inventory Balance Report Storeroom: {Storeroom}", () =>
                pom.EnterInventoryBalanceReportStoreroom(Storeroom));
        }

        [Given("I submit Inventory Balance Report")]
        public void GivenISubmitInventoryBalanceReport()
        {
            AllureLogger.LogStep("I submit Inventory Balance Report",
           pom.SubmitInventoryBalanceReport);
        }

        [Given("I take screenshot of Inventory Balance Report")]
        public void GivenITakeScreenshotOfInventoryBalanceReport()
        {
            AllureLogger.LogStep("I take screenshot of Inventory Balance Report",
           pom.TakeScreenshotOfInventoryBalanceReport);
        }


    }
}