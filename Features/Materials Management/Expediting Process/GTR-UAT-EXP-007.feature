Feature: 0.0.7 - View POs to Expedite

The user needs to view a list of POs that are overdue 


@Feature:0.0.7-ViewPOstoExpedite
Scenario: View POs to Expedite
	Given I sign as materials depot manager
	And I go to Materials Depot manager's start centre
	And I filter Portlet table POs to Expedite:
      |  POs to Expedite |
      | SR111638 |
    And I select no. 1 record from  POs to Expedite Portlet table record
	And I take screenshot of View POs to Expedite Test
	
	Examples:
      | role |
      | materials depot manager |
