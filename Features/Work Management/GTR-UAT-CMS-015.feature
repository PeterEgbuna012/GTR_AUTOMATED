Feature:  0.0.015 - Creation of Campaigns work order

This procedure defines the creation of Campaigns in the Maximo System

@CreationofCampaignsintheMaximoSystem

Scenario: 01) Creation of a Qualification
      Given I sign as <role>
	  And I open application Qualifications
	  And I select New Qualification
	  And I enter Qualifications Details:
		  | Qualification Code | Qualification Description |
		  | TEST_CMS | Qualification for Unit Familiarity |
	  And I open Select Value lookup of Qualification Type field
	  And I select Qualification Type:
	    | Qualification Type |
	    | REFRESH |
      And I select Qualification Type  
	  And I enter following:
		  | Power Up Parent Qualification | Duration |
		  | TQ0099 | 1 |
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
      And I take screenshot of Creation of Campaigns work order Test Scenario one
	

	Examples:
      | role |
      | training manager |


Scenario: 02) Creating new Training Course Job Plans
     Given I sign as <role>
	 And I open application Job Plans (Tr)
	 And I select New Job Plan
	 And I enter Job Plan:
		  | ID | Description |
		  | CMS_TEST40 | Campaigns Job Plan |
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
          | Creating Campaigns Jo Plan |
	 And I open Select Value lookup of Qualifications field
	 And I select yes dialog button of System Message
	 And I select New Row
	 And I open Select Value lookup of Qualification Requirements field
	 And I filter Qualification Requirements:
          | Qualification |
          | TEST_CMS |
	 And I select no. 1 record from Qualification Requirements table records
	 And I Press Ok dialog button
	 And I save record
	 And I set Qualification status ACTIVE
	 And I click Ok
	 And I verify Job Plans status ACTIVE
	 And I take screenshot of Creation of Campaigns work order Test Scenario two
	 

	Examples:
      | role |
      | cms admin team leader |






  Scenario: 03) Creation of Campaigns in the Maximo System
  Given I sign as <role>
  And I open application Campaigns (Tr)
  And I select New Campaign
  And I enter Campaign Details:
	    | Campaign Description |
	    | Creating Campaigns Test |
  And I select long Description button
  And I enter Campaigns long Description:
	    | Long Description |
	    | Automation Test of Creating Campaigns Work Order |
  And I click button ok
  And I enter Campaign Reference:
	    | Campaign Reference |
	    | Campaigns Test |
  And I open Select Value lookup of priority field
  And I filter table Priority:
        | Priority |
        | Next Exam  |
  And I select no. 1 record from Priority table records
  And I save record
  And I go to tab Work Package
  And I click Select Asset List button
  And I select the Detail Menu of the asset and go to the Asset List (Tr)
  And I filter table Campaigns Asset:
        | Asset |
        | 387-2  |
  And I select no. 1 record from Campaigns Asset table records
  And I select Return With Value option
  And I select the Ok dialog button
  And I select no. 1 record from Work Package table records
  And I select the Detail Menu of the Work Location and go to the Locations (Tr)
  And I filter table Locations:
        | Location |
        | DMOSA - LEVELLING CONTROL ROD - NO.1 BOGIE  |
  And I select no. 1 record from Work Location table records
  And I select Return With Value option
  And I save record
  And I select the Detail Menu of the Job Plans and go to the Job Plans (Tr)
  And I filter table Job Plans:
		| Job Plans |
		| CMS_TEST40 |
  And I select no. 1 record from Job Plans table records
  And I select Return With Value option
  And I select no. 2 record from Work Package table records
  And I select the Detail Menu of the Job Plans and go to the Job Plans (Tr)
  And I filter table Job Plans:
		| Job Plans |
		| CMS_TEST40 |
  And I select no. 1 record from Job Plans table records
  And I select Return With Value option
  And I select no. 3 record from Work Package table records
  And I select the Detail Menu of the Job Plans and go to the Job Plans (Tr)
  And I filter table Job Plans:
		| Job Plans |
		| CMS_TEST40 |
  And I select no. 1 record from Job Plans table records
  And I select Return With Value option
  And I Approved Campaign
  And I press dialog ok button
  And I verify Campaign status
  And I Generate Campaign work order
  And I wait for generate work order to load
  #And I verify work order is generated 
  And I take screenshot of Creation of Campaigns work order Test Scenario three
  And I select Ok buttton of system message
  And I verify work order generated numbers

	

	Examples:
      | role |
      | maxadmin |

