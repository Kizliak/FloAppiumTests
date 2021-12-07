using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class PregnancyWeeksChoosePage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public PregnancyWeeksChoosePage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _dontRememberButton = By.Id("org.iggymedia.periodtracker:id/introUnknownCheckBox");
        private readonly By _nextButton = By.Id("org.iggymedia.periodtracker:id/introScreenNext");

        public PregnancyWeeksChoosePage iDontRememberButtonClick()
        {
            _driver.FindElement(_dontRememberButton).Click();
            _driver.FindElement(_nextButton).Click();
            return this;
        }
    }
}
