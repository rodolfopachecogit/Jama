using JamaAutomationFramework.Pages;
using JamaAutomationFramework.Utilities;
using OpenQA.Selenium;
using NUnit.Framework;

namespace JamaAutomationFramework.Steps
{
    [Binding]
    public class StreamSteps
    {
        private readonly IWebDriver _driver;
        private StreamPage _streamPage;

        public StreamSteps()
        {
            _driver = DriverManager.GetDriver();
            _streamPage = new StreamPage(_driver);
        }

        [Then(@"I validate a comment is correctly added")]
        public void ThenIValidateACommentIsCorrectlyAdded()
        {
            _streamPage.ClickAddCommentInt();
            string comment = _streamPage.AddComment();
            _streamPage.ClickAddCommentButton();
            string firstComment = _streamPage.GetCommentTextByIndex(0, comment);
            Assert.That(comment, Is.EqualTo(firstComment),"Comment was not added");
        }
    }
}
