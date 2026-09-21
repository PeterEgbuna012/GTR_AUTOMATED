Feature: 0.0.2 - Campaigns Overview

You need to generate a Work Order Details Report.

@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:CampaignsOverview
@allure.label.story:CampaignsOverview
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.2
Scenario: Compliance Overview
	  Given I sign as <role>
	  And I open application Work Order Tracking (BRDA)
	  And I filter table CM Work Order:
        | Description | Status  |
        | CM WO AUTO TEST | =WAIT-REV |
	  #And I wait for Report page to load
	  And I select action Run Reports
	  And I filter Report table:
		| Report | 
		| Campaign Overview |
	  And I select no. 1 record from Reports table records
	  And I enter period count:
		| Period Count | 
		| 2 |
      And I set (Radio) field to "Immediate"
	  And I submit campaigns overview report
	  And I wait for page to load
	  And I take screenshot of Campaigns Overview

	  Examples:
      | role |
      | maintainer team leader |
	
