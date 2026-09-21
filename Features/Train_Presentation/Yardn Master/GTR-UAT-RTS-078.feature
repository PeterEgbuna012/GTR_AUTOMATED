Feature: GTR-UAT-RTS-078 - Reports - Stopped Vehicles Report

A short summary of the feature

@allure.label.epic:YardMaster
@allure.label.feature:Reports
@allure.label.story:StoppedVehicles
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-078
Scenario: Stopped Vehicles Report
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
       | Stopped Vehicles Report |
	And I select no.1 record Reports table records
	And I filter table Owner Group:
       | Owner Group |
       | =APP,=BATSLN,=BRGHTN,=BRIGHTON,=HORNSEY |
	And I filter table Depot:
       | Depot |
       | =APP,=BATSLN,=BRGHTN,=BRIGHTON,=HORNSEY |
	And I filter table Vehicle Type:
       | Vehicle Type |
       | =COMPO,=RAILCAR,=RAILUNIT |
	And I set Stop Date From
	And I set Stop Date To
	And I set (Radio) field to "Immediate"
	And I select submit Report button
	And I take screenshot of Stopped Vehicles Report


	
	Examples:
      | role |
      | Panel Operations Manager |
