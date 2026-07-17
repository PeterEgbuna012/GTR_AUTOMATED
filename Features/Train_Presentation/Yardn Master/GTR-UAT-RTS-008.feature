Feature: GTR-UAT-RTS-008 Depot View Tab - View Units in the Yard

As a FAM user, I want to see the units in in yard. Including their position, status and any other relevant information I need to do my job. 

@Feature:GTR-UAT-RTS-008DepotViewTab-ViewUnitsintheYard
Scenario: View Units in the Yard
	Given I sign as Fleet Control
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | BATTERSEA-STWRT-YARD |
	And I select no.1 record Yard Asset table records
	And I select Unit on Roads
	And I select View Details
	And I go to Vehicle tab
	And I take screenshot of Vehicle Tab
	And I go to Service Line Tab
	And I take screenshot of Service Line Tab
	And I go to Sanding Tab
	And I take screenshot of Sanding Tab
	And I go to Toilet Availability Tab
	And I take screenshot of Toilet Availability Tab
	And I go to Status History Tab
	And I take screenshot of Status History Tab
	And I go to Mileage History Tab
	And I take screenshot of Mileage History Tab
	And I go to Work Orders Tab
	And I take screenshot of Work Orders Tab
	And I press dialog Ok button
	And I filter Unit:
	   | Unit | 
	   | 377613 |
	And I take screenshot of filtered Unit


	Examples:
      | role |
      | Fleet Control |

	
