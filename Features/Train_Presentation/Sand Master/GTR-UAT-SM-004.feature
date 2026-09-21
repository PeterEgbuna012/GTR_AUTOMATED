Feature: 0.0.4 - Changing location of a person 

The user needs to update the location.

@allure.label.epic:SandMaster
@allure.label.feature:Changinglocationofaperson
@allure.label.story:Changinglocationofaperson
@allure.label.severity:Minor
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.4
Scenario: Changing location of a person 
	Given I sign as <role>  
    #And I open application Sand Master (MXR) from Fav Menu
    And I open application Sand Master (MXR)
    And I select Change Person's Location
    And I select value option of Person's Location field
    And I select no. 2 record from Person's Location table records
    And I click dialog button ok
    And I verify locatiom change
    And I select button Fill Sand Box
    And I select View Sanding Log
    And I press dialog ok
    And I take screenshot of Changing location of a person test
    And I return to Maintainer Start Center


	Examples:
      | role |
      | sand master |
