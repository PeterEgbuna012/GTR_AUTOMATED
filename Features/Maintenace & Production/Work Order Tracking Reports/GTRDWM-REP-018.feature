Feature: 0.0.18 - Unit Mileage & Last Service Date


The Maintainer Team Leader wants to run a Unit Mileage & Last Service Date report.

@Feature:0.0.18-UnitMileage&LastServiceDate
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


