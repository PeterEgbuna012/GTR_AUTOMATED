Feature: 0.0.7 - Frequency Based PM Overview


The Maintainer Team Leader wants to run a Frequency Based PM Overview report.

@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:FrequencyBasedPMOverview
@allure.label.story:FrequencyBasedPMOverview
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.7
Scenario: Frequency Based PM Overview
      Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I select action Run Reports
	  And I filter Report table:
		| Report | 
		| Day Count Based PM Overview Report |
	  And I select no. 1 record from Reports table records
	  And I enter Work Type:
	   	|  Work Type | 
	    | =A2 |
	  And I submit Frequency Based PM Overview report
	  And I wait for page to load
	  And I take screenshot of Frequency Based PM Overview Report


	   Examples:
      | role |
      | maintainer team leader |


	
