Feature: 1.2.2 - Raising a duplicate Fault in Fault Reporting


You have received a call from a driver. You are entering the information into the system and a check is required if the ticket is a duplicate.


@1.2.2-RaisingaduplicateFaultinFaultReporting
Scenario: Raising a duplicate Fault in Fault Reporting
   Given I sign as <role>
    When I open application Work Orders, Fault Reporting (BRDA)
    And I create new record
	And I choose Select Value from Detail Menu of Location field
    And I filter table location:
      | Location |
      | 387111 |
    And I select no. 1 record from Location table records
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
      | Raising a duplicate Fault | Raising a duplicate Fault Auto Test |
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
    And I take screenshot of Raising a duplicate Fault in Fault Reporting test

    Examples:
      | role        |
      | Fault Analyst |
