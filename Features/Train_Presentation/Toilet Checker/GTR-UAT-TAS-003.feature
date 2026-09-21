Feature: GTR-UAT-TAS-003 - Lock/ Unlock a Toilet Asset

As a FLEETINTERIORS personnel you need to Lock a toilet asset to ensure compliance and planning.

@allure.label.epic:ToiletChecker
@allure.label.feature:ChangestatusofaToiletAsset
@allure.label.story:ChangestatusofaToiletAsset
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-003
@allure.label.suite.scenario01.ChangestatusofaToiletAsset
	Scenario: 01) Change status of a Toilet Asset
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377103 |
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
	And I take screenshot of Change status of a Toilet Asset
	

	Examples:
      | role |
      | clean master |



@allure.label.epic:ToiletChecker
@allure.label.feature:Lock/UnlockaToiletAsset
@allure.label.story:Lock/UnlockaToiletAsset
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-003
@allure.label.suite.scenario02.Lock/UnlockaToiletAsset
Scenario: 02) Lock/ Unlock a Toilet Asset
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377103 |
	And I select View Details arrow
	And I press button Lock/Unlock a Toilet Asset
	And I enter following Toilet Checker data:
      | Comment |
      | Lock/Unlock a Toilet Asset Test |
	And I press ok button
	And I verify toilet locked
	And I verify toilet Status
	And I take screenshot of toilet Status Unlock
	And I press button Lock/Unlock a Toilet Asset
	And I press dialog button no
	And I enter following Toilet Checker data:
      | Comment |
      | Lock/Unlock a Toilet Asset Test Update |
	And I press ok button
	And I select View Details arrow
	And I press button Lock/Unlock a Toilet Asset
	And I press dialog button yes
	And I take screenshot of Lock/ Unlock a Toilet Asset Test




	Examples:
      | role |
      | clean master |




@allure.label.epic:ToiletChecker
@allure.label.feature:ChangestatusofaToiletAsset
@allure.label.story:ChangestatusofaToiletAsset
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-003
@allure.label.suite.scenario03.ChangestatusofaToiletAsset
	Scenario: 03) Change status of a Toilet Asset
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377103 |
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