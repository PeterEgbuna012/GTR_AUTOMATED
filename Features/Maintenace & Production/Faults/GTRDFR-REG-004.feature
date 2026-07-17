Feature: 1.2.4 - Complete Fault Work Order Assignments

Completing fault work order assignment raised in GTRDFR-REG-003

@Feature:1.2.4-CompleteFaultWorkOrderAssignments
Scenario: 01)  Raising a Fault
    Given I sign as <role>
    When I open application Work Orders, Fault Reporting (BRDA)
    And I create new record
    And I choose Select Value from Detail Menu of Location field
    And I select no. 3 record from Location table records
    And I open Select Value lookup for Failure Group field
    And I select no. 3 record from Failure Group table
    And I open Select Value lookup for Failure Code field
    And I select no. 1 record from Failure Code table
    And I open Select Value lookup for Problem Code field
    And I select no. 1 record from Problem Code table
    And I open Select Value lookup for Repair Facility field
    And I select no. 1 record from Repair Facility table
    And I open Select Value lookup for Reported Priority
    And I select no. 1 record from Reported Priority table
    And I enter following data to Headcode:
      | Headcode |
      | TAUTO|
    And I enter following data:
      | Summary | Details |
      | Complete Fault Work Order Assignments | Complete Fault Work Order Assignments Auto Test |
    And I route the workflow
    And I press dialog button of Show Duplicate Tickets
    #And I press Ok button 
    And I route the workflow
    And I set (Radio) field to "Raise a Depot Work Order"
    Then I press dialog button OK
    When I go to Related Records tab
    And I view Related Work Order
    Then field Status has value WAIT-REV
    Then Relationship field has value FOLLOWUP
    And I take screenshot of Complete Fault Work Order Assignments Scenario one

    Examples:
      | role |
      | fault analyst |



Scenario: 02) Complete Fault Work Order Assignments
Given I sign as <role>
And I open application Work Order Tracking (BRDA)
	And I filter table:
		| Description | Status |
		| Complete Fault Work Order Assignments | =WAIT-REV |
	And I select no. 1 record from CM Work Order table records
	And I press route the workflow button
    And I set (Radio) field to "Accept this Work Order into the Work Bank"
    And I select dialog button ok
    And I press route the workflow button
    And I set (Radio) field to "Send Work for Execution"
    And I select Ok dialog button
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
    #And I press route the workflow button
	#And I press the button Close
	And I save record
    And I go to Failure Reporting
    And I press dialog button Select Failure Codes
	And I filter table Failure Codes:
      | Failure Codes |
      | 171-FC-02 |
    And I select Fault Work Order Faliure Informations
	And I go to Log Tab
	And I press add new row button under Log section
	And I enter following data:
      | Summary       | Details |
      | Fault Work Order Assignments Test Completed | Fault Work Order Assignments Auto Test Completed |
    And I save record
    And I press route the workflow button
    And I press route the workflow button
    And I set (Radio) field to "Complete Work Assignment"
    And I press the button Ok
    And  work order Status field has value COMP-WREV
    And I take screenshot of Complete Fault Work Order Assignments Scenario two


 Examples:  
      | role  |
      | teamlead | 






