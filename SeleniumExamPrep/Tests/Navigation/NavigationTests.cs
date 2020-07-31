using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using SeleniumExamPrep.Pages.DemoQA.Navigation;

namespace SeleniumExamPrep.Tests.Navigation
{
    [TestFixture]
    public class NavigationTests : BaseTest
    {
        private NavigationPage _navigationPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _navigationPage = new NavigationPage(Driver);
            _navigationPage.NavigateTo();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.TakeScreenshot();
            }

            Driver.Quit();
        }

        [Test]
        [TestCase("Elements")]
        [TestCase("Forms")]
        [TestCase("Alerts, Frame & Windows")]
        [TestCase("Widgets")]
        [TestCase("Interactions")]
        public void SectionsNamesDisplayed_When_NavigateToDemoQA(string sectionName)
        {
            _navigationPage.NavigateToSections(sectionName);

            _navigationPage.AssertCorrectSubsectionTitles(sectionName, _navigationPage.PageHeader);
        }
        

        [Test]
        [TestCase("Text Box")]
        [TestCase("Check Box")]
        [TestCase("Radio Button")]
        [TestCase("Web Tables")]
        [TestCase("Buttons")]
        [TestCase("Links")]
        [TestCase("Upload and Download")]
        [TestCase("Dynamic Properties")]
        public void ElementsSectionNameDisplayed_When_NavigateToElementsSection(string subsectionName)
        {
            _navigationPage.NavigateToElementsSubsection(subsectionName);

            _navigationPage.AssertCorrectSubsectionTitles(subsectionName, _navigationPage.PageHeader);
        }

        [Test]
        [TestCase("Forms")]
        public void FormsSectionNameDisplayed_When_NavigateToFormsSection(string subsectionName)
        {
            _navigationPage.NavigateToFormsSubsection(subsectionName);

            _navigationPage.AssertCorrectSubsectionTitles(subsectionName, _navigationPage.PageHeader);
        }

        [Test]
        [TestCase("Browser Windows")]
        [TestCase("Alerts")]
        [TestCase("Frames")]
        [TestCase("Modal Dialogs")]
        public void AlertsSectionNameDisplayed_When_NavigateToAlertsSection(string subsectionName)
        {
            _navigationPage.NavigateToAlertSubsection(subsectionName);

            _navigationPage.AssertCorrectSubsectionTitles(subsectionName, _navigationPage.PageHeader);
        }

        [Test]
        [TestCase("Accordian")]
        [TestCase("Auto Complete")]
        [TestCase("Date Picker")]
        [TestCase("Slider")]
        [TestCase("Progress Bar")]
        [TestCase("Tabs")]
        [TestCase("Tool Tips")]
        [TestCase("Menu")]
        [TestCase("Select Menu")]
        public void WidgetsSectionNameDisplayed_When_NavigateToWidgetsSection(string subsectionName)
        {
            _navigationPage.NavigateToWidgetsSubsection(subsectionName);

            _navigationPage.AssertCorrectSubsectionTitles(subsectionName, _navigationPage.PageHeader);
        }

        [Test]
        [TestCase("Sortable")]
        [TestCase("Selectable")]
        [TestCase("Resizable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]
        public void InteractionsSectionNameDisplayed_When_NavigateToInteractionsSection(string subsectionName)
        {
            _navigationPage.NavigateToInteractionsSubsection(subsectionName);

            _navigationPage.AssertCorrectSubsectionTitles(subsectionName, _navigationPage.PageHeader);
        }
    }
}
