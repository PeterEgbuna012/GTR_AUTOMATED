Feature: 0.0.4 - Fleet PM Overview Report

The Maintainer Team Leader wants to run a Fleet PM Overview Report.

@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:FleetPMOverviewReport
@allure.label.story:FleetPMOverviewReport
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.4
Scenario: Fleet PM Overview Report
      Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I select action Run Reports
	  And I filter Report table:
		| Report | 
		| Fleet PM Overview Report |
	  And I select no. 1 record from Reports table records
	  And I enter class of vehicle:
		| Class Of Vehicle | 
		| 171 |
	  And I submit fleet PM overview report
	  And I wait for page to load
	  And I take screenshot of Fleet PM Overview Report

	   Examples:
      | role |
      | maintainer team leader |
	
