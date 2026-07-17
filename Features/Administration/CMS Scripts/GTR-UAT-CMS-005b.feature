Feature: 0.0.05b - Creating a new Training Course Work Order

There is a need to create a new training course work order (for MC Courses or Annual Assessments).

@Feature:0.0.05b-CreatinganewTrainingCourseWorkOrder
Scenario: Creating a new Training Course Work Order
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
	And I take screenshot of Creating a new Training Course Work Order test
	And I return to Maintainer Start Center
	
	

	Examples:
      | role |
      |maxadmin|


   