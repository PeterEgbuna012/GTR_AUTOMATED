using GTR_AUTOMATED.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace GTR_Automated_Tests.Pages
{
    /// <summary>
    /// Handles all arcad1s2026 login flows.
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


                case "store":
                    LoginAsStore();
                    break;


                case "maxadmin":
                case "max admin":
                    LoginAsMaxAdmin();
                    break;


                case "cms admin":
                    LoginAsCMSADMIN();
                    break;

                case "cms admin team leader":
                    LoginAsCMSADMINTEAMLEADER();
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

                case "fault person":
                    LoginAsFaultPerson();
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
                    LoginAsMaximoAdministrator();
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

        public void LoginAsStoresPerson() => LoginAs("PHIL.STEVENS@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsFaultAnalyst() => LoginAs("MARK.TICKNER@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsMaterialsController() => LoginAs("PAUL.BANKS@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsTeamLeaderStores() => LoginAs("MICHAEL.FLYNN@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsTeamLeader() => LoginAs("IAN.SCOTT@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsStoresPersonHornsey() => LoginAs("STEVE.DARANJO@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsSandMaster() => LoginAs("ANDREW.BOLTON@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsStore() => LoginAs("GARY.HENDLEY@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsFaultPerson() => LoginAs("ANDREW.BOLTON@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsAdmin() => LoginAs("PETER.REED@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsMaxAdmin() => LoginAs("MAXADMIN", "4Jre*LXEir4C");

        public void LoginAsCMSADMIN() => LoginAs("ANDY.RICHARDS@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsCMSADMINTEAMLEADER() => LoginAs("ANDY.RICHARDS@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsCMSManager() => LoginAs("ANDY.RICHARDS@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsTrainingManager() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsMaintainerTeamLeader() => LoginAs("IAN.SCOTT@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsTeamLeaderMaintainer() => LoginAs("IAN.SCOTT@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsstores() => LoginAs("GARY.HENDLEY@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsMaintainer() => LoginAs("ANTHONY.BRACE@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsMaterialsDepotManager() => LoginAs("GRAEME.TAYLOR@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsCleanMaster() => LoginAs("ANDREW.BOLTON@GTRAILWAY.COM", "arcad1s2026");

        public void PanelOperationsManager() => LoginAs("PEGBUNA", "maximo");

        public void FleetControl() => LoginAs("PEGBUNA", "maximo");

        public void FamUser() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsCleanMasterTeamLeader() => LoginAs("PEGBUNA", "maximo");

        public void LoginAsMaximoAdministrator() => LoginAs("PETER.REED@GTRAILWAY.COM", "arcad1s2026");
               
        public void LoginAsCmsTeamLeader() => LoginAs("ANDY.RICHARDS@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsWarrantyManager() => LoginAs("BARRY.BRIDGES@GTRAILWAY.COM", "arcad1s2026");

        public void LoginAsMaterialsSupplyChainSupport() => LoginAs("JILL.FEDERICO@GTRAILWAY.COM", "arcad1s2026");
    }
}