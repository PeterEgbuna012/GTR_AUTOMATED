Feature: GTR-UAT-RTS-074 Depot View - Managing Placeholders

As a POM i arrive trains into the depot. The arriving trains may be a consist that has been created in line with the information that is in TRENT. In certain situations TRENT may include 

@Feature:GTR-UAT-RTS-074DepotView-ManagingPlaceholders
Scenario: Depot View - Managing Placeholders
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | BATTERSEA-STWRT-YARD |
	And I select no.1 record Yard Asset table records
	And I go to Depot View Tab
	And I take screenshot of Depot View Tab
	And I go to At Location Tab
	And I select a pink background unit on the At Location Tab
	And I select action addUnit Attributes to pink background unit
	And I select Unit Attributes 
	And I select dialog button Continue
	And I take screenshot of Managing Placeholders


	Examples:
      | role |
      | Panel Operations Manager |
