using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.WebTables
{
    public partial class WebTablesPage 
    {
        public void AssertNoRowsFound(WebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }

        public void AssertNoRowsFoundText(string text, WebElement element)
        {
            Assert.AreEqual(text, element.Text);
        }
    }
}
