Feature: GTR-UAT-RTS-Toilet-Availability-Report

Users need to access the Toilet Availability Report

@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:Toilet-Availability-Report
@allure.label.story:Toilet-Availability-Report
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-0.0.2
Scenario: Toilet Availability Report
	Given I sign as <role>
    And I open application Toilet Checker (MXR)
	And I select action Run Reports
	And I filter Reports:
		| Reports | 
		| Train Toilet Availability Report |
	And I select no. 1 record from Train Toilet Availability Reports table records
	And I enter Area:
		| Area | 
		| =SOUTHERN |
    And I set (Radio) field to "Immediate"
	And I submit Report
	And I wait for page to load
	And I take screenshot of Toilet Availability Report


	 Examples:
      | role |
      | maxadmin |
