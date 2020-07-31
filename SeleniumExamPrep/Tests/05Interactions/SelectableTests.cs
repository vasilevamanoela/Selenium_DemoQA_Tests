using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Pages._05DemoQA.Interactions;
using POMHomework.Tests._01GoogleSearch;
using POMHomework.Utilities.Extensions;
using System;

namespace POMHomework.Tests._05DemoQA.Interactions
{
    [TestFixture]
    public class SelectableTests : BaseTest
    {
        private SelectablePage _selectablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _selectablePage = new SelectablePage(Driver);
            _selectablePage.NavigateTo();
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
        public void CompareListColor_When_ClickOnListItem()
        {
            //Arrange
            string colorBefore = _selectablePage.LastBox.GetCssColor();

            //Act
            _selectablePage.LastBox.Click();
            string colorAfter = _selectablePage.LastBox.GetCssColor();

            //Assert
            _selectablePage.AssertChangedColor(colorBefore, colorAfter);
        }

        [Test]
        public void CheckExactColor_When_ClickOnListItem()
        {
            //Arrange
            _selectablePage.LastBox.Click();

            //Act
            string colorAfter = _selectablePage.LastBox.GetCssColor();

            //Assert
            _selectablePage.AssertExactColor("rgba(0, 123, 255, 1)", colorAfter);
        }

        [Test]
        public void SelectItemColorChange_When_SelectItem([Range(0, 3)] int index)
        {
           //Arrange
            _selectablePage.ListOptions[index].Click();

            //Act
            string listColor = _selectablePage.ListOptions[index].GetCssColor();

            //Assert
            _selectablePage.AssertExactColor("rgba(0, 123, 255, 1)", listColor);
        }
    }
}
