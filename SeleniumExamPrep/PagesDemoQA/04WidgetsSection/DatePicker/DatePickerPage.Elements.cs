using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.DatePicker
{
    public partial class DatePickerPage 
    {
        public WebElement DatePickerButton => Driver.FindElement(By.Id("datePickerMonthYearInput"));

        public WebElement SelectDay(string day) => Driver.FindElement(By.XPath($"//div[text()='{day}']"));

        public WebElement MonthField => Driver.FindElement(By.XPath("//select[@class='react-datepicker__month-select']"));

        public WebElement MonthPicker(string month) => Driver.FindElement(By.XPath($"//option[text()='{month}']"));

        public WebElement MonthHeader => Driver.FindElement(By.XPath("//div[@class='react-datepicker__current-month react-datepicker__current-month--hasYearDropdown react-datepicker__current-month--hasMonthDropdown']"));
    }
}
