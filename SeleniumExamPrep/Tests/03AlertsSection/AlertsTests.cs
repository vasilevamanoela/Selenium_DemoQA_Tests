using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using POMHomework.Utilities.Extensions;
using SeleniumExamPrep.PagesDemoQA._02AlertsSection.Alerts;
using System.Threading;

namespace SeleniumExamPrep.Tests._02AlertsSection
{
    [TestFixture]
    public class AlertsTests : BaseTest
    {
        private AlertsPage _alertsPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _alertsPage = new AlertsPage(Driver);
            _alertsPage.NavigateTo();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.TakeScreenshot();
            }

            Driver.Quit();
        }

        [Test]
        public void AlertButtonChangedHisColor_When_ClickAlertButton()
        {
            string colorBefore = _alertsPage.AlertButton.GetCssColor();

            _alertsPage.AlertButton.Click();
            var alert = Driver.WrappedDriver.SwitchTo().Alert();
            alert.Accept();

            string colorAfter = _alertsPage.AlertButton.GetCssColor();
            _alertsPage.AssertChangedColor(colorBefore, colorAfter);
        }

        [Test]
        public void TimerAlertAcceptSuccessfully_When_ClickTimerAlertButton()
        {
            string colorBefore = _alertsPage.TimerAlertButton.GetCssColor();

            _alertsPage.TimerAlertButton.Click();
            Thread.Sleep(5500);
            var alert = Driver.WrappedDriver.SwitchTo().Alert();
            alert.Accept();

            string colorAfter = _alertsPage.TimerAlertButton.GetCssColor();
            _alertsPage.AssertChangedColor(colorBefore, colorAfter);
        }

        [Test]
        public void DismissAlertSuccessfully_When_ClickCancelButton()
        {
            _alertsPage.ConfirmButton.Click();

            var alert = Driver.WrappedDriver.SwitchTo().Alert();
            alert.Dismiss();

            _alertsPage.AssertTextDisplayed(_alertsPage.CanceledText);
            string message = "You selected Cancel";
            _alertsPage.AssertCorrectText(message, _alertsPage.CanceledText);
        }
    }
}
