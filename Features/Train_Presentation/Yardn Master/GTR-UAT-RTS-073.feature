Feature: GTR-UAT-RTS-073 Depot View - Verify by engineer

As an engineer / POM, I want to be able to mark a unit that it has been verified by an engineer to understand if the unit is fit for service or needs any additional maintenance work as it is arrived into the yard
@allure.label.epic:YardMaster
@allure.label.feature:DepotView
@allure.label.story:AddUnittotheDepot
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-073
@allure.label.suite.scenario01.AddUnittotheDepot
Scenario: 01) Add Unit to the Depot
	Given I sign as Panel Operations Manager
	And I open application Road (BRDF)
	And I filter table Roads:
       | Road | 
       | BRIGHTON-YARD |
	And I select no.5 record Roads table records
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
@allure.label.feature:DepotView
@allure.label.story:Verifybyengineer
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-073
@allure.label.suite.scenario02.Verifybyengineer
Scenario: 02) Depot View - Verify by engineer
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | BRIGHTON-YARD |
	And I select no.1 record Yard Asset table records
	And I go to Depot View Tab
	And I take screenshot of Depot View Tab
	And I go to At Location Tab
	And I select a pink background unit on the At Location Tab
	And I select action addUnit Attributes to pink background unit
	And I select Unit Attributes 
	And I select dialog button Continue
	And I take screenshot of Verify by engineer


	Examples:
      | role |
      | Panel Operations Manager |
