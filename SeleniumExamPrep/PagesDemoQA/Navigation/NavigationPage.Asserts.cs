using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.Pages.DemoQA.Navigation
{
    public partial class NavigationPage 
    {
        public void AssertCorrectSubsectionTitles(string subsectionName, WebElement element)
        {
            Assert.AreEqual(subsectionName, PageHeader.Text);
        }
    }
}
