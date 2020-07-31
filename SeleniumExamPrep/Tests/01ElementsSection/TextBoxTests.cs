using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using POMHomework.Utilities.Extensions;
using SeleniumExamPrep.Factories;
using SeleniumExamPrep.Models;
using SeleniumExamPrep.PagesDemoQA._01ElementsSection.TextBox;

namespace SeleniumExamPrep.Tests._01ElementsSection
{
    [TestFixture]
    public class TextBoxTests : BaseTest
    {
        private TextBoxPage _textBoxPage;
        private TextBoxModel _user;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _textBoxPage = new TextBoxPage(Driver);
            _textBoxPage.NavigateTo();
            _user = TextBoxFactory.Create();
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
        public void MessageDisplayed_When_FillFormInTextBox()
        {
            _textBoxPage.FillForm(_user);

            _textBoxPage.AssertMessageDisplayed(_textBoxPage.Message);
        }

        [Test]
        [TestCase("userName")]
        [TestCase("currentAddress")]
        [TestCase("permanentAddress")]
        public void OtputFieldVisible_When_FillFormWithOnePanel(string panel)
        {
            _textBoxPage.FillOnePanel(panel);

            _textBoxPage.AssertCorrectTextPanel("Some Text", _textBoxPage.OuthputField);
        }

        [Test]
        public void OuthputMissing_When_FillFormInTextBoxWithoutEmailDomain()
        {
            _user.UserEmail = "someemail";

            _textBoxPage.FillForm(_user);

            _textBoxPage.AssertMissingElement(_textBoxPage.Output);
        }

        [Test]
        public void EmailFieldChangingColor_When_FillFormInTextBoxWithoutEmailDomain()
        {
            _user.UserEmail = "someemail";

            var colorBefore = _textBoxPage.UserEmail.GetCssColorBorder();
            _textBoxPage.FillForm(_user);

            _textBoxPage.UserEmail.ScrollTo();
            var colorAfter = _textBoxPage.UserEmail.GetCssColorBorder();

            _textBoxPage.AssertColorChanged(colorBefore, colorAfter);
        }

        [Test]
        public void CorrectNameDisplayed_When_FillFormTextBox()
        {
            _textBoxPage.FillForm(_user);

            string submitedName = "Name:Pesho Peshov";
            _textBoxPage.AssertCorrectTextAfterSubmition(submitedName, _textBoxPage.SubmitedName);
        }

        [Test]
        public void CorrectEmailDisplayed_When_FillFormTextBox()
        {
            _textBoxPage.FillForm(_user);

            string submitedEmail = "Email:someemail@gmail.com";
            _textBoxPage.AssertCorrectTextAfterSubmition(submitedEmail, _textBoxPage.SubmitedEmail);
        }

        [Test]
        public void CorrectCurrentAddressDisplayed_When_FillFormTextBox()
        {
            _textBoxPage.FillForm(_user);

            string submitedCurrentAddress = "Current Address :Some Adress 1";
            _textBoxPage.AssertCorrectTextAfterSubmition(submitedCurrentAddress, _textBoxPage.SubmitedCurrentAddress);
        }

        [Test]
        public void CorrectPermalentAddressDisplayed_When_FillFormTextBox()
        {
            _textBoxPage.FillForm(_user);

            string submitedPermalentAddress = "Permananet Address :Other Adress 2";
            _textBoxPage.AssertCorrectTextAfterSubmition(submitedPermalentAddress, _textBoxPage.SubmitedPermalentAddress);
        }
    }
}
