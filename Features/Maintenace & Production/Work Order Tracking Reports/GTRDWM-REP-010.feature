Feature: 0.0.10 - Fleet Meter Based PM overview

The Maintainer Team Leader wants to run a Fleet Meter Based PM overview report.

@Feature:0.0.10-FleetMeterBasedPMoverview
Scenario: Fleet Meter Based PM overview
      Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I select action Run Reports
	  And I filter Report table:
		| Report | 
		| Frequency Based Maintenance Plan |
	  And I select no. 1 record from Reports table records
	  And I enter class:
		| Class | 
		| =A2   |
	  And I submit Frequency Based Maintenance Plan
	  And I wait for page to load
	  And I take screenshot of Fleet Meter Based PM overview Report


	   Examples:
      | role |
      | maintainer team leader |

	
