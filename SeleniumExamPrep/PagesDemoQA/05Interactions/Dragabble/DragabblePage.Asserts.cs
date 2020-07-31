using NUnit.Framework;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class DragabblePage 
    {
        public void AssertPositionChanged(int offsetX, int offsetY)
        {
            Assert.IsFalse(offsetX == offsetY);
        }

        public void AssertPositionIsNotChanged(int offsetX, int offsetY)
        {
            Assert.AreEqual(offsetX, offsetY);
        }

        public void AssertExactPosition(double position, int sourse, int delta)
        {
            Assert.AreEqual(position, sourse, delta);
        }
    }
}
