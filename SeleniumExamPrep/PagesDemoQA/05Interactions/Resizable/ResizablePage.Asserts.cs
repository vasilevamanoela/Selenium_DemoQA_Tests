using NUnit.Framework;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class ResizablePage
    {
        public void AssertExactPosition(double exactPosition, double element, int delta)
        {
            Assert.AreEqual(exactPosition, element, 3);
            Assert.AreEqual(exactPosition, element, 3);
        }

        public void AssertPosition(double container, double resizeBox)
        {
            Assert.AreEqual(container, resizeBox);
            Assert.AreEqual(container, resizeBox);
        }
    }
}
