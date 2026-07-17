using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using Reqnroll;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GTR_AUTOMATED.StepDefinitions
{
    [Binding]
    public sealed class WorkOrderTrackingReportsStepDefinitions
    {

        private readonly IWebDriver driver;
        private readonly WorkOrderTrackingReportsPOM pom;

        public WorkOrderTrackingReportsStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new WorkOrderTrackingReportsPOM(driver);

        }
               
        [Given("I wait for Report page to load")]
        public void GivenIWaitForReportPageToLoad()
        {
            AllureLogger.LogStep("I wait for Report page to load",
                pom.WaitForReportPageToLoad);
        }

        [Given("I filter Report table:")]
        public void GivenIFilterReportTable(Table table)
        {
            string Report = table.Rows[0]["Report"];
            AllureLogger.LogStep($"I filter Report table: {Report}", () =>
            pom.FilterTableReports(Report));
        }

        [Given("I select no. {int} record from Reports table records")]
        public void GivenISelectNo_RecordFromReportsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Reports table records",
             () => pom.SelectNoRecordFromReportsTableRecords(recordNumber));
        }


        [Given("I set \\(Radio) Immediate field to Yes")]
        public void GivenISetRadioImmediateFieldToYes()
        {
              AllureLogger.LogStep("I set (Radio) Immediate field to Yes",
              pom.SetRadioImmediateFieldToYes);
        }

        [Given("I submit Work Order Details Report")]
        public void GivenISubmitWorkOrderDetailsReport()
        {
            AllureLogger.LogStep("I submit Work Order Details Report",
              pom.SubmitWorkOrderDetailsReport);
        }

        [Given("I take screenshot of Work Order Details Report")]
        public void GivenITakeScreenshotOfWorkOrderDetailsReport()
        {
            AllureLogger.LogStep("I take screenshot of Work Order Details Report",
              pom.TakeScreenshotOfWorkOrderDetailsReport);
        }




        // Campaigns Overview Step Definitions



        [Given("I enter period count:")]
        public void GivenIEnterPeriodCount(Table table)
        {
            string periodcount = table.Rows[0]["Period Count"];
            AllureLogger.LogStep($"I enter period count: {periodcount}", () =>
            pom.EnterPeriodCount(periodcount));
        }

        [Given("I submit campaigns overview report")]
        public void GivenISubmitCampaignsOverviewReport()
        {
              AllureLogger.LogStep("I submit Work Order Details Report",
              pom.SubmitCampaignsOverviewReport);
        }

        [Given("I take screenshot of Campaigns Overview")]
        public void GivenITakeScreenshotOfCampaignsOverview()
        {
            AllureLogger.LogStep("I take screenshot of Work Order Details Report",
              pom.TakeScreenshotOfCampaignsOverview);
        }




        // Compliance Overview Step Definitions




        [Given("I enter Compliance Details:")]
        public void GivenIEnterComplianceDetails(Table table)
        {
            string PeriodCount = table.Rows[0]["Period Count"];
            string AssetGroup = table.Rows[0]["Asset Group"];
            pom.EnterComplianceDetails(PeriodCount, AssetGroup);
        }

        [Given("I submit compliance overview report")]
        public void GivenISubmitComplianceOverviewReport()
        {
            AllureLogger.LogStep("I submit compliance overview report",
             pom.SubmitComplianceOverviewReport);
        }

        [Given("I take screenshot of Compliance Overview Report")]
        public void GivenITakeScreenshotOfComplianceOverviewReport()
        {
            AllureLogger.LogStep("I take screenshot of Compliance Overview Report",
            pom.TakeScreenshotOfComplianceOverviewReport);
        }





        // Fleet PM Overview Report Step Definitions




        [Given("I enter class of vehicle:")]
        public void GivenIEnterClassOfVehicle(Table table)
        {
            string ClassOfVehicle = table.Rows[0]["Class Of Vehicle"];
            AllureLogger.LogStep($"I enter Class Of Vehicle: {ClassOfVehicle}", () =>
            pom.EnterClassOfVehicle(ClassOfVehicle));
        }

        [Given("I submit fleet PM overview report")]
        public void GivenISubmitFleetPMOverviewReport()
        {
            AllureLogger.LogStep("I submit fleet PM overview report",
             pom.SubmitFleetPMOverviewReport);
        }

        [Given("I take screenshot of Fleet PM Overview Report")]
        public void GivenITakeScreenshotOfFleetPMOverviewReport()
        {
            AllureLogger.LogStep("I take screenshot of Fleet PM Overview Report",
            pom.TakeScreenshotOfFleetPMOverviewReport);
        }





        // Fleet Status Report Step Definitions





        [Given("I open Select Value lookup for Depot field")]
        public void GivenIOpenSelectValueLookupForDepotField()
        {
            AllureLogger.LogStep("I open Select Value lookup for Depot field",
              pom.OpenSelectValueLookupForDepotField);
        }

        [Given("I filter Depot table:")]
        public void GivenIFilterDepotTable(Table table)
        {
            string Depot = table.Rows[0]["Depot"];
            AllureLogger.LogStep($"I filter Depot table: {Depot}", () =>
            pom.FilterDepotTable(Depot));
        }

        [Given("I select no. {int} record from Depot table records")]
        public void GivenISelectNo_RecordFromDepotTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Depot table records",
             () => pom.SelectNoRecordFromDepotTableRecords(recordNumber));
        }

        [Given("I submit fleet status report")]
        public void GivenISubmitFleetStatusReport()
        {
            AllureLogger.LogStep("I submit fleet status report",
             pom.SubmitFleetStatusReport);
        }

        [Given("I take screenshot of Fleet Status Report")]
        public void GivenITakeScreenshotOfFleetStatusReport()
        {
            AllureLogger.LogStep("I take screenshot of Fleet Status Report",
            pom.TakeScreenshotOfFleetStatusReport);
        }





        // Frequency Based Maintenance Plan Step Definitions


        [Given("I enter Next Work Type:")]
        public void GivenIEnterNextWorkType(Table table)
        {
            string NextWorkType = table.Rows[0]["Next Work Type"];
            AllureLogger.LogStep($"I enter Next Work Type: {NextWorkType}", () =>
            pom.EnterNextWorkType(NextWorkType));
        }



        [Given("I submit frequency based maintenance plan report")]
        public void GivenISubmitFrequencyBasedMaintenancePlanReport()
        {
             AllureLogger.LogStep("I submit frequency based maintenance plan report",
             pom.SubmitFrequencyBasedMaintenancePlanReport);
        }

        [Given("I take screenshot of Frequency Based Maintenance Plan Report")]
        public void GivenITakeScreenshotOfFrequencyBasedMaintenancePlanReport()
        {
            AllureLogger.LogStep("I take screenshot of Frequency Based Maintenance Plan Report",
            pom.TakeScreenshotOfFrequencyBasedMaintenancePlanReport);
        }




        // Frequency Based PM Overview Step Definitions




        [Given("I enter Work Type:")]
        public void GivenIEnterWorkType(Table table)
        {
            string WorkType = table.Rows[0]["Work Type"];
            AllureLogger.LogStep($"I enter Work Type: {WorkType}", () =>
            pom.EnterWorkType(WorkType));
        }

        [Given("I submit Frequency Based PM Overview report")]
        public void GivenISubmitFrequencyBasedPMOverviewReport()
        {
             AllureLogger.LogStep("I submit Frequency Based PM Overview report",
             pom.SubmitFrequencyBasedPMOverviewReport);
        }

        [Given("I take screenshot of Frequency Based PM Overview Report")]
        public void GivenITakeScreenshotOfFrequencyBasedPMOverviewReport()
        {
            AllureLogger.LogStep("I take screenshot of Frequency Based PM Overview Report",
            pom.TakeScreenshotOfFrequencyBasedPMOverviewReport);
        }





        // Incompetent Labour Reports Step Definitions



        [Given("I enter Work Type Category:")]
        public void GivenIEnterWorkTypeCategory(Table table)
        {
            string WorkType = table.Rows[0]["Work Type"];
            AllureLogger.LogStep($"I enter Work Type Category: {WorkType}", () =>
            pom.EnterWorkTypeCategory(WorkType));
        }

        [Given("I enter Start and End Date:")]
        public void GivenIEnterStartAndEndDate(Table table)
        {
            string StartDate = table.Rows[0]["Start Date"];
            string EndDate = table.Rows[0]["End Date"];
            pom.EnterStartAndEndDate(StartDate, EndDate);
        }

        [Given("I submit incompetent labour report")]
        public void GivenISubmitIncompetentLabourReport()
        {
            AllureLogger.LogStep("I submit incompetent labour report",
             pom.SubmitIncompetentLabourReport);
        }

        [Given("I take screenshot of Incompetent Labour Reports")]
        public void GivenITakeScreenshotOfIncompetentLabourReports()
        {
            AllureLogger.LogStep("I take screenshot of Incompetent Labour Reports",
            pom.TakeScreenshotOfIncompetentLabourReports);
        }





        // Fleet Meter Based PM overview Step Definitions




        [Given("I enter class:")]
        public void GivenIEnterClass(Table table)
        {
            string Class = table.Rows[0]["Class"];
            AllureLogger.LogStep($"I enter class: {Class}", () =>
            pom.EnterClass(Class));
        }

        [Given("I submit Frequency Based Maintenance Plan")]
        public void GivenISubmitFrequencyBasedMaintenancePlan()
        {
            AllureLogger.LogStep("I submit Frequency Based Maintenance Plan report",
             pom.SubmitFrequencyBasedMaintenancePlan);
        }

        [Given("I take screenshot of Fleet Meter Based PM overview Report")]
        public void GivenITakeScreenshotOfFleetMeterBasedPMOverviewReport()
        {
            AllureLogger.LogStep("I take screenshot of Fleet Meter Based PM overview Report",
            pom.TakeScreenshotOfFleetMeterBasedPMOverviewReport);
        }




        // Mobile Work Order Completion Summary Report Step Definitions



        [Given("I set Start and End Date:")]
        public void GivenISetStartAndEndDate(Table table)
        {
            string StartDate = table.Rows[0]["Start Date"];
            string EndDate = table.Rows[0]["End Date"];
            pom.SetStartAndEndDate(StartDate, EndDate);
        }

        [Given("I submit mobile work order completion summary report")]
        public void GivenISubmitMobileWorkOrderCompletionSummaryReport()
        {
            AllureLogger.LogStep("I submit mobile work order completion summary report",
             pom.SubmitMobileWorkOrderCompletionSummaryReport);
        }

        [Given("I take screenshot of Mobile Work Order Completion Summary Report")]
        public void GivenITakeScreenshotOfMobileWorkOrderCompletionSummaryReport()
        {
            AllureLogger.LogStep("I take screenshot of Mobile Work Order Completion Summary Report",
            pom.TakeScreenshotOfMobileWorkOrderCompletionSummaryReport);
        }






        //New WO vs Close WO over time Step Definitions




        [Given("I set report Start and End Date:")]
        public void GivenISetReportStartAndEndDate(Table table)
        {
            string StartDate = table.Rows[0]["Start Date"];
            string EndDate = table.Rows[0]["End Date"];
            pom.SetReportStartAndEndDate(StartDate, EndDate);
        }

        [Given("I enter report details:")]
        public void GivenIEnterReportDetails(Table table)
        {
            string WorkType = table.Rows[0]["Work Type"];
            string Location = table.Rows[0]["Location"];
            pom.EnterReportDetails(WorkType, Location);
        }

        [Given("I submit new WO vs close WO over time report")]
        public void GivenISubmitNewWOVsCloseWOOverTimeReport()
        {
            AllureLogger.LogStep("I submit new WO vs close WO over time report",
            pom.SubmitNewWOVsCloseWOOverTimeReport);
        }

        [Given("I take screenshot of New WO vs Close WO over time Report")]
        public void GivenITakeScreenshotOfNewWOVsCloseWOOverTimeReport()
        {
            AllureLogger.LogStep("I take screenshot of New WO vs Close WO over time Report",
            pom.TakeScreenshotOfNewWOVsCloseWOOverTimeReport);
        }





        // Work Orders Awaiting Material Step Definitions




        [Given("I enter report Start and End Date:")]
        public void GivenIEnterReportStartAndEndDate(Table table)
        {
            string StartDate = table.Rows[0]["Start Date"];
            string EndDate = table.Rows[0]["End Date"];
            pom.EnterReportStartAndEndDate(StartDate, EndDate);
        }

        [Given("I enter Location:")]
        public void GivenIEnterLocation(Table table)
        {
            string Location = table.Rows[0]["Location"];
            AllureLogger.LogStep($"I enter Location: {Location}", () =>
            pom.EnterLocation(Location));
        }

        [Given("I submit Number of Work Orders Awaiting Materials and Average Time Open report")]
        public void GivenISubmitNumberOfWorkOrdersAwaitingMaterialsAndAverageTimeOpenReport()
        {
            AllureLogger.LogStep("I submit Number of Work Orders Awaiting Materials and Average Time Open report",
            pom.SubmitNumberOfWorkOrdersAwaitingMaterialsAndAverageTimeOpenReport);
        }

        [Given("I take screenshot of Work Orders Awaiting Material Report")]
        public void GivenITakeScreenshotOfWorkOrdersAwaitingMaterialReport()
        {
            AllureLogger.LogStep("I take screenshot of Work Orders Awaiting Material Report",
            pom.TakeScreenshotOfWorkOrdersAwaitingMaterialReport);
        }




        // Repeat Failure Step Definitions




        [Given("I enter Target Date:")]
        public void GivenIEnterTargetDate(Table table)
        {
            string TargetDate = table.Rows[0]["Target Date"];
            AllureLogger.LogStep($"I enter Target Date: {TargetDate}", () =>
            pom.EnterTargetDate(TargetDate));
        }

        [Given("I enter repeat failure report details:")]
        public void GivenIEnterRepeatFailureReportDetails(Table table)
        {

            string PeriodCount = table.Rows[0]["Period Count"];
            string LocationClass = table.Rows[0]["Location Class"];
            pom.EnterRepeatFailureReportDetails(PeriodCount, LocationClass);

        }

        [Given("I submit Failure Report")]
        public void GivenISubmitFailureReport()
        {
            AllureLogger.LogStep("I submit Failure Report",
            pom.SubmitFailureReport);
        }

        [Given("I take screenshot of Repeat Failure Report")]
        public void GivenITakeScreenshotOfRepeatFailureReport()
        {
            AllureLogger.LogStep("I take screenshot of Repeat Failure Report",
            pom.TakeScreenshotOfRepeatFailureReport);
        }




        // Staff Productivity Step Definitions




        [Given("I enter Start Date and End Date:")]
        public void GivenIEnterStartDateAndEndDate(Table table)
        {
            string StartDate = table.Rows[0]["Start Date"];
            string EndDate = table.Rows[0]["End Date"];
            pom.EnterStartDateAndEndDate(StartDate, EndDate);
        }

        [Given("I submit Staff Productivity Report")]
        public void GivenISubmitStaffProductivityReport()
        {
            AllureLogger.LogStep("I submit Staff Productivity Report",
            pom.SubmitStaffProductivityReport);
        }

        [Given("I take screenshot of Staff Productivity Report")]
        public void GivenITakeScreenshotOfStaffProductivityReport()
        {
            AllureLogger.LogStep("I take screenshot of Staff Productivity Report",
            pom.TakeScreenshotOfStaffProductivityReport);
        }





        // Total time per exam/block/task Step Definitions




        [Given("I enter Report Start Date and End Date:")]
        public void GivenIEnterReportStartDateAndEndDate(Table table)
        {
            string StartDate = table.Rows[0]["Start Date"];
            string EndDate = table.Rows[0]["End Date"];
            pom.EnterReportStartDateAndEndDate(StartDate, EndDate);
        }

        [Given("I submit Total Time per Task Block Exam Report")]
        public void GivenISubmitTotalTimePerTaskBlockExamReport()
        {
            AllureLogger.LogStep("I submit Total Time per Task Block Exam Report",
            pom.SubmitTotalTimePerTaskBlockExamReport);
        }

        [Given("I take screenshot of Total time per exam block task Report")]
        public void GivenITakeScreenshotOfTotalTimePerExamBlockTaskReport()
        {
            AllureLogger.LogStep("I take screenshot of Total time per exam block task Report",
             pom.TakeScreenshotOfTotalTimePerExamBlockTaskReport);
        }





        // Unit Mileage & Last Service Date Step Definitions



        [Given("I enter report class:")]
        public void GivenIEnterReportClass(Table table)
        {
            string Class = table.Rows[0]["Class"];
            AllureLogger.LogStep($"I enter report class: {Class}", () =>
            pom.EnterReportClass(Class));
        }

        [Given("I submit Unit Mileage & Last Service Date Report")]
        public void GivenISubmitUnitMileageLastServiceDateReport()
        {
            AllureLogger.LogStep("I submit Unit Mileage & Last Service Date Report",
            pom.SubmitUnitMileageLastServiceDateReport);
        }

        [Given("I take screenshot of Unit Mileage & Last Service Date Report")]
        public void GivenITakeScreenshotOfUnitMileageLastServiceDateReport()
        {
            AllureLogger.LogStep("I take screenshot of Unit Mileage & Last Service Date Report",
            pom.TakeScreenshotOfUnitMileageLastServiceDateReport);
        }




        // Work Undertaken by Individual Step Definitions




        [Given("I set report start date and end date:")]
        public void GivenISetReportStartDateAndEndDate(Table table)
        {
            string StartDate = table.Rows[0]["Start Date"];
            string EndDate = table.Rows[0]["End Date"];
            pom.IEnterReportStartDateAndEndDate(StartDate, EndDate);
        }
            

        [Given("I enter maintainer:")]
        public void GivenIEnterMaintainer(Table table)
        {
            string Maintainer = table.Rows[0]["Maintainer"];
            AllureLogger.LogStep($"I enter maintainer: {Maintainer}", () =>
            pom.EnterMaintainer(Maintainer));
        }

        [Given("I submit Work Undertaken by Individual Report")]
        public void GivenISubmitWorkUndertakenByIndividualReport()
        {
            AllureLogger.LogStep("I submit Work Undertaken by Individual Report",
            pom.SubmitWorkUndertakenByIndividualReport);
        }

        [Given("I take screenshot of Work Undertaken by Individual Report")]
        public void GivenITakeScreenshotOfWorkUndertakenByIndividualReport()
        {
            AllureLogger.LogStep("I take screenshot of Work Undertaken by Individual Report",
            pom.TakeScreenshotOfWorkUndertakenByIndividualReport);
        }





        // Work Order List Report Step Definitions





        [Given("I filter table Work Order:")]
        public void GivenIFilterTableWorkOrder(Table table)
        {
            string WorkType = table.Rows[0]["Work Type"];
            string Status = table.Rows[0]["Status"];
            string RepairFacility = table.Rows[0]["Repair Facility"];
            pom.FilterTableWorkOrder(WorkType, Status, RepairFacility);
        }

        [Given("I submit Work Order List Report")]
        public void GivenISubmitWorkOrderListReport()
        {
            AllureLogger.LogStep("I submit Work Order List Report",
            pom.SubmitWorkOrderListReport);
        }

        [Given("I take screenshot of Work Order List Report")]
        public void GivenITakeScreenshotOfWorkOrderListReport()
        {
            AllureLogger.LogStep("I take screenshot of Work Order List Report",
            pom.TakeScreenshotOfWorkOrderListReport);
        }






        // Work Arising Report Step Definitions





        [Given("I submit Work Arising Report")]
        public void GivenISubmitWorkArisingReport()
        {
            AllureLogger.LogStep("I submit Work Arising Report",
            pom.SubmitWorkArisingReport);
        }

        [Given("I take screenshot of Work Arising Report")]
        public void GivenITakeScreenshotOfWorkArisingReport()
        {
            AllureLogger.LogStep("I take screenshot of Work Arising Report",
            pom.TakeScreenshotOfWorkArisingReport);
        }





        // Work Bank Size Report Step Definitions





        [Given("I enter Work Bank Size Report Details:")]
        public void GivenIEnterWorkBankSizeReportDetails(Table table)
        {
            string OwnerGroup = table.Rows[0]["Owner Group"];
            string RepairFacility = table.Rows[0]["Repair Facility"];
            string WorkType = table.Rows[0]["Work Type"];
            pom.WorkBankSizeReportDetails(OwnerGroup, RepairFacility, WorkType);
        }
              

        [Given("I submit Work Bank Size Summary Report")]
        public void GivenISubmitWorkBankSizeSummaryReport()
        {
            AllureLogger.LogStep("I submit Work Bank Size Summary Report",
            pom.SubmitWorkBankSizeSummaryReport);
        }

        [Given("I take screenshot of Work Bank Size Report")]
        public void GivenITakeScreenshotOfWorkBankSizeReport()
        {
            AllureLogger.LogStep("I take screenshot of Work Bank Size Report",
            pom.TakeScreenshotOfWorkBankSizeReport);
        }






    }
}