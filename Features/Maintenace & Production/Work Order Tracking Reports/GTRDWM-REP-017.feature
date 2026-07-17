Feature: 0.0.17 - Total time per exam/block/task

The Maintainer Team Leader wants to run a Total time per exam/block/task report.

@Feature:0.0.17-Totaltimeperexam/block/task
Scenario: Total time per exam/block/task
      Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I select action Run Reports
	  And I filter Report table:
		| Report | 
		| Total Time per Task/Block/Exam |
	  And I select no. 1 record from Reports table records
	  And I enter Report Start Date and End Date:
		| Start Date | End Date |
		| 01/01/2024 | 01/08/2024 |
	  And I submit Total Time per Task Block Exam Report
	  And I wait for page to load
	  And I take screenshot of Total time per exam block task Report


	   Examples:
      | role |
      | maintainer team leader |

	
