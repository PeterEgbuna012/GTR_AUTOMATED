Feature: GTR-UAT-RTS-001 Depot View Tab - Adding and Removing a Gap on a Road

As a Panel Operations Manager, I want to add a gap to the road

@Feature:GTR-UAT-RTS-001DepotViewTab-AddingandRemovingaGaponaRoad
Scenario: Adding a Gap to the Road
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | LITTLEHAMPTON-YARD |
	And I select no.1 record Yard Asset table records
	And I select no.1 Gap on Road Block diagram
	And I add Gap to the Road
	And I enter Gap Details:
		| Gap Memo | Poistion |
		| TESTING     | 1 |
	And I select ok dialog button
   	And I take screenshot of Gap added to the Road
	And I View Gap details
	And I take screenshot of viewed Gap details one
	And I click OK dialog button
	And I Delete Gap
	And I take screenshot of Deleted Gap

	Examples:
      | role |
      | Panel Operations Manager |