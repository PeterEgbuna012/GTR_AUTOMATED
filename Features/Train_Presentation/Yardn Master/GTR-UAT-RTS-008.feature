Feature: GTR-UAT-RTS-008 Depot View Tab - View Units in the Yard

As a FAM user, I want to see the units in in yard. Including their position, status and any other relevant information I need to do my job. 
@allure.label.epic:DepotViewTab
@allure.label.feature:AvailableforServiceTab
@allure.label.story:AddUnittotheDepot
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-008
@allure.label.suite.scenario01.AddUnittotheDepot
Scenario: 01) Add Unit to the Depot
	Given I sign as Panel Operations Manager
	And I open application Road (BRDF)
	And I filter table Roads:
       | Road | 
       | BATTERSEA-STWRT-YARD |
	And I select no.3 record Roads table records
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




@allure.label.feature:DepotViewTab
@allure.label.story:ViewUnitsintheYard
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-008
@allure.label.suite.scenario02.ViewUnitsintheYard
Scenario: 02) View Units in the Yard
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

	
