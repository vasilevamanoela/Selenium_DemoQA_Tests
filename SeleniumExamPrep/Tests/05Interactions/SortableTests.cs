using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Pages._05DemoQA.Interactions;
using POMHomework.Tests._01GoogleSearch;

namespace POMHomework.Tests._05DemoQA.Interactions
{
    [TestFixture]
    public class SortableTests : BaseTest
    {
        private SortablePage _sortablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _sortablePage = new SortablePage(Driver);
            _sortablePage.NavigateTo();
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
        public void CheckFirstElement_When_FirstElementGoToEnd()
        {
            //Arrange
            _sortablePage.FirstElement.Click();

            //Act
            _sortablePage.DragAndDrop(_sortablePage.FirstElement, _sortablePage.SortablePanel);

            //Assert
            _sortablePage.AsserChangedElements("Two", _sortablePage.FirstElement.Text);
        }

        [Test]
        public void CheckLastElement_When_FirstElementGoToEnd()
        {
            //Arrange
            _sortablePage.FirstElement.Click();

            //Act
            _sortablePage.DragAndDrop(_sortablePage.FirstElement, _sortablePage.SortablePanel);

            //Assert
            _sortablePage.AsserChangedElements("One", _sortablePage.LastElement.Text);
        }

        [Test]
        public void OptionPlaceIsSwitch_When_DragAndDropUnderOtherOption()
        {
            //Arrange
            int index = 0;

            //Act
            _sortablePage.DragAndDropToOffset(_sortablePage.ListOfOption[index], 0, 50);

            //Assert
            _sortablePage.AsserChangedElements("One", _sortablePage.ListOfOption[index + 1].Text);
        }

        [Test]
        public void OptionPlaceIsSwitch_When_DragAndDropOverOtherOption()
        {
            //Arrange
            int index = 5;

            //Act
            _sortablePage.DragAndDropToOffset(_sortablePage.ListOfOption[index], 0, -50);

            //Assert
            _sortablePage.AsserChangedElements("Six", _sortablePage.ListOfOption[index - 1].Text);
        }
    }
}
