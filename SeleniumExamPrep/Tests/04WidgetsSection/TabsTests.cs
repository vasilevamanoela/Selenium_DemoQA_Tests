using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using SeleniumExamPrep.PagesDemoQA._04WidgetsSection.Tabs;

namespace SeleniumExamPrep.Tests._04WidgetsSection
{
    [TestFixture]
    public class TabsTests : BaseTest
    {
        private TabsPage _tabPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _tabPage = new TabsPage(Driver);
            _tabPage.NavigateTo();
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
        [TestCase("What")]
        [TestCase("Origin")]
        [TestCase("Use")]
        public void TabsSuccessfullySelected_When_ClickOnTabs(string tabName)
        {
            _tabPage.SelectTab(tabName);

            _tabPage.AssertTextDisplayed(_tabPage.TextParagraph);
        }
    }
}
