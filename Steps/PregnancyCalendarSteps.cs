using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;
using FloAppiumTests.Pages;
using NUnit.Framework;

namespace FloAppiumTests.Steps
{
    [Binding]
    public class PregnancyCalendarSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly CalendarPeriodPage _calendarPeriodPage;
        private readonly PregnancyChooseMethodPage _pregnancyChooseMethodPage;
        private readonly PregnancyMainPage _pregnancyMainPage;
        private readonly PregnancyPromoPage _pregnancyPromoPage;
        private readonly PregnancyReviewsPage _pregnancyReviewsPage;
        private readonly PregnancyWeeksChoosePage _pregnancyWeeksChoosePage;
        private readonly PregnancyYearChoosePage _pregnancyYearChoosePage;
        private readonly WelcomePage _welcomePage;

        public PregnancyCalendarSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AppiumDriver<AndroidElement>>("driver");
            _calendarPeriodPage = new CalendarPeriodPage(_driver);
            _pregnancyChooseMethodPage = new PregnancyChooseMethodPage(_driver);
            _pregnancyMainPage = new PregnancyMainPage(_driver);
            _pregnancyPromoPage = new PregnancyPromoPage(_driver);
            _pregnancyReviewsPage = new PregnancyReviewsPage(_driver);
            _pregnancyWeeksChoosePage = new PregnancyWeeksChoosePage(_driver);
            _pregnancyYearChoosePage = new PregnancyYearChoosePage(_driver);
            _welcomePage = new WelcomePage(_driver);
        }

        [When(@"I choose I am pregnant")]
        public void WhenIChooseIAmPregnant()
        {
            _welcomePage.PregnancyButtonClick();
        }
        
        [When(@"I select Not remember pregnancy weeks")]
        public void WhenISelectNotRememberPregnancyWeeks()
        {
            _pregnancyWeeksChoosePage.iDontRememberButtonClick();
        }
        
        [When(@"I select first day of my last period method")]
        public void WhenISelectFirstDayOfMyLastPeriodMethod()
        {
            _pregnancyChooseMethodPage.FirstDayOfLastPeriodChoose();
        }
        
        [When(@"I select the oldest date in calendar")]
        public void WhenISelectTheOldestDateInCalendar()
        {
            _calendarPeriodPage.ChooseDateAsOldAsPossible();
        }
        
        [When(@"I Choose (.*) year of birthday")]
        public void WhenIChooseYearOfBirthday(int p0)
        {
            _pregnancyYearChoosePage.ChooseYear();
        }
        
        [When(@"I click Next button on promo page")]
        public void WhenIClickNextButton()
        {
            _pregnancyPromoPage.NextButtonClick()
                .NextButtonClick()
                .NextButtonClick();
        }
        
        [When(@"I close reviews popup")]
        public void WhenICloseReviewsPopup()
        {
            _pregnancyReviewsPage.ClickCloseButton();
        }
        
        [Then(@"I get to main pregnancy page")]
        public void ThenIGetToMainPregnancyPage()
        {
            Assert.IsTrue(_pregnancyMainPage.CheckIfPregnancyMainPageLoaded());
        }
    }
}
