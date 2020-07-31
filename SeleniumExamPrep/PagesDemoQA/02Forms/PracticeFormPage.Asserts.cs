using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._02Forms
{
    public partial class PracticeFormPage
    {
        public void AssertCorrectThanksMessage(string message, WebElement element)
        {
            Assert.AreEqual(message, element.Text);
        }

        public void AssertValueDisplayedAfterSubmittion(WebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }

        public void AssertColorChanged(string colorBefore, string colorAfter)
        {
            this.Driver.WaitForLoad();
            Assert.AreNotEqual(colorBefore, colorAfter);
        }
    }
}
