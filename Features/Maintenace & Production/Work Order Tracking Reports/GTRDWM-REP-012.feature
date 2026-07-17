Feature: 0.0.12 - New WO vs Close WO over time

The Maintainer Team Leader wants to run a New WO vs Close WO over time report.

@Feature:0.0.12-NewWOvsCloseWOovertime
Scenario: New WO vs Close WO over time
      Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I select action Run Reports
	  And I filter Report table:
		| Report | 
		| New WO vs Close WO over time |
	  And I select no. 1 record from Reports table records
	  And I set report Start and End Date:
		| Start Date | End Date |
		| 01/01/2024 | 01/08/2024 |
		And I enter report details:
		| Work Type | Location |
		| =EM | =HORNSEY |
	  And I submit new WO vs close WO over time report
	  And I wait for page to load
	  And I take screenshot of New WO vs Close WO over time Report


	   Examples:
      | role |
      | maintainer team leader |
	
