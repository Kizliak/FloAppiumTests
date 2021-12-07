using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;

namespace FloAppiumTests.Pages
{
    class WelcomeModePage
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly WebDriverWait _wait;

        public WelcomeModePage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
            _wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 20));
        }

        private readonly By _featureCardPrimaryActionButton = By.Id("org.iggymedia.periodtracker:id/featureCardPrimaryActionButton");

        public WelcomeModePage ClickFeatureCardPrimaryActionButton()
        {
            _wait.Until(ExpectedConditions.ElementExists(_featureCardPrimaryActionButton));
            _driver.FindElement(_featureCardPrimaryActionButton).Click();
            return this;
        }
    }
}