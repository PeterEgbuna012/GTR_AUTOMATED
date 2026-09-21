Feature: 0.0.18 - Unit Mileage & Last Service Date


The Maintainer Team Leader wants to run a Unit Mileage & Last Service Date report.

@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:UnitMileage&LastServiceDate
@allure.label.story:UnitMileage&LastServiceDate
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.18
Scenario: Unit Mileage & Last Service Date
      Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I select action Run Reports
	  And I filter Report table:
		| Report | 
		| Unit Mileage & Last Service Date |
	  And I select no. 1 record from Reports table records
	  And I enter report class:
		| Class | 
		| =171   |
	  And I submit Unit Mileage & Last Service Date Report
	  And I wait for page to load
	  And I take screenshot of Unit Mileage & Last Service Date Report


	   Examples:
      | role |
      | maintainer team leader |


