Feature: 0.0.1 - View Sand Master Units and Sandboxes

The user needs to view all the train presentation-related work orders

@Feature:0.0.1-ViewSandMasterUnitsandSandboxes
Scenario: View Sand Master Units and Sandboxes
	Given I sign as <role>
    #And I open application Sand Master (MXR) from Fav Menu
	And I open application Sand Master (MXR)
	And I select unit 387 query
	And I view Sand Master Work Order details
	And I verify sand master Work Order details
	And I take screenshot of View Sand Master Units and Sandboxes test
	And I return to Maintainer Start Center

	 Examples:
      | role |
      | sand master |
