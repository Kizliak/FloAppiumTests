using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;
using FloAppiumTests.Pages;
using NUnit.Framework;

namespace FloAppiumTests.Steps
{
    [Binding]
    public class TrackMyCycleSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly WelcomePage _welcomePage;
        private readonly WhenDidYourLastPeriodStartPage _whenDidYourLastPeriodStartPage;
        private readonly DontRememberLastPeriodFirstDayPage _dontRememberLastPeriodFirstDayPage;
        private readonly WhatYearWereYouBornPage _whatYearWereYouBornPage;
        private readonly StartAppAnswersPage _startAppAnswersPage;
        private readonly CreatingYourPersonalProgramPage _creatingYourPersonalProgramPage;
        private readonly WelcomeModePage _welcomeModePage;
        private readonly ChooseYourPlanWebPage _chooseYourPlanWebPage;
        private readonly TrackMyCycleMainPage _trackMyCycleMainPage;
        private readonly MainMenuPage _mainMenuPage;


        public TrackMyCycleSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AppiumDriver<AndroidElement>>("driver");
            _welcomePage = new WelcomePage(_driver);
            _whenDidYourLastPeriodStartPage = new WhenDidYourLastPeriodStartPage(_driver);
            _dontRememberLastPeriodFirstDayPage = new DontRememberLastPeriodFirstDayPage(_driver);
            _whatYearWereYouBornPage = new WhatYearWereYouBornPage(_driver);
            _startAppAnswersPage = new StartAppAnswersPage(_driver);
            _creatingYourPersonalProgramPage = new CreatingYourPersonalProgramPage(_driver);
            _welcomeModePage = new WelcomeModePage(_driver);
            _chooseYourPlanWebPage = new ChooseYourPlanWebPage(_driver);
            _trackMyCycleMainPage = new TrackMyCycleMainPage(_driver);
            _mainMenuPage = new MainMenuPage(_driver);
        }

        [When(@"I tap on Track my cycle button")]
        public void WhenITapOnTrackMyCycleButton()
        {
            _welcomePage.ClickWantTrackCycleButton();
        }

        [When(@"I tap on I don't remember checkbox")]
        public void WhenITapOnIDonTRememberCheckbox()
        {
            _whenDidYourLastPeriodStartPage.ClickIntroUnknownCheckBox();
        }

        [When(@"I tap on don't remember Next button")]
        public void WhenITapOnDonTRememberNextButton()
        {
            _dontRememberLastPeriodFirstDayPage.ClickIntroScreenNextButton();
        }

        [When(@"I swipe from Select to one position up")]
        public void WhenISwipeFromSelectToOnePositionUp()
        {
            _whatYearWereYouBornPage.verticalSwipeFromYearElementCenter();
        }

        [When(@"I tap on year born Next button")]
        public void WhenITapOnYearBornNextButton()
        {
            _whatYearWereYouBornPage.ClickIntroScreenNextButton();
        }

        [When(@"I tap on '(.*)' answer button")]
        public void WhenITapOnAnswerButton(string textButton)
        {
            _startAppAnswersPage.ClickAnswerButton(textButton);
        }

        [When(@"I tap on Next answer button")]
        public void WhenITapOnNextAnswerButton()
        {
            _startAppAnswersPage.ClickNextButton();
        }

        [When(@"I tap on No button on Do you take supplements")]
        public void WhenITapOnNoButtonOnDoYouTakeSupplements()
        {
            _creatingYourPersonalProgramPage.ClickDontTakeSapplementsButton();
        }

        [When(@"I tap on Welcome mode page Next button")]
        public void WhenITapOnWelcomeModePageNextButton()
        {
            _welcomeModePage.ClickFeatureCardPrimaryActionButton();
        }

        [When(@"I tap on Choose your plan X button")]
        public void WhenITapOnChooseYourPlanXButton()
        {
            _chooseYourPlanWebPage.ClickCloseButton();
        }

        [Then(@"The message '(.*)' appears on the Track my cycle mode main page")]
        public void ThenTheMessageAppearsOnTheTrackMyCycleModeMainPage(string pagePrimaryText)
        {
            Assert.AreEqual(pagePrimaryText, _trackMyCycleMainPage.GetPrimaryText());
        }

        [When(@"I tap on Track my cycle menu button")]
        public void WhenITapOnTrackMyCycleMenuButton()
        {
            _trackMyCycleMainPage.ClickMenuButon();
        }

        [Then(@"Track cycle button selected")]
        public void ThenTrackCycleButtonSelected()
        {
            Assert.AreEqual("true", _mainMenuPage.IsSelectedTrackCycleButton());
        }
    }
}
