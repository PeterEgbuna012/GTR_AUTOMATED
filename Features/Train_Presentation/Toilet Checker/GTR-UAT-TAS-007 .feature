Feature: GTR-UAT-TAS-007 - Toilet Asset Setup

As a planner you need to view all the train toilet type related for work and status

# Setup scenario
@allure.label.epic:ToiletChecker
@allure.label.feature:ToiletAssetSetup
@allure.label.story:ToiletAssetSetup
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-007
@allure.label.suite.scenario01.ToiletAssetSetup
Scenario: 01) Toilet Asset Setup
	Given I sign as <role>
	And I open application Assets(Tr) 
	And I filter table Assets:
      | Asset |
      | TOILET-S-00098 |
	And I select no. 1 record from Assets table records
	And I go to Tab Specifications
	And I add new record in Specifications section
	And I open Select Value lookup for attribute field
	And I select no. 1 record from attribute table records
	And I open Select Value lookup for alphanumeric value field
	And I select no. 2 record from alphanumeric value table records
	And I save record
	And I take screenshot of Update status of Toilet Asset Setup Test

	Examples:
      | role |
      | clean master |



@allure.label.epic:ToiletChecker
@allure.label.feature:ChangestatusofaToiletAsset
@allure.label.story:ChangestatusofaToiletAsset
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-007
@allure.label.suite.scenario02.ChangestatusofaToiletAsset
	Scenario: 02) Change status of a Toilet Asset
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377133 |
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
@allure.label.suite:GTRDWM-REG-007
@allure.label.suite.scenario03.Lock/UnlockaToiletAsset
Scenario: 03) Lock/ Unlock a Toilet Asset
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377133 |
	And I select View Details arrow
	And I press button Lock/Unlock a Toilet Asset
	And I enter following Toilet Checker data:
      | Comment |
      | Lock/Unlock a Toilet Asset Test |
	And I press ok button
	And I verify toilet locked
	And I verify toilet Status
	And I take screenshot of toilet Status Unlock

	Examples:
      | role |
      | clean master |




# Validate Setup scenario
@allure.label.epic:ToiletChecker
@allure.label.feature:ValidateToiletAssetSetup
@allure.label.story:ValidateToiletAssetSetup
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-007
@allure.label.suite.scenario04.ValidateToiletAssetSetup
Scenario: 04) Validate Toilet Asset Setup
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377133 |
	And I select View Details arrow
	And I verify toilet number
	And I verify toilet description
	And I verify toilet Status
	And I verify toilet unavailability reason
	And I verify toilet locked
	And I verify toilet checked date
	And I select the Close Details arrow
	And I take screenshot of Validate Toilet Asset Setup Test
	


	Examples:
      | role |
      | clean master |



@allure.label.epic:ToiletChecker
@allure.label.feature:UnlockaToiletAsset
@allure.label.story:UnlockaToiletAsset
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-007
@allure.label.suite.scenario05.UnlockaToiletAsset
Scenario: 05) Unlock a Toilet Asset
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377133 |
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
@allure.label.suite:GTRDWM-REG-007
@allure.label.suite.scenario06.ChangestatusofaToiletAsset
	Scenario: 06) Change status of a Toilet Asset
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377133 |
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



# Delete scenario
@allure.label.epic:ToiletChecker
@allure.label.feature:DeleteToiletAssetSetup
@allure.label.story:DeleteToiletAssetSetup
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-007
@allure.label.suite.scenario07.DeleteToiletAssetSetup
Scenario: 07) Delete Toilet Asset Setup
	Given I sign as <role>
	And I open application Assets(Tr) 
	And I filter table Assets:
      | Asset |
      | TOILET-S-00098 |
	And I select no. 1 record from Assets table records
	And I go to Tab Specifications
	And I delete no. 1 record in Specifications section
	And I save record
	And I take screenshot of Delete Toilet Asset Setup Test


	Examples:
      | role |
      | clean master |