using OpenQA.Selenium;

namespace JamaAutomationFramework.Utilities;

public static class JavaScriptHelpers
{
    /// <summary>
    /// Sets focus to the specified field using JavaScript.
    /// </summary>
    /// <param name="driver">The WebDriver instance.</param>
    /// <param name="locator">The locator of the field to focus on.</param>
    public static void SetFocusToField(IWebDriver driver, By locator)
    {
        var element = driver.FindElement(locator);
        var jsExecutor = (IJavaScriptExecutor)driver;
        jsExecutor.ExecuteScript("arguments[0].focus();", element);
    }
}
