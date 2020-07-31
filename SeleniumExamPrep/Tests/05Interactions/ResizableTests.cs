using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Pages._05DemoQA.Interactions;
using POMHomework.Tests._01GoogleSearch;

namespace POMHomework.Tests._05DemoQA.Interactions
{
    [TestFixture]
    public class ResizableTests : BaseTest
    {
        private ResizablePage _resizablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _resizablePage = new ResizablePage(Driver);
            _resizablePage.NavigateTo();
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
        public void ResizeBoxSizeIsMaximum_When_ResizeMoreThanMaximum()
        {
            //Arrange
            _resizablePage.ResizeBox.Click();

            //Act
            _resizablePage.DragAndDropToOffset(_resizablePage.ResizeArrow, 350, 150);

            //Assert
            _resizablePage.AssertExactPosition(882d, _resizablePage.ResizeArrow.Location.X, 5);
            _resizablePage.AssertExactPosition(516d, _resizablePage.ResizeArrow.Location.Y, 5);
        }

        [Test]
        public void ResizeBoxSizeIsMinimum_When_ResizeToMinimum()
        {
            //Arrange
            _resizablePage.ResizeBox.Click();

            //Act
            _resizablePage.DragAndDropToOffset(_resizablePage.ResizeArrow, -50, -100);

            //Assert
            _resizablePage.AssertExactPosition(532d, _resizablePage.ResizeArrow.Location.X, 5);
            _resizablePage.AssertExactPosition(366d, _resizablePage.ResizeArrow.Location.Y, 5);
        }

        [Test]
        public void ElemetSizeIsMaximum_When_ResizeMoreThanMaximum()
        {
            //Arrange
            _resizablePage.ResizeBox.Click();

            //Act
            _resizablePage.DragAndDropToOffset(_resizablePage.ResizeArrow, 300, 100);

            //Assert
            _resizablePage.AssertPosition(_resizablePage.Container.Size.Height, _resizablePage.ResizeBox.Size.Height);
            _resizablePage.AssertPosition(_resizablePage.Container.Size.Width, _resizablePage.ResizeBox.Size.Width);
        }

        [Test]
        public void ElemetSizeIsMinimum_When_ResizeToMinimum()
        {
            //Arrange
            _resizablePage.ResizeBox.Click();

            //Act
            _resizablePage.DragAndDropToOffset(_resizablePage.ResizeArrow, -50, -50);

            //Assert
            _resizablePage.AssertExactPosition(150d, _resizablePage.ResizeBox.Size.Height, 5);
            _resizablePage.AssertExactPosition(150d, _resizablePage.ResizeBox.Size.Width, 5);
        }
    }
}
