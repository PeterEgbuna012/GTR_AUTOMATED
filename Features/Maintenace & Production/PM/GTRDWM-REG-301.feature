Feature: 3.0.1 - Generating an Ad Hoc PM Work Order

You need to generate a PM Work Order Ad Hoc out of the frequency sequence.

# Setup scenario
@Feature:GTRDWM-REG-301-GeneratinganAdHocPMWorkOrder
Scenario:01) Create a PM
	Given I sign as <role>
    When I open application Preventive Maintenance, Preventative Maintenance (BRDA)
    And I create new record
    And I enter Description:
      | Description |
      |  AUTO GENERATING PM WORK ORDER   |
    And I choose Select Value from Detail Menu of Asset Group field
    And I filter table Asset Group:
      | Asset Group |
      | UNIT 387102 |
    And I select no. 1 record from Asset table records
    And I enter Lead Time Days:
      | Lead Time Days |
      | 182 |
    And I set Include this PM in the Forecast[Checkbox] field to False
    And I open Select Value lookup for Work Type field
    And I filter table:
      | Work Type |
      | =TXCK |
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
    And I take screenshot of Generating an Ad Hoc PM Work Order test scenario one

	Examples:
      | role        |
      | maxadmin |





	# Setup scenario
  Scenario:02) Generating Ad Hoc PM Work Order
    Given I sign as <role>
    When I open application Preventive Maintenance, Preventative Maintenance (BRDA)
    When I filter table PMs:
      | Description | Status  | Parent |
      | AUTO GENERATING PM WORK ORDER  | =ACTIVE | ~Null~|
    And I select no. 1 record from PMs table
    And I select action Generate Work Orders
    And I set Use Frequency Criteria[Checkbox] field to false
    And I press the button OK
    And the message appears BMXAA3208I
    And I press the button Ok
    And I take screenshot of Generating an Ad Hoc PM Work Order test scenario two

	 Examples:
      | role        |
      | teamlead |
