Feature: GTR-UAT-RTS-003 Depot View Tab - Block all the roads in a Depot (Emergency)

As a Panel Operations Manager, you want to block all roads in the yard. So that in the case of an Emergency incident all roads can be blocked

@Feature:GTR-UAT-RTS-003DepotViewTab-BlockalltheroadsinaDepot(Emergency)
Scenario: Block all the roads in a Depot (Emergency)
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | BRIGHTON-YARD |
	And I select no.1 record Yard Asset table records
	And I select Depot Menu Option change Status
	#And I Select change Status
	And I enter Memo:
		| Memo |  
		| TESTING |
	And I select Status as BLOCKED
	And I press OK dialog button
	And I take screenshot of Blocked Roads
	And I select Depot Menu Option
	And I change Status
	And I select Status as ACTIVE
	And I enter Memo details:
		| Memo |  
		| TESTING |
	And I press OK dialog button
	And I take screenshot of UnBlocked Roads
	

	Examples:
      | role |
      | Panel Operations Manager |

	
