Feature: 0.0.3 - Issuing Consumable Materials

A store person is required to issue consumable material. This might be to a Work Order, a Fleet Location (lineside spares), or a Person (PPE).

@Feature:0.0.3-IssuingConsumableMaterials
Scenario: Issuing Consumable Materials
	 Given I sign as stores
	 And I open application Inventory Usage from Fav Menu
	 And I filter table storeroom:
		| Storeroom  | Item  |
		| SL-VALUE | 093/060987 |
     And I return to Maintainer Start Center
	 And I open application Inventory Usage from Fav Menu
	 And I select create New Inventory usage
	 And I enter asset description:
		| Asset Description  |
		| Issuing Consumable Materials |
	  And I choose Select Value from Detail Menu for Storeroom field
	  And I filter table Storeroom:
		| Storeroom  |
		| SL-VALUE|
     And I select no. 1 record from Storeroom table record
	 And I save record
	 And I select New Row button under the Usage Lines
	 And I choose Select Value from Detail Menu for Item field
	 And I filter Item table records:
		| Description | Item |
		| Screw | 093/060987 |
      And I select no. 1 record from Item table records
	  And I choose Select Value from Detail Menu of Work Order Field
	  And I filter work Order table:
        | Work Order Description |
        | Issue Rotating Assets to a Work Order |
     And I wait for Work order records 
     And I select no. 1 from work Order table record
	 And I save record
	 And I select New Row button under the Usage Lines
	 And I choose Select Value from Detail Menu for Item field
	 And I filter Item table records:
		| Description | Item |
		| Screw | 093/060987 |
     And I select no. 1 record from Item table records
	 And I choose Select Value from Detail Menu of location field
	 And I filter location table:
		| location  |
		| 387201 |
     And I select no. 1 record from location table records
     And I save record
	 And I select view Item details
	 And I select New Row button under the Usage Line
	 And I choose Select Value from Detail Menu for Item field
	 And I filter Item table records:
		| Description | Item |
		| Screw | 093/060987 |
     And I select no. 1 record from Item table records
	 And I choose Select Value from Detail Menu of location field
	 And I filter locations table records:
		| locations | Type |
		| MAT-HE-PERSON | Person |
     And I select no. 1 record from location table records
	 And I open Select Value lookup of Issue To field
	  And I filter Issue To table:
		| Issue To |
		| GHENDLEY |
     And I select no. 1 record from person records
     And I save record
	 And I select Change status 
	 And I select Complete from dropdown menu option of New Status field
	 And I press the dialog button OK
	 And I verify status changed to COMPLETE
	 And I take screenshot of Issuing Consumable Materials test

	 Examples:
      | role  |
      | stores |
