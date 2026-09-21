Feature: 0.0.4 - Clean Master - Remove Labour Actuals from Clean Master Work Order

The user needs to remove a Labour actuals from a previously completed work order

@allure.label.epic:CleanMaster
@allure.label.feature:RemoveLabourActualsfromCleanMasterWorkOrder
@allure.label.story:RemoveLabourActualsfromCleanMasterWorkOrder
@allure.label.severity:Trivial
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.4
Scenario: Clean Master - Remove Labour Actuals from Clean Master Work Order
	 Given I sign as maxadmin
     And I open application Clean Master Application (MXR)
      And I filter Work Type field:
		| Work Type| 
		| =CWM |
     And I select no. 1 record from Clean Master table records
     And I remove labor assignments
	 And I save record
     And I take screenshot of Clean Master - Remove Labour Actuals from Clean Master Work Order test
     And I return to Maintainer Start Center

   Examples:
      | role |
      | maxadmin |
