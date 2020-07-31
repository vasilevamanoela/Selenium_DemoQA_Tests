using POMHomework.Pages;
using POMHomework.Utilities.Extensions;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.Pages.DemoQA.Navigation
{
    public partial class NavigationPage : BasePage
    {
        public NavigationPage(WebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/";

        public void NavigateToSections(string sectionName)
        {
            SectionsButtons(sectionName).ScrollTo().Click();
        }

        public void NavigateToElementsSubsection(string subsectionName)
        {
            ElementsSectionsButtons.Click();
            SideBarMenu(subsectionName).ScrollTo().ToBeVisible().Click();
        }

        public void NavigateToFormsSubsection(string subsectionName)
        {
            FormsSectionsButtons.Click();
            SideBarMenu(subsectionName).ScrollTo().ToBeVisible().Click();
        }

        public void NavigateToAlertSubsection(string subsectionName)
        {
            AlertsSectionsButtons.Click();
            SideBarMenu(subsectionName).ScrollTo().ToBeVisible().Click();
        }

        public void NavigateToWidgetsSubsection(string subsectionName)
        {
            WidgetsSectionsButtons.Click();
            SideBarMenu(subsectionName).ScrollTo().ToBeVisible().Click();
        }

        public void NavigateToInteractionsSubsection(string subsectionName)
        {
            InteractionsSectionsButtons.Click();
            SideBarMenu(subsectionName).ScrollTo().ToBeVisible().Click();
        }
    }
}
