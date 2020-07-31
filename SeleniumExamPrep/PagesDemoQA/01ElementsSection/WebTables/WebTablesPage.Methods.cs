using POMHomework.Pages;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.WebTables
{
    public partial class WebTablesPage : BasePage
    {
        public WebTablesPage(WebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/webtables";

        public void SearchAndDeledeRecord()
        {
            SearchBox.SetText("Vega");
            DeleteFirstRecord.Click();
        }
    }
}
