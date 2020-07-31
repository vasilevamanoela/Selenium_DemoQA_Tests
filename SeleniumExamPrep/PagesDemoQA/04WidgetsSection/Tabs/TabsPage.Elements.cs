using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._04WidgetsSection.Tabs
{
    public partial class TabsPage 
    {
        public WebElement Sections(string sectionName) => Driver.FindElement(By.XPath($"//a[text()='{sectionName}']"));

        public WebElement TextParagraph => Driver.FindElement(By.XPath("//div[@class='fade tab-pane active show']"));
    }
}
