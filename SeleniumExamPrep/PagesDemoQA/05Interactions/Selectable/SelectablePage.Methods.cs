using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class SelectablePage : BasePage
    {
        public SelectablePage(WebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/selectable";
    }
}
