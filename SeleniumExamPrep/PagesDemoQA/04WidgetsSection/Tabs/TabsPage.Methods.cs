using POMHomework.Pages;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._04WidgetsSection.Tabs
{
    public partial class TabsPage : BasePage
    {
        public TabsPage(WebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/tabs";
      
        public void SelectTab(string tabName)
        {
            Sections(tabName).Click();
        }
    }
}
