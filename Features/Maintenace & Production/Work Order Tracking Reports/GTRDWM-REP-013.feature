Feature: 0.0.13 - Work Orders Awaiting Material

The Maintainer Team Leader wants to run a Frequency Based Maintenance Plan report.

@Feature:0.0.13-WorkOrdersAwaitingMaterial
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
		| 01/01/2025 | 01/08/2025 |
     And I enter Location:
		| Location | 
		| =HORNSEY |
	  And I submit Number of Work Orders Awaiting Materials and Average Time Open report
	  And I wait for page to load
	  And I take screenshot of Work Orders Awaiting Material Report


	   Examples:
      | role |
      | maintainer team leader |
