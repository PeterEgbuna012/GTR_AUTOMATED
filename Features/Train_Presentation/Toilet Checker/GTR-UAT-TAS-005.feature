Feature: GTR-UAT-TAS-005 - Audit Log Updates

As a Toilet checker Team Leader/ FLEETINTERIORS personnel need to verify/ update the status of toilet asset and also check the history.

@allure.label.epic:ToiletChecker
@allure.label.feature:AuditLogUpdates
@allure.label.story:AuditLogUpdates
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-005
Scenario: Audit Log Updates
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 171728 |
	And I select change toilet asset statuse button
	And I Click on the status dropdown
	And I select available
	And I press button ok
	And I verify toilet locked
	And I verify toilet Status
	And I press button View Audit Log
	And I take screenshot of Audit Log Updates
	And I press OK button

	Examples:
      | role |
      | clean master |
