using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using Reqnroll;
using System.Text;
using System.Timers;

namespace GTR_AUTOMATED.StepDefinitions
{
    [Binding]
    public sealed class YardMasterStepDefinitions
    {
        private readonly IWebDriver driver;
        private readonly YardMasterPOM pom;

        public YardMasterStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new YardMasterPOM(driver);
        }
              

        [Given("I open application Depot Management \\(BRDF)")]
        public void GivenIOpenApplicationDepotManagementBRDF()
        {
            AllureLogger.LogStep("Open Go To Menu)",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Fleet Availability Management(BRDF) Menu",
                pom.OpenFleetAvailabilityManagementBRDFMenu);
            AllureLogger.LogStep("Open Depot Management (BRDF) ",
                pom.OpenDepotManagementBRDF);
        }

        [Given("I filter table Yard Asset:")]
        public void GivenIFilterTableYardAsset(DataTable table)
        {
            string YardAsset = table.Rows[0]["Yard Asset"];
            AllureLogger.LogStep($"I filter table Yard Asset: {YardAsset}", () =>
                pom.FilterTableYardAsset(YardAsset));
        }

        [Given("I select no.{int} record Yard Asset table records")]
        public void GivenISelectNo_RecordYardAssetTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Yard Asset table records",
              () => pom.SelectNoRecordYardAssetTableRecords(recordNumber));
        }

        [Given("I take screenshot of Depot Yard View")]
        public void GivenITakeScreenshotOfDepotYardView()
        {
            AllureLogger.LogStep("I take screenshot of Depot Yard View",
                pom.TakeScreenshotOfDepotYardView);
        }

        [Given("I set Toggle Kiosk Mode")]
        public void GivenISetToggleKioskMode()
        {
            AllureLogger.LogStep("I set Toggle Kiosk Mode",
             pom.SetToggleKioskMode);
        }

        [Given("I take screenshot of Kiosk Mode")]
        public void GivenITakeScreenshotOfKioskMode()
        {
            AllureLogger.LogStep("I take screenshot of Kiosk Mode",
                pom.TakeScreenshotOfKioskMode);
        }

        [Given("I select Toggle Virtual Holding Road")]
        public void GivenISelectToggleVirtualHoldingRoad()
        {
            AllureLogger.LogStep("I select Toggle Virtual Holding Road",
             pom.SelectToggleVirtualHoldingRoad);
        }

        [Given("I take screenshot of Virtual Holding Road")]
        public void GivenITakeScreenshotOfVirtualHoldingRoad()
        {
            AllureLogger.LogStep("I take screenshot of Virtual Holding Road",
                pom.TakeScreenshotOfVirtualHoldingRoad);
        }

        [Given("I select Return to Depot Selector")]
        public void GivenISelectReturnToDepotSelector()
        {
            AllureLogger.LogStep("I select Return to Depot Selector",
             pom.SelectReturnToDepotSelector);
        }

        [Given("I take screenshot of Depots and Sidings Table")]
        public void GivenITakeScreenshotOfDepotsAndSidingsTable()
        {
            AllureLogger.LogStep("I take screenshot of Depots and Sidings Table",
                pom.TakeScreenshotOfDepotsAndSidingsTable);
        }

        [Given("I select no.{int} Gap on Road Block diagram")]
        public void GivenISelectNo_GapOnRoadBlockDiagram(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} Gap on Road Block diagram",
              () => pom.SelectNoGapOnRoadBlockDiagram(recordNumber));
        }

        [Given("I select no.{int} Road")]
        public void GivenISelectNo_Road(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} Road",
             () => pom.SelectNoRoad(recordNumber));
        }
        
        [Given("I add Gap to the Road")]
        public void GivenIAddGapToTheRoad()
        {
            AllureLogger.LogStep("I add Gap to the Road",
              pom.AddGapToTheRoad);
        }

        [Given("I enter Gap Details:")]
        public void GivenIEnterGapDetails(DataTable table)
        {
            string GapMemo = table.Rows[0]["Gap Memo"];
            string Poistion = table.Rows[0]["Poistion"];
            pom.EnterGapDetails(GapMemo, Poistion);
        }

        [Given("I select ok dialog button")]
        public void GivenISelectOkDialogButton()
        {
            AllureLogger.LogStep("I select ok dialog button",
             pom.SelectOkDialogButton);
        }

        [Given("I take screenshot of Gap added to the Road")]
        public void GivenITakeScreenshotOfGapAddedToTheRoad()
        {
            AllureLogger.LogStep("I take screenshot of Gap added to the Road",
                pom.TakeScreenshotOfGapAddedToTheRoad);
        }


        [Given("I View Gap details")]
        public void GivenIViewGapDetails()
        {
            AllureLogger.LogStep("I View Gap details",
             pom.ViewGapDetails);
        }

        [Given("I take screenshot of viewed Gap details one")]
        public void GivenITakeScreenshotOfViewedGapDetailsOne()
        {
            AllureLogger.LogStep("I take screenshot of viewed Gap details one",
                pom.TakeScreenshotOfViewedGapDetailsOne);
        }

        [Given("I click OK dialog button")]
        public void GivenIClickOKDialogButton()
        {
            AllureLogger.LogStep("I click OK dialog button",
             pom.ClickOKDialogButton);
        }

        [Given("I Delete Gap")]
        public void GivenIDeleteGap()
        {
            AllureLogger.LogStep("I delete Gap",
            pom.DeleteGap);
        }


        [Given("I take screenshot of Deleted Gap")]
        public void GivenITakeScreenshotOfDeletedGap()
        {
            AllureLogger.LogStep("I take screenshot of Deleted Gap",
               pom.TakeScreenshotOfDeletedGap);
        }



        // Depot View Tab - Adding and Removing a Block on a Road Step Definitions


        [Given("I add Block to the Road")]
        public void GivenIAddBlockToTheRoad()
        {
            AllureLogger.LogStep("I add Block to the Road",
                () => pom.AddBlockToTheRoad(1));
        }

        [Given("I enter Block Details:")]
        public void GivenIEnterBlockDetails(Table table)
        {
            string Memo = table.Rows[0]["Memo"];
            string Poistion = table.Rows[0]["Poistion"];
            pom.EnterBlockDetails(Memo, Poistion);
        }

        [Given("I select dialog ok button")]
        public void GivenISelectDialogOkButton()
        {
            AllureLogger.LogStep("I select dialog ok button",
             pom.SelectDialogOkButton);
        }


        [Given("I take screenshot of Block added to the Road")]
        public void GivenITakeScreenshotOfBlockAddedToTheRoad()
        {
            AllureLogger.LogStep("I take screenshot of Block added to the Road",
              pom.TakeScreenshotOfBlockAddedToTheRoad);
        }

        [Given("I View Block details")]
        public void GivenIViewBlockDetails()
        {
            AllureLogger.LogStep("I View Block details",
             pom.ViewBlockDetails);
        }


        [Given("I take screenshot of viewed Block details")]
        public void GivenITakeScreenshotOfViewedBlockDetails()
        {
            AllureLogger.LogStep("I take screenshot of viewed Block details",
               pom.TakeScreenshotOfViewedBlockDetails);
        }
          

        [Given("I Delete Block")]
        public void GivenIDeleteBlock()
        {
            AllureLogger.LogStep("I delete Block",
            pom.DeleteBlock);
        }

        [Given("I take screenshot of Deleted Block")]
        public void GivenITakeScreenshotOfDeletedBlock()
        {
            AllureLogger.LogStep("I take screenshot of Deleted Block",
              pom.TakeScreenshotOfDeletedBlock);
        }



        // Depot View Tab -  Block all the roads in a Depot (Emergency) Step Definitions



        [Given("I select Depot Menu Option")]
        public void GivenISelectDepotMenuOption()
        {
            AllureLogger.LogStep("I select Depot Menu Option",
             pom.SelectDepotMenuOption);
        }

        [Given("I select Depot Menu Option change Status")]
        public void GivenISelectDepotMenuOptionChangeStatus()
        {
            AllureLogger.LogStep("I select Depot Menu Option change Status",
             pom.SelectDepotMenuOptionChangeStatus);
        }


        [Given("I Select change Status")]
        public void GivenISelectChangeStatus()
        {
            AllureLogger.LogStep("I Select change Status",
             pom.SelectChangeStatus);
        }

        [Given("I enter Memo:")]
        public void GivenIEnterMemo(Table table)
        {
            string Memo = table.Rows[0]["Memo"];
            pom.EnterMemo(Memo);
        }

        [Given("I select Status as BLOCKED")]
        public void GivenISelectStatusAsBLOCKED()
        {
            AllureLogger.LogStep("I select Status as BLOCKED",
             pom.SelectStatusAsBLOCKED);
        }

        [Given("I press OK dialog button")]
        public void GivenIPressOKDialogButton()
        {
            AllureLogger.LogStep("I press OK dialog button",
             pom.PressOKDialogButton);
        }

        [Given("I take screenshot of Blocked Roads")]
        public void GivenITakeScreenshotOfBlockedRoads()
        {
            AllureLogger.LogStep("I take screenshot of Blocked Roads",
              pom.TakeScreenshotOfBlockedRoads);
        }

        [Given("I change Status")]
        public void GivenIChangeStatus()
        {
            AllureLogger.LogStep("I change Status",
             pom.ChangeStatus);
        }


        [Given("I select Status as ACTIVE")]
        public void GivenISelectStatusAsACTIVE()
        {
            AllureLogger.LogStep("I select Status as ACTIVE",
             pom.SelectStatusAsACTIVE);
        }

        [Given("I enter Memo details:")]
        public void GivenIEnterMemoDetails(Table table)
        {
            string Memo = table.Rows[0]["Memo"];
            pom.EnterMemoDetails(Memo);
        }


        [Given("I take screenshot of UnBlocked Roads")]
        public void GivenITakeScreenshotOfUnBlockedRoads()
        {
            AllureLogger.LogStep("I take screenshot of UnBlocked Roads",
             pom.TakeScreenshotOfUnBlockedRoads);
        }



        // Depot View Tab - Block an Entire Road in Depot Step Definitions




        [Given("I Add Road Attribute")]
        public void GivenIAddRoadAttribute()
        {
            AllureLogger.LogStep("I Add Road Attribute",
             pom.AddRoadAttribute);
        }

        [Given("I select New Row button under Fleet Availability Attributes")]
        public void GivenISelectNewRowButtonUnderFleetAvailabilityAttributes()
        {
            AllureLogger.LogStep("I select New Row button under Fleet Availability Attributes",
             pom.SelectNewRowButtonUnderFleetAvailabilityAttributes);
        }

        [Given("I select Value lookup of Attribute field")]
        public void GivenISelectValueLookupOfAttributeField()
        {
            AllureLogger.LogStep("I select Value lookup of Attribute field",
             pom.SelectValueLookupOfAttributeField);
        }

        [Given("I filter Attributes:")]
        public void GivenIFilterAttributes(Table table)
        {
            string Attributes = table.Rows[0]["Attributes"];
            AllureLogger.LogStep($"I filter table Attributes: {Attributes}", () =>
                pom.FilterAttributes(Attributes));
        }

        [Given("I select no.{int} record Attribute table records")]
        public void GivenISelectNo_RecordAttributeTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Attribute table records",
              () => pom.SelectNoRecordAttributeTableRecords(recordNumber));
        }

        [Given("I click OK dialog button of Attribute dropdown list")]
        public void GivenIClickOKDialogButtonOfAttributeDropdownList()
        {
            AllureLogger.LogStep("I click OK dialog button of Attribute dropdown list",
            pom.ClickOKDialogButtonOfAttributeDropdownList);
        }
              

        [Given("I take screenshot of Blocked Road added to the Road")]
        public void GivenITakeScreenshotOfBlockedRoadAddedToTheRoad()
        {
            AllureLogger.LogStep("I take screenshot of Blocked Road added to the Road",
            pom.TakeScreenshotOfBlockedRoadAddedToTheRoad);
        }

        [Given("I select Blocked road")]
        public void GivenISelectBlockedRoad()
        {
            AllureLogger.LogStep("I select Blocked road",
              pom.SelectBlockedRoad);
        }


        [Given("I Delete Road Attribute")]
        public void GivenIDeleteRoadAttribute()
        {
            AllureLogger.LogStep("I Delete Road Attribute",
              pom.DeleteRoadAttribute);
        }

        [Given("I take screenshot of Deleted Blocked Road")]
        public void GivenITakeScreenshotOfDeletedBlockedRoad()
        {
            AllureLogger.LogStep("I take screenshot of Deleted Blocked Road",
            pom.TakeScreenshotOfDeletedBlockedRoad);
        }



        // Depot View Tab - Add Attributes to the Road Step Definitions



        [Given("I take screenshot of Low Speed Attribute")]
        public void GivenITakeScreenshotOfLowSpeedAttribute()
        {
            AllureLogger.LogStep("I take screenshot of Low Speed Attribute",
            pom.TakeScreenshotOfLowSpeedAttribute);
        }

        [Given("I take screenshot of Deleted Low Speed Attribute")]
        public void GivenITakeScreenshotOfDeletedLowSpeedAttribute()
        {
            AllureLogger.LogStep("I take screenshot of Deleted Low Speed Attribute",
            pom.TakeScreenshotOfDeletedLowSpeedAttribute);
        }



        // Depot View Tab - Add Attributes to the Road Step Definitions


        [Given("I Add Road Comment")]
        public void GivenIAddRoadComment()
        {
            AllureLogger.LogStep("I Add Road Comment",
             pom.AddRoadComment);
        }

        
        [Given("I enter Comment:")]
        public void GivenIEnterComment(Table table)
        {
            string Comment = table.Rows[0]["Comment"];
            AllureLogger.LogStep($"I enter Comment: {Comment}", () =>
                pom.EnterComment(Comment));
        }


        [Given("I click OK dialog button of Add Comment dialog")]
        public void GivenIClickOKDialogButtonOfAddCommentDialog()
        {
            AllureLogger.LogStep("I click OK dialog button of Add Comment dialog",
             pom.ClickOKDialogButtonOfAddCommentDialog);
        }

        [Given("I take screenshot of Added Comment")]
        public void GivenITakeScreenshotOfAddedComment()
        {
            AllureLogger.LogStep("I take screenshot of Added Comment",
            pom.TakeScreenshotOfAddedComment);
        }

        [Given("I Modify Road Comment")]
        public void GivenIModifyRoadComment()
        {
            AllureLogger.LogStep("I Modify Road Comment",
             pom.ModifyRoadComment);
        }


        [Given("I Modify Comment:")]
        public void GivenIModifyComment(Table table)
        {
            string Comment = table.Rows[0]["Comment"];
            AllureLogger.LogStep($"I enter Comment: {Comment}", () =>
                pom.ModifyComment(Comment));
        }

        [Given("I remove Road Comment")]
        public void GivenIRemoveRoadComment()
        {
            AllureLogger.LogStep("I remove Road Comment",
             pom.RemoveRoadComment);
        }
              
        [Given("I click OK dialog button of Modify Comment dialog")]
        public void GivenIClickOKDialogButtonOfModifyCommentDialog()
        {
            AllureLogger.LogStep("I click OK dialog button of Modify Comment dialog",
             pom.ClickOKDialogButtonOfModifyCommentDialog);
        }

        
        [Given("I take screenshot of Deleted Comment")]
        public void GivenITakeScreenshotOfDeletedComment()
        {
            AllureLogger.LogStep("I take screenshot of Deleted Comment",
            pom.TakeScreenshotOfDeletedComment);
        }





        // Depot View Tab - Stopping Units in the Depot Step Definitions



        [Given("I select Unit on Roads")]
        public void GivenISelectUnitOnRoads()
        {
            AllureLogger.LogStep("I select Unit on Roads",
             pom.SelectUnitOnRoads);
        }

        [Given("I change unit status")]
        public void GivenIChangeUnitStatus()
        {
            AllureLogger.LogStep("I change Unit Status",
             pom.ChangeUnitStatus);
        }

        [Given("I select STOPPED")]
        public void GivenISelectSTOPPED()
        {
            AllureLogger.LogStep("I select Status as STOPPED",
             pom.SelectSTOPPED);
        }

        [Given("I enter unit Memo:")]
        public void GivenIEnterUnitMemo(Table table)
        {
            string Memo = table.Rows[0]["Memo"];
            pom.EnterUnitMemo(Memo);
        }

        [Given("I select value lookup of stop code field")]
        public void GivenISelectValueLookupOfStopCodeField()
        {
            AllureLogger.LogStep("I select value lookup of stop code field",
             pom.SelectValueLookupOfStopCodeField);
        }

        [Given("I filter Stop Code:")]
        public void GivenIFilterStopCode(Table table)
        {
            string StopCode = table.Rows[0]["Stop Code"];
            AllureLogger.LogStep($"I filter table Stop Code: {StopCode}", () =>
                pom.FilterStopCode(StopCode));
        }

        [Given("I select no.{int} record from Stop Code table")]
        public void GivenISelectNo_RecordFromStopCodeTable(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Stop Code table records",
              () => pom.SelectNoRecordFromStopCodeTable(recordNumber));
        }

               
        [Given("I set Stop Date")]
        public void GivenISetStopDate()
        {
            AllureLogger.LogStep("I set Stop Date",
            pom.SetStopDate);
        }
                             

        [Given("I set Stop Estimated Release Date")]
        public void GivenISetStopEstimatedReleaseDate()
        {
            AllureLogger.LogStep("I set Stop Estimated Release Date",
          pom.SetStopEstimatedReleaseDate);
        }


        [Given("I click dialog OK button of change unit status")]
        public void GivenIClickDialogOKButtonOfChangeUnitStatus()
        {
            AllureLogger.LogStep("I click dialog OK button of change unit status",
             pom.ClickDialogOKButtonOfChangeUnitStatus);
        }


        [Given("I take screenshot of Stopped Unit in Depot")]
        public void GivenITakeScreenshotOfStoppedUnitInDepot()
        {
            AllureLogger.LogStep("I take screenshot of Stopped Unit in Depot",
              pom.TakeScreenshotOfStoppedUnitInDepot);
        }


        [Given("I select Available for Service")]
        public void GivenISelectAvailableForService()
        {
            AllureLogger.LogStep("I select Available for Service",
             pom.SelectAvailableForService);
        }

        [Given("I take screenshot of Depot to Active")]
        public void GivenITakeScreenshotOfDepotToActive()
        {
            AllureLogger.LogStep("I take screenshot of Depot to Active",
              pom.TakeScreenshotOfDepotToActive);
        }




        // Depot View Tab - View Units in the Yard Step Definitions


        [Given("I select View Details")]
        public void GivenISelectViewDetails()
        {
            AllureLogger.LogStep("I select View Details",
             pom.SelectViewDetails);
        }

        [Given("I go to Vehicle tab")]
        public void GivenIGoToVehicleTab()
        {
            AllureLogger.LogStep("I go to Vehicle tab",
             pom.GoToVehicleTab);
        }

        [Given("I take screenshot of Vehicle Tab")]
        public void GivenITakeScreenshotOfVehicleTab()
        {
            AllureLogger.LogStep("I take screenshot of Vehicle Tab",
              pom.TakeScreenshotOfVehicleTab);
        }

        [Given("I go to Service Line Tab")]
        public void GivenIGoToServiceLineTab()
        {
            AllureLogger.LogStep("I go to Service Line Tab",
             pom.GoToServiceLineTab);
        }

        [Given("I take screenshot of Service Line Tab")]
        public void GivenITakeScreenshotOfServiceLineTab()
        {
            AllureLogger.LogStep("I take screenshot of Service Line Tab",
              pom.TakeScreenshotOfServiceLineTab);
        }

        [Given("I go to Sanding Tab")]
        public void GivenIGoToSandingTab()
        {
            AllureLogger.LogStep("I go to Sanding tab",
             pom.GoToSandingTab);
        }

        [Given("I take screenshot of Sanding Tab")]
        public void GivenITakeScreenshotOfSandingTab()
        {
            AllureLogger.LogStep("I take screenshot of Sanding Tab",
              pom.TakeScreenshotOfSandingTab);
        }

        [Given("I go to Toilet Availability Tab")]
        public void GivenIGoToToiletAvailabilityTab()
        {
            AllureLogger.LogStep("I go to Availability tab",
             pom.GoToToiletAvailabilityTab);
        }

        [Given("I take screenshot of Toilet Availability Tab")]
        public void GivenITakeScreenshotOfToiletAvailabilityTab()
        {
            AllureLogger.LogStep("I take screenshot of Toilet Availability Tab",
              pom.TakeScreenshotOfToiletAvailabilityTab);
        }

        [Given("I go to Status History Tab")]
        public void GivenIGoToStatusHistoryTab()
        {
            AllureLogger.LogStep("I go to Status History tab",
             pom.GoToStatusHistoryTab);
        }

        [Given("I take screenshot of Status History Tab")]
        public void GivenITakeScreenshotOfStatusHistoryTab()
        {
            AllureLogger.LogStep("I take screenshot of Status History Tab",
              pom.TakeScreenshotOfStatusHistoryTab);
        }

        [Given("I go to Mileage History Tab")]
        public void GivenIGoToMileageHistoryTab()
        {
            AllureLogger.LogStep("I go to Mileage History tab",
             pom.GoToMileageHistoryTab);
        }

        [Given("I take screenshot of Mileage History Tab")]
        public void GivenITakeScreenshotOfMileageHistoryTab()
        {
            AllureLogger.LogStep("I take screenshot of Mileage History Tab",
              pom.TakeScreenshotOfMileageHistoryTab);
        }

        [Given("I go to Work Orders Tab")]
        public void GivenIGoToWorkOrdersTab()
        {
            AllureLogger.LogStep("I go to Work Orders tab",
             pom.GoToWorkOrdersTab);
        }

        [Given("I take screenshot of Work Orders Tab")]
        public void GivenITakeScreenshotOfWorkOrdersTab()
        {
            AllureLogger.LogStep("I take screenshot of Work Orders Tab",
              pom.TakeScreenshotOfWorkOrdersTab);
        }

        [Given("I press dialog Ok button")]
        public void GivenIPressDialogOkButton()
        {
            AllureLogger.LogStep("I press dialog Ok button",
             pom.PressDialogOkButton);
        }

        [Given("I filter Unit:")]
        public void GivenIFilterUnit(Table table)
        {
            string Unit = table.Rows[0]["Unit"];
            AllureLogger.LogStep($"I filter table Unit: {Unit}", () =>
                pom.FilterUnit(Unit));
        }

        [Given("I take screenshot of filtered Unit")]
        public void GivenITakeScreenshotOfFilteredUnit()
        {
            AllureLogger.LogStep("I take screenshot of filtered Unit",
              pom.TakeScreenshotOfFilteredUnit);
        }




        // Depot View Tab - Create a Move Request Step Definitions


        [Given("I Select Create Move Request")]
        public void GivenISelectCreateMoveRequest()
        {
            AllureLogger.LogStep("I select Create Move Request",
             pom.SelectCreateMoveRequest);
        }

        [Given("I select value lookup of Road field")]
        public void GivenISelectValueLookupOfRoadField()
        {
            AllureLogger.LogStep("I select value lookup of Road field",
             pom.SelectValueLookupOfRoadField);
        }

        [Given("I filter Road:")]
        public void GivenIFilterRoad(Table table)
        {
            string Road = table.Rows[0]["Road"];
            AllureLogger.LogStep($"I filter table Road: {Road}", () =>
                pom.FilterRoad(Road));
        }

        [Given("I select no.{int} record from Road table")]
        public void GivenISelectNo_RecordFromRoadTable(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Road table records",
              () => pom.SelectNoRecordFromRoadTable(recordNumber));
        }

        [Given("I set Move By Date")]
        public void GivenISetMoveByDate()
        {
            AllureLogger.LogStep("I set Move By Date",
            pom.SetMoveByDate);
        }

        [Given("I click ok dailog button of Create Move Request")]
        public void GivenIClickOkDailogButtonOfCreateMoveRequest()
        {
            AllureLogger.LogStep("I click ok dailog button of Create Move Request",
            pom.ClickOkDailogButtonOfCreateMoveRequest);
        }

        [Given("I take screenshot of Create Move Request")]
        public void GivenITakeScreenshotOfCreateMoveRequest()
        {
            AllureLogger.LogStep("I take screenshot of Create Move Request",
              pom.TakeScreenshotOfCreateMoveRequest);
        }

        [Given("I go to At Location Tab")]
        public void GivenIGoToAtLocationTab()
        {
            AllureLogger.LogStep("I go to At Location Tab",
             pom.GoToAtLocationTab);
        }

        [Given("I select Create Move Request from the action menu options")]
        public void GivenISelectCreateMoveRequestFromTheActionMenuOptions()
        {
            AllureLogger.LogStep("I select Create Move Request from the action menu options",
              pom.SelectCreateMoveRequestFromTheActionMenuOptions);
        }


        [Given("I click select action menu Create Move Request")]
        public void GivenIClickSelectActionMenuCreateMoveRequest()
        {
            AllureLogger.LogStep("I click select action menu Create Move Request",
              pom.ClickSelectActionMenuCreateMoveRequest);
        }


        [Given("I select action Create Move Request")]
        public void GivenISelectActionCreateMoveRequest()
        {
            AllureLogger.LogStep("I select action Create Move Request",
             pom.SelectActionCreateMoveRequest);
        }


        [Given("I click action Create Move Request")]
        public void GivenIClickActionCreateMoveRequest()
        {
            AllureLogger.LogStep("I click action Create Move Request",
             pom.ClickActionCreateMoveRequest);
        }



        [Given("I select action Manage Move Request")]
        public void GivenISelectActionManageMoveRequest()
        {
            AllureLogger.LogStep("I select action Manage Move Request",
             pom.SelectActionManageMoveRequest);
        }

        [Given("I modify Move By Date")]
        public void GivenIModifyMoveByDate()
        {
            AllureLogger.LogStep("I modify Move By Date",
            pom.ModifyMoveByDate);
        }

        [Given("I click ok dailog button of Move Request Details")]
        public void GivenIClickOkDailogButtonOfMoveRequestDetails()
        {
            AllureLogger.LogStep("I click ok dailog button of Move Request Details",
            pom.ClickOkDailogButtonOfMoveRequestDetails);
        }

        [Given("I take screenshot of Move Request Details")]
        public void GivenITakeScreenshotOfMoveRequestDetails()
        {
            AllureLogger.LogStep("I take screenshot of Move Request Details",
              pom.TakeScreenshotOfMoveRequestDetails);
        }

        [Given("I go to Prepping Tab")]
        public void GivenIGoToPreppingTab()
        {
            AllureLogger.LogStep("I go to Prepping Tab",
             pom.GoToPreppingTab);
        }

        [Given("I select action Prep Consist")]
        public void GivenISelectActionPrepConsist()
        {
            AllureLogger.LogStep("I select action Prep Consist",
             pom.SelectActionPrepConsist);
        }

        [Given("I set Choose a Date")]
        public void GivenISetChooseADate()
        {
            AllureLogger.LogStep("I set Choose a Date",
             pom.SetChooseADate);
        }

        [Given("I select value lookup of Prepped By field")]
        public void GivenISelectValueLookupOfPreppedByField()
        {
            AllureLogger.LogStep("I select value lookup of Prepped By field",
            pom.SelectValueLookupOfPreppedByField);
        }

        [Given("I filter Person:")]
        public void GivenIFilterPerson(Table table)
        {
            string Person = table.Rows[0]["Person"];
            AllureLogger.LogStep($"I filter table Person: {Person}", () =>
                pom.FilterPerson(Person));
        }

        [Given("I select no.{int} record from Person table")]
        public void GivenISelectNo_RecordFromPersonTable(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Person table records",
              () => pom.SelectNoRecordFromPersonTable(recordNumber));
        }

        [Given("I enter Additional info:")]
        public void GivenIEnterAdditionalInfo(Table table)
        {
            string AdditionalInfo = table.Rows[0]["Additional Info"];
            AllureLogger.LogStep($"I enter Additional info: {AdditionalInfo}", () =>
                pom.EnterAdditionalInfo(AdditionalInfo));
        }

        [Given("I click Confirm dailog button")]
        public void GivenIClickConfirmDailogButton()
        {
            AllureLogger.LogStep("I click Confirm dailog button",
             pom.ClickConfirmDailogButton);
        }

        [Given("I take screenshot of Prep Consist")]
        public void GivenITakeScreenshotOfPrepConsist()
        {
            AllureLogger.LogStep("I take screenshot of Prep Consist",
              pom.TakeScreenshotOfPrepConsist);
        }

        [Given("I take screenshot of Move Request in At Location Tab")]
        public void GivenITakeScreenshotOfMoveRequestInAtLocationTab()
        {
            AllureLogger.LogStep("I take screenshot of Move Request in At Location Tab",
              pom.TakeScreenshotOfMoveRequestInAtLocationTab);
        }

        [Given("I go to Move Request Tab")]
        public void GivenIGoToMoveRequestTab()
        {

            AllureLogger.LogStep("I go to Move Request Tab",
             pom.GoToMoveRequestTab);
        }


        [Given("I select action Cancel Move Request")]
        public void GivenISelectActionCancelMoveRequest()
        {
            AllureLogger.LogStep("I select action Cancel Move Request",
            pom.SelectActionCancelMoveRequest);
        }
                
        [Given("I select Cancelled")]
        public void GivenISelectCancelled()
        {
            AllureLogger.LogStep("I select Cancelled",
             pom.SelectCancelled);
        }

        [Given("I enter Memo Notes:")]
        public void GivenIEnterMemoNotes(Table table)
        {
            string MemoNotes = table.Rows[0]["Memo Notes"];
            AllureLogger.LogStep($"I enter Memo Notes: {MemoNotes}", () =>
                pom.EnterMemoNotes(MemoNotes));
        }


        [Given("I click ok dailog button of Change Move Request Status")]
        public void GivenIClickOkDailogButtonOfChangeMoveRequestStatus()
        {
            AllureLogger.LogStep("I click ok dailog button of Create Move Request",
            pom.ClickOkDailogButtonOfChangeMoveRequestStatus);
        }

        [Given("I take screenshot of Cancelled Move Request")]
        public void GivenITakeScreenshotOfCancelledMoveRequest()
        {
            AllureLogger.LogStep("I take screenshot of Cancelled Move Request",
              pom.TakeScreenshotOfCancelledMoveRequest);
        }




        // Depot View Tab - Actioning a Move Request Step Definitions


        [Given("I take screenshot of Create Move Request Test")]
        public void GivenITakeScreenshotOfCreateMoveRequestTest()
        {
            AllureLogger.LogStep("I take screenshot of Create Move Request Test",
              pom.TakeScreenshotOfCreateMoveRequestTest);
        }

        [Given("I click ok dailog button of Move Request")]
        public void GivenIClickOkDailogButtonOfMoveRequest()
        {
            AllureLogger.LogStep("I click ok dailog button of Move Request",
            pom.ClickOkDailogButtonOfMoveRequest);
        }



        [Given("I go to Tab Move Request")]
        public void GivenIGoToTabMoveRequest()
        {
            AllureLogger.LogStep("I go to Tab Move Request",
            pom.GoToTabMoveRequest);
        }


        [Given("I go to Depot View Tab")]
        public void GivenIGoToDepotViewTab()
        {
            AllureLogger.LogStep("I go to Depot View Tab",
             pom.GoToDepotViewTab);
        }

        [Given("I Move Unit to Next Road")]
        public void GivenIMoveUnitToNextRoad()
        {
            AllureLogger.LogStep("I Move Unit to Next Road",
              pom.MoveUnitToNextRoad);
        }

        
        [Given("I click Yes dailog button of system message")]
        public void GivenIClickYesDailogButtonOfSystemMessage()
        {
            AllureLogger.LogStep("I click Yes dailog button of system message",
            pom.ClickYesDailogButtonOfSystemMessage);
        }

        [Given("I set Actual Move By Date")]
        public void GivenISetActualMoveByDate()
        {
            AllureLogger.LogStep("I set Actual Move By Date",
            pom.SetActualMoveByDate);
        }

        [Given("I select value lookup of Actual Moved By field")]
        public void GivenISelectValueLookupOfActualMovedByField()
        {
            AllureLogger.LogStep("I select value lookup of Actual Moved By field",
            pom.SelectValueLookupOfActualMovedByField);
        }

        [Given("I filter Actual Person:")]
        public void GivenIFilterActualPerson(Table table)
        {
            string ActualPerson = table.Rows[0]["Actual Person"];
            AllureLogger.LogStep($"I filter table Actual Person: {ActualPerson}", () =>
                pom.FilterActualPerson(ActualPerson));
        }

        [Given("I select no.{int} record from Actual Person table")]
        public void GivenISelectNo_RecordFromActualPersonTable(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Person table records",
              () => pom.SelectNoRecordFromActualPersonTable(recordNumber));
        }


        [Given("I click ok dailog button of Confirm Request")]
        public void GivenIClickOkDailogButtonOfConfirmRequest()
        {
            AllureLogger.LogStep("I click ok dailog button of Confirm Request",
            pom.ClickOkDailogButtonOfConfirmRequest);
        }

        [Given("I take screenshot of Moved Unit in Depot View Tab")]
        public void GivenITakeScreenshotOfMovedUnitInDepotViewTab()
        {
            AllureLogger.LogStep("I take screenshot of Moved Unit in Depot View Tab",
              pom.TakeScreenshotOfMovedUnitInDepotViewTab);
        }





        // Prepping Tab Viewing Prepping / Prepping a Train Step Definitions



        [Given("I take screenshot of Created Move Request")]
        public void GivenITakeScreenshotOfCreatedMoveRequest()
        {
            AllureLogger.LogStep("I take screenshot of Created Move Request",
              pom.TakeScreenshotOfCreatedMoveRequest);
        }

        [Given("I take screenshot of Move Request in Prepping Tab")]
        public void GivenITakeScreenshotOfMoveRequestInPreppingTab()
        {
            AllureLogger.LogStep("I take screenshot of Move Request in Prepping Tab",
             pom.TakeScreenshotOfMoveRequestInPreppingTab);
        }

        [Given("I select prepped sub tab")]
        public void GivenISelectPreppedSubTab()
        {
            AllureLogger.LogStep("I select prepped sub tab",
             pom.SelectPreppedSubTab);
        }

        [Given("I select No Prep Required sub Tab")]
        public void GivenISelectNoPrepRequiredSubTab()
        {
            AllureLogger.LogStep("I select No Prep Required sub Tab",
            pom.SelectNoPrepRequiredSubTab);
        }

        [Given("I select unprepped sub Tab")]
        public void GivenISelectUnpreppedSubTab()
        {
            AllureLogger.LogStep("I select unprepped sub Tab",
            pom.SelectUnpreppedSubTab);
        }

        [Given("I take screenshot of Completed Prep Consist")]
        public void GivenITakeScreenshotOfCompletedPrepConsist()
        {
            AllureLogger.LogStep("I take screenshot of Completed Prep Consist",
             pom.TakeScreenshotOfCompletedPrepConsist);
        }

        [Given("I select action Unprep Consist")]
        public void GivenISelectActionUnprepConsist()
        {
            AllureLogger.LogStep("I select action Unprep Consist",
             pom.SelectActionUnprepConsist);
        }

        [Given("I select dialog Yes buttom of system message")]
        public void GivenISelectDialogYesButtomOfSystemMessage()
        {
            AllureLogger.LogStep("I select dialog Yes buttom of system message",
            pom.SelectDialogYesButtomOfSystemMessage);
        }

        [Given("I take screenshot of Unprep Consist")]
        public void GivenITakeScreenshotOfUnprepConsist()
        {
            AllureLogger.LogStep("I take screenshot of Unprep Consist",
             pom.TakeScreenshotOfUnprepConsist);
        }

        [Given("I select action No Prep Required")]
        public void GivenISelectActionNoPrepRequired()
        {
            AllureLogger.LogStep("I select action No Prep Required",
             pom.SelectActionNoPrepRequired);
        }

        [Given("I select Yes dialog button of system message")]
        public void GivenISelectYesDialogButtonOfSystemMessage()
        {
            AllureLogger.LogStep("I select Yes dialog button of system message",
             pom.SelectYesDialogButtonOfSystemMessage);
        }


        [Given("I go to No Prep Required sub tab")]
        public void GivenIGoToNoPrepRequiredSubTab()
        {
            AllureLogger.LogStep("I go to No Prep Required sub tab",
             pom.GoToNoPrepRequiredSubTab);
        }

        [Given("I take screenshot of No Prep Required")]
        public void GivenITakeScreenshotOfNoPrepRequired()
        {
            AllureLogger.LogStep("I take screenshot of No Prep Required",
             pom.TakeScreenshotOfNoPrepRequired);
        }






        // In Service / Arriving Tab - View Planned Arrivals Step Definitions



        [Given("I go to In Service \\/ Arriving Tab")]
        public void GivenIGoToInServiceArrivingTab()
        {
            AllureLogger.LogStep("I go to In Service \\/ Arriving Tab",
             pom.GoToInServiceArrivingTab);
        }

        [Given("I take screenshot of Planned Arrivals in In Service \\/ Arriving Tab")]
        public void GivenITakeScreenshotOfPlannedArrivalsInInServiceArrivingTab()
        {
            AllureLogger.LogStep("I take screenshot of Planned Arrivals in In Service \\/ Arriving Tab",
              pom.TakeScreenshotOfPlannedArrivalsInInServiceArrivingTab);
        }

        [Given("I select In Service Arrivals sub Tab")]
        public void GivenISelectInServiceArrivalsSubTab()
        {
            AllureLogger.LogStep("I select In Service Arrivals sub tab",
             pom.SelectInServiceArrivalsSubTab);
        }


        [Given("I take screenshot of In Service sub Tab")]
        public void GivenITakeScreenshotOfInServiceSubTab()
        {
            AllureLogger.LogStep("I take screenshot of In Service sub Tab",
              pom.TakeScreenshotOfInServiceSubTab);
        }

        [Given("I select Recently Arrive sub Tab")]
        public void GivenISelectRecentlyArriveSubTab()
        {
            AllureLogger.LogStep("I select Recently Arrive sub tab",
             pom.SelectRecentlyArriveSubTab);
        }

        [Given("I take screenshot of Recently Arrive sub Tab")]
        public void GivenITakeScreenshotOfRecentlyArriveSubTab()
        {
            AllureLogger.LogStep("I take screenshot of Recently Arrive sub Tab",
              pom.TakeScreenshotOfRecentlyArriveSubTab);
        }

        [Given("I select No Show sub Tab")]
        public void GivenISelectNoShowSubTab()
        {
            AllureLogger.LogStep("I select No Show sub tab",
              pom.SelectNoShowSubTab);
        }

        [Given("I take screenshot of No Show sub Tab")]
        public void GivenITakeScreenshotOfNoShowSubTab()
        {
            AllureLogger.LogStep("I take screenshot of No Show sub Tab",
              pom.TakeScreenshotOfNoShowSubTab);
        }




        // In Service / Arriving Tab - Action an Unplanned Arrival Step Definitions



        [Given("I click on the Unplanned Arrival button")]
        public void GivenIclickOnTheUnplannedArrivalButton()
        {
            AllureLogger.LogStep("I click on the Unplanned Arrival button",
              pom.clickOnTheUnplannedArrivalButton);
        }

        [Given("I take screenshot of Unplanned Arrival dialog")]
        public void GivenITakeScreenshotOfUnplannedArrivalDialog()
        {
            AllureLogger.LogStep("I take screenshot of Unplanned Arrival dialog",
              pom.TakeScreenshotOfUnplannedArrivalDialog);
        }

        [Given("I select no.{int} record from Unplanned Arrival table")]
        public void GivenISelectNo_RecordFromUnplannedArrivalTable(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Unplanned Arrival table records",
              () => pom.SelectNoRecordFromUnplannedArrivalTable(recordNumber));
        }


        [Given("I select OK button")]
        public void GivenISelectOKButton()
        {
            AllureLogger.LogStep("I select OK button",
            pom.SelectOKButton);
        }

        [Given("I take screenshot of Unplanned Arrival Service Added to Planned Arrivals")]
        public void GivenITakeScreenshotOfUnplannedArrivalServiceAddedToPlannedArrivals()
        {
            AllureLogger.LogStep("I take screenshot of Unplanned Arrival Service Added to Planned Arrivals",
              pom.TakeScreenshotOfUnplannedArrivalServiceAddedToPlannedArrivals);
        }

        [Given("I select action Arrive to Road")]
        public void GivenISelectActionArriveToRoad()
        {
            AllureLogger.LogStep("I select action Arrive to Road",
             pom.SelectActionArriveToRoad);
        }

        [Given("I select value lookup of Arrival Road field")]
        public void GivenISelectValueLookupOfArrivalRoadField()
        {
            AllureLogger.LogStep("I select value lookup of Arrival Road field",
            pom.SelectValueLookupOfArrivalRoadField);
        }

        [Given("I filter Arrival Road:")]
        public void GivenIFilterArrivalRoad(Table table)
        {
            string ArrivalRoad = table.Rows[0]["Arrival Road"];
            AllureLogger.LogStep($"I filter table Arrival Road: {ArrivalRoad}", () =>
                pom.FilterArrivalRoad(ArrivalRoad));
        }

        [Given("I select no.{int} record from Arrival Road table")]
        public void GivenISelectNo_RecordFromArrivalRoadTable(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Arrival Road table records",
               () => pom.SelectNoRecordFromArrivalRoadTable(recordNumber));
        }


        [Given("I set Arrived")]
        public void GivenISetArrived()
        {
            AllureLogger.LogStep("I set Arrived",
            pom.SetArrived);
        }

        [Given("I set Accepted")]
        public void GivenISetAccepted()
        {
            AllureLogger.LogStep("I set Accepted",
            pom.SetAccepted);
        }

        [Given("I set Yard")]
        public void GivenISetYard()
        {
            AllureLogger.LogStep("I set Yard",
            pom.SetYard);
        }

        [Given("I select dialog Arrive Service button")]
        public void GivenISelectDialogArriveServiceButton()
        {
            AllureLogger.LogStep("I select dialog Arrive Service button",
            pom.SelectDialogArriveServiceButton);
        }

        [Given("I take screenshot of Arrive Service")]
        public void GivenITakeScreenshotOfArriveService()
        {
            AllureLogger.LogStep("I take screenshot of Arrive Service",
              pom.TakeScreenshotOfArriveService);
        }





        // In Service / Arriving Tab - Manually Allocating Units (If TRENT Integration is not available) Step Definitions




        [Given("I select Generate button")]
        public void GivenISelectGenerateButton()
        {
            AllureLogger.LogStep("I select Generate button",
           pom.SelectGenerateButton);
        }

        [Given("I select value lookup of Timetable Name field")]
        public void GivenISelectValueLookupOfTimetableNameField()
        {
            AllureLogger.LogStep("I select value lookup of Timetable Name field",
            pom.SelectValueLookupOfTimetableNameField);
        }

        [Given("I select no.{int} record from Timetable Name table records")]
        public void GivenISelectNo_RecordFromTimetableNameTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Timetable Name table records",
            () => pom.SelectNoRecordFromTimetableNameTableRecords(recordNumber));
        }

        [Given("I press dialog OK button of Generate Daily Service")]
        public void GivenIPressDialogOKButtonOfGenerateDailyService()
        {
            AllureLogger.LogStep("I press dialog OK button of Generate Daily Service",
             pom.PressDialogOKButtonOfGenerateDailyService);
        }

        [Given("I take screenshot of Service Management - Daily Service Generated")]
        public void GivenITakeScreenshotOfServiceManagement_DailyServiceGenerated()
        {
            AllureLogger.LogStep("I take screenshot of Service Management - Daily Service Generated",
              pom.TakeScreenshotOfServiceManagementDailyServiceGenerated);
        }

        [Given("I select Service lines from table records")]
        public void GivenISelectServiceLinesFromTableRecords()
        {
            AllureLogger.LogStep("I select Service lines from table records",
             pom.SelectServiceLinesFromTableRecords);
        }

        [Given("I select Add Line button")]
        public void GivenISelectAddLineButton()
        {
            AllureLogger.LogStep("I select Add Line button",
             pom.SelectAddLineButton);
        }

        [Given("I select value lookup of Destination field")]
        public void GivenISelectValueLookupOfDestinationField()
        {
            AllureLogger.LogStep("I select value lookup of Destination field",
              pom.SelectValueLookupOfDestinationField);
        }

        [Given("I filter Destination:")]
        public void GivenIFilterDestination(Table table)
        {
            string Destination = table.Rows[0]["Destination"];
            AllureLogger.LogStep($"I filter table Destination: {Destination}", () =>
                pom.FilterDestination(Destination));
        }

        [Given("I select no.{int} record from Destination table records")]
        public void GivenISelectNo_RecordFromDestinationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Destination table records",
            () => pom.SelectNoRecordFromDestinationTableRecords(recordNumber));
        }

        [Given("I enter Run Number:")]
        public void GivenIEnterRunNumber(Table table)
        {
            string RunNumber = table.Rows[0]["Run Number"];
            AllureLogger.LogStep($"I enter Run Number: {RunNumber}", () =>
                pom.EnterRunNumber(RunNumber));
        }

        [Given("I enter Add a Service Line Memo:")]
        public void GivenIEnterAddAServiceLineMemo(Table table)
        {
            string Memo = table.Rows[0]["Memo"];
            pom.EnterAddAServiceLineMemo(Memo);
        }


        [Given("I set Departure Time:")]
        public void GivenISetDepartureTime(Table table)
        {
            string DepartureTime = table.Rows[0]["Departure Time"];
            pom.SetDepartureTime(DepartureTime);
        }

        [Given("I set Arrival Time:")]
        public void GivenISetArrivalTime(Table table)
        {
            string DepartureTime = table.Rows[0]["Arrival Time"];
            pom.SetArrivalTime(DepartureTime);
        }

        [Given("I press dialog OK button of Add a Service Line")]
        public void GivenIPressDialogOKButtonOfAddAServiceLine()
        {
            AllureLogger.LogStep("I press dialog OK button of Add a Service Line",
            pom.PressDialogOKButtonOfAddAServiceLine);
        }

        [Given("I take screenshot of Destination table with new service line added")]
        public void GivenITakeScreenshotOfDestinationTableWithNewServiceLineAdded()
        {
            AllureLogger.LogStep("I take screenshot of Destination table with new service line added",
               pom.TakeScreenshotOfDestinationTableWithNewServiceLineAdded);
        }

        [Given("I select Service lines to prep")]
        public void GivenISelectServiceLinesToPrep()
        {
            AllureLogger.LogStep("I select Service lines to prep",
             pom.SelectServiceLinesToPrep);
        }


        [Given("I select Prep button")]
        public void GivenISelectPrepButton()
        {
            AllureLogger.LogStep("I select Prep button",
             pom.SelectPrepButton);
        }

        [Given("I select Service lines to depart")]
        public void GivenISelectServiceLinesToDepart()
        {
            AllureLogger.LogStep("I select Service lines to depart",
             pom.SelectServiceLinesToDepart);
        }


        [Given("I select Prep unit from table records")]
        public void GivenISelectPrepUnitFromTableRecords()
        {
            AllureLogger.LogStep("I select Prep unit from table records",
             pom.SelectPrepUnitFromTableRecords);
        }


        [Given("I select Depart button")]
        public void GivenISelectDepartButton()
        {
            AllureLogger.LogStep("I select Depart button",
             pom.SelectDepartButton);
        }
               
        [Given("I select value lookup of Delay Code field")]
        public void GivenISelectValueLookupOfDelayCodeField()
        {
            AllureLogger.LogStep("I select value lookup of Delay Code field",
              pom.SelectValueLookupOfDelayCodeField);
        }

        [Given("I filter table Delay Code:")]
        public void GivenIFilterTableDelayCode(Table table)
        {
            string DelayCode = table.Rows[0]["Delay Code"];
            pom.FilterTableDelayCode(DelayCode);
        }

        [Given("I select no.{int} record Delay Code table records")]
        public void GivenISelectNo_RecordDelayCodeTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Delay Code table records",
             () => pom.SelectNoRecordDelayCodeTableRecords(recordNumber));
        }

        [Given("I enter following Depart Run details:")]
        public void GivenIEnterFollowingDepartRunDetails(Table table)
        {
            string DelayReason = table.Rows[0]["Delay Reason"];
            string DepartureTimeChangeReason = table.Rows[0]["Departure Time Change Reason"];
            pom.EnterFollowingData(DelayReason, DepartureTimeChangeReason);
        }


        [Given("I press dialog OK button of Depart Run")]
        public void GivenIPressDialogOKButtonOfDepartRun()
        {
            AllureLogger.LogStep("I press dialog OK button of Depart Run",
            pom.PressDialogOKButtonOfDepartRun);
        }

        [Given("I go to In Service Tab")]
        public void GivenIGoToInServiceTab()
        {
            AllureLogger.LogStep("I go to In Service Tab",
            pom.GoToInServiceTab);
        }

        [Given("I take screenshot of Service Tab")]
        public void GivenITakeScreenshotOfServiceTab()
        {
            AllureLogger.LogStep("I take screenshot of Service Tab",
            pom.TakeScreenshotOfServiceTab);
        }

        [Given("I select List View button")]
        public void GivenISelectListViewButton()
        {
            AllureLogger.LogStep("I select List View button",
            pom.SelectListViewButton);
        }

        [Given("I go to Scheduled Arrivals Tab")]
        public void GivenIGoToScheduledArrivalsTab()
        {
            AllureLogger.LogStep("I go to Arrivals Tab",
            pom.GoToScheduledArrivalsTab);
        }

        [Given("I take screenshot of Scheduled Arrivals Tab")]
        public void GivenITakeScreenshotOfScheduledArrivalsTab()
        {
            AllureLogger.LogStep("I take screenshot of Scheduled Arrivals Tab",
            pom.TakeScreenshotOfScheduledArrivalsTab);
        }

        [Given("I take screenshot of Arrive Service Test")]
        public void GivenITakeScreenshotOfArriveServiceTest()
        {
            AllureLogger.LogStep("I take screenshot of Arrive Service Test",
            pom.TakeScreenshotOfArriveServiceTest);
        }

        [Given("I take screenshot of Depot View Tab")]
        public void GivenITakeScreenshotOfDepotViewTab()
        {
            AllureLogger.LogStep("I take screenshot of Depot View Tab",
             pom.TakeScreenshotOfDepotViewTab);
        }

        [Given("I couple unit")]
        public void GivenICoupleUnit()
        {
            AllureLogger.LogStep("I couple unit",
              pom.ICoupleUnit);
        }

        [Given("I take screenshot of coupled unit")]
        public void GivenITakeScreenshotOfCoupledUnit()
        {
            AllureLogger.LogStep("I take screenshot of coupled unit",
             pom.TakeScreenshotOfCoupledUnit);
        }

        [Given("I Uncouple unit")]
        public void GivenIUncoupleUnit()
        {
            AllureLogger.LogStep("I uncouple unit",
              pom.IUncoupleUnit);
        }

        [Given("I take screenshot of uncoupled unit")]
        public void GivenITakeScreenshotOfUncoupledUnit()
        {
            AllureLogger.LogStep("I take screenshot of uncoupled unit",
             pom.TakeScreenshotOfUncoupledUnit);
        }






        // In Service / Arriving Tab - Un-Arrive a Recently Arrived Train Step Definitions



        [Given("I select action un-arrive")]
        public void GivenISelectActionUn_Arrive()
        {
            AllureLogger.LogStep("I select action un-arrive",
              pom.SelectActionUnArrive);
        }

        [Given("I take screenshot of un-arrive a recently arrived train dialog")]
        public void GivenITakeScreenshotOfUn_ArriveARecentlyArrivedTrainDialog()
        {
            AllureLogger.LogStep("I take screenshot of un-arrive a recently arrived train dialog",
            pom.TakeScreenshotOfUnArriveARecentlyArrivedTrainDialog);
        }



        // In Service / Arriving Tab - Mark a Unit as No Show or Delayed Step Definitions


        [Given("I select action Manage Non-Arrival")]
        public void GivenISelectActionManageNon_Arrival()
        {
            AllureLogger.LogStep("I select action Manage Non-Arrival",
             pom.SelectActionManageNonArrival);
        }

        [Given("I Add Memo:")]
        public void GivenIAddMemo(Table table)
        {
            string Comment = table.Rows[0]["Comment"];
            AllureLogger.LogStep($"I enter Run Number: {Comment}", () =>
                pom.AddMemo(Comment));
        }

        [Given("I select Confirm Non-Arrival button")]
        public void GivenISelectConfirmNon_ArrivalButton()
        {
            AllureLogger.LogStep("I select Confirm Non-Arrival button",
            pom.SelectConfirmNonArrivalButton);
        }

        [Given("I take screenshot of No Show")]
        public void GivenITakeScreenshotOfNoShow()
        {
            AllureLogger.LogStep("I take screenshot of No Show",
            pom.TakeScreenshotOfNoShow);
        }




        // In Service / Arriving Tab Mark as Delayed Step Definitions


        [Given("I select action Manage Delay")]
        public void GivenISelectActionManageDelay()
        {
            AllureLogger.LogStep("I select action Manage Delay",
             pom.SelectActionManageDelay);
        }

        [Given("I set Expected Arrival Time:")]
        public void GivenISetExpectedArrivalTime(Table table)
        {
            string ExpectedArrivalTime = table.Rows[0]["Expected Arrival Time"];
            AllureLogger.LogStep($"I set Expected Arrival Time: {ExpectedArrivalTime}", () =>
                pom.SetExpectedArrivalTime(ExpectedArrivalTime));
        }

        [Given("I select value lookup of Arrival Delay Code field")]
        public void GivenISelectValueLookupOfArrivalDelayCodeField()
        {
            AllureLogger.LogStep("I select value lookup of Arrival Delay Code field",
              pom.SelectValueLookupOfArrivalDelayCodeField);
        }

        [Given("I filter table Arrival Delay Code:")]
        public void GivenIFilterTableArrivalDelayCode(Table table)
        {
            string ArrivalDelayCode = table.Rows[0]["Arrival Delay Code"];
            AllureLogger.LogStep($"I filter table Arrival Delay Code: {ArrivalDelayCode}", () =>
            pom.FilterTableArrivalDelayCode(ArrivalDelayCode));
        }

        [Given("I select no.{int} record Arrival Delay Code table records")]
        public void GivenISelectNo_RecordArrivalDelayCodeTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Arrival Delay Code table records",
              () => pom.SelectNoRecordArrivalDelayCodeTableRecords(recordNumber));
        }

        [Given("I enter Arrival Delay Reason:")]
        public void GivenIEnterArrivalDelayReason(Table table)
        {
            string ArrivalDelayReason = table.Rows[0]["Arrival Delay Reason"];
            AllureLogger.LogStep($"I filter table Arrival Delay Reason: {ArrivalDelayReason}", () =>
            pom.EnterArrivalDelayReason(ArrivalDelayReason));
        }

        [Given("I press dialog OK button of Manage Delay")]
        public void GivenIPressDialogOKButtonOfManageDelay()
        {
            AllureLogger.LogStep("I press dialog OK button of Manage Delay",
            pom.PressDialogOKButtonOfManageDelay);
        }

        [Given("I take screenshot of delayed train in service arrivals sub tab")]
        public void GivenITakeScreenshotOfDelayedTrainInServiceArrivalsSubTab()
        {
            AllureLogger.LogStep("I take screenshot of delayed train in service arrivals sub tab",
            pom.TakeScreenshotOfDelayedTrainInServiceArrivalsSubTab);
        }

        [Given("I select Arrived on Time button")]
        public void GivenISelectArrivedOnTimeButton()
        {
            AllureLogger.LogStep("I select Arrived on Time button",
            pom.SelectArrivedOnTimeButton);
        }

        [Given("I take screenshot of removed delay")]
        public void GivenITakeScreenshotOfRemovedDelay()
        {
            AllureLogger.LogStep("I take screenshot of removed delay",
            pom.TakeScreenshotOfRemovedDelay);
        }




        // Available for Service Tab - Allocate a Unit to a Service Step Definitions



        [Given("I go to Available for Service Tab")]
        public void GivenIGoToAvailableForServiceTab()
        {
            AllureLogger.LogStep("I go to Available for Service Tab",
             pom.GoToAvailableForServiceTab);
        }

        [Given("I select action Allocate Departure Timetable")]
        public void GivenISelectActionAllocateDepartureTimetable()
        {
            AllureLogger.LogStep("I select action Allocate Departure Timetable",
             pom.SelectActionAllocateDepartureTimetable);
        }

        [Given("I select no.{int} record of Allocate Departure Timetable table records")]
        public void GivenISelectNo_RecordOfAllocateDepartureTimetableTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record of Allocate Departure Timetable table records",
             () => pom.SelectNoRecordAllocateDepartureTimetableTableRecords(recordNumber));
        }


        [Given("I select Allocate Departure Service")]
        public void GivenISelectAllocateDepartureService()
        {
            AllureLogger.LogStep("I select Allocate Departure Service",
             pom.SelectAllocateDepartureService);
        }

        
        [Given("I take screenshot of Allocate Departure Service")]
        public void GivenITakeScreenshotOfAllocateDepartureService()
        {
            AllureLogger.LogStep("I take screenshot of Allocate Departure Service",
            pom.TakeScreenshotOfAllocateDepartureService);
        }

        [Given("I take screenshot of Allocated Unit in Depot View Tab")]
        public void GivenITakeScreenshotOfAllocatedUnitInDepotViewTab()
        {
            AllureLogger.LogStep("I take screenshot of Allocated Unit in Depot View Tab",
            pom.TakeScreenshotOfAllocatedUnitInDepotViewTab);
        }





        // Available for Service Tab - Change Unit Status Step Definitions



        [Given("I select action change unit status")]
        public void GivenISelectActionChangeUnitStatus()
        {
            AllureLogger.LogStep("I select action change unit status",
             pom.SelectActionChangeUnitStatus);
        }

        [Given("I select OK dialog button of Change Status of Rail Unit")]
        public void GivenISelectOKDialogButtonOfChangeStatusOfRailUnit()
        {
            AllureLogger.LogStep("I select OK dialog button of Change Status of Rail Unit",
             pom.SelectOKDialogButtonOfChangeStatusOfRailUnit);
        }



        [Given("I take screenshot of stopped status in Available for Service Tab")]
        public void GivenITakeScreenshotOfStoppedStatusInAvailableForServiceTab()
        {
            AllureLogger.LogStep("I take screenshot of stopped status in Available for Service Tab",
            pom.TakeScreenshotOfStoppedStatusInAvailableForServiceTab);
        }




        // Available for Service Tab - Un-assign Train from Service Step Definitions



        [Given("I select action Un-assign Train")]
        public void GivenISelectActionUn_AssignTrain()
        {
            AllureLogger.LogStep("I select action Un-assign Train",
            pom.SelectActionUnAssignTrain);
        }

        [Given("I take screenshot of Allocated Unit in Depot View Tab Test")]
        public void GivenITakeScreenshotOfAllocatedUnitInDepotViewTabTest()
        {
            AllureLogger.LogStep("I take screenshot of Allocated Unit in Depot View Tab Test",
             pom.TakeScreenshotOfAllocatedUnitInDepotViewTabTest);
        }


        [Given("I take screenshot of un-assigned train in Available for Service Tab")]
        public void GivenITakeScreenshotOfUn_AssignedTrainInAvailableForServiceTab()
        {
            AllureLogger.LogStep("I take screenshot of un-assigned train in Available for Service Tab",
             pom.TakeScreenshotOfUnAssignedTrainInAvailableForServiceTab);
        }




        // Available for Service Tab - Cancel a Service Step Definitions


        [Given("I go to Departures sub tab")]
        public void GivenIGoToDeparturesSubTab()
        {
            AllureLogger.LogStep("I go to Departures sub tab",
             pom.GoToDeparturesSubTab);
        }

        [Given("I go to Available for Service sub tab")]
        public void GivenIGoToAvailableForServiceSubTab()
        {
            AllureLogger.LogStep("I go to Available for Service sub tab",
             pom.GoToAvailableForServiceSubTab);
        }


        [Given("I select action Cancel Service Line")]
        public void GivenISelectActionCancelServiceLine()
        {
            AllureLogger.LogStep("I select action Cancel Service Line",
             pom.SelectActionCancelServiceLine);
        }

        [Given("I select OK dialog button of Cancel Service Line")]
        public void GivenISelectOKDialogButtonOfCancelServiceLine()
        {
            AllureLogger.LogStep("I select OK dialog button of Cancel Service Line",
             pom.SelectOKDialogButtonOfCancelServiceLine);
        }

        [Given("I select Ok dialog system message of Cancel Service Line")]
        public void GivenISelectOkDialogSystemMessageOfCancelServiceLine()
        {
            AllureLogger.LogStep("I select Ok dialog system message of Cancel Service Line",
             pom.SelectOkDialogSystemMessageOfCancelServiceLine);
        }


        [Given("I take screenshot of canceled service in Available for Service Tab")]
        public void GivenITakeScreenshotOfCanceledServiceInAvailableForServiceTab()
        {
            AllureLogger.LogStep("I take screenshot of canceled service in Available for Service Tab",
             pom.TakeScreenshotOfCanceledServiceInAvailableForServiceTab);
        }




        // Available for Service Tab - Depart a Service Step Definitions

        [Given("I select action Depart Train")]
        public void GivenISelectActionDepartTrain()
        {
            AllureLogger.LogStep("I select action Depart Train",
             pom.SelectActionDepartTrain);
        }

        [Given("I select value lookup of Delay Code")]
        public void GivenISelectValueLookupOfDelayCode()
        {
            AllureLogger.LogStep("I select value lookup of Delay Code",
            pom.SelectValueLookupOfDelayCode);
        }

        [Given("I filter Delay Code:")]
        public void GivenIFilterDelayCode(Table table)
        {
            string DelayCode = table.Rows[0]["Delay Code"];
            AllureLogger.LogStep($"I filter table Delay Code: {DelayCode}", () =>
                pom.FilterDelayCode(DelayCode));
        }

        [Given("I select no.{int} record from Delay Code table records")]
        public void GivenISelectNo_RecordFromDelayCodeTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Delay Code table records",
               () => pom.SelectNoRecordFromDelayCodeTableRecords(recordNumber));
        }

        [Given("I enter Delay Reason:")]
        public void GivenIEnterDelayReason(Table table)
        {
            string DelayReason = table.Rows[0]["Delay Reason"];
            AllureLogger.LogStep($"I filter table Delay Reason: {DelayReason}", () =>
                pom.FilterDelayReason(DelayReason));
        }

        [Given("I click OK dialog button of Depart Train")]
        public void GivenIClickOKDialogButtonOfDepartTrain()
        {
            AllureLogger.LogStep("I click OK dialog button of Depart Train",
            pom.ClickOKDialogButtonOfDepartTrain);
        }

        [Given("I take screenshot of departed train")]
        public void GivenITakeScreenshotOfDepartedTrain()
        {
            AllureLogger.LogStep("I take screenshot of departed train",
              pom.TakeScreenshotOfDepartedTrain);
        }

        [Given("I go to Recently Departed sub Tab")]
        public void GivenIGoToRecentlyDepartedSubTab()
        {
            AllureLogger.LogStep("I go to Recently Departed sub Tab",
             pom.GoToRecentlyDepartedSubTab);
        }

        [Given("I take screenshot of Recently Departed sub Tab")]
        public void GivenITakeScreenshotOfRecentlyDepartedSubTab()
        {
            AllureLogger.LogStep("I take screenshot of Recently Departed sub Tab",
              pom.TakeScreenshotOfRecentlyDepartedSubTab);
        }

        [Given("I select action Revoke Depart Train")]
        public void GivenISelectActionRevokeDepartTrain()
        {
            AllureLogger.LogStep("I select action Revoke Depart Train",
             pom.SelectActionRevokeDepartTrain);
        }

        [Given("I select value lookup of Return Road")]
        public void GivenISelectValueLookupOfReturnRoad()
        {
            AllureLogger.LogStep("I select value lookup of Return Road",
           pom.SelectValueLookupOfReturnRoad);
        }

        [Given("I filter Return Road:")]
        public void GivenIFilterReturnRoad(Table table)
        {
            string ReturnRoad = table.Rows[0]["Return Road"];
            AllureLogger.LogStep($"I filter table Return Road: {ReturnRoad}", () =>
                pom.FilterReturnRoad(ReturnRoad));
        }


        [Given("I select no.{int} record from Return Road table records")]
        public void GivenISelectNo_RecordFromReturnRoadTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Return Road table records",
              () => pom.SelectNoRecordFromReturnRoadTableRecords(recordNumber));
        }

        [Given("I enter Return Position:")]
        public void GivenIEnterReturnPosition(Table table)
        {
            string ReturnPosition = table.Rows[0]["Return Position"];
            AllureLogger.LogStep($"I filter table Return Position: {ReturnPosition}", () =>
                pom.FilterReturnPosition(ReturnPosition));
        }

        [Given("I click OK dialog button of Revoke Departure")]
        public void GivenIClickOKDialogButtonOfRevokeDeparture()
        {
            AllureLogger.LogStep("I click OK dialog button of Revoke Departure",
            pom.ClickOKDialogButtonOfRevokeDeparture);
        }

        [Given("I take screenshot of Recently Revoke Departure")]
        public void GivenITakeScreenshotOfRecentlyRevokeDeparture()
        {
            AllureLogger.LogStep("I take screenshot of Recently Revoke Departure",
              pom.TakeScreenshotOfRecentlyRevokeDeparture);
        }




        // Available for Service Tab - Add a New Service Line Step Definitions



        [Given("I select Add a New Service Line")]
        public void GivenISelectAddANewServiceLine()
        {
            AllureLogger.LogStep("I select Add a New Service Line",
            pom.SelectAddANewServiceLine);
        }

        [Given("I select value lookup of Destination")]
        public void GivenISelectValueLookupOfDestination()
        {
            AllureLogger.LogStep("I select value lookup of Destination",
            pom.SelectValueLookupOfDestination);
        }

        [Given("I filter table Destination:")]
        public void GivenIFilterTableDestination(Table table)
        {
            string Destination = table.Rows[0]["Destination"];
            AllureLogger.LogStep($"I filter table Destination: {Destination}", () =>
                pom.FilterTableDestination(Destination));
        }

        
        [Given("I select no.{int} record Destination table records")]
        public void GivenISelectNo_RecordDestinationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Destination table records",
            () => pom.SelectNoRecordDestinationTableRecords(recordNumber));
        }

        [Given("I select value lookup of Direction field")]
        public void GivenISelectValueLookupOfDirectionField()
        {
            AllureLogger.LogStep("I select value lookup of Direction",
            pom.SelectValueLookupOfDirection);
        }

        [Given("I filter Direction:")]
        public void GivenIFilterDirection(Table table)
        {
            string Direction = table.Rows[0]["Direction"];
            AllureLogger.LogStep($"I filter table Direction: {Direction}", () =>
                pom.FilterDirection(Direction));
        }

        [Given("I select no.{int} record Direction table records")]
        public void GivenISelectNo_RecordDirectionTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Direction table records",
             () => pom.SelectNoRecordDirectionTableRecords(recordNumber));
        }

        [Given("I enter Departure and Arrival Time:")]
        public void GivenIEnterDepartureAndArrivalTime(Table table)
        {
            string DepartureTime = table.Rows[0]["Departure Time"];
            string ArrivalTime = table.Rows[0]["Arrival Time"];
            pom.EnterDepartureAndArrivalTime(DepartureTime, ArrivalTime);
        }


        [Given("I enter Service Line Details:")]
        public void GivenIEnterServiceLineDetails(Table table)
        {
            string RunNumber = table.Rows[0]["Run Number"];
            string Memo = table.Rows[0]["Memo"];
            string DutyNumber = table.Rows[0]["Duty Number"];
            pom.EnterServiceLineDetails(RunNumber, Memo, DutyNumber);
        }

               
        [Given("I select OK dialog button of Add a New Service Line")]
        public void GivenISelectOKDialogButtonOfAddANewServiceLine()
        {
            AllureLogger.LogStep("I select OK dialog button of Add a New Service Line",
            pom.SelectOKDialogButtonOfAddANewServiceLine);
        }

        [Given("I take screenshot of New Service Line")]
        public void GivenITakeScreenshotOfNewServiceLine()
        {
            AllureLogger.LogStep("I take screenshot of New Service Line",
              pom.TakeScreenshotOfNewServiceLine);
        }




        // Available for Service Tab - Edit a Service Line Step Definitions



        [Given("I select action Edit Service Line")]
        public void GivenISelectActionEditServiceLine()
        {
            AllureLogger.LogStep("I select action Edit Service Line",
             pom.SelectActionEditServiceLine);
        }

        [Given("I select value lookup of Service Line Destination field")]
        public void GivenISelectValueLookupOfServiceLineDestinationField()
        {
            AllureLogger.LogStep("I select value lookup of Service Line Destination field",
            pom.SelectValueLookupOfServiceLineDestinationField);
        }
                                            

        [Given("I select no.{int} record Service Line Destination table records")]
        public void GivenISelectNo_RecordServiceLineDestinationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Service Line Destination table records",
           () => pom.SelectNoRecordDestinationTableRecords(recordNumber));
        }

        [Given("I select value lookup of Service Line Direction field")]
        public void GivenISelectValueLookupOfServiceLineDirectionField()
        {
            AllureLogger.LogStep("I select value lookup of Service Line Destination field",
            pom.SelectValueLookupOfServiceLineDirectionField);
        }

        [Given("I select no.{int} record Service Line Direction table records")]
        public void GivenISelectNo_RecordServiceLineDirectionTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Service Line Direction table records",
             () => pom.SelectNoRecordDirectionTableRecords(recordNumber));
        }

        [Given("I set Departure and Arrival Time:")]
        public void GivenISetDepartureAndArrivalTime(Table table)
        {
            string DepartureTime = table.Rows[0]["Departure Time"];
            string ArrivalTime = table.Rows[0]["Arrival Time"];
            pom.SetDepartureAndArrivalTime(DepartureTime, ArrivalTime);
        }

        [Given("I Edit Service Line Details:")]
        public void GivenIEditServiceLineDetails(Table table)
        {
            string Memo = table.Rows[0]["Memo"];
            string Notes = table.Rows[0]["Notes"];
            string DutyNumber = table.Rows[0]["Duty Number"];
            pom.EditServiceLineDetails(Memo, Notes, DutyNumber);
        }

        [Given("I click OK dialog button of Edit Service Line")]
        public void GivenIClickOKDialogButtonOfEditServiceLine()
        {
            AllureLogger.LogStep("I click OK dialog button of Edit Service Line",
            pom.ClickOKDialogButtonOfEditServiceLine);
        }
               

        [Given("I take screenshot of Edited Service Line")]
        public void GivenITakeScreenshotOfEditedServiceLine()
        {
            AllureLogger.LogStep("I take screenshot of Edited Service Line",
            pom.TakeScreenshotOfEditedServiceLine);
        }

        [Given("I clear Notes")]
        public void GivenIClearNotes()
        {
            AllureLogger.LogStep("I clear Notes",
            pom.ClearNotes);
        }



        // Available for Service Tab - Add a Sliding Comment to the Departure Service Line Step Definitions


        [Given("I enter Notes:")]
        public void GivenIEnterNotes(Table table)
        {
            string Notes = table.Rows[0]["Notes"];
            string Memo = table.Rows[0]["Memo"];
            pom.EnterNotes(Memo, Notes);
            
        }

        [Given("I take screenshot of Note Added to Service Line")]
        public void GivenITakeScreenshotOfNoteAddedToServiceLine()
        {
            AllureLogger.LogStep("I take screenshot of Note Added to Service Line",
            pom.TakeScreenshotOfNoteAddedToServiceLine);
        }




        // Move Request Tab - View Move Requests Step Definitions


        [Given("I take screenshot of Move Request Details Test Scenario")]
        public void GivenITakeScreenshotOfMoveRequestDetailsTestScenario()
        {
            AllureLogger.LogStep("I take screenshot of Move Request Details Test Scenario",
            pom.TakeScreenshotOfMoveRequestDetailsTestScenario);
        }


        [Given("I verify Status")]
        public void GivenIVerifyStatus()
        {
            AllureLogger.LogStep("I Verify Status",
            pom.VerifyStatus);
        }

        [Given("I verify Location")]
        public void GivenIVerifyLocation()
        {
            AllureLogger.LogStep("I Verify Location",
            pom.VerifyLocation);
        }

        [Given("I verify Move To")]
        public void GivenIVerifyMoveTo()
        {
            AllureLogger.LogStep("I Verify Move To",
            pom.VerifyMoveTo);
        }

        [Given("I verify Requested")]
        public void GivenIVerifyRequested()
        {
            AllureLogger.LogStep("I Verify Requested",
            pom.VerifyRequested);
        }

        [Given("I verify Move By Date")]
        public void GivenIVerifyMoveByDate()
        {
            AllureLogger.LogStep("I Verify Move By Date",
            pom.VerifyMoveByDate);
        }

        [Given("I verify Details")]
        public void GivenIVerifyDetails()
        {
            AllureLogger.LogStep("I Verify Details",
            pom.VerifyDetails);
        }

        [Given("I take screenshot of Move Request Details Tab")]
        public void GivenITakeScreenshotOfMoveRequestDetailsTab()
        {
            AllureLogger.LogStep("I take screenshot of Move Request Details Tab",
            pom.TakeScreenshotOfMoveRequestDetailsTab);
        }



        // Move Request Tab - Update an Existing Move Request Step Definitions

        [Given("I take screenshot of Create a Move Request Test Scenario")]
        public void GivenITakeScreenshotOfCreateAMoveRequestTestScenario()
        {
            AllureLogger.LogStep("I take screenshot of Create a Move Request Test Scenario",
            pom.TakeScreenshotOfCreateAMoveRequestTestScenario);
        }


        [Given("I modify Move By Date field")]
        public void GivenIModifyMoveByDateField()
        {
            AllureLogger.LogStep("I modify Move By Date field",
            pom.ModifyMoveByDateField);
        }

        [Given("I Open select value lookup of Destination")]
        public void GivenIOpenSelectValueLookupOfDestination()
        {
            AllureLogger.LogStep("I select value lookup of Destination",
            pom.OpenSelectValueLookupOfDestination);
        }

        [Given("I take screenshot of Update Move Request Details Test Scenario")]
        public void GivenITakeScreenshotOfUpdateMoveRequestDetailsTestScenario()
        {
            AllureLogger.LogStep("I take screenshot of Update Move Request Details Test Scenario",
            pom.TakeScreenshotOfUpdateMoveRequestDetailsTestScenario);
        }


        // Move Request Tab - Cancel a Move Request Step Definitions

        [Given("I take screenshot of Create Move Request Test Scenario")]
        public void GivenITakeScreenshotOfCreateMoveRequestTestScenario()
        {
            AllureLogger.LogStep("I take screenshot of Create Move Request Test Scenario",
            pom.TakeScreenshotOfCreateMoveRequestTestScenario);
        }


        [Given("I take screenshot of Cancelled Move Request Test Scenario")]
        public void GivenITakeScreenshotOfCancelledMoveRequestTestScenario()
        {
            AllureLogger.LogStep("I take screenshot of Cancelled Move Request Test Scenario",
            pom.TakeScreenshotOfCancelledMoveRequestTestScenario);
        }


        // At Location Tab - Allocate Unit to Service Step Definitions


        [Given("I take screenshot of Allocated Unit to Service test scenario")]
        public void GivenITakeScreenshotOfAllocatedUnitToServiceTestScenario()
        {
            AllureLogger.LogStep("I take screenshot of Allocated Unit to Service test scenario",
            pom.TakeScreenshotOfAllocatedUnitToServiceTestScenario);
        }


        // At Location Tab - View Units in the Yard Step Definitions


        [Given("I take screenshot of View Units in the Yard test scenario")]
        public void GivenITakeScreenshotOfViewUnitsInTheYardTestScenario()
        {
            AllureLogger.LogStep("I take screenshot of View Units in the Yard test scenario",
            pom.TakeScreenshotOfViewUnitsInTheYardTestScenario);
        }



        // At Location Tab - Create Move Requests Step Definitions


        [Given("I take screenshot of Move Request Test Scenario")]
        public void GivenITakeScreenshotOfMoveRequestTestScenario()
        {
            AllureLogger.LogStep("I take screenshot of Move Request Test Scenario",
            pom.TakeScreenshotOfMoveRequestTestScenario);
        }





        // Verifying a Unit After its Arrival at the Yard Step Definitions


        [Given("I Add Unit Attributes")]
        public void GivenIAddUnitAttributes()
        {
            AllureLogger.LogStep("I Add Unit Attributes",
             pom.IAddUnitAttributes);
        }

        [Given("I select Unit Attributes")]
        public void GivenISelectUnitAttributes()
        {
            AllureLogger.LogStep("I select Unit Attributes",
            pom.SelectUnitAttributes);
        }

        [Given("I select dialog button Continue")]
        public void GivenISelectDialogButtonContinue()
        {
            AllureLogger.LogStep("I select dialog button Continue",
            pom.SelectDialogButtonContinue);
        }

        [Given("I take screenshot of verified unit")]
        public void GivenITakeScreenshotOfVerifiedUnit()
        {
            AllureLogger.LogStep("I take screenshot of verified unit",
            pom.TakeScreenshotOfVerifiedUnit);
        }


        // View Tab - Block to a Unit Step Definitions


        [Given("I Add a block to a unit")]
        public void GivenIAddABlockToAUnit()
        {
            AllureLogger.LogStep("I Add a block to a unit",
             pom.AddABlockToAUnit);
        }

        [Given("I take screenshot of blocked unit")]
        public void GivenITakeScreenshotOfBlockedUnit()
        {
            AllureLogger.LogStep("I take screenshot of blocked unit",
             pom.TakeScreenshotOfBlockedUnit);
        }

        [Given("I remove block from a unit")]
        public void GivenIRemoveBlockFromAUnit()
        {
            AllureLogger.LogStep("I remove block from a unit",
             pom.RemoveBlockFromAUnit);
        }

        [Given("I take screenshot of unblocked unit")]
        public void GivenITakeScreenshotOfUnblockedUnit()
        {
            AllureLogger.LogStep("I take screenshot of unblocked unit",
             pom.TakeScreenshotOfUnblockedUnit);
        }



        // In Service / Arriving Tab - Arrive a Consist Step Definitions

        [Given("I select action Manage Consist")]
        public void GivenISelectActionManageConsist()
        {
            AllureLogger.LogStep("I select action Manage Consist",
             pom.SelectActionManageConsist);
        }

        [Given("I filter table Consist:")]
        public void GivenIFilterTableConsist(Table table)
        {

            string Consist = table.Rows[0]["Consist"];
            string Status = table.Rows[0]["Status"];
            pom.FilterConsist(Consist, Status   );
                                   
        }

        [Given("I select no.{int} record Consist table records")]
        public void GivenISelectNo_RecordConsistTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Consist table records",
              () => pom.SelectNoRecordConsistTableRecords(recordNumber));
        }

        [Given("I remove no.{int} unarrived units")]
        public void GivenIRemoveNo_UnarrivedUnits(int recordNumber)
        {
            AllureLogger.LogStep($"I remove no.{recordNumber} unarrived units",
              () => pom.RemoveNoUnarrivedUnits(recordNumber));
        }
                      

        [Given("I Update Consist")]
        public void GivenIUpdateConsist()
        {
            AllureLogger.LogStep("I Update Consist",
             pom.UpdateConsist);
        }



        // Available for Service Tab - View the Units that are Available for Service Step Definitions


        [Given("I take screenshot of Available for Service Tab")]
        public void GivenITakeScreenshotOfAvailableForServiceTab()
        {
            AllureLogger.LogStep("I take screenshot of Available for Service Tab",
             pom.TakeScreenshotOfAvailableForServiceTab);
        }




        //  Depot View - Update Traincare Work Orders Step Definitions

        [Given("I select View Train Care Work Orders from the action menu")]
        public void GivenISelectViewTrainCareWorkOrdersFromTheActionMenu()
        {
            AllureLogger.LogStep("I select View Traincare work orders from the action menu",
              () => pom.SelectViewTraincareWorkOrdersFromTheActionMenu());
        }
                       

        [Given("I complete no.{int} cleaning task in the Traincare work orders table")]
        public void GivenICompleteNo_CleaningTaskInTheTraincareWorkOrdersTable(int recordNumber)
        {
            AllureLogger.LogStep($"I complete no.{recordNumber} cleaning task in the Traincare work orders table",
              () => pom.CompleteNoCleaningTaskInTheTraincareWorkOrdersTable(recordNumber));
        }

        [Given("I click dialog OK button of View Traincare work orders")]
        public void GivenIClickDialogOKButtonOfViewTraincareWorkOrders()
        {
            AllureLogger.LogStep("I click dialog OK button of View Traincare work orders",
             pom.ClickDialogOKButtonOfViewTraincareWorkOrders);
        }

        [Given("I take screenshot of Update Traincare Work Orders Test")]
        public void GivenITakeScreenshotOfUpdateTraincareWorkOrdersTest()
        {
            AllureLogger.LogStep("I take screenshot of Update Traincare Work Orders Test",
             pom.TakeScreenshotOfUpdateTraincareWorkOrdersTest);
        }

        [Given("I take screenshot of completed cleaning task in the Traincare work orders table")]
        public void GivenITakeScreenshotOfCompletedCleaningTaskInTheTraincareWorkOrdersTable()
        {
            AllureLogger.LogStep("I take screenshot of completed cleaning task in the Traincare work orders table",
             pom.TakeScreenshotOfCompletedCleaningTaskInTheTraincareWorkOrdersTable);
        }




        // Depot View - Verify by engineer Step Definitions



        [Given("I select a pink background unit on the At Location Tab")]
        public void GivenISelectAPinkBackgroundUnitOnTheAtLocationTab()
        {
            AllureLogger.LogStep("I selecta pink background unit on the At Location Tab",
             pom.SelectAPinkBackgroundUnitOnTheAtLocationTab);
        }

        [Given("I select action addUnit Attributes to pink background unit")]
        public void GivenISelectActionAddUnitAttributesToPinkBackgroundUnit()
        {
            AllureLogger.LogStep("I select action addUnit Attributes to pink background unit",
              pom.SelectActionAddUnitAttributesToPinkBackgroundUnit);
        }



        [Given("I take screenshot of Verify by engineer")]
        public void GivenITakeScreenshotOfVerifyByEngineer()
        {
            AllureLogger.LogStep("I take screenshot of Verify by engineer",
             pom.TakeScreenshotOfVerifyByEngineer);
        }



        // Depot View - Managing Placeholders Step Definitions



        [Given("I take screenshot of Managing Placeholders")]
        public void GivenITakeScreenshotOfManagingPlaceholders()
        {
            AllureLogger.LogStep("I take screenshot of Managing Placeholders",
             pom.TakeScreenshotOfManagingPlaceholders);
        }




    }
}