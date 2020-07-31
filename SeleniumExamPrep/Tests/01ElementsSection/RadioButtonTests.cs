using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using SeleniumExamPrep.PagesDemoQA._01ElementsSection.RadioButton;

namespace SeleniumExamPrep.Tests._01ElementsSection
{
    [TestFixture]
    public class RadioButtonTests : BaseTest
    {
        private RadioButtonPage _radioButtonPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _radioButtonPage = new RadioButtonPage(Driver);
            _radioButtonPage.NavigateTo();
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
        public void MessageDisplayed_When_SelectRadioButtons()
        {
            _radioButtonPage.CheckingRadioButtons();
        }

        [Test]
        public void YesMessageDisplayed_When_SelectRadioButton()
        {
            _radioButtonPage.RadioButtons[0].Click();

            _radioButtonPage.AssertSuccessText("Yes", _radioButtonPage.SuccessMessage);
        }

        [Test]
        public void ImpressiveMessageDisplayed_When_SelectRadioButton()
        {
            _radioButtonPage.RadioButtons[1].Click();

            _radioButtonPage.AssertSuccessText("Impressive", _radioButtonPage.SuccessMessage);
        }        
    }
}
