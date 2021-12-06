using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;

namespace FloAppiumTests.Pages
{
    class CreatingYourPersonalProgramPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly WebDriverWait _wait;

        public CreatingYourPersonalProgramPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
            _wait = new WebDriverWait(_driver, new TimeSpan(0,0,20));
        }

        private readonly By _dontTakeSapplementsButton = By.Id("android:id/button2");

        public CreatingYourPersonalProgramPage ClickDontTakeSapplementsButton()
        {
            _driver.FindElement(_dontTakeSapplementsButton).Click();
            return this;
        }
    }
}