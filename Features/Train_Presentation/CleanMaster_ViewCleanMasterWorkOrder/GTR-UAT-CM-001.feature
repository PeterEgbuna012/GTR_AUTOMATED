Feature: 0.0.1 - Clean Master - View Clean Master Work Orders

The user needs to view all the train presentation related work orders

@allure.label.epic:CleanMaster
@allure.label.feature:ViewCleanMasterWorkOrders
@allure.label.story:ViewCleanMasterWorkOrders
@allure.label.severity:Trivial
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.1
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

