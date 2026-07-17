using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using OpenQA.Selenium;
using Reqnroll;
using System.Diagnostics.Metrics;

namespace GTR_AUTOMATED.StepDefinitions
{

    [Binding]
    public sealed class ItemMasterStepDefinitions
    {

        private readonly IWebDriver driver;
        private readonly ItemMasterPOM pom;

        public ItemMasterStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new ItemMasterPOM(driver);

        }

        [Given("I open application Item Master from Fav Menu")]
        public void GivenIOpenApplicationItemMasterFromFavMenu()
        {
            AllureLogger.LogStep("I open application Item Master from Fav Menu",
             pom.OpenApplicationItemMasterFromFavMenu);
        }

        [Given("I filter table Item Master:")]
        public void GivenIFilterTableItemMaster(Table table)
        {
            string ItemMaster = table.Rows[0]["Item Master"];
            AllureLogger.LogStep($"I filter table Item Master: {ItemMaster}", () =>
                pom.FilterTableLocation(ItemMaster));
        }

        [Given("I open Select Value lookup for Repairable item field")]
        public void GivenIOpenSelectValueLookupForRepairableItemField()
        {
            AllureLogger.LogStep("I open Select Value lookup for Repairable item field",
             pom.SelectValueLookupForRepairableItemField);
        }

        [Given("I select Y from table record")]
        public void GivenISelectYFromTableRecord()
        {
            AllureLogger.LogStep("I select Y from table record",
             pom.SelectYFromTableRecord);

            AllureLogger.LogStep("I click into the Part Number field and press Enter",
            pom.PartNumberField);
            
        }

