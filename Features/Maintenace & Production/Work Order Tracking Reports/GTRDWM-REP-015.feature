Feature: 0.0.15 - Repeat Failure

The Maintainer Team Leader wants to run a Repeat Failure report.

@Feature:0.0.15-RepeatFailure
Scenario: Repeat Failure
      Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I select action Run Reports
	  And I filter Report table:
		| Report | 
		| Repeat Failure Report |
	  And I select no. 1 record from Reports table records
	  And I enter Target Date:
		| Target Date | 
		| 01/01/2025 |
      And I enter repeat failure report details:
		|  Period Count | Location Class |
		| 1 | =1001,=1002,=1006,=1007 | 
	  And I submit Failure Report
	  And I wait for page to load
	  And I take screenshot of Repeat Failure Report


	   Examples:
      | role |
      | maintainer team leader |

     

	
