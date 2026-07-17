Feature: 2.0.7 - Automatic work order status transition to WMATL


As a Team Leader when a WO requires a part but it has nil stock the work order should automatically change status to WMATL

@Feature:2.0.7-AutomaticworkorderstatustransitiontoWMATL
Scenario: Automatic work order status transition to WMATL
   Given I sign as <role>
   And I open application Inventory
   And I filter table Inventory:
      | Inventory | storeroom  |
      | 093/100225 | =HE-Value |
   And I return to Maintainer Start Center
   And I open application Work Order Tracking (BRDA)
	And I select create new record
	And I enter work order:
      | Description |
      | Transition To WMATL AUTO TEST |
	And I choose Select Value from Detail Menu of Location field
	And I filter table Location:
      | Location |
      | 387102 |
	And I select no. 1 from Location table records
	And I open Select Value lookup for Work Type field
	And I filter table Work Type:
      | Type |
      | =CM |
	And I select no. 1 from Work Type table records
	And I choose Select Value from Detail Menu of Repair Facility
	And I filter table Repair Facility:
      | Repair Facility |
      | HORNSEY |
	And I select no. 1 record from Repair Facility table records
	And I open Select Value lookup for Priority field
	And I filter table Priority field:
      | Value |
      | Next Exam |
	And I select no. 1 record from Priority table records
	And I Scheduled Start Date to today's date
	And I save CM record
	And I verify generated work order number
	And I go to tab Plan
    And I go to tab materials
    And I press add new row under materials tab
    And I choose Select Value from Detail Menu of Item field
    And I filter table Item:
      | Item |
      | 093/100225 |
    And I select no. 1 record from Item table records
    And I choose Select Value from Detail Menu of Storeroom field
    And I select no. 1 record from Storeroom table records
    And I set Direct Issue active
    And I save record
    And I press route the workflow button
    And I set (Radio) field to "Waiting Materials"
    And I press ok dialog button
    And I verify Status field has value WMATL
    And I verify generated WMATL work order number
    And I take screenshot of Automatic work order status transition to WMATL test


 Examples:
      | role |
      | teamlead | 
