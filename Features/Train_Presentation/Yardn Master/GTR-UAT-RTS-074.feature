Feature: GTR-UAT-RTS-074 Depot View - Managing Placeholders

As a POM i arrive trains into the depot. The arriving trains may be a consist that has been created in line with the information that is in TRENT. In certain situations TRENT may include 
@allure.label.epic:YardMaster
@allure.label.feature:DepotView
@allure.label.story:AddUnittotheDepot
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-074
@allure.label.suite.scenario01.AddUnittotheDepot
Scenario: 01) Add Unit to the Depot
	Given I sign as Panel Operations Manager
	And I open application Road (BRDF)
	And I filter table Roads:
       | Road | 
       | BRIGHTON-YARD |
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
@allure.label.feature:DepotView
@allure.label.story:ManagingPlaceholders
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-074
@allure.label.suite.scenario02.ManagingPlaceholders
Scenario: Depot View - Managing Placeholders
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
	And I take screenshot of Managing Placeholders


	Examples:
      | role |
      | Panel Operations Manager |
