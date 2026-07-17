using Allure.Net.Commons;
using OpenQA.Selenium;
using System;
using System.Text;


namespace GTR_AUTOMATED.Utilities
{
    /// <summary>
    /// Thin wrapper around the Allure 2 runtime helpers
    /// plus a few convenience methods for screenshots, text,
    /// and (now) the user’s login role.
    /// </summary>
    public static class AllureLogger
    {
        private static readonly AllureLifecycle Allure = AllureLifecycle.Instance;

        /* ---------- step helpers ---------- */


        public static void LogStep(string name, Action action)
        {
            AllureApi.Step(name, () =>
            {
                try
                {
                    action();
                }
                catch (Exception ex)
                {
                    LogError(name, ex);
                    throw;
                }
            });
        }


        /* ---------- attachments ---------- */

        public static void AddTextAttachment(string title, string content) =>
            AllureApi.AddAttachment(
                title,
                "text/plain",
                Encoding.UTF8.GetBytes(content));

        public static void AddScreenshot(string title, byte[] png) =>
            AllureApi.AddAttachment(title, "image/png", png);

        /* ---------- error and logging ---------- */

        public static void LogInfo(string message)
        {
            // Optional: log to console for visibility
            Console.WriteLine("[INFO] " + message);

            // Add to Allure as a named step or text attachment
            Allure.UpdateTestCase(tc =>
            {
                tc.steps.Add(new StepResult
                {
                    name = "[INFO] " + message,
                    status = Status.passed
                });
            });
        }

        public static void LogError(string message, Exception ex)
        {
            Console.WriteLine("[ERROR] " + message + " | " + ex.Message);

            Allure.UpdateTestCase(tc =>
            {
                tc.steps.Add(new StepResult
                {
                    name = "[ERROR] " + message,
                    status = Status.failed,
                    statusDetails = new StatusDetails
                    {
                        message = ex.Message,
                        trace = ex.ToString()
                    }
                });
            });

            // Optionally, add a full attachment of the exception for detailed review
            AddTextAttachment($"Exception – {message}", ex.ToString());
        }

        public static void LogError(Exception ex, string context) =>
            AddTextAttachment($"Exception – {context}", ex.ToString());

        public static void SetUserLoginRole(string role)
        {
            if (string.IsNullOrWhiteSpace(role)) return;

            // 1️⃣ Parameter in the test-case header
            Allure.UpdateTestCase(tc =>
            {
                tc.parameters.RemoveAll(p => p.name == "User role");
                tc.parameters.Add(new Parameter { name = "User role", value = role });
            });

            // 2️⃣ Small attachment for step-level visibility
            AddTextAttachment("User role", role);
        }




       


    }
}
