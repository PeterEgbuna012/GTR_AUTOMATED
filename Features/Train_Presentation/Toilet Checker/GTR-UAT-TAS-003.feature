Feature: GTR-UAT-TAS-003 - Lock/ Unlock a Toilet Asset

As a FLEETINTERIORS personnel you need to Lock a toilet asset to ensure compliance and planning.


@GTR-UAT-TAS-003-Lock/UnlockaToiletAsset
Scenario: Lock/ Unlock a Toilet Asset
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