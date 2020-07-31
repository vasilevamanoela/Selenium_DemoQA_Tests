using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.Menu
{
    public partial class MenuPage 
    {
        public void AssertSubSectionDisplayed(WebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }
    }
}
