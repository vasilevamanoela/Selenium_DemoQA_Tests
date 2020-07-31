using OpenQA.Selenium.Support.UI;
using POMHomework.Pages;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.SelectMenu
{
    public partial class SelectMenuPage : BasePage
    {
        public SelectMenuPage(WebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/select-menu";

        public void SelectColor()
        {
            SelectElement color = new SelectElement(OldSelectMenu.WrappedElement);
            color.SelectByValue("3");
        }

        public void ColorSelection(string color)
        {
            OldSelectMenu.Click();
            Colors(color).Click();
        }
    }
}
