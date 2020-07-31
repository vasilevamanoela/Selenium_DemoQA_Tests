using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.Buttons
{
    public partial class ButtonsPage 
    {
        public void AssertMessageDisplayed(WebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }

        public void AssertCorrectTextMessage(string message, WebElement element)
        {
            Assert.AreEqual(message, element.Text);
        }
    }
}
