using Allure.Net.Commons;
using GTR_AUTOMATED.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using Reqnroll.BoDi;

namespace GTR_AUTOMATED.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _container;
        private readonly ScenarioContext _scenarioContext;

        private static readonly AllureLifecycle Allure = AllureLifecycle.Instance;

        public Hooks(
            IObjectContainer container,
            ScenarioContext scenarioContext)
        {
            _container = container;
            _scenarioContext = scenarioContext;
        }



        [BeforeScenario(Order = -100)]
        public void AddAllureLabels()
        {
            foreach (var tag in _scenarioContext.ScenarioInfo.Tags)
            {
                if (tag.StartsWith(
                    "allure.label.epic:",
                    StringComparison.OrdinalIgnoreCase))
                {
                    AllureApi.AddEpic(
                        tag.Replace(
                            "allure.label.epic:",
                            "",
                            StringComparison.OrdinalIgnoreCase));
                }

                if (tag.StartsWith(
                    "allure.label.feature:",
                    StringComparison.OrdinalIgnoreCase))
                {
                    AllureApi.AddFeature(
                        tag.Replace(
                            "allure.label.feature:",
                            "",
                            StringComparison.OrdinalIgnoreCase));
                }

                if (tag.StartsWith(
                    "allure.label.story:",
                    StringComparison.OrdinalIgnoreCase))
                {
                    AllureApi.AddStory(
                        tag.Replace(
                            "allure.label.story:",
                            "",
                            StringComparison.OrdinalIgnoreCase));
                }

                if (tag.StartsWith(
                    "allure.label.severity:",
                    StringComparison.OrdinalIgnoreCase))
                {
                    AllureApi.AddLabel(
                        "severity",
                        tag.Replace(
                            "allure.label.severity:",
                            "",
                            StringComparison.OrdinalIgnoreCase));
                }

                if (tag.StartsWith(
                    "allure.label.owner:",
                    StringComparison.OrdinalIgnoreCase))
                {
                    AllureApi.AddLabel(
                        "owner",
                        tag.Replace(
                            "allure.label.owner:",
                            "",
                            StringComparison.OrdinalIgnoreCase));
                }

                if (tag.StartsWith(
                    "allure.label.layer:",
                    StringComparison.OrdinalIgnoreCase))
                {
                    AllureApi.AddLabel(
                        "layer",
                        tag.Replace(
                            "allure.label.layer:",
                            "",
                            StringComparison.OrdinalIgnoreCase));
                }

                if (tag.StartsWith(
                    "allure.label.suite:",
                    StringComparison.OrdinalIgnoreCase))
                {
                    AllureApi.AddLabel(
                        "suite",
                        tag.Replace(
                            "allure.label.suite:",
                            "",
                            StringComparison.OrdinalIgnoreCase));
                }

                if (tag.StartsWith(
                    "allure.label.subsuite:",
                    StringComparison.OrdinalIgnoreCase))
                {
                    AllureApi.AddLabel(
                        "subSuite",
                        tag.Replace(
                            "allure.label.subsuite:",
                            "",
                            StringComparison.OrdinalIgnoreCase));
                }
            }
        }

        [SetUpFixture]
        public class GlobalSetup
        {
            [OneTimeSetUp]
            public void BeforeAnyTests()
            {
                var currentDirectory = Directory.GetCurrentDirectory();

                Console.WriteLine(
                    $"Current Directory: {currentDirectory}");

                var allureResults =
                    Path.Combine(currentDirectory, "allure-results");

                var allureReport =
                    Path.Combine(currentDirectory, "allure-report");

                var sourceHistory =
                    Path.Combine(allureReport, "history");

                var targetHistory =
                    Path.Combine(allureResults, "history");

                if (!Directory.Exists(allureResults))
                {
                    Directory.CreateDirectory(allureResults);
                }

                // Copy history from previous report
                if (Directory.Exists(sourceHistory))
                {
                    Directory.CreateDirectory(targetHistory);

                    foreach (var file in Directory.GetFiles(sourceHistory))
                    {
                        File.Copy(
                            file,
                            Path.Combine(
                                targetHistory,
                                Path.GetFileName(file)),
                            true);
                    }

                    Console.WriteLine(
                        $"History copied from: {sourceHistory}");
                }
                else
                {
                    Console.WriteLine(
                        $"History folder not found: {sourceHistory}");
                }

                // Environment Properties
                File.WriteAllLines(
                    Path.Combine(
                        allureResults,
                        "environment.properties"),
                    new[]
                    {
                "Environment=TEST",
                "Application=GTR",
                "Framework=Reqnroll",
                "Browser=Chrome",
                $"RunDate={DateTime.Now:yyyy-MM-dd HH:mm}"
                    });

                // Executor information
                var executorJson = """
               {
                  "type":"NUnit",
                  "buildName":"GTR Automation Run",
                   "buildOrder":1
               }
               """;

                File.WriteAllText(
                    Path.Combine(
                        allureResults,
                        "executor.json"),
                    executorJson);
            }
        }

        [BeforeScenario(Order = 0)]
        public void SetupDriver()
        {
            var options = new ChromeOptions();

            options.AddArgument("--incognito");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--no-sandbox");

            options.AddUserProfilePreference(
                "credentials_enable_service",
                false);

            options.AddUserProfilePreference(
                "profile.password_manager_enabled",
                false);

            var driver = new ChromeDriver(options);

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl(
                "https://gtrtest.eams-cloud.com/maximo/webclient/login/login.jsp");

            _container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void TeardownDriver()
        {
            var driver = _container.Resolve<IWebDriver>();

            try
            {
                if (_scenarioContext.TestError != null)
                {
                    var screenshot =
                        ((ITakesScreenshot)driver)
                        .GetScreenshot()
                        .AsByteArray;

                    AllureLogger.AddScreenshot(
                        "Failure Screenshot",
                        screenshot);

                    AllureLogger.LogError(
                        _scenarioContext.TestError,
                        "Scenario Failure");
                }
            }
            finally
            {
                driver.Quit();
                driver.Dispose();
            }
        }

        [BeforeStep]
        public void BeforeStep()
        {
            Console.WriteLine("➡ Step start");
        }

        [AfterStep]
        public void AfterStep()
        {
            Console.WriteLine("⬅ Step end");
        }

        [BeforeFeature]
        public static void BeforeFeature(
            FeatureContext featureContext)
        {
            Console.WriteLine(
                $"⏩ Feature: {featureContext.FeatureInfo.Title}");
        }

        [AfterFeature]
        public static void AfterFeature(
            FeatureContext featureContext)
        {
            Console.WriteLine("🔚 Feature done");
        }
    }
}