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

        private readonly By _introScreenNextButton = By.Id("org.iggymedia.periodtracker:id/introScreenNext");

        public DontRememberLastPeriodFirstDayPage ClickIntroScreenNextButton()
        {
            _driver.FindElement(_introScreenNextButton).Click();
            return this;
        }
    }
}