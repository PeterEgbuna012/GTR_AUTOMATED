Feature: GTR-UAT-RTS-015 In Service / Arriving Tab - Arriving a Train that is in Service

As a Panel Operations Manager, I want to be able to arrive trains that are scheduled to arrive at the selected depot and allocate them to a specific road.

@Feature:GTR-UAT-RTS-015InService/ArrivingTab-ArrivingaTrainthatisinService
Scenario: In Service / Arriving Tab - Arriving a Train that is in Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | BOGNOR-YARD |
	And I select no.1 record Yard Asset table records
	And I go to In Service / Arriving Tab
	And I select action Arrive to Road
	And I select value lookup of Arrival Road field
	And I filter Arrival Road:
		| Arrival Road |  
		| BG-P3 |
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
