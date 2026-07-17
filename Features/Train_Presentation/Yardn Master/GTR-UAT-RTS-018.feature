Feature: GTR-UAT-RTS-018 In Service / Arriving Tab Mark as Delayed

As a Panel Operations Manager, I want to mark when a train is delayed so others can see it on the arrivals screen. 

@Feature:GTR-UAT-RTS-018InService/ArrivingTabMarkasDelayed
Scenario: In Service / Arriving Tab Mark as Delayed
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | BATTERSEA-STWRT-YARD |
	And I select no.1 record Yard Asset table records
	And I go to In Service / Arriving Tab
	And I select action Manage Delay
	And I set Expected Arrival Time:
	   | Expected Arrival Time |
	   | 03/07/26 10:00:00 |
	And I select value lookup of Arrival Delay Code field
	And I filter table Arrival Delay Code:
	   | Arrival Delay Code |
	   | TEST |
	And I select no.1 record Arrival Delay Code table records
	And I enter Arrival Delay Reason:
		| Arrival Delay Reason | 
		| Arrival Delay Reason Test |
	And I press dialog OK button of Manage Delay
	And I take screenshot of delayed train in service arrivals sub tab
	And I select action Manage Delay
	And I select Arrived on Time button
	And I take screenshot of removed delay


	Examples:
      | role |
      | Panel Operations Manager |
	
