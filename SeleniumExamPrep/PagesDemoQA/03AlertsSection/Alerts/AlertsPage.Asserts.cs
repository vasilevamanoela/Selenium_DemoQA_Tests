using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._02AlertsSection.Alerts
{
    public partial class AlertsPage
    {
        public void AssertChangedColor(string colorBefore, string colorAfter)
        {
            Assert.AreNotEqual(colorBefore, colorAfter);
        }

        public void AssertTextDisplayed(WebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }

        public void AssertCorrectText(string message, WebElement element)
        {
            Assert.AreEqual(message, element.Text);
        }
    }
}
