Feature: GTR-UAT-RTS-013 In Service / Arriving Tab - Action an Unplanned Arrival

As a Panel Operations Manager, I want to perform an unplanned arrival.

@Feature:GTR-UAT-RTS-013InService/ArrivingTab-ActionanUnplannedArrival
Scenario: In Service / Arriving Tab - Action an Unplanned Arrival
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | BATTERSEA-STWRT-YARD |
	And I select no.1 record Yard Asset table records
	And I go to In Service / Arriving Tab
	And I click on the Unplanned Arrival button
	And I take screenshot of Unplanned Arrival dialog
	And I select no.1 record from Unplanned Arrival table
	And I select OK button
	And I take screenshot of Unplanned Arrival Service Added to Planned Arrivals
	And I select action Arrive to Road
	And I select value lookup of Arrival Road field
	And I filter Arrival Road:
		| Arrival Road |  
		| SL-04-RD |
	And I select no.1 record from Arrival Road table
	And I set Arrived
	And I set Accepted
	And I set Yard
	And I select dialog Arrive Service button
	And I go to Depot View Tab
	And I take screenshot of Arrive Service


	Examples:
      | role |
      | Panel Operations Manager |
