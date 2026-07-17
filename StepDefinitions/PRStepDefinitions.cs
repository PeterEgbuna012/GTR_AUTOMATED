using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using Reqnroll;
using System;
using BindingAttribute = Reqnroll.BindingAttribute;
using GivenAttribute = Reqnroll.GivenAttribute;
using PendingStepException = Reqnroll.PendingStepException;
using Table = Reqnroll.Table;

namespace GTR_AUTOMATED.StepDefinitions
{

    [Binding]
    public class PRStepDefinitions
    {
        private readonly IWebDriver driver;
        private readonly PRPOM pom;

        public PRStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new PRPOM(driver);

        }
                
        [Given("I select create New Purchase Requisition from quick insert menu")]
        public void GivenISelectCreateNewPurchaseRequisitionFromQuickInsertMenu()
        {
            AllureLogger.LogStep("I select create New Purchase Requisition from quick insert menu",
           pom.CreateNewPurchaseRequisitionFromQuickInsertMenu);
        }

        [Given("I enter Requisition Description:")]
        public void GivenIEnterRequisitionDescription(Reqnroll.Table table)
        {
            string Description = table.Rows[0]["Description"];
            

            pom.RequisitionDescription(Description);
        }

        [Given("I enter Required Date")]
        public void GivenIEnterRequiredDate()
        {
            AllureLogger.LogStep("I select Start and End time",
            pom.RequiredDate);
        }

        [Given("I choose Select Value from Detail Menu of Company Field")]
        public void GivenIChooseSelectValueFromDetailMenuOfCompanyField()
        {
            AllureLogger.LogStep("Detail Menu Of Company Field",
                pom.DetailMenuOfCompanyField);
            AllureLogger.LogStep("Select Value Option of Company",
                pom.SelectValueOptionofCompany);
        }

        [Given("I filter table Company Field:")]
        public void GivenIFilterTableCompanyField(Reqnroll.Table table)
        {
            string Description = table.Rows[0]["Description"];


            pom.FilterTableCompanyField(Description);
        }

