using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class DragabblePage : BasePage
    {
        public DragabblePage(WebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/dragabble";

        public void DragAndDropToOffset(WebElement sourse, int offsetX, int offsetY)
        {
            Builder
                .DragAndDropToOffset(sourse.WrappedElement, offsetX, offsetY)
                    .SendKeys(sourse.WrappedElement, Keys.Tab)
                    .Perform();
        }
    }
}
