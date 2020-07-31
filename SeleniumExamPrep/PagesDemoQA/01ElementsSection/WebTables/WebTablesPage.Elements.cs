using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.WebTables
{
    public partial class WebTablesPage
    {
        public WebElement SearchBox => Driver.FindElement(By.Id("searchBox"));

        public WebElement DeleteFirstRecord => Driver.FindElement(By.Id("delete-record-1"));

        public WebElement NoResultText => Driver.FindElement(By.XPath("//div[@class='rt-noData']"));
    }
}
