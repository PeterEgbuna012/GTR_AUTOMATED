Feature: 0.0.2 - Raising a Warranty Claim

An Asset has failed within the Warranty coverage period, a claim needs to be submitted to the vendor


@RaisingaWarrantyClaim
Scenario: Raising a Warranty Claim
     Given I sign as warranty manager
	 And I open application Warranty Claims (Tr)
	 And I select create new clams button
	 And I enter Clams Details:
      | Clams Description |
      | Raising a Warranty Claim Test |
	  And I choose select value from detail menu of asset field
	  And I filter table Asset:
      | Asset |
      | 1000000 |
	 And I select no. 1 record from asset table record
	 And I press route the workflow button
     And I set (Radio) field to Submit Claim
     And I Press dialog button OK
	 And I change clams status to Waiting on Approval (WAPPR)
	 And I Press dialog button OK system message
	 And I go to clams Log tab
	 And I select the New Row button
	 And I enter following claim logs:
      | Summary | Details |
      | Raising a Warranty Claim Test | Raising a Warranty Claim Auto Test |
	 And I save record
	 And I go to claim tab
	 And I enter following claim data:
      | RMA Reference | Missed Peaks |
      | TAUTO | 100 |
	 And I choose select value from detail menu of contract field
	 And I filter table contract:
      | Contract |
      | BOM |
	 And I select no. 1 record from contract table records
	 And I save record
	  And I enter claim data:
      | Cost | Claimed Amount |
      | 100 | 100 |
	 And I press route the workflow button
	 And I select Approve claim
	 And I click dialog OK button
	 And I verify claims status
	 And I take screenshot of Raising a Warranty Claim


	  Examples:
      | role        |
      | warranty manager |
	 
