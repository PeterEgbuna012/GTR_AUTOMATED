Feature: GTR-UAT-RTS-019 Available for Service Tab - Allocate a Unit to a Service

As a Panel Operations Manager I want to allocate a unit to a service through the Available for Service tab. 
@allure.label.epic:YardMaster
@allure.label.feature:AvailableforServiceTab
@allure.label.story:AllocateaUnittoaService
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-019
Scenario: Available for Service Tab - Allocate a Unit to a Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | BATTERSEA-STWRT-YARD |
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