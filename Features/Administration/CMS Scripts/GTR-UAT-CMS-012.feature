Feature: 0.0.012 - Labor Skill-Level Check - Update skill-levels

The CMS functionality awards qualifications to delegates on completion of a CMS work order. As part of this process, the system checks the labor record's skill-level to verify whether the qualification should or should not be awarded the qualification (if a craft/skill-level requirement is specified on an individual qualification record)

This guide covers the steps to update or add any skill-levels that need to be checked as part of this system check. This is managed via the Business Rules (BRDB) application. 

NOTE: Skill-levels of SKILLED or SEMI-SKILLED do not need to be added to the business rule as this are automatically checked by the system.

@Feature:0.0.012-LaborSkill-LevelCheck-Updateskill-levels
Scenario: 01) Labor Skill-Level Check - Update skill-levels
       Given I sign as <role>
       And I open application Business Rule (BRDB)
	   And I filter table Business Rule:
          | Business Rule |
          | MXRCMSSKILLLEVEL |
       And I select no. 1 record from Business Rule table records
	   And I select New Row button under the List Values for MXRCMSSKILLLEVEL section
	   And I enter Skill level Details:
		  | Skill level | Description |
		  | NDT | NDT |
	   And I save record
       And I take screenshot of Labor Skill-Level Check - Update skill-levels Test Scenario one
	 	 

	Examples:
      | role |
      | maximo administrator |


Scenario: 02) Deleting Updated skill-levels
       Given I sign as <role>
	   And I open application Business Rule (BRDB)
	   And I filter table Business Rule:
          | Business Rule |
          | MXRCMSSKILLLEVEL |
       And I select no. 1 record from Business Rule table records
	   And I select delete button under the List Values for MXRCMSSKILLLEVEL section
	   And I save record
	   And I verify table skill levels has no records
	   And I take screenshot of Deleting Updated skill-levels Test
	 	 

	Examples:
      | role |
      | maximo administrator |
	 
