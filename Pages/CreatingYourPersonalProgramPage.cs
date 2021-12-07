using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class CreatingYourPersonalProgramPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public CreatingYourPersonalProgramPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _dontTakeSapplementsButton = By.Id("android:id/button2");

        public CreatingYourPersonalProgramPage ClickDontTakeSapplementsButton()
        {
            _driver.FindElement(_dontTakeSapplementsButton).Click();
            return this;
        }
    }
}