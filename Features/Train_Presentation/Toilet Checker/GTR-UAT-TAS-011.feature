Feature: GTR-UAT-TAS-011 - Email notification to TOC for change of status for toilet asset

A short summary of the feature

@Feature:GTR-UAT-TAS-011-EmailnotificationtoTOCforchangeofstatusfortoiletasset
Scenario: 01) Email notification to TOC for change of status for toilet asset
	Given I sign as <role>
	And I open application Business Rules (BRDB)
	And I filter table Business Rules (BRDB):
      | Business Rules |
      | MXRSANDMANAGEMENTAREA1 |
   And I select no. 1 record from Business Rules table records
   And I select no. 1 record to view detials
   And I add Email Details:
      | Email |
      | peter.egbuna@arcadis.com |
   And I save record
   And I open application Toilet Checker (MXR)
   And I filter table Toilet Checker:
      | Toilet Checker |
      | 377113 |
   And I select change toilet asset statuse button
   And I Click on the status dropdown
   And I select unavailable
   And I filter table Toilet Unavailable Reason:
     | Toilet Checker |
     | Water Tank Empty |
   And I press button ok
   And I select View Details arrow
   And I verify toilet number
   And I verify toilet description
   And I verify toilet Status
   And I verify toilet unavailability reason
   And I verify toilet checked date
   And I take screenshot of Email notification to TOC for change of status for toilet asset test


	   Examples:
      | role |
      | maxadmin |


Scenario: 02) Modify Email notification to TOC for change of status for toilet asset
	Given I sign as <role>
	And I open application Business Rules (BRDB)
	And I filter table Business Rules (BRDB):
      | Business Rules |
      | MXRSANDMANAGEMENTAREA1 |
   And I select no. 1 record from Business Rules table records
   And I select no. 1 record to view detials
   And I add Email Details:
      | Email |
      | peter.egbuna@arcadis.com |
   And I save record
   And I take screenshot of Modify Email notification to TOC for change of status for toilet asset test


Examples:
	| role     |
	| maxadmin |

