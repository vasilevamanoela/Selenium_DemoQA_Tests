using POMHomework.Pages;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.Menu
{
    public partial class MenuPage : BasePage
    {
        public MenuPage(WebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/menu";

        public void HoverMenu(WebElement element)
        {
            Builder
                .MoveToElement(element.WrappedElement)
                .Perform();
        }
    }
}
