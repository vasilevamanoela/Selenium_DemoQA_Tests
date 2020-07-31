using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._04WidgetsSection.Tabs
{
    public partial class TabsPage
    {
        public void AssertTextDisplayed(WebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }
    }
}
