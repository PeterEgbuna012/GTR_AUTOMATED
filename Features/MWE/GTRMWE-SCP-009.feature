Feature: GTRMWE-SCP-009 - Scheduling a Training Course (in Work Order Tracking)

There is a need to (re)schedule training courses using the Work Order Tracking (BRDA) application.


# Setup scenario
@allure.label.epic:CMS
@allure.label.feature:CreatinganewTrainingCourseWorkOrder
@allure.label.story:CreatinganewTrainingCourseWorkOrder
@allure.label.severity:Critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRMWE-SCP-009
@allure.label.suite.scenario01.CreatinganewTrainingCourseWorkOrder
Scenario: 01) Creating a new Training Course Work Order
      Given I sign as maxadmin
	And I open application Work Order Tracking (BRDA)
	And I select create new record
	And I enter work order:
      | Description |
      | Scheduling a Training Course Test |
	And I choose Select Value from Detail Menu of Location field
	And I filter table Location:
      | Location |
      | HORNSEY |
	And I select no. 1 from Location table records
	And I set Work Type field:
	  | Work Type |
		| CMS |
	And I Scheduled Start Date to today's date
	And I save record
	And I verify work order status WAIT-REV
	And I take screenshot of Scheduling a Training Course (in Work Order Tracking) Test Scenario one
	And I return to Maintainer Start Center
	
		

	Examples:
      | role |
      | maxadmin |





# Setup scenario
@allure.label.epic:CMS
@allure.label.feature:SchedulingaTrainingCourseAssessment
@allure.label.story:SchedulingaTrainingCourseAssessment
@allure.label.severity:Critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRMWE-SCP-009
@allure.label.suite.scenario02.SchedulingaTrainingCourseAssessment
Scenario: 02) Scheduling a Training Course Assessment
	Given I sign as <role>
    And I open application CMS Course Work Order (MXR)
	And I filter table CMS Course Work Order (MXR):
	  | Description | Status |
	  | Scheduling a Training Course Test | =WAIT-REV |
	And I select no. 1 from CMS Course Work Order table records
	And I select route work flow button
	And I set (Radio) field to Set the work order to SCHEDULED
	And I select dialog ok button of System Message
	And I take screenshot of Scheduling a Training Course Assessment

	Examples:
      | role |
      | cms admin |


@allure.label.epic:CMS
@allure.label.feature:AssigningaCMWorkOrder
@allure.label.story:AssigningaCMWorkOrder
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRMWE-SCP-009
@allure.label.suite.scenario03.AssigningaCMSWorkOrder
 Scenario: 03) Assigning a CMS Work Order
 Given I sign as <role>
  And I open application Work Order Tracking BRDA from Favorite Menu
  And I filter table CM Work Order:
      | Description | Status  |
      | Scheduling a Training Course Test | =SCHEDULED |
  And I select no. 1 record from CM Work Order table records
  And I go to Assignments Tab
  And I add new row in Assignments Tab
  And I open Select Value lookup for Labor field
  And I filter table Labor:
      | Labor |
      | ISCOTT |
  And I select no. 3 record from Labor table records
  #And I pree Ok dialog system message button
  And I verify CM work order generated
  And I save record
  And I take screenshot of Assigning a CM Work Order Test Scenario two
  
   Examples:
      | role     |
      | cms admin |
	 
