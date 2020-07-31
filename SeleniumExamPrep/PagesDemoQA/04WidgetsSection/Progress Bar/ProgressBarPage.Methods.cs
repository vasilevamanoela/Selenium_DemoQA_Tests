using POMHomework.Pages;
using StabilizeTestsDemos.ThirdVersion;
using System.Threading;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.Progress_Bar
{
    public partial class ProgressBarPage : BasePage
    {
        public ProgressBarPage(WebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/progress-bar";
       
        public void ProgresBarLoading()
        {
            StartButton.Click();
            Thread.Sleep(1500);
            StartButton.Click();
        }
    }
}
