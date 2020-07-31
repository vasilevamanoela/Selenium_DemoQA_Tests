using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class DroppablePage 
    {
        public WebElement TheSlowestElementOnPage => Driver.FindElement(By.XPath("//*[@class='Advertisement-Section']"));

        public WebElement SourceBox => Driver.FindElement(By.Id("draggable"));

        public WebElement TargetBox => Driver.FindElement(By.Id("droppable"));
    }
}
