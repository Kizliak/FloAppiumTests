using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;

namespace FloAppiumTests.Pages
{
    class WhatYearWereYouBornPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public WhatYearWereYouBornPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        private readonly By _introPickerBlock = By.Id("org.iggymedia.periodtracker:id/introPicker");
        private readonly By _introScreenNextButton = By.Id("org.iggymedia.periodtracker:id/introScreenNext");

        public WhatYearWereYouBornPage ClickIntroScreenNextButton()
        {
            _driver.FindElement(_introScreenNextButton).Click();
            return this;
        }

        public WhatYearWereYouBornPage verticalSwipeFromElementCenter()
        {
            var elementCoordinates = _driver.FindElement(_introPickerBlock).Coordinates;
            int elementXCoordinate = elementCoordinates.LocationInDom.X;
            int elementYCoordinate = elementCoordinates.LocationInDom.Y;
            var elementSize = _driver.FindElement(_introPickerBlock).Size;
            int elementWidth = elementSize.Width;
            int elementHeight = elementSize.Height;
            new TouchAction(_driver)
                .Press(elementXCoordinate + elementWidth / 2, elementYCoordinate + elementHeight / 2)
                //.Wait(1000)
                .MoveTo(elementXCoordinate + elementWidth / 2, elementYCoordinate + elementHeight / 1.3)
                .Release()
                .Perform();
            return this;
        }
    }
}
