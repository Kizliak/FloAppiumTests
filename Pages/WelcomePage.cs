using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class WelcomePage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public WelcomePage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _welcomeText = By.Id("org.iggymedia.periodtracker:id/introScreenTitle");
        private readonly By _wantTrackCycleButton = By.Id("org.iggymedia.periodtracker:id/wantTrackCycle");

        public string IsWelcomeTextExsist()
        {
            return Regex.Replace(_driver.FindElement(_welcomeText).Text, @"\r\n?|\n", " ");
        }

        public WelcomePage ClickWantTrackCycleButton()
        {
            _driver.FindElement(_wantTrackCycleButton).Click();
            return this;
        }
    }
}
