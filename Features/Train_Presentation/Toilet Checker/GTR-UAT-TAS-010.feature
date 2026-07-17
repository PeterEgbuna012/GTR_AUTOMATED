Feature: GTR-UAT-TAS-010 - Automatically create a fault ticket when toilet asset set to unavailable for a technical reason

A short summary of the feature

@Feature:GTR-UAT-TAS-010-Automaticallycreateafaultticketwhentoiletassetsettounavailableforatechnicalreason
Scenario: Automatically create a fault ticket when toilet asset set to unavailable for a technical reason
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I filter table Toilet Checker:
      | Toilet Checker |
      | 377113 |
	And I select change toilet asset statuse button
	And I Click on the status dropdown
	And I select unavailable
	And I filter table Toilet Unavailable Reason:
      | Toilet Checker |
      | Technical Fault |
	And I press button ok
	And I select View Details arrow
	And I verify toilet number
	And I verify toilet description
	And I verify toilet Status
	And I verify toilet unavailability reason
	And I verify toilet checked date
	When I open application Work Orders, Fault Reporting (BRDA)
	And I filter table Fault Reporting (BRDA):
	  | Summary  | Location |
	  | =Technical Fault | 377113   |
	And I select no. 1 record from Fault Reporting table records
	And I verify Fault ID
	And I verify Fault Status
	And I verify Fault Location
	And I verify Fault Summary
	And I take screenshot of Automatically create a fault ticket when toilet asset set to unavailable for a technical reason Test
	

	Examples:
      | role |
      | maxadmin |
