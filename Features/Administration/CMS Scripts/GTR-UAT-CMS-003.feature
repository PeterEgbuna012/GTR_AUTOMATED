Feature:  0.0.03 - View a List of Labor Records with Qualifications Soon to Expire

There is a need to view a list of labor records with qualifications soon to expire

@allure.label.epic:CMS
@allure.label.feature:ViewaListofLaborRecordswithQualificationsSoontoExpire
@allure.label.story:ViewaListofLaborRecordswithQualificationsSoontoExpire
@allure.label.severity:critical
@allure.label.layer:e2e
@allure.label.owner:Peter
@allure.label.suite:GTRDWM-REG-0.0.03
Scenario: View a List of Labor Records with Qualifications Soon to Expire
	  Given I sign as training manager
	  And I go to CMS Administrator tab
	  And I Open Result Set in the Application
	  #And I wait for page to load
	  And I take screenshot of View a List of Labor Records with Qualifications Soon to Expire Test
	  	  	

	Examples:
      | role |
      | training manager |
