Feature: 0.0.8 - Incompetent Labour Reports

The Maintainer Team Leader wants to run a Incompetent Labour report.

@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:IncompetentLabourReports
@allure.label.story:IncompetentLabourReports
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.8
Scenario: Incompetent Labour Reports
      Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I select action Run Reports
	  And I filter Report table:
		| Report | 
		| Incompetent Labour Report |
	  And I select no. 1 record from Reports table records
	  And I enter Work Type Category:
		| Work Type | 
		| =PM       |
	  And I enter Start and End Date:
		| Start Date | End Date |
		| 01/01/2026 | 01/08/2026 |
	  And I submit incompetent labour report
	  And I wait for page to load
	  And I take screenshot of Incompetent Labour Reports


	   Examples:
      | role |
      | maintainer team leader |

	
