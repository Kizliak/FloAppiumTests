using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class StartPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public StartPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _acceptAllLink = By.Id("org.iggymedia.periodtracker:id/acceptAllButton");
        private readonly By _NextButton = By.Id("org.iggymedia.periodtracker:id/nextButton");

        public StartPage AcceptAllPrivacy()
        {
            _driver.FindElement(_acceptAllLink).Click();
            return this;
        }

        public StartPage ClickNextButton()
        {
            _driver.FindElement(_NextButton).Click();
            return this;
        }
    }
}
