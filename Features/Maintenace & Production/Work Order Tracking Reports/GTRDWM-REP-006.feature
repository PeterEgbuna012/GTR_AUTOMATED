Feature: 0.0.6 - Frequency Based Maintenance Plan

The Maintainer Team Leader wants to run a Frequency Based PM Maintenance Plan report.

@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:FrequencyBasedMaintenancePlan
@allure.label.story:FrequencyBasedMaintenancePlan
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.6
Scenario: Frequency Based Maintenance Plan
      Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I select action Run Reports
	  And I filter Report table:
		| Report | 
		| 717 Frequency Based Maintenance Plan |
	  And I select no. 1 record from Reports table records
	  And I enter Next Work Type:
	   	| Next Work Type | 
	    | ==A1,=A2 |
	  And I submit frequency based maintenance plan report
	  And I wait for page to load
	  And I take screenshot of Frequency Based Maintenance Plan Report


	   Examples:
      | role |
      | maintainer team leader |
	
