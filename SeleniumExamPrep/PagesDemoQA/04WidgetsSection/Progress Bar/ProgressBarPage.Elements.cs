using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.Progress_Bar
{
    public partial class ProgressBarPage 
    {
        public WebElement StartButton => Driver.FindElement(By.Id("startStopButton"));

        public WebElement ProgressBar => Driver.FindElement(By.XPath("//div[@role='progressbar']"));
    }
}
