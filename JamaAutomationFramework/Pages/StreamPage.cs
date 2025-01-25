using OpenQA.Selenium;
using JamaAutomationFramework.Utilities;

namespace JamaAutomationFramework.Pages
{
    public class StreamPage : BasePage
    {
        //Locators.
        private By AddCommentInt => By.XPath("//div[@class='add-comment-interactions']");
        private By AddCommentField => By.Id("js-add-comment-field");
        private By AddCommentButton => By.XPath("//button[contains(@class,'add-comment')]");

        //Methods.
        public StreamPage(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// Generates a list of locators based on the provided text.
        /// </summary>
        /// <param name="text">The dynamic text to include in the locator.</param>
        /// <returns>A list of By locators.</returns>
        public List<By> GetCommentsList(string text)
        {
            return new List<By>
            {
                By.XPath($"//div[@class='js-root-comment-text-wrapper']/p[text()='{text}']")
            };
        }
        public string AddComment() {
            string comment = "Comment" + StringUtils.GenerateRandomString(10);
            EnterText(AddCommentField, comment);
            return comment;
        }

        public void ClickAddCommentInt() => Click(AddCommentInt);
        public void ClickAddCommentButton() => Click(AddCommentButton);

        public By GetLocator(int index, string text)
        {
            // Generate the dynamic list of locators
            List<By> dynamicCommentsList = GetCommentsList(text);

            // Validate the index and return the appropriate locator
            if (index >= 0 && index < dynamicCommentsList.Count)
            {
                return dynamicCommentsList[index];
            }

            // Throw exception if the index is out of range
            throw new IndexOutOfRangeException("Invalid index for the dynamic comments list.");
        }


        /// <summary>
        /// Gets the Comment Text Using an Specific Index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Text on the comment.</returns>
        public string GetCommentTextByIndex(int index, string comment) {
            By specificLocator = GetLocator(index, comment);

            // Wait for the element to be visible
            var element = WaitHelpers.WaitForElementToBeVisible(Driver, specificLocator, 10);

            // Return the text of the visible element
            return element.Text;
        }
    }
}
