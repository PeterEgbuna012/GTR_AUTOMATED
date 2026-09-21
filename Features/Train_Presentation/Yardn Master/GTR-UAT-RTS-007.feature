Feature: GTR-UAT-RTS-007 Depot View Tab - Stopping Units in the Depot

As an Engineer, I want to Stop units in the depot for an exam, maintenance or defect

@allure.label.epic:YardMaster
@allure.label.feature:DepotViewTab
@allure.label.story:AddUnittotheDepot
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-007
@allure.label.suite.scenario01.AddUnittotheDepot
Scenario: 01) Add Unit to the Depot
	Given I sign as Panel Operations Manager
	And I open application Road (BRDF)
	And I filter table Roads:
       | Road | 
       | BATTERSEA-STWRT-YARD |
	And I select no.2 record Roads table records
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

@allure.label.epic:YardMaster
@allure.label.feature:DepotViewTab
@allure.label.story:StoppingUnitsintheDepot
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-007
@allure.label.suite.scenario02.StoppingUnitsintheDepot
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


@allure.label.epic:YardMaster
@allure.label.feature:DepotViewTab
@allure.label.story:SetUnitintheDepottoActive
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-007
@allure.label.suite.scenario02.SetUnitintheDepottoActive
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

