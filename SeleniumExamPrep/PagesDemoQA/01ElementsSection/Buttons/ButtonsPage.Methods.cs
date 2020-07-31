using POMHomework.Pages;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.Buttons
{
    public partial class ButtonsPage : BasePage
    {
        public ButtonsPage(WebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/buttons";

        public void DoubleClicking(WebElement element)
        {
            Builder
                .DoubleClick(element.WrappedElement)
                .Perform();
        }

        public void RightClicking(WebElement element)
        {
            Builder
                .ContextClick(element.WrappedElement)
                .Perform();
        }
    }
}
