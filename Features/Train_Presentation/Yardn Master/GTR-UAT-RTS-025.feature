Feature: GTR-UAT-RTS-025 Available for Service Tab - Edit a Service Line

As a Panel Operations Manager, I want to edit an existing service line.

@Feature:GTR-UAT-RTS-025AvailableforServiceTab-EditaServiceLine
Scenario: Available for Service Tab - Edit a Service Line
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | THREE-BRIDGES-YARD |
	And I select no.1 record Service Management table records
	And I go to Available for Service Tab
	And I go to Departures sub tab
	And I select action Edit Service Line
	And I select value lookup of Service Line Destination field
	And I filter table Destination:
	   | Destination |
	   | BRIGHTON-YARD |
	And I select no.1 record Service Line Destination table records
	And I select value lookup of Service Line Direction field
	And I filter Direction: 
	   | Direction |
	   | N |
	And I select no.1 record Service Line Direction table records
	And I set Departure and Arrival Time: 
		| Departure Time | Arrival Time |
		| 10:20:00       | 10:30:00     |
	And I Edit Service Line Details:
		| Memo | Notes  | Duty Number |
		| TESTING | BEST DRIVERS  | 1234        |
	And I click OK dialog button of Edit Service Line
	And I take screenshot of Edited Service Line


   Examples:   
	| role |
	| Panel Operations Manager |
