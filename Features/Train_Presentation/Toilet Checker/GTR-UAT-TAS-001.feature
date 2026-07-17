Feature: GTR-UAT-TAS-001 - View Toilet Status

As a planner you need to view all the train toilet related status


@Feature:GTR-UAT-TAS-001-ViewToiletStatus
Scenario: View Toilet Status
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	 And I filter table Toilet Checker:
      | Toilet Checker |
      | 377133 |
    And I select no. 1 record from Toilet Checker table records
	And I select View Details arrow
	And I verify toilet number
	And I verify toilet description
	And I verify toilet Status
	And I verify toilet unavailability reason
	And I verify toilet locked
	And I verify toilet checked date
	And I select the Close Details arrow
	And I take screenshot of View Toilet Status
	


	Examples:
      | role |
      | clean master |
