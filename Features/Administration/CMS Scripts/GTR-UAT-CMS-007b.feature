Feature: 0.0.07b - Allocating a Trainer & Classroom to a Training Course (in Work Order Tracking)


To schedule a training course using the Work Order Tracking (BRDA) application.

@Feature:0.0.07b-AllocatingaTrainer&ClassroomtoaTrainingCourse(inWorkOrderTracking)
 Scenario: 01) Creating a new Training Course Work Order
    Given I sign as maxadmin
	And I open application Work Order Tracking (BRDA)
	And I select create new record
	And I enter work order:
      | Description |
      | New Starter Assessment WO |
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
	And I take screenshot of Allocating a Trainer & Classroom to a Training Course (in Work Order Tracking) test scenario one
	And I return to Maintainer Start Center
	
	

	Examples:
      | role |
      |maxadmin|



Scenario: 02) Allocating a Trainer & Classroom to a Training Course (in Work Order Tracking)
	  Given I sign as training manager
	  And I open application Work Order Tracking (BRDA)
	  And I filter work Order:
          | Description | Work Type  |
          | New Starter Assessment WO | =CMS |
      And I select no. 1 record from work Order table records
	  And I Reschedule Start Date tomorrow's date
	  And I save record
      And I take screenshot of Allocating a Trainer & Classroom to a Training Course (in Work Order Tracking) Test Scenario two
	

	Examples:
      | role |
      | training manager |


