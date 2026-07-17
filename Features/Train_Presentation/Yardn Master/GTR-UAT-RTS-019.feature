Feature: GTR-UAT-RTS-019 Available for Service Tab - Allocate a Unit to a Service

As a Panel Operations Manager I want to allocate a unit to a service through the Available for Service tab. 

@Feature:GTR-UAT-RTS-019AvailableforServiceTab-AllocateaUnittoaService
Scenario: Available for Service Tab - Allocate a Unit to a Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | BATTERSEA-STWRT-YARD |
	And I select no.1 record Service Management table records
	And I go to Available for Service Tab
	And I select action Allocate Departure Timetable
	And I select no.1 record of Allocate Departure Timetable table records
	And I select Allocate Departure Service
	And I take screenshot of Allocate Departure Service
	And I go to Depot View Tab
	And I take screenshot of Allocated Unit in Depot View Tab
	
   Examples:
      | role |
      | Panel Operations Manager |