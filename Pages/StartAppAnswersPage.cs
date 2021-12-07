using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;

namespace FloAppiumTests.Pages
{
    class StartAppAnswersPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly Helper _helper;

        public StartAppAnswersPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _helper = new Helper(_driver);
        }

        private readonly By _answerButtons = By.CssSelector("[resource-id='org.iggymedia.periodtracker:id/answerTextView']");
        private readonly By _nextButton = By.Id("org.iggymedia.periodtracker:id/nextButton");

        public StartAppAnswersPage ClickAnswerButton(string buttonText)
        {
            _helper.ClickOnButtonByText(buttonText, _answerButtons);
            return this;
        }

        public StartAppAnswersPage ClickNextButton()
        {
            _driver.FindElement(_nextButton).Click();
            return this;
        }
    }
}