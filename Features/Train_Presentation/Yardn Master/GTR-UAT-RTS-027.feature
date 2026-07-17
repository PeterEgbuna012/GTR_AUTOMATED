Feature: GTR-UAT-RTS-027 Move Request Tab - View Move Requests

As a Panel Operations Manager, I want to view active Move Requests on units in the Yard

@Feature:GTR-UAT-RTS-027MoveRequestTab-ViewMoveRequests
Scenario: 01) Available for Service Tab - Add a New Service Line
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | PETERBOROUGH-NENE-YARD |
	And I select no.1 record Service Management table records
	And I go to Available for Service Tab
	And I go to Departures sub tab
	And I select Add a New Service Line
	And I select value lookup of Destination
	And I filter table Destination:
	   | Destination |
	   | PETERBOROUGH-NENE-YARD|
	And I select no.1 record Destination table records
	And I select value lookup of Direction field
	And I filter Direction: 
	   | Direction |
	   | S |
	And I select no.1 record Direction table records
	And I enter Departure and Arrival Time: 
		| Departure Time | Arrival Time |
		| 02:00:00       | 02:25:00     |
	And I enter Service Line Details:
		| Run Number | Memo  | Duty Number |
		| SU311      | Test  | 1234        |
	And I select OK dialog button of Add a New Service Line
	And I take screenshot of New Service Line
	And I go to Available for Service sub tab
	And I select action Allocate Departure Timetable
	And I select no.1 record of Allocate Departure Timetable table records
	And I select Allocate Departure Service
	And I take screenshot of Allocate Departure Service
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


   Examples:   
	| role |
	| Panel Operations Manager |


Scenario: 02) In Service / Arriving Tab - Arriving a Train that is in Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | PETERBOROUGH-NENE-YARD |
	And I select no.1 record Yard Asset table records
	And I go to In Service / Arriving Tab
	And I select action Arrive to Road
	And I select value lookup of Arrival Road field
	And I filter Arrival Road:
		| Arrival Road |  
		| PN-05-RD |
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



Scenario: 03) Create a Move Request
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | PETERBOROUGH-NENE-YARD |
	And I select no.1 record Yard Asset table records
	And I select Unit on Roads
	And I Select Create Move Request
	And I select value lookup of Road field
	And I filter Road:
		| Road |  
		| PN-06-RD |
	And I select no.1 record from Road table
	And I set Move By Date
	And I click ok dailog button of Create Move Request
	And I take screenshot of Create Move Request
	And I go to At Location Tab
	And I click action Create Move Request
	#And I select action Manage Move Request
	And I select value lookup of Road field
	And I filter Road:
		| Road |  
		| PN-04-RD |
	And I select no.1 record from Road table
	And I modify Move By Date
	And I click ok dailog button of Move Request Details
	And I take screenshot of Move Request Details Test Scenario


	Examples:
      | role |
      | Panel Operations Manager |




Scenario: 04) Move Request Tab - View Move Requests
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | PETERBOROUGH-NENE-YARD |
	And I select no.1 record Yard Asset table records
	And I go to Move Request Tab
	And I verify Status
	And I verify Location
	And I verify Move To
	And I verify Requested
	And I verify Move By Date
	#And I verify Details
	And I take screenshot of Move Request Details Tab


	Examples:
      | role |
      | Panel Operations Manager |










