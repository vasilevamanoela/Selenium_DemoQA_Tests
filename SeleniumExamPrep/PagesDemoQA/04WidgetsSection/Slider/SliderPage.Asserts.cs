using NUnit.Framework;
using POMHomework.Utilities.Extensions;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.Slider
{
    public partial class SliderPage 
    {
        public void AssertChangedPosition(string before, string after)
        {
            Assert.AreNotEqual(before, after);
        }

        public void AssertExactPosition(string position, WebElement element)
        {
            Assert.AreEqual(position, element.GetProperty());
        }
    }
}
