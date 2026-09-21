Feature: GTR-UAT-RTS-077 - Reports - Departure History

A short summary of the feature

@allure.label.epic:YardMaster
@allure.label.feature:Reports
@allure.label.story:DepartureHistory
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-077
Scenario: Departure History
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | LITTLEHAMPTON-YARD |
	And I select no.1 record Yard Asset table records
	And I take screenshot of Depot Yard View
	And I select Depot Menu Run Reports
	And I filter Reports table records:
       | Reports |
       | Historical Departure Report |
	And I select no.1 record Reports table records
	And I select start date
	And I select end date
	And I set (Radio) field to "Immediate"
	And I select submit Report button
	And I take screenshot of Historical Departure Report


	
	Examples:
      | role |
      | Panel Operations Manager |