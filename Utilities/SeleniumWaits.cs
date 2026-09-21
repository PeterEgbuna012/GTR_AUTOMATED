using OpenQA.Selenium;

namespace GTR_AUTOMATED.Utilities
{
    public static class SeleniumWaits
    {
        public static Func<IWebDriver, IWebElement> ElementIsVisible(By locator)
        {
            return driver =>
            {
                try
                {
                    var element = driver.FindElement(locator);

                    if (element.Displayed)
                        return element;

                    return null;
                }
                catch
                {
                    return null;
                }
            };
        }

        public static Func<IWebDriver, IWebElement> ElementToBeClickable(By locator)
        {
            return driver =>
            {
                try
                {
                    var element = driver.FindElement(locator);

                    if (element.Displayed && element.Enabled)
                        return element;

                    return null;
                }
                catch
                {
                    return null;
                }
            };
        }


        public static Func<IWebDriver, IWebElement> ElementExists(By locator)
        {
            return driver =>
            {
                try
                {
                    return driver.FindElement(locator);
                }
                catch
                {
                    return null;
                }
            };
        }

        public static Func<IWebDriver, IWebDriver> FrameToBeAvailableAndSwitchToIt(By locator)
        {
            return driver =>
            {
                try
                {
                    IWebElement frame = driver.FindElement(locator);

                    driver.SwitchTo().Frame(frame);

                    return driver;
                }
                catch
                {
                    return null;
                }
            };
        }

        public static Func<IWebDriver, bool> InvisibilityOfElementLocated(By locator)
        {
            return driver =>
            {
                try
                {
                    var element = driver.FindElement(locator);

                    return !element.Displayed;
                }
                catch (NoSuchElementException)
                {
                    return true;
                }
                catch (StaleElementReferenceException)
                {
                    return true;
                }
            };
        }





    }
}