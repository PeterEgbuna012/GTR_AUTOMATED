Feature: 0.0.5 - Fleet Status Report

The Maintainer Team Leader wants to run a Fleet Status Report.

@Feature:0.0.5-FleetStatusReport
Scenario: Fleet Status Report
      Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I select action Run Reports
	  And I filter Report table:
		| Report | 
		| Fleet Status Report |
	  And I select no. 1 record from Reports table records
	  And I open Select Value lookup for Depot field
	  And I filter Depot table:
		| Depot | 
		| HORNSEY |
	  And I select no. 1 record from Depot table records
	  And I submit fleet status report
	  And I wait for page to load
	  And I take screenshot of Fleet Status Report


	   Examples:
      | role |
      | maintainer team leader |
	  
