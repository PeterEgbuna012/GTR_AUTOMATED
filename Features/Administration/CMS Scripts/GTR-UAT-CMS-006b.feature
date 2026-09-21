Feature: 0.0.06b - Scheduling a Training Course (in Work Order Tracking)

There is a need to (re)schedule training courses using the Work Order Tracking (BRDA) application.

# Setup scenario
@allure.label.epic:CMS
@allure.label.feature:CreatinganewTrainingCourseWorkOrder
@allure.label.story:CreatinganewTrainingCourseWorkOrder
@allure.label.severity:Critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.06b
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
@allure.label.feature:SchedulingaTrainingCourse(inWorkOrderTracking)
@allure.label.story:SchedulingaTrainingCourse(inWorkOrderTracking)
@allure.label.severity:Critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.06b
@allure.label.suite.scenario02.SchedulingaTrainingCourse(inWorkOrderTracking)
Scenario: 02) Scheduling a Training Course (in Work Order Tracking)
	  Given I sign as training manager
 	  And I open application CMS Course Work Order (MXR)
	  And I filter table CMS Course Work Order:
      | Description |
      | Scheduling a Training Course Test |
	  And I select no. 1 from CMS Course Work Order table records
	  And I Set Scheduled Start
	  And I Set Scheduled Finish date
      And I save record
	  And I verify Scheduled Start
	  And I take screenshot of Scheduling a Training Course (in Work Order Tracking) Test Scenario two
	  And I return to Maintainer Start Center
	  
	

	Examples:
      | role |
      | training manager |
	 
