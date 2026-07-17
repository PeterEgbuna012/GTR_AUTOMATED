Feature: 0.0.06b - Scheduling a Training Course (in Work Order Tracking)

There is a need to (re)schedule training courses using the Work Order Tracking (BRDA) application.

@Feature:0.0.06b-SchedulingaTrainingCourse(inWorkOrderTracking)
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
	 
