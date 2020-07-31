using POMHomework.Pages;
using StabilizeTestsDemos.ThirdVersion;

namespace ExamPreparation.SeleniumTests.Pages._01Tooltips
{
    public partial class TooltipsPage : BasePage
    {
        public TooltipsPage(WebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/tool-tips";

       
        public void HoverToolTip(WebElement element)
        {
            Builder
                .MoveToElement(element.WrappedElement)
                .Perform();
        }
    }
}
