Feature: 0.0.3 - Viewing a sanding log 

The user needs to view a sanding log 

@Feature:0.0.3-Viewingasandinglog 
Scenario: Viewing a sanding log 
	Given I sign as <role> 
    #And I open application Sand Master (MXR) from Fav Menu
    And I open application Sand Master (MXR)
    And I select View Sanding Log
    And I select value option Unit ID field
     And I filter table Unit ID:
		| ID | 
		| 171 |
    And I select no. 1 record from Unit ID table records
    And I select Refresh button
    And I verify Unit ID changed
    And I take screenshot of Viewing a sanding log
    And I press dialog ok
    And I return to Maintainer Start Center

	Examples:
      | role |
      | sand master |
