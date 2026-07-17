Feature: GTR-UAT-RTS-026 Available for Service Tab - Add a Sliding Comment to the Departure Service

As a Panel Operations Manager, I want to add a comment to the departure service

@Feature:GTR-UAT-RTS-026AvailableforServiceTab-AddaSlidingCommenttotheDepartureService
Scenario: 01) In Service / Arriving Tab - Arriving a Train that is in Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | HORNSEY-YARD |
	And I select no.1 record Yard Asset table records
	And I go to In Service / Arriving Tab
	And I select action Arrive to Road
	And I select value lookup of Arrival Road field
	And I filter Arrival Road:
		| Arrival Road |  
		| HE-05-RD |
	And I select no.1 record from Arrival Road table
	And I set Arrived
	And I set Accepted
	And I set Yard
	And I select dialog Arrive Service button
	And I take screenshot of Arrive Service Test
	And I go to Depot View Tab
	And I take screenshot of Depot View Tab


	Examples:
      | role |
      | Panel Operations Manager |




Scenario: 02) Available for Service Tab - Add a Sliding Comment to the Departure Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | HORNSEY-YARD |
	And I select no.1 record Service Management table records
	And I go to Available for Service Tab
	And I go to Departures sub tab
	And I select action Edit Service Line
	And I enter Notes:
		| Notes        | Memo |
		| TEST | MORE DRIVERS |
	And I click OK dialog button of Edit Service Line
	And I take screenshot of Note Added to Service Line


   Examples:   
	| role |
	| Panel Operations Manager |




Scenario: 03) Available for Service Tab - Remove Sliding Comment from the Departure Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | HORNSEY-YARD |
	And I select no.1 record Service Management table records
	And I go to Available for Service Tab
	And I go to Departures sub tab
	And I select action Edit Service Line
	And I enter Notes:
		| Notes | Memo            |
		| TEST  | TODAY'S DRIVERS |
	And I click OK dialog button of Edit Service Line
	#And I clear Notes
	#And I click OK dialog button of Edit Service Line
	And I take screenshot of Note Added to Service Line


   Examples:   
	| role |
	| Panel Operations Manager |


