using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.SelectMenu
{
    public partial class SelectMenuPage 
    {
        public WebElement OldSelectMenu => Driver.FindElement(By.Id("oldSelectMenu"));

        public WebElement Color => Driver.FindElement(By.XPath("//option[text()='Yellow']"));

        public WebElement Colors(string color) => 
            Driver.FindElement(By.XPath($"//option[text()='{color}']"));
    }
}
