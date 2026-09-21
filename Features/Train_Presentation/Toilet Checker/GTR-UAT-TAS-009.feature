Feature: GTR-UAT-TAS-009 - Calculate Risk When “Days Left = 1”

Validate the calculated risk for a toilet asset when days left = 1, based on last check time (<24h vs ≥24h)
@allure.label.epic:ToiletChecker
@allure.label.feature:ChangestatusofaToiletAsset
@allure.label.story:ChangestatusofaToiletAsset
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-009
@allure.label.suite.scenario01.ChangestatusofaToiletAsset
	Scenario: 01) Change status of a Toilet Asset
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377101 |
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
@allure.label.suite:GTRDWM-REG-009
@allure.label.suite.scenario02.Lock/UnlockaToiletAsset
Scenario: 02) Lock/ Unlock a Toilet Asset
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377101 |
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


@allure.label.epic:ToiletChecker
@allure.label.feature:CalculateRiskWhen“DaysLeft=1”
@allure.label.story:CalculateRiskWhen“DaysLeft=1”
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-009
@allure.label.suite.scenario03.CalculateRiskWhen“DaysLeft=1”
Scenario: 03) Calculate Risk When “Days Left = 1”
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377101 |
    And I select no. 1 record from Toilet Checker table records
	And I select View Details arrow
	And I verify toilet number
	And I verify toilet description
	And I verify toilet Status
	And I verify toilet unavailability reason
	And I verify toilet checked date
	And I verify toilet locked
	And I verify toilet locked Comments
	And I take screenshot of Toliet Checker Details
	And I open application Clean Master Application (MXR)
	And I filter clean master:
	  | Location | Work Type |
	  | 377101   | CET,WTF   |
	And I verify CET Days Left
	And I verify WTF Days Left
	And I take screenshot of Clean Master Details
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377101 |
    And I select no. 1 record from Toilet Checker table records
	And I select View Details arrow
	And I verify toilet checked date
	And I open application Rail Units (BRDF)
	And I filter table Rail Units:
      | Rail Units |
      | 377101 |
    And I select no. 1 record from Rail Units table records
	And I verify unit in service
	And I take screenshot of Rail Units Details
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377101 |
    And I select no. 1 record from Toilet Checker table records
	And I select Run Reports
	#And I select action Run Reports
	And I filter table Toilet Checker Reports:
	  | Reports | 
	  | Train Toilet Availability Report |
	And I enter Area Details:
      | Area |
      | =SOUTHERN |
	#And I open Select Value lookup of Area
	And I submit report
	And I wait for page to load
	And I take screenshot of Toilet Checker Report test


	   Examples:
      | role |
      | maxadmin |
	
	
