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

        private readonly By _closeButton = By.CssSelector("[elementId='00000000-0000-008f-0000-00070000012f']");

        public ChooseYourPlanWebPage ClickCloseButton()
        {
            _driver.FindElement(_closeButton).Click();
            return this;
        }
    }
}