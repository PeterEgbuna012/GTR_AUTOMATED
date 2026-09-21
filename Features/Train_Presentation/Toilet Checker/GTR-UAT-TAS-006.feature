Feature: GTR-UAT-TAS-006 - Update status of  locked Toilet Asset

Toilet Checker tries to update a status of a locked asset. 


@allure.label.epic:ToiletChecker
@allure.label.feature:UpdateStatusOfLockedToiletAsset
@allure.label.story:UpdateStatusOfLockedToiletAsset
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-006
Scenario: Update status of  locked Toilet Asset
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377133 |
    And I select no. 1 record from Toilet Checker table records
	And I select View Details arrow
	And I change toilet asset statuse button
	And I Click on the status dropdown
	And I select available
	And I press button ok
	#And I press ok dialog system message button
	And I take screenshot of Update status of  locked Toilet Asset Test



	Examples:
      | role |
      | clean master |
	
