using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._02AlertsSection.ModalDialogs
{
    public partial class ModalDialogsPage 
    {

        public WebElement SmallModalButton => Driver.FindElement(By.Id("showSmallModal"));

        public WebElement CloseSmallModalButton => Driver.FindElement(By.Id("closeSmallModal"));
    }
}
