Feature: 2.0.3 - Creating a Follow On


As a Maintainer Team Leader you want to create a Found it Fixed it Work Order

@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:CreateCMWorkOrder
@allure.label.story:CreateCMWorkOrder
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-203
@allure.label.suite.scenario01.CreateCMWorkOrder
Scenario: 01) Create a CM Work Order
	Given I sign as <role>
	And I open application Work Order Tracking (BRDA)
	And I select create new record
	And I enter work order:
      | Description |
      | FOLLOW ON WORK ORDER TEST |
	And I choose Select Value from Detail Menu of Location field
	And I filter table Location:
      | Location |
      | 387102 |
	And I select no. 1 from Location table records
	And I open Select Value lookup for Work Type field
	And I filter table Work Type:
      | Type |
      | =CM |
	And I select no. 1 from Work Type table records
	And I choose Select Value from Detail Menu of Repair Facility
	And I filter table Repair Facility:
      | Repair Facility |
      | HORNSEY |
	And I select no. 1 record from Repair Facility table records
	And I open Select Value lookup for Priority field
	And I filter table Priority field:
      | Value |
      | Next Exam |
	And I select no. 1 record from Priority table records
	And I Scheduled Start Date to today's date
	And I save CM record
	And I verify generated work order number
	And I take screenshot of Creating a Follow On Work Order Scenario one
		

	Examples:
      | role |
      | maxadmin |



@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:AssigningaCMWorkOrder
@allure.label.story:AssigningaCMWorkOrder
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-203
@allure.label.suite.scenario02.AssigningaCMWorkOrder
 Scenario: 02) Assigning a CM Work Order
 Given I sign as <role>
  And I open application Work Order Tracking BRDA from Favorite Menu
  And I filter table CM Work Order:
      | Description | Status  |
      | FOLLOW ON WORK ORDER TEST | =WAIT-REV |
  And I select no. 1 record from CM Work Order table records
  And I press route the workflow button
  And I set (Radio) field to "Accept this Work Order into the Work Bank"
  And I select dialog button ok
  And I press route the workflow button
  And I set (Radio) field to "Send Work for Execution"
  And I select Ok dialog button
  And I go to Assignments Tab
  And I add new row in Assignments Tab
  And I open Select Value lookup for Labor field
  And I filter table Labor:
      | Labor |
      | ISCOTT |
  And I select no. 2 record from Labor table records
  #And I pree Ok dialog system message button
  And I verify CM work order generated
  And I save record
  And I take screenshot of Creating a Follow On Work Order Scenario two
  
  
   Examples:
      | role |
      | teamlead |




@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:CreatingaFounditFixeditWorkOrder
@allure.label.story:CreatingaFounditFixeditWorkOrder
@allure.label.severity:Trivial
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-203
@allure.label.suite.scenario03.CreatingaFollowOn
Scenario: 03) Creating a Follow On
Given I sign as <role>
	And I open application Quick Work Order Tracking (BRDA)
	And I filter table Quick Work Order:
     | Description | Status | Work Type |
	 | FOLLOW ON WORK ORDER TEST | =SCHEDULED | =CM |
    And I select no. 1 record from Quick Work Order table records
	And I press route the workflow button
    And I set (Radio) field to "Start Work"
    And I select Ok button
	And I select action
	And I select Create Work Order
	And I Select Value lookup for Work Type field
	And I filter table Follow on Work Type:
      | Type |
      | Follow On |
	And I select no. 1 record from Work Type table records
	And I save record
	And I go to failure reporting tab
	And I press the button select Failure Codes
	And I filter table Follow on Failure Codes:
      | Failure Codes |
      | 455-FC-06 |
	And I select faliure codes 
    And I select problem codes 
    And I select cause codes
    And I select remedy codes
	And I go to Log tab
    And I press add new row under Log
	And I enter following data:
      | Summary | Details |
      | CM WO AUTO TEST | CM WORK ORDER AUTO TEST |
	And I open Select Value lookup of Type
	And I filter table work Log:
      | Value |
      | UPDATE |
	And I select no. 1 record from work Log table records
	#And I Select UPDATE
	And Work log Status field has value UPDATE
    And I save record
	And I take screenshot of Creating a Follow On Work Order Scenario three
	

	 Examples:
      | role |
      | teamlead | 
