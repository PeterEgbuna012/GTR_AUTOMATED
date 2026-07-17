Feature: 0.0.2 - Receiving New Consumable Material

An Order has been delivered to Store and needs to be received in.

@Feature:0.0.2-ReceivingNewConsumableMaterial

Scenario: Receiving New Consumable Material
    Given I sign as stores person hornsey
	And I open application Receiving (Tr) from Fav Menu
	And I filter Receiving (Tr):
		| PO | PO Status | Receipts |
		| SU | =APPR  | PARTIAL  |
    And I select no. 1 record from PO Item table record 
	And I select Ordered Items button
	And I enter  delivery note:
		| Delivery Note | Remarks Note |
		| TEST AUTO     | Receiving New Consumable Material Auto Test |
	And I select no. 1 record from PO Item to receive table record 
	And I Press Ok
	And I view Item details
	#And I enter Shelf Life Start date
	#And I enter Shelf Life Duration (Months)
	 And I save record
	And I take screenshot of completed status
	And I select action button Run Report
	 And I filter table Report:
      | Report |
      | Goods Receipt Label Report |
    And I select no. 1 from Reports table records
	And I set (Radio) field to submit report
	And I wait for page to load
	And I take screenshot of Receiving New Consumable Material test

	  Examples:
      | role |
      | stores person hornsey |
