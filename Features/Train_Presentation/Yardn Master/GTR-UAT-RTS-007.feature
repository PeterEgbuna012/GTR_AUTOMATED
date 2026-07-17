Feature: GTR-UAT-RTS-007 Depot View Tab - Stopping Units in the Depot

As an Engineer, I want to Stop units in the depot for an exam, maintenance or defect

@Feature:GTR-UAT-RTS-007DepotViewTab-StoppingUnitsintheDepo
Scenario: 01) In Service / Arriving Tab - Arriving a Train that is in Service
	Given I sign as Panel Operations Manager
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | BATTERSEA-STWRT-YARD |
	And I select no.1 record Yard Asset table records
	And I go to In Service / Arriving Tab
	And I select action Arrive to Road
	And I select value lookup of Arrival Road field
	And I filter Arrival Road:
		| Arrival Road |  
		| SL-03-RD |
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



Scenario: 02) Stopping Units in the Depot
	Given I sign as Panel Operations Manager
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | BATTERSEA-STWRT-YARD |
	And I select no.1 record Yard Asset table records
	And I select Unit on Roads
	And I change unit status
	And I select STOPPED
	And I enter unit Memo:
		| Memo |  
		| TESTING |
    And I select value lookup of stop code field
	And I filter Stop Code:
		| Stop Code |  
		| ENG |
	And I select no.1 record from Stop Code table
	And I set Stop Date
	And I set Stop Estimated Release Date
	And I click dialog OK button of change unit status
	And I take screenshot of Stopped Unit in Depot
	

	Examples:
      | role |
      | Panel Operations Manager |



Scenario: 03) Set Unit in the Depot to Active
 Given I sign as Panel Operations Manager
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | BATTERSEA-STWRT-YARD |
	And I select no.1 record Yard Asset table records
	And I select Unit on Roads
	And I change unit status
	And I select Available for Service
	And I enter unit Memo:
		| Memo |  
		| STATUS UPDATED |
    And I click dialog OK button of change unit status
	And I take screenshot of Depot to Active
	

	Examples:
      | role |
      | Panel Operations Manager |

