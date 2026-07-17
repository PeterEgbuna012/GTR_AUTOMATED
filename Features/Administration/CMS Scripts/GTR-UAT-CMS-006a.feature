Feature: 0.0.06a - Scheduling a Training Course (in Graphical Scheduling)


There is a need to (re)schedule training courses using the Graphical Scheduling application.


@Feature:0.0.06a-SchedulingaTrainingCourse(inGraphicalScheduling)
Scenario: 01) Scheduling a Training Course (in Graphical Scheduling)
    Given I sign as maxadmin
	And I open application Graphical Scheduling
	And I select create new schedule
	And I enter Schedule ID:
        | ID | Description |
		| Test1 | Schedule for New Starter Assessments |
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
	And I go to tab Graphical View
	And I wait for Graphical page to load
	And I select Commit Changes
	And I click yes dialog button
	And I press OK dialog button of system message
	And I change status to Approved
	And I select ok
	And I go to tab Schedule
	And I verify status APPROVED
	And I take screenshot of Scheduling a Training Course (in Graphical Scheduling) Test Scenario one
	

	Examples:
      | role |
      | maxadmin |



	  
Scenario: 02) Delete Training Course 
      Given I sign as maxadmin
	  And I open application Graphical Scheduling
	  And I filter table Graphical Scheduling:
		  | ID |
		  | Test1 |
      And I select no. 1 record from Graphical Scheduling table records
	  And I select delete Graphical Scheduling record
	  And I select Yes button
	  And I verify Graphical Scheduling table has no records
	  And I take screenshot of Scheduling a Training Course (in Graphical Scheduling) Test Scenario two
	

	Examples:
      | role |
      | maxadmin |
	 
