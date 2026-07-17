Feature: 0.0.4 - Returning Items

A storeperson is required to return items that have previously been issued

@Feature:0.0.4-ReturningItems
Scenario: Returning Items
	   Given I sign as stores
	   And I open application Inventory Usage from Fav Menu
	   And I select create New Inventory usage
	   And I enter asset description:
		| Asset Description  |
		| Returning Items |
	    And I choose Select Value from Detail Menu for Storeroom field
	    And I filter table Storeroom:
		| Storeroom  |
		| SL-Z-VALUE |
       And I select no. 1 record from Storeroom table record
	   And I save record
	   And I select Items for Return button
	   And I filter table Items for Return:
		| Items  |
		| 093/050493|
       And I select no. 1 record from Items for Return table records
	   And I press OK
	   And I save record
	   And I select Change status 
	   And I select Complete from dropdown menu option of New Status field
	   And I press the dialog button OK
	   And I verify status changed to COMPLETE
	   And I take screenshot of complete status
	   And I open application Work Order Tracking (BRDA)
	   And I filter table CM:
		| Description | Status | Work Type |
		| Issue Rotating Assets to a Work Order | =COMP-WREV | =EM |
	   And I select no. 1 record from CM Work Order table records
	   And I go to actuals Tab
       And I go to materials Tab
	   And I verify issued materials
	   And I take screenshot of Returning Items test

	   Examples:
      | role  |
      | stores |
