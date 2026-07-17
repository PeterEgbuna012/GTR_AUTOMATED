Feature: GTR-UAT-RTS-011 Prepping Tab - Prepping and Unprepping a Unit

As a Panel Operations Manager, I want to view whether a train is prepped / unprepped and to be able to action as needed. 

@Feature:GTR-UAT-RTS-011PreppingTab-PreppingandUnpreppingaUnit
Scenario: Prepping Tab - Prepping and Unprepping a Unit
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | BRIGHTON-YARD |
	And I select no.1 record Yard Asset table records
	#And I select Unit on Roads
	#And I Select Create Move Request
	#And I select value lookup of Road field
	#And I filter Road:
	#	| Road |  
	#	| LH-P2 |
	#And I select no.1 record from Road table
	#And I set Move By Date
	#And I click ok dailog button of Create Move Request
	#And I take screenshot of Created Move Request 
	And I go to Prepping Tab
	And I take screenshot of Move Request in Prepping Tab
	And I select prepped sub tab
	And I select No Prep Required sub Tab
	And I select unprepped sub Tab
	And I select action Prep Consist
	And I set Choose a Date 
	And I select value lookup of Prepped By field
	And I filter Person:
		| Person |  
		| PEGBUNA |
	And I select no.1 record from Person table
	And I enter Additional info:
		| Additional Info |  
		| Additional Info Testing |
	And I click Confirm dailog button
	And I take screenshot of Completed Prep Consist
	And I select prepped sub tab
	And I select action Unprep Consist
	And I select dialog Yes buttom of system message
	And I take screenshot of Unprep Consist
	And I select unprepped sub Tab
	And I select action No Prep Required
	And I select Yes dialog button of system message
	And I go to No Prep Required sub tab
	And I take screenshot of No Prep Required




	Examples:
      | role |
      | Panel Operations Manager |
