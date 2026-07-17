Feature: 0.0.3 - Raising a Purchase Requisition - Stocked Item

There is demand in the storeroom that has not been met by the automatic reorder process (either not on reorder or not depleted to reorder point). As such an ad-hoc order is required. The item is under contract price and so no carriage charge is required.

@Feature:0.0.3-RaisingaPurchaseRequisition-StockedItem
Scenario: Raising a Purchase Requisition - Stocked Item
	Given I sign as <role>
	#And I go to Supply Chain Support Tab
	And I open application Purchase Requisition
	And I select New Purchase Requisition
	And I enter following Purchase Requisition:
      | Purchase Requisition |
      | Raising a Purchase Requisition - Stocked Item Test |
	And I set Required Date
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
    And I select no. 1 record from Storeroom table records
	And I enter GL Debit Account:
      | GL Debit Account |
      | 00000-00000-0000 |
	And I select view PR details
	And I enter  Conversion Factor:
      | Conversion Factor |
      | 4 |
    And I Select Value from Detail Menu of Storeroom
    And I select no. 1 record from Storeroom table records
    And I save record
	And I set (Radio) Allow Expediting Email True
	And I Verify Estimated Due Date is set to 15 days
	And I Verify Vendor Due Date is set plus 7 days
	And I go to Ship To Bill To tab
	And I Verify the Ship To address
	And I Verify the Bill To address
	And I press route the workflow button
	And I set (Radio) field to Submit Purchase Request
	And I press ok manual input dialog button
	And I close
	And I take screenshot of Raising a Purchase Requisition - Stocked Item Test


	 Examples:
      | role |
      | materials supply chain support |


