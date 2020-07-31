using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using SeleniumExamPrep.PagesDemoQA._03WidgetsSection.AutoComplete;

namespace SeleniumExamPrep.Tests._03WidgetsSection
{
    [TestFixture]
    [System.Runtime.InteropServices.Guid("D8B6F1F1-338C-4F19-978B-93B2A97CE4A2")]
    public class AutoCompleteTests : BaseTest
    {
        private AutoCompletePage _autoCompletePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _autoCompletePage = new AutoCompletePage(Driver);
            _autoCompletePage.NavigateTo();
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
        public void ColorSetSuccessfully_When_WriteColorInAutoComplete()
        {
            _autoCompletePage.WriteColor(_autoCompletePage.SingleColorInput);

            _autoCompletePage.AssertColorDisplayed(_autoCompletePage.RedColorDiv);
            _autoCompletePage.AssertColorDisplayed(_autoCompletePage.GreenColorDiv);

            _autoCompletePage.AssertCorrectColor("Red", _autoCompletePage.RedColorDiv);
            _autoCompletePage.AssertCorrectColor("Green", _autoCompletePage.GreenColorDiv);
        }
    }
}
