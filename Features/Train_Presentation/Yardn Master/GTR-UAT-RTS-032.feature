Feature: GTR-UAT-RTS-032 At Location Tab - Create Move Requests

As an Engineer, I want to create a move request. 
@allure.label.epic:YardMaster
@allure.label.feature:AtLocationTab
@allure.label.story:CreateMoveRequests
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-032
Scenario: At Location Tab - Create Move Requests
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | THREE-BRIDGES-YARD |
	And I select no.1 record Yard Asset table records
	And I go to At Location Tab
	And I select Create Move Request from the action menu options
	#And I select action Manage Move Request
	And I select value lookup of Road field
	And I filter Road:
		| Road |  
		| TB-DN-03 |
	And I select no.1 record from Road table
	And I modify Move By Date
	And I click ok dailog button of Move Request Details
	And I take screenshot of Move Request Test Scenario


	Examples:
      | role |
      | Panel Operations Manager |
