Feature: GTR-UAT-RTS-005 Depot View Tab - Add Attributes to the Road

As a Panel Operations Manager, you want to associate an attribute to the road i.e., energised, low speed

@Feature:GTR-UAT-RTS-005DepotViewTab-AddAttributestotheRoad
Scenario: Add Attributes to the Road
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
       | LOWSPEED |
	And I select no.1 record Attribute table records
	And I click OK dialog button of Attribute dropdown list
	And I take screenshot of Low Speed Attribute
	And I select Blocked road
	And I Delete Road Attribute
	And I click OK dialog button of Attribute dropdown list
	And I take screenshot of Deleted Low Speed Attribute


	Examples:
      | role |
      | Panel Operations Manager |
