using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using POMHomework.Utilities.Extensions;
using SeleniumExamPrep.PagesDemoQA._03WidgetsSection.Slider;

namespace SeleniumExamPrep.Tests._03WidgetsSection
{
    [TestFixture]
    public class SliderTests : BaseTest
    {
        private SliderPage _sliderPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _sliderPage = new SliderPage(Driver);
            _sliderPage.NavigateTo();
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
        public void SliderDotChangedPosition_When_SlideToSliderValue()
        {
            string positionBefore = _sliderPage.SliderDot.GetProperty();

            _sliderPage.MoveSliderToSliderValue(_sliderPage.SliderDot, _sliderPage.SliderValue);
            string positionAfter = _sliderPage.SliderDot.GetProperty();

            _sliderPage.AssertChangedPosition(positionBefore, positionAfter);
        }

        [Test]
        public void SliderDotChangedPosition_When_SlideByOffset()
        {
            string positionBefore = _sliderPage.SliderDot.GetProperty();

            _sliderPage.MoveSliderByOffset(_sliderPage.SliderDot);
            string positionAfter = _sliderPage.SliderDot.GetProperty();

            _sliderPage.AssertChangedPosition(positionBefore, positionAfter);
            Assert.AreEqual("50", positionAfter);
        }

        [Test]
        public void SliderDotChangedExactPosition_When_SlideByOffset()
        {
            _sliderPage.MoveSliderByOffset(_sliderPage.SliderDot);

            _sliderPage.AssertExactPosition("50", _sliderPage.SliderDot);
        }
    }
}
