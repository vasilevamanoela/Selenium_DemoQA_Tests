using POMHomework.Pages;
using StabilizeTestsDemos.ThirdVersion;
using System.Threading;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.DynamicProperties
{
    public partial class DynamicPropertiesPage : BasePage
    {
        public DynamicPropertiesPage(WebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/dynamic-properties";
   
        public void WaitPageToLoad()
        {
            Thread.Sleep(5500);
        }
    }
}
