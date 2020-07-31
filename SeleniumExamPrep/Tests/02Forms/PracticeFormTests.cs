using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using POMHomework.Utilities.Extensions;
using SeleniumExamPrep.Factories;
using SeleniumExamPrep.Models;
using SeleniumExamPrep.PagesDemoQA._02Forms;

namespace SeleniumExamPrep.Tests._02Forms
{
    [TestFixture]
    public class PracticeFormTests : BaseTest
    {
        private PracticeFormPage _practiceFormPage;
        private PracticeFormModel _user;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _practiceFormPage = new PracticeFormPage(Driver);
            _practiceFormPage.NavigateTo();
            _user = PracticeFormFactory.Create();
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
        public void ThanksMessageDisplayed_When_FillFormWithValidData()
        {
            _practiceFormPage.FillForm(_user);

            string message = "Thanks for submitting the form";
            _practiceFormPage.AssertCorrectThanksMessage(message, _practiceFormPage.ThanksMessage);
        }

        [Test]
        public void ErrorDisplayed_When_FillFormWithoutFirstName()
        {
            _user.FirstName = string.Empty;

            var colorBefore = _practiceFormPage.FirstName.GetCssColorBorder();
            _practiceFormPage.FillForm(_user);

            _practiceFormPage.FirstName.ScrollTo();
            var colorAfter = _practiceFormPage.FirstName.GetCssColorBorder();

            _practiceFormPage.AssertColorChanged(colorBefore, colorAfter);
        }

        [Test]
        public void ErrorDisplayed_When_FillFormWithoutLastName()
        {
            _user.LastName = string.Empty;

            var colorBefore = _practiceFormPage.LastName.GetCssColorBorder();
            _practiceFormPage.FillForm(_user);

            _practiceFormPage.LastName.ScrollTo();
            var colorAfter = _practiceFormPage.LastName.GetCssColorBorder();

            _practiceFormPage.AssertColorChanged(colorBefore, colorAfter);
        }

        [Test]
        public void ErrorDisplayed_When_FillFormWithoutPhoneNumber()
        {
            _user.UserNumber = string.Empty;

            var colorBefore = _practiceFormPage.UserNumber.GetCssColorBorder();
            _practiceFormPage.FillForm(_user);

            _practiceFormPage.UserNumber.ScrollTo();
            var colorAfter = _practiceFormPage.UserNumber.GetCssColorBorder();

            _practiceFormPage.AssertColorChanged(colorBefore, colorAfter);
        }

        [Test]
        [TestCase("Male")]
        [TestCase("Female")]
        [TestCase("Other")]
        public void ThanksMessageDisplayed_When_FillFormWithValidDataAndDiffGender(string labelText)
        {
            _practiceFormPage.FillFormWithDifferentGender(labelText, _user);

            string message = "Thanks for submitting the form";
            _practiceFormPage.AssertCorrectThanksMessage(message, _practiceFormPage.ThanksMessage);
            _practiceFormPage.AssertValueDisplayedAfterSubmittion(_practiceFormPage.SectionAftreSubmition(labelText));
        }

        [Test]
        [TestCase("Sports")]
        [TestCase("Reading")]
        [TestCase("Music")]
        public void ThanksMessageDisplayed_When_FillFormWithValidDataAndDiffHobby(string labelText)
        {
            _practiceFormPage.FillFormWithDifferentHobbies(labelText, _user);

            string message = "Thanks for submitting the form";
            _practiceFormPage.AssertCorrectThanksMessage(message, _practiceFormPage.ThanksMessage);
            _practiceFormPage.AssertValueDisplayedAfterSubmittion(_practiceFormPage.SectionAftreSubmition(labelText));
        }
    }
}
