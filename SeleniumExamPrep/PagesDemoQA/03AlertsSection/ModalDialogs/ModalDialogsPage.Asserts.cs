using NUnit.Framework;

namespace SeleniumExamPrep.PagesDemoQA._02AlertsSection.ModalDialogs
{
    public partial class ModalDialogsPage 
    {
        public void AssertColorChanged(string colorBefore, string colorAfter)
        {
            Assert.AreNotEqual(colorBefore, colorAfter);
        }
    }
}
