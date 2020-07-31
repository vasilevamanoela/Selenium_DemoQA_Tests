using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.AutoComplete
{
    public partial class AutoCompletePage 
    {
        public void AssertColorDisplayed(WebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }

        public void AssertCorrectColor(string color, WebElement element)
        {
            Assert.AreEqual(color, element.Text);
        }
    }
}
