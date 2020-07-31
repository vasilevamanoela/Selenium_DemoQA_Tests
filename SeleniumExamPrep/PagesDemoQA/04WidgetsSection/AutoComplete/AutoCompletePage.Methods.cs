using POMHomework.Pages;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.AutoComplete
{
    public partial class AutoCompletePage : BasePage
    {
        public AutoCompletePage(WebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/auto-complete";

        public void WriteColor(WebElement element)
        {
            Builder
                .Click(element.WrappedElement)
                .SendKeys("Re")
                .Perform();
        }
    }
}
