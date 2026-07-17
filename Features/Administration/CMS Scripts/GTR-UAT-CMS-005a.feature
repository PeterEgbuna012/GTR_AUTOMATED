Feature: 0.0.05a - Creating a new Training Course Work Order Template

There is a need to create a new training course work order template (for MC Courses or Annual Assessments).

@Feature:0.0.05a-CreatinganewTrainingCourseWorkOrderTemplate
Scenario: 01) Creation of a Qualification
	  Given I sign as training manager
	  And I open application Qualifications
	  And I select New Qualification
	  And I enter Qualifications Details:
		  | Qualification Code | Qualification Description |
		  | CMS_T5 | Qualification for Unit Familiarity |
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
		  | CMS-108 | New Starter Assessment - Tasks |
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
          | Training Course Job Plans Test |
	 And I open Select Value lookup of Qualifications field
	 And I select yes dialog button of System Message
	 And I select New Row
	 And I open Select Value lookup of Qualification Requirements field
	 And I filter Qualification Requirements:
          | Qualification |
          | CMS_T5 |
	 And I select no. 1 record from Qualification Requirements table records
	 And I Press Ok dialog button
	 And I save record
	 And I set Qualification status ACTIVE
	 And I click Ok
	 And I verify Job Plans status ACTIVE
	 And I take screenshot of Creating a new Training Course Work Order Template Test Scenario one
	 

	Examples:
      | role |
      | cms admin team leader |






Scenario: 03) Creating a new Training Course Work Order Template
	 Given I sign as training manager
	 And I open application Work Order Template (BRDA)
	 And I select new record
	 And I enter Work Order Template Details:
		  | ID | Description |
		  | TEST_CMS5 | New Starter Assessment WO Template |
	 And I choose Select Value from Detail Menu of Asset Group field
	 And I select no. 1 record from Asset Group table records
	 And I open Select Value lookup of Work Type field
	 And I filter Work Type:
          | Work Type |
          | CMS |
	 And I select no. 1 record from Template Work Type table records
	 And I choose Select Value from Detail Menu of Job Plan field
	 And I filter Job Plan:
          | Job Plan |
          | CMS-108|
	 And I select no. 1 record from Job Plan table records
 	 And I set Work Order Template status to ACTIVE
     And I save record
	 And I verify template status ACTIVE
	 And I take screenshot of Creating a new Training Course Work Order Template Test Scenario two
	

	Examples:
      | role |
      | training manager |




Scenario: 04) Delete Training Course Work Order Template
      Given I sign as maxadmin
	  And I open application Work Order Template (BRDA)
	  And I filter table Work Order Template:
		  | ID |
		  | TEST_CMS5 |
      And I select no. 1 record from Work Order Template table records
	  And I select delete Work Order Template record
	  And I select Yes button
	  And I verify Work Order Template table has no records
	  And I take screenshot of Creating a new Training Course Work Order Template Test Scenario three


	Examples:
      | role |
      | maxadmin |





Scenario: 05) Delete Job Plan
     Given I sign as training manager
	 And I open application Job Plans (Tr)
	 And I filter table Job Plans:
		  | Job Plans |
		  | CMS-108 |
     And I select no. 1 record from Job Plans table records
	 And I select delect Job Plan
	 And I select Yes button 
	 And I verify Job Plans table has no records
	 And I take screenshot of Creating a new Training Course Work Order Template Test Scenario four
	 

	Examples:
      | role |
      | training manager |

	  	  	  