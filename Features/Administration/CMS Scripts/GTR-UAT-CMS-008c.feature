Feature: 0.0.08c - Allocating a Trainee to a Training Course (in Work Order Tracking)

To allocate a trainee to a scheduled training course using the Work Order Tracking (BRDA) application.


@Feature:0.0.08c-AllocatingaTraineetoaTrainingCourse(inWorkOrderTracking)
Scenario: 01) Creating a new Training Course Work Order
Given I sign as cms admin
	And I open application Work Order Tracking (BRDA)
	And I select create new record
	And I enter work order:
        | Description |
        | Allocating a Trainee to a Training Course Test |
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
	And I take screenshot of Allocating Trainee Training Course in (Work Order Tracking) Test Scenario one
	And I return to Maintainer Start Center

	 

	Examples:
      | role |
      | cms admin |




Scenario: 02) Allocating a Trainee to a Training Course (in Work Order Tracking)
    Given  I sign as cms admin 
    And I open application CMS Course Work Order (MXR)
	And I filter table CMS Course Work Order (MXR):
	    | Description | Status |
	    | Allocating a Trainee to a Training Course Test | =WAIT-REV |
	And I select no. 1 from CMS Course Work Order table records
	And I select New Row button under Assignments section
	And I choose Select Value from Detail Menu of the Craft Field
	And I filter Craft table:
        | Craft |
        | DELEGATE |
	And I select no. 1 from Craft table records
	And I choose Select Value from Detail Menu of the labor field
	And I select no. 1 from labor table records
    And I save record
	And I verify Assignments status is ASSIGNED
    And I take screenshot of Allocating Trainee Training Course in (Work Order Tracking) Test Scenario two
    
	
	

	Examples:
      | role |
      | cms admin |
