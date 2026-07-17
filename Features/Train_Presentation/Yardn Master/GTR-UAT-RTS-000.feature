Feature: GTR-UAT-RTS-000 Logging in and Navigating to the FAM Application

I want to login to Maximo and find the FAM application

@Feature:GTR-UAT-RTS-000LogginginandNavigatingtotheFAMApplication
Scenario: Logging in and Navigating to the FAM Application
	Given I sign as <role>
	And I open application Depot Management (BRDF)
	And I filter table Yard Asset:
       | Yard Asset |
       | SELHURST-YARD |
	And I select no.1 record Yard Asset table records
	And I take screenshot of Depot Yard View
	And I select Depot Menu Option
	And I set Toggle Kiosk Mode
	And I take screenshot of Kiosk Mode
	And I select Depot Menu Option
	And I select Toggle Virtual Holding Road
	And I take screenshot of Virtual Holding Road
	And I select Depot Menu Option
	And I select Return to Depot Selector
	And I take screenshot of Depots and Sidings Table


	Examples:
      | role |
      | Panel Operations Manager |

