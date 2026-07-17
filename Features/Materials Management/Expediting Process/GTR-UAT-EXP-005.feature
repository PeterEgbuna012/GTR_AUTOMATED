Feature: 0.0.5 - Approving a PR - Stocked Item

PRs to review - non-intervention

@Feature:0.0.5-ApprovingaPR-StockedItem
Scenario: 01) Raising a Purchase Requisition - Stocked Item
	Given I sign as materials supply chain support
	And I open application Purchase Requisition
	#And I go to Supply Chain Support Tab
	And I select New Purchase Requisition
	 And I enter following Purchase Requisition:
      | Purchase Requisition |
      | Approving a PR - Stocked Item Test |
	And I enter Required Date
	And I choose Select Value from Detail Menu of Company Field
	And I filter table Company Field:
      | Description |
      | BUCK & HICKMAN (WEST THURROCK) |
	And I select no. 1 record from Company table record
	And I select value lookup of Contact field
	And I select no. 1 record from Contact table record
	And I go to PR Lines tab
	And I select Vendor Items button
	 And I filter table Vendor Items:
      | Vendor Items |
      | 039/140100 |
    And I select no. 1 record from Vendor Items table record
    And I press dialog OK button
	And I choose Select Value from Detail Menu of Storeroom
	And I filter table Storeroom:
      | Storeroom |
      | HE-VALUE |
    And I select no. 1 record from Storeroom table records
	And I enter GL Debit Account:
      | GL Debit Account |
      | 00000-00000-0000 |
	And I select view PR details
	And I enter  Conversion Factor:
      | Conversion Factor |
      | 100 |
    And I Select Value from Detail Menu of Storeroom
	And I filter table Storeroom:
      | Storeroom |
      | HE-VALUE |
	And I select no. 1 record from Storeroom table records
	And I save record
	And I set (Radio) Allow Expediting Email True
	And I Verify Estimated Due Date is set to 14 days
	And I Verify Vendor Due Date is set plus 7 days
	And I go to Ship To Bill To tab
	And I Verify the Ship To address
	And I Verify the Bill To address
	And I press route the workflow button
	And I set (Radio) field to Submit Purchase Request
	And I press ok manual input dialog button
	And I close
	And I take screenshot of Approving a PR - Stocked Item Test scenario one


	 Examples:
      | role |
      | materials supply chain support |



Scenario: 02) Approving a PR - Stocked Item
	Given I sign as materials controller
	 And I filter Portlet table Purchase Requisition:
      | Purchase Requisition |
      | Approving a PR - Stocked Item Test |
     And I select no. 1 record from Purchase Requisition Portlet table record
	And I go to PR Lines tab
	And I select view PR details
	And I Verify PR details
	And I go to tab Work Log
	And I select New Row button under Work Log
	And I enter following Item data:
      | Summary | Details |
      | Stocked Item Auto Test | Approving a PR - Stocked Item Auto Test |
	And I save record
	And I press route the workflow button
	And I set (Radio) field to Approve for £3k limit
	And I press dialog Ok Complete Workflow assignment button
	And I press dialog Ok system message
	And I open application Purchase Orders (Tr)
	And I filter table Purchase Orders (Tr):
      | Purchase Orders  | Status |
      | Approving a PR - Stocked Item Test | APPR |
	And I select no. 1 record from Purchase Orders table records
	And I verify PO status
	And I go to tab PO Lines
	And I select view PO details
	And I Verify PO Estimated Due Date is set to 15 days
	And I Verify PO Vendor Due Date is set plus 7 days
	And I Amend the Vendor Due Date
	And I save record
	And I go to Work Log tab
	And I add new row under Work Log tab
	And I enter following PO Work Log data:
      | Summary | Details |
      | Stocked Item Auto Test | Approving a PR - Stocked Item Auto Test |
	And I save record
	And I take screenshot of Approving a PR - Stocked Item Test scenario two
	


	Examples:
      | role |
      | materials controller |
