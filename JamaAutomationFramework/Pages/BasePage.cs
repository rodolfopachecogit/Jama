using JamaAutomationFramework.Utilities;
using OpenQA.Selenium;

namespace JamaAutomationFramework.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        protected IWebElement WaitAndFindElement(By locator, int timeoutInSeconds = 10)
        {
            return WaitHelpers.WaitForElementToBeVisible(Driver, locator, timeoutInSeconds);
        }
        public void Click(By locator, int timeoutInSeconds = 10)
        {
            var element = WaitHelpers.WaitForElementToBeClickable(Driver, locator, timeoutInSeconds);
            element.Click();
        }

        public void EnterText(By locator, string text, int timeoutInSeconds = 10)
        {
            var element = WaitAndFindElement(locator, timeoutInSeconds);
            element.Clear();
            element.SendKeys(text);
        }

        /// <summary>
        /// Retrieves the visible text of a web element identified by the given locator.
        /// </summary>
        /// <param name="by">The locator of the web element.</param>
        /// <returns>The visible text of the element.</returns>
        public string GetText(By by)
        {
            try
            {
                return Driver.FindElement(by).Text;
            }
            catch (NoSuchElementException)
            {
                throw new Exception($"Element with locator {by} was not found on the page.");
            }
        }
    }
}
