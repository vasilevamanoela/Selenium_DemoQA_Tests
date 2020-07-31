using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;
using System.Collections.Generic;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.Check_Box
{
    public partial class CheckBoxPage 
    {
        public WebElement SectionButton => Driver.FindElement(By.XPath("//*[@class='rct-icon rct-icon-expand-close']"));

        public List<WebElement> UncheckBoxButtons =>
            Driver.FindElements(By.XPath("//*[@class='rct-icon rct-icon-uncheck']"));

        public WebElement TextResult => Driver.FindElement(By.Id("result"));

        public List<WebElement> BoxesChecked => Driver.FindElements(By.XPath("//*[@class='rct-icon rct-icon-check']"));
    }
}
