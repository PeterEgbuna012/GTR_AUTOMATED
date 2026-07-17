Feature: 0.0.29 - Inventory Balance Report

Run Inventory Balance Report

@Feature:0.0.29-InventoryBalanceReport
Scenario: Inventory Balance Report
      Given I sign as materials controller
	  And I open application Inventory
	  And I select action Run Reports
	  And I filter table Reports:
		| Reports | 
		| Inventory Balance Report |
	  And I select no. 1 record from Reports table record
	  And I enter Inventory Balance Report Storeroom:
	    | Storeroom | 
		| =HE-VALUE |
	  And I submit Inventory Balance Report
	  And I wait for page to load
	  And I take screenshot of Inventory Balance Report


	   Examples:
      | role |
      | materials controller |
	
