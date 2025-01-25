using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace JamaAutomationFramework.Utilities
{
    public static class WaitHelpers
    {
        /// <summary>
        /// Waits until an element is visible on the page.
        /// </summary>
        /// <param name="driver">The WebDriver instance.</param>
        /// <param name="locator">The locator of the element to wait for.</param>
        /// <param name="timeoutInSeconds">The timeout in seconds.</param>
        /// <returns>The located IWebElement.</returns>
        public static IWebElement WaitForElementToBeVisible(IWebDriver driver, By locator, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        /// <summary>
        /// Waits until an element is clickable.
        /// </summary>
        /// <param name="driver">The WebDriver instance.</param>
        /// <param name="locator">The locator of the element to wait for.</param>
        /// <param name="timeoutInSeconds">The timeout in seconds.</param>
        /// <returns>The located IWebElement.</returns>
        public static IWebElement WaitForElementToBeClickable(IWebDriver driver, By locator, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        /// <summary>
        /// Waits until a specific condition is met (custom wait).
        /// </summary>
        /// <param name="driver">The WebDriver instance.</param>
        /// <param name="condition">The condition to wait for.</param>
        /// <param name="timeoutInSeconds">The timeout in seconds.</param>
        public static void WaitForCondition(IWebDriver driver, Func<IWebDriver, bool> condition, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(condition);
        }
    }
}
