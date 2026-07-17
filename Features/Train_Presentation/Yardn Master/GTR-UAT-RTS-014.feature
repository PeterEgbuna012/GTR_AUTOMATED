Feature: GTR-UAT-RTS-014 Depot View Tab - Manage Consists

As a Panel Operations Manager, I want to create a consist, move it to another road, replace a unit in the consist and uncouple it.

@Feature:GTR-UAT-RTS-014DepotViewTab-ManageConsists
Scenario: 01) In Service / Arriving Tab - Arriving a Train that is in Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | CRICKLEWOOD-SOUTH-SIDINGS-YARD |
	And I select no.1 record Yard Asset table records
	And I go to In Service / Arriving Tab
	And I select action Arrive to Road
	And I select value lookup of Arrival Road field
	And I filter Arrival Road:
		| Arrival Road |  
		| CW-UG-02 |
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


 Scenario: 02) In Service / Arriving Tab - Arriving a Train that is in Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | CRICKLEWOOD-SOUTH-SIDINGS-YARD |
	And I select no.1 record Yard Asset table records
	And I go to In Service / Arriving Tab
	And I select action Arrive to Road
	And I select value lookup of Arrival Road field
	And I filter Arrival Road:
		| Arrival Road |  
		| CW-UG-02 |
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



Scenario: 03) Depot View Tab - Manage Consists
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | CRICKLEWOOD-SOUTH-SIDINGS-YARD |
	And I select no.1 record Yard Asset table records
	And I go to Depot View Tab 
	And I couple unit
	And I take screenshot of coupled unit
	And I Uncouple unit
	And I take screenshot of uncoupled unit


	Examples:
      | role |
      | Panel Operations Manager |
