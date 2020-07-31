using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using POMHomework.Utilities.Extensions;
using SeleniumExamPrep.PagesDemoQA._02AlertsSection.ModalDialogs;

namespace SeleniumExamPrep.Tests._02AlertsSection
{
    [TestFixture]
    public class ModalDialogsTests : BaseTest
    {
        private ModalDialogsPage _modalDialogsPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _modalDialogsPage = new ModalDialogsPage(Driver);
            _modalDialogsPage.NavigateTo();
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
        public void SmallModalButtonChangedHisColor_When_ClickSmallModalButton()
        {
            string colorBefore = _modalDialogsPage.SmallModalButton.GetCssColor();

            _modalDialogsPage.ClosingSmallModal();

            string colorAfter = _modalDialogsPage.SmallModalButton.GetCssColor();
            _modalDialogsPage.AssertColorChanged(colorBefore, colorAfter);
        }
    }
}
