Feature: 0.0.0 - Create a EM Work Order

A short summary of the feature

@Feature:0.0.0-CreateaEMWorkOrder
Scenario: Create a EM Work Order
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
      | Create a EM Work Order| Auto Test EM Work Order |
    And I route the workflow
    #And I press Ok button
    And I press dialog button of Show Duplicate Tickets
    And I route the workflow
    And I set (Radio) field to "Raise a Depot Work Order"
    Then I press dialog button OK
    When I go to Related Records tab
    And I view Related Work Order
    Then field Status has value WAIT-REV
    And I take screenshot of Create a EM Work Order test



	  Examples:
      | role |
      | teamlead | 
