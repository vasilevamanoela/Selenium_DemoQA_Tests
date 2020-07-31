using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.Links
{
    public partial class LinksPage 
    {
        public void AssertPageHeaderExist(WebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }
    }
}