        [Given("I select no. {int} record from Item Master table record")]
        public void GivenISelectNo_RecordFromItemMasterTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from  Item Master table records",
             () => pom.SelectNoRecordFromItemMasterTableRecord(recordNumber));
        }

        [Given("I review Item information")]
        public void GivenIReviewItemInformation()
        {
            AllureLogger.LogStep("I review Item information",
                pom.ReviewItemInformation);
           
        }

        [Given("I go to tab Specifications")]
        public void GivenIGoToTabSpecifications()
        {
            AllureLogger.LogStep("I go to tab Specifications",
             pom.GoToTabSpecifications);
        }

        [Given("I select Specifications table filter option")]
        public void GivenISelectSpecificationsTableFilterOption()
        {
            AllureLogger.LogStep("I select Specifications table filter option",
             pom.SelectSpecificationsTableFilterOption);
        }

        [Given("I open Select Value lookup for Attribute field")]
        public void GivenIOpenSelectValueLookupForAttributeField()
        {
            AllureLogger.LogStep("I open Select Value lookup for Attribute field",
            pom.SelectValueLookupForAttributeField);
        }


        [Given("I filter table Attribute:")]
        public void GivenIFilterTableAttribute(Table table)
        {
            string Attribute = table.Rows[0]["Attribute"];
            AllureLogger.LogStep($"I filter table Attribute: {Attribute}", () =>
                pom.FilterSpecificationsTableRecords(Attribute));
        }
           

        [Given("I select no. {int} record from Attribute table record")]
        public void GivenISelectNo_RecordFromAttributeTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from  Attribute table records",
              () => pom.SelectNoRecordFromAttributeTableRecord(recordNumber));
        }

        [Given("I Press OK button")]
        public void GivenIPressOKButton()
        {
            AllureLogger.LogStep("I Press OK button",
            pom.PressOKButton);
        }

        [Given("I open application Inventory Fav Menu")]
        public void GivenIOpenApplicationInventoryFavMenu()
        {
            AllureLogger.LogStep("I open application Inventory Fav Menu",
            pom.OpenApplicationInventoryFavMenu);
        }

        [Given("I filter Inventory table:")]
        public void GivenIFilterInventoryTable(Table table)
        {
            string storeroom = table.Rows[0]["storeroom"];
            pom.FilterTableInventor(storeroom);
        }


        [Given("I select no. {int} record from Inventory table record")]
        public void GivenISelectNo_RecordFromInventoryTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from  Inventory table records",
              () => pom.SelectNoRecordFromInventoryTableRecord(recordNumber));
        }

        [Given("I verify Inventory Balances")]
        public void GivenIVerifyInventoryBalances()
        {
            AllureLogger.LogStep("I View Details Button",
            pom.ViewDetailsButton);

            AllureLogger.LogStep("I verify Inventory Balances",
               pom.VerifyInventoryBalances);
        }

        [Given("I go to Reorder Details tab")]
        public void GivenIGoToReorderDetailsTab()
        {
            AllureLogger.LogStep("I go to Reorder Details tab",
            pom.GoToReorderDetailsTab);
        }

        [Given("I verify Primary Vendor details")]
        public void GivenIVerifyPrimaryVendorDetails()
        {
            AllureLogger.LogStep("I verify Primary Vendor details",
                 pom.VerifyPrimaryVendorDetails);
        }

        [Given("I take screenshot of Navigate in the Inventory and Item Master Applications test")]
        public void GivenITakeScreenshotOfNavigateInTheInventoryAndItemMasterApplicationsTest()
        {
            AllureLogger.LogStep("I take screenshot of Navigate in the Inventory and Item Master Applications test",
               pom.TakeScreenshotOfNavigateInTheInventoryAndItemMasterApplicationsTest);
        }





        // Issue Rotating Assets to a Work Order Step Definitions


        [Given("I open application Inventory Usage from Fav Menu")]
        public void GivenIOpenApplicationInventoryUsageFromFavMenu()
        {
            AllureLogger.LogStep("I open application Inventory Usage from Fav Menu",
           pom.OpenApplicationInventoryUsageFromFavMenu);
        }

        [Given("I select create New Inventory usage")]
        public void GivenISelectCreateNewInventoryUsage()
        {
            AllureLogger.LogStep("I select create New Inventory usage",
           pom.SelectCreateNewInventoryUsage);
        }

        [Given("I enter asset description:")]
        public void GivenIEnterAssetDescription(Table table)
        {
            string AssetDescription = table.Rows[0]["Asset Description"];
            AllureLogger.LogStep($"I enter asset description: {AssetDescription}", () =>
                pom.EnterAssetDescription(AssetDescription));
        }

        [Given("I choose Select Value from Detail Menu for Storeroom field")]
        public void GivenIChooseSelectValueFromDetailMenuForStoreroomField()
        {
            AllureLogger.LogStep("I Select Detail Menu for Storeroom",
             pom.DetailMenuForStoreroom);
            AllureLogger.LogStep("I Select Value for Storeroom",
             pom.SelectValueForStoreroom);
        }

        [Given("I select New Row button under the Usage Lines")]
        public void GivenISelectNewRowButtonUnderTheUsageLines()
        {
            AllureLogger.LogStep("I select New Row button under the Usage Lines",
             pom.SelectNewRowButtonUnderTheUsageLines);
        }

        [Given("I set Usage Type field to ISSUE")]
        public void GivenISetUsageTypeFieldToISSUE()
        {
            AllureLogger.LogStep("I Select Drop Down Menu Option",
            pom.DropdownMenuOption);
            AllureLogger.LogStep("I set Usage Type field to ISSUE",
            pom.SetUsageTypeFieldToISSUE);
        }

        [Given("I choose Select Value from Detail Menu for Item field")]
        public void GivenIChooseSelectValueFromDetailMenuForItemField()
        {
            AllureLogger.LogStep("I Select Detail Menu for Item",
             pom.DetailMenuForItem);
            AllureLogger.LogStep("I Select Value for Item",
             pom.SelectValueForItem);
        }

        [Given("I choose Select Value from Detail Menu of Work Order Field")]
        public void GivenIChooseSelectValueFromDetailMenuOfWorkOrderField()
        {
            AllureLogger.LogStep("Detail Menu Of Work Order field",
                 pom.SelectDetailMenuOfWorkOrderField);
            AllureLogger.LogStep("Select Value Option Of Work Order field",
                pom.SelectValueOptionOfWorkOrderField);
        }

        [Given("I filter work Order table:")]
        public void GivenIFilterWorkOrderTable(Table table)
        {
            string WorkOrderDescription = table.Rows[0]["Work Order Description"];
            AllureLogger.LogStep($"I filter work Order table: {WorkOrderDescription}", () =>
                pom.FilterWorkOrderTable(WorkOrderDescription));
        }

        [Given("I wait for Work order records")]
        public void GivenIWaitForWorkOrderRecords()
        {
            AllureLogger.LogStep("I wait for Work order records",
               pom.WaitForWorkOrderRecords);
        }


        [Given("I select no. {int} from work Order table record")]
        public void GivenISelectNo_FromWorkOrderTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from work Order table records",
             () => pom.SelectNoFromWorkOrderTableRecord(recordNumber));
        }

        [Given("I select Change status")]
        public void GivenISelectChangeStatus()
        {
            AllureLogger.LogStep("I Select Change status",
           pom.SelectChangeStatus);
        }

        [Given("I Change status")]
        public void GivenIChangeStatus()
        {
            AllureLogger.LogStep("I Change status",
            pom.IChangeStatus);
        }


        [Given("I select Complete from dropdown menu option of New Status field")]
        public void GivenISelectCompleteFromDropdownMenuOptionOfNewStatusField()
        {
            AllureLogger.LogStep("I Select dropdown menu option of New Status",
           pom.DropdownMenuOptionOfNewStatusField);
            AllureLogger.LogStep("I Select Complete",
           pom.SelectComplete);
        }

        [Given("I set \\(Radio) field to Use the default stage bin for each inventory item")]
        public void GivenISetRadioFieldToUseTheDefaultStageBinForEachInventoryItem()
        {
            AllureLogger.LogStep("I set (Radio) field to Use the default stage bin for each inventory item",
           pom.SetRadioFieldToUseTheDefaultStageBinForEachInventoryItem);
        }

        [Given("I press the dialog button OK")]
        public void GivenIPressTheDialogButtonOK()
        {
            AllureLogger.LogStep("I press the dialog button OK",
             pom.PressTheDialogButtonOK);
        }

        [Given("I select New Row button under Select Rotating Assets Section")]
        public void GivenISelectNewRowButtonUnderSelectRotatingAssetsSection()
        {
            AllureLogger.LogStep("I Select New Row button under Select Rotating Assets Section",
           pom.SelectNewRowButtonUnderSelectRotatingAssetsSection);
        }

        [Given("I open Select Value lookup for Asset field")]
        public void GivenIOpenSelectValueLookupForAssetField()
        {
            AllureLogger.LogStep("open Select Value lookup for Asset field",
           pom.OpenSelectValueLookupForAssetField);
        }

        [Given("I select no. {int} record from Rotating Asset table record")]
        public void GivenISelectNo_RecordFromRotatingAssetTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Rotating Asset table records",
             () => pom.SelectNoRecordFromRotatingAssetTableRecord(recordNumber));
        }

        [Given("I verify Asset serial number")]
        public void GivenIVerifyAssetSerialNumber()
        {
            AllureLogger.LogStep("I verify Asset serial number",
               pom.VerifyAssetSerialNumber);
        }

        [Given("Rotating Assets Status field has value COMPLETE")]
        public void GivenRotatingAssetsStatusFieldHasValueCOMPLETE()
        {
            AllureLogger.LogStep("Rotating Assets Status field has value COMPLETE",
             pom.RotatingAssetsStatusFieldHasValueCOMPLETE);
        }


        [Given("I click the dialog button OK")]
        public void GivenIClickTheDialogButtonOK()
        {
            AllureLogger.LogStep("I click the dialog button OK",
            pom.ClickTheDialogButtonOK);
        }

        [Given("I open application Assets")]
        public void GivenIOpenApplicationAssets()
        {
            AllureLogger.LogStep("Open [Go To] menu",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Assets Menu",
                pom.AssetMenuButton);
            AllureLogger.LogStep("Launch Assets Application",
                pom.AssetApplication);
        }

        [Given("I filter Asset table:")]
        public void GivenIFilterAssetTable(Table table)
        {
            string Asset = table.Rows[0]["Asset"];
            AllureLogger.LogStep($"I filter table Asset: {Asset}", () =>
                pom.FilterAssetTable(Asset));
        }
        
        [Given("I select no. {int} record from asset table records")]
        public void GivenISelectNo_RecordFromAssetTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from asset table records",
            () => pom.SelectNoRecordFromAssetTableRecords(recordNumber));
        }

        [Then("I take screenshot of Fault Work Order")]
        public void ThenITakeScreenshotOfFaultWorkOrder()
        {
            AllureLogger.LogStep("I take screenshot of Fault Work Order",
              pom.TakeScreenshotOfFaultWorkOrder);
        }


        [Given("I take screenshot of  Issue Rotating Assets to a Work Order test")]
        public void GivenITakeScreenshotOfIssueRotatingAssetsToAWorkOrderTest()
        {
            AllureLogger.LogStep("I take screenshot of  Issue Rotating Assets to a Work Order test",
              pom.TakeScreenshotOfIssueRotatingAssetsToAWorkOrderTest);
        }





        // Issue Rotating Assets to a Work Order Step Definitions



              

        [Given("I filter table storeroom:")]
        public void GivenIFilterTableStoreroom(Table table)
        {
            string Storeroom = table.Rows[0]["Storeroom"];
            string Item = table.Rows[0]["Item"];
            pom.FilterTableStoreroom(Storeroom, Item);
        }
           

        [Given("I filter Item table records:")]
        public void GivenIFilterItemTableRecords(Table table)
        {
            string Description = table.Rows[0]["Description"];
            string Item = table.Rows[0]["Item"];
            pom.FilterItemTableRecords(Description, Item);
        }

        [Given("I choose Select Value from Detail Menu of location field")]
        public void GivenIChooseSelectValueFromDetailMenuOfLocationField()
        {
             AllureLogger.LogStep("Detail Menu Of location field",
                pom.SelectDetailMenuOflocationField);
             AllureLogger.LogStep("Select Value Option Of location field",
                pom.SelectValueOptionOflocationField);
        }

        [Given("I filter location table:")]
        public void GivenIFilterLocationTable(Table table)
        {
            string location = table.Rows[0]["location"];
            AllureLogger.LogStep($"I filter table location: {location}", () =>
                pom.FilterTableStoreroom(location));
        }

        [Given("I select no. {int} record from location table records")]
        public void GivenISelectNo_RecordFromLocationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from location table records",
           () => pom.SelectNoRecordFromLocationTableRecords(recordNumber));
        }

        [Given("I select view Item details")]
        public void GivenISelectViewItemDetails()
        {
            AllureLogger.LogStep("I select view Item details",
               pom.SelectViewItemDetails);
        }

        [Given("I select New Row button under the Usage Line")]
        public void GivenISelectNewRowButtonUnderTheUsageLine()
        {
            AllureLogger.LogStep("I select New Row button under the Usage Line",
                pom.SelectNewRowButtonUnderTheUsageLine);
        }

        [Given("I filter locations table records:")]
        public void GivenIFilterLocationsTableRecords(Table table)
        {
            string location = table.Rows[0]["locations"];
            string Type = table.Rows[0]["Type"];
            pom.FilterLocationsTableRecords(location, Type);
        }

        [Given("I open Select Value lookup of Issue To field")]
        public void GivenIOpenSelectValueLookupOfIssueToField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Issue To field",
              pom.OpenSelectValueLookupOfIssueToField);
        }

        [Given("I filter Issue To table:")]
        public void GivenIFilterIssueToTable(Table table)
        {
            string IssueTo = table.Rows[0]["Issue To"];
            AllureLogger.LogStep($"I filter table Issue To: {IssueTo}", () =>
                pom.FilterIssueToTable(IssueTo));
        }

        [Given("I select no. {int} record from person records")]
        public void GivenISelectNo_RecordFromPersonRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from person table records",
          () => pom.SelectNoRecordFromPersonRecords(recordNumber));
        }

        [Given("I verify status changed to COMPLETE")]
        public void GivenIVerifyStatusChangedToCOMPLETE()
        {
            AllureLogger.LogStep("I verify status changed to COMPLETE",
             pom.VerifyStatusChangedToCOMPLETE);
        }

        [Given("I take screenshot of Issuing Consumable Materials test")]
        public void GivenITakeScreenshotOfIssuingConsumableMaterialsTest()
        {

            AllureLogger.LogStep("I take screenshot of Issuing Consumable Materials test",
               pom.TakeScreenshotOfIssuingConsumableMaterialsTest);
        }





        // Returning Items to Inventory Step Definitions



        [Given("I select Items for Return button")]
        public void GivenISelectItemsForReturnButton()
        {
            AllureLogger.LogStep("I select Items for Return button",
              pom.SelectItemsForReturnButton);
        }

        [Given("I filter table Items for Return:")]
        public void GivenIFilterTableItemsForReturn(Table table)
        {
            string Item = table.Rows[0]["Items"];
            AllureLogger.LogStep($"I filter table Items for Return: {Item}", () =>
                pom.FilterTableItemsForReturn(Item));
        }

        [Given("I select no. {int} record from Items for Return table records")]
        public void GivenISelectNo_RecordFromItemsForReturnTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Items for Return table records",
           () => pom.SelectNoRecordFromItemsForReturnTableRecords(recordNumber));
        }



        [Given("I press OK")]
        public void GivenIPressOK()
        {
            AllureLogger.LogStep("I press OK",
              pom.PressOK);
        }

        [Given("I take screenshot of complete status")]
        public void GivenITakeScreenshotOfCompleteStatus()
        {
            AllureLogger.LogStep("I take screenshot of complete status",
               pom.TakeScreenshotOfCompleteStatus);
        }

        [Given("I go to materials Tab")]
        public void GivenIGoToMaterialsTab()
        {
            AllureLogger.LogStep("I go to materials Tab",
              pom.GoToMaterialsTab);
        }

        [Given("I verify issued materials")]
        public void GivenIVerifyIssuedMaterials()
        {
            AllureLogger.LogStep("I verify issued materials",
             pom.VerifyIssuedMaterials);
        }

        [Given("I take screenshot of Returning Items test")]
        public void GivenITakeScreenshotOfReturningItemsTest()
        {
            AllureLogger.LogStep("I take screenshot of Returning Items test",
              pom.TakeScreenshotOfReturningItemsTest);
        }





        // Internal Transfers Step Definitions


        [Given("I set Usage Type field to Transfer")]
        public void GivenISetUsageTypeFieldToTransfer()
        {
            AllureLogger.LogStep("I Select Drop Down Menu Option",
            pom.DropdownMenuOption);
            AllureLogger.LogStep("I set Usage Type field to Transfer",
            pom.SetUsageTypeFieldToTransfer);
        }

        [Given("I choose Select Value from Detail Menu for Storeroom field Under Transfer details")]
        public void GivenIChooseSelectValueFromDetailMenuForStoreroomFieldUnderTransferDetails()
        {

            AllureLogger.LogStep("I Select Detail Menu for Storeroom field Under Transfer details",
             pom.DetailMenuForStoreroomFieldUnderTransferDetails);
            AllureLogger.LogStep("I Select Value for Storeroom field Under Transfer details",
             pom.SelectValueForStoreroomFieldUnderTransferDetails);
        }

        [Given("I filter Storeroom:")]
        public void GivenIFilterStoreroom(Table table)
        {
            string Storeroom = table.Rows[0]["Storeroom"];
            AllureLogger.LogStep($"I filter table Storeroom: {Storeroom}", () =>
                pom.IFilterStoreroom(Storeroom));
        }

        [Given("I open application Inventory from Fav Menu")]
        public void GivenIOpenApplicationInventoryFromFavMenu()
        {
            AllureLogger.LogStep("I open application Inventory from Fav Menu",
           pom.OpenApplicationInventoryFromFavMenu);
        }

        [Given("I filter Inventory:")]
        public void GivenIFilterInventory(Table table)
        {
            string Inventory = table.Rows[0]["Inventory"];
            AllureLogger.LogStep($"I filter table Inventory: {Inventory}", () =>
                pom.FilterInventory(Inventory));
        }

        [Given("I select no. {int} record from Inventory table records")]
        public void GivenISelectNo_RecordFromInventoryTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Inventory table records",
            () => pom.SelectNoRecordFromInventoryTableRecords(recordNumber));
        }

        [Given("I verify inventory balance")]
        public void GivenIVerifyInventoryBalance()
        {

               AllureLogger.LogStep("I verify inventory balance",
               pom.VerifyInventoryBalance);
        }

        [Given("I take screenshot of Internal Transfers test")]
        public void GivenITakeScreenshotOfInternalTransfersTest()
        {
             AllureLogger.LogStep("I take screenshot of Internal Transfers test",
             pom.TakeScreenshotOfInternalTransfersTest);
        }





        // Inter-depot Transfer Step Definitions


        [Given("I select Shipped from dropdown menu option of New Status field")]
        public void GivenISelectShippedFromDropdownMenuOptionOfNewStatusField()
        {
            AllureLogger.LogStep("I Select dropdown menu option of New Status",
            pom.DropdownMenuOptionOfNewStatusField);
            AllureLogger.LogStep("I Select Complete",
            pom.SelectShipped);
        }

        [Given("I open Select Value lookup of Ship To field")]
        public void GivenIOpenSelectValueLookupOfShipToField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Ship To field",
             pom.OpenSelectValueLookupOfShipToField);
        }

        [Given("I filter Ship To:")]
        public void GivenIFilterShipTo(Table table)
        {
            string ShipTo = table.Rows[0]["Ship To"];
            AllureLogger.LogStep($"I filter table Ship To: {ShipTo}", () =>
                pom.FilterShipTo(ShipTo));
        }

        [Given("I select no. {int} record from Ship To table records")]
        public void GivenISelectNo_RecordFromShipToTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Ship To table records",
            () => pom.SelectNoRecordFromShipToTableRecords(recordNumber));
        }

        [Given("I Press OK dialog button")]
        public void GivenIPressOKDialogButton()
        {
            AllureLogger.LogStep("I Press OK dialog button",
             pom.PressOKDialogButton);
        }

        [Given("I select action Run Reports")]
        public void GivenISelectActionRunReports()
        {
            AllureLogger.LogStep("I select action",
             pom.SelectAction);
            AllureLogger.LogStep("I Run Reports",
             pom.RunReports);
        }

        [Given("I filter table Shipment Reports:")]
        public void GivenIFilterTableShipmentReports(Table table)
        {
            string ShipmentReports = table.Rows[0]["Shipment Reports"];
            AllureLogger.LogStep($"I filter table Shipment Reports: {ShipmentReports}", () =>
                pom.FilterTableShipmentReports(ShipmentReports));
        }

        [Given("I select no. {int} record from Shipment Reports table record")]
        public void GivenISelectNo_RecordFromShipmentReportsTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record Shipment Reports To table records",
           () => pom.SelectNoRecordFromShipmentReportsTableRecord(recordNumber));
        }

        [Given("I Submit Reports")]
        public void GivenISubmitReports()
        {
            AllureLogger.LogStep("I Submit Reports",
            pom.SubmitReports);
        }

        [Given("I take screenshot of Inter-depot Transfer")]
        public void GivenITakeScreenshotOfInter_DepotTransfer()
        {
            AllureLogger.LogStep("I take screenshot of Inter-depot Transfer",
            pom.TakeScreenshotOfInterDepotTransfer);
        }






        //Receiving Shipments Step Definitions


        [Given("I open application shipment receiving from Fav Menu")]
        public void GivenIOpenApplicationShipmentReceivingFromFavMenu()
        {
            AllureLogger.LogStep("I open application shipment receiving from Fav Menu",
            pom.OpenApplicationShipmentReceivingFromFavMenu);
        }

        [Given("I filter table shipment receiving:")]
        public void GivenIFilterTableShipmentReceiving(Table table)
        {
            string ShipmentReceiving = table.Rows[0]["Shipment Receiving"];
            AllureLogger.LogStep($"I filter table Shipment Receiving: {ShipmentReceiving}", () =>
                pom.FilterTableShipmentReceiving(ShipmentReceiving));
        }

        [Given("I select no. {int} record from shipment receiving table record")]
        public void GivenISelectNo_RecordFromShipmentReceivingTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from shipment receiving table records",
          () => pom.SelectNoRecordFromShipmentReceivingTableRecord(recordNumber));
        }

        [Given("I select Shipped Items button")]
        public void GivenISelectShippedItemsButton()
        {
            AllureLogger.LogStep("I select Shipped Items button",
            pom.SelectShippedItemsButton);
        }

        [Given("I select no. {int} record from Shipped Items table records")]
        public void GivenISelectNo_RecordFromShippedItemsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from  Shipped Items table records",
           () => pom.SelectNoRecordFromShippedItemsTableRecords(recordNumber));
        }

        [Given("I click ok")]
        public void GivenIClickOk()
        {
            AllureLogger.LogStep("I click ok",
            pom.ClickOk);
        }

        [Given("I take screenshot of Receiving Shipments test")]
        public void GivenITakeScreenshotOfReceivingShipmentsTest()
        {
            AllureLogger.LogStep("I take screenshot of Receiving Shipments test",
             pom.TakeScreenshotOfReceivingShipmentsTest);
        }










    }
}