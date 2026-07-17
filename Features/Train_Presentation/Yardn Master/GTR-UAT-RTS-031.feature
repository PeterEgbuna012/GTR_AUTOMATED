Feature: GTR-UAT-RTS-031 At Location Tab - View Units in the Yard

As a Panel Operations Manager, I want to view the units in the yard (Other than depot view) 

@Feature:GTR-UAT-RTS-031AtLocationTab-ViewUnitsintheYard
Scenario: At Location Tab - View Units in the Yard
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | THREE-BRIDGES-YARD |
	And I select no.1 record Service Management table records
	And I go to At Location Tab
	And I take screenshot of View Units in the Yard test scenario
	
   Examples:
      | role |
      | Panel Operations Manager |
