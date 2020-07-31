using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.AutoComplete
{
    public partial class AutoCompletePage 
    {
        public WebElement SingleColorInput => Driver.FindElement(By.XPath("//div[@id='autoCompleteSingleContainer']"));

        public WebElement RedColorDiv => Driver.FindElement(By.XPath("//div[@id='react-select-3-option-0']"));

        public WebElement GreenColorDiv => Driver.FindElement(By.XPath("//div[@id='react-select-3-option-1']"));
    }
}
