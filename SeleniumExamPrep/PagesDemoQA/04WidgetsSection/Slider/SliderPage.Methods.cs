using POMHomework.Pages;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.Slider
{
    public partial class SliderPage : BasePage
    {
        public SliderPage(WebDriver driver) : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/slider";

        public void MoveSliderToSliderValue(WebElement source, WebElement target)
        {
            Builder
                .DragAndDrop(source.WrappedElement, target.WrappedElement)
                .Perform();
        }

        public void MoveSliderByOffset(WebElement element)
        {
            Builder
                .DragAndDropToOffset(element.WrappedElement, 0, 100)
                .Perform();
        }
    }
}
