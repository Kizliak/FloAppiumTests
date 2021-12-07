using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;
using FloAppiumTests.Pages;
using NUnit.Framework;
using System.Threading;

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

        [When(@"I tap on agree checkbox '(.*)'")]
        public void WhenITapOnAgreeCheckbox(string checkboxText)
        {
            if (checkboxText == "I agree to Privacy Policy")
            {
                _startPage.SelectPrivacyTermsCheckBox();
            }
            else if (checkboxText == "I agree to processing of my personal health")
            {
                _startPage.SelectHealthDataCheckBox();
            }
            Thread.Sleep(2000);
        }

        [Then(@"'(.*)' checkbox is selected")]
        public void ThenIsChecked(string checkboxText)
        {
            if (checkboxText == "I agree to Privacy Policy")
            {
                Assert.IsTrue(_startPage.CheckIfCheckBoxIsSelected(1));
            }
            else if (checkboxText == "I agree to processing of my personal health")
            {
                Assert.IsTrue(_startPage.CheckIfCheckBoxIsSelected(2));
            }
        }

        [Then(@"'(.*)' button is not active")]
        public void ThenButtonIsNotActive(string p0)
        {
            Assert.IsFalse(_startPage.CheckIfNextButtonIsEnabled());
        }

        [Given(@"Welcome menu is open")]
        public void GivenWelcomeMenuIsOpen()
        {
            _startPage.AcceptAllPrivacy();
            _startPage.ClickNextButton();
            _allowToTrackPage.ClickNoTrackLink();
        }

    }
}
