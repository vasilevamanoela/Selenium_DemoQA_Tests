using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;
using System.Collections.Generic;
using System.Linq;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class SortablePage
    {
        public WebElement TheSlowestElementOnPage => Driver.FindElement(By.XPath("//*[@class='Advertisement-Section']"));

        public WebElement SortablePanel => Driver.FindElement(By.XPath("//li[@class='btn btn-light active']"));

        public WebElement FirstElement => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[1]"));

        public WebElement LastElement => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[6]"));

        public List<WebElement> ListOfOption => Driver.FindElements(By.XPath("//div[@id='demo-tabpane-list']//div[contains(@class, 'list-group-item')]")).ToList();
    }
}
