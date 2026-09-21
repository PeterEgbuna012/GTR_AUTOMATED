Feature: 0.0.25 - FOS Report

Run FOS report

@allure.label.epic:InventoryReports
@allure.label.feature:FOSReport
@allure.label.story:FOSReport
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.25
Scenario: FOS Report
      Given I sign as stores
	  And I open application Inventory
	  And I select action Run Reports
	  And I filter table Reports:
		| Reports | 
		| FOS Report |
	  And I select no. 1 record from Reports table record
	  And I enter Item number:
		| Item Number | 
		| =007/042021 |
	  And I submit FOS Report
	  And I wait for page to load
	  And I take screenshot of FOS Report test


	   Examples:
      | role |
      | stores |
	
