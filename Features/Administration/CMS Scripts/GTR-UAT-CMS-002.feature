Feature: 0.0.02 - Association of a Qualification to a Labour Record

As a CMS Admin user/Training Manager, there is a need to associate a Qualification to a Labor record

# Setup scenario
@allure.label.epic:CMS
@allure.label.feature:PowerUps-Initialsetup
@allure.label.story:PowerUps-Initialsetup
@allure.label.severity:Critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.02
@allure.label.suite.scenario01.CreationofaQualification
Scenario: 01) Creation of a Qualification
	  Given I sign as training manager
	  And I open application Qualifications
	  And I select New Qualification
	  And I enter Qualifications Details:
		  | Qualification Code | Qualification Description |
		  | CMS_10 | Qualification for Unit Familiarity |
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
	  And I select New Row under the Required Craft and Skill Level section
	  And I choose Select Value from Detail Menu of Craft field
	  And I filter table Craft and Skill Level:
		  | Craft | Skill-Level |
		  | TRAINING | SEMI-SKILLED |
      And I select no. 1 record from Craft and Skill Level table records
	  And I save record
	  And I take screenshot of Craft Skill Level
	  And I delete Craft Skill-Level
	  And I save record
	  And I verify status is ACTIVE
	  #And I select Ok Button
	  And I take screenshot of Association of a Qualification to a Labour Record test
	

	Examples:
      | role |
      | training manager |




# Setup scenario
@allure.label.epic:CMS
@allure.label.feature:AssociationofaQualificationtoaLabourRecord
@allure.label.story:AssociationofaQualificationtoaLabourRecord
@allure.label.severity:Critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.02
@allure.label.suite.scenario02.AssociationofaQualificationtoaLabourRecord
Scenario: 02) Association of a Qualification to a Labour Record
	  Given I sign as cms admin
	  And I open application Labor
	  And I filter table labor:
      | labor |
      | ARICHARDS  |
	  And I select no. 1 record from labor table records
	  And I go to Qualifications tab
	  And I select New Row Button
	  And I choose Select Value from Detail Menu of Qualification field
	  And I filter table Qualification:
      | Qualification |
      | CMS_10  |
	  And I select no. 1 record from Qualification table record
      And I save record
	  And I take screenshot of Association of a Qualification to a Labour Record
	

	Examples:
      | role |
      | cms admin |


# Cleanup scenario
@allure.label.epic:CMS
@allure.label.feature:SetQualificationInactive
@allure.label.story:SetQualificationInactive
@allure.label.severity:Critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.02
@allure.label.suite.scenario03.SetQualificationInactive
@Ignore
Scenario: 03) Set Qualification Inactive
      Given I sign as maxadmin
	  And I open application Labor
	  And I filter table labor:
      | labor |
      | ARICHARDS  |
	  And I select no. 1 record from labor table records
	  And I go to Qualifications tab
	  And I select the filter option
	  And I filter Qualification table:
      | Qualification |
      | CMS_10  |
	  And I select no. 1 from Qualification table records
	  And I set qualifications status inactive
	  And I select Ok Button
	  And I verify status is INACTIVE
	  And I save record
	  And I take screenshot of Set Qualification Inactive
	

	Examples:
      | role |
      | maxadmin |


