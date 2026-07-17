Feature: GTR-UAT-RTS-034 Depot View Tab - Add Block to a Unit

As a FAM user, I want to add a block to a unit, so that no action can be taken on that unit until the block is removed. 

@Feature:GTR-UAT-RTS-034DepotViewTab-AddBlocktoaUnit
Scenario: Depot View Tab - Add Block to a Unit
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | BRIGHTON-YARD |
	And I select no.1 record Yard Asset table records
	And I go to Depot View Tab
	And I select Unit on Roads
	And I Add a block to a unit
	And I take screenshot of blocked unit
	And I remove block from a unit
	And I take screenshot of unblocked unit


	Examples:
      | role |
      | Panel Operations Manager |

