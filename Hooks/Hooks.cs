using FloAppiumTests.Drivers;
using OpenQA.Selenium.Appium.Android;
using System.Threading;
using TechTalk.SpecFlow;

namespace FloAppiumTests.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        public readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            AppiumDriver appiumDriver = new AppiumDriver();
            _scenarioContext.Set(appiumDriver.InitializeAppium(), "driver");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Thread.Sleep(4000);
            _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver").Dispose();
        }
    }
}
