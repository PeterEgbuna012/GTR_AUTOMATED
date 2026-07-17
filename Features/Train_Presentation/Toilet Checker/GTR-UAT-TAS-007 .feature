Feature: GTR-UAT-TAS-007 - Toilet Asset Setup

As a planner you need to view all the train toilet type related for work and status

@Feature:GTR-UAT-TAS-007-ToiletAssetSetup
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


@Feature:GTR-UAT-TAS-006-UpdatestatusoflockedToiletAsset
Scenario: 02) Validate Toilet Asset Setup
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

