using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class WhatYearWereYouBornPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public WhatYearWereYouBornPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }
    }
}
