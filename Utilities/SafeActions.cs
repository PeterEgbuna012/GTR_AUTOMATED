using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace GTR_AUTOMATED.Utilities
{
    /// <summary>
    /// Provides resilient Selenium interactions with retries and logging.
    /// </summary>
    public static class SafeActions
    {
        /* ---------- Public Actions ---------- */

        public static void Click(IWebDriver driver, By by, string humanName,
                                int timeoutSec = 50, int retries = 2) =>
            Execute(driver, humanName, retries, () =>
            {
                var el = Wait(driver, by, timeoutSec,
                    SeleniumWaits.ElementToBeClickable);
                el.Click();
            });

        public static void EnterText(IWebDriver driver, By by, string text,
                                    string humanName, int timeoutSec = 50,
                                    int retries = 2) =>
            Execute(driver, humanName, retries, () =>
            {
                var el = Wait(driver, by, timeoutSec,
                    SeleniumWaits.ElementIsVisible);
                el.Clear();
                el.SendKeys(text);
            });

        public static string GetText(IWebDriver driver, By by,
                                    string humanName,
                                    int timeoutSec = 50, int retries = 2)
        {
            string value = string.Empty;

            Execute(driver, humanName, retries, () =>
            {
                var el = Wait(driver, by, timeoutSec,
                    SeleniumWaits.ElementIsVisible);
                value = el.Text;
            });

            return value;
        }

        public static void DoubleClick(IWebDriver driver, By by, string humanName,
                                      int timeoutSec = 50, int retries = 2) =>
            Execute(driver, humanName, retries, () =>
            {
                var el = Wait(driver, by, timeoutSec,
                    SeleniumWaits.ElementToBeClickable);

                var actions = new Actions(driver);
                actions.DoubleClick(el).Perform();
            });

        public static void ContextClick(IWebDriver driver, By by, string humanName,
                                       int timeoutSec = 50, int retries = 2) =>
            Execute(driver, humanName, retries, () =>
            {
                var el = Wait(driver, by, timeoutSec,
                    SeleniumWaits.ElementIsVisible);

                var actions = new Actions(driver);
                actions.ContextClick(el).Perform();
            });

        public static void ClearAndEnterText(IWebDriver driver, By locator,
                                             string text, string description)
        {
            Execute(driver, description, 1, () =>
            {
                var element = driver.FindElement(locator);
                element.Clear();
                element.SendKeys(text);
            });
        }

        /* ---------- Helpers ---------- */

        private static IWebElement Wait(IWebDriver driver, By by, int timeout,
            Func<By, Func<IWebDriver, IWebElement>> condition)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            return wait.Until(condition(by));
        }

        private static void Execute(IWebDriver driver, string description,
                                   int retries, Action body)
        {
            int attempt = 0;

            while (true)
            {
                try
                {
                    body();
                    return;
                }
                catch (Exception ex)
                {
                    attempt++;

                    if (attempt > retries)
                    {
                        AllureLogger.LogError($"Failed action: {description}", ex);
                        AttachScreenshot(driver, description);
                        throw;
                    }

                    Task.Delay(5000).Wait();
                }
            }
        }

        private static void AttachScreenshot(IWebDriver driver, string description)
        {
            if (driver is ITakesScreenshot ts)
            {
                var screenshot = ts.GetScreenshot().AsByteArray;
                AllureLogger.AddScreenshot($"Failure - {description}", screenshot);
            }
        }
    }
}