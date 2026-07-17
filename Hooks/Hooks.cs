using Allure.Net.Commons;
using GTR_AUTOMATED.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using Reqnroll.BoDi;


//[assembly: Parallelizable(ParallelScope.Fixtures)]
namespace GTR_AUTOMATED.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _container;
        private static readonly AllureLifecycle Allure = AllureLifecycle.Instance;

        public Hooks(IObjectContainer container) => _container = container;

        [SetUpFixture]
        public class GlobalSetup
        {
            [OneTimeSetUp]
            public void BeforeAnyTests()
            {
                Allure.CleanupResultDirectory();
                Directory.CreateDirectory("allure-results");
                File.WriteAllLines("allure-results/environment.properties", new[]
                {
                    "Environment=TEST",
                    "Browser=Chrome",
                    "BaseURL=https://gtrtest.eams-cloud.com",
                    $"RunDate={DateTime.Now:yyyy-MM-dd HH:mm}"
                });
            }
        }

        [BeforeScenario(Order = 0)]
        public void SetupDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--incognito");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--no-sandbox");
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            var driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://gtrtest.eams-cloud.com/maximo/webclient/login/login.jsp");
            _container.RegisterInstanceAs<IWebDriver>(driver);
        }
               

        [AfterScenario]
        public void TeardownDriver(ScenarioContext ctx)
        {
            var driver = _container.Resolve<IWebDriver>();
            if (ctx.TestError != null)
            {
                var png = ((ITakesScreenshot)driver).GetScreenshot().AsByteArray;
                AllureLogger.AddScreenshot("Failure", png);
                AllureLogger.LogError(ctx.TestError, "Scenario failure");
            }

            driver.Quit();
            driver.Dispose();
        }

        [BeforeStep] public void BeforeStep() => Console.WriteLine("➡ Step start");
        [AfterStep] public void AfterStep() => Console.WriteLine("⬅ Step end");
        [BeforeFeature] public static void BeforeFeature(FeatureContext f) => Console.WriteLine($"⏩ Feature: {f.FeatureInfo.Title}");
        [AfterFeature] public static void AfterFeature(FeatureContext f) => Console.WriteLine($"🔚 Feature done");
    }
}
