Feature: GTR-UAT-RTS-002 Depot View Tab - Adding and Removing a Block on a Road

As a Panel Operations Manager, I want to add a block to a road and I want to remove a block from a road. 

@allure.label.epic:YardMaster
@allure.label.feature:DepotViewTab
@allure.label.story:AddingandRemovingaBlockonaRoad
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-002
Scenario: Adding and Removing a Block on a Road
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | LITTLEHAMPTON-YARD |
	And I select no.1 record Yard Asset table records
	And I select no.1 Gap on Road Block diagram
	And I add Block to the Road
	And I enter Block Details:
		| Memo | Poistion |
		| TESTING     | 1 |
	And I select dialog ok button
   	And I take screenshot of Block added to the Road
	And I View Block details
	And I take screenshot of viewed Block details
	And I click OK dialog button
	And I Delete Block
	And I take screenshot of Deleted Block

	Examples:
      | role |
      | Panel Operations Manager |
