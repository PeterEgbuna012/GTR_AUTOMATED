Feature: 0.0.010a - Assigning a Work Order to a Labour Record - Qualification Match

To assign a labor record which has the required qualification(s) to a Work Order.

@allure.label.epic:CMS
@allure.label.feature:AssigningaWorkOrdertoaLabourRecord-QualificationMatch
@allure.label.story:AssigningaWorkOrdertoaLabourRecord-QualificationMatch
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.010a
Scenario: Assigning a Work Order to a Labour Record - Qualification Match
     Given I sign as <role>
	 And I go to Team Leader Routine Work Tab
	 And I select Work Order from the Routine Work Orders to Schedule portlet
	 And I go to Assignments Tab
     And I add new row in Assignments Tab
     And I open Select Value lookup for Labor field
	 And I filter table Labor:
      | Labor |
      | PREED |
     And I select no. 1 record from Labor table records
	 #And I pree Ok dialog system message button
     And I save record
	 And I take screenshot of Assigning a Work Order to a Labour Record - Qualification Match Test
	 	 

	Examples:
      | role |
      | cms team leader |
