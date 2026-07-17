Feature: GTR-UAT-TAS-009 - Calculate Risk When “Days Left = 1”

Validate the calculated risk for a toilet asset when days left = 1, based on last check time (<24h vs ≥24h)

@Feature:GTR-UAT-TAS-009-CalculateRiskWhen“DaysLeft=1”
Scenario: Calculate Risk When “Days Left = 1”
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
	And I verify toilet checked date
	And I verify toilet locked
	And I verify toilet locked Comments
	And I take screenshot of Toliet Checker Details
	And I open application Clean Master Application (MXR)
	And I filter clean master:
	  | Location | Work Type |
	  | 377133   | CET,WTF   |
	And I verify CET Days Left
	And I verify WTF Days Left
	And I take screenshot of Clean Master Details
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377133 |
    And I select no. 1 record from Toilet Checker table records
	And I select View Details arrow
	And I verify toilet checked date
	And I open application Rail Units (BRDF)
	And I filter table Rail Units:
      | Rail Units |
      | 377133 |
    And I select no. 1 record from Rail Units table records
	And I verify unit in service
	And I take screenshot of Rail Units Details
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377133 |
    And I select no. 1 record from Toilet Checker table records
	And I select Run Reports
	#And I select action Run Reports
	And I filter table Toilet Checker Reports:
	  | Reports | 
	  | Train Toilet Availability Report |
	And I select no. 1 record from Toilet Checker Reports table record
	And I open Select Value lookup of Area
	And I select no. 2 record from Area lookup table records
	And I submit report
	And I wait for page to load
	And I take screenshot of Toilet Checker Report test


	   Examples:
      | role |
      | maxadmin |
	
	
