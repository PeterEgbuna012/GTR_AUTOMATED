Feature: 0.0.2 - Automatic Email to Supplier 

The system will automatically send an email to the Supplier when an item on a PO is 1 day overdue.

@Feature:0.0.2-AutomaticEmailtoSupplier 
Scenario: 01) Automatic Email to Supplier 
   Given I sign as maximo administrator
   And I open application Business Rules (BRDB)
   And I filter table Business Rules (BRDB):
      | Business Rules |
      | MXRSUPPLIERCONTACT |
   And I select no. 1 record from Business Rules table records
   And I filter Application Search field:
      | Application |
      | Escalations |
   And I select Application Escalations
   And I filter table Escalations:
      | Escalations |
      | MXRORDEROVERDUE |
   And I select no. 1 record from Escalations table records
   And I set escalations active
   And I go to notifications tab
   And I choose Go To Communcation Templates from Detail Menu of Template field
   And I go to Recipients tab
   And I select New Row button
   And I enter following Email:
      | Email |
      | peter.egbuna@arcadis.com |
   And I set (Radio) field to active
   And I save record
   And I return
   And I select value lookup of Schedule field
    And I enter following Schedule:
      | Schedule |
      | 2 |
   And I press the dialog button ok
   And I set escalations active
   And I select view details 
   And I review sent email
   And I take screenshot of Automatic Email to Supplier Test Scenario one
   Then I return to Maintainer Start Center


    Examples:
      | role |
      | maximo administrator |


Scenario: 02) Delete Automatic Email to Supplier
   Given I sign as maximo administrator
   And I open application Business Rules (BRDB)
   And I filter table Business Rules (BRDB):
      | Business Rules |
      | MXRSUPPLIERCONTACT |
   And I select no. 1 record from Business Rules table records
   And I filter Application Search field:
      | Application |
      | Escalations |
   And I select Application Escalations
    And I filter table Escalations:
      | Escalations |
      | MXRORDEROVERDUE |
   And I select no. 1 record from Escalations table records
   And I set escalations active
   And I go to notifications tab
   And I choose Go To Communcation Templates from Detail Menu of Template field
   And I go to Recipients tab
   And I select show communcation template menu button
   And I filter table Email:
      | Email |
      | peter.egbuna@arcadis.com |
   And I delete email record
   And I take screenshot of Deleted Email to Supplier Test
   And I save record
   And the table Asset Templates has no records
   And I select return
   And I set escalations inactive
   And I take screenshot of Automatic Email to Supplier Test Scenario two


    Examples:
      | role |
      | maximo administrator |

	
