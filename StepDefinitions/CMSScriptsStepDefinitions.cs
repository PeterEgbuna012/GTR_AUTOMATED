using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using Reqnroll;
using GivenAttribute = Reqnroll.GivenAttribute;
using Table = Reqnroll.Table;

namespace GTR_AUTOMATED.StepDefinitions
{
    [Binding]
    public sealed class CMSScriptsStepDefinitions
    {

        private readonly IWebDriver driver;
        private readonly CMSSCRIPTSPOM pom;

        public CMSScriptsStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new CMSSCRIPTSPOM(driver);

        }

        [Given(@"I sign as (.*)")]
        public void GivenISignAs(string role)
        {
            var loginPage = new LoginPage(driver);

            loginPage.LoginAsRole(role);

            AllureLogger.SetUserLoginRole(role);
        }


        [Given("I open application Qualifications")]
        public void GivenIOpenApplicationQualifications()
        {
            AllureLogger.LogStep("Open Go To Menu)",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Administration Menu Button",
                pom.AdministrationMenuButton);
            AllureLogger.LogStep("Resources Menu Button",
                pom.ResourcesMenuButton);
            AllureLogger.LogStep("Launch Application Qualifications",
                pom.OpenApplicationQualifications);
        }

        [Given("I select New Qualification")]
        public void GivenISelectNewQualification()
        {
              AllureLogger.LogStep("I select New Qualification",
              pom.SelectNewQualification);
        }

        [Given("I enter Qualifications Details:")]
        public void GivenIEnterQualificationsDetails(Table table)
        {
            string QualificationCode = table.Rows[0]["Qualification Code"];
            string QualificationDescription = table.Rows[0]["Qualification Description"];
            pom.EnterQualificationsDetails(QualificationCode, QualificationDescription);
        }

