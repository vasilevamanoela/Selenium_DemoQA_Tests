using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using SeleniumExamPrep.PagesDemoQA._03WidgetsSection.SelectMenu;

namespace SeleniumExamPrep.Tests._03WidgetsSection
{
    [TestFixture]
    public class SelectMenuTests : BaseTest
    {
        private SelectMenuPage _selectMenuPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _selectMenuPage = new SelectMenuPage(Driver);
            _selectMenuPage.NavigateTo();
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
        public void ColorSelected_When_ClickingSelectMenu()
        {
            _selectMenuPage.SelectColor();

            string color = "Yellow";
            _selectMenuPage.AssertCorectColor(color, _selectMenuPage.Color);
        }

        [Test]
        [TestCase("Red")]
        [TestCase("Blue")]
        [TestCase("Green")]
        [TestCase("Yellow")]
        [TestCase("Purple")]
        [TestCase("Black")]
        [TestCase("White")]
        [TestCase("Voilet")]
        [TestCase("Indigo")]
        [TestCase("Magenta")]
        [TestCase("Aqua")]
        public void ColorsSuccessfullySelected_When_ChoosingAColor(string color)
        {
            _selectMenuPage.ColorSelection(color);

            _selectMenuPage.AssertCorectColor(color, _selectMenuPage.Colors(color));
        }
    }
}
