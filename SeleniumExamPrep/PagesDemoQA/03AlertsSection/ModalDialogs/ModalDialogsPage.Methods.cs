using POMHomework.Pages;
using StabilizeTestsDemos.ThirdVersion;
using System.Threading;

namespace SeleniumExamPrep.PagesDemoQA._02AlertsSection.ModalDialogs
{
    public partial class ModalDialogsPage : BasePage
    {
        public ModalDialogsPage(WebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/modal-dialogs";

        public void ClosingSmallModal()
        {
            SmallModalButton.Click();
            CloseSmallModalButton.Click();
            Thread.Sleep(200);
        }
    }
}
