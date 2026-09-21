Feature: GTR-UAT-RTS-017 In Service / Arriving Tab - Mark a Unit as No Show or Delayed

As a Panel Operations Manager, I want to mark a train as No Show.
@allure.label.epic:YardMaster
@allure.label.feature:InService/ArrivingTab
@allure.label.story:MarkaUnitasNoShoworDelayed
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-017
Scenario: In Service / Arriving Tab - Mark a Unit as No Show or Delayed
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | BATTERSEA-STWRT-YARD |
	And I select no.1 record Yard Asset table records
	And I go to In Service / Arriving Tab
	And I select action Manage Non-Arrival
	And I Add Memo: 
	   | Comment | 
       | Non-Arrival Test |
	And I select Confirm Non-Arrival button
	And I select No Show sub Tab
	And I take screenshot of No Show


	Examples:
      | role |
      | Panel Operations Manager |