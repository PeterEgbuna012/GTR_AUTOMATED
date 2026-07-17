Feature: 0.0.1 - Navigate in the Inventory and Item Master Applications

Navigate the Inventory and Item Master applications as a store person.

@Feature:0.0.1-NavigateintheInventoryandItemMasterApplications
Scenario: Navigate in the Inventory and Item Master Applications
	Given I sign as stores person
	And I open application Item Master from Fav Menu
	And I filter table Item Master:
		| Item Master   |
		| 387/ | 
    And I open Select Value lookup for Repairable item field
	And I select Y from table record
	And I select no. 1 record from Item Master table record
	And I review Item information
	And I go to tab Specifications
	And I select Specifications table filter option
	And I open Select Value lookup for Attribute field
	And I filter table Attribute:
		| Attribute  |
		| 387/1 |
    And I select no. 1 record from Attribute table record
    And I Press OK button
	And I return to Maintainer Start Center
	And I open application Inventory Fav Menu
	And I filter Inventory table:
		| storeroom  |
		| HE-Z-VALUE |
    And I select no. 1 record from Inventory table record
	And I verify Inventory Balances
	And I go to Reorder Details tab
	And I verify Primary Vendor details
	And I take screenshot of Navigate in the Inventory and Item Master Applications test
    And I return to Maintainer Start Center

	Examples:
      | role  |
      | stores person |

