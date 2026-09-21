Feature: 0.0.2 - Assigning a PM Work Order Task With Tasks Assignment

AS a Team Leader you need to Assign A single PM Work Order where there is no planned labour requirement generating an assignment.


# Setup scenario
@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:CreateaPM
@allure.label.story:CreateaPM
@allure.label.severity:Trivial
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRMWE-SCP-0.0.2
@allure.label.suite.scenario01.CreateaPM
 Scenario:01) Create a PM
	Given I sign as <role>
    When I open application Preventive Maintenance, Preventative Maintenance (BRDA)
    And I create new record
    And I enter Description:
      | Description |
      | MWE 1.12.2 RELEASE TEST |
    And I choose Select Value from Detail Menu of Asset Group field
    And I filter table Asset Group:
      | Asset Group |
      | DMOSA-377 |
    And I select no. 1 record from Asset table records
    And I enter Lead Time Days:
      | Lead Time Days |
      | 182 |
    And I set Include this PM in the Forecast[Checkbox] field to False
    And I open Select Value lookup for Work Type field
    And I filter table:
      | Work Type |
      | =PM   |
    And I select no.1 record PM from table
    And I enter data to following:
      | Priority | Owner Group |
      | 6 | RS |
    And I set Interruptible [Checkbox] field to true
    And I enter GL Account:
      | GL Account |
      | 00000-00000-0000 |
    And I save record
    And I press Change Status button
    And I press the dropdown new status button
    And I select active status
	And I set Roll New Status to All Child PMs[Checkbox] field to True
    And I press dialog button OK
    Then field Status has value ACTIVE
    And I take screenshot of Assigning a PM Work Order Task Scenario one

	Examples:
      | role        |
      | maxadmin |



@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:GeneratinganAdHocPMWorkOrder
@allure.label.story:GeneratinganAdHocPMWorkOrder
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRMWE-SCP-0.0.2
@allure.label.suite.scenario02.GeneratinganAdHocPMWorkOrder
Scenario:02) Generating Ad Hoc PM Work Order
    Given I sign as <role>
    When I open application Preventive Maintenance, Preventative Maintenance (BRDA)
    When I filter table PMs:
      | Description | Status  | Parent |
      | MWE 1.12.2 RELEASE TEST | =ACTIVE | ~Null~|
    And I select no. 1 record from PMs table
    And I select action Generate Work Orders
    And I set Use Frequency Criteria[Checkbox] field to false
    And I press the button OK
    And the message appears BMXAA3208I
    And I take screenshot of Assigning a PM Work Order Task Scenario two
    And I press the button Ok
    

	 Examples:
      | role        |
      | teamlead |


@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:AssigningaPMWorkOrderTask
@allure.label.story:AssigningaPMWorkOrderTask
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRMWE-SCP-0.0.2
@allure.label.suite.scenario03.AssigningaPMWorkOrderTask
Scenario: 03) Assigning a PM Work Order Task
  Given I sign as <role>
  And I open application Work Order Tracking BRDA from Favorite Menu
  When I filter table PM:
	 | Description | Status | Work Type |
	 | MWE 1.12.2 RELEASE TEST | =SCHEDULED | =PM |
  And I select no. 1 record from PMs table
  And I go to Plans tab
  And I press add new row under Task for work order section
  And I enter Task Description:
     | Description |
	 | COMMENTS   |
  And I open Select Value lookup for Task Requires Tools or Comments field
  And I select Y
  And I press add new row under Task for work order section
  And I enter Task Description:
     | Description |
     | METERS   |
  #And I choose Select Value from Detail Menu of Measurement Point field
  And I open Select Value lookup for Measurement Point field
  And I filter table Measurement Point:
     | Measurement Point |
	 | P000031 |
  And I select no. 1 record from Measurement Point table
  And I go to Assignments Tab
  And I add new row in Assignments Tab
  And I open Select Value lookup for Labor field
  And I filter Labor table:
     | Labor |
     | ISCOTT |
  And I select no. 2 from Labor table records
  And I save record
  And I take screenshot of Assigning a PM Work Order Task Scenario three

   Examples:
      | role     |
      | teamlead |
