using OpenQA.Selenium;
using POMHomework.Pages;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._02AlertsSection.Alerts
{
    public partial class AlertsPage : BasePage
    {
        public AlertsPage(WebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/alerts";

        public WebElement AlertButton => Driver.FindElement(By.Id("alertButton"));

        public WebElement TimerAlertButton => Driver.FindElement(By.Id("timerAlertButton"));

        public WebElement ConfirmButton => Driver.FindElement(By.Id("confirmButton"));

        public WebElement PromtButton => Driver.FindElement(By.Id("promtButton"));

        public WebElement CanceledText => Driver.FindElement(By.XPath("//span[text()='Cancel']"));
    }
}
