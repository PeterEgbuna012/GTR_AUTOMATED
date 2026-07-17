Feature: 0.0.4 - Raising a Purchase Requisition - Non-stocked Item


There is demand in the storeroom that has not been met by the automatic reorder process (either not on reorder or not depleted to reorder point). As such an ad-hoc order is required. The item is under contract price and so no carriage charge is required.

@Feature:0.0.4-RaisingaPurchaseRequisition-Non-stockedItem
Scenario: Raising a Purchase Requisition - Non-stocked Item
    Given I sign as materials supply chain support
    And I open application Purchase Requisition
    #And I go to Supply Chain Support Tab
    And I select New Purchase Requisition
    And I enter following Purchase Requisition:
      | Purchase Requisition |
      | Raising a Purchase Requisition - Non-stocked Item |
	And I set Required Date
	And I choose Select Value from Detail Menu of Company Field
	And I filter table Company Field:
      | Description |
      | BUCK & HICKMAN (WEST THURROCK) |
	And I select no. 1 record from Company table record
	And I select value lookup of Contact field
	And I select no. 1 record from Contact table record
	And I go to PR Lines tab
	And I add new row under PR Lines tab
	And I select Material from Line Type dropdown options
	And I enter following Material Details:
		| Material Description | Line Cost | 
	 	| NON-STOCKED TEST     | 100       |
    And I open Select Value lookup for Order Unit field
	And I select no. 1 record from Order Unit table record
	And I choose Select Value and go to Work Order tracking (BRDA)
    And I filter table CM Work Order:
      | Description | Status  |
      | Complete Fault Work Order Assignments | =COMP-WREV |
    And I select no. 1 record from CM Work Order table records
    And I select Return With Value option
    #And I choose Select Value from Detail Menu of Work Order
	#And I filter table work Order:
    #  | Description |
    #  | Complete Fault Work Order Assignments |
	#And I select no. 1 record from work Order table record
    And I go to Ship To Bill To tab
	And I open Select Value lookup for Ship To field
	And I filter table Ship To:
      | Ship To |
      | GTR-HE |
	And I select no. 1 record from Ship To table record
	And I save record
	And I go to PR Lines tab
    And I Verify Estimated Due Date is set to 14 days
    And I Verify Vendor Due Date is set plus 7 days
    And I go to Ship To Bill To tab
    And I Verify the Ship To address
    And I Verify the Bill To address
    And I press route the workflow button
    And I set (Radio) field to Submit Purchase Request
	And I press ok manual input dialog button
    And I close
    And I take screenshot of  Raising a Purchase Requisition - Non-stocked Item Test


  Examples:
      | role |
      | materials supply chain support |
	
	
	
