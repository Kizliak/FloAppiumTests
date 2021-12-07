using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class AllowToTrackPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public AllowToTrackPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _noTrackLink = By.Id("org.iggymedia.periodtracker:id/alertFirstButton");

        public AllowToTrackPage ClickNoTrackLink()
        {
            _driver.FindElement(_noTrackLink).Click();
            return this;
        }
    }
}