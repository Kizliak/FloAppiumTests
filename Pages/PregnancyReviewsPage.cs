using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace FloAppiumTests.Pages
{
    class PregnancyReviewsPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public PregnancyReviewsPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _closeButton = By.XPath("//android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View[1]/android.widget.Button");
        public PregnancyReviewsPage ClickCloseButton()
        {
            _driver.FindElement(_closeButton).Click();
            return this;
        }
    }
}
