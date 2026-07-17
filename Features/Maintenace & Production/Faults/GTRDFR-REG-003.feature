Feature:1.2.3 - Fault Raised and closed by Fault Reporter

You have received a call from a driver. You have assessed the issue over the phone and have resolved it. A Fault entry needs to be raised and completed. 


@1.2.3-FaultRaisedandclosedbyFaultReporter
Scenario: Fault Raised and closed by Fault Reporter
	Given I sign as <role>
    When I open application Work Orders, Fault Reporting (BRDA)
    And I create new record
    And I choose Select Value from Detail Menu of Location field
    And I filter table location:
      | Location |
      | 387102 |
    And I select no. 1 record from Location table records
    And I open Select Value lookup for Failure Group field
    And I select no. 3 record from Failure Group table
    And I open Select Value lookup for Failure Code field
    And I select no. 1 record from Failure Code table
    And I open Select Value lookup for Problem Code field
    And I select no. 1 record from Problem Code table
    And I enter following data:
      | Summary | Details |
      | Raising a duplicate Fault | Raising a duplicate Fault Auto Test |
    And I open Select Value lookup for Reported Priority
    And I select no. 1 record from Reported Priority table
    And I enter following data to Headcode:
      | Headcode |
      | TAUTO|
    And I open Select Value lookup for Repair Facility field
    And I select no. 1 record from Repair Facility table
    And I route the workflow
    And I press dialog button of Show Duplicate Tickets
    #And I press dialog button cancel
    #And I press Ok button
    And I select action Create Work Order
    And I choose Select Value from Detail Menu of Repair Facility
	And I select no. 4 from Repair Facility table records
    And I press dialog button ok
    When I go to Related Records tab
    And I view Related Work Order
    Then field Status has value WAIT-REV
    Then Relationship field has value FOLLOWUP
    And I take screenshot of Fault Raised and closed by Fault Reporter Test

    Examples:
      | role |
      | Fault Analyst |

     



    
    
