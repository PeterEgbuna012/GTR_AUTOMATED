using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using Reqnroll;
using System.Diagnostics.Contracts;
using System.Security.Claims;
using GivenAttribute = Reqnroll.GivenAttribute;
using Table = Reqnroll.Table;

namespace GTR_AUTOMATED.StepDefinitions
{
    [Binding]
    public sealed class DefectiveAssetManagementStepDefinitions
    {

        private readonly IWebDriver driver;
        private readonly DEFECTIVEASSETMANAGEMENTPOM pom;

        public DefectiveAssetManagementStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new DEFECTIVEASSETMANAGEMENTPOM(driver);

        }
          

        [Given("I select assets from production drop-off location portlet")]
        public void GivenISelectAssetsFromProductionDrop_OffLocationPortlet()
        {
            AllureLogger.LogStep("I go to assets in production drop-off location portlet",
             pom.SelectAssetsFromProductionDropOffLocationPortlet);
        }
              

        [Given("I select action Move Asset")]
        public void GivenISelectActionMoveAsset()
        {
            AllureLogger.LogStep("I Select Action",
            pom.SelectAction);

            AllureLogger.LogStep("Move Asset",
            pom.MoveAsset);
        }

        [Given("I select Move Modify Asset")]
        public void GivenISelectMoveModifyAsset()
        {
            AllureLogger.LogStep("I select Move Modify Asset",
            pom.SelectMoveModifyAsset);
        }

        [Given("I choose Select Value from Detail Menu of location")]
        public void GivenIChooseSelectValueFromDetailMenuOfLocation()
        {
            AllureLogger.LogStep("Detail Menu of location",
            pom.DetailMenuOfLocation);
            AllureLogger.LogStep("Select Value of location",
            pom.SelectValueOfLocation);
        }
               
        [Given("I filter table location:")]
        public void GivenIFilterTableLocation(Table table)
        {
            string location = table.Rows[0]["location"];
            AllureLogger.LogStep($"I filter table Vendor Items: {location}", () =>
                pom.FilterTableLocation(location));
        }

