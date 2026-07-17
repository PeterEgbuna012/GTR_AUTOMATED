Feature: 0.0.2 - Complete a Sand Master Work Order

The user needs to complete the sanding work order and Fill individual sandboxes. 

@Feature:0.0.2-CompleteaSandMasterWorkOrder
Scenario: Complete a Sand Master Work Order
	Given I sign as <role>
    #And I open application Sand Master (MXR) from Fav Menu
    And I open application Sand Master (MXR)
    And I filter table Sand Master (MXR):
		| ID | 
		| 171 |
    And I select button Fill Sand Box
    And I press the ok dialog button
    And I select Check Sand Box
    And I verify SandBox level
    And I take screenshot of Complete a Sand Master Work Order test

	 Examples:
      | role |
      | sand master |
