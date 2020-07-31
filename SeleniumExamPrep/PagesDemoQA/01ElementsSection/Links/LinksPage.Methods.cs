using NUnit.Framework;
using POMHomework.Pages;
using POMHomework.Utilities.Extensions;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.Links
{
    public partial class LinksPage : BasePage
    {
        public LinksPage(WebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/links";

        public void ClickAPICallsButton()
        {
            for (int i = 0; i < 7; i++)
            {
                APICallsButtons[i].ScrollTo().Click();

                Assert.IsTrue(LinkResponse.Displayed);
            }
        }
    }
}
