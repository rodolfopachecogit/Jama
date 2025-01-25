using OpenQA.Selenium;
using JamaAutomationFramework.Utilities;

namespace JamaAutomationFramework.Pages
{
    public class LoginPage : BasePage
    {
        private readonly string BaseUrl = ConfigurationManager.GetValue("BaseUrl");
     
        //Locators.
        private By UsernameField => By.Id("j_username");
        private By PasswordField => By.Id("j_password");
        private By LoginButton => By.Id("loginButton");
        private By LoginVersionNumber => By.XPath("//span[@class='j-login-version-number']");

        //Methods.
        public LoginPage(IWebDriver driver) : base(driver) { }

        public void NavigateToLoginPage()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
        }

        public void Login()
        {
            EnterText(UsernameField, ConfigurationManager.GetUsername());
            EnterText(PasswordField, ConfigurationManager.GetPassword());
            Click(LoginButton);
        }

        public string GetLoginVersionNumberText() => GetText(LoginVersionNumber);
    }
}
