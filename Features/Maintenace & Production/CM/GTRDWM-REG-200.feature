Feature: 2.0.0 - Create a CM Work Order

As a Maintainer Team Leader I have been assigned work and want to create a FIFI.

@Feature:2.0.0-CreateaCMWorkOrder
Scenario: Create a CM Work Order
Given I sign as <role>
	And I open application Work Order Tracking (BRDA)
	And I select create new record
	And I enter work order:
      | Description |
      | CM WO AUTO TEST |
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
	And I take screenshot of Create a CM Work Order test
	

	Examples:
      | role |
      | maxadmin |

	
