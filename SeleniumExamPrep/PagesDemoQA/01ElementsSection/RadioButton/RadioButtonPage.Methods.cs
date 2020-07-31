using NUnit.Framework;
using POMHomework.Pages;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.RadioButton
{
    public partial class RadioButtonPage : BasePage
    {
        public RadioButtonPage(WebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/radio-button";

        public void CheckingRadioButtons()
        {
            for (int i = 0; i < 2; i++)
            {
                RadioButtons[i].Click();
                Assert.IsTrue(SuccessMessage.Displayed);
            }
        }
    }
}
