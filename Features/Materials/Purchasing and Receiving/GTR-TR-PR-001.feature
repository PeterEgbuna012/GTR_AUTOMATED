Feature: 0.0.1 - New Consumable Purchase Under Contract Price

There is demand in the storeroom that has not been met by the automatic reorder process (either not on reorder or not depleted to reorder point). As such an ad-hoc order is required. The item is under contract price and so no carriage charge is required.

@Feature:0.0.1-NewConsumablePurchaseUnderContractPrice
Scenario: New Consumable Purchase Under Contract Price
  Given I sign as stores
   And I select create New Purchase Requisition from quick insert menu
   And I enter Requisition Description:
      | Description |
      | New Consumable Purchase Under Contract Price Test |
  And I enter Required Date
  And I choose Select Value from Detail Menu of Company Field
  And I filter table Company Field:
      | Description |
      | BUCK & HICKMAN (WEST THURROCK) |
  And I select no. 1 record from Company table record
  And I select value lookup of Contact field
  And I select no. 1 record from Contact table record
  And I go to PR Lines tab
  And I select Vendor Items button
  And I filter table Vendor Items:
      | Vendor Items |
      | 039/140100 |
  And I select no. 1 record from Vendor Items table record
  And I press dialog OK button
  And I choose Select Value from Detail Menu of Storeroom
  And I filter table Storeroom:
      | Storeroom |
      | HE-VALUE |
  And I select no. 1 record from Storeroom table record
  And I select view PR details
  And I enter  Conversion Factor:
      | Conversion Factor |
      | 100 |
  And I Select Value from Detail Menu of Storeroom
  And I select no. 1 record from Storeroom table records
  And I save record
  And I go to tab Ship To Bill To 
  And I Verify the Ship To address
  And I Verify the Bill To address
  And I press route the workflow button
  And I set (Radio) field to Submit Purchase Request
  And I select OK dialog button
  And I close
  And I take screenshot of New Consumable Purchase Under Contract Price test


	Examples:
      | role |
      | stores |
