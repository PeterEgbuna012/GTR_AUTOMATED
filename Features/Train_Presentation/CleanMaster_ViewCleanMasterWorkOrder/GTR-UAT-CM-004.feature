Feature: 0.0.4 - Clean Master - Remove Labour Actuals from Clean Master Work Order

The user needs to remove a Labour actuals from a previously completed work order

@Feature:0.0.4-CleanMaster-RemoveLabourActualsfromCleanMasterWorkOrder
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
