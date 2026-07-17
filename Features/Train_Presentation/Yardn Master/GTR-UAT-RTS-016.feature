Feature: GTR-UAT-RTS-016 In Service / Arriving Tab - Un-Arrive a Recently Arrived Train

As a Panel Operations Manager, I want to un-arrive a train that has been arrived in error so that it goes back into service. 

@Feature:GTR-UAT-RTS-016InService/ArrivingTab-Un-ArriveaRecentlyArrivedTrain
Scenario: 01) In Service / Arriving Tab - Arriving a Train that is in Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | LETCHWORTH-YARD |
	And I select no.1 record Yard Asset table records
	And I go to In Service / Arriving Tab
	And I select action Arrive to Road
	And I select value lookup of Arrival Road field
	And I filter Arrival Road:
		| Arrival Road |  
		| LE-04-RD |
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




Scenario: 02) In Service / Arriving Tab - Un-Arrive a Recently Arrived Train
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | LETCHWORTH-YARD |
	And I select no.1 record Yard Asset table records
	And I go to In Service / Arriving Tab
	And I select Recently Arrive sub Tab
	And I take screenshot of Recently Arrive sub Tab
	And I select action un-arrive
	And I take screenshot of un-arrive a recently arrived train dialog
	And I go to Depot View Tab
	And I take screenshot of Depot View Tab

	Examples:
      | role |
      | Panel Operations Manager |
	
