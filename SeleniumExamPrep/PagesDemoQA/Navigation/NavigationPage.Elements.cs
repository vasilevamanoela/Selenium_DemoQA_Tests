using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.Pages.DemoQA.Navigation
{
    public partial class NavigationPage 
    {
        public WebElement SectionsButtons(string sectionName) => 
            Driver.FindElement(By.XPath($"//*[normalize-space(text())='{sectionName}']/ancestor::div[contains(@class, 'top-card')]"));

        public WebElement ElementsSectionsButtons=>
            Driver.FindElement(By.XPath($"//*[normalize-space(text())='Elements']/ancestor::div[contains(@class, 'top-card')]"));

        public WebElement FormsSectionsButtons =>
            Driver.FindElement(By.XPath($"//*[normalize-space(text())='Forms']/ancestor::div[contains(@class, 'top-card')]"));

        public WebElement AlertsSectionsButtons =>
            Driver.FindElement(By.XPath($"//*[normalize-space(text())='Alerts, Frame & Windows']/ancestor::div[contains(@class, 'top-card')]"));

        public WebElement WidgetsSectionsButtons =>
            Driver.FindElement(By.XPath($"//*[normalize-space(text())='Widgets']/ancestor::div[contains(@class, 'top-card')]"));

        public WebElement InteractionsSectionsButtons =>
            Driver.FindElement(By.XPath($"//*[normalize-space(text())='Interactions']/ancestor::div[contains(@class, 'top-card')]"));

        public WebElement SideBarMenu(string subsectionName) =>
            Driver.FindElement(By.XPath($"//*[normalize-space(text())='{subsectionName}']"));

        public WebElement PageHeader => Driver.FindElement(By.ClassName("main-header"));
    }
}
