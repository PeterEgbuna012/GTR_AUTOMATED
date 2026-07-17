Feature: GTR-UAT-TAS-012 - Toilet Checker Email Notification to Downstream Locations with Turnaround Capability and Stop Time Over 10 Minutes

An email notification is sent to downstream locations with turnaround capability and a stop time over 10 minutes to review and address reported issues.

@Feature:GTR-UAT-TAS-012-ToiletCheckerEmailNotificationtoDownstreamLocationswithTurnaroundCapabilityandStopTimeOver10Minutes
Scenario: 01) Toilet Checker Email Notification to Downstream Locations with Turnaround Capability and Stop Time Over 10 Minutes
	Given I sign as <role>
	And I open application Toilet Checker (MXR)
	 And I filter table Toilet Checker:
      | Toilet Checker |
      | 171812 |
    And I select no. 1 record from Toilet Checker table records
	And I select View Details arrow
	And I verify toilet number
	And I verify toilet description
	And I verify toilet Status
	And I verify toilet unavailability reason
	And I verify toilet locked
	And I verify toilet checked date
	And I select the Close Details arrow
	And I take screenshot of View Toilet Status Test
	And I open application Service Management (BRDF)
	And I filter table Service Management:
       | Yard Asset |
       | SELHURST-YARD |
	And I select no.1 record Service Management table records
	And I filter table Unit:
       | Unit |
       | 171812 |
	And I select no.1 record Unit table records
	And I view Unit record
	And I verify Unit Run Number
	And I copy <Unit Run Number>
	And I press dialog button OK 
	And I open application Diagrams (BRDF)
	And I filter table Diagrams:
       | Status |
       | =ACTIVE |
	And I select no.1 record Diagrams table records
	And I select Filter Table option
	And I set Diagram ID field to <Unit Run Number>
	And I select no.1 record Diagram ID records to view details
	And I select no.1 record Diagram legs records to view details 
	And I take screenshot of Diagram Lines details
	And I open application Business Rules (BRDB)
	And I filter table Business Rules (BRDB):
      | Business Rules |
      | MXRMAILLIST |
   And I select no. 1 record from Business Rules table records
   And I filter table MXRMAILLIST:
       | MXRMAILLIST |
       | LNDNBDC |
   And I select no. 1 record from MXRMAILLIST table records
   And I add following details:
		|  Email |
		| peter.egbuna@arcadis.com |
   And I save record
   And I take screenshot of added email details
   And I open application Toilet Checker (MXR)
   And I filter table Toilet Checker:
      | Toilet Checker |
      | 171812 |
    And I select no. 1 record from Toilet Checker table records
	And I Unchecked the Needs Checking box
	And I save record
	And I take screenshot of Unchecked the Needs Checking box
	And I checked the Needs Checking box
	And I save record
	And I take screenshot of Checked the Needs Checking box


	Examples:
      | role |
      | clean master |



Scenario: 02) Modify Email Notification to Downstream Locations with Turnaround Capability and Stop Time Over 10 Minutes
	Given I sign as <role>
	And I open application Business Rules (BRDB)
	And I filter table Business Rules (BRDB):
      | Business Rules |
      | MXRMAILLIST |
   And I select no. 1 record from Business Rules table records
   And I filter table MXRMAILLIST:
       | MXRMAILLIST |
       | LNDNBDC |
   And I select no. 1 record from MXRMAILLIST table records
   And I add following details:
		|  Email |
		| lightbridge.londonbridge@gtrailway.com, London.bridge@churchillservices.com |
   And I save record
   And I take screenshot of Modify Email details


   Examples:
      | role |
      | clean master |
