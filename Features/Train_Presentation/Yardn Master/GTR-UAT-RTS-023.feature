Feature: GTR-UAT-RTS-023 Available for Service Tab - Depart a Service

As a Panel Operations Manager, I want to depart a service.

@Feature:GTR-UAT-RTS-023AvailableforServiceTab-DepartaService
 Scenario: 01) Available for Service Tab - Allocate a Unit to a Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | SELHURST-YARD |
	And I select no.1 record Service Management table records
	And I go to Available for Service Tab
	And I select action Allocate Departure Timetable
	And I select no.2 record of Allocate Departure Timetable table records
	And I select Allocate Departure Service
	And I take screenshot of Allocate Departure Service
	And I go to Depot View Tab
	And I take screenshot of Allocated Unit in Depot View Tab
	
   Examples:
      | role |
      | Panel Operations Manager |



Scenario: 02) Available for Service Tab - Depart a Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | SELHURST-YARD |
	And I select no.1 record Service Management table records
	And I go to Available for Service Tab
	And I go to Departures sub tab
	And I select action Depart Train
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
	   | HE-05-RD |
	And I select no.1 record from Return Road table records
	And I enter Return Position:
	   | Return Position |
	   | 1 |
	And I click OK dialog button of Revoke Departure
	And I take screenshot of Recently Revoke Departure




	 Examples:
	  | role |
	| Panel Operations Manager |
