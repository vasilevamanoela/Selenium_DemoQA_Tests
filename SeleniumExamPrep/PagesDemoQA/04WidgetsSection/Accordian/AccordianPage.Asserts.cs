using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.Accordian
{
    public partial class AccordianPage 
    {
        public void AssertSectionsAreClosed(List<WebElement> elements)
        {
            var section = SectionsClosed.Select(e => e.Displayed).ToList();
            CollectionAssert.IsNotEmpty(section);
        }

        public void AssertMessageDisplayed(WebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }
    }
}
