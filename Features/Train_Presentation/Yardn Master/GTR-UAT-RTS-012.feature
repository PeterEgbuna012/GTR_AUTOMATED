Feature: GTR-UAT-RTS-012 In Service / Arriving Tab - View Planned Arrivals 

As a Panel Operations Manager, I want to be able to view incoming arrivals that are scheduled to arrive at the selected depot so that i can get a view of what trains are expected, the expected time of arrival and  what train presentation activities are required.

@Feature:GTR-UAT-RTS-012InService/ArrivingTab-ViewPlannedArrivals 
Scenario: In Service / Arriving Tab - View Planned Arrivals
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | SELHURST-YARD |
	And I select no.1 record Yard Asset table records
	And I go to In Service / Arriving Tab
	And I take screenshot of Planned Arrivals in In Service / Arriving Tab
	And I select In Service Arrivals sub Tab
	And I take screenshot of In Service sub Tab 
	And I select Recently Arrive sub Tab
	And I take screenshot of Recently Arrive sub Tab
	And I select No Show sub Tab
	And I take screenshot of No Show sub Tab

	
	Examples:
      | role |
      | Panel Operations Manager |
