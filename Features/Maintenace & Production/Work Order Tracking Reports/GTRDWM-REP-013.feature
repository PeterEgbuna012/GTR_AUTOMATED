Feature: 0.0.13 - Work Orders Awaiting Material

The Maintainer Team Leader wants to run a Frequency Based Maintenance Plan report.

@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:WorkOrdersAwaitingMaterial
@allure.label.story:WorkOrdersAwaitingMaterial
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.13
Scenario: Work Orders Awaiting Material
      Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I select action Run Reports
	  And I filter Report table:
		| Report | 
		| Number of Work Orders Awaiting Materials and Average Time Open |
	  And I select no. 1 record from Reports table records
	  And I enter report Start and End Date:
		| Start Date | End Date |
		| 01/01/2026 | 01/08/2026 |
     And I enter Location:
		| Location | 
		| =HORNSEY |
	  And I submit Number of Work Orders Awaiting Materials and Average Time Open report
	  And I wait for page to load
	  And I take screenshot of Work Orders Awaiting Material Report


	   Examples:
      | role |
      | maintainer team leader |
