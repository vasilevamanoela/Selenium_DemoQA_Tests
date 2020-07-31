using NUnit.Framework;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class SelectablePage 
    {
        public void AssertChangedColor(string colorBefore, string colorAfter)
        {
            Assert.IsFalse(colorBefore == colorAfter);
        }

        public void AssertExactColor(string exactColor, string color)
        {
            Assert.AreEqual(exactColor, color);
        }
    }
}
