Feature: GTR-UAT-RTS-021 Available for Service Tab - Un-assign Train from Service

As a Panel Operations Manager, I want to un-assign (un-allocate) a unit from a service. 

@Feature:GTR-UAT-RTS-021AvailableforServiceTab-Un-assignTrainfromService
Scenario: 01) In Service / Arriving Tab - Arriving a Train that is in Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | SELHURST-YARD |
	And I select no.1 record Yard Asset table records
	And I go to In Service / Arriving Tab
	And I select action Arrive to Road
	And I select value lookup of Arrival Road field
	And I filter Arrival Road:
		| Arrival Road |  
		| SU-01-CLEAN |
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


Scenario: 02) Available for Service Tab - Allocate a Unit to a Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | SELHURST-YARD |
	And I select no.1 record Service Management table records
	And I go to Available for Service Tab
	And I select action Allocate Departure Timetable
	And I select no.1 record of Allocate Departure Timetable table records
	And I select Allocate Departure Service
	And I take screenshot of Allocate Departure Service
	And I go to Depot View Tab
	And I take screenshot of Allocated Unit in Depot View Tab Test
	
   Examples:
      | role |
      | Panel Operations Manager |



Scenario: 03) Available for Service Tab - Un-assign Train from Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | SELHURST-YARD |
	And I select no.1 record Service Management table records
	And I go to Available for Service Tab
	And I select action Un-assign Train
	And I take screenshot of un-assigned train in Available for Service Tab
	
   Examples:
	  | role |
	| Panel Operations Manager |
