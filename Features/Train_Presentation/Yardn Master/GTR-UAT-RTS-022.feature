Feature: GTR-UAT-RTS-022 Available for Service Tab - Cancel a Service

	As a Panel Operations Manager, I want to cancel a Service. 

@Feature:GTR-UAT-RTS-022AvailableforServiceTab-CancelaService
Scenario: Available for Service Tab - Cancel a Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | SELHURST-YARD |
	And I select no.1 record Service Management table records
	And I go to Available for Service Tab
	And I go to Departures sub tab
	And I select action Cancel Service Line
	And I select OK dialog button of Cancel Service Line
	And I select Ok dialog system message of Cancel Service Line
	And I take screenshot of canceled service in Available for Service Tab



	Examples:
	  | role |
	| Panel Operations Manager |
