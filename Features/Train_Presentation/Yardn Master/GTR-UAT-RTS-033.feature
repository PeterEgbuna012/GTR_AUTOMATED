Feature: GTR-UAT-RTS-033 Depot View Tab - Verifying a Unit After its Arrival

As an Engineer, I want to verify a unit after it has arrived at the depot so that the POMs know which units are ready to go back into service.
@allure.label.epic:YardMaster
@allure.label.feature:DepotView
@allure.label.story:VerifyingaUnitAfteritsArrival
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-033
Scenario: Verifying a Unit After its Arrival
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | BATTERSEA-STWRT-YARD |
	And I select no.1 record Yard Asset table records
	And I go to Depot View Tab
	And I select Unit on Roads
	And I Add Unit Attributes
	And I select Unit Attributes 
	And I select dialog button Continue
	And I take screenshot of verified unit

	Examples:
      | role |
      | Panel Operations Manager |