Feature: 0.0.2 - Receiving New Consumable Material

An Order has been delivered to Store and needs to be received in.

@allure.label.epic:PurchasingandReceiving
@allure.label.feature:ReceivingNewConsumableMaterial
@allure.label.story:ReceivingNewConsumableMaterial
@allure.label.severity:Normal
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.2
Scenario: Receiving New Consumable Material
    Given I sign as <role>
	And I open application Receiving (Tr)
	#And I open application Receiving (Tr) from Fav Menu
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
	And I set (Radio) field to "Immediate"
	And I wait for page to load
	And I take screenshot of Receiving New Consumable Material test

	  Examples:
      | role |
      | materials depot manager |
