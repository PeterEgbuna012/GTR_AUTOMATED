Feature: 1.2.1 - Raising a Fault

 You have received a call from a driver. You have assessed the issue over the phone and have resolved it. A Fault entry needs to be raised and completed. 


@Feature:1.2.1-RaisingaFault
Scenario Outline: Raising a Fault
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
      | Raising a Fault Test | Raising a Fault Auto Test |
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
    And I take screenshot of Raising a Fault Test

    Examples:
      | role  |
      | Fault Analyst |