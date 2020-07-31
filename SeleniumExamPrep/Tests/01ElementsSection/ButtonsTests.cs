using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using SeleniumExamPrep.PagesDemoQA._01ElementsSection.Buttons;

namespace SeleniumExamPrep.Tests._01ElementsSection
{
    [TestFixture]
    public class ButtonsTests : BaseTest
    {
        private ButtonsPage _buttonsPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _buttonsPage = new ButtonsPage(Driver);
            _buttonsPage.NavigateTo();
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
        public void VerifyText_When_ClickingTheButton()
        {
            _buttonsPage.ClickMeButton.Click();

            _buttonsPage.AssertMessageDisplayed(_buttonsPage.ClickMeMessage);

            string message = "You have done a dynamic click";
            _buttonsPage.AssertCorrectTextMessage(message, _buttonsPage.ClickMeMessage);
        }

        [Test]
        public void VerifyText_When_DoubleClickingTheButton()
        {
            _buttonsPage.DoubleClicking(_buttonsPage.DoubleClickMeButton);

            _buttonsPage.AssertMessageDisplayed(_buttonsPage.DoubleClickMessage);

            string message = "You have done a double click";
            _buttonsPage.AssertCorrectTextMessage(message, _buttonsPage.DoubleClickMessage);
        }

        [Test]
        public void VerifyText_When_RightClickingTheButton()
        {
            _buttonsPage.RightClicking(_buttonsPage.RightClickMeButton);

            _buttonsPage.AssertMessageDisplayed(_buttonsPage.RightClickMessage);

            string message = "You have done a right click";
            _buttonsPage.AssertCorrectTextMessage(message, _buttonsPage.RightClickMessage);
        }
    }
}
