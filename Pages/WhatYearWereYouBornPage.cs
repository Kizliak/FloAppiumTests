using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;

namespace FloAppiumTests.Pages
{
    class WhatYearWereYouBornPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly Helper _helper;

        public WhatYearWereYouBornPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
            _helper = new Helper(_driver);
        }

        private readonly By _introPickerBlock = By.Id("org.iggymedia.periodtracker:id/introPicker");
        private readonly By _introScreenNextButton = By.Id("org.iggymedia.periodtracker:id/introScreenNext");

        public WhatYearWereYouBornPage ClickIntroScreenNextButton()
        {
            _driver.FindElement(_introScreenNextButton).Click();
            return this;
        }

        public WhatYearWereYouBornPage verticalSwipeFromYearElementCenter()
        {
            _helper.verticalSwipeFromElementCenter(_introPickerBlock);
            return this;
        }
    }
}
