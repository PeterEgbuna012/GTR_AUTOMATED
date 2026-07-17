Feature: GTR-UAT-RTS-036 Available for Service Tab - View the Units that are Available for Service

As a Panel Operations Manager, I want to view all units that are available for service so that I can assign them to a service or un-assign them from a service as needed. 

@Feature:GTR-UAT-RTS-036AvailableforServiceTab-ViewtheUnitsthatareAvailableforService
Scenario: Available for Service Tab - View the Units that are Available for Service
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | BRIGHTON-YARD |
	And I select no.1 record Service Management table records
	And I go to Available for Service Tab
	And I take screenshot of Available for Service Tab


Examples:
	| role                     |
	| Panel Operations Manager |
