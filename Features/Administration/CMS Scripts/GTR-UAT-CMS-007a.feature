Feature: 0.0.07a - Allocating a Trainer & Classroom to a Training Course (in Graphical Assignment)

There is a need to assign a trainer and classroom to a training course (in Graphical Assignment)

@Feature:0.0.07a-AllocatingaTrainer&ClassroomtoaTrainingCourse(inGraphicalAssignment)
Scenario: 01) Allocating a Trainer & Classroom to a Training Course (in Graphical Assignment)
    Given I sign as maxadmin
	And I open application Graphical Scheduling
	And I select create new schedule
	And I enter Schedule ID:
        | ID | Description |
		| TEST-CMS | Work List for Scheduled CMS Work Orders |
	And I enter Long Description :
        | Long Description  | 
	   	| Allocating a Trainer & Classroom to a Training Course (in Graphical Assignment) Long Description AUTO TEST | 
	And I select the Ok button
	And I choose Select Value from Detail Menu of calendar field
	And I select GTRBASE
	And I select Copy Query button under Work Queries section
	And I filter table Query:
       | Query |
       | MXR_CMS_SCHEDULED_ADMIN |
	And I select no. 1 from Query table records
	And I press dialog ok button of copy Query
	And I save record
	And I wait for Query to load
	And I select list view button
	And I filter Graphical Scheduling Table:
      | ID |
      | TEST-CMS |
	And I select no. 1 from Graphical Scheduling table records
	And I go to tab Graphical View
	And I wait for Graphical page to load
	And I select Commit Changes
	And I click yes dialog button
	#And I press OK dialog button of system message
	And I change status to Approved
	And I select ok
	And I go to tab Schedule
	And I verify status APPROVED
	And I take screenshot of Allocating a Trainer & Classroom to a Training Course (in Graphical Assignment) Test Scenario one
	

	Examples:
      | role |
      | maxadmin |



Scenario: 02) Delete Allocating a Trainer & Classroom to a Training Course (in Graphical Assignment)
      Given I sign as maxadmin
	  And I open application Graphical Scheduling
	  And I filter table Graphical Scheduling:
		  | ID |
		  | TEST-CMS |
      And I select no. 1 record from Graphical Scheduling table records
	  And I select delete Graphical Scheduling record
	  And I select Yes button
	  And I verify Graphical Scheduling table has no records
      And I take screenshot of Delete Allocating a Trainer & Classroom to a Training Course (in Graphical Assignment) Test Scenario two
	

	Examples:
      | role |
      | maxadmin |
	 