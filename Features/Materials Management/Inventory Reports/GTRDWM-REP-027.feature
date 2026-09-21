Feature: 0.0.27 - Inventory ABC Analysis Report

Run Inventory ABC Analysis Report

@allure.label.epic:InventoryReports
@allure.label.feature:InventoryABCAnalysisReport
@allure.label.story:InventoryABCAnalysisReport
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.27
Scenario: Inventory ABC Analysis Report
      Given I sign as materials controller
	  And I open application Inventory
	  And I select action Run Reports
	  And I filter table Reports:
		| Reports | 
		| Inventory ABC Analysis Report |
	  And I select no. 1 record from Reports table record
	  And I enter Storeroom:
	    | Storeroom | 
		| =BI-VALUE |
	  And I submit Inventory ABC Analysis Report
	  And I wait for page to load
	  And I take screenshot of Inventory ABC Analysis Report test


	   Examples:
      | role |
      | materials controller |

 
	
