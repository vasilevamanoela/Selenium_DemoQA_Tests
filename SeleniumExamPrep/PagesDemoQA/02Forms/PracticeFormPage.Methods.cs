using POMHomework.Pages;
using POMHomework.Utilities.Extensions;
using SeleniumExamPrep.Models;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._02Forms
{
    public partial class PracticeFormPage : BasePage
    {
        public PracticeFormPage(WebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/automation-practice-form";
    
        public void FillForm(PracticeFormModel user)
        {
            FirstName.SetText(user.FirstName);
            LastName.SetText(user.LastName);
            UserEmail.SetText(user.UserEmail);
            MaleGender.Click();
            UserNumber.SetText(user.UserNumber);
            SportsHobby.Click();

            SubmitButton.ScrollTo().Click();
        }

        public void FillFormWithDifferentGender(string labelText, PracticeFormModel user)
        {
            FirstName.SetText(user.FirstName);
            LastName.SetText(user.LastName);
            UserEmail.SetText(user.UserEmail);
            Gender(labelText).Click();
            UserNumber.SetText(user.UserNumber);
            SportsHobby.Click();

            SubmitButton.ScrollTo().Click();
        }

        public void FillFormWithDifferentHobbies(string labelText, PracticeFormModel user)
        {
            FirstName.SetText(user.FirstName);
            LastName.SetText(user.LastName);
            UserEmail.SetText(user.UserEmail);
            MaleGender.Click();
            UserNumber.SetText(user.UserNumber);
            HobbiesButtons(labelText).Click();

            SubmitButton.ScrollTo().Click();
        }    
    }
}
