Feature: 0.0.1 - Work Order Details Report


The Maintainer Team Leader wants to run a Work Order Details report.

@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:WorkOrderDetailsReport
@allure.label.story:WorkOrderDetailsReport
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.1
Scenario: Work Order Details Report
      Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I filter table CM Work Order:
        | Description | Status  |
        | CM WO AUTO TEST | =WAIT-REV |
      #And I wait for Report page to load
	  And I select action Run Reports
	  And I filter Report table:
		| Report | 
		| Work Order Details Report |
	  And I select no. 1 record from Reports table records
	  And I set (Radio) field to "Immediate"
      And I submit Work Order Details Report
	  And I wait for page to load
	  And I take screenshot of Work Order Details Report

	  Examples:
      | role |
      | maintainer team leader |
	
