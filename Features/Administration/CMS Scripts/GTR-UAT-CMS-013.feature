Feature: 0.0.013 - Power Ups - Initial set up

The CMS functionality awards qualifications to delegates on completion of a CMS work order. As part of this process, the system checks the qualifications to determine whether or not a qualification is a Power up qualification, or if the qualification is a child of a Power up qualification. The following logic is applied when the system detects that there are Power up or Power up child qualifications when completing a course.

For non MC related courses, on COMP-PASS a new power Up Parent qualification will not get added, however will get updated if they currently already have it
For non MC related courses, on COMP-PASS a new child qualification that has a Power up parent will not get added, but will get updated if they already have it (based on their current Annual Assessment end date)
If a Power up Parent qualification expires/COMP-FAIL then the children will also expire
If a Power up parent qualification is renewed (COMP-PASS), the expired children from the above will get their end dates updated again (the end date is based on their Annual Assessment end date)
If a child qualification is specifically set to COMP-FAIL on a course, then the Failed Power Up? flag is checked in the Labor application, and this will not get renewed unless this is unchecked by a CMS Trainer/admin within the Labor application


This guide covers the steps to create a Power up qualification as well as setting a qualification to have a Power up parent. This is managed via the Business Rules (BRDB) application and the Qualifications application.

@Feature:0.0.013-PowerUps-Initialsetup
Scenario: 01) Power Ups - Initial set up
	   Given I sign as <role>
	   And I open application Business Rule (BRDB)
	   And I filter table Business Rule:
          | Business Rule |
          | MXRCMSPOWERUPS |
       And I select no. 1 record from Business Rule table records
	   And I select New Row button under the List Values for MXRCMSPOWERUPS section
	   And I enter MXRCMSPOWERUPS Details:
		  | ID | Description |
		  | TQ1099 | 313/313 Power Up |
	   And I save record
	   And I take screenshot of Power Ups
	   And I open application Qualifications
	   And I filter table Qualifications Description:
          | Qualifications |
          | Power Up  |
	   And I select no. 1 record from Qualification table records
	   And I enter Parent Qualification:
          | Parent Qualification |
          | TQ0099  |
	   And I save record
	   And I take screenshot of Power Ups - Initial set up Test

	 	 
	Examples:
      | role |
      | maximo administrator |




Scenario: 02) Deleting Updated skill-levels
	   Given I sign as <role>
       And I open application Business Rule (BRDB)
	   And I filter table Business Rule:
          | Business Rule |
          | MXRCMSPOWERUPS |
       And I select no. 1 record from Business Rule table records
	   And I filter table MXRCMSPOWERUPS:
          | MXRCMSPOWERUPS |
          | TQ1099 |
	   And I delete MXRCMSPOWERUPS record
	   And I save record
	   And I verify table skill levels has no records
	   And I take screenshot of Deleting skill-levels Test
	 	 
	Examples:
      | role |
      | maximo administrator |