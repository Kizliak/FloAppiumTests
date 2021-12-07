using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class ChooseYourPlanWebPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public ChooseYourPlanWebPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _closeButton = By.CssSelector("[text='Close']");

        public ChooseYourPlanWebPage ClickCloseButton()
        {
            _driver.FindElement(_closeButton).Click();
            return this;
        }
    }
}