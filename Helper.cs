using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;

namespace FloAppiumTests
{
    class Helper
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public Helper(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        
    }
}
