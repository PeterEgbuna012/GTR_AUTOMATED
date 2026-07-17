Feature: 0.0.04 - Creating new Training Course Job Plans

There is a need to create a new training course job plan(s) (to be applied to a Training Course Work Order for MC Courses and Annual Assessments). There are two steps to this process:

Creating the Job Plan for the Parent Work Order for Assignment of Trainees;
Creating the Job Plan for Children Work Orders to list Tasks for Qualifications.

@Feature:0.0.04-CreatingnewTrainingCourseJobPlans
Scenario: 01) Creation of a Qualification
	  Given I sign as training manager
	  And I open application Qualifications
	  And I select New Qualification
	  And I enter Qualifications Details:
		  | Qualification Code | Qualification Description |
		  | QUF 5 | Qualification for Unit Familiarity |
	  And I open Select Value lookup of Qualification Type field
	  And I select Qualification Type:
	    | Qualification Type |
	    | REFRESH |
      And I select Qualification Type  
	  And I enter following:
		  | Power Up Parent Qualification | Duration |
		  | TQ0099 | 2 |
	  And I open Select Value lookup of Duration Period field
      And I select Years from the list
	  And I enter Required Use Length:
          | Required Use Length |
          | 6 |
	  And I open Select Value lookup of Required Use Period field
      And I select MONTHS from the list
	  And I select New Row under the Required Craft and Skill Level section
	  And I choose Select Value from Detail Menu of Craft field
	  And I filter table Craft and Skill Level:
		  | Craft | Skill-Level |
		  | TRAINING | SEMI-SKILLED |
      And I select no. 1 record from Craft and Skill Level table records
	  And I save record
	  And I take screenshot of Craft Skill-Level
	  And I delete Craft Skill-Level
	  And I save record
	  And I change qualifications change status inactive
	  And I select Ok Button
	  And I verify status is INACTIVE
      And I take screenshot of Creating new Training Course Job Plans Test Scenario one
	

	Examples:
      | role |
      | training manager |



Scenario: 02) Creating new Training Course Job Plans
	 Given I sign as cms admin team leader
	 And I open application Job Plans (Tr)
	 And I select New Job Plan
	 And I enter Job Plan:
		  | ID | Description |
		  | CMS-210 | New Starter Assessment - Tasks |
	 And I open Select Value lookup of Organisation field
	 And I select no. 1 record from Organisation table records
	 And I open Select Value lookup of Site field 
	 And I select no. 1 record from Site table records
	 And I select details section maximize option
	 And I enter Duration:
          | Duration |
          | 4:00 |
	 And I select New Row button under Job Plans Tasks section
	 And I enter Task Description:
          | Task Description |
          | Unit familiarity |
	 And I open Select Value lookup of Qualifications field
	 And I select yes dialog button of System Message
	 And I select New Row
	 And I open Select Value lookup of Qualification Requirements field
	 And I filter Qualification Requirements:
          | Qualification |
          | QUF 5 |
	 And I select no. 1 record from Qualification Requirements table records
	 And I Press Ok dialog button
	 And I save record
	 And I set Qualification status ACTIVE
	 And I click Ok
	 And I verify Job Plans status ACTIVE
	 And I take screenshot of Creating new Training Course Job Plans Test Scenario two
	

	Examples:
      | role |
      | cms admin team leader |


Scenario: 03) Create Job Plan to Assign Trainee
	 Given I sign as cms admin team leader
	 And I open application Job Plans (Tr)
	 And I select New Job Plan
	 And I enter Job Plan:
		  | ID | Description |
		  | CMS-202 | New Starter Assessment |
	 And I open Select Value lookup of Organisation field
	 And I select no. 1 record from Organisation table records
	 And I open Select Value lookup of Site field 
	 And I select no. 1 record from Site table records
	 And I select details section maximize option
	 And I enter Duration:
          | Duration |
          | 4:00 |
	 And I select New Row button under Job Plans Tasks section
	 And I enter Task Description:
          | Task Description |
          | Unit familiarity |
	 And I open Select Value lookup of Nested Job Plan field
	  And I filter Nested Job Plan:
          | Description |
          | New Starter Assessment - Tasks |
	 And I select no. 1 record from Nested Job Plan table records
     And I save record
	 And I select New Row button under Job Plans Tasks section
	 And I enter Task Description:
          | Task Description |
          | Unit familiarity 2 |
	 And I open Select Value lookup of Nested Job Plan field
	 And I filter Nested Job Plan:
          | Description |
          | New Starter Assessment - Tasks |
	 And I select no. 1 record from Nested Job Plan table records
	 And I select New Row button under Job Plans Tasks section
	 And I enter Task Description:
          | Task Description |
          | Unit familiarity 3 |
	 And I open Select Value lookup of Nested Job Plan field
	 And I filter Nested Job Plan:
          | Description |
          | New Starter Assessment - Tasks |
	 And I select no. 1 record from Nested Job Plan table records
	 And I save record
	 And I select New Row button under Planned Labor section
	 And I enter Task Value:
          | Task Value |
          | 10 |
     And I choose Select Value from Detail Menu of Craft
	 And I filter table Craft:
		  | Craft | Skill-Level |
		  | TRAINING | SKILLED |
     And I select no. 2 record from Craft table records
	 And I select New Row button under Planned Labor section
	 And I enter Task Value:
          | Task Value |
          | 20 |
     And I choose Select Value from Detail Menu of Craft
	 And I filter table Craft:
		  | Craft | Skill-Level |
		  | TRAINING | SKILLED |
     And I select no. 2 record from Craft table records
	 And I select New Row button under Planned Labor section
	 And I enter Task Value:
          | Task Value |
          | 30 |
     And I choose Select Value from Detail Menu of Craft
	 And I filter table Craft:
		  | Craft | Skill-Level |
		  | TRAINING | SKILLED |
     And I select no. 2 record from Craft table records
     And I save record
	 And I set Job Plan status ACTIVE
	 And I click Ok
	 And I verify status ACTIVE
	 And I take screenshot of Creating new Training Course Job Plans Test Scenario three
	

	Examples:
      | role |
      | cms admin team leader |


Scenario: 04) Delete Training Course Job Plans
      Given I sign as training manager
	  And I open application Job Plans (Tr)
	  And I filter table Job Plans:
		  | Job Plans |
		  | CMS-210 |
      And I select no. 1 record from Job Plans table records
	  And I select delete Job Plans
	  And I press Yes button
	  And I verify Job Plans table has no records
	  And I take screenshot of Creating new Training Course Job Plans Test Scenario four
	

	Examples:
      | role |
      | training manager |


Scenario: 05) Delete Job Plan
     Given I sign as training manager
	 And I open application Job Plans (Tr)
	 And I filter table Job Plans:
		  | Job Plans |
		  | CMS-202 |
     And I select no. 1 record from Job Plans table records
	 And I select delect Job Plan
	 And I select Yes button 
	 And I verify Job Plans table has no records
	 And I take screenshot of Creating new Training Course Job Plans Test Scenario five
	

	Examples:
      | role |
      | training manager |




 






