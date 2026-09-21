Feature: GTR-UAT-RTS-026 Available for Service Tab - Add a Sliding Comment to the Departure Service

As a Panel Operations Manager, I want to add a comment to the departure service

@allure.label.epic:YardMaster
@allure.label.feature:AvailableforServiceTab
@allure.label.story:AddaNewServiceLine
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-026
@allure.label.suite.scenario01.AddaNewServiceLine
Scenario: 01) Available for Service Tab - Add a New Service Line
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | HORNSEY-YARD  |
	And I select no.1 record Service Management table records
	And I go to Available for Service Tab
	And I go to Departures sub tab
	And I select Add a New Service Line
	And I select value lookup of Destination
	And I filter table Destination:
	   | Destination |
	   | HORNSEY-YARD |
	And I select no.1 record Destination table records
	And I select value lookup of Direction field
	And I filter Direction: 
	   | Direction |
	   | S |
	And I select no.1 record Direction table records
	And I enter Departure and Arrival Time: 
		| Departure Time | Arrival Time |
		| 10:00:00       | 10:25:00     |
	And I enter Service Line Details:
		| Run Number | Memo  | Duty Number |
		| SU311      | Test  | 1234        |
	And I select OK dialog button of Add a New Service Line
	And I take screenshot of New Service Line


   Examples:   
	| role |
	| Panel Operations Manager |


@allure.label.epic:YardMaster
@allure.label.feature:InService/ArrivingTab
@allure.label.story:ArrivingaTrainthatisinService
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-026
@allure.label.suite.scenario02.ArrivingaTrainthatisinService
Scenario: 02) In Service / Arriving Tab - Arriving a Train that is in Service
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


@allure.label.epic:YardMaster
@allure.label.feature:AvailableforServiceTab
@allure.label.story:AddaSlidingCommenttotheDepartureService
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-026
@allure.label.suite.scenario03.AddaSlidingCommenttotheDepartureService
Scenario: 03) Available for Service Tab - Add a Sliding Comment to the Departure Service
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



@allure.label.epic:YardMaster
@allure.label.feature:AvailableforServiceTab
@allure.label.story:AllocateaUnittoaService
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-026
@allure.label.suite.scenario04.AllocateaUnittoaService
Scenario: 04) Available for Service Tab - Remove Sliding Comment from the Departure Service
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


