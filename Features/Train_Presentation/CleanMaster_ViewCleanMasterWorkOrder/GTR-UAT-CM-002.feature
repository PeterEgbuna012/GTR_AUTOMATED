Feature: 0.0.2 - Clean Master - Complete a Clean Master Work Order

The user needs to complete a train presentation related work order

@Feature:0.0.2-CleanMaster-CompleteaCleanMasterWorkOrder
Scenario: Clean Master - Complete a Clean Master Work Order
   Given I sign as clean master
  And I open application Clean Master Application (MXR)
  And I filter table clean master:
		| Clean Master | Description   |
		| 171201       |               |
  And I complete clean master task
  And I recomplete clean master task
  And I press dialog Ok  button
  And I confirm task completion
  And I take screenshot of Clean Master - Complete a Clean Master Work Order test


  Examples:
      | role |
      | clean master |
