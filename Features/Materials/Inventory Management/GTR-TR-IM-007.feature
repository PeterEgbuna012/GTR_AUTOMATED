Feature: 0.0.7 - Receiving Shipments

A consignment has arrived from another storeroom and needs to be booked in.

@Feature:0.0.7-ReceivingShipments
@Ignore
Scenario: Receiving Shipments
	  Given I sign as stores person
	  And I open application shipment receiving from Fav Menu
	   And I filter table shipment receiving:
		| Shipment Receiving  |
		| 007/042021 |
      And I select no. 1 record from shipment receiving table record
	  And I select Shipped Items button
	  And I select no. 1 record from Shipped Items table records
	  And I click ok
      And I save record
	  And I verify status changed to COMPLETE
	  And I take screenshot of Receiving Shipments test

	   Examples:
      | role |
      | stores person |
