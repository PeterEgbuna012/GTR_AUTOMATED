using Allure.Net.Commons;
using GTR_AUTOMATED.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GTR_Automated_Tests.Pages
{
    public class TakeScreenShotPOM
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public TakeScreenShotPOM(IWebDriver driver)
        {
            this.driver = driver;
        }


        /// <summary>
        /// Captures a PNG screenshot and saves it to
        /// &lt;TestContext.WorkDirectory&gt;\Screenshots\{TestName}_{timestamp}.png
        /// It is also attached to the Allure report.
        /// </summary>
        public void TakeScreenshot(IWebDriver driver, string successPath) =>
            AllureLogger.LogStep("Take screenshot", () =>
            {
                var ssDriver = driver as ITakesScreenshot
                                ?? throw new NotSupportedException("Driver does not support screenshots.");

                // Build target path relative to test context
                string testDir = TestContext.CurrentContext.WorkDirectory;
                string folder = Path.Combine(testDir, "Screenshots");
                Directory.CreateDirectory(folder);

                string safeTestName = MakeFsSafe(TestContext.CurrentContext.Test.Name);
                string fileName = $"{safeTestName}_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                string filePath = Path.Combine(folder, fileName);

                // Capture and save
                var screenshot = ssDriver.GetScreenshot();
                screenshot.SaveAsFile(filePath);

                // Attach to Allure
                AllureLogger.AddScreenshot(fileName, screenshot.AsByteArray);
            });

        /* ---------------------------------------------------------------
         * Helpers
         * -------------------------------------------------------------*/
        private static string MakeFsSafe(string name)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
                name = name.Replace(c, '_');
            return name.Trim();
        }
    }
}
