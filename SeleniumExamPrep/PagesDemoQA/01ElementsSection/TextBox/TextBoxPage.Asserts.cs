using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.TextBox
{
    public partial class TextBoxPage 
    {
        public void AssertMessageDisplayed(WebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }

        public void AssertMissingElement(WebElement element)
        {
            Assert.IsFalse(element.Displayed);
        }

        public void AssertColorChanged(string colorBefore, string colorAfter)
        {
            this.Driver.WaitForLoad();
            Assert.AreNotEqual(colorBefore, colorAfter);
        }

        public void AssertCorrectTextAfterSubmition(string text, WebElement element)
        {
            Assert.AreEqual(text, element.Text);
        }

        public void AssertCorrectTextPanel(string text, WebElement element)
        {
            StringAssert.Contains(text, element.Text);
        }
    }
}
