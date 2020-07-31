using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using SeleniumExamPrep.PagesDemoQA._03WidgetsSection.Progress_Bar;

namespace SeleniumExamPrep.Tests._03WidgetsSection
{
    [TestFixture]
    public class ProgressBarTests : BaseTest
    {
        private ProgressBarPage _progressBarPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _progressBarPage = new ProgressBarPage(Driver);
            _progressBarPage.NavigateTo();
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
        public void ProgressBarLoadingSuccessfully_When_ClickStartButton()
        {
            _progressBarPage.ProgresBarLoading();

            string number = "15%";
            _progressBarPage.AssertExactNumberLoaded(number, _progressBarPage.ProgressBar);
        }
    }
}
