using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class TrackMyCycleMainPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public TrackMyCycleMainPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _primaryText = By.Id("org.iggymedia.periodtracker:id/primaryText");
        private readonly By _menuButton = By.CssSelector("[resource-id='org.iggymedia.periodtracker:id/iconView']");

        public string GetPrimaryText()
        {
            return _driver.FindElement(_primaryText).Text;
        }

        public TrackMyCycleMainPage ClickMenuButon()
        {
            _driver.FindElement(_menuButton).Click();
            return this;
        }
    }
}