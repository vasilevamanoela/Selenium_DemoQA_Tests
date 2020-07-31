using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using POMHomework.Utilities.Extensions;
using SeleniumExamPrep.PagesDemoQA._01ElementsSection.DynamicProperties;

namespace SeleniumExamPrep.Tests._01ElementsSection
{
    [TestFixture]
    public class DynamicPropertiesTests : BaseTest
    {
        private DynamicPropertiesPage _dynamicPropertiesPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _dynamicPropertiesPage = new DynamicPropertiesPage(Driver);
            _dynamicPropertiesPage.NavigateTo();
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
        public void ColorChangedSuccessfully_When_WaitingPagetoLoad()
        {
            var colorBefore = _dynamicPropertiesPage.ColorChangeButton.GetCssColorInside();

            _dynamicPropertiesPage.WaitPageToLoad();

            var colorAfter = _dynamicPropertiesPage.ColorChangeButton.GetCssColorInside();

            _dynamicPropertiesPage.AssertColorChanged(colorBefore, colorAfter);
        }

        [Test]
        public void ElemetsAreVisible_When_WaitingPageToLoad()
        {
            _dynamicPropertiesPage.WaitPageToLoad();

            _dynamicPropertiesPage.AssertElementDisplayed(_dynamicPropertiesPage.ColorAfterButton);
            _dynamicPropertiesPage.AssertElementDisplayed(_dynamicPropertiesPage.VisibleAfterButton);
        }
    }
}
