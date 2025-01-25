using OpenQA.Selenium;

namespace JamaAutomationFramework.Pages
{
    public class HomePage : BasePage
    {
        //Locators.
        private By StreamMenu => By.XPath("//nav[@id='j-contour-header-tabs']//a[text()='Stream']");

        //Methods.
        public HomePage(IWebDriver driver) : base(driver) { }

        public void ClickStreamMenu() => Click(StreamMenu);
    }
}
