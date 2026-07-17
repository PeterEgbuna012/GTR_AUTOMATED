Feature: 0.0.2 - Rejecting An EM Work Order form the Work Bank

Rejecting a service request which was raised.

@Feature:0.0.2-RejectingAnEMWorkOrderformtheWorkBank
Scenario: 01) Create a EM Work Order
	Given I sign as <role>
	When I open application Work Orders, Fault Reporting (BRDA)
    And I create new record
    And I choose Select Value from Detail Menu of Location field
    And I filter table Location:
      | Location |
      | 377458 |
    And I select no. 1 record from Location table records
    And I open Select Value lookup for Failure Group field
    And I select no. 1 record from Failure Group table
    And I open Select Value lookup for Failure Code field
    And I select no. 1 record from Failure Code table
    And I open Select Value lookup for Problem Code field
    And I select no. 1 record from Problem Code table
    And I open Select Value lookup for Repair Facility field
    And I filter table Repair Facility:
      | Repair Facility |
      | BRIGHTON |
	And I select no. 1 record from Repair Facility table
    And I open Select Value lookup for Reported Priority
    And I filter table Reported Priority:
      | Reported Priority |
      | P12 Unit Stopped on Depot |
    And I select no. 1 record from Reported Priority table
    And I enter following data to Headcode:
      | Headcode |
      | TAUTO|
    And I enter following data:
      | Summary | Details |
      | Rejecting An EM Work Order form the Work Bank | Auto Test EM Work Order |
    And I route the workflow
    #And I press Ok button
    And I press dialog button of Show Duplicate Tickets
    And I route the workflow
    And I set (Radio) field to "Raise a Depot Work Order"
    Then I press dialog button OK
    When I go to Related Records tab
    And I view Related Work Order
    Then field Status has value WAIT-REV
    And I take screenshot of Rejecting An EM Work Order form the Work Bank scenario one


	  Examples:
      | role |
      | teamlead | 




Scenario:  02) Rejecting An EM Work Order from the Work Bank
	 Given I sign as <role>
	 And I open application Work Order Tracking BRDA from Fav Menu
     When I filter table EM:
		| Description | Status | Work Type |
		| Rejecting An EM Work Order form the Work Bank | =WAIT-REV | =EM |
    And I select no. 1 record from EM table
    And I press route the workflow button
    And I set (Radio) field to "Reject Work"
	And I press OK dialog button
	And  work order Status field has value CANCELLED
	And I take screenshot of Rejecting An EM Work Order form the Work Bank scenario two
    And I return to Maintainer Start Center


	 Examples:
      | role |
      | teamlead | 

