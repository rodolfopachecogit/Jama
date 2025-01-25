using JamaAutomationFramework.Pages;
using JamaAutomationFramework.Utilities;
using OpenQA.Selenium;

namespace JamaAutomationFramework.Steps
{
    [Binding]
    public class HomeSteps
    {
        private readonly IWebDriver _driver;
        private HomePage _homePage;

        public HomeSteps()
        {
            _driver = DriverManager.GetDriver();
            _homePage = new HomePage(_driver);
        }

        [When(@"I navigate to Stream Page")]
        public void WhenINavigateToStreamPage()
        {
            _homePage.ClickStreamMenu();
        }
    }
}
