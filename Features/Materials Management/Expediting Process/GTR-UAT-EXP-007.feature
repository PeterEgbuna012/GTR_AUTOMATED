Feature: 0.0.7 - View POs to Expedite

The user needs to view a list of POs that are overdue 

@allure.label.epic:ExpeditingProcess
@allure.label.feature:ViewPOstoExpedite
@allure.label.story:ViewPOstoExpedite
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.7
Scenario: View POs to Expedite
	Given I sign as <role>
	And I go to Materials Depot manager's start centre
	And I filter Portlet table POs to Expedite:
      |  POs to Expedite |
      | SR117805 |
    And I select no. 1 record from  POs to Expedite Portlet table record
	And I take screenshot of View POs to Expedite Test
	
	Examples:
      | role |
      | materials depot manager |
