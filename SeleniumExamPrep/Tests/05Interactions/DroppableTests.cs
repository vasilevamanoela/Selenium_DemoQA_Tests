using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Pages._05DemoQA.Interactions;
using POMHomework.Tests._01GoogleSearch;
using POMHomework.Utilities.Extensions;

namespace POMHomework.Tests._05DemoQA.Interactions
{
    [TestFixture]
    public class DroppableTests : BaseTest
    {
        private DroppablePage _droppablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _droppablePage = new DroppablePage(Driver);
            _droppablePage.NavigateTo();
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
        public void DropElementChangeColorOfTarget_When_DragAndDropDragMe()
        {
            //Arrange
            string colorBefore = _droppablePage.TargetBox.GetCssColor();

            //Act
            _droppablePage.DragAndDrop(_droppablePage.SourceBox, _droppablePage.TargetBox);
            string colorAfter = _droppablePage.TargetBox.GetCssColor();

            //Assert
            _droppablePage.AssertColorChanged(colorBefore, colorAfter);
        }

        [Test]
        public void ElementChengedColor_When_MoveElementToTarget()
        {
            //Arrange
            _droppablePage.SourceBox.Click();

            //Act
            _droppablePage.DragAndDrop(_droppablePage.SourceBox, _droppablePage.TargetBox);
            string colorAfter = _droppablePage.TargetBox.GetCssColor();

            //Assert
            _droppablePage.AssertExactColor("rgba(70, 130, 180, 1)", colorAfter);
        }

        [Test]
        public void SourseBoxPositionChanged_When_MoveSourseBoxToTargetBox()
        {
            //Arrange
            double sourcePosXBefore = _droppablePage.SourceBox.Location.X;
            double sourcePosYBefore = _droppablePage.SourceBox.Location.Y;

            //Act
            _droppablePage.DragAndDrop(_droppablePage.SourceBox, _droppablePage.TargetBox);
            double sourcePosXAfter = _droppablePage.SourceBox.Location.X;
            double sourcePosYAfter = _droppablePage.SourceBox.Location.Y;

            //Assert
            _droppablePage.AssertPositionChanged(sourcePosXBefore, sourcePosXAfter);
            _droppablePage.AssertPositionChanged(sourcePosYBefore, sourcePosYAfter);
        }

        [Test]
        public void SourseBoxChangedHisExactPosition_When_DragAndDrop()
        {
            //Arrange
            double sourcePosXBefore = _droppablePage.SourceBox.Location.X;

            //Act
            _droppablePage.DragAndDrop(_droppablePage.SourceBox, _droppablePage.TargetBox);
            double sourcePosXAfter = _droppablePage.SourceBox.Location.X;

            //Assert
            _droppablePage.AssertExactPosition(552d, sourcePosXBefore, 5);
            _droppablePage.AssertExactPosition(843d, sourcePosXAfter, 5);
        }

        [Test]
        public void SourseBoxPositionChanged_When_MoveSourseBoxToOffset()
        {
            //Arrange
            _droppablePage.SourceBox.Click();

            //Act
            _droppablePage.DragAndDropToOffset(_droppablePage.SourceBox, 301, 47);
            double sourcePosXAfter = _droppablePage.SourceBox.Location.X;
            double sourcePosYAfter = _droppablePage.SourceBox.Location.Y;

            //Assert
            _droppablePage.AssertExactPosition(853d, sourcePosXAfter, 5);
            _droppablePage.AssertExactPosition(349d, sourcePosYAfter, 5);
        }
    }
}
