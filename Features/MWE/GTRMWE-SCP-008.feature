Feature: 0.0.8 - PM Child Work Order
A short summary of the feature

# Setup scenario
@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:CreateaPreventiveMaintenanceRecord
@allure.label.story:CreateaPreventiveMaintenanceRecord
@allure.label.severity:Trivial
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRMWE-SCP-0.0.8
@allure.label.suite.scenario01.CreateaPreventiveMaintenanceChildRecord
Scenario:01) PM Child Work Order
	Given I sign as <role>
    When I open application Preventive Maintenance, Preventative Maintenance (BRDA)
    And I create new record
    And I enter Description:
      | Description |
      | SON-PM-TEST |
    And I choose Select Value from Detail Menu of Asset Group field
    And I filter table Asset Group:
      | Asset Group |
      | DMOSA-377 |
    And I select no. 1 record from Asset table records
    #And I enter Lead Time Days:
    #  | Lead Time Days |
    #  | 182 |
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
    Then field Status has value DRAFT
    And I take screenshot of PM Child Work Order Task Scenario one

	Examples:
      | role     |
      | maxadmin |




# Setup scenario
@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:CreateaPreventiveMaintenanceRecord
@allure.label.story:CreateaPreventiveMaintenanceRecord
@allure.label.severity:Trivial
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRMWE-SCP-0.0.8
@allure.label.suite.scenario02.CreateaPreventiveMaintenanceParentRecord
 Scenario:02) Create a PM
	Given I sign as <role>
    When I open application Preventive Maintenance, Preventative Maintenance (BRDA)
    And I create new record
    And I enter Description:
      | Description |
      | FATHER-PM-TEST |
    And I choose Select Value from Detail Menu of Asset Group field
    And I filter table Asset Group:
      | Asset Group |
      | DMOSA-377 |
    And I select no. 1 record from Asset table records
    #And I enter Lead Time Days:
    #  | Lead Time Days |
    #  | 182 |
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
    And I go to PM Hierarchy tab
	And I add new row Button in Children PMs section
	And I open Select Value lookup for PM field
    And I filter table Children PM:
      | Description |
      | SON-PM-TEST |
    And I select no. 1 record from Children PM table records
    And I save record
    And I press Change Status button
    And I press the dropdown new status button
    And I select active status
	And I set Roll New Status to All Child PMs[Checkbox] field to True
    And I press dialog button OK
    And I go to PM tab
    Then field Status has value ACTIVE
    And I take screenshot of PM Child Work Order Task Scenario two

	Examples:
      | role     |
      | maxadmin |



@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:GeneratinganAdHocPMWorkOrder
@allure.label.story:GeneratinganAdHocPMWorkOrder
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRMWE-SCP-0.0.8
@allure.label.suite.scenario03.GeneratinganAdHocPMWorkOrder
Scenario:03) Generating Ad Hoc PM Work Order
    Given I sign as <role>
    When I open application Preventive Maintenance, Preventative Maintenance (BRDA)
    When I filter table PMs:
      | Description | Status  | Parent |
      | FATHER-PM-TEST  | =ACTIVE | ~Null~|
    And I select no. 1 record from PMs table
    And I select action Generate Work Orders
    And I set Use Frequency Criteria[Checkbox] field to false
    And I press the button OK
    And the message appears BMXAA3208I
    And I take screenshot of PM Child Work Order Task Scenario three

	 Examples:
      | role     |
      | teamlead |




@allure.label.epic:MaintenanceAndProduction
@allure.label.feature:AssigningaPMWorkOrderTask
@allure.label.story:AssigningaPMWorkOrderTask
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRMWE-SCP-0.0.8
@allure.label.suite.scenario04.AssigningaPMWorkOrderTask
Scenario: 04) Assigning a PM Work Order Task
  Given I sign as <role>
  And I open application Work Order Tracking BRDA from Favorite Menu
  When I filter table PM:
		| Description | Status | Work Type |
		| SON-PM-TEST  | =SCHEDULED | =PM |
  And I select no. 1 record from PMs table
  And I go to Assignments Tab
  And I add new row in Assignments Tab
  And I open Select Value lookup for Labor field
  And I filter Labor table:
      | Labor |
      | ISCOTT |
  And I select no. 2 from Labor table records
  And I save record
  And I take screenshot of PM Child Work Order Task Scenario four

   Examples:
      | role        |
      | teamlead |
