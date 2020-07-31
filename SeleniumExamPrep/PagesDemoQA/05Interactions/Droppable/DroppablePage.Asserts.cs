using NUnit.Framework;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class DroppablePage 
    {
        public void AssertColorChanged(string colorBefore, string colorAfter)
        {
            Assert.AreNotEqual(colorBefore, colorAfter);
        }

        public void AssertExactColor(string exactColor, string colorAfter)
        {
            Assert.AreEqual(exactColor, colorAfter);
        }

        public void AssertPositionChanged(double positionBefore, double positionAfter)
        {
            Assert.AreNotEqual(positionBefore, positionAfter);
        }

        public void AssertExactPosition(double exactPosition, double position, int delta)
        {
            Assert.AreEqual(exactPosition, position, delta);
        }
    }
}
