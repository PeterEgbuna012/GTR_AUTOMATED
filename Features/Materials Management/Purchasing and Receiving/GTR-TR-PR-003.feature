Feature: 0.0.3 - Receiving New Rotating Material


An Order has been delivered to Store and needs to be received in. As the items are rotating serialized asset records will need to be created.

@Feature:0.0.3-ReceivingNewRotatingMaterial
Scenario: Receiving New Rotating Material
	Given I sign as <role>
	And I open application Receiving (Tr) from Fav Menu
	And I filter Receiving (Tr):
		| PO | PO Status | Receipts |
		| HN | =APPR  | PARTIAL  |
    And I select no. 1 record from PO Item table record 
	And I select Ordered Items button
	And I enter  delivery note:
		| Delivery Note | Remarks Note |
		| TEST AUTO     | Receiving New Rotating Material Auto Test |
	And I select no. 1 PO Item to receive table records 
	And I Press Ok
	And I save record
	And I take screenshot of completed Receiving New Rotating Material
	And I select action Receive Rotating Items
	And I select Auto number button
	And I Press OK
	#And I verify status COMP
	And I take screenshot of Receiving New Rotating Material test


	Examples:
      | role |
      | stores person hornsey |
