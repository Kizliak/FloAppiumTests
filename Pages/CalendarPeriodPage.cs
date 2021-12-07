using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class CalendarPeriodPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public CalendarPeriodPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _dateCheckBox = By.ClassName("android.widget.ImageView");
        private readonly By _nextButton = By.Id("org.iggymedia.periodtracker:id/introScreenNext");

        public CalendarPeriodPage ChooseDateAsOldAsPossible()
        {
            _driver.FindElements(_dateCheckBox)[0].Click();
            _driver.FindElement(_nextButton).Click();
            return this;
        }
    }
}
