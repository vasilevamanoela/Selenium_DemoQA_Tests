using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;
using System.Collections.Generic;
using System.Linq;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class SelectablePage 
    {
        public WebElement TheSlowestElementOnPage => Driver.FindElement(By.XPath("//*[@class='Advertisement-Section']"));

        public WebElement LastBox => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/ul/li[4]"));

        public WebElement List => Driver.FindElement(By.Id("verticalListContainer"));

        public List<WebElement> ListOptions => Driver.FindElements(By.XPath("//ul[@id='verticalListContainer']//li")).ToList();
    }
}
