using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class IsYourMenstrualCycleRegularPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public IsYourMenstrualCycleRegularPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _answerFirstButton = By.CssSelector("[resource-id=\"org.iggymedia.periodtracker:id/answerTextView\"]");

        public IsYourMenstrualCycleRegularPage ClickAnswerFirstButton()
        {
            _driver.FindElement(_answerFirstButton).Click();
            return this;
        }
    }
}