        [Given("I open Select Value lookup of Qualification Type field")]
        public void GivenIOpenSelectValueLookupOfQualificationTypeField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Qualification Type field",
                 pom.OpenSelectValueLookupOfQualificationTypeField);
        }

        [Given("I select Qualification Type:")]
        public void GivenISelectQualificationType(Table table)
        {
            string QualificationType = table.Rows[0]["Qualification Type"];
            AllureLogger.LogStep($"I select Qualification Type: {QualificationType}", () =>
                pom.SelectQualificationType(QualificationType));
        }

        [Given("I set Certificate Required [Checkbox] field to true")]
        public void GivenISetCertificateRequiredCheckboxFieldToTrue()
        {
            AllureLogger.LogStep("I set Certificate Required [Checkbox] field to true",
            pom.SetCertificateRequiredCheckboxFieldToTrue);
        }

        [Given("I enter Certificate Information:")]
        public void GivenIEnterCertificateInformation(Table table)
        {
            string EvaluationMethod = table.Rows[0]["Evaluation Method"];
            string IssuingAuthority = table.Rows[0]["Issuing Authority"];
            pom.EnterCertificateInformation(EvaluationMethod, IssuingAuthority);
        }

        [Given("I select long Description Option")]
        public void GivenISelectLongDescriptionOption()
        {
            AllureLogger.LogStep("I select long Description Option",
              pom.SelectLongDescriptionOption);
        }

        [Given("I enter Certificate Long Description:")]
        public void GivenIEnterCertificateLongDescription(Table table)
        {
            string LongDescription = table.Rows[0]["Long Description"];
            AllureLogger.LogStep($"I enter Long Description: {LongDescription}", () =>
                pom.EnterCertificateLongDescription(LongDescription));
        }

        [Given("I select ok button of Long Description")]
        public void GivenISelectOkButtonOfLongDescription()
        {
            AllureLogger.LogStep("I select ok button of Long Description",
                pom.SelectOkButtonOfLongDescription);
        }


        [Given("I select Qualification Type")]
        public void GivenISelectQualificationType()
        {
            AllureLogger.LogStep("I select Qualification Type",
              pom.SelectQualificationType);
        }
                       

        [Given("I enter following:")]
        public void GivenIEnterFollowing(Table table)
        {
            string PowerUpParentQualification = table.Rows[0]["Power Up Parent Qualification"];
            string Duration = table.Rows[0]["Duration"];
            pom.EnterFollowing(PowerUpParentQualification, Duration);
        }

        [Given("I open Select Value lookup of Duration Period field")]
        public void GivenIOpenSelectValueLookupOfDurationPeriodField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Duration Period field",
              pom.OpenSelectValueLookupOfDurationPeriodField);
        }

        [Given("I select Years from the list")]
        public void GivenISelectYearsFromTheList()
        {
            AllureLogger.LogStep("I select Years from the list",
               pom.SelectYearsFromTheList);
        }

        [Given("I enter Required Use Length:")]
        public void GivenIEnterRequiredUseLength(Table table)
        {
            string RequiredUseLength = table.Rows[0]["Required Use Length"];
            AllureLogger.LogStep($"I enter Required Use Length: {RequiredUseLength}", () =>
                pom.EnterRequiredUseLength(RequiredUseLength));
        }

        [Given("I open Select Value lookup of Required Use Period field")]
        public void GivenIOpenSelectValueLookupOfRequiredUsePeriodField()
        {
              AllureLogger.LogStep("I open Select Value lookup of Required Use Period field",
              pom.OpenSelectValueLookupOfRequiredUsePeriodField);
        }

        [Given("I select MONTHS from the list")]
        public void GivenISelectMONTHSFromTheList()
        {
             AllureLogger.LogStep("I select MONTHS from the list",
             pom.SelectMONTHSFromTheList);
        }

        [Given("I select New Row under the Required Craft and Skill Level section")]
        public void GivenISelectNewRowUnderTheRequiredCraftAndSkillLevelSection()
        {
            AllureLogger.LogStep("I select New Row under the Required Craft and Skill Level section",
            pom.SelectNewRowUnderTheRequiredCraftAndSkillLevelSection);
        }

        [Given("I choose Select Value from Detail Menu of Craft field")]
        public void GivenIChooseSelectValueFromDetailMenuOfCraftField()
        {
            AllureLogger.LogStep("Detail Menu Of Craft Field",
                pom.DetailMenuOfCraftField);
            AllureLogger.LogStep("Select Value Option of Craft",
                pom.SelectValueOptionofCraft);
        }

        [Given("I filter table Craft and Skill Level:")]
        public void GivenIFilterTableCraftAndSkillLevel(Table table)
        {
            string Craft = table.Rows[0]["Craft"];
            string SkillLevel = table.Rows[0]["Skill-Level"];
            pom.FilterTableCraftAndSkillLevel(Craft, SkillLevel);
        }

        [Given("I select no. {int} record from Craft and Skill Level table records")]
        public void GivenISelectNo_RecordFromCraftAndSkillLevelTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Craft and Skill Level table records",
              () => pom.SelectNoRecordFromCraftAndSkillLevelTableRecords(recordNumber));
        }



        [Given("I take screenshot of Craft Skill-Level")]
        public void GivenITakeScreenshotOfCraftSkill_Level()
        {
            AllureLogger.LogStep("I take screenshot of Craft Skill-Level",
               pom.TakeScreenshotOfCraftSkill_Level);
        }

        [Given("I delete Craft Skill-Level")]
        public void GivenIDeleteCraftSkill_Level()
        {
            AllureLogger.LogStep("I delete Craft Skill-Level",
               pom.DeleteCraftSkillLevel);
        }

        [Given("I change qualifications change status inactive")]
        public void GivenIChangeQualificationsChangeStatusInactive()
        {
            AllureLogger.LogStep("I change qualifications status",
               pom.ChangeQualificationsstatus);
            AllureLogger.LogStep("Status Bar Drop Down Menu Option",
                pom.DropdownMenuOption);
            AllureLogger.LogStep("I set status inactive",
                pom.SetStatusInactive);
        }

        [Given("I verify status is INACTIVE")]
        public void GivenIVerifyStatusIsINACTIVE()
        {

            AllureLogger.LogStep("I verify status is INACTIVE",
              pom.VerifyStatusIsINACTIVE);

        }

        [Given("I select Ok Button")]
        public void GivenISelectOkButton()
        {
              AllureLogger.LogStep("I select Ok Button",
                pom.SelectOkButton);
        }

        [Given("I take screenshot of Creation of a Qualification Test")]
        public void GivenITakeScreenshotOfCreationOfAQualificationTest()
        {
            AllureLogger.LogStep("I take screenshot of Creation of a Qualification Test",
               pom.TakeScreenshotOfCreationOfAQualificationTest);
        }



        // Delete Qualification Steps Definitions





        [Given("I filter table Qualifications:")]
        public void GivenIFilterTableQualifications(Table table)
        {
            string Qualifications = table.Rows[0]["Qualifications"];
            AllureLogger.LogStep($"filter table Qualifications: {Qualifications}", () =>
                pom.FilterTableQualifications(Qualifications));
        }

        [Given("I select no. {int} record from Qualification table records")]
        public void GivenISelectNo_RecordFromQualificationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Qualification table records",
             () => pom.SelectNoRecordFromQualificationTableRecords(recordNumber));
        }

        [Given("I select delete Qualifications")]
        public void GivenISelectDeleteQualifications()
        {
            AllureLogger.LogStep("I select delete Qualifications",
                pom.SelectDeleteQualifications);
        }

        [Given("I press Yes dialog button")]
        public void GivenIPressYesDialogButton()
        {
            AllureLogger.LogStep("I press Yes dialog button",
                pom.PressYesDialogButton);
        }
        
        [Given("I verify table has no records")]
        public void GivenIVerifyTableHasNoRecords()
        {
            AllureLogger.LogStep("I verify table has no records",
                pom.VerifyTableHasNoRecords);
        }

        [Given("I take screenshot of Delete Qualification Test")]
        public void GivenITakeScreenshotOfDeleteQualificationTest()
        {
            AllureLogger.LogStep("I take screenshot of Delete Qualification Test",
               pom.TakeScreenshotOfDeleteQualificationTest);
        }






        // Association of a Qualification to a Labour Record Steps Definitions


        [Given("I take screenshot of Craft Skill Level")]
        public void GivenITakeScreenshotOfCraftSkillLevel()
        {
            AllureLogger.LogStep("I take screenshot of Craft Skill-Level",
               pom.TakeScreenshotOfCraftSkillLevel);
        }
        
        [Given("I verify status is ACTIVE")]
        public void GivenIVerifyStatusIsACTIVE()
        {
            AllureLogger.LogStep("I verify status is ACTIVE",
              pom.VerifyStatusIsACTIVE);
        }

        [Given("I take screenshot of Association of a Qualification to a Labour Record test")]
        public void GivenITakeScreenshotOfAssociationOfAQualificationToALabourRecordTest()
        {
            AllureLogger.LogStep("I take screenshot of Association of a Qualification to a Labour Record test",
            pom.TakeScreenshotOfAssociationOfAQualificationToALabourRecordTest);
        }


        //Association of a Qualification to a Labour Record Steps Definitions



        [Given("I open application Labor")]
        public void GivenIOpenApplicationLabor()
        {
            AllureLogger.LogStep("Open Go To Menu)",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Administration Menu Button",
                pom.AdministrationMenuButton);
            AllureLogger.LogStep("Resources Menu Button",
                pom.ResourcesMenuButton);
            AllureLogger.LogStep("Launch Application Labor",
                pom.OpenApplicationLabor);
        }

        [Given("I filter table labor:")]
        public void GivenIFilterTableLabor(Table table)
        {
            string labor = table.Rows[0]["labor"];
            AllureLogger.LogStep($"filter table labor: {labor}", () =>
                pom.FilterTableLabor(labor));
        }

        [Given("I select no. {int} record from labor table records")]
        public void GivenISelectNo_RecordFromLaborTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from labor table records",
             () => pom.SelectNoRecordFromLaborTableRecords(recordNumber));
        }

        [Given("I go to Qualifications tab")]
        public void GivenIGoToQualificationsTab()
        {
            AllureLogger.LogStep("I go to Qualifications tab",
               pom.GoToQualificationsTab);
        }

        [Given("I select New Row Button")]
        public void GivenISelectNewRowButton()
        {
            AllureLogger.LogStep("I select New Row Button",
               pom.SelectNewRowButton);
        }

        [Given("I choose Select Value from Detail Menu of Qualification field")]
        public void GivenIChooseSelectValueFromDetailMenuOfQualificationField()
        {
            AllureLogger.LogStep("Detail Menu Of Qualification",
                  pom.DetailMenuOfQualification);
            AllureLogger.LogStep("Select Value Option Of Qualification",
                pom.SelectValueOptionOfQualification);
        }

        [Given("I filter table Qualification:")]
        public void GivenIFilterTableQualification(Table table)
        {
            string Qualification = table.Rows[0]["Qualification"];
            AllureLogger.LogStep($"filter table Qualification: {Qualification}", () =>
                pom.FilterTableQualification(Qualification));
        }

        [Given("I select no. {int} from Qualification table records")]
        public void GivenISelectNo_FromQualificationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Qualification table records",
             () => pom.SelectNoFromQualificationTableRecords(recordNumber));
        }

        [Given("I select no. {int} record from Qualification table record")]
        public void GivenISelectNo_RecordFromQualificationTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Qualification table records",
            () => pom.SelectNoRecordFromQualificationTableRecord(recordNumber));
        }


        [Given("I take screenshot of Association of a Qualification to a Labour Record")]
        public void GivenITakeScreenshotOfAssociationOfAQualificationToALabourRecord()
        {
            AllureLogger.LogStep("I take screenshot of Association of a Qualification to a Labour Record",
            pom.TakeScreenshotOfAssociationOfAQualificationToALabourRecord);
        }

        [Given("I select the filter option")]
        public void GivenISelectTheFilterOption()
        {
            AllureLogger.LogStep("I select the filter option",
               pom.SelectTheFilterOption);
        }

        [Given("I filter Qualification table:")]
        public void GivenIFilterQualificationTable(Table table)
        {
            string Qualification = table.Rows[0]["Qualification"];
            AllureLogger.LogStep($"filter table Qualification: {Qualification}", () =>
                pom.FilterQualificationTable(Qualification));
        }


        [Given("I set qualifications status inactive")]
        public void GivenISetQualificationsChangeStatusInactive()
        {
            AllureLogger.LogStep("I change qualifications status",
               pom.ChangeQualificationsstatus);
            AllureLogger.LogStep("Status Bar Drop Down Menu",
                pom.DropdownMenu);
            AllureLogger.LogStep("I set status inactive",
                pom.SetStatusInactive);
        }


        [Given("I take screenshot of Set Qualification Inactive")]
        public void GivenITakeScreenshotOfSetQualificationInactive()
        {
            AllureLogger.LogStep("I take screenshot of Set Qualification Inactive",
            pom.TakeScreenshotOfSetQualificationInactive);
        }






        // View a List of Labor Records with Qualifications Soon to Expire Steps Definitions




        [Given("I go to CMS Administrator tab")]
        public void GivenIGoToCMSAdministratorTab()
        {
            AllureLogger.LogStep("I go to CMS Administrator tab",
                pom.GoToCMSAdministratorTab);
        }

        [Given("I Open Result Set in the Application")]
        public void GivenIOpenResultSetInTheApplication()
        {
            AllureLogger.LogStep("I Open Result Set in the Application",
                 pom.OpenResultSetInTheApplication);
        }

        [Given("I take screenshot of View a List of Labor Records with Qualifications Soon to Expire Test")]
        public void GivenITakeScreenshotOfViewAListOfLaborRecordsWithQualificationsSoonToExpireTest()
        {
            AllureLogger.LogStep("I take screenshot of View a List of Labor Records with Qualifications Soon to Expire Test",
            pom.TakeScreenshotOfViewAListOfLaborRecordsWithQualificationsSoonToExpireTest);
        }






        // Creating new Training Course Job Plans Steps Definitions





        [Given("I take screenshot of Creating new Training Course Job Plans Test Scenario one")]
        public void GivenITakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Creating new Training Course Job Plans Test Scenario one",
            pom.TakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenarioOne);
        }
                

        [Given("I open application Job Plans \\(Tr)")]
        public void GivenIOpenApplicationJobPlansTr()
        {
            AllureLogger.LogStep("Open Go To Menu)",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Planning Menu Button",
                pom.PlanningMenuButton);
            AllureLogger.LogStep("Open Application Job Plans Tr",
                pom.OpenApplicationJobPlansTr);
        }

        [Given("I select New Job Plan")]
        public void GivenISelectNewJobPlan()
        {
            AllureLogger.LogStep("I select New Job Plan",
            pom.SelectNewJobPlan);
        }

        [Given("I enter Job Plan:")]
        public void GivenIEnterJobPlan(Table table)
        {
            string ID = table.Rows[0]["ID"];
            string Description = table.Rows[0]["Description"];
            pom.EnterJobPlan(ID, Description);
        }

        [Given("I open Select Value lookup of Organisation field")]
        public void GivenIOpenSelectValueLookupOfOrganisationField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Organisation field",
               pom.OpenSelectValueLookupOfOrganisationField);
        }

        [Given("I select no. {int} record from Organisation table records")]
        public void GivenISelectNo_RecordFromOrganisationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Organisation table records",
            () => pom.SelectNoRecordFromOrganisationTableRecords(recordNumber));
        }

        [Given("I open Select Value lookup of Site field")]
        public void GivenIOpenSelectValueLookupOfSiteField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Site field",
            pom.OpenSelectValueLookupOfSiteField);
        }

        [Given("I select no. {int} record from Site table records")]
        public void GivenISelectNo_RecordFromSiteTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Site table records",
            () => pom.SelectNoRecordFromSiteTableRecords(recordNumber));
        }

        [Given("I select details section maximize option")]
        public void GivenISelectDetailsSectionMaximizeOption()
        {
            AllureLogger.LogStep("I select details section maximize option",
              pom.SelectDetailsSectionMaximizeOption);
        }


        [Given("I enter Duration:")]
        public void GivenIEnterDuration(Table table)
        {
            string Duration = table.Rows[0]["Duration"];
            AllureLogger.LogStep($"I enter Duration: {Duration}", () =>
                pom.EnterDuration(Duration));
        }

        [Given("I select New Row button under Job Plans Tasks section")]
        public void GivenISelectNewRowButtonUnderJobPlansTasksSection()
        {
            AllureLogger.LogStep("I select New Row button under Job Plans Tasks section",
              pom.SelectNewRowButtonUnderJobPlansTasksSection);
        }

        [Given("I enter Task Description:")]
        public void GivenIEnterTaskDescription(Table table)
        {
            string TaskDescription = table.Rows[0]["Task Description"];
            AllureLogger.LogStep($"I enter Task Description: {TaskDescription}", () =>
                pom.TaskDescription(TaskDescription));
        }

        [Given("I open Select Value lookup of Qualifications field")]
        public void GivenIOpenSelectValueLookupOfQualificationsField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Qualifications field",
              pom.OpenSelectValueLookupOfQualificationsField);
        }

        [Given("I select yes dialog button of System Message")]
        public void GivenISelectYesDialogButtonOfSystemMessage()
        {
            AllureLogger.LogStep("I select yes dialog button of System Message",
           pom.SelectYesDialogButtonOfSystemMessage);
        }

        [Given("I select New Row")]
        public void GivenISelectNewRow()
        {
            AllureLogger.LogStep("I select New Row",
            pom.SelectNewRow);
        }

        [Given("I open Select Value lookup of Qualification Requirements field")]
        public void GivenIOpenSelectValueLookupOfQualificationRequirementsField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Qualification Requirements field",
                   pom.SelectValueLookupOfQualificationRequirementsField);
        }
                  

        [Given("I filter Qualification Requirements:")]
        public void GivenIFilterQualificationRequirements(Table table)
        {
            string Qualification = table.Rows[0]["Qualification"];
            AllureLogger.LogStep($"I filter Qualification Requirements: {Qualification}", () =>
            pom.FilterQualificationRequirements(Qualification));
        }

        [Given("I select no. {int} record from Qualification Requirements table records")]
        public void GivenISelectNo_RecordFromQualificationRequirementsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Qualification Requirements table records",
            () => pom.SelectNoRecordFromQualificationRequirementsTableRecords(recordNumber));
        }

        [Given("I Press Ok dialog button")]
        public void GivenIPressOkDialogButton()
        {
            AllureLogger.LogStep("I Press Ok dialog button",
           pom.PressOkDialogButton);
        }


        [Given("I Select Value from Detail Menu of Qualification")]
        public void GivenISelectValueFromDetailMenuOfQualification()
        {
            AllureLogger.LogStep("Detail Menu Of Qualification",
                  pom.DetailMenuOfQualification);
            AllureLogger.LogStep("Select Value Option Of Qualification",
                pom.SelectValueOptionOfQualification);
        }

        [Given("I filter Qualification:")]
        public void GivenIFilterQualification(Table table)
        {
            string Qualification = table.Rows[0]["Qualification"];
            AllureLogger.LogStep($"I filter Qualification: {Qualification}", () =>
            pom.FilterQualification(Qualification));
        }

        [Given("I set Qualification status ACTIVE")]
        public void GivenISetQualificationStatusACTIVE()
        {
            AllureLogger.LogStep("I select Change Status Button",
            pom.ChangeStatusButton);
            AllureLogger.LogStep("I select Drop Down New Status Menu Option",
           pom.SelectDropdownNewStatusMenuOption);
            AllureLogger.LogStep("I Select ACTIVE From New Status Menu Option",
                pom.SelectACTIVEFromNewStatusMenuOption);

        }

        [Given("I click Ok")]
        public void GivenIClickOk()
        {
            AllureLogger.LogStep("I click Ok",
           pom.ClickOk);
        }

        [Given("I verify Job Plans status ACTIVE")]
        public void GivenIVerifyJobPlansStatusACTIVE()
        {
            AllureLogger.LogStep("I verify status is ACTIVE",
             pom.VerifyJobPlansStatusACTIVE);
        }


        [Given("I verify status ACTIVE")]
        public void GivenIVerifyStatusACTIVE()
        {
            AllureLogger.LogStep("I verify status is ACTIVE",
              pom.VerifyStatusACTIVE);
        }

        [Given("I take screenshot of Creating new Training Course Job Plans Test Scenario two")]
        public void GivenITakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Creating new Training Course Job Plans Test Scenario two",
            pom.TakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenariotwo);
        }

        [Given("I open Select Value lookup of Nested Job Plan field")]
        public void GivenIOpenSelectValueLookupOfNestedJobPlanField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Nested Job Plan field",
                pom.OpenSelectValueLookupOfNestedJobPlanField);
        }

        [Given("I filter Nested Job Plan:")]
        public void GivenIFilterNestedJobPlan(Table table)
        {
            string Description = table.Rows[0]["Description"];
            AllureLogger.LogStep($"I filter Nested Job Plan: {Description}", () =>
            pom.FilterNestedJobPlan(Description));
        }

        [Given("I select no. {int} record from Nested Job Plan table records")]
        public void GivenISelectNo_RecordFromNestedJobPlanTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Nested Job Plan table records",
            () => pom.SelectNoRecordFromNestedJobPlanTableRecords(recordNumber));
        }

        [Given("I select New Row button under Planned Labor section")]
        public void GivenISelectNewRowButtonUnderPlannedLaborSection()
        {
            AllureLogger.LogStep("I select New Row button under Planned Labor section",
                pom.SelectNewRowButtonUnderPlannedLaborSection);
        }

        [Given("I enter Task Value:")]
        public void GivenIEnterTaskValue(Table table)
        {
            string TaskValue = table.Rows[0]["Task Value"];
            AllureLogger.LogStep($"I enter Task Value: {TaskValue}", () =>
                pom.EnterTaskValue(TaskValue));
        }

        [Given("I choose Select Value from Detail Menu of Craft")]
        public void GivenIChooseSelectValueFromDetailMenuOfCraft()
        {
            AllureLogger.LogStep("Detail Menu Of Craft",
                pom.DetailMenuOfCraft);
            AllureLogger.LogStep("Select Value Option of Craft",
                pom.SelectValueOption);
        }

        [Given("I filter table Craft:")]
        public void GivenIFilterTableCraft(Table table)
        {
            string Craft = table.Rows[0]["Craft"];
            string SkillLevel = table.Rows[0]["Skill-Level"];
            pom.FilterTableCraft(Craft, SkillLevel);
        }

        [Given("I select no. {int} record from Craft table records")]
        public void GivenISelectNo_RecordFromCraftTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Craft table records",
            () => pom.SelectNoRecordFromCraftTableRecords(recordNumber));
        }


        [Given("I set Job Plan status ACTIVE")]
        public void GivenISetJobPlanStatusACTIVE()
        {
            AllureLogger.LogStep("I select Change Status Button",
            pom.ChangeStatusButton);
            AllureLogger.LogStep("I select Drop Down New Status Menu Option",
           pom.SelectDropdownNewStatusMenuOption);
            AllureLogger.LogStep("I Select ACTIVE From New Status Menu Option",
                pom.SelectACTIVEFromNewStatusMenuOption);
        }

        [Given("I take screenshot of Creating new Training Course Job Plans Test Scenario three")]
        public void GivenITakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Creating new Training Course Job Plans Test Scenario three",
            pom.TakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenariothree);
        }

        [Given("I filter table Job Plans:")]
        public void GivenIFilterTableJobPlans(Table table)
        {
            string JobPlans = table.Rows[0]["Job Plans"];
            AllureLogger.LogStep($"I filter Job Plans: {JobPlans}", () =>
            pom.FilterTableJobPlans(JobPlans));
        }

        [Given("I select no. {int} record from Job Plans table records")]
        public void GivenISelectNo_RecordFromJobPlansTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Job Plan table records",
            () => pom.SelectNoRecordFromJobPlansTableRecords(recordNumber));
        }

        [Given("I select delete Job Plans")]
        public void GivenISelectDeleteJobPlans()
        {
            AllureLogger.LogStep("I select delete Job Plans",
          pom.SelectDeleteJobPlans);
        }

        [Given("I press Yes button")]
        public void GivenIPressYesButton()
        {
            AllureLogger.LogStep("I press Yes button",
           pom.PressYesButton);
        }

        [Given("I verify Job Plans table has no records")]
        public void GivenIVerifyJobPlansTableHasNoRecords()
        {
            AllureLogger.LogStep("verify Job Plans table has no records",
                pom.VerifyJobPlansTableHasNoRecords);
        }

        [Given("I take screenshot of Creating new Training Course Job Plans Test Scenario four")]
        public void GivenITakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenarioFour()
        {
            AllureLogger.LogStep("I take screenshot of Creating new Training Course Job Plans Test Scenario four",
            pom.TakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenariofour);
        }

        [Given("I select delect Job Plan")]
        public void GivenISelectDelectJobPlan()
        {
            AllureLogger.LogStep("I select delete Job Plans",
            pom.SelectDeleteJobPlans);
        }

        [Given("I select Yes button")]
        public void GivenISelectYesButton()
        {
            AllureLogger.LogStep("I press Yes button",
            pom.PressYesButton);
        }

        [Given("I take screenshot of Creating new Training Course Job Plans Test Scenario five")]
        public void GivenITakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenarioFive()
        {
            AllureLogger.LogStep("I take screenshot of Creating new Training Course Job Plans Test Scenario five",
           pom.TakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenariofive);
        }

        [Given("I take screenshot of Creating new Training Course Job Plans Test Scenario six")]
        public void GivenITakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenarioSix()
        {
            AllureLogger.LogStep("I take screenshot of Creating new Training Course Job Plans Test Scenario six",
            pom.TakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenariosix);
        }






        // Creating a new Training Course Work Order Template Steps Definitions






        [Given("I take screenshot of Creating a new Training Course Work Order Template Test Scenario one")]
        public void GivenITakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Creating a new Training Course Work Order Template Test Scenario one",
            pom.TakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenarioOne);
        }

        [Given("I open application Work Order Template \\(BRDA)")]
        public void GivenIOpenApplicationWorkOrderTemplateBRDA()
        {
            AllureLogger.LogStep("Go To Menu",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Work Order Menu",
                pom.OpenWorkOrderMenu);
            AllureLogger.LogStep("Launch Work Order Template",
                pom.OpenApplicationWorkOrderTemplateBRDA);
        }

        [Given("I select new record")]
        public void GivenISelectNewRecord()
        {
            AllureLogger.LogStep("I select new record",
            pom.SelectNewRecord);
        }

        [Given("I enter Work Order Template Details:")]
        public void GivenIEnterWorkOrderTemplateDetails(Table table)
        {
            string ID = table.Rows[0]["ID"];
            string Description = table.Rows[0]["Description"];
            pom.EnterWorkOrderTemplateDetails(ID, Description);
        }

        [Given("I choose Select Value from Detail Menu of Asset Group field")]
        public void GivenIChooseSelectValueFromDetailMenuOfAssetGroupField()
        {
            AllureLogger.LogStep("Detail Menu Of Asset Group",
                pom.DetailMenuOfAssetGroup);
            AllureLogger.LogStep("Select Value Option of Asset Group",
                pom.SelectValueOptionOfAssetGroup);
        }

        [Given("I select no. {int} record from Asset Group table records")]
        public void GivenISelectNo_RecordFromAssetGroupTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Asset Group table records",
            () => pom.SelectNoRecordFromAssetGroupTableRecords(recordNumber));
        }

        [Given("I open Select Value lookup of Work Type field")]
        public void GivenIOpenSelectValueLookupOfWorkTypeField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Work Type field",
            pom.OpenSelectValueLookupOfWorkTypeField);
        }

        [Given("I filter Work Type:")]
        public void GivenIFilterWorkType(Table table)
        {
            string WorkType = table.Rows[0]["Work Type"];
            AllureLogger.LogStep($"I filter Work Type: {WorkType}", () =>
            pom.FilterWorkType(WorkType));
        }

        [Given("I select no. {int} record from Template Work Type table records")]
        public void GivenISelectNo_RecordFromTemplateWorkTypeTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Template Work Type table records",
            () => pom.SelectNoRecordFromTemplateWorkTypeTableRecords(recordNumber));
        }

        [Given("I choose Select Value from Detail Menu of Job Plan field")]
        public void GivenIChooseSelectValueFromDetailMenuOfJobPlanField()
        {
            AllureLogger.LogStep("Detail Menu Of Job Plan",
               pom.DetailMenuOfJobPlan);
            AllureLogger.LogStep("Select Value Option of Job Plan",
                pom.SelectValueOptionOfJobPlan);
        }

        [Given("I filter Job Plan:")]
        public void GivenIFilterJobPlan(Table table)
        {
            string JobPlan = table.Rows[0]["Job Plan"];
            AllureLogger.LogStep($"I filter Job Plan: {JobPlan}", () =>
            pom.FilterJobPlan(JobPlan));
        }

        [Given("I select no. {int} record from Job Plan table records")]
        public void GivenISelectNo_RecordFromJobPlanTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Job Plan table records",
            () => pom.SelectNoRecordFromJobPlanTableRecords(recordNumber));
        }

        [Given("I set Work Order Template status to ACTIVE")]
        public void GivenISetWorkOrderTemplateStatusToACTIVE()
        {
            AllureLogger.LogStep("I select Change Status Button",
            pom.OpenSelectValueOfStatusField);
            AllureLogger.LogStep("I Select ACTIVE",
                pom.SelectStatusACTIVE);
        }

        [Given("I verify template status ACTIVE")]
        public void GivenIVerifyTemplateStatusACTIVE()
        {
            AllureLogger.LogStep("I verify status is ACTIVE",
             pom.VerifyTemplateStatusACTIVE);
        }

        [Given("I take screenshot of Creating a new Training Course Work Order Template Test Scenario two")]
        public void GivenITakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Creating a new Training Course Work Order Template Test Scenario two",
            pom.TakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenariotwo);
        }

        [Given("I filter table Work Order Template:")]
        public void GivenIFilterTableWorkOrderTemplate(Table table)
        {
            string ID = table.Rows[0]["ID"];
            AllureLogger.LogStep($"I filter ID: {ID}", () =>
            pom.FilterTableWorkOrderTemplate(ID));
        }

        [Given("I select no. {int} record from Work Order Template table records")]
        public void GivenISelectNo_RecordFromWorkOrderTemplateTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Work Order Template table records",
            () => pom.SelectNoRecordFromWorkOrderTemplateTableRecords(recordNumber));
        }

        [Given("I select delete Work Order Template record")]
        public void GivenISelectDeleteWorkOrderTemplateRecord()
        {
            AllureLogger.LogStep("I select delete Work Order Template record",
           pom.SelectDeleteWorkOrderTemplateRecord);
        }

        [Given("I verify Work Order Template table has no records")]
        public void GivenIVerifyWorkOrderTemplateTableHasNoRecords()
        {
            AllureLogger.LogStep("I verify Work Order Template table has no records",
                pom.VerifyWorkOrderTemplateTableHasNoRecords);
        }

        [Given("I take screenshot of Creating a new Training Course Work Order Template Test Scenario three")]
        public void GivenITakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Creating a new Training Course Work Order Template Test Scenario three",
            pom.TakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenariothree);
        }

        [Given("I take screenshot of Creating a new Training Course Work Order Template Test Scenario four")]
        public void GivenITakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenarioFour()
        {
            AllureLogger.LogStep("I take screenshot of Creating a new Training Course Work Order Template Test Scenario four",
            pom.TakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenariofour);
        }





        //Creating a new Training Course Work Order Steps Definitions



        [Given("I enter work order:")]
        public void GivenIEnterWorkOrder(Table table)
        {
            string Description = table.Rows[0]["Description"];
            AllureLogger.LogStep($"I enter work order: {Description}", () =>
            pom.EnterWorkOrder(Description));
        }

        [Given("I set Work Type field:")]
        public void GivenISetWorkTypeField(Table table)
        {
            string WorkType = table.Rows[0]["Work Type"];
            AllureLogger.LogStep($"I set Work Type field: {WorkType}", () =>
            pom.SetWorkTypeField(WorkType));
        }



        [Given("I verify work order status WAIT-REV")]
        public void GivenIVerifyWorkOrderStatusWAIT_REV()
        {
            AllureLogger.LogStep("I verify work order status WAIT-REV",
            pom.VerifyWorkOrderStatusWAITREV);
        }

        [Given("I take screenshot of Creating a new Training Course Work Order test")]
        public void GivenITakeScreenshotOfCreatingANewTrainingCourseWorkOrderTest()
        {
            AllureLogger.LogStep("I take screenshot of Creating a new Training Course Work Order test",
            pom.TakeScreenshotOfCreatingANewTrainingCourseWorkOrderTest);
        }





        // Scheduling a Training Course (in Graphical Scheduling) Steps Definitions






        [Given("I open application Graphical Scheduling")]
        public void GivenIOpenApplicationGraphicalScheduling()
        {
            AllureLogger.LogStep("Go To Menu",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Planning And Scheduling Menu Button",
                pom.PlanningAndSchedulingMenuButton);
            AllureLogger.LogStep("Launch Graphical Scheduling Button",
                pom.GraphicalSchedulingButton);
        }

        [Given("I select create new schedule")]
        public void GivenISelectCreateNewSchedule()
        {
            AllureLogger.LogStep("I select create new schedule",
            pom.SelectCreateNewSchedule);
        }

        [Given("I enter Schedule ID:")]
        public void GivenIEnterScheduleID(Table table)
        {
            string ID = table.Rows[0]["ID"];
            string Description = table.Rows[0]["Description"];
            pom.EnterScheduleID(ID, Description);
        }

        [Given("I choose Select Value from Detail Menu of calendar field")]
        public void GivenIChooseSelectValueFromDetailMenuOfCalendarField()
        {
            AllureLogger.LogStep("Detail Menu Of calendar",
               pom.DetailMenuOfcalendar);
            AllureLogger.LogStep("Select Value Option of calendar",
                pom.SelectValueOptionOfcalendar);
        }

        [Given("I select GTRBASE")]
        public void GivenISelectGTRBASE()
        {
            AllureLogger.LogStep("I select GTRBASE",
            pom.SelectGTRBASE);
        }

        [Given("I select Copy Query button under Work Queries section")]
        public void GivenISelectCopyQueryButtonUnderWorkQueriesSection()
        {
            AllureLogger.LogStep("I select Copy Query button under Work Queries section",
            pom.SelectCopyQueryButtonUnderWorkQueriesSection);
        }

        [Given("I filter table Query:")]
        public void GivenIFilterTableQuery(Table table)
        {
            string Query = table.Rows[0]["Query"];
            AllureLogger.LogStep($"I filter table Query: {Query}", () =>
            pom.FilterTableQuery(Query));
        }

        [Given("I select no. {int} from Query table records")]
        public void GivenISelectNo_FromQueryTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Query table records",
            () => pom.SelectNoFromQueryTableRecords(recordNumber));
        }

        [Given("I press dialog ok button of copy Query")]
        public void GivenIPressDialogOkButtonOfCopyQuery()
        {
            AllureLogger.LogStep("I press dialog ok button of copy Query",
            pom.PressDialogOkButtonOfCopyQuery);
        }


        [Given("I wait for Query to load")]
        public void GivenIWaitForQueryToLoad()
        {
            AllureLogger.LogStep("I wait for Query to load",
           pom.WaitForQueryToLoad);
        }

        [Given("I go to tab Graphical View")]
        public void GivenIGoToTabGraphicalView()
        {
            AllureLogger.LogStep("I go to tab Graphical View",
            pom.GoToTabGraphicalView);
        }

        [Given("I wait for Graphical page to load")]
        public void GivenIWaitForGraphicalPageToLoad()
        {
            AllureLogger.LogStep("I wait for Query to load",
           pom.WaitForGraphicalPageToLoad);
        }

        [Given("I select Commit Changes")]
        public void GivenISelectCommitChanges()
        {
            AllureLogger.LogStep("I select Commit Changes",
            pom.SelectCommitChanges);
        }

        [Given("I click yes dialog button")]
        public void GivenIClickYesDialogButton()
        {
            AllureLogger.LogStep("I click yes dialog button",
            pom.ClickYesDialogButton);
        }

        [Given("I press OK dialog button of system message")]
        public void GivenIPressOKDialogButtonOfSystemMessage()
        {
            AllureLogger.LogStep("I press OK dialog button of system message",
            pom.PressOKDialogButtonOfSystemMessage);
        }

        [Given("I change status to Approved")]
        public void GivenIChangeStatusToApproved()
        {
            AllureLogger.LogStep("I select Change Status",
            pom.ChangeStatus);
            AllureLogger.LogStep("Drop Down Menu Option",
            pom.DropDownMenuOption);
            AllureLogger.LogStep("I select Approved",
            pom.SelectApproved);
        }

        [Given("I select ok")]
        public void GivenISelectOk()
        {
            AllureLogger.LogStep("I select ok",
            pom.SelectOk);
        }

        [Given("I go to tab Schedule")]
        public void GivenIGoToTabSchedule()
        {
            AllureLogger.LogStep("I go to tab Schedule",
            pom.GoToTabSchedule);
        }


        [Given("I verify status APPROVED")]
        public void GivenIVerifyStatusAPPROVED()
        {
             AllureLogger.LogStep("I verify status is APPROVED",
             pom.VerifyStatusAPPROVED);
        }

        [Given("I take screenshot of Scheduling a Training Course \\(in Graphical Scheduling) Test Scenario one")]
        public void GivenITakeScreenshotOfSchedulingATrainingCourseInGraphicalSchedulingTestScenarioOne()
        {
             AllureLogger.LogStep("I take screenshot of Scheduling a Training Course \\(in Graphical Scheduling) Test Scenario one",
             pom.TakeScreenshotOfSchedulingATrainingCourseInGraphicalSchedulingTestScenarioOne);
        }

               
        [Given("I filter table Graphical Scheduling:")]
        public void GivenIFilterTableGraphicalScheduling(Table table)
        {
            string GraphicalScheduling = table.Rows[0]["ID"];
            AllureLogger.LogStep($"I filter Graphical Scheduling: {GraphicalScheduling}", () =>
            pom.FilterTableGraphicalScheduling(GraphicalScheduling));
        }

        [Given("I select no. {int} record from Graphical Scheduling table records")]
        public void GivenISelectNo_RecordFromGraphicalSchedulingTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from  Graphical Scheduling table records",
            () => pom.SelectNoRecordFromGraphicalSchedulingTableRecords(recordNumber));
        }

        [Given("I select delete Graphical Scheduling record")]
        public void GivenISelectDeleteGraphicalSchedulingRecord()
        {
            AllureLogger.LogStep("I select delete Graphical Scheduling record",
            pom.SelectDeleteGraphicalSchedulingRecord);
        }

        [Given("I verify Graphical Scheduling table has no records")]
        public void GivenIVerifyGraphicalSchedulingTableHasNoRecords()
        {
            AllureLogger.LogStep("I verify Graphical Scheduling table has no records",
                pom.VerifyGraphicalSchedulingTableHasNoRecords);
        }

        [Given("I take screenshot of Scheduling a Training Course \\(in Graphical Scheduling) Test Scenario two")]
        public void GivenITakeScreenshotOfSchedulingATrainingCourseInGraphicalSchedulingTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Scheduling a Training Course \\(in Graphical Scheduling) Test Scenario two",
            pom.TakeScreenshotOfSchedulingATrainingCourseInGraphicalSchedulingTestScenariotwo);
        }





        // Scheduling a Training Course (in Work Order Tracking) Steps Definitions 




        [Given("I take screenshot of Scheduling a Training Course \\(in Work Order Tracking) Test Scenario one")]
        public void GivenITakeScreenshotOfSchedulingATrainingCourseInWorkOrderTrackingTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Scheduling a Training Course (in Work Order Tracking) Test Scenario one",
            pom.TakeScreenshotOfSchedulingATrainingCourseInWorkOrderTrackingTestScenarioOne);
        }

        [Given("I open application CMS Course Work Order \\(MXR)")]
        public void GivenIOpenApplicationCMSCourseWorkOrderMXR()
        {
            AllureLogger.LogStep("Go To Menu",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Work Order Menu",
                pom.OpenWorkOrderMenu);
            AllureLogger.LogStep("Launch CMS Course Work Order (MXR)",
                pom.OpenApplicationCMSCourseWorkOrderMXR);
        }

        [Given("I filter table CMS Course Work Order:")]
        public void GivenIFilterTableCMSCourseWorkOrder(Table table)
        {
            string Description = table.Rows[0]["Description"];
            AllureLogger.LogStep($"I filter CMS Course Work Order: {Description}", () =>
            pom.FilterTableCMSCourseWorkOrder(Description));
        }

        [Given("I select no. {int} from CMS Course Work Order table records")]
        public void GivenISelectNo_FromCMSCourseWorkOrderTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from CMS Course Work Order table records",
           () => pom.SelectNoFromCMSCourseWorkOrderTableRecords(recordNumber));
        }

        [Given("I Set Scheduled Start")]
        public void GivenISetScheduledStart()
        {
            AllureLogger.LogStep("I Set Scheduled Start",
                pom.SetScheduledStart);
        }

        [Given("I Set Scheduled Finish date")]
        public void GivenISetScheduledFinishDate()
        {
            AllureLogger.LogStep("I Set Scheduled Finish date",
                pom.SetScheduledFinishDate);
        }

        [Given("I verify Scheduled Start")]
        public void GivenIVerifyScheduledStart()
        {
            AllureLogger.LogStep("I verify Scheduled Start",
              pom.VerifyGeneratedWorkOrderNumber);
        }

        [Given("I take screenshot of Scheduling a Training Course \\(in Work Order Tracking) Test Scenario two")]
        public void GivenITakeScreenshotOfSchedulingATrainingCourseInWorkOrderTrackingTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Scheduling a Training Course (in Work Order Tracking) Test Scenario two",
            pom.TakeScreenshotOfSchedulingATrainingCourseInWorkOrderTrackingTestScenarioTwo);
        }




        // Allocating a Trainer & Classroom to a Training Course (in Graphical Assignment) Steps Definitions



        [Given("I enter Long Description :")]
        public void GivenIEnterLongDescription(Table table)
        {
            string LongDescription = table.Rows[0]["Long Description"];
            AllureLogger.LogStep($"I filter CMS Course Work Order: {LongDescription}", () =>
            pom.EnterLongDescription(LongDescription));
        }

        [Given("I select the Ok button")]
        public void GivenISelectTheOkButton()
        {
            AllureLogger.LogStep("I select the Ok button",
            pom.SelectTheOkButton);
        }

        [Given("I select list view button")]
        public void GivenISelectListViewButton()
        {
            AllureLogger.LogStep("I select list view button",
            pom.SelectListViewButton);
        }

        [Given("I filter Graphical Scheduling Table:")]
        public void GivenIFilterGraphicalSchedulingTable(Table table)
        {
            string ID = table.Rows[0]["ID"];
            AllureLogger.LogStep($"I filter Graphical Scheduling: {ID}", () =>
            pom.FilterGraphicalSchedulingTable(ID));
        }

        [Given("I select no. {int} from Graphical Scheduling table records")]
        public void GivenISelectNo_FromGraphicalSchedulingTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Graphical Scheduling table records",
          () => pom.SelectNoFromGraphicalSchedulingTableRecords(recordNumber));
        }

        [Given("I take screenshot of Allocating a Trainer & Classroom to a Training Course \\(in Graphical Assignment) Test Scenario one")]
        public void GivenITakeScreenshotOfAllocatingATrainerClassroomToATrainingCourseInGraphicalAssignmentTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Allocating a Trainer & Classroom to a Training Course (in Graphical Assignment) Test Scenario one",
            pom.TakeScreenshotOfAllocatingATrainerClassroomToATrainingCourseInGraphicalAssignmentTestScenarioOne);
        }

        [Given("I take screenshot of Delete Allocating a Trainer & Classroom to a Training Course \\(in Graphical Assignment) Test Scenario two")]
        public void GivenITakeScreenshotOfDeleteAllocatingATrainerClassroomToATrainingCourseInGraphicalAssignmentTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Allocating a Trainer & Classroom to a Training Course (in Graphical Assignment) Test Scenario two",
            pom.TakeScreenshotOfAllocatingATrainerClassroomToATrainingCourseInGraphicalAssignmentTestScenariotwo);
        }






        // Allocating a Trainer & Classroom to a Training Course (in Work Order Tracking) Steps Definitions




        [Given("I take screenshot of Allocating a Trainer & Classroom to a Training Course \\(in Work Order Tracking) test scenario one")]
        public void GivenITakeScreenshotOfAllocatingATrainerClassroomToATrainingCourseInWorkOrderTrackingTestScenarioOne()
        {

            AllureLogger.LogStep("I take screenshot of Allocating a Trainer & Classroom to a Training Course (in Work Order Tracking) test scenario one",
            pom.TakeScreenshotOfAllocatingATrainerClassroomToATrainingCourseInWorkOrderTrackingTestScenarioOne);

        }

        [Given("I filter work Order:")]
        public void GivenIFilterWorkOrder(Table table)
        {
            string description = table.Rows[0]["Description"];
            string WorkType = table.Rows[0]["Work Type"];
            pom.FilterWorkOrder(description, WorkType);
        }



        [Given("I select no. {int} record from work Order table records")]
        public void GivenISelectNo_RecordFromWorkOrderTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Work Order table records",
              () => pom.SelectNoRecordFromWorkOrderTableRecords(recordNumber));
        }

        [Given("I Reschedule Start Date tomorrow's date")]
        public void GivenIRescheduleStartDateTomorrowsDate()
        {
            AllureLogger.LogStep("I Set Scheduled Start",
                pom.RescheduleStartDateTomorrowsDate);
        }

        [Given("I take screenshot of Allocating a Trainer & Classroom to a Training Course \\(in Work Order Tracking) Test Scenario two")]
        public void GivenITakeScreenshotOfAllocatingATrainerClassroomToATrainingCourseInWorkOrderTrackingTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Allocating a Trainer & Classroom to a Training Course (in Work Order Tracking) test scenario two",
            pom.TakeScreenshotOfAllocatingATrainerClassroomToATrainingCourseInWorkOrderTrackingTestScenariotwo);
        }







        // Allocating a Trainer, Classroom & Trainees to a Training Course (in Graphical Assignment) Steps Definitions



        [Given("I open application Graphical Assignment")]
        public void GivenIOpenApplicationGraphicalAssignment()
        {
            AllureLogger.LogStep("Go To Menu",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Planning And Scheduling Menu Button",
                pom.PlanningAndSchedulingMenuButton);
            AllureLogger.LogStep("Launch Graphical Assignment",
                pom.GraphicalAssignment);
        }

        [Given("I enter Assignment:")]
        public void GivenIEnterAssignment(Table table)
        {
            string ID = table.Rows[0]["ID"];
            string Description = table.Rows[0]["Description"];
            pom.EnterAssignment(ID, Description);
        }

        [Given("I open Select Value lookup of Shift field")]
        public void GivenIOpenSelectValueLookupOfShiftField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Shift field",
            pom.OpenSelectValueLookupOfShiftField);
        }
                       
        [Given("I select no. {int} from Shift table records")]
        public void GivenISelectNo_FromShiftTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Shift table records",
              () => pom.SelectNoFromShiftTableRecords(recordNumber));
        }

        [Given("I Press Ok dialog select Shift button")]
        public void GivenIPressOkDialogSelectShiftButton()
        {
            AllureLogger.LogStep("I Press Ok dialog select Shift button",
            pom.PressOkDialogSelectShiftButton);
        }


        [Given("I filter Graphical Scheduling:")]
        public void GivenIFilterGraphicalScheduling(Table table)
        {
            string Description = table.Rows[0]["Description"];
            AllureLogger.LogStep($"I filter Graphical Scheduling: {Description}", () =>
            pom.FilterGraphicalScheduling(Description));
        }

        [Given("I select no. {int} record from Graphical table records")]
        public void GivenISelectNo_RecordFromGraphicalTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Graphical table records",
              () => pom.SelectNoRecordFromGraphicalTableRecords(recordNumber));
        }


        [Given("I go to tab Work View")]
        public void GivenIGoToTabWorkView()
        {
            AllureLogger.LogStep("I go to tab Work View",
            pom.GoToTabWorkView);
        }

        [Given("I wait for Work View page to load")]
        public void GivenIWaitForWorkViewPageToLoad()
        {
            AllureLogger.LogStep("I wait for Work View page to load",
           pom.WaitForWorkViewPageToLoad);
        }
        

        [Given("I take screenshot of Allocating a Trainer, Classroom & Trainees to a Training Course \\(in Graphical Assignment) Test Scenario one")]
        public void GivenITakeScreenshotOfAllocatingATrainerClassroomTraineesToATrainingCourseInGraphicalAssignmentTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Allocating a Trainer, Classroom & Trainees to a Training Course \\(in Graphical Assignment) Test Scenario one",
            pom.TakeScreenshotOfAllocatingATrainerClassroomTraineesToATrainingCourseInGraphicalAssignmentTestScenarioOne);
        }

        [Given("I take screenshot of Allocating a Trainer, Classroom & Trainees to a Training Course \\(in Graphical Assignment) Test Scenario two")]
        public void GivenITakeScreenshotOfAllocatingATrainerClassroomTraineesToATrainingCourseInGraphicalAssignmentTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Allocating a Trainer, Classroom & Trainees to a Training Course \\(in Graphical Assignment) Test Scenario one",
            pom.TakeScreenshotOfAllocatingATrainerClassroomTraineesToATrainingCourseInGraphicalAssignmentTestScenariotwo);
        }








        // Allocating a Trainee to a Training Course (in Work Order Tracking) Steps Definitions




        [Given("I take screenshot of Allocating a Trainee to a Training Course \\(in Work Order Tracking) test scenario one")]
        public void GivenITakeScreenshotOfAllocatingATraineeToATrainingCourseInWorkOrderTrackingTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Allocating a Trainee to a Training Course (in Work Order Tracking) test scenario one",
            pom.TakeScreenshotOfAllocatingATraineeToATrainingCourseInWorkOrderTrackingTestScenarioOne);
        }

        [Given("I filter table CMS Course Work Order \\(MXR):")]
        public void GivenIFilterTableCMSCourseWorkOrderMXR(Table table)
        {
            string Description = table.Rows[0]["Description"];
            string Status = table.Rows[0]["Status"];
            pom.FilterTableCMSCourseWorkOrderMXR(Description, Status);
        }

        [Given("I select New Row button under Assignments section")]
        public void GivenISelectNewRowButtonUnderAssignmentsSection()
        {
            AllureLogger.LogStep("I select New Row button under Assignments section",
            pom.SelectNewRowButtonUnderAssignmentsSection);
        }

        [Given("I choose Select Value from Detail Menu of the Craft Field")]
        public void GivenIChooseSelectValueFromDetailMenuOfTheCraftField()
        {
            AllureLogger.LogStep("Detail Menu of the Craft Field",
            pom.DetailMenuOfTheCraftField);
            AllureLogger.LogStep("I Select Value of the Craft Field",
            pom.SelectValueOfTheCraftField);
        }

        [Given("I filter Craft table:")]
        public void GivenIFilterCraftTable(Table table)
        {
            string Craft = table.Rows[0]["Craft"];
            AllureLogger.LogStep($"I filter Craft: {Craft}", () =>
            pom.FilterCraftTable(Craft));
        }

        [Given("I select no. {int} from Craft table records")]
        public void GivenISelectNo_FromCraftTableRecords(int recordNumber)
        {
              AllureLogger.LogStep($"I select no.{recordNumber} from Craft table records",
              () => pom.SelectNoFromCraftTableRecords(recordNumber));
        }

        [Given("I filter Craft and skill level table:")]
        public void GivenIFilterCraftAndSkillLevelTable(Table table)
        {
            string Craft = table.Rows[0]["Craft"];
            string SkillLevel = table.Rows[0]["Skill Level"];
            pom.FilterCraftAndSkillLevelTable(Craft, SkillLevel);
        }

        [Given("I select no. {int} from Craft and skill levl table records")]
        public void GivenISelectNo_FromCraftAndSkillLevlTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Craft and skill levl table records",
              () => pom.SelectNoFromCraftAndSkillLevlTableRecords(recordNumber));
        }

        [Given("I choose Select Value from Detail Menu of the labor field")]
        public void GivenIChooseSelectValueFromDetailMenuOfTheLaborField()
        {
            AllureLogger.LogStep("Detail Menu of the labor Field",
            pom.DetailMenuOflaborField);
            AllureLogger.LogStep("I Select Value of the labor Field",
            pom.SelectValueOflaborField);
        }

        [Given("I select no. {int} from labor table records")]
        public void GivenISelectNo_FromLaborTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from labor table records",
              () => pom.SelectNoFromLaborTableRecords(recordNumber));
        }
               

        [Given("I verify Assignments status is ASSIGNED")]
        public void GivenIVerifyAssignmentsStatusIsASSIGNED()
        {
            AllureLogger.LogStep("I verify Assignments status is ASSIGNED",
              pom.VerifyAssignmentsStatusIsASSIGNED);
        }

        [Given("I take screenshot of Allocating a Trainee to a Training Course \\(in Work Order Tracking) test scenario two")]
        public void GivenITakeScreenshotOfAllocatingATraineeToATrainingCourseInWorkOrderTrackingTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Allocating a Trainee to a Training Course (in Work Order Tracking) test scenario two",
            pom.TakeScreenshotOfAllocatingATraineeToATrainingCourseInWorkOrderTrackingTestScenariotwo);
        }







        //  Allocating a Trainee to a Training Course (in Work Order Tracking) 8C Steps Definitions



        [Given("I take screenshot of Allocating Trainee Training Course in \\(Work Order Tracking) Test Scenario one")]
        public void GivenITakeScreenshotOfAllocatingTraineeTrainingCourseInWorkOrderTrackingTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Allocating Trainee Training Course in (Work Order Tracking) Test Scenario one",
            pom.TakeScreenshotOfAllocatingTraineeTrainingCourseInWorkOrderTrackingTestScenarioOne);
        }

        [Given("I take screenshot of Allocating Trainee Training Course in \\(Work Order Tracking) Test Scenario two")]
        public void GivenITakeScreenshotOfAllocatingTraineeTrainingCourseInWorkOrderTrackingTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Allocating Trainee Training Course in (Work Order Tracking) Test Scenario one",
            pom.TakeScreenshotOfAllocatingTraineeTrainingCourseInWorkOrderTrackingTestScenariotwo);
        }


        // Executing a Training Course Assessment Steps Definitions


        [Given("I select New Row button under Children of Work Order")]
        public void GivenISelectNewRowButtonUnderChildrenOfWorkOrder()
        {
            AllureLogger.LogStep("I select New Row button under Children of Work Order",
                 pom.SelectNewRowButtonUnderChildrenOfWorkOrder);
        }


        [Given("I enter Children of Work Order details:")]
        public void GivenIEnterChildrenOfWorkOrderDetails(Table table)
        {
            string description = table.Rows[0]["Description"];
            AllureLogger.LogStep($"I enter Children of Work Order Description: {description}", () =>
                pom.EnterChildrenOfWorkOrderDetails(description));
        }

        [Given("I choose Select Value from Detail Menu of Children Work Order Location field")]
        public void GivenIChooseSelectValueFromDetailMenuOfChildrenWorkOrderLocationField()
        {
            AllureLogger.LogStep("I choose Select Value from Detail Menu of Children Work Order Location field",
            pom.ChooseSelectValueFromDetailMenuOfChildrenWorkOrderLocationField);
        }

        [Given("I filter table Children Work Order Location:")]
        public void GivenIFilterTableChildrenWorkOrderLocation(Table table)
        {
            string Location = table.Rows[0]["Location"];
            AllureLogger.LogStep($"I filter table Children Work Order Location: {Location}", () =>
                pom.FilterTableChildrenWorkOrderLocation(Location));
        }

        [Given("I select no. {int} from Children Work Order Location table records")]
        public void GivenISelectNo_FromChildrenWorkOrderLocationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Children Work Order Location table records",
              () => pom.SelectNoFromChildrenWorkOrderLocationTableRecords(recordNumber));
        }


        [Given("I enter Estimated Duration:")]
        public void GivenIEnterEstimatedDuration(Table table)
        {
            string EstimatedDuration = table.Rows[0]["Estimated Duration"];
            AllureLogger.LogStep($"I enter Estimated Duration: {EstimatedDuration}", () =>
                pom.EnterEstimatedDuration(EstimatedDuration));
        }

        [Given("I select New Row button under Task for Work Order")]
        public void GivenISelectNewRowButtonUnderTaskForWorkOrder()
        {
            AllureLogger.LogStep("I select New Row button under Task for Work Order",
            pom.SelectNewRowButtonUnderTaskForWorkOrder);
        }

        [Given("I enter Task details:")]
        public void GivenIEnterTaskDetails(Table table)
        {
            string description = table.Rows[0]["Description"];
            AllureLogger.LogStep($"I enter Task Description: {description}", () =>
                pom.EnterTaskDetails(description));
        }

        [Given("I select route work flow button")]
        public void GivenISelectRouteWorkFlowButton()
        {
            AllureLogger.LogStep("I select route work flow button",
           pom.SelectRouteWorkFlowButton);
        }

        [Given("I set \\(Radio) field to Set the work order to SCHEDULED")]
        public void GivenISetRadioFieldToSetTheWorkOrderToSCHEDULED()
        {
            AllureLogger.LogStep("I set \\(Radio) field to Set the work order to SCHEDULED",
           pom.SetRadioFieldToSetTheWorkOrderToSCHEDULED);
        }

        [Given("I select dialog ok button of System Message")]
        public void GivenISelectDialogOkButtonOfSystemMessage()
        {
            AllureLogger.LogStep("I select dialog ok button of System Message",
            pom.SelectDialogOkButtonOfSystemMessage);
        }

        [Given("I take screenshot of Scheduling a Training Course Assessment")]
        public void GivenITakeScreenshotOfSchedulingATrainingCourseAssessment()
        {
            AllureLogger.LogStep("I take screenshot of Scheduling a Training Course Assessment",
            pom.TakeScreenshotOfSchedulingATrainingCourseAssessment);
        }

        [Given("I complete Child Tasks")]
        public void GivenICompleteChildTasks()
        {
            AllureLogger.LogStep("I complete Child Tasks",
            pom.ICompleteChildTasks);
        }

        [Given("I fail Child Tasks")]
        public void GivenIFailChildTasks()
        {
            AllureLogger.LogStep("I fail Child Tasks",
            pom.IFailChildTasks);
        }


        [Given("I take screenshot of Executing a Training Course Assessment")]
        public void GivenITakeScreenshotOfExecutingATrainingCourseAssessment()
        {
            AllureLogger.LogStep("I take screenshot of Executing a Training Course Assessment",
            pom.TakeScreenshotOfExecutingATrainingCourseAssessment);
        }

        [Given("I select change Delegates status button")]
        public void GivenISelectChangeDelegatesStatusButton()
        {
            AllureLogger.LogStep("I select change Delegates status button",
            pom.SelectChangeDelegatesStatusButton);
        }

        [Given("I select Qualification Passed from dropdown menu options")]
        public void GivenISelectQualificationPassedFromDropdownMenuOptions()
        {
            AllureLogger.LogStep("I select Qualification Passed from dropdown menu options",
            pom.SelectQualificationPassedFromDropdownMenuOptions);
        }

        [Given("I take screenshot of Executing a Training Course Assessment - Qualification Passed")]
        public void GivenITakeScreenshotOfExecutingATrainingCourseAssessment_QualificationPassed()
        {
            AllureLogger.LogStep("I take screenshot of Executing a Training Course Assessment",
            pom.TakeScreenshotOfExecutingATrainingCourseAssessmentQualificationPassed);
        }




        // Assigning a Work Order to a Labour Record - Qualification Match Steps Definitions





        [Given("I go to Team Leader Routine Work Tab")]
        public void GivenIGoToTeamLeaderRoutineWorkTab()
        {
            AllureLogger.LogStep("I go to Team Leader Routine Work Tab",
            pom.GoToTeamLeaderRoutineWorkTab);
        }

        [Given("I select Work Order from the Routine Work Orders to Schedule portlet")]
        public void GivenISelectWorkOrderFromTheRoutineWorkOrdersToSchedulePortlet()
        {
            AllureLogger.LogStep("I select Work Order from the Routine Work Orders to Schedule portlet",
            pom.SelectWorkOrderFromTheRoutineWorkOrdersToSchedulePortlet);
        }

        [Given("I take screenshot of Assigning a Work Order to a Labour Record - Qualification Match Test")]
        public void GivenITakeScreenshotOfAssigningAWorkOrderToALabourRecord_QualificationMatchTest()
        {
            AllureLogger.LogStep("I take screenshot of Assigning a Work Order to a Labour Record - Qualification Match Test",
            pom.TakeScreenshotOfAssigningAWorkOrderToALabourRecordQualificationMatchTest);
        }




        // Labor Skill-Level Check - Update skill-levels Steps Definitions



        [Given("I open application Business Rule \\(BRDB)")]
        public void GivenIOpenApplicationBusinessRuleBRDB()
        {
            AllureLogger.LogStep("Open Go To Menu)",
                 pom.OpenGoToMenu);
            AllureLogger.LogStep("Administration Menu Button",
                pom.AdministrationMenuButton);
            AllureLogger.LogStep("Open Application Business Rules BRDB",
                pom.OpenApplicationBusinessRulesBRDB);
            
        }

        [Given("I filter table Business Rule:")]
        public void GivenIFilterTableBusinessRule(Table table)
        {
            string BusinessRule = table.Rows[0]["Business Rule"];
            AllureLogger.LogStep($"I filter Business Rule: {BusinessRule}", () =>
            pom.FilterTableBusinessRule(BusinessRule));
        }

        [Given("I select no. {int} record from Business Rule table records")]
        public void GivenISelectNo_RecordFromBusinessRuleTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Business Rule table records",
              () => pom.SelectNoRecordFromBusinessRuleTableRecords(recordNumber));
        }

        [Given("I select New Row button under the List Values for MXRCMSSKILLLEVEL section")]
        public void GivenISelectNewRowButtonUnderTheListValuesForMXRCMSSKILLLEVELSection()
        {
            AllureLogger.LogStep("I select New Row button under the List Values for MXRCMSSKILLLEVEL section",
            pom.SelectNewRowButtonUnderTheListValuesForMXRCMSSKILLLEVELSection);
        }

        [Given("I enter Skill level Details:")]
        public void GivenIEnterSkillLevelDetails(Table table)
        {
            string Skilllevel = table.Rows[0]["Skill level"];
            string Description = table.Rows[0]["Description"];
            pom.EnterSkillLevelDetails(Skilllevel, Description);
        }

        [Given("I take screenshot of Labor Skill-Level Check - Update skill-levels Test Scenario one")]
        public void GivenITakeScreenshotOfLaborSkill_LevelCheck_UpdateSkill_LevelsTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Labor Skill-Level Check - Update skill-levels Test Scenario one",
           pom.TakeScreenshotOfLaborSkillLevelCheckUpdateSkillLevelsTestScenarioOne);
        }

        [Given("I select delete button under the List Values for MXRCMSSKILLLEVEL section")]
        public void GivenISelectDeleteButtonUnderTheListValuesForMXRCMSSKILLLEVELSection()
        {
            AllureLogger.LogStep("I select delete button under the List Values for MXRCMSSKILLLEVEL section",
            pom.SelectDeleteButtonUnderTheListValuesForMXRCMSSKILLLEVELSection);
        }

        [Given("I verify table skill levels has no records")]
        public void GivenIVerifyTableSkillLevelsHasNoRecords()
        {
            AllureLogger.LogStep("I verify table has no records",
               pom.VerifyTableSkillLevelsHasNoRecords);
        }


        [Given("I take screenshot of Deleting Updated skill-levels Test")]
        public void GivenITakeScreenshotOfDeletingUpdatedSkill_LevelsTest()
        {
            AllureLogger.LogStep("I take screenshot of Deleting Updated skill-levels Test",
            pom.TakeScreenshotOfDeletingUpdatedSkillLevelsTest);
        }





        // Power Ups - Initial set up Steps Definitions







        [Given("I select New Row button under the List Values for MXRCMSPOWERUPS section")]
        public void GivenISelectNewRowButtonUnderTheListValuesForMXRCMSPOWERUPSSection()
        {
            AllureLogger.LogStep("I select New Row button under the List Values for MXRCMSPOWERUPS section",
            pom.SelectNewRowButtonUnderTheListValuesForMXRCMSPOWERUPSSection);
        }

        [Given("I enter MXRCMSPOWERUPS Details:")]
        public void GivenIEnterMXRCMSPOWERUPSDetails(Table table)
        {
            string ID = table.Rows[0]["ID"];
            string Description = table.Rows[0]["Description"];
            pom.EnterMXRCMSPOWERUPSDetails(ID, Description);
        }

        [Given("I take screenshot of Power Ups")]
        public void GivenITakeScreenshotOfPowerUps()
        {
            AllureLogger.LogStep("I take screenshot of Power Ups",
            pom.TakeScreenshotOfPowerUps);
        }

        [Given("I filter table Qualifications Description:")]
        public void GivenIFilterTableQualificationsDescription(Table table)
        {
            string Qualifications = table.Rows[0]["Qualifications"];
            AllureLogger.LogStep($"I filter Qualifications: {Qualifications}", () =>
            pom.FilterTableQualificationsDescription(Qualifications));
        }

        [Given("I enter Parent Qualification:")]
        public void GivenIEnterParentQualification(Table table)
        {
            string ParentQualification = table.Rows[0]["Parent Qualification"];
            AllureLogger.LogStep($"I enter Parent Qualification: {ParentQualification}", () =>
            pom.EnterParentQualification(ParentQualification));
        }

        [Given("I take screenshot of Power Ups - Initial set up Test")]
        public void GivenITakeScreenshotOfPowerUps_InitialSetUpTest()
        {
            AllureLogger.LogStep("I take screenshot of Power Ups - Initial set up Test",
            pom.TakeScreenshotOfPowerUpsInitialSetUpTest);
        }

        [Given("I filter table MXRCMSPOWERUPS:")]
        public void GivenIFilterTableMXRCMSPOWERUPS(Table table)
        {
            string MXRCMSPOWERUPS = table.Rows[0]["MXRCMSPOWERUPS"];
            AllureLogger.LogStep($"I filter table MXRCMSPOWERUPS: {MXRCMSPOWERUPS}", () =>
            pom.FilterTableMXRCMSPOWERUPS(MXRCMSPOWERUPS));
        }

        [Given("I delete MXRCMSPOWERUPS record")]
        public void GivenIDeleteMXRCMSPOWERUPSRecord()
        {
            AllureLogger.LogStep("I delete MXRCMSPOWERUPS record",
            pom.DeleteMXRCMSPOWERUPSRecord);
        }

        [Given("I take screenshot of Deleting skill-levels Test")]
        public void GivenITakeScreenshotOfDeletingSkill_LevelsTest()
        {
            AllureLogger.LogStep("I take screenshot of Deleting skill-levels Test",
            pom.TakeScreenshotOfDeletingSkillLevelsTest);
        }






        // Power Ups - Managing failed Power Ups Steps Definitions





        [Given("I set \\(Radio) field Uncheck all Power Up Fail to false")]
        public void GivenISetRadioFieldUncheckAllPowerUpFailToFalse()
        {
            AllureLogger.LogStep("I set \\(Radio) field Uncheck all Power Up Fail to false",
            pom.SetRadioFieldUncheckAllPowerUpFailToFalse);
        }

        [Given("I take screenshot of Power Ups - Managing failed Power Ups Test")]
        public void GivenITakeScreenshotOfPowerUps_ManagingFailedPowerUpsTest()
        {
            AllureLogger.LogStep("I take screenshot of Deleting skill-levels Test",
            pom.TakeScreenshotOfPowerUpsManagingFailedPowerUpsTest);
        }





        // Creation of Campaigns work order Steps Definitions



        [Given("I take screenshot of Creation of Campaigns work order Test Scenario one")]
        public void GivenITakeScreenshotOfCreationOfCampaignsWorkOrderTestScenarioOne()
        {
            AllureLogger.LogStep("take screenshot of Creation of Campaigns work order Test Scenario one",
            pom.TakeScreenshotOfCreationOfCampaignsWorkOrderTestScenarioOne);
        }

        [Given("I take screenshot of Creation of Campaigns work order Test Scenario two")]
        public void GivenITakeScreenshotOfCreationOfCampaignsWorkOrderTestScenarioTwo()
        {
            AllureLogger.LogStep("take screenshot of Creation of Campaigns work order Test Scenario two",
            pom.TakeScreenshotOfCreationOfCampaignsWorkOrderTestScenariotwo);
        }

        [Given("I open application Campaigns \\(Tr)")]
        public void GivenIOpenApplicationCampaignsTr()
        {
            AllureLogger.LogStep("Go To Menu",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Work Order Menu",
                pom.OpenWorkOrderMenu);
            AllureLogger.LogStep("Launch application Campaigns (TR)",
                pom.OpenApplicationCampaignsTr);
        }

        [Given("I select New Campaign")]
        public void GivenISelectNewCampaign()
        {
             AllureLogger.LogStep("I select New Campaign",
             pom.SelectNewCampaign);
        }

        [Given("I enter Campaign Details:")]
        public void GivenIEnterCampaignDetails(Table table)
        {
            string Campaign = table.Rows[0]["Campaign Description"];
            AllureLogger.LogStep($"I enter Campaign Details: {Campaign}", () =>
            pom.EnterCampaignDetails(Campaign));
        }

        [Given("I select long Description button")]
        public void GivenISelectLongDescriptionButton()
        {
            AllureLogger.LogStep("I select long Description button",
             pom.SelectLongDescriptionButton);
        }

        [Given("I enter Campaigns long Description:")]
        public void GivenIEnterCampaignsLongDescription(Table table)
        {
            string LongDescription = table.Rows[0]["Long Description"];
            AllureLogger.LogStep($"I enter long Description: {LongDescription}", () =>
            pom.EnterCampaignLongDescription(LongDescription));
        }

        
        [Given("I click button ok")]
        public void GivenIClickButtonOk()
        {
            AllureLogger.LogStep("I click button ok",
             pom.ClickButtonOk);
        }

        [Given("I enter Campaign Reference:")]
        public void GivenIEnterCampaignReference(Table table)
        {
            string CampaignReference = table.Rows[0]["Campaign Reference"];
            AllureLogger.LogStep($"I enter Campaign Reference: {CampaignReference}", () =>
            pom.EnterCampaignReference(CampaignReference));
        }

        [Given("I open Select Value lookup of priority field")]
        public void GivenIOpenSelectValueLookupOfPriorityField()
        {
            AllureLogger.LogStep("I open Select Value lookup of priority field",
             pom.OpenSelectValueLookupOfPriorityField);
        }

        [Given("I filter table Priority:")]
        public void GivenIFilterTablePriority(Table table)
        {
            string Priority = table.Rows[0]["Priority"];
            AllureLogger.LogStep($"I filter table Priority: {Priority}", () =>
            pom.FilterTablePriority(Priority));
        }

        [Given("I go to tab Work Package")]
        public void GivenIGoToTabWorkPackage()
        {
            AllureLogger.LogStep("I go to tab Work Package",
            pom.GoToTabWorkPackage);
        }

        [Given("I click Select Asset List button")]
        public void GivenIClickSelectAssetListButton()
        {
             AllureLogger.LogStep("I click Select Asset List button",
             pom.ClickSelectAssetListButton);
        }

        [Given("I select the Detail Menu of the asset and go to the Asset List \\(Tr)")]
        public void GivenISelectTheDetailMenuOfTheAssetAndGoToTheAssetListTr()
        {
            AllureLogger.LogStep("I select the Detail Menu of the asset",
            pom.SelectTheDetailMenuOfTheAsset);
            AllureLogger.LogStep("I select Go To The Asset Tr",
            pom.GoToAssetTr);
            AllureLogger.LogStep("Asset Tr Application",
            pom.AssetTrApplication);
        }

        [Given("I filter table Campaigns Asset:")]
        public void GivenIFilterTableCampaignsAsset(Table table)
        {
            string Asset = table.Rows[0]["Asset"];
            AllureLogger.LogStep($"I filter table Campaigns Asset: {Asset}", () =>
            pom.FilterTableCampaignsAsset(Asset));
        }

        [Given("I select no. {int} record from Campaigns Asset table records")]
        public void GivenISelectNo_RecordFromCampaignsAssetTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Campaigns Asset table records",
              () => pom.SelectNoRecordFromCampaignsAssetTableRecords(recordNumber));
        }

        [Given("I select Return With Value option")]
        public void GivenISelectReturnWithValueOption()
        {
            AllureLogger.LogStep("I select Return With Value option",
             pom.SelectReturnWithValueOption);
        }

        [Given("I select the Ok dialog button")]
        public void GivenISelectTheOkDialogButton()
        {
            AllureLogger.LogStep("I select the Ok dialog button",
             pom.SelectTheOkDialogButton);
        }

        [Given("I select no. {int} record from Work Package table records")]
        public void GivenISelectNo_RecordFromWorkPackageTableRecords(int recordNumber)
        {
              AllureLogger.LogStep($"I select no.{recordNumber} from Work Package table records",
              () => pom.SelectNoRecordFromWorkPackageTableRecords(recordNumber));
        }

        [Given("I select the Detail Menu of the Work Location and go to the Locations \\(Tr)")]
        public void GivenISelectTheDetailMenuOfTheWorkLocationAndGoToTheLocationsTr()
        {
            AllureLogger.LogStep("I select the Detail Menu of Work Locations",
            pom.SelectTheDetailMenuOfLocation);
            AllureLogger.LogStep("I select Go To Locations Tr",
            pom.GoToLocationTr);
            AllureLogger.LogStep("Locations Tr Application",
            pom.LocationTrApplication);
        }

        [Given("I filter table Locations:")]
        public void GivenIFilterTableLocations(Table table)
        {
            string Location = table.Rows[0]["Location"];
            AllureLogger.LogStep($"I filter table Location: {Location}", () =>
            pom.FilterTableLocations(Location));
        }

        [Given("I select no. {int} record from Work Location table records")]
        public void GivenISelectNo_RecordFromWorkLocationTableRecords(int recordNumber)
        {
              AllureLogger.LogStep($"I select no.{recordNumber} from Location table records",
               () => pom.SelectNoRecordFromWorkLocationTableRecords(recordNumber));
        }

        [Given("I select the Detail Menu of the Job Plans and go to the Job Plans \\(Tr)")]
        public void GivenISelectTheDetailMenuOfTheJobPlansAndGoToTheJobPlansTr()
        {
            AllureLogger.LogStep("I select the Detail Menu of Job Plans",
            pom.SelectTheDetailMenuOfJobPlans);
            AllureLogger.LogStep("I select Go To Job Plans",
            pom.GoToJobPlans);
            AllureLogger.LogStep("Job Plans Application",
            pom.JobPlansApplication);
        }

        [Given("I press dialog ok button")]
        public void GivenIPressDialogOkButton()
        {
            AllureLogger.LogStep("I press dialog ok button",
            pom.PressDialogOkButton);
        }

        [Given("I Approved Campaign")]
        public void GivenIApprovedCampaign()
        {
            AllureLogger.LogStep("I Approved Campaign",
            pom.ApprovedCampaign);
        }


        [Given("I verify Campaign status")]
        public void GivenIVerifyCampaignStatus()
        {
            AllureLogger.LogStep("I verify Campaign status SCHEDULED",
              pom.VerifyCampaignStatus);
        }

        [Given("I Generate Campaign work order")]
        public void GivenIGenerateCampaignWorkOrder()
        {
            AllureLogger.LogStep("I Generate Campaign work order",
             pom.GenerateCampaignWorkOrder);
        }


        [Given("I wait for generate work order to load")]
        public void GivenIWaitForGenerateWorkOrderToLoad()
        {
            AllureLogger.LogStep("I wait for generate work order to load",
            pom.WaitForGenerateCampaignWorkOrderToLoad);
        }

        [Given("I verify work order is generated")]
        public void GivenIVerifyWorkOrderIsGenerated()
        {
               AllureLogger.LogStep("I verify work order is generated",
               pom.VerifyWorkOrderIsGenerated);
        }

        [Given("I select Ok buttton of system message")]
        public void GivenISelectOkButttonOfSystemMessage()
        {
            AllureLogger.LogStep("I select Ok buttton of system message",
            pom.SelectOkButttonOfSystemMessage);
        }

        [Given("I verify work order generated numbers")]
        public void GivenIVerifyWorkOrderGeneratedNumbers()
        {
            AllureLogger.LogStep("I verify work order generated numbers",
               pom.VerifyWorkOrderGeneratedNumbers);
        }

        [Given("I take screenshot of Creation of Campaigns work order Test Scenario three")]
        public void GivenITakeScreenshotOfCreationOfCampaignsWorkOrderTestScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Creation of Campaigns work order Test Scenario three",
            pom.TakeScreenshotOfCreationOfCampaignsWorkOrderTestScenariothree);
        }












    }
}