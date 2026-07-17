Feature: 0.0.3 - Compliance Overview

The Maintainer Team Leader wants to run a Compliance overview report.

@Feature:0.0.3-ComplianceOverview
Scenario: Compliance Overview
	  Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I select action Run Reports
	  And I filter Report table:
		| Report | 
		| Compliance Overview Report |
	  And I select no. 1 record from Reports table records
	  And I enter Compliance Details:
		| Period Count | Asset Group |
		| 2            | =RS        |
	  And I submit compliance overview report
	  And I wait for page to load
	  And I take screenshot of Compliance Overview Report

	  Examples:
      | role |
      | maintainer team leader |
