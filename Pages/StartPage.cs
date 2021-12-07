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
        private readonly By _privacyTermsCheckBox = By.Id("org.iggymedia.periodtracker:id/privacyTermsCheck");
        private readonly By _healthDataCheckBox = By.Id("org.iggymedia.periodtracker:id/healthDataCheck");

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

        public bool CheckIfNextButtonIsEnabled()
        {
            if (_driver.FindElement(_NextButton).Enabled)
            {
                return true;
            }
            return false;
        }

        public StartPage SelectPrivacyTermsCheckBox()
        {
            _driver.FindElement(_privacyTermsCheckBox).Click();
            return this;
        }

        public StartPage SelectHealthDataCheckBox()
        {
            _driver.FindElement(_healthDataCheckBox).Click();
            return this;
        }

        public bool CheckIfCheckBoxIsSelected(int checkboxNumber)
        {
            bool result = false;
            if (checkboxNumber == 1)
            {
                if (_driver.FindElement(_privacyTermsCheckBox).Selected)
                {
                    result = true;
                }
            }
            else if (checkboxNumber == 2)
            {
                if (_driver.FindElement(_healthDataCheckBox).Selected)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}