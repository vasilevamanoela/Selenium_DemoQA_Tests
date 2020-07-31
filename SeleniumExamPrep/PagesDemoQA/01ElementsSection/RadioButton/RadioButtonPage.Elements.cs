using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;
using System.Collections.Generic;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.RadioButton
{
    public partial class RadioButtonPage
    {
        public List<WebElement> RadioButtons => Driver.FindElements(By.XPath("//label[@class='custom-control-label']"));

        public WebElement SuccessMessage => Driver.FindElement(By.XPath("//span[@class='text-success']"));
    }
}
