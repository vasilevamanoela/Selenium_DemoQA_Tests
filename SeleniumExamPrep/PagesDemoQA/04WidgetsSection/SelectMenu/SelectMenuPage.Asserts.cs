using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.SelectMenu
{
    public partial class SelectMenuPage
    {
        public void AssertCorectColor(string color, WebElement element)
        {
            Assert.AreEqual(color, element.Text);
        }
    }
}
