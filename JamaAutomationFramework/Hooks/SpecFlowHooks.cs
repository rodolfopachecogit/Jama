using JamaAutomationFramework.Utilities;

namespace JamaAutomationFramework.Hooks
{
    [Binding]
    public class SpecFlowHooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            DriverManager.GetDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverManager.QuitDriver();
        }
    }
}
