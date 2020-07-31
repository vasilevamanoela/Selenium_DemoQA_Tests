using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.DatePicker
{
    public partial class DatePickerPage 
    {
        public void AssertCorrectMonth(string month, WebElement element)
        {
            Assert.AreEqual(month, element.Text);
        }
    }
}
