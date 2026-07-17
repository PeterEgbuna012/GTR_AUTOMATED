Feature: 0.0.26 - Historic Stock Value Report

Run Historic Stock Value Report

@Feature:0.0.26-HistoricStockValueReport
Scenario: Historic Stock Value Report
     Given I sign as stores
	  And I open application Inventory
	  And I select action Run Reports
	   And I filter table Reports:
		| Reports | 
		| Historic Stock Value Report |
	  And I select no. 1 record from Reports table record
	  And I set start date and end date
	  And I filter table Historic Stock Report Storeroom:
		| Storeroom | 
		| =HE-VALUE |
      #And I select no. 1 record from storeroom table record
	  And I submit Historic Stock Value Report
	  And I wait for page to load
	  And I take screenshot of Historic Stock Value Report test


	   Examples:
      | role |
      | stores |
	
