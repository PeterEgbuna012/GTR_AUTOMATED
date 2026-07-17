Feature: 0.0.5 - Internal Transfers

As a store person you need to transfer items between bins in the same storeroom.

@Feature:0.0.5-InternalTransfers
Scenario:   Internal Transfers
       Given I sign as stores person hornsey
       And I open application Inventory Usage from Fav Menu
	   And I select create New Inventory usage
	    And I enter asset description:
		| Asset Description  |
		| Internal Transfers |
	    And I choose Select Value from Detail Menu for Storeroom field
	    And I filter table Storeroom:
		| Storeroom  |
		| BI-VALUE |
       And I select no. 1 record from Storeroom table record
	   And I select New Row button under the Usage Lines
	   And I set Usage Type field to Transfer
	   And I choose Select Value from Detail Menu for Item field
	   And I filter table Item:
		| Item  |
		| 007/021837 |
       And I select no. 1 record from Item table records
	   And I choose Select Value from Detail Menu for Storeroom field Under Transfer details
	   And I filter Storeroom:
		| Storeroom  |
		| SU-VALUE |
       And I select no. 1 record from Storeroom table records
       And I save record
	   And I select Change status 
	   And I select Complete from dropdown menu option of New Status field
	   And I press the dialog button OK
	   And I verify status changed to COMPLETE
	   And I return to Maintainer Start Center
	   And I open application Inventory from Fav Menu
	   And I filter Inventory:
		| Inventory  |
		| 007/021837 |
       And I select no. 1 record from Inventory table records
	   And I verify inventory balance
	   And I take screenshot of Internal Transfers test
	   And I return to Maintainer Start Center


	    Examples:
      | role  |
      | stores person hornsey |

	   
