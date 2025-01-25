using JamaAutomationFramework.Pages;
using JamaAutomationFramework.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace JamaAutomationFramework.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _driver;
        private LoginPage _loginPage;

        public LoginSteps()
        {
            _driver = DriverManager.GetDriver();
            _loginPage = new LoginPage(_driver);
        }

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            _loginPage.NavigateToLoginPage();
        }

        [When(@"I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            _loginPage.Login();
        }

        [Then(@"I validate version text is displayed")]
        public void ThenIValidateVersionTextIsDisplayed()
        {
            Assert.IsNotEmpty(_loginPage.GetLoginVersionNumberText());
        }
    }
}
