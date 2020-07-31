using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;
using System.Collections.Generic;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.Links
{
    public partial class LinksPage 
    {
        public WebElement SimpleLink => Driver.FindElement(By.Id("simpleLink"));

        public WebElement PageHeader => Driver.FindElement(By.XPath("//img[@src='/images/Toolsqa.jpg']"));

        public List<WebElement> APICallsButtons => Driver.FindElements(By.XPath("//a[@href='javascript:void(0)']"));

        public WebElement LinkResponse => Driver.FindElement(By.Id("linkResponse"));
    }
}
