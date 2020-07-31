using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.Menu
{
    public partial class MenuPage 
    {
        public WebElement Menu2 => Driver.FindElement(By.XPath("//a[text()='Main Item 2']"));

        public WebElement SubSection => Driver.FindElement(By.XPath("//a[text()='SUB SUB LIST »']"));

        public WebElement MenusSection(string menuName) => 
            Driver.FindElement(By.XPath($"//a[text()='{menuName}']"));
    }
}
