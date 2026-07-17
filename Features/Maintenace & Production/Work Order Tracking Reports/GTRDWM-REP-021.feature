Feature: 0.0.21 - Work Arising Report

The Maintainer Team Leader wants to run a Work Arising report.

@Feature:0.0.21-WorkArisingReport
Scenario: Work Arising Report
	  Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I select action Run Reports
	   And I filter Report table:
		| Report | 
		| Work Arising |
	  And I select no. 1 record from Reports table records
	  And I submit Work Arising Report
	  And I wait for page to load
	  And I take screenshot of Work Arising Report


	   Examples:
      | role |
      | maintainer team leader |
