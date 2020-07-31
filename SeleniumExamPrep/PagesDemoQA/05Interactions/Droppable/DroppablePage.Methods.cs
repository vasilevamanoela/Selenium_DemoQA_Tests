using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class DroppablePage : BasePage
    {
        public DroppablePage(WebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/droppable";

        public void DragAndDrop(WebElement sourse, WebElement target)
        {
            Builder
                .DragAndDrop(sourse.WrappedElement, target.WrappedElement)
                .SendKeys(sourse.WrappedElement, Keys.Tab)
                .Perform();
        }

        public void DragAndDropToOffset(WebElement sourse, int offsetX, int offsetY)
        {
            Builder
                .DragAndDropToOffset(sourse.WrappedElement, offsetX, offsetY)
                .SendKeys(sourse.WrappedElement, Keys.Tab)
                .Perform();
        }
    }
}
