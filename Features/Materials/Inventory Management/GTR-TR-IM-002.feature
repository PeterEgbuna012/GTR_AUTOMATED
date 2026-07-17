Feature: 0.0.2 - Issue Rotating Assets to a Work Order

As a Stores Person Issue Rotating Items to a Work Order, specifying the unique assets that have been issued.

@Feature:0.0.2-IssueRotatingAssetstoaWorkOrder
Scenario Outline: 01) Raising a Fault
    Given I sign as Fault Analyst
    When I open application Work Orders, Fault Reporting (BRDA)
    And I create new record
    And I choose Select Value from Detail Menu of Location field
    And I select no. 3 record from Location table records
    And I open Select Value lookup for Failure Group field
    And I select no. 3 record from Failure Group table
    And I open Select Value lookup for Failure Code field
    And I select no. 1 record from Failure Code table
    And I open Select Value lookup for Problem Code field
    And I select no. 1 record from Problem Code table
    And I open Select Value lookup for Repair Facility field
    And I select no. 1 record from Repair Facility table
    And I open Select Value lookup for Reported Priority
    And I select no. 1 record from Reported Priority table
    And I enter following data to Headcode:
      | Headcode |
      | TAUTO|
    And I enter following data:
      | Summary | Details |
      | Issue Rotating Assets to a Work Order | Issue Rotating Assets to a Work Order Test |
    And I route the workflow
    And I press dialog button of Show Duplicate Tickets
    #And I press Ok button 
    And I route the workflow
    And I set (Radio) field to Raise a Depot Work Order
    Then I press dialog button OK
    When I go to Related Records tab
    And I view Related Work Order
    Then field Status has value WAIT-REV
    Then Relationship field has value FOLLOWUP
    And I take screenshot of Fault Work Order
    

    Examples:
      | role  |
      | Fault Analyst |

      Scenario:  02) Accepting An EM Work Order into the Work Bank
	 Given I sign as teamlead
	 And I open application Work Order Tracking BRDA from Fav Menu
     When I filter table EM:
		| Description | Status | Work Type |
		| Issue Rotating Assets to a Work Order | =WAIT-REV | =EM |
    And I select no. 1 record from EM table
    And I press route the workflow button
	And I set (Radio) Box to Accept this Work Order into the Work Bank
	And I press OK dialog button
	And  work order Status field has value REVIEWED
	And I take screenshot of Completing an EM Work Order for Review scenario two


	 Examples:
      | role |
      | teamlead | 




Scenario: 03)  Assigning an EM Work Orderr
	Given I sign as teamlead
	  And I open application Work Order Tracking BRDA from Fav Menu
      When I filter table EM:
		| Description | Status | Work Type |
		| Issue Rotating Assets to a Work Order | =REVIEWED | =EM |
     And I select no. 1 record from EM table
     And I go to Assignment tab
	 And I press add new row under Assignments tab
	 And I select Value lookup for Labor field
     And I filter table labor:
      | labor |
      | ABRACE |
	 And I select no.2 from labor table record
	 And I pree Ok dialog system message button
	 And I save
	 And I press route the workflow button
	 And I set (Radio) Box to Send Work For Execution
	 And I click OK dialog button
	 And I verify Status field has value SCHEDULED
	 And I take screenshot of Completing an EM Work Order for Review scenario three

	 Examples:
      | role  |
      | teamlead | 


Scenario: 04) Completing an EM Work Order for Review
	Given I sign as Maintainer
	And I open application Quick Work Order BRDA from Fav Menu
    When I filter table Quick Work Order:
		| Description | Status | Work Type |
		| Issue Rotating Assets to a Work Order | =SCHEDULED | =EM |
    And I select no. 1 record from EM table
	And I press route the workflow button
	And I set (Radio) Box to Start Work order
	And I press dialog Ok
	And I press route the workflow button
	And I set (Radio) Box to Complete Work Assignment
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
	And I set (Radio) Box to Complete Work Assignment
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
      | Issue Rotating Assets to a Work Order | Issue Rotating Assets to a Work Order Test |
    Then the record is saved successfully
    And I press route the workflow button
    And I press route the workflow button
    And I set (Radio) Box to Complete Work Assignment
    And I Click dialog Ok button
    And I Status field has value COMP-WREV
    And I take screenshot of Completing an EM Work Order for Review test scenario four

    Examples:
      | role     |
      | Maintainer | 





Scenario: 05) Issue Rotating Assets to a Work Order
      Given I sign as stores
	  And I open application Inventory Usage from Fav Menu
	  And I select create New Inventory usage
	  And I enter asset description:
		| Asset Description  |
		| Issue Rotating Assets to a Work Order |
	  And I choose Select Value from Detail Menu for Storeroom field
	  And I filter table Storeroom:
		| Storeroom  |
		| SL-Z-VALUE |
      And I select no. 1 record from Storeroom table record
	  And I save record
	  And I select New Row button under the Usage Lines
	  And I set Usage Type field to ISSUE
	  And I choose Select Value from Detail Menu for Item field
	  And I filter table Item:
		| Item  |
		| 093/051329 |
      And I select no. 1 record from Item table records
	  And I choose Select Value from Detail Menu of Work Order Field
	  And I filter work Order table:
        | Work Order Description |
        | Issue Rotating Assets to a Work Order |
      And I wait for Work order records 
      And I select no. 1 from work Order table record
	  And I save record
	  And I select Change status 
	  And I select Complete from dropdown menu option of New Status field
	  And I set (Radio) field to Use the default stage bin for each inventory item
	  And I press the dialog button OK
	  And I select New Row button under Select Rotating Assets Section
	  And I open Select Value lookup for Asset field
	  And I select no. 1 record from Rotating Asset table record
	  #And I verify Asset serial number
	  And I click the dialog button OK
	  And Rotating Assets Status field has value COMPLETE
	  And I open application Assets
	  And I filter Asset table:
	  	| Asset  |
		| MAT-ASS-2726 |
	  And I select no. 1 record from asset table records
	  And I take screenshot of  Issue Rotating Assets to a Work Order test
	  And I return to Maintainer Start Center

	  Examples:
      | role  |
      | store |
	
