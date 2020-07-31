using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;
using System.Collections.Generic;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.Accordian
{
    public partial class AccordianPage 
    {
        public WebElement Section1Heading => Driver.FindElement(By.Id("section1Heading"));

        public WebElement Section3Heading => Driver.FindElement(By.Id("section3Heading"));

        public List<WebElement> Sections => 
            Driver.FindElements(By.XPath("//div[@class='card-header']"));

        public WebElement Message => Driver.FindElement(By.XPath("//div[@class='collapse show']"));

        public List<WebElement> SectionsClosed => 
            Driver.FindElements(By.XPath("//div[@class='collapse']"));

        public WebElement SectionsFields(string numberOfSection) =>
            Driver.FindElement(By.XPath($"//div[@id='section{numberOfSection}Heading']"));
    }
}
