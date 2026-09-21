Feature: 0.0.16 - Staff Productivity


The Maintainer Team Leader wants to run a Staff Productivity report.

@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:StaffProductivity
@allure.label.story:StaffProductivity
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.16
Scenario: Staff Productivity
      Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I select action Run Reports
	  And I filter Report table:
		| Report | 
		| Staff Productivity Report |
	  And I select no. 1 record from Reports table records
	  And I enter Start Date and End Date:
		| Start Date | End Date |
		| 01/01/2026 | 01/08/2026 |
	  And I submit Staff Productivity Report
	  And I wait for page to load
	  And I take screenshot of Staff Productivity Report


	   Examples:
      | role |
      | maintainer team leader |
	
