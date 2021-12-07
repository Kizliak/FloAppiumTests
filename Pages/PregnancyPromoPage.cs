using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class PregnancyPromoPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public PregnancyPromoPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _nextButton = By.Id("org.iggymedia.periodtracker:id/btnNext");

        public PregnancyPromoPage NextButtonClick()
        {
            _driver.FindElement(_nextButton).Click();
            return this;
        }
    }
}
