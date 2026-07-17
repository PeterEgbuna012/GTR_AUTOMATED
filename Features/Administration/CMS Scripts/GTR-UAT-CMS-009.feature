Feature: 0.0.09 - Executing a Training Course Assessment


To execute a training course assessment to either pass or fail tasks (for qualifications) or mark the training course assessment as unattended or unallocated.

@Feature:0.0.09-ExecutingaTrainingCourseAssessment
Scenario: 01) Creation of a Qualification
	  Given I sign as training manager
	  And I open application Qualifications
	  And I select New Qualification
	  And I enter Qualifications Details:
		  | Qualification Code | Qualification Description |
		  | QUF20 | Executing a Training Course Assessment |
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
		  | CMS-200 | Executing a Training Course Assessment Test - Tasks |
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
          | Executing a Training Course Assessment Test |
	 And I open Select Value lookup of Qualifications field
	 And I select yes dialog button of System Message
	 And I select New Row
	 And I open Select Value lookup of Qualification Requirements field
	 And I filter Qualification Requirements:
          | Qualification |
          | QUF20 |
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



Scenario: 03) Creating a new Training Course Work Order
    Given I sign as maxadmin
	And I open application Work Order Tracking (BRDA)
	And I select create new record
	And I enter work order:
      | Description |
      | Executing a Training Course Assessment WO |
	And I choose Select Value from Detail Menu of Location field
	And I filter table Location:
      | Location |
      | HORNSEY |
	And I select no. 1 from Location table records
	And I set Work Type field:
	  | Work Type |
		| CMS |
	And I Scheduled Start Date to today's date
	And I go to Plans tab
	And I select New Row button under Children of Work Order
	And I enter Children of Work Order details:
      | Description |
      | Executing a Training Course Assessment WO |
    And I choose Select Value from Detail Menu of Children Work Order Location field
	And I filter table Children Work Order Location:
      | Location |
      | HORNSEY |
	And I select no. 1 from Children Work Order Location table records
	And I enter Estimated Duration:
      | Estimated Duration |
      | 2:00 |
	And I select New Row button under Task for Work Order
	And I enter Task details:
      | Description |
      | Executing a Training Course Assessment WO |
	And I select New Row button under Task for Work Order
	And I enter Task details:
      | Description |
      | Executing a Training Course Assessment WO | 
	And I save record
	And I verify work order status WAIT-REV
	And I take screenshot of Creating a new Training Course Work Order test
	And I return to Maintainer Start Center
	
	

	Examples:
      | role |
      | maxadmin |



Scenario: 04) Scheduling a Training Course Assessment
	Given  I sign as cms admin
    And I open application CMS Course Work Order (MXR)
	And I filter table CMS Course Work Order (MXR):
	  | Description | Status |
	  | Executing a Training Course Assessment WO | =WAIT-REV |
	And I select no. 1 from CMS Course Work Order table records
	And I select route work flow button
	And I set (Radio) field to Set the work order to SCHEDULED
	And I select dialog ok button of System Message
	And I take screenshot of Scheduling a Training Course Assessment

	Examples:
      | role |
      | cms admin |



Scenario: 05) Executing a Training Course Assessment
	Given  I sign as cms admin
    And I open application CMS Course Work Order (MXR)
	And I filter table CMS Course Work Order (MXR):
	  | Description | Status |
	  | Executing a Training Course Assessment WO | =SCHEDULED |
	And I select no. 1 from CMS Course Work Order table records
	And I complete Child Tasks
	And I fail Child Tasks
	And I take screenshot of Executing a Training Course Assessment
	And I select change Delegates status button
	And I select Qualification Passed from dropdown menu options
	And I select dialog ok button of System Message
	And I take screenshot of Executing a Training Course Assessment - Qualification Passed

	Examples:
      | role |
      | cms admin |