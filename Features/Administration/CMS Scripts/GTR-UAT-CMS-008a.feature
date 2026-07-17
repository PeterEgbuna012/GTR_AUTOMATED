Feature: 0.0.08a - Allocating a Trainer, Classroom & Trainees to a Training Course (in Graphical Assignment)

To allocate a trainer, classroom and trainees to a scheduled training course using the Graphical Assignment application.


@Feature:0.0.08a-AllocatingaTrainer,Classroom&TraineestoaTrainingCourse(inGraphicalAssignment)
Scenario: 01) Allocating a Trainer, Classroom & Trainees to a Training Course (in Graphical Assignment)
Given I sign as training manager
	And I open application Graphical Assignment
	And I select create new schedule
	And I enter Assignment:
        | ID | Description |
		| TAUTO-CMS | Allocating a Trainee to a Training Course Test |
	And I choose Select Value from Detail Menu of calendar field
	And I select GTRBASE
	And I open Select Value lookup of Shift field
	And I select no. 1 from Shift table records
	And I Press Ok dialog select Shift button
	And I select Copy Query button under Work Queries section
	And I filter table Query:
       | Query |
       | MXR_CMS_SCHEDULED_ADMIN |
	And I select no. 1 from Query table records
	And I press dialog ok button of copy Query
	And I save record
	And I wait for Query to load
	And I select list view button
	And I filter Graphical Scheduling:
        | Description |
        | Allocating a Trainee to a Training Course Test |
	And I select no. 1 record from Graphical table records
	And I go to tab Work View
	And I wait for Work View page to load
	And I take screenshot of Allocating a Trainer, Classroom & Trainees to a Training Course (in Graphical Assignment) Test Scenario one
	


	Examples:
      | role |
      | training manager |





Scenario: 02) Delete Allocating a Trainer & Classroom to a Training Course (in Graphical Assignment)
      Given I sign as training manager
	  And I open application Graphical Assignment
	  And I filter table Graphical Scheduling:
		  | ID |
		  | TAUTO-CMS |
      And I select no. 1 record from Graphical Scheduling table records
	  And I select delete Graphical Scheduling record
	  And I select Yes button
	  And I verify Graphical Scheduling table has no records
	  And I take screenshot of Allocating a Trainer, Classroom & Trainees to a Training Course (in Graphical Assignment) Test Scenario two
	

	Examples:
      | role |
      | training manager |
	   
 