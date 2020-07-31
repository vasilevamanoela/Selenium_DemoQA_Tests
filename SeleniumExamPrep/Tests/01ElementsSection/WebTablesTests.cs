using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using SeleniumExamPrep.PagesDemoQA._01ElementsSection.WebTables;

namespace SeleniumExamPrep.Tests._01ElementsSection
{
    [TestFixture]
    public class WebTablesTests : BaseTest
    {
        private WebTablesPage _webTablesPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _webTablesPage = new WebTablesPage(Driver);
            _webTablesPage.NavigateTo();
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
        public void RowSuccessfullyDeleted_When_ClickDeleteButton()
        {
            _webTablesPage.SearchAndDeledeRecord();

            _webTablesPage.AssertNoRowsFound(_webTablesPage.NoResultText);
            _webTablesPage.AssertNoRowsFoundText("No rows found", _webTablesPage.NoResultText);
        }
    }
}
