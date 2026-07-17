Feature: 0.0.22 - Work Bank Size Report

The Maintainer Team Leader wants to run a Work Bank Size Summary report.

@Feature:0.0.22-WorkBankSizeReport
Scenario: Work Bank Size Report
      Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	   And I select action Run Reports
	   And I filter Report table:
		| Report | 
		| Work Bank Size Summary Report |
	  And I select no. 1 record from Reports table records
	  And I enter Work Bank Size Report Details:
		| Owner Group | Repair Facility | Work Type |
		| =RS | =HORNSEY | =CM |
	  And I submit Work Bank Size Summary Report
	  And I wait for page to load
	  And I take screenshot of Work Bank Size Report


	   Examples:
      | role |
      | maintainer team leader |



	
	
