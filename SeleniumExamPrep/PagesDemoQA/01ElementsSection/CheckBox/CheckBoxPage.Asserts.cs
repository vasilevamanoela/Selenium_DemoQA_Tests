using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.Check_Box
{
    public partial class CheckBoxPage 
    {
        public void AssertMessageDisplayed(WebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }

        public void AssertCorrectMessage(string message, WebElement element)
        {
            Assert.AreEqual(message, element.Text);
        }
    }
}
