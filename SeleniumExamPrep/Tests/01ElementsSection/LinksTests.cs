using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using SeleniumExamPrep.PagesDemoQA._01ElementsSection.Links;

namespace SeleniumExamPrep.Tests._01ElementsSection
{
    [TestFixture]
    public class LinksTests : BaseTest
    {
        private LinksPage _linksPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _linksPage = new LinksPage(Driver);
            _linksPage.NavigateTo();
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
        public void VerifyNewTabOpening_When_ClickingLinkButton()
        {
            _linksPage.SimpleLink.Click();

            Driver.WrappedDriver.SwitchTo().ActiveElement();

            _linksPage.AssertPageHeaderExist(_linksPage.PageHeader);
        }

        [Test]
        public void LinkResponseSuccessfullyOpened_When_ClickingAPICallsButtons()
        {
            _linksPage.ClickAPICallsButton();
        }
    }
}
