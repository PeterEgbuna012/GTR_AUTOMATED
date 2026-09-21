Feature: GTR-UAT-TAS-013 - Toilet Checker - 'Needs Checking' Flag

Units Details should be available in the "Toilet Checker(MXR)" Application.
@allure.label.epic:ToiletChecker
@allure.label.feature:ToiletChecker-'NeedsChecking'Flag
@allure.label.story:ToiletChecker-'NeedsChecking'Flag
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-013
@allure.label.suite.scenario01.ToiletChecker-'NeedsChecking'Flag
Scenario: 01) Toilet Checker - 'Needs Checking' Flag
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377119 |
    And I select View Details arrow
	And I take screenshot of Toilet Checker Asset Details
	And I set (Radio) field to needs Checking to true
	And I save record
	And I verify toilet needs checking flag is set to true
	And I take screenshot of Toilet Checker Asset Details with Needs Checking Flag
	And I select button to change toilet asset status
	And I Click on the status dropdown
	And I select unavailable
	And I filter table Toilet Unavailable Reason:
      | Toilet Checker |
      | Water Tank Empty |
	And I take screenshot of Status Change to Unavailable
	And I press button ok
	And I select View Details arrow
	And I verify toilet needs checking flag is set to false
	And I take screenshot of Toilet Checker Asset Details with Needs Checking Flag set to false


	
	Examples:
      | role |
      | maxadmin |




@allure.label.epic:ToiletChecker
@allure.label.feature:ChangestatusofaToiletAsset
@allure.label.story:ChangestatusofaToiletAsset
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-013
@allure.label.suite.scenario02.ChangestatusofaToiletAsset
	Scenario: 02) Change status of a Toilet Asset
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377119 |
	And I select View Details arrow
	And I select button to change toilet asset status
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
      | maxadmin |