using NUnit.Framework;
using POMHomework.Pages;
using POMHomework.Utilities.Extensions;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.Accordian
{
    public partial class AccordianPage : BasePage
    {
        public AccordianPage(WebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/accordian";

        public void SectionsClicking()
        {

            for (int i = 0; i < Sections.Count; i++)
            {
                Sections[i].ScrollTo().Click();
                Assert.IsTrue(Message.Displayed);
            }

            Section3Heading.Click();
        }
    }
}
