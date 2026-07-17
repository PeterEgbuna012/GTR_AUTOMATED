Feature: 0.0.25 - FOS Report

Run FOS report

@Feature:0.0.25-FOSReport
Scenario: FOS Report
      Given I sign as stores
	  And I open application Inventory
	  And I select action Run Reports
	  And I filter table Reports:
		| Reports | 
		| FOS Report |
	  And I select no. 1 record from Reports table record
	  And I enter Item number:
		| Item Number | 
		| =007/042021 |
	  And I submit FOS Report
	  And I wait for page to load
	  And I take screenshot of FOS Report test


	   Examples:
      | role |
      | stores |
	
