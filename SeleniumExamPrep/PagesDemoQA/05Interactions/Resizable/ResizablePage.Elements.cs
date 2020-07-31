using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class ResizablePage 
    {
        public WebElement TheSlowestElementOnPage => Driver.FindElement(By.XPath("//*[@class='Advertisement-Section']"));

        public WebElement ResizeBox => Driver.FindElement(By.Id("resizableBoxWithRestriction"));

        public WebElement ResizeArrow => Driver.FindElement(By.XPath("//div[@id='resizableBoxWithRestriction']//span[@class='react-resizable-handle react-resizable-handle-se']"));

        public WebElement Container => Driver.FindElement(By.ClassName("constraint-area"));

    }
}
