using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class WhenDidYourLastPeriodStartPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public WhenDidYourLastPeriodStartPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _introUnknownCheckBox = By.Id("org.iggymedia.periodtracker:id/introUnknownCheckBox");

        public WhenDidYourLastPeriodStartPage ClickIntroUnknownCheckBox()
        {
            _driver.FindElement(_introUnknownCheckBox).Click();
            return this;
        }
    }
}