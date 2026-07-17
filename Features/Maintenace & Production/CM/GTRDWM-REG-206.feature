Feature: 2.0.6 - Approving an CM Work Order

You are reviewing Completed Work in your start centre and want to approve it

@Feature:2.0.6-ApprovinganCMWorkOrder
Scenario: 01) Create a CM Work Order
	Given I sign as <role>
	And I open application Work Order Tracking (BRDA)
	And I select create new record
	And I enter work order:
      | Description |
      | APPROVE CM WO TEST |
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
	And I take screenshot of Approving an CM Work Order test Scenario one
	

	Examples:
      | role |
      | maxadmin |


 Scenario: 02) Assigning a CM Work Order
 Given I sign as <role>
  And I open application Work Order Tracking BRDA from Favorite Menu
  And I filter table CM Work Order:
      | Description | Status  |
      | APPROVE CM WO TEST | =WAIT-REV |
  And I select no. 1 record from CM Work Order table records
  And I press route the workflow button
  And I set (Radio) field to "Accept this Work Order into the Work Bank"
  And I select dialog button ok
  And I press route the workflow button
  And I set (Radio) field to "Send Work for Execution"
  And I select Ok dialog button
  And I go to Assignments Tab
  And I add new row in Assignments Tab
  And I open Select Value lookup for Labor field
  And I filter table Labor:
      | Labor |
      | ISCOTT |
  And I select no. 2 record from Labor table records
  #And I pree Ok dialog system message button
  And I verify CM work order generated
  And I save record
  And I take screenshot of Approving an CM Work Order test Scenario two
  
   Examples:
      | role |
      | teamlead |





Scenario: 03) Completing a CM Work Order for Review
	Given I sign as <role>
    And I open application Work Order Tracking (BRDA)
	And I filter table CM:
		| Description | Status | Work Type |
		| APPROVE CM WO TEST | =SCHEDULED | =CM |
	And I select no. 1 record from CM Work Order table records
	And I press route the workflow button
    And I set (Radio) field to "Start Work"
    And I select Ok button
	And I press route the workflow button
	And I set (Radio) field to "Complete Work Assignment"
    And I press the button Ok
    And I press the button Close
	And I go to actuals Tab
	And I select new row under labor section
	And I choose select value from detail menu of labor field
	And I filter table actuals labor:
      | Labor |
      | ISCOTT |
	And I select no. 4 record from Labor table record
	And I set Start and End time
    And I press route the workflow button
	And I press the button Close
	And I save record
    And I go to Failure Reporting
    And I press dialog button Select Failure Codes
	And I filter table Failure Codes:
      | Failure Codes |
      | 171-FC-02 |
	And I select Faliure Informations
	And I go to tab Log
	And I press add new row button under Log section
	And I enter following data:
      | Summary       | Details |
      | CM WO AUTO TEST | CM WORK ORDER AUTO TEST |
    And I save record
    And I press route the workflow button
    #And I press route the workflow button
    #And I set (Radio) field to "Complete Work Assignment"
    #And I press the button Ok
    And  work order Status field has value COMP-WREV
    And I take screenshot of Approving an CM Work Order test Scenario three

    Examples:
      | role     |
      | teamlead | 



Scenario: 04) Approving an CM Work Order
	Given I sign as <role>
	And I open application Work Order Tracking (BRDA)
	And I filter table CM:
		| Description | Status | Work Type |
		| APPROVE CM WO TEST | =COMP-WREV | =CM |
    And I select no. 1 record from CM Work Order table records
	And I press route the workflow button
	And I set (Radio) field to "Approve Work Order"
	And I press dialog button ok
	And work order Status field has value COMP
	And I verify generated Rejectd work order number
	And I return to Maintainer Start Center
	And I take screenshot of Approving an CM Work Order test Scenario four


	Examples:
      | role |
      | maintainer teamleader | 


