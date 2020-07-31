using OpenQA.Selenium;
using POMHomework.Pages;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.DatePicker
{
    public partial class DatePickerPage : BasePage
    {
        public DatePickerPage(WebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/date-picker";
        
        public void PickADate(string day)
        {
            Builder
                .Click(DatePickerButton.WrappedElement)
                .SendKeys(Keys.Control + "a")
                .SendKeys(Keys.Delete)
                .Perform();

            SelectDay(day).Click();
        }

        public void PickAMonth(string month)
        {
            DatePickerButton.Click();
            MonthField.Click();
            MonthPicker(month).Click();
        }
    }
}
