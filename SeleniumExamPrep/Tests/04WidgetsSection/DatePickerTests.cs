using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using SeleniumExamPrep.PagesDemoQA._03WidgetsSection.DatePicker;

namespace SeleniumExamPrep.Tests._03WidgetsSection
{
    [TestFixture]
    public class DatePickerTests : BaseTest
    {
        private DatePickerPage _datePickerPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _datePickerPage = new DatePickerPage(Driver);
            _datePickerPage.NavigateTo();
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
        [TestCase("January", "17")]
        [TestCase("February", "17")]
        [TestCase("March", "17")]
        [TestCase("April", "17")]
        [TestCase("May", "17")]
        [TestCase("June", "17")]
        [TestCase("July", "17")]
        [TestCase("August", "17")]
        [TestCase("September", "17")]
        [TestCase("October", "17")]
        [TestCase("November", "17")]
        [TestCase("December", "17")]
        public void DateSelectedSuccessfully_When_PickADate(string month, string day)
        {
            _datePickerPage.PickADate(day);
            _datePickerPage.PickAMonth(month);

            _datePickerPage.AssertCorrectMonth($"{month} 2020", _datePickerPage.MonthHeader);
        }
    }
}
