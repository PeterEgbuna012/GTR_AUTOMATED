Feature: 0.0.6 - Inter-depot Transfer

A Materials Team Lead is required to transfer material from one depot to another attaching shipment paperwork as appropriate.

@Feature:0.0.6-Inter-depotTransfer
Scenario: Inter-depot Transfer
	   Given I sign as materials depot manager
	   And I open application Inventory Usage from Fav Menu
	   And I select create New Inventory usage
	   And I enter asset description:
		| Asset Description  |
		| Inter-depot Transfer |
	   And I choose Select Value from Detail Menu for Storeroom field
	    And I filter table Storeroom:
		| Storeroom  |
		| SL-Z-VALUE |
       And I select no. 1 record from Storeroom table record
	   And I save record
	   And I select New Row button under the Usage Lines
	   And I set Usage Type field to Transfer
	   And I choose Select Value from Detail Menu for Item field
	   And I filter table Item:
		| Item  |
		| 093/050493 |
       And I select no. 1 record from Item table records
	   And I choose Select Value from Detail Menu for Storeroom field Under Transfer details
	   And I filter Storeroom:
		| Storeroom  |
		| BI-Z-VALUE |
       And I select no. 1 record from Storeroom table records
       And I save record
	   And I select Change status
	   And I select Shipped from dropdown menu option of New Status field
	   And I press the dialog button OK
	   And I open Select Value lookup of Ship To field
	    And I filter Ship To:
		| Ship To  |
		| GTR-BI |
       And I select no. 1 record from Ship To table records
       And I Press OK dialog button
	   And I select action Run Reports
	   And I filter table Shipment Reports:
		| Shipment Reports   | 
		| Shipment Detail Report |
	   And I select no. 1 record from Shipment Reports table record
	   And I Submit Reports
	   And I wait for page to load
	   And I take screenshot of Inter-depot Transfer
	  
	   

	   Examples:
      | role |
      | materials depot manager |
