using POMHomework.Pages;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.Check_Box
{
    public partial class CheckBoxPage : BasePage
    {
        public CheckBoxPage(WebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/checkbox";

        public void CheckingUncheckedBoxes()
        {
            SectionButton.Click();

            UncheckBoxButtons[1].Click();

            for (int i = 0; i < 2; i++)
            {
                UncheckBoxButtons[0].Click();
            }
        }

        public void CheckingOneBox(int i)
        {
            SectionButton.Click();

            UncheckBoxButtons[i].Click();
        }
    }
}
