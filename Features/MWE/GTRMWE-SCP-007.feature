Feature: 0.0.7 - Asset Swap Work Order

Create an Asset Swap CM/EM Work order 

@Feature:2.0.1-AssigningaCMWorkOrder
Scenario: 01) Create a CM Work Order
Given I sign as <role>
	And I open application Work Order Tracking (BRDA)
	And I select create new record
	And I enter work order:
      | Description |
      | ASSET SWAP WO TEST |
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
	And I take screenshot of Asset Swap Work Order Test Scenario one
	

	Examples:
      | role |
      |maxadmin|


 Scenario: 02) Assigning a CM Work Order
 Given I sign as <role>
  And I open application Work Order Tracking BRDA from Favorite Menu
  And I filter table CM Work Order:
      | Description | Status  |
      | ASSET SWAP WO TEST | =WAIT-REV |
  And I select no. 1 record from CM Work Order table records
  And I press route the workflow button
  And I set (Radio) field to "Accept this Work Order into the Work Bank"
  And I select dialog button ok
  And I press route the workflow button
  And I set (Radio) field to "Send Work for Execution"
  And I select Ok dialog button
  And I go to Tab actuals
  And I select materials sub tab
  And I add new row in materials tab
  And I choose select value from detail menu of materials item field
  And I filter table item:
      | item |
      | 093/051371 |
  And I select no. 1 from item table records
  And I choose select value from detail menu of materials storeroom field
  And I filter storeroom:
      | storeroom |
      | BI-Z-VALUE |
  And I select no. 1 from materials storeroom table records
  And I choose select value from detail menu of rotating asset field
  And I select no. 1 record from rotating asset table records
  And I save record
  And I go to Assignments Tab
  And I add new row in Assignments Tab
  And I open Select Value lookup for Labor field
  And I filter table Labor:
      | Labor |
      | CBRUNS |
  And I select no. 1 record from Labor table records
  #And I pree Ok dialog system message button
  And I verify CM work order generated
  And I save record
  And I take screenshot of Asset Swap Work Order Test Scenario two
  
   Examples:
      | role        |
      | teamlead |

