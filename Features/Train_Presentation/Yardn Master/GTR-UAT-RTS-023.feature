Feature: GTR-UAT-RTS-023 Available for Service Tab - Depart a Service

As a Panel Operations Manager, I want to depart a service.
@allure.label.epic:YardMaster
@allure.label.feature:AvailableforServiceTab
@allure.label.story:AddUnittotheDepot
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-023
@allure.label.suite.scenario01.AddUnittotheDepot
Scenario: 01) Add Unit to the Depot
	Given I sign as Panel Operations Manager
	And I open application Road (BRDF)
	And I filter table Roads:
       | Road | 
       | THREE-BRIDGES-YARD |
	And I select no.6 record Roads table records
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
@allure.label.feature:AvailableforServiceTab
@allure.label.story:AddaNewServiceLine
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-023
@allure.label.suite.scenario02.AddaNewServiceLine
Scenario: 02) Available for Service Tab - Add a New Service Line
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
		| 17:45:00       | 18:25:00     |
	And I enter Service Line Details:
		| Run Number | Memo  | Duty Number |
		| SU311      | Test  | 1234        |
	And I select OK dialog button of Add a New Service Line
	And I take screenshot of New Service Line


   Examples:   
	| role |
	| Panel Operations Manager |



@allure.label.epic:YardMaster
@allure.label.feature:AvailableforServiceTab
@allure.label.story:AllocateaUnittoaService
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-023
@allure.label.suite.scenario03.AllocateaUnittoaService
 Scenario: 03) Available for Service Tab - Allocate a Unit to a Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | THREE-BRIDGES-YARD |
	And I select no.1 record Service Management table records
	And I go to Available for Service Tab
	And I select action Allocate Departure Timetable
	And I click on Yes dialog button of system message
	And I select no.1 record of Allocate Departure Timetable table records
	And I select Allocate Departure Service
	And I take screenshot of Allocate Departure Service
	And I go to Depot View Tab
	And I take screenshot of Allocated Unit in Depot View Tab
	
   Examples:
      | role |
      | Panel Operations Manager |



@allure.label.epic:YardMaster
@allure.label.feature:AvailableforServiceTab
@allure.label.story:DepartaService
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-023
@allure.label.suite.scenario04.DepartaService
Scenario: 04) Available for Service Tab - Depart a Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | THREE-BRIDGES-YARD |
	And I select no.1 record Service Management table records
	And I go to Available for Service Tab
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
	And I select action Revoke Depart Train
	And I select value lookup of Return Road
	And I filter Return Road: 
	   | Return Road |
	   | TB-TIL-01 |
	And I select no.1 record from Return Road table records
	And I enter Return Position:
	   | Return Position |
	   | 1 |
	And I click OK dialog button of Revoke Departure
	And I take screenshot of Recently Revoke Departure


	 Examples:
	  | role |
	| Panel Operations Manager |
