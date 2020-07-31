using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using SeleniumExamPrep.PagesDemoQA._01ElementsSection.Check_Box;

namespace SeleniumExamPrep.Tests._01ElementsSection
{
    [TestFixture]
    public class CheckBoxTests : BaseTest
    {
        private CheckBoxPage _checkBoxPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _checkBoxPage = new CheckBoxPage(Driver);
            _checkBoxPage.NavigateTo();
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
        public void MessageDisplayed_When_CheckTheCheckBoxes()
        {
            _checkBoxPage.CheckingUncheckedBoxes();

            _checkBoxPage.AssertMessageDisplayed(_checkBoxPage.TextResult);
        }

        [Test]
        public void CorrectMessageDisplayed_When_CheckDesktopBox()
        {
            _checkBoxPage.CheckingOneBox(1);

            string message = "You have selected :\r\ndesktop\r\nnotes\r\ncommands";
            _checkBoxPage.AssertCorrectMessage(message, _checkBoxPage.TextResult);
        }

        [Test]
        public void CorrectMessageDisplayed_When_CheckDocumentsBox()
        {
            _checkBoxPage.CheckingOneBox(2);

            string message = "You have selected :\r\ndocuments\r\nworkspace\r\nreact\r\nangular\r\nveu\r\noffice\r\npublic\r\nprivate\r\nclassified\r\ngeneral";
            _checkBoxPage.AssertCorrectMessage(message, _checkBoxPage.TextResult);
        }

        [Test]
        public void CorrectMessageDisplayed_When_CheckDownloadsBox()
        {
            _checkBoxPage.CheckingOneBox(3);

            string message = "You have selected :\r\ndownloads\r\nwordFile\r\nexcelFile";
            _checkBoxPage.AssertCorrectMessage(message, _checkBoxPage.TextResult);
        }
    }
}