        [Given("I select no. {int} record from Company table record")]
        public void GivenISelectNo_RecordFromCompanyTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Company table records",
               () => pom.SelectNoRecordFromCompanyTableRecord(recordNumber));
        }

        [Given("I select value lookup of Contact field")]
        public void GivenISelectValueLookupOfContactField()
        {
            AllureLogger.LogStep("I select value lookup of Contact field",
               pom.SelectValueLookupOfContactField);
        }

        [Given("I select no. {int} record from Contact table record")]
        public void GivenISelectNo_RecordFromContactTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Contact table records",
               () => pom.SelectNoRecordFromContactTableRecord(recordNumber));
        }

        [Given("I go to PR Lines tab")]
        public void GivenIGoToPRLinesTab()
        {
            AllureLogger.LogStep("I go to PR Lines tab",
                pom.GoToPRLinesTab);
        }

        [Given("I select Vendor Items button")]
        public void GivenISelectVendorItemsButton()
        {
            AllureLogger.LogStep("I select Vendor Items button",
               pom.SelectVendorItemsButton);
        }

        [Given("I filter table Vendor Items:")]
        public void GivenIFilterTableVendorItems(Table table)
        {
            string VendorItems = table.Rows[0]["Vendor Items"];
            AllureLogger.LogStep($"I filter table Vendor Items: {VendorItems}", () =>
                pom.FilterTableVendorItems(VendorItems));
        }

        [Given("I select no. {int} record from Vendor Items table record")]
        public void GivenISelectNo_RecordFromVendorItemsTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Vendor Items table records",
              () => pom.SelectNoRecordFromVendorItemsTableRecord(recordNumber));
        }

        [Given("I press dialog OK button")]
        public void GivenIPressDialogOKButton()
        {

            AllureLogger.LogStep("I press dialog OK button",
                pom.PressDialogOKButton);
        }


        [Given("I choose Select Value from Detail Menu of Storeroom")]
        public void GivenIChooseSelectValueFromDetailMenuOfStoreroom()
        {
            AllureLogger.LogStep("Detail Menu Of Storeroom Field",
                pom.DetailMenuOfStoreroomField);
            AllureLogger.LogStep("Select Value Option of Storeroom",
                pom.SelectValueOptionofStoreroom);
        }

        [Given("I filter table Storeroom:")]
        public void GivenIFilterTableStoreroom(Table table)
        {
            string Storeroom = table.Rows[0]["Storeroom"];
            AllureLogger.LogStep($"I filter table Storeroom: {Storeroom}", () =>
                pom.FilterTableStoreroom(Storeroom));
        }

        [Given("I select no. {int} record from Storeroom table record")]
        public void GivenISelectNo_RecordFromStoreroomTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Storeroom table records",
              () => pom.SelectNoRecordFromStoreroomTableRecord(recordNumber));
        }

        [Given("I select view PR details")]
        public void GivenISelectViewPRDetails()
        {
            AllureLogger.LogStep("I select view PR details",
                pom.SelectViewPRDetails);
        }

        [Given("I enter  Conversion Factor:")]
        public void GivenIEnterConversionFactor(Table table)
        {
            string ConversionFactor = table.Rows[0]["Conversion Factor"];


            pom.IEnterConversionFactor(ConversionFactor);
        }

        [Given("I Select Value from Detail Menu of Storeroom")]
        public void GivenISelectValueFromDetailMenuOfStoreroom()
        {
            AllureLogger.LogStep("Detail Menu Of Storeroom",
                pom.DetailMenuOfStoreroom);
            AllureLogger.LogStep("Select Value Option",
                pom.SelectValueOptiono);
        }
                       

        [Given("I go to tab Ship To Bill To")]
        public void GivenIGoToTabShipToBillTo()
        {
            AllureLogger.LogStep("I go to tab Ship To Bill To",
               pom.GoToTabShipToBillTo);
        }

        [Given("I Verify the Ship To address")]
        public void GivenIVerifyTheShipToAddress()
        {
            AllureLogger.LogStep("I Verify the Ship To address",
                pom.VerifyTheShipToAddress);
        }

        [Given("I Verify the Bill To address")]
        public void GivenIVerifyTheBillToAddress()
        {
            AllureLogger.LogStep("I Verify the Bill To address",
               pom.VerifyTheBillToAddress);
        }

        [Given("I set \\(Radio) field to Submit Purchase Request")]
        public void GivenISetRadioFieldToSubmitPurchaseRequest()
        {
            AllureLogger.LogStep("I set (Radio) field to Submit Purchase Request",
                pom.SetRadioFieldToSubmitPurchaseRequest);
        }

        [Given("I select OK dialog button")]
        public void GivenISelectOKDialogButton()
        {
            AllureLogger.LogStep("I select OK dialog button",
                pom.SelectOKDialogButton);
        }

        [Given("I close")]
        public void GivenIClose()
        {
            AllureLogger.LogStep("I close",
               pom.IClose);
        }

        [Given("I take screenshot of New Consumable Purchase Under Contract Price test")]
        public void GivenITakeScreenshotOfNewConsumablePurchaseUnderContractPriceTest()
        {
            AllureLogger.LogStep("I take screenshot of New Consumable Purchase Under Contract Price test",
                pom.TakeScreenshotOfNewConsumablePurchaseUnderContractPriceTest);
        }


        //New Consumable Purchase Under Contract Price Step Definitions

        [Given("I open application Receiving \\(Tr) from Fav Menu")]
        public void GivenIOpenApplicationReceivingTrFromFavMenu()
        {
            AllureLogger.LogStep("I open application Receiving (Tr) from Fav Menu",
               pom.OpenApplicationReceivingTrFromFavMenu);
        }
        
        [Given("I filter Receiving \\(Tr):")]
        public void GivenIFilterReceivingTr(Table table)
        {
            string description = table.Rows[0]["PO"];
            string POStatus = table.Rows[0]["PO Status"];
            string Receipts = table.Rows[0]["Receipts"];

            pom.FilterReceivingTr(description, POStatus, Receipts);
        }

        [Given("I select no. {int} record from PO Item table record")]
        public void GivenISelectNo_RecordFromPOItemTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from PO Item table records",
             () => pom.SelectNoRecordFromPOItemTableRecord(recordNumber));
        }

        [Given("I select Ordered Items button")]
        public void GivenISelectOrderedItemsButton()
        {
            AllureLogger.LogStep("I select Ordered Items button",
              pom.SelectOrderedItemsButton);
        }

        [Given("I enter  delivery note:")]
        public void GivenIEnterDeliveryNote(Table table)
        {
            string DeliveryNote = table.Rows[0]["Delivery Note"];
            string RemarksNote = table.Rows[0]["Remarks Note"];


            pom.EnterDeliveryNote(DeliveryNote, RemarksNote);
        }

        [Given("I select no. {int} PO Item to receive table records")]
        public void GivenISelectNo_POItemToReceiveTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from PO Item table records",
            () => pom.SelectNoPOItemToReceiveTableRecords(recordNumber));
        }


        [Given("I select no. {int} record from PO Item to receive table record")]
        public void GivenISelectNo_RecordFromPOItemToReceiveTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from PO Item table records",
             () => pom.SelectNoRecordFromPOItemToReceiveTableRecord(recordNumber));
        }

        [Given("I Press Ok")]
        public void GivenIPressOk()
        {
            AllureLogger.LogStep("I Press Ok",
             pom.PressOk);
        }

        [Given("I view Item details")]
        public void GivenIViewItemDetails()
        {
            AllureLogger.LogStep("I view Item details",
            pom.ViewItemDetails);
        }

        [Given("I take screenshot of completed status")]
        public void GivenITakeScreenshotOfCompletedStatus()
        {
            AllureLogger.LogStep("I take screenshot of completed status",
               pom.TakeScreenshotOfCompletedStatus);
        }

        [Given("I select action button Run Report")]
        public void GivenISelectActionButtonRunReport()
        {
            AllureLogger.LogStep("I select action button Run Report",
               pom.SelectAction);
            AllureLogger.LogStep("I Run Report",
               pom.RunReport);
        }

        [Given("I filter table Report:")]
        public void GivenIFilterTableReport(Table table)
        {
            string Report = table.Rows[0]["Report"];
            pom.FilterTableReport(Report);
        }

        [Given("I select no. {int} from Reports table records")]
        public void GivenISelectNo_FromReportsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Report table records",
             () => pom.SelectNoFromReportsTableRecords(recordNumber));
        }


        [Given("I select no. {int} record from Report table record")]
        public void GivenISelectNo_RecordFromReportTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Report table records",
             () => pom.SelectNoRecordFromReportTableRecord(recordNumber));
        }

        [Given("I set \\(Radio) field to submit report")]
        public void GivenISetRadioFieldToSubmitReport()
        {
            AllureLogger.LogStep("I set (Radio) field to submit report",
              pom.RadioFieldToSubmitReport);
        }

       
        [Given("I wait for page to load")]
        public void GivenIWaitForPageToLoad()
        {
            AllureLogger.LogStep("I wait for page to load",
              pom.IWaitForPageToLoad);
        }

        [Given("I take screenshot of Receiving New Consumable Material test")]
        public void GivenITakeScreenshotOfReceivingNewConsumableMaterialTest()
        {
            AllureLogger.LogStep("I take screenshot of Receiving New Consumable Material test",
                pom.TakeScreenshotOfReceivingNewConsumableMaterialTest);
        }




        //Receiving New Rotating Material Step Definitions

        [Given("I take screenshot of completed Receiving New Rotating Material")]
        public void GivenITakeScreenshotOfCompletedReceivingNewRotatingMaterial()
        {
            AllureLogger.LogStep("I take screenshot of completed Receiving New Rotating Material",
                pom.TakeScreenshotOfCompletedReceivingNewRotatingMaterial);
        }

        [Given("I select action Receive Rotating Items")]
        public void GivenISelectActionReceiveRotatingItems()
        {
            AllureLogger.LogStep("I Select Action",
               pom.ISelectAction);
            AllureLogger.LogStep("Receive Rotating Items",
               pom.ReceiveRotatingItems);
        }

        [Given("I select Auto number button")]
        public void GivenISelectAutoNumberButton()
        {
            AllureLogger.LogStep("I select Auto number button",
              pom.SelectAutoNumberButton);
        }

        [Given("I Press OK")]
        public void GivenIPressOK()
        {
            AllureLogger.LogStep("I Press OK",
               pom.IPressOK);
        }

        [Given("I verify status COMP")]
        public void GivenIVerifyStatusCOMP()
        {
            AllureLogger.LogStep("I verify status COMP",
                 pom.VerifyStatusCOMP);
        }
        
        [Given("I take screenshot of Receiving New Rotating Material test")]
        public void GivenITakeScreenshotOfReceivingNewRotatingMaterialTest()
        {
            AllureLogger.LogStep("I take screenshot of completed Receiving New Rotating Material",
                pom.TakeScreenshotOfCompletedReceivingNewRotatingMaterial);
        }





    }
}
