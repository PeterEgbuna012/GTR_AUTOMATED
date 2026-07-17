Feature: 0.0.1 - Clean Master - View Clean Master Work Orders

The user needs to view all the train presentation related work orders

@Feature:0.0.1-CleanMaster-ViewCleanMasterWorkOrders
Scenario: Clean Master - View Clean Master Work Orders
  Given I sign as <role>
  And I open application Clean Master Application (MXR)
  And I filter table All Unit:
		| All 377 Unit | 
		| SANITISATION |
  And I view work order details
  And I verify work order number
  And I take screenshot of Clean Master - View Clean Master Work Orders test
  And I close work order details 

  Examples:
      | role |
      | clean master |

