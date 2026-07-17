Feature: GTR-UAT-RTS-006 Depot View Tab - Add comments to a road

As a Panel Operations Manager, I want to add & remove comments on roads. So that workers can read any comments or instructions they need to know about what is happening on a road

@Feature:GTR-UAT-RTS-006DepotViewTab-Addcommentstoaroad
Scenario: Add comments to a road
	Given I sign as Panel Operations Manager
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | SELHURST-YARD |
	And I select no.1 record Yard Asset table records
	And I select no.1 Road
	And I Add Road Comment
	And I enter Comment:
       | Comment |
       | COMMENT TESTING |
	And I click OK dialog button of Add Comment dialog
	And I take screenshot of Added Comment
	And I Modify Road Comment
	And I Modify Comment:
       | Comment |
       | COMMENT TESTING UPDATED |
    And I click OK dialog button of Modify Comment dialog
	And I remove Road Comment
	And I take screenshot of Deleted Comment
	

	Examples:
      | role |
      | Panel Operations Manager |
