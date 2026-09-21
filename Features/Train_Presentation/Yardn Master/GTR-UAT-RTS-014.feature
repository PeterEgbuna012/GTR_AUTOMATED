Feature: GTR-UAT-RTS-014 Depot View Tab - Manage Consists

As a Panel Operations Manager, I want to create a consist, move it to another road, replace a unit in the consist and uncouple it.
@allure.label.epic:YardMaster
@allure.label.feature:AvailableforServiceTab
@allure.label.story:AddUnittotheDepot
@allure.label.severity:Trivial
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-014
@allure.label.suite.scenario01.AddUnittotheDepot
Scenario: 01) Add Unit to the Depot
	Given I sign as Panel Operations Manager
	And I open application Road (BRDF)
	And I filter table Roads:
       | Road | 
       | CRICKLEWOOD-SOUTH-SIDINGS-YARD |
	And I select no.2 record Roads table records
	And I click button Select Existing Rail Unit
	And I click Filter Table option
	And I filter table Existing Rail Unit:
       | Status | 
       | AFS |
	And I select no.1 record Rail Units table records
	And I click Select button
	And I verify Rail unit
	And I take Screenshot of Add Unit to the Depot Test

	Examples:
      | role |
      | Panel Operations Manager |


@allure.label.epic:YardMaster
@allure.label.feature:InService/ArrivingTab
@allure.label.story:ArrivingaTrainthatisinService
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-014
@allure.label.suite.scenario02.ArrivingaTrainthatisinService
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



@allure.label.epic:YardMaster
@allure.label.feature:InService/ArrivingTab
@allure.label.story:ArrivingaTrainthatisinService
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-014
@allure.label.suite.scenario03.ArrivingaTrainthatisinService
Scenario: 03) In Service / Arriving Tab - Arriving a Train that is in Service
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



@allure.label.epic:YardMaster
@allure.label.feature:DepotViewTab
@allure.label.story:ManageConsists
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-014
@allure.label.suite.scenario04.ManageConsists
Scenario: 04) Depot View Tab - Manage Consists
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
