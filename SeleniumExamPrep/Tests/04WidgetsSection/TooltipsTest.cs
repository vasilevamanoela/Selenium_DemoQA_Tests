using ExamPreparation.SeleniumTests.Pages._01Tooltips;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;

namespace ExamPreparation.SeleniumTests.Tests._01Tooltips
{
    [TestFixture]
    public class TooltipsTest : BaseTest
    {
        private TooltipsPage _toopTipPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _toopTipPage = new TooltipsPage(Driver);
            _toopTipPage.NavigateTo();
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
        public void ToolTipsTextDisplayed_When_HoveredToInputField()
        {
            _toopTipPage.HoverToolTip(_toopTipPage.InputField);

            _toopTipPage.AssertToolTipDiv(_toopTipPage.ToolTipDiv);
            _toopTipPage.AssertCorrectText("You hovered over the text field", _toopTipPage.ToolTipDiv);
        }

        [Test]
        public void ToolTipsTextDisplayed_When_HoveredToFirtsInputField()
        {
            _toopTipPage.HoverToolTip(_toopTipPage.FirstInputField);

            _toopTipPage.AssertToolTipDiv(_toopTipPage.HoveredButton);
            _toopTipPage.AssertCorrectText("You hovered over the Button", _toopTipPage.HoveredButton);
        }
    }
}
