Feature: 0.0.20 - Work Order List Report


The Maintainer Team Leader wants to run a Work Order List Report.

@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:WorkOrderListReport
@allure.label.story:WorkOrderListReport
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.20
Scenario: Work Order List Report
      Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I filter table Work Order:
		| Work Type | Status | Repair Facility |
		| =EM | =SCHEDULED | =BATTERSEA-STWRT-LN |
       And I select action Run Reports
	   And I filter Report table:
		| Report | 
		| Work Order List Report |
	  And I select no. 1 record from Reports table records
	  And I set (Radio) field to "Immediate"
	  And I submit Work Order List Report
	  And I wait for page to load
	  And I take screenshot of Work Order List Report


	   Examples:
      | role |
      | maintainer team leader |
	
