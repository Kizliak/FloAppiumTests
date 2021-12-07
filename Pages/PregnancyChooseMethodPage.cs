using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class PregnancyChooseMethodPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public PregnancyChooseMethodPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _firstDayOfLastPeriodCheckBox = By.Id("org.iggymedia.periodtracker:id/lastCycleDateCheckBox");
        private readonly By _nextButton = By.Id("org.iggymedia.periodtracker:id/introScreenNext");

        public PregnancyChooseMethodPage FirstDayOfLastPeriodChoose()
        {
            _driver.FindElement(_firstDayOfLastPeriodCheckBox).Click();
            _driver.FindElement(_nextButton).Click();
            return this;
        }
    }
}
