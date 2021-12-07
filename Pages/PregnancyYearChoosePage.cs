using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class PregnancyYearChoosePage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public PregnancyYearChoosePage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _year2000Selector = By.CssSelector("[text=\"2000\"]");
        private readonly By _nextButton = By.Id("org.iggymedia.periodtracker:id/introScreenNext");

        public PregnancyYearChoosePage ChooseYear()
        {
            _driver.FindElement(_year2000Selector).Click();
            _driver.FindElement(_nextButton).Click();
            return this;
        }
    }
}
