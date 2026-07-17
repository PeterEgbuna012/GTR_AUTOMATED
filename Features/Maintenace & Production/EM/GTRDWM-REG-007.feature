Feature: 0.0.7 - Approving an EM Work Order


You are reviewing Completed Work in your start centre and want to approve it

@Feature:0.0.7-ApprovinganEMWorkOrder
Scenario: 01) Create a EM Work Order
	Given I sign as <role>
	When I open application Work Orders, Fault Reporting (BRDA)
    And I create new record
    And I choose Select Value from Detail Menu of Location field
    And I filter table Location:
      | Location |
      | 377458 |
    And I select no. 1 record from Location table records
    And I open Select Value lookup for Failure Group field
    And I select no. 1 record from Failure Group table
    And I open Select Value lookup for Failure Code field
    And I select no. 1 record from Failure Code table
    And I open Select Value lookup for Problem Code field
    And I select no. 1 record from Problem Code table
    And I open Select Value lookup for Repair Facility field
    And I filter table Repair Facility:
      | Repair Facility |
      | BRIGHTON |
	And I select no. 1 record from Repair Facility table
    And I open Select Value lookup for Reported Priority
    And I filter table Reported Priority:
      | Reported Priority |
      | P12 Unit Stopped on Depot |
    And I select no. 1 record from Reported Priority table
    And I enter following data to Headcode:
      | Headcode |
      | TAUTO|
    And I enter following data:
      | Summary | Details |
      | Approving an EM Work Order | AUTO TEST EM WORK ORDER |
    And I route the workflow
    #And I press Ok button
    And I press dialog button of Show Duplicate Tickets
    And I route the workflow
    And I set (Radio) field to "Raise a Depot Work Order"
    Then I press dialog button OK
    When I go to Related Records tab
    And I view Related Work Order
    Then field Status has value WAIT-REV
    And I take screenshot of Approving an EM Work Order scenario one


	  Examples:
      | role |
      | teamlead | 




Scenario:  02) Accepting An EM Work Order into the Work Bank
	 Given I sign as <role>
	 And I open application Work Order Tracking BRDA from Fav Menu
     When I filter table EM:
		| Description | Status | Work Type |
		| Approving an EM Work Order | =WAIT-REV | =EM |
    And I select no. 1 record from EM table
    And I press route the workflow button
	And I set (Radio) field to "Accept this Work Order into the Work Bank"
	And I press OK dialog button
	And  work order Status field has value REVIEWED
	And I take screenshot of Approving an EM Work Order scenario two


	 Examples:
      | role |
      | teamlead | 




Scenario: 03)  Assigning an EM Work Orderr
	Given I sign as <role>
	  And I open application Work Order Tracking BRDA from Fav Menu
      When I filter table EM:
		| Description | Status | Work Type |
		| Approving an EM Work Order | =REVIEWED | =EM |
     And I select no. 1 record from EM table
     And I go to Assignment tab
	 And I press add new row under Assignments tab
	 And I select Value lookup for Labor field
     And I filter table labor:
      | labor |
      | ABRACE |
	 And I select no.2 from labor table record
	 And I save
	 And I press route the workflow button
	 And I set (Radio) field to "Send Work For Execution"
	 And I click OK dialog button
	 And I verify Status field has value SCHEDULED
	 And I take screenshot of Approving an EM Work Order scenario three

	 Examples:
      | role  |
      | teamlead | 


Scenario: 04) Completing an EM Work Order for Review
	Given I sign as <role>
	And I open application Quick Work Order BRDA from Fav Menu
    When I filter table Quick Work Order:
		| Description | Status | Work Type |
		| Approving an EM Work Order | =SCHEDULED | =EM |
    And I select no. 1 record from EM table
	And I press route the workflow button
	And I set (Radio) field to "Start Work order"
	And I press dialog Ok
	And I press route the workflow button
	And I set (Radio) field to "Complete Work Assignment"
	And I press dialog Ok
	And I press dialog button close
	And I go to labor tab
	And I press add new row button
	And I choose Select Value from Detail Menu labor field
     And I filter table Record labor:
      | Labor |
      | ABRACE |
	And I select no. 2 record from labor table records
	And I set labor Start and End time
	And I save
	And I press route the workflow button
	And I press route the workflow button
	And I set (Radio) field to "Complete Work Assignment"
	And I press dialog Ok
    And I press dialog button close
    And I go to Failure Reporting Tab
    And I press the button Select Failure Codes
    #And I filter table Failure Codes:
      #| Failure Codes |
      #| 171-FC-01 |
	And I select Faliure Informations
	And I go to Log Tab
    And I add new row Button
    And I enter following:
      | Summary       | Details |
      | Approving an EM Work Order | COMPLETE EM WORK ORDER AUTO TEST |
    And I save
    And I press route the workflow button
    And I press route the workflow button
    And I set (Radio) field to "Complete Work Assignment"
    And I Click dialog Ok button
    And I Status field has value COMP-WREV
    And I take screenshot of Approving an EM Work Order test scenario four

    Examples:
      | role |
      | Maintainer | 


Scenario: 05) Approving an EM Work Order
	Given I sign as <role>
	And I open application Work Order Tracking BRDA from Fav Menu
    When I filter table EM:
		| Description | Status | Work Type |
		| Approving an EM Work Order | =COMP-WREV | =EM |
    And I select no. 1 record from EM table
	And I press route the workflow button
	And I set (Radio) field to "Approve Work Order"
	And I press OK button
	And I Status field has value COMP
	And I take screenshot of Approving an EM Work Order test scenario five


	Examples:
      | role     |
      | teamlead | 

