Feature: GTR-UAT-RTS-020 Available for Service Tab - Change Unit Status

As an Engineer, I want to change the status of a Unit in the yard. 

@Feature:GTR-UAT-RTS-020AvailableforServiceTab-ChangeUnitStatus
Scenario: Available for Service Tab - Change Unit Status
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | CRICKLEWOOD-SOUTH-SIDINGS-YARD |
	And I select no.1 record Service Management table records
	And I go to Available for Service Tab
	And I select action change unit status
	And I select STOPPED
	And I enter unit Memo:
		| Memo |  
		| TESTING |
    And I select value lookup of stop code field
	And I filter Stop Code:
		| Stop Code |  
		| ENG |
	And I select no.1 record from Stop Code table
	And I set Stop Date
	And I set Stop Estimated Release Date
	And I select OK dialog button of Change Status of Rail Unit
	And I go to Depot View Tab
	And I take screenshot of stopped status in Available for Service Tab
	
   Examples:
      | role |
      | Panel Operations Manager |