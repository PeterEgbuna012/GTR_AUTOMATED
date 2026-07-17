Feature: 3.0.0 - Create a PM

You need to create a PM to generate a PM Work Order Ad Hoc out of the frequency sequence

# Setup scenario
@Feature:3.0.0-CreateaPM
Scenario: Create a PM
	Given I sign as <role>
    When I open application Preventive Maintenance, Preventative Maintenance (BRDA)
    And I create new record
    And I enter Description:
      | Description |
      |  MWE PM CHILD WO Test  |
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
    And I take screenshot of Create a PM test

	Examples:
      | role |
      | maxadmin |
