using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using System;

namespace FloAppiumTests.Drivers
{
    class AppiumDriver
    {
        private AppiumDriver<AndroidElement> _driver;

        public AppiumDriver<AndroidElement> InitializeAppium()
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "9.0");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Google Pixel 3");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "Appium");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.App, "C:\\Flo_7.3.0_apk-dl.com.apk");
            driverOptions.AddAdditionalCapability("appPackage", "org.iggymedia.periodtracker");
            driverOptions.AddAdditionalCapability("appActivity", "org.iggymedia.periodtracker.feature.startup.ui.StartupDispatchingActivity");

            var appiumService = new AppiumServiceBuilder()
                .WithIPAddress("127.0.0.1")
                .UsingAnyFreePort()
                .Build();

            if (!appiumService.IsRunning)
            {
                appiumService.Start();
            }

            _driver = new AndroidDriver<AndroidElement>(appiumService, driverOptions, TimeSpan.FromSeconds(100));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            return _driver;
        }
    }
}
