Feature: 0.0.16 - Staff Productivity


The Maintainer Team Leader wants to run a Staff Productivity report.

@Feature:0.0.16-StaffProductivity
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
		| 01/01/2024 | 01/08/2024 |
	  And I submit Staff Productivity Report
	  And I wait for page to load
	  And I take screenshot of Staff Productivity Report


	   Examples:
      | role |
      | maintainer team leader |
	
