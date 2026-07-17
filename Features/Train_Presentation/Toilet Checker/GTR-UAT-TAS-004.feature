Feature: GTR-UAT-TAS-004 - Check audit logs

As a Planner you need to check the user logs of a toilet asset status change.

@Feature:GTR-UAT-TAS-004Checkauditlogs
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

