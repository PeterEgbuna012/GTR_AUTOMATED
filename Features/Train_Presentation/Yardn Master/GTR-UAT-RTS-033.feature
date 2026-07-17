Feature: GTR-UAT-RTS-033 Depot View Tab - Verifying a Unit After its Arrival

As an Engineer, I want to verify a unit after it has arrived at the depot so that the POMs know which units are ready to go back into service.

@Feature:GTR-UAT-RTS-033DepotViewTab-VerifyingaUnitAfteritsArrival
Scenario: Verifying a Unit After its Arrival
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | BRIGHTON-YARD |
	And I select no.1 record Yard Asset table records
	And I go to Depot View Tab
	And I select Unit on Roads
	And I Add Unit Attributes
	And I select Unit Attributes 
	And I select dialog button Continue
	And I take screenshot of verified unit

	Examples:
      | role |
      | Panel Operations Manager |