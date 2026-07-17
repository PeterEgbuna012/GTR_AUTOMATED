Feature: 3.0.5 - Reject a PM Work Order Task


As a Team Leader you need to reject work which was completed by your team

@Feature:3.0.5-RejectaPMWorkOrderTask
Scenario: 01) Create a PM Work Order Record
	Given I sign as <role>
    When I open application Preventive Maintenance, Preventative Maintenance (BRDA)
    And I create new record
    And I enter Description:
      | Description |
      | AUTO REJECT PM WO |
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
      | =M1 |
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
    And I take screenshot of Reject a PM Work Order Task scenario one

	Examples:
      | role        |
      | maxadmin |



  Scenario:02) Generating Ad Hoc PM Work Order
    Given I sign as <role>
    When I open application Preventive Maintenance, Preventative Maintenance (BRDA)
    When I filter table PMs:
      | Description | Status  | Parent |
      | AUTO REJECT PM WO | =ACTIVE | ~Null~ |
    And I select no. 1 record from PMs table
    And I select action Generate Work Orders
    And I set Use Frequency Criteria[Checkbox] field to false
    And I press the button OK
    And the message appears BMXAA3208I
    And I take screenshot of Reject a PM Work Order Task Scenario two
    And I press the button Ok
    

	 Examples:
      | role        |
      | teamlead |


Scenario: 03) Assigning a PM Work Order Task
  Given I sign as <role>
  And I open application Work Order Tracking BRDA from Favorite Menu
  When I filter table PM:
		| Description | Status | Work Type |
		| AUTO REJECT PM WO | =SCHEDULED | =M1 |
  And I select no. 1 record from PMs table
  And I go to Assignments Tab
  And I add new row in Assignments Tab
  And I open Select Value lookup for Labor field
   And I filter Labor table:
      | Labor |
      | ISCOTT | 
  And I select no. 2 from Labor table records
  And I save record
  And I take screenshot of Reject a PM Work Order Task Scenario three

   Examples:
      | role        |
      | teamlead |


Scenario: 04) Complete a PM Work Order Task
 Given I sign as <role>
  And I open application Work Order Tracking BRDA from Favorite Menu
  When I filter table PM:
		| Description | Status | Work Type |
		| AUTO REJECT PM WO | =SCHEDULED | =M1 |
  And I select no. 1 record from PMs table
  And I press route the workflow button
  And I set (Radio) field to "Start Work"
  And I press Ok dialog button
  And I return to Maintainer Start Center
  And I open application Work Order Tracking BRDA from Favorite Menu
  When I filter table PM:
		| Description | Status | Work Type |
		| AUTO REJECT PM WO | =INPRG | =M1 |
  And I select no. 1 record from PMs table
  And I press route the workflow button
  And I set (Radio) field to "Complete Work Assignment"
  And I press dialog button Ok
  And I press dialog button Close
  And I go to Tab actuals
  And I add new row in Labor Tab
  And I choose select Value from Detail Menu of Labor field
  And I filter table Labor:
      | Labor |
      | ISCOTT |
  And I select no. 5 record from Labor table records
  And I set Start and End time
  And I save record
  And I press route the workflow button
  Then Status field has value COMP-WREV
  And I take screenshot of Reject a PM Work Order Task scenario four

  Examples:
      | role        |
      | teamlead |

      



Scenario: 05) Reject a PM Work Order Task
  Given I sign as <role> 
  And I open application Work Order Tracking BRDA from Favorite Menu
  When I filter table PM:
		| Description | Status | Work Type |
		| AUTO REJECT PM WO | =COMP-WREV | =M1 |
  And I select no. 1 record from PMs table
  And I press route the workflow button
  And I set (Radio) field to "Reject Work"
  And I press OK dialog button
  And Status field has value INPRG-HOLD
  And I take screenshot of Reject a PM Work Order Task test scenario five


   Examples:
      | role        |
      | maintainer teamlead |
