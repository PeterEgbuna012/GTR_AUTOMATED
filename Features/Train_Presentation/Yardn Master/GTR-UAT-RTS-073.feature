Feature: GTR-UAT-RTS-073 Depot View - Verify by engineer

As an engineer / POM, I want to be able to mark a unit that it has been verified by an engineer to understand if the unit is fit for service or needs any additional maintenance work as it is arrived into the yard

@Feature:GTR-UAT-RTS-073DepotView-Verifybyengineer
Scenario: Depot View - Verify by engineer
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | BRIGHTON-YARD |
	And I select no.1 record Yard Asset table records
	And I go to Depot View Tab
	And I take screenshot of Depot View Tab
	And I go to At Location Tab
	And I select a pink background unit on the At Location Tab
	And I select action addUnit Attributes to pink background unit
	And I select Unit Attributes 
	And I select dialog button Continue
	And I take screenshot of Verify by engineer


	Examples:
      | role |
      | Panel Operations Manager |
