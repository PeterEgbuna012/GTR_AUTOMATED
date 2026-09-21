Feature: GTR-UAT-RTS-009 Depot View Tab - Create a Move Request

I want to create a move request for the POMs to action. I also want to be able to amend or cancel an existing Move Request. 
@allure.label.epic:YardMaster
@allure.label.feature:DepotViewTab
@allure.label.story:AddUnittotheDepot
@allure.label.severity:Trivial
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-009
@allure.label.suite.scenario01.AddUnittotheDepot
Scenario: 01) Add Unit to the Depot
	Given I sign as Panel Operations Manager
	And I open application Road (BRDF)
	And I filter table Roads:
       | Road | 
       | LITTLEHAMPTON-YARD |
	And I select no.2 record Roads table records
	And I click button Select Existing Rail Unit
	And I click Filter Table option
	And I filter table Existing Rail Unit:
       | Status | 
       | AFS |
	And I select no.1 record Rail Units table records
	And I click Select button
	And I verify Rail unit
	And I take Screenshot of Add Unit to the Depot Test


	Examples:
      | role |
      | Panel Operations Manager |


@allure.label.epic:YardMaster
@allure.label.feature:DepotViewTab
@allure.label.story:CreateaMoveRequest
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTR-UAT-RTS-009
@allure.label.suite.scenario02.CreateaMoveRequest
Scenario: 02) Create a Move Request
	Given I sign as Panel Operations Manager
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | LITTLEHAMPTON-YARD |
	And I select no.1 record Yard Asset table records
	And I select Unit on Roads
	And I Select Create Move Request
	And I select value lookup of Road field
	And I filter Road:
		| Road |  
		| LH-P1 |
	And I select no.1 record from Road table
	And I set Move By Date
	And I click ok dailog button of Create Move Request
	And I take screenshot of Create Move Request
	And I go to Tab Move Request
	And I take screenshot of Move Request Details
	#And I select action Create Move Request
	#And I select action Manage Move Request
	#And I select value lookup of Road field
	#And I filter Road:
	#	| Road |  
	#	| LH-P2 |
	#And I select no.1 record from Road table
	#And I modify Move By Date
	#And I click ok dailog button of Move Request Details
	#And I go to Prepping Tab
	#And I select action Prep Consist
	#And I set Choose a Date 
	#And I select value lookup of Prepped By field
	#And I filter Person:
		#| Person |  
		#| MAXADMIN |
	#And I select no.1 record from Person table
	#And I enter Additional info:
		#| Additional Info |  
		#| Additional Info Testing |
	#And I click Confirm dailog button
	#And I take screenshot of Prep Consist
	#And I go to At Location Tab
	#And I take screenshot of Move Request in At Location Tab
	#And I go to Move Request Tab
	#And I select action Cancel Move Request
	#And I select Cancelled
	#And I click ok dailog button of Change Move Request Status
	#And I take screenshot of Cancelled Move Request


	Examples:
      | role |
      | Panel Operations Manager |


