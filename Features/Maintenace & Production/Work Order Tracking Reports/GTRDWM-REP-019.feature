Feature: 0.0.19 - Work Undertaken by Individual


The Maintainer Team Leader wants to run a Work Undertaken by Individual Report

@Feature:0.0.19-WorkUndertakenbyIndividual
Scenario: Work Undertaken by Individual
      Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I select action Run Reports
	  And I filter Report table:
		| Report | 
		| Work Undertaken by Individual |
	  And I select no. 1 record from Reports table records
	  And I set report start date and end date:
		| Start Date | End Date |
		| 01/01/2025 | 01/08/2025 |
     And I enter maintainer:
		| Maintainer | 
		| =ISCOTT |
	  And I submit Work Undertaken by Individual Report
	  And I wait for page to load
	  And I take screenshot of Work Undertaken by Individual Report
	  
	   Examples:
      | role |
      | maintainer team leader |
	
