using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class ResizablePage : BasePage
    {
        public ResizablePage(WebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/resizable";

        public void DragAndDropToOffset(WebElement sourse, int offsetX, int offsetY)
        {
            Builder
                .DragAndDropToOffset(sourse.WrappedElement, offsetX, offsetY)
                .Perform();
        }
    }
}
