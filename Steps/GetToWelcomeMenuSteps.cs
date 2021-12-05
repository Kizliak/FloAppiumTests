﻿using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;
using FloAppiumTests.Pages;
using NUnit.Framework;

namespace FloAppiumTests.Features
{
    [Binding]
    public class GetToWelcomeMenuSteps
    {

        private readonly ScenarioContext _scenarioContext;
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly StartPage _startPage;
        private readonly AllowToTrackPage _allowToTrackPage;
        private readonly WelcomePage _welcomePage;
        public GetToWelcomeMenuSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AppiumDriver<AndroidElement>>("driver");
            _startPage = new StartPage(_driver);
            _allowToTrackPage = new AllowToTrackPage(_driver);
            _welcomePage = new WelcomePage(_driver);
        }

        [When(@"I tap on '(.*)' link")]
        public void WhenITapOnLink(string p0)
        {
            _startPage.AcceptAllPrivacy();
        }
        
        [When(@"I tap on '(.*)' button")]
        public void WhenITapOnButton(string p0)
        {
            _startPage.ClickNextButton();
        }
        
        [When(@"I decline tracking my activity")]
        public void WhenIDeclineTrackingMyActivity()
        {
            _allowToTrackPage.ClickNoTrackLink();
        }
        
        [Then(@"I get I see main menu with title '(.*)'")]
        public void ThenIGetISeeMainMenuWithTitle(string welcomeText)
        {
            Assert.AreEqual(welcomeText,_welcomePage.IsWelcomeTextExsist());
        }
    }
}
