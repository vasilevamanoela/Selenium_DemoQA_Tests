using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace ExamPreparation.SeleniumTests.Pages._01Tooltips
{
    public partial class TooltipsPage 
    {
        public void AssertToolTipDiv(WebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }

        public void AssertCorrectText(string text, WebElement element)
        {
            Assert.AreEqual(text, element.Text);
        }
    }
}
