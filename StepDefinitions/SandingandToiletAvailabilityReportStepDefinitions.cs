using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OpenQA.Selenium;
using Reqnroll;
using Table = Reqnroll.Table;

namespace GTR_AUTOMATED.StepDefinitions
{
    [Binding]
    public sealed class SandingandToiletAvailabilityReportStepDefinitions
    {

        private readonly IWebDriver driver;
        private readonly SandingandToiletAvailabilityReportPOM pom;

        public SandingandToiletAvailabilityReportStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new SandingandToiletAvailabilityReportPOM(driver);
                      
        }

        [Given("I filter Reports table Records:")]
        public void GivenIFilterReportsTableRecords(Table table)
        {
            string Reports = table.Rows[0]["Reports"];
            AllureLogger.LogStep($"I filter Reports table: {Reports}", () =>
            pom.FilterReportsTableRecords(Reports));
        }

        [Given("I select no. {int} record from Sanding Reports table records")]
        public void GivenISelectNo_RecordFromSandingReportsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Sanding Reports table records",
             () => pom.SelectNoRecordFromSandingReportsTableRecords(recordNumber));
        }
        
        [Given("I enter Area:")]
        public void GivenIEnterArea(Table table)
        {
            string Area = table.Rows[0]["Area"];
            AllureLogger.LogStep($"I enter area: {Area}", () =>
            pom.EnterArea(Area));
        }

        [Given("I submit Sanding Report")]
        public void GivenISubmitSandingReport()
        {
            AllureLogger.LogStep("I submit Sanding Report",
              pom.SubmitSandingReport);
        }


        [Given("I take screenshot of Sanding Report")]
        public void GivenITakeScreenshotOfSandingReport()
        {
            AllureLogger.LogStep("I take screenshot of Sanding Report",
              pom.TakeScreenshotOfSandingReport);
        }


        // Toilet Availability Report Steps Definitions


        [Given("I filter Reports:")]
        public void GivenIFilterReports(Table table)
        {
            string Reports = table.Rows[0]["Reports"];
            AllureLogger.LogStep($"I filter Reports table: {Reports}", () =>
            pom.FilterReports(Reports));
        }


       

        [Given("I select no. {int} record from Train Toilet Availability Reports table records")]
        public void GivenISelectNo_RecordFromTrainToiletAvailabilityReportsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Train Toilet Availability Reports table records",
             () => pom.SelectNoRecordFromTrainToiletAvailabilityReportsTableRecords(recordNumber));
        }
     

        [Given("I submit Report")]
        public void GivenISubmitReport()
        {
            AllureLogger.LogStep("I submit Report",
             pom.SubmitReport);
        }

        [Given("I take screenshot of Toilet Availability Report")]
        public void GivenITakeScreenshotOfToiletAvailabilityReport()
        {
            AllureLogger.LogStep("I take screenshot of Toilet Availability Report",
             pom.TakeScreenshotOfToiletAvailabilityReport);
        }





    }
}