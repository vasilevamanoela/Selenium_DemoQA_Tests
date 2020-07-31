using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.DynamicProperties
{
    public partial class DynamicPropertiesPage 
    {
        public WebElement ColorChangeButton => Driver.FindElement(By.Id("colorChange"));

        public WebElement ColorAfterButton => Driver.FindElement(By.XPath("//button[@class='mt-4 text-danger btn btn-primary']"));

        public WebElement VisibleAfterButton => Driver.FindElement(By.Id("visibleAfter"));
    }
}
