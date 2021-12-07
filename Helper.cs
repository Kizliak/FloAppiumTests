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

        public Helper VerticalSwipeFromElementCenter(By element)
        {
            var elementCoordinates = _driver.FindElement(element).Coordinates;
            int elementXCoordinate = elementCoordinates.LocationInDom.X;
            int elementYCoordinate = elementCoordinates.LocationInDom.Y;
            var elementSize = _driver.FindElement(element).Size;
            int elementWidth = elementSize.Width;
            int elementHeight = elementSize.Height;
            new TouchAction(_driver)
                .Press(elementXCoordinate + elementWidth / 2, elementYCoordinate + elementHeight / 2)
                .Wait(100)
                .MoveTo(elementXCoordinate + elementWidth / 2, elementYCoordinate + elementHeight / 1.2)
                .Wait(100)
                .Release()
                .Perform();
            return this;
        }

        public void ClickOnButtonByText(string buttonText, By elementSelector)
        {
            foreach (IWebElement link in _driver.FindElements(elementSelector))
            {
                if (link.Text == buttonText)
                {
                    link.Click();
                    break;
                }
            }
        }
    }
}