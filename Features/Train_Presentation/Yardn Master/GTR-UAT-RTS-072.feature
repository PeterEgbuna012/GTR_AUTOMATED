Feature: GTR-UAT-RTS-072 Depot View - Update Traincare Work Orders

As an engineer / POM, I want to be able to update traincare work orders directly from FAM

@allure.label.epic:YardMaster
@allure.label.feature:DepotView
@allure.label.story:UpdateTraincareWorkOrders
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-072
Scenario: Depot View - Update Traincare Work Orders
	Given I sign as <role> 
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | LITTLEHAMPTON-YARD |
	And I select no.1 record Yard Asset table records
	And I go to Depot View Tab
	And I select View Train Care Work Orders from the action menu
	And I complete no.1 cleaning task in the Traincare work orders table
	And I take screenshot of completed cleaning task in the Traincare work orders table
	And I click dialog OK button of View Traincare work orders
	And I take screenshot of Update Traincare Work Orders Test


		Examples:
      | role |
      | Panel Operations Manager |
