Feature: 0.0.3 - Sending assets away on a Despatch record

Material needs to be sent away to a supplier for repair. This material may be covered by a Service Purchase Order or a Warranty Claim, or it could be despatched without any financial information as the repair requires a quote or it is assumed the asset will be repaired/replaced for free.


@Feature:0.0.3-SendingassetsawayonaDespatchrecord
Scenario: Sending assets away on a Despatch record
    Given I sign as stores person hornsey
    And I select new MXRDESPATCH
     And I enter Despatch Details:
      | Despatch Description |
      | Sending assets away on a Despatch record Test |
    And I choose Select Value from Detail Menu of Despatch location
    And I filter table Despatch location:
      | Despatch location |
      | MAT-HE-DIRTY |
      And I select no. 1 record from Despatch location table record
     And I enter Vendor data:
      | Vendor Items |
      | 38 |
    And I choose Select Value from Detail Menu of Vendor Location
    And I filter table Vendor location:
      | Vendor location |
      | MAT-VEND-BH |
    And I select no. 1 record from Vendor location table record
    And I choose Select Value from Detail Menu of Return location
    And I filter table Return location:
      | Return location |
      | HE-Z-OVERHAUL |
    And I select no. 1 record from Return location table record
    And I save record
    And I go to Despatch Lines tab
    And I select new row button
    And I choose select value from detail menu for asset field
    Given I filter table Asset:
       | Asset | Location |
       |       | MAT-HE-DIRTY  | 
	And I select no. 1 record from asset table record
    And I select change status 
    And I set (Radio) field to Despatched
    And I click the OK dialog button
    And I take screenshot of DESPATCHED status
    And I select action Run Report
     And I filter Report:
      | Report |
      | Despatch Report |
	And I select no. 1 record from Despatch Report table record
    And I Submit Despatch Report
    And I wait for page to load
    And I take screenshot of Sending assets away on a Despatch record test
    

	Examples:
      | role |
      | stores person hornsey |
	