Feature: 0.0.1 - Amend Inventory Defaults for Expediting Process

The store buffer value for the calculation of the Vendor Due Date and the average lead time for non-stock items to calculate the Estimated Due Date can be adjusted if required by an admin-user.

@Feature:0.0.1-AmendInventoryDefaultsforExpeditingProcess
Scenario: Amend Inventory Defaults for Expediting Process
   Given I sign as <role>
   And I open application Organizations (Tr)
    And I filter table Organizations (Tr):
      | Description |
      | GTR |
   And I select no. 1 record from Organizations (Tr) table records
   And I Select Actions Expedite Options
   And I enter following Expedite Options data:
      | Store Lead Time | store buff day |
      | 14 | 7 |
    And I submit record
   And I take screenshot of Amend Inventory Defaults for Expediting Process Test
   And I return to Maintainer Start Center
   

   Examples:
      | role |
      | maximo administrator |
	
