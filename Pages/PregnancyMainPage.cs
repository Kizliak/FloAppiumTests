using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class PregnancyMainPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public PregnancyMainPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _calendarButton = By.Id("org.iggymedia.periodtracker:id/calendarButton");
        private readonly By _symptompsAddElement = By.Id("org.iggymedia.periodtracker:id/symptomsCardContainer");

        public bool CheckIfPregnancyMainPageLoaded()
        {
            _driver.FindElement(_calendarButton);
            _driver.FindElement(_symptompsAddElement);
            return true;
        }
    }
}
