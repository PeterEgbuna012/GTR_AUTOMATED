Feature: GTR-UAT-RTS-004 Depot View Tab - Block an Entire Road in Depot

As a Panel Operations Manager, I want to block a road in the yard.

@Feature:GTR-UAT-RTS-004DepotViewTab-BlockanEntireRoadinDepot
Scenario: Block an Entire Road in Depot
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | BRIGHTON-YARD |
	And I select no.1 record Yard Asset table records
	And I select no.1 Road
	And I Add Road Attribute
	And I select New Row button under Fleet Availability Attributes
	And I select Value lookup of Attribute field
	And I filter Attributes:
       | Attributes |
       | BLOCKED |
	And I select no.1 record Attribute table records
	And I click OK dialog button of Attribute dropdown list
	And I take screenshot of Blocked Road added to the Road
	And I select Blocked road
	And I Delete Road Attribute
	And I click OK dialog button of Attribute dropdown list
	And I take screenshot of Deleted Blocked Road


	Examples:
      | role |
      | Panel Operations Manager |

