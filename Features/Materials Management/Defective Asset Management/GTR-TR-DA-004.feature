Feature: 0.0.4 - Returning assets on a Despatch record

Defective goods have been returned/replaced by the supplier and need to be brought into the storeroom.

@allure.label.epic:DefectiveAssetManagement
@allure.label.feature:ReturningassetsonaDespatchrecord
@allure.label.story:ReturningassetsonaDespatchrecord
@allure.label.severity:Trivial
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.4
Scenario: Returning assets on a Despatch record
	    Given I sign as <role>
		And I open application Despatches (MXR) from Fav Menu
		And I filter table Despatches:
		| Despatches   | Status      |
		| MAT-HE-DIRTY | =DESPATCHED |
	    And I select no. 3 record from Despatches table record
		And I select action Return Despatched Assets 
		And I set (Radio) field Return Asset True
		And I select the OK dialog button
		And I select Ok dialog system message
		And I verify status changed to RETURNED
		And I take screenshot of Returning assets on a Despatch record test

		Examples:
      | role |
      | stores person hornsey |