using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;
using FloAppiumTests.Pages;
using NUnit.Framework;

namespace FloAppiumTests.Steps
{
    [Binding]
    public class TrackMyCycleSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly WelcomePage _welcomePage;

        public TrackMyCycleSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AppiumDriver<AndroidElement>>("driver");
            _welcomePage = new WelcomePage(_driver);
        }

        [When(@"I tap on Track my cycle button")]
        public void WhenITapOnTrackMyCycleButton()
        {
            _welcomePage.ClickWantTrackCycleButton();
        }
    }
}
