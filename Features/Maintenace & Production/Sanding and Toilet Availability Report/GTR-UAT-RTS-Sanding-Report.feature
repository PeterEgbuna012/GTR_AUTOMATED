Feature: GTR-UAT-RTS-Sanding-Report

Users need to access the Sanding Report

@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:Sanding-Report
@allure.label.story:Sanding-Report
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-0.0.1
Scenario: Sanding Report
	Given I sign as <role>
    And I open application Sand Master (MXR)
	And I select action Run Reports
	And I filter Reports table Records:
		| Reports | 
		| Sanding Report |
	And I select no. 1 record from Sanding Reports table records
	And I enter Area:
		| Area | 
		| =SOUTHERN |
    And I set (Radio) field to "Immediate"
	And I submit Sanding Report
	And I wait for page to load
	And I take screenshot of Sanding Report


	 Examples:
      | role |
      | maxadmin |