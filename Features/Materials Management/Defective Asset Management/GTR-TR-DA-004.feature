Feature: 0.0.4 - Returning assets on a Despatch record

Defective goods have been returned/replaced by the supplier and need to be brought into the storeroom.

@Feature:0.0.4-ReturningassetsonaDespatchrecord
Scenario: Returning assets on a Despatch record
	    Given I sign as stores person hornsey
		And I open application Despatches (MXR) from Fav Menu
		And I filter table Despatches:
		| Despatches   | Status      |
		| MAT-HE-DIRTY | =DESPATCHED |
	    And I select no. 1 record from Despatches table record
		And I select action Return Despatched Assets 
		And I set (Radio) field Return Asset True
		And I select the OK dialog button
		And I select Ok dialog system message
		And I verify status changed to RETURNED
		And I take screenshot of Returning assets on a Despatch record test

		Examples:
      | role |
      | stores person hornsey |