Feature: GTR-UAT-TAS-008 - View Clean Master Work orders

As a planner you need to view all the train toilet assets and associated for cleanmaster work orders. 

@Feature:GTR-UAT-TAS-008-ViewCleanMasterWorkorders
Scenario: View Clean Master Work orders
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	And I refresh Toilet Checker table records
	And I select no. 2 record from Toilet Checker table records
	And I select View clean master work orders option
	And I select complete clean master task button
	And I take screenshot of View Clean Master Work
	And I press ok
	And I take screenshot of View Clean Master Work orders Test



	Examples:
      | role |
      | clean master |
