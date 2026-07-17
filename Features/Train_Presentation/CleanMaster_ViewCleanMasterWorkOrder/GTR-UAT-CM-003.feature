Feature: 0.0.3 - Clean Master - Automatically Close a Clean Master Work Order


The user needs to regenerate a Clean Master work order

After a set amount of time has passed the Clean Master work order will auto-close and regenerate a new work order in its place

@Feature:0.0.3-CleanMaster-AutomaticallyCloseaCleanMasterWorkOrder
Scenario: Clean Master - Automatically Close a Clean Master Work Order
  Given I sign as clean master
  And I filter Application Search field:
      | Application |
      | Escalations |
  And I select no. 1 record from Search field table records
  And I filter table Escalations:
      | Escalations |
      | MXRCLWOREGEN |
  And I select no. 1 record from Escalations table records
  And I set escalations active
  And I enter Escalations time:
		| Time | 
		| 2 |
  And I click ok dailog button
  And I set escalations active
  And I return to Maintainer Start Center
  And I open application Clean Master Application (MXR)
  And I filter table clean master:
		| Clean Master | Description                            |
		|              | Clean Master - Work Order regeneration |
  And I return to Maintainer Start Center
  And I open application Work Order Tracking (BRDA)
  And I filter table Work Order Tracking (BRDA):
      | Description |
      | Clean Master - Work Order regeneration |
  And I take screenshot of Clean Master - Automatically Close a Clean Master Work Order test


  Examples:
      | role |
      | clean master |

	