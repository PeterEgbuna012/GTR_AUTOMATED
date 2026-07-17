Feature: 0.0.1 - Work Order Details Report


The Maintainer Team Leader wants to run a Work Order Details report.

@Feature:0.0.1-WorkOrderDetailsReport
Scenario: Work Order Details Report
      Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I filter table CM Work Order:
        | Description | Status  |
        | CM WO AUTO TEST | =WAIT-REV |
      #And I wait for Report page to load
	  And I select action Run Reports
	  And I filter Report table:
		| Report | 
		| Work Order Details Report |
	  And I select no. 1 record from Reports table records
      And I set (Radio) Immediate field to Yes
	  And I submit Work Order Details Report
	  And I wait for page to load
	  And I take screenshot of Work Order Details Report

	  Examples:
      | role |
      | maintainer team leader |
	
