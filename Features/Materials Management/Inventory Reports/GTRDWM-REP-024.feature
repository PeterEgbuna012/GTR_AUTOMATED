Feature: 0.0.24 - First time Pickrate Report

Run First time Pickrate Report

@Feature:0.0.24-FirsttimePickrateReport
Scenario: First time Pickrate Report
      Given I sign as stores
	  And I open application Inventory
	  And I select action Run Reports
	  And I filter table Reports:
		| Reports | 
		| Firsttime Pickrate Report|
	  And I select no. 1 record from Reports table record
	  And I select start date and end date
	  And I submit First time Pickrate Report
	  And I wait for page to load
	  And I take screenshot of First time Pickrate Report test


	   Examples:
      | role |
      | stores |

