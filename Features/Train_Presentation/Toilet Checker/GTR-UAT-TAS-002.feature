Feature: GTR-UAT-TAS-002 - Change status of a Toilet Asset

As a user you need to indicate the status of a toilet related to a train for planning purposes. 

@allure.label.epic:ToiletChecker
@allure.label.feature:ChangestatusofaToiletAsset
@allure.label.story:ChangestatusofaToiletAsset
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-002
	Scenario: Change status of a Toilet Asset
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 171804 |
	And I select change toilet asset statuse button
	And I Click on the status dropdown
	And I select unavailable
	And I filter table Toilet Unavailable Reason:
      | Toilet Checker |
      | Water Tank Empty |
	And I press button ok
	And I select View Details arrow
	And I verify toilet number
	And I verify toilet description
	And I verify toilet Status
	And I select the Close Details arrow
	And I select change toilet asset statuse button
	And I Click on the status dropdown
	And I select available
	And I press button ok
	And I select View Details arrow
	And I verify toilet number
	And I verify toilet description
	And I verify toilet Status
	And I select the Close Details arrow
	And I take screenshot of Change status of a Toilet Asset
	

	Examples:
      | role |
      | clean master |
	

