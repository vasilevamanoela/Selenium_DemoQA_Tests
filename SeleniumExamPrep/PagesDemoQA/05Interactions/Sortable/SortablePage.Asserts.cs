using NUnit.Framework;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class SortablePage 
    {
        public void AsserChangedElements(string firstElement, string secondElement)
        {
            Assert.AreEqual(firstElement, secondElement);
        }
    }
}
