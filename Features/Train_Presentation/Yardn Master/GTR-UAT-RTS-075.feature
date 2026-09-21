Feature: GTR-UAT-RTS-075 - Reports - Departure history

A short summary of the feature

@allure.label.epic:YardMaster
@allure.label.feature:Reports
@allure.label.story:Departurehistory
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-075
Scenario: Departure history
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
       | Depot History |
	And I select no.1 record Reports table records
	And I set Start Date
	And I set End Date
	And I select value lookup of changed By field
	And I filter Person table records:
       | Person |
       | POM-UAT1 |
	And I select no.1 record Person table records
	And I click the OK button
	And I set (Radio) field to "Immediate"
	And I select submit Report button
	And I take screenshot of Departure history Report


	
	Examples:
      | role |
      | Panel Operations Manager |

	