using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class DontRememberLastPeriodFirstDayPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public DontRememberLastPeriodFirstDayPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _introScreenNext = By.Id("org.iggymedia.periodtracker:id/introScreenNext");

        public DontRememberLastPeriodFirstDayPage ClickIntroScreenNext()
        {
            _driver.FindElement(_introScreenNext).Click();
            return this;
        }
    }
}