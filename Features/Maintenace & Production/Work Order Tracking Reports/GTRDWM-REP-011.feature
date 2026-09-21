Feature: 0.0.11 - Mobile Work Order Completion Summary Report


The Maintainer Team Leader wants to run a Frequency Based Maintenance Plan report.


@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:MobileWorkOrderCompletionSummaryReport
@allure.label.story:MobileWorkOrderCompletionSummaryReport
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.11
Scenario: Mobile Work Order Completion Summary Report
      Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I select action Run Reports
	  And I filter Report table:
		| Report | 
		| Mobile Work Order Completion Summary Report |
	  And I select no. 1 record from Reports table records
	  And I set Start and End Date:
		| Start Date | End Date |
		| 01/01/2026 | 01/08/2026 |
	  And I submit mobile work order completion summary report
	  And I wait for page to load
	  And I take screenshot of Mobile Work Order Completion Summary Report


	   Examples:
      | role |
      | maintainer team leader |

	
