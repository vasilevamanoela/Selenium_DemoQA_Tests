using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Pages._05DemoQA.Interactions;
using POMHomework.Tests._01GoogleSearch;

namespace POMHomework.Tests._05DemoQA.Interactions
{
    [TestFixture]
    public class DragabbleTests : BaseTest
    {
        private DragabblePage _dragabblePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _dragabblePage = new DragabblePage(Driver);
            _dragabblePage.NavigateTo();
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
        public void ElementYIsSame_When_DragAndDropOnlyXDiagonally()
        {
            //Arrange
            _dragabblePage.AxisRestrictedTab.Click();

            //Act
            int yBefore = _dragabblePage.onlyXBox.Location.Y;
            _dragabblePage.DragAndDropToOffset(_dragabblePage.onlyXBox, 100, 100);
            int yAfter = _dragabblePage.onlyXBox.Location.Y;

            //Assert
            _dragabblePage.AssertPositionIsNotChanged(yBefore, yAfter);
        }

        [Test]
        public void ElementXIsSame_When_DragAndDropOnlyYDiagonally()
        {
            //Arrange
            _dragabblePage.AxisRestrictedTab.Click();

            //Act
            int xBefore = _dragabblePage.onlyXBox.Location.Y;
            _dragabblePage.DragAndDropToOffset(_dragabblePage.onlyYBox, 100, 100);
            int xAfter = _dragabblePage.onlyXBox.Location.Y;

            //Assert
            _dragabblePage.AssertPositionIsNotChanged(xBefore, xAfter);
        }

        [Test]
        public void ElementYIsNotSame_When_DragAndDropToOffset()
        {
            //Arrange
            _dragabblePage.DraggebleBox.Click();

            //Act
            int yBefore = _dragabblePage.DraggebleBox.Location.Y;
            _dragabblePage.DragAndDropToOffset(_dragabblePage.DraggebleBox, 300, 100);
            int yAfter = _dragabblePage.DraggebleBox.Location.Y;

            //Assert
            _dragabblePage.AssertPositionChanged(yBefore, yAfter);

        }

        [Test]
        public void ElementMovedToRightAndCheckExactPosition_When_DragAndDropToOffset()
        {
            //Arrange
            _dragabblePage.DraggebleBox.Click();

            //Act
            _dragabblePage.DragAndDropToOffset(_dragabblePage.DraggebleBox, 200, 100);

            //Assert
            _dragabblePage.AssertExactPosition(618d, _dragabblePage.DraggebleBox.Location.X, 5);
        }
    }
}
