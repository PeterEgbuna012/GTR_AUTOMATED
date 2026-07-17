Feature: 0.0.1 - Move Defective Asset from Drop-Off Location


Assets that have come from an operating location will be moved to a REPAIR location. The user will then need to make the decision as to whether to move the assets to an internal repair location, send the asset away for repair, or to scrap the asset. 

@Feature:0.0.1-MoveDefectiveAssetfromDrop-OffLocation
Scenario: Move Defective Asset from Drop-Off Location
      Given I sign as stores person
	  And I select assets from production drop-off location portlet
	  And I select action Move Asset
	  And I select Move Modify Asset
	  And I choose Select Value from Detail Menu of location
	  And I filter table location:
      | location |
      | MAT-BI-DIRTY |
      And I select no. 1 record from location table record
	  And I select apply button
	  And I press Ok
	  And I press Ok dilaog to close system message
	  And I take screenshot of Move Defective Asset from Drop-Off Location test

	  Examples:
      | role |
      | stores person |
	
