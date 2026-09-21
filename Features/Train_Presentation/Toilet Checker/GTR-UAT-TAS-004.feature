Feature: GTR-UAT-TAS-004 - Check audit logs

As a Planner you need to check the user logs of a toilet asset status change.

@allure.label.epic:ToiletChecker
@allure.label.feature:Checkauditlogs
@allure.label.story:Checkauditlogs
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-004
Scenario: Check audit logs
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 171728 |
	And I press button View Audit Log
	And I take screenshot of Audit Log
	And I press OK button

	Examples:
      | role |
      | clean master |

