Feature: 0.0.24 - First time Pickrate Report

Run First time Pickrate Report

@allure.label.epic:InventoryReports
@allure.label.feature:FirsttimePickrateReport
@allure.label.story:FirsttimePickrateReport
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.24
Scenario: First time Pickrate Report
      Given I sign as stores
	  And I open application Inventory
	  And I select action Run Reports
	  And I filter table Reports:
		| Reports | 
		| Firsttime Pickrate Report|
	  And I select no. 1 record from Reports table record
	  And I select start date and end date
	  And I submit First time Pickrate Report
	  And I wait for page to load
	  And I take screenshot of First time Pickrate Report test


	   Examples:
      | role |
      | stores |

