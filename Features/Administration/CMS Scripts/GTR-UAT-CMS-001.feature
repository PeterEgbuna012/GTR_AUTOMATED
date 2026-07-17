Feature: 0.0.01 - Creation of a Qualification

As a CMS Admin User/Training Manager you need a new qualification to be added in the Qualifications application

@Feature:0.0.01-CreationofaQualification
Scenario: 01) Creation of a Qualification
      Given I sign as <role>
	  And I open application Qualifications
	  And I select New Qualification
	  And I enter Qualifications Details:
		  | Qualification Code | Qualification Description |
		  | AUTO 10 | Qualification for Unit Familiarity |
	  And I open Select Value lookup of Qualification Type field
	  And I select Qualification Type:
	    | Qualification Type |
	    | REFRESH |
      And I select Qualification Type  
      And I set Certificate Required [Checkbox] field to true
	  And I enter Certificate Information:
		  | Evaluation Method | Issuing Authority |
		  | Qualification Testing | Qualification Testing |
      And I select long Description Option
      And I enter Certificate Long Description:
	    | Long Description |
		| This qualification is required to ensure that personnel are familiar with the specific unit and its operation. It covers essential knowledge and skills needed for safe and efficient handling of the unit. |
      And I select ok button of Long Description
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
	  And I take screenshot of Creation of a Qualification Test
	

	Examples:
      | role |
      | training manager |


 Scenario: 02) Delete Qualification
      Given I sign as <role>
	  And I open application Qualifications
	  And I filter table Qualifications:
        | Qualifications |
        | AUTO 10  |
	  And I select no. 1 record from Qualification table records
	  #And I delete Craft Skill-Level
	  #And I save record
	  And I select delete Qualifications
	  And I press Yes dialog button
	  And I verify table has no records
	  And I take screenshot of Delete Qualification Test
	

	Examples:
      | role |
      | training manager |






