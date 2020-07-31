using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.DynamicProperties
{
    public partial class DynamicPropertiesPage
    {
        public void AssertColorChanged(string colorBefore, string colorAfter)
        {
            Assert.AreNotEqual(colorBefore, colorAfter);
        }

        public void AssertElementDisplayed(WebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }
    }
}
