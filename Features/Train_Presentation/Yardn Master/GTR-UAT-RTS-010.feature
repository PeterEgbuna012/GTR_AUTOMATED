Feature: GTR-UAT-RTS-010 Depot View Tab - Actioning a Move Request

As a Panel Operations Manager, I want to view Move Requests and action them.

@Feature:GTR-UAT-RTS-010DepotViewTab-ActioningaMoveRequest
Scenario: 01) In Service / Arriving Tab - Arriving a Train that is in Service
	Given I sign as Panel Operations Manager
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset | 
       | LITTLEHAMPTON-YARD |
	And I select no.1 record Yard Asset table records
	And I go to In Service / Arriving Tab
	And I select action Arrive to Road
	And I select value lookup of Arrival Road field
	And I filter Arrival Road:
		| Arrival Road |  
		| LH-P1 |
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

Scenario: 02) Actioning a Move Request
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
		| LH-P3 |
	And I select no.1 record from Road table
	And I set Move By Date
	And I click ok dailog button of Create Move Request
	And I take screenshot of Create Move Request Test
	And I go to Tab Move Request
	And I select action Manage Move Request
	And I click ok dailog button of Move Request
	And I go to Depot View Tab
	And I Move Unit to Next Road
	And I click Yes dailog button of system message
	#And I set Actual Move By Date
	And I select value lookup of Actual Moved By field
	And I filter Actual Person:
		| Actual Person |  
		| PEGBUNA |
	And I select no.1 record from Actual Person table
	And I click ok dailog button of Confirm Request
	And I take screenshot of Moved Unit in Depot View Tab


	Examples:
      | role |
      | Panel Operations Manager |

