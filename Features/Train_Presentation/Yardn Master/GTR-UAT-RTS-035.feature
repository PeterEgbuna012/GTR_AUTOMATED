Feature: GTR-UAT-RTS-035 In Service / Arriving Tab - Arrive a Consist

As a Panel Operations Manager, I want to arrive a consist. I also want to be able to replace a unit on a consist before arriving it. 
@allure.label.epic:YardMaster
@allure.label.feature:InService/ArrivingTab
@allure.label.story:ArriveaConsist
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-035
Scenario: In Service / Arriving Tab - Arrive a Consist
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | SELHURST-YARD |
	And I select no.1 record Yard Asset table records
	And I go to In Service / Arriving Tab
	And I select action Manage Consist
	And I filter table Consist:
       | Consist | Status |
       |         | INS    |
	And I select no.1 record Consist table records
	And I remove no.3 unarrived units
	And I Update Consist
	And I select action Arrive to Road
	And I select value lookup of Arrival Road field
	And I filter Arrival Road:
		| Arrival Road |  
		| SU-01-AC |
	And I select no.1 record from Arrival Road table
	And I set Arrived
	And I set Accepted
	And I set Yard
	And I select dialog Arrive Service button
	And I take screenshot of Arrive Service Test
	And I go to Depot View Tab
	And I take screenshot of Depot View Tab


	Examples:
      | role |
      | Panel Operations Manager |