        [Given("I select no. {int} record from location table record")]
        public void GivenISelectNo_RecordFromLocationTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from  location table records",
             () => pom.SelectNoRecordFromLocationTableRecord(recordNumber));
        }
               
        [Given("I select apply button")]
        public void GivenISelectApplyButton()
        {
            AllureLogger.LogStep("I select apply button",
           pom.SelectApplyButton);
        }

        [Given("I press Ok")]
        public void GivenIPressOk()
        {
            AllureLogger.LogStep("I press Ok",
             pom.PressOk);
        }

        [Given("I press Ok dilaog to close system message")]
        public void GivenIPressOkDilaogToCloseSystemMessage()
        {
            AllureLogger.LogStep("I press Ok dilaog to close system message",
           pom.PressOkDilaogToCloseSystemMessage);
        }

        [Given("I take screenshot of Move Defective Asset from Drop-Off Location test")]
        public void GivenITakeScreenshotOfMoveDefectiveAssetFromDrop_OffLocationTest()
        {
            AllureLogger.LogStep("I take screenshot of Move Defective Asset from Drop-Off Location test",
             pom.TakeScreenshotOfMoveDefectiveAssetFromDrop_OffLocationTest);
        }



        //Raising a Warranty Claim Step Definitions
                      

        [Given("I open application Warranty Claims \\(Tr)")]
        public void GivenIOpenApplicationWarrantyClaimsTr()
        {
            AllureLogger.LogStep("Open [Go To] menu",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Warranity Menu",
                pom.WarranityMenu);
            AllureLogger.LogStep("Launch Warranty Claims Tr",
                pom.WarrantyClaimsTr);
        }

        [Given("I select create new clams button")]
        public void GivenISelectCreateNewClamsButton()
        {
            AllureLogger.LogStep("I select create new clams button",
           pom.SelectCreateNewClamsButton);
        }

        [Given("I enter Clams Details:")]
        public void GivenIEnterClamsDetails(Table table)
        {
            string Clams = table.Rows[0]["Clams Description"];
            AllureLogger.LogStep($"I enter Clams Details: {Clams}", () =>
                pom.FilterTableClams(Clams));
        }
                      

        [Given("I choose select value from detail menu of asset field")]
        public void GivenIChooseSelectValueFromDetailMenuOfAssetField()
        {
            AllureLogger.LogStep("Detail Menu Of Asset",
            pom.DetailMenuOfAsset);

            AllureLogger.LogStep("I Select Value Of Asset",
           pom.SelectValueOfAsset);
        }

        [Given("I filter table Asset:")]
        public void GivenIFilterTableAsset(Table table)
        {
            string asset = table.Rows[0].ContainsKey("Asset") ? table.Rows[0]["Asset"] : string.Empty;
            string Location = table.Rows[0].ContainsKey("Location") ? table.Rows[0]["Location"] : string.Empty;

            AllureLogger.LogStep($"I filter table Asset using Asset: '{asset}' or Location: '{Location}'", () =>
                pom.FilterTableAsset(asset, Location));
        }

        [Given("I select no. {int} record from asset table record")]
        public void GivenISelectNo_RecordFromAssetTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from  asset table records",
              () => pom.SelectNoRecordFromAssetTableRecord(recordNumber));
        }

        [Given("I set \\(Radio) field to Submit Claim")]
        public void GivenISetRadioFieldToSubmitClaim()
        {
            AllureLogger.LogStep("I set (Radio) field to Submit Claim",
            pom.SetRadioFieldToSubmitClaim);
        }

        [Given("I Press dialog button OK")]
        public void GivenIPressDialogButtonOK()
        {
            AllureLogger.LogStep("I press dialog button OK",
            pom.PressDialogButtonOK);
        }

        [Given("I change clams status to Waiting on Approval \\(WAPPR)")]
        public void GivenIChangeClamsStatusToWaitingOnApprovalWAPPR()
        {
            AllureLogger.LogStep("I Change Clams Status",
            pom.ChangeClamsStatus);

            AllureLogger.LogStep("DropDown Option button",
            pom.DropDownOption);

            AllureLogger.LogStep("I Select Status Waiting On Approval WAPPR",
            pom.StatusToWaitingOnApprovalWAPPR);
        }

        [Given("I Press dialog button OK system message")]
        public void GivenIPressDialogButtonOKSystemMessage()
        {
            AllureLogger.LogStep("I press dialog button OK system message",
           pom.PressDialogButtonOKSystemMessage);
        }

        [Given("I go to clams Log tab")]
        public void GivenIGoToClamsLogTab()
        {
            AllureLogger.LogStep("I go to clams Log tab",
           pom.GoToClamsLogTab);
        }

        [Given("I select the New Row button")]
        public void GivenISelectTheNewRowButton()
        {
            AllureLogger.LogStep("I select the New Row button",
           pom.SelectTheNewRowButton);
        }

        [Given("I enter following claim logs:")]
        public void GivenIEnterFollowingClaimLogs(Table table)
        {
            string Summary = table.Rows[0]["Summary"];
            string Details = table.Rows[0]["Details"];
            pom.EnterFollowingClaimLogs(Summary, Details);
        }

        [Given("I go to claim tab")]
        public void GivenIGoToClaimTab()
        {
            AllureLogger.LogStep("I go to claim tab",
           pom.GoToClaimTab);
        }

        [Given("I enter following claim data:")]
        public void GivenIEnterFollowingClaimData(Table table)
        {
            string RMAReference = table.Rows[0]["RMA Reference"];
            string MissedPeaks = table.Rows[0]["Missed Peaks"];
            pom.EnterFollowingClaimData(RMAReference, MissedPeaks);
        }

        [Given("I choose select value from detail menu of contract field")]
        public void GivenIChooseSelectValueFromDetailMenuOfContractField()
        {
            AllureLogger.LogStep("Detail Menu Of Contract",
             pom.DetailMenuOfContract);
           AllureLogger.LogStep("Select Value Of Contract",
           pom.SelectValueOfContract);
        }

        [Given("I filter table contract:")]
        public void GivenIFilterTableContract(Table table)
        {
            string Contract = table.Rows[0]["Contract"];
            AllureLogger.LogStep($"I filter table Contract: {Contract}", () =>
                pom.FilterTableContract(Contract));
        }

        [Given("I select no. {int} record from contract table records")]
        public void GivenISelectNo_RecordFromContractTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from  contract table records",
             () => pom.SelectNoRecordFromContractTableRecords(recordNumber));
        }

        [Given("I enter claim data:")]
        public void GivenIEnterClaimData(Table table)
        {
            string Cost = table.Rows[0]["Cost"];
            string ClaimedAmount = table.Rows[0]["Claimed Amount"];
            pom.EnterClaimData(Cost, ClaimedAmount);
        }

        [Given("I select Approve claim")]
        public void GivenISelectApproveClaim()
        {
            AllureLogger.LogStep("I select Approve claim",
            pom.SelectApproveClaim);
        }

        [Given("I click dialog OK button")]
        public void GivenIClickDialogOKButton()
        {
            AllureLogger.LogStep("I select Approve claim",
           pom.ClickDialogOKButton);
        }

        [Given("I verify claims status")]
        public void GivenIVerifyClaimsStatus()
        {
            AllureLogger.LogStep("I verify SUBMITTED Status",
              pom.VerifyClaimsStatus);
        }

        [Given("I take screenshot of Raising a Warranty Claim")]
        public void GivenITakeScreenshotOfRaisingAWarrantyClaim()
        {
            AllureLogger.LogStep("I take screenshot of Raising a Warranty Claim",
            pom.TakeScreenshotOfRaisingAWarrantyClaim);
        }




        // Sending assets away on a Despatch record Step Definitions 



        [Given("I select new MXRDESPATCH")]
        public void GivenISelectNewMXRDESPATCH()
        {
            AllureLogger.LogStep("I select new MXRDESPATCH",
            pom.SelectNewMXRDESPATCH);
        }

        [Given("I enter Despatch Details:")]
        public void GivenIEnterDespatchDetails(Table table)
        {
            string DespatchDescription = table.Rows[0]["Despatch Description"];
            AllureLogger.LogStep($"I enter Despatch Details: {DespatchDescription}", () =>
                pom.EnterDespatchDetails(DespatchDescription));
        }

        [Given("I choose Select Value from Detail Menu of Despatch location")]
        public void GivenIChooseSelectValueFromDetailMenuOfDespatchLocation()
        {
            AllureLogger.LogStep("Detail Menu of location",
            pom.DetailMenuOfDespatchLocation);
            AllureLogger.LogStep("Select Value of location",
            pom.SelectValueOfDespatchLocation);
        }

        [Given("I filter table Despatch location:")]
        public void GivenIFilterTableDespatchLocation(Table table)
        {
            string location = table.Rows[0]["Despatch location"];
            AllureLogger.LogStep($"I filter table Despatch location: {location}", () =>
                pom.FilterTableDespatchLocation(location));
        }

        [Given("I select no. {int} record from Despatch location table record")]
        public void GivenISelectNo_RecordFromDespatchLocationTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Despatch location table records",
             () => pom.SelectNoRecordFromDespatchLocationTableRecord(recordNumber));
        }

        [Given("I enter Vendor data:")]
        public void GivenIEnterVendorData(Table table)
        {
            string VendorItems = table.Rows[0]["Vendor Items"];
            AllureLogger.LogStep($"I enter Vendor data: {VendorItems}", () =>
                pom.EnterVendorData(VendorItems));
        }

        [Given("I choose Select Value from Detail Menu of Vendor Location")]
        public void GivenIChooseSelectValueFromDetailMenuOfVendorLocation()
        {
            AllureLogger.LogStep("Detail Menu of Vendor location",
           pom.DetailMenuOfVendorLocation);
            AllureLogger.LogStep("Select Value of Vendor location",
            pom.SelectValueOfVendorLocation);
        }

        [Given("I filter table Vendor location:")]
        public void GivenIFilterTableVendorLocation(Table table)
        {
            string Vendorlocation = table.Rows[0]["Vendor location"];
            AllureLogger.LogStep($"I filter table Vendor location: {Vendorlocation}", () =>
                pom.FilterTableVendorLocation(Vendorlocation));
        }

        [Given("I select no. {int} record from Vendor location table record")]
        public void GivenISelectNo_RecordFromVendorLocationTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Vendor location table records",
            () => pom.SelectNoRecordFromVendorLocationTableRecord(recordNumber));
        }

        [Given("I choose Select Value from Detail Menu of Return location")]
        public void GivenIChooseSelectValueFromDetailMenuOfReturnLocation()
        {
            AllureLogger.LogStep("Detail Menu of Return location",
           pom.DetailMenuOfReturnLocation);
            AllureLogger.LogStep("Select Value of Return location",
            pom.SelectValueOfReturnLocation);
        }

        [Given("I filter table Return location:")]
        public void GivenIFilterTableReturnLocation(Table table)
        {
            string Returnlocation = table.Rows[0]["Return location"];
            AllureLogger.LogStep($"I filter table Return location: {Returnlocation}", () =>
                pom.FilterTableReturnLocation(Returnlocation));
        }

        [Given("I select no. {int} record from Return location table record")]
        public void GivenISelectNo_RecordFromReturnLocationTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Return location table records",
            () => pom.SelectNoRecordFromReturnLocationTableRecord(recordNumber));
        }


        [Given("I go to Despatch Lines tab")]
        public void GivenIGoToDespatchLinesTab()
        {
            AllureLogger.LogStep("I go to Despatch Lines tab",
              pom.GoToDespatchLinesTab);
        }

        [Given("I select new row button")]
        public void GivenISelectNewRowButton()
        {
            AllureLogger.LogStep("I select new row button",
            pom.SelectNewRowButton);
        }

        [Given("I choose select value from detail menu for asset field")]
        public void GivenIChooseSelectValueFromDetailMenuForAssetField()
        {
            AllureLogger.LogStep("Detail Menu For Asset",
             pom.DetailMenuForAsset);
            AllureLogger.LogStep("I Select Value For Asset",
            pom.SelectValueForAsset);
        }

        [Given("I select change status")]
        public void GivenISelectChangeStatus()
        {
            AllureLogger.LogStep("I select change status",
             pom.SelectChangeStatus);

        }

        [Given("I set \\(Radio) field to Despatched")]
        public void GivenISetRadioFieldToDespatched()
        {
            AllureLogger.LogStep("Status Dropdwon Menu",
             pom.StatusDropdwonMenuOption);
            AllureLogger.LogStep("I set (Radio) field to Despatched",
             pom.SetRadioFieldToDespatched);
        }

        [Given("I click the OK dialog button")]
        public void GivenIClickTheOKDialogButton()
        {
            AllureLogger.LogStep("I click the OK dialog button",
             pom.ClickTheOKDialogButton);
        }

        [Given("I take screenshot of DESPATCHED status")]
        public void GivenITakeScreenshotOfDESPATCHEDStatus()
        {
            AllureLogger.LogStep("I take screenshot of DESPATCHED status",
             pom.TakeScreenshotOfDESPATCHEDStatus);
        }

        [Given("I select action Run Report")]
        public void GivenISelectActionRunReport()
        {
            AllureLogger.LogStep("I Select Action",
             pom.SelectAction);
            AllureLogger.LogStep("I Run Report",
             pom.RunReport);
        }

        [Given("I filter Report:")]
        public void GivenIFilterReport(Table table)
        {
            string Report = table.Rows[0]["Report"];
            AllureLogger.LogStep($"I filter table Report: {Report}", () =>
                pom.FilterReport(Report));
        }

        [Given("I select no. {int} record from Despatch Report table record")]
        public void GivenISelectNo_RecordFromDespatchReportTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Return Despatch Report table records",
            () => pom.SelectNoRecordFromDespatchReportTableRecord(recordNumber));
        }


        [Given("I Submit Despatch Report")]
        public void GivenISubmitDespatchReport()
        {
            AllureLogger.LogStep("I Submit Despatch Report",
             pom.SubmitDespatchReport);
        }

        [Given("I take screenshot of Sending assets away on a Despatch record test")]
        public void GivenITakeScreenshotOfSendingAssetsAwayOnADespatchRecordTest()
        {
            AllureLogger.LogStep("I take screenshot of Sending assets away on a Despatch record test",
              pom.TakeScreenshotOfSendingAssetsAwayOnADespatchRecordTest);
        }





        //Returning assets on a Despatch record Step Definitions


        [Given("I open application Despatches \\(MXR) from Fav Menu")]
        public void GivenIOpenApplicationDespatchesMXRFromFavMenu()
        {
            AllureLogger.LogStep("I open application Despatches (MXR) from Fav Menu",
              pom.OpenApplicationDespatchesMXRFromFavMenu);
        }

        [Given("I filter table Despatches:")]
        public void GivenIFilterTableDespatches(Table table)
        {
            string Despatches = table.Rows[0]["Despatches"];
            string Status = table.Rows[0]["Status"];
            AllureLogger.LogStep($"I filter table Despatches: {Despatches} , Status: {Status}", () =>
                pom.FilterTableDespatches(Despatches, Status));
        }

        [Given("I select no. {int} record from Despatches table record")]
        public void GivenISelectNo_RecordFromDespatchesTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Despatches table records",
           () => pom.SelectNoRecordFromDespatchesTableRecord(recordNumber));
        }

        [Given("I select action Return Despatched Assets")]
        public void GivenISelectActionReturnDespatchedAssets()
        {
            AllureLogger.LogStep("I Select Action",
            pom.SelectAction);
            AllureLogger.LogStep("I Select Return Despatched Assets",
             pom.ReturnDespatchedAssets);
        }

        [Given("I set \\(Radio) field Return Asset True")]
        public void GivenISetRadioFieldReturnAssetTrue()
        {
            AllureLogger.LogStep("I set (Radio) field Return Asset True",
             pom.SetRadioFieldReturnAssetTrue);
        }

        [Given("I select the OK dialog button")]
        public void GivenISelectTheOKDialogButton()
        {
            AllureLogger.LogStep("I select the OK dialog button",
            pom.SelectTheOKDialogButton);
        }

        [Given("I select Ok dialog system message")]
        public void GivenISelectOkDialogSystemMessage()
        {
            AllureLogger.LogStep("I select Ok dialog system message",
            pom.SelectOkDialogSystemMessage);
        }

        [Given("I verify status changed to RETURNED")]
        public void GivenIVerifyStatusChangedToRETURNED()
        {
            AllureLogger.LogStep("I verify RETURNED Status",
               pom.VerifyStatusChangedToRETURNED);
        }

        [Given("I take screenshot of Returning assets on a Despatch record test")]
        public void GivenITakeScreenshotOfReturningAssetsOnADespatchRecordTest()
        {
            AllureLogger.LogStep("I take screenshot of Returning assets on a Despatch record test",
               pom.TakeScreenshotOfReturningAssetsOnADespatchRecordTest);
        }





    }
}