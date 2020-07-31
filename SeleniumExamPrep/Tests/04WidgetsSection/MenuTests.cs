using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using SeleniumExamPrep.PagesDemoQA._03WidgetsSection.Menu;

namespace SeleniumExamPrep.Tests._03WidgetsSection
{
    [TestFixture]
    public class MenuTests : BaseTest
    {
        private MenuPage _menuPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _menuPage = new MenuPage(Driver);
            _menuPage.NavigateTo();
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
        public void MenuSubSectionDisplayed_When_HoverToMenuSection()
        {
            _menuPage.HoverMenu(_menuPage.Menu2);

            _menuPage.AssertSubSectionDisplayed(_menuPage.SubSection);
        }

        [Test]
        [TestCase("Main Item 1")]
        [TestCase("Main Item 2")]
        [TestCase("Main Item 3")]
        public void MenuColorChanged_When_HoverMenuSection(string menuName)
        {
            _menuPage.HoverMenu(_menuPage.MenusSection(menuName));

        }
    }
}
