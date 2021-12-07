using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class MainMenuPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public MainMenuPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _trackCycleButton = By.Id("org.iggymedia.periodtracker:id/btnTrackCycle");

        public string IsSelectedTrackCycleButton()
        {
            return _driver.FindElement(_trackCycleButton).GetAttribute("selected");
        }
    }
}