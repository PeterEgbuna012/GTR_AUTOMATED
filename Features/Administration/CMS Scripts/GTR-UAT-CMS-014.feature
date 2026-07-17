Feature: 0.0.014 - Power Ups - Managing failed Power Ups

The CMS functionality awards qualifications to delegates on completion of a CMS work order. As part of this process, the system checks the qualifications to determine whether or not a qualification is a Power up qualification, or if the qualification is a child of a Power up qualification. The following logic is applied when the system detects that there are Power up or Power up child qualifications when completing a course.

For non MC related courses, on COMP-PASS a new power Up Parent qualification will not get added, however will get updated if they currently already have it
For non MC related courses, on COMP-PASS a new child qualification that has a Power up parent will not get added, but will get updated if they already have it (based on their current Annual Assessment end date)
If a Power up Parent qualification expires/COMP-FAIL then the children will also expire
If a Power up parent qualification is renewed (COMP-PASS), the expired children from the above will get their end dates updated again (the end date is based on their Annual Assessment end date)
If a child qualification is specifically set to COMP-FAIL on a course, then the Failed Power Up? flag is checked in the Labor application, and this will not get renewed unless this is unchecked by a CMS Trainer/admin within the Labor application


This guide covers the steps to reactivate a failed Power up qualification. This is managed via the Business Rules (BRDB) application and the Qualifications application.
@Ignore
@Feature:0.0.014-PowerUps-ManagingfailedPowerUps
Scenario: Power Ups - Managing failed Power Ups
	   Given I sign as <role>
	   And I open application Labor
	   And I filter table labor:
           | labor |
           | ARICHARDS  |
	   And I select no. 1 record from labor table records
	   And I go to Qualifications tab
       And I set (Radio) field Uncheck all Power Up Fail to false
	   And I save record
	   And I take screenshot of Power Ups - Managing failed Power Ups Test
	 	 
	Examples:
      | role |
      | maximo administrator |
