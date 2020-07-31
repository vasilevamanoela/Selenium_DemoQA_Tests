using POMHomework.Pages;
using POMHomework.Utilities.Extensions;
using SeleniumExamPrep.Models;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.TextBox
{
    public partial class TextBoxPage : BasePage
    {
        public TextBoxPage(WebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/text-box";

        public void FillForm(TextBoxModel user)
        {
            UserName.ScrollTo().SetText(user.UserName);
            UserEmail.ScrollTo().SetText(user.UserEmail);
            UserAdress.ScrollTo().SetText(user.UserAdress);
            OtherAdress.ScrollTo().SetText(user.OtherAdress);

            SubmitButton.Click();
        }

        public void FillOnePanel(string text)
        {
            Builder
                .MoveToElement(SectionsFields(text).WrappedElement)
                .Click()
                .SendKeys("Some Text")
                .Perform();

            SubmitButton.ScrollTo().Click();
        }
    }
}
