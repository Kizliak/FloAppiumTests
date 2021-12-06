using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class WelcomeModePage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public WelcomeModePage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _featureCardPrimaryActionButton = By.Id("org.iggymedia.periodtracker:id/featureCardPrimaryActionButton");

        public WelcomeModePage ClickFeatureCardPrimaryActionButton()
        {
            _driver.FindElement(_featureCardPrimaryActionButton).Click();
            return this;
        }
    }
}