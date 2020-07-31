using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class DragabblePage
    {
        public WebElement TheSlowestElementOnPage => Driver.FindElement(By.XPath("//*[@class='Advertisement-Section']"));

        public WebElement AxisRestrictedTab => Driver.FindElement(By.Id("draggableExample-tab-axisRestriction"));

        public WebElement DraggebleBox => Driver.FindElement(By.Id("dragBox"));

        public WebElement onlyXBox => Driver.FindElement(By.Id("restrictedX"));
       
        public WebElement onlyYBox => Driver.FindElement(By.Id("restrictedY"));
    }
}
