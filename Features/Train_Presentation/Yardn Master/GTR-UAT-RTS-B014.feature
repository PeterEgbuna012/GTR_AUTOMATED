Feature: GTR-UAT-RTS-B014 In Service / Arriving Tab - Manually Allocating Units (If TRENT Integration is not available)

As a Panel Operations Manager, I want to view stopped units in the depot So that I can see a summary of why the unit was stopped, who did the work, where the unit is, how long it was stopped for and a release time & date.. 

@Ignore
@Feature:GTR-UAT-RTS-014InService/ArrivingTab-ManuallyAllocatingUnits(IfTRENTIntegrationisnotavailable)
Scenario: In Service / Arriving Tab - Manually Allocating Units (If TRENT Integration is not available)
	Given I sign as <role>
	And I open application Service Management (BRDF)
	And I filter table Service Management:
       | Yard Asset |
       | HORNSEY-YARD |
	And I select no.1 record Service Management table records
	#And I select Generate button
	#And I select value lookup of Timetable Name field
	#And I select no.1 record from Timetable Name table records
	#And I press dialog OK button of Generate Daily Service
	And I take screenshot of Service Management - Daily Service Generated
	And I select Service lines from table records
	And I select Add Line button 
	And I select value lookup of Destination field 
	And I filter Destination:
	   | Destination |
	   | HOVE-YARD |
    And I select no.1 record from Destination table records
	And I enter Run Number:
	   | Run Number |
	   | SU803B |
	And I enter Add a Service Line Memo:
	   | Memo |
	   | Test |
   And I set Departure Time:
	   | Departure Time |
	   | 01:00:00 |
   And I set Arrival Time:
	 | Arrival Time |
	 | 02:00:00 |
   And I press dialog OK button of Add a Service Line
   And I take screenshot of Destination table with new service line added
   And I select Service lines to prep
   And I select Prep button
   And I select Service lines to depart
   And I select Depart button
   And I select value lookup of Delay Code field
   And I filter table Delay Code:
       | Delay Code |
       | ES |
   And I select no.1 record Delay Code table records
   And I enter following Depart Run details:
		| Delay Reason | Departure Time Change Reason |
        | Delay Reason Test | Departure Time Change Reason Test |
   And I press dialog OK button of Depart Run
  And I go to In Service Tab
  And I take screenshot of Service Tab
  And I select List View button
  And I filter table Service Management:
       | Yard Asset |
       | HOVE-YARD |
	And I select no.1 record Service Management table records
	And I go to Scheduled Arrivals Tab
	And I take screenshot of Scheduled Arrivals Tab


	Examples:
      | role |
      | Panel Operations Manager |

   
