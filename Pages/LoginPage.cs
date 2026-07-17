using GTR_AUTOMATED.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace GTR_Automated_Tests.Pages
{
    /// <summary>
    /// Handles all Maximo login flows.
    /// Every public method is a one-liner that wraps a common private LoginAs() helper
    /// so credentials live in exactly one place and every attempt is reported to Allure.
    /// </summary>
    public class LoginPage
    {
        private readonly IWebDriver driver;

        /* ----- Locators ----- */
        private readonly By userField = By.Id("username");
        private readonly By passField = By.Id("password");
        private readonly By submitBtn = By.CssSelector("#loginform > div > input[type=submit]");

        public LoginPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        /* ---------- Core helper ---------- */

       
    private void LoginAs(string user, string pass) =>
    AllureLogger.LogStep($"Login as {user}", () =>
    {
        SafeActions.EnterText(driver, userField, user, "Username field");
        SafeActions.EnterText(driver, passField, pass, "Password field");
        SafeActions.Click(driver, submitBtn, "Submit button");
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
        wait.Until(SeleniumWaits.ElementExists(By.Id("titlebar-tb_appname")));
    });

    /* ---------- Generic Role Login ---------- */

    public void LoginAsRole(string role)
        {
            switch (role.Trim().ToLowerInvariant())
            {
                case "training manager":
                    LoginAsTrainingManager();
                    break;

                case "stores person":
                    LoginAsStoresPerson();
                    break;

                case "fault analyst":
                    LoginAsFaultAnalyst();
                    break;

                case "materials controller":
                    LoginAsMaterialsController();
                    break;

                case "team leader stores":
                    LoginAsTeamLeaderStores();
                    break;

                case "teamlead":
                    LoginAsTeamLeader();
                    break;

                case "stores person hornsey":
                    LoginAsStoresPersonHornsey();
                    break;

                case "sand master":
                    LoginAsSandMaster();
                    break;

                case "admin":
                    LoginAsAdmin();
                    break;


                case "maxadmin":
                case "max admin":
                    LoginAsMaxAdmin();
                    break;


                case "cms admin":
                    LoginAsCMSADMIN();
                    break;

                case "cms manager":
                    LoginAsCMSManager();
                    break;

                case "maintainer team leader":
                    LoginAsMaintainerTeamLeader();
                    break;

                case "team leader maintainer":
                    LoginAsTeamLeaderMaintainer();
                    break;

                case "stores":
                    LoginAsstores();
                    break;

                case "maintainer":
                    LoginAsMaintainer();
                    break;

                case "materials depot manager":
                    LoginAsMaterialsDepotManager();
                    break;

                case "clean master":
                    LoginAsCleanMaster();
                    break;

                case "panel operations manager":
                    PanelOperationsManager();
                    break;

                case "fleet control":
                    FleetControl();
                    break;

                case "fam user":
                    FamUser();
                    break;

                case "clean master team leader":
                    LoginAsCleanMasterTeamLeader();
                    break;

                case "maximo administrator":
                    LoginAsMaximoadministrator();
                    break;

                case "cms team leader":
                    LoginAsCmsTeamLeader();
                    break;

                case "warranty manager":
                    LoginAsWarrantyManager();
                    break;

                case "materials supply chain support":
                    LoginAsMaterialsSupplyChainSupport();
                    break;

                default:
                    throw new ArgumentException(
                        $"Role '{role}' is not configured in LoginPage.");
            }
        }

        /* ---------- Role-specific one-liners ---------- */

        public void LoginAsStoresPerson() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsFaultAnalyst() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsMaterialsController() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsTeamLeaderStores() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsTeamLeader() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsStoresPersonHornsey() => LoginAs("MDUMPHY", "maximo");

        public void LoginAsSandMaster() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsAdmin() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsMaxAdmin() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsCMSADMIN() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsCMSManager() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsTrainingManager() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsMaintainerTeamLeader() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsTeamLeaderMaintainer() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsstores() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsMaintainer() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsMaterialsDepotManager() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsCleanMaster() => LoginAs("PEGBUNA", "maximo");

        public void PanelOperationsManager() => LoginAs("POM-UAT1", "maximo");

        public void FleetControl() => LoginAs("POM-UAT2", "maximo");

        public void FamUser() => LoginAs("ENG-UAT16", "maximo");

        public void LoginAsCleanMasterTeamLeader() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsMaximoadministrator() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsCmsTeamLeader() => LoginAs("POM-UAT1", "maximo");

        public void LoginAsWarrantyManager() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsMaterialsSupplyChainSupport() => LoginAs("PEGBUNA", "maximo");
    }
}