Feature: GTR-UAT-RTS-030 At Location Tab - Allocate Unit to Service

As a Panel Operations Manager, I want to allocate a unit to a service. 
@allure.label.epic:YardMaster
@allure.label.feature:AvailableforServiceTab
@allure.label.story:AddaNewServiceLine
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-030
@allure.label.suite.scenario01.AddaNewServiceLine
Scenario: 01) Available for Service Tab - Add a New Service Line
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | THREE-BRIDGES-YARD  |
	And I select no.1 record Service Management table records
	And I go to Available for Service Tab
	And I go to Departures sub tab
	And I select Add a New Service Line
	And I select value lookup of Destination
	And I filter table Destination:
	   | Destination |
	   | THREE-BRIDGES-YARD |
	And I select no.1 record Destination table records
	And I select value lookup of Direction field
	And I filter Direction: 
	   | Direction |
	   | S |
	And I select no.1 record Direction table records
	And I enter Departure and Arrival Time: 
		| Departure Time | Arrival Time |
		| 03:20:00       | 03:35:00     |
	And I enter Service Line Details:
		| Run Number | Memo  | Duty Number |
		| SU311      | Test  | 1234        |
	And I select OK dialog button of Add a New Service Line
	And I take screenshot of New Service Line
	And I go to Available for Service sub tab
	And I select action Allocate Departure Timetable
	And I click on Yes dialog button of system message
	And I select no.1 record of Allocate Departure Timetable table records
	And I select Allocate Departure Service
	And I take screenshot of Allocate Departure Service
	And I go to Departures sub tab
	And I select action Depart Train
	And I set Off Berth Time to today's Time
	And I select value lookup of Delay Code
	And I filter Delay Code: 
	   | Delay Code |
	   | ES |
	And I select no.1 record from Delay Code table records
	And I enter Delay Reason: 
	   | Delay Reason |
	   | TESTING      |
	And I click OK dialog button of Depart Train
	And I take screenshot of departed train
	And I go to Recently Departed sub Tab
	And I take screenshot of Recently Departed sub Tab


   Examples:   
	| role |
	| Panel Operations Manager |




@allure.label.epic:YardMaster
@allure.label.feature:InService/ArrivingTab
@allure.label.story:ArrivingaTrainthatisinService
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-030
@allure.label.suite.scenario02.ArrivingaTrainthatisinService
Scenario: 02) In Service / Arriving Tab - Arriving a Train that is in Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | THREE-BRIDGES-YARD |
	And I select no.1 record Yard Asset table records
	And I go to In Service / Arriving Tab
	And I select action Arrive to Road
	And I select value lookup of Arrival Road field
	And I filter Arrival Road:
		| Arrival Road |  
		| TB-07-RD |
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
@allure.label.feature:AtLocationTab
@allure.label.story:AllocateaUnittoaService
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-030
@allure.label.suite.scenario03.AllocateaUnittoaService
Scenario: 03) At Location Tab - Allocate Unit to Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | THREE-BRIDGES-YARD |
	And I select no.1 record Service Management table records
	And I go to At Location Tab
	And I select action Allocate Departure Timetable
	And I click on Yes dialog button of system message
	And I select no.1 record of Allocate Departure Timetable table records
	And I select Allocate Departure Service
	And I take screenshot of Allocate Departure Service
	And I go to Depot View Tab
	And I take screenshot of Allocated Unit to Service test scenario 
	
   Examples:
      | role |
      | Panel Operations Manager |
