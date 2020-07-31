using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.RadioButton
{
    public partial class RadioButtonPage 
    {
        public void AssertSuccessText(string text, WebElement element)
        {
            Assert.AreEqual(text, element.Text);
        }
    }
}
