using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.Progress_Bar
{
    public partial class ProgressBarPage 
    {
        public void AssertExactNumberLoaded(string number, WebElement element)
        {
            Assert.AreEqual(number, element.Text);
        }
    }
}
