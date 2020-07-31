using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using SeleniumExamPrep.PagesDemoQA._03WidgetsSection.Accordian;

namespace SeleniumExamPrep.Tests._03WidgetsSection
{
    [TestFixture]
    public class AccordianTests : BaseTest
    {
        private AccordianPage _accordianPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _accordianPage = new AccordianPage(Driver);
            _accordianPage.NavigateTo();
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
        public void SectionsAreClosedSuccessfully_When_ClickingDifferentSections()
        {
            //Arrange
            _accordianPage.Section1Heading.Click();

            //Act
            _accordianPage.SectionsClicking();

            //Assert
            _accordianPage.AssertSectionsAreClosed(_accordianPage.SectionsClosed);
        }

        [Test]
        [TestCase("1")]
        [TestCase("2")]
        [TestCase("3")]
        public void MessageDisplayed_When_ClickingDifferentSections(string number)
        {
            //Arrange
            _accordianPage.Section1Heading.Click();

            //Act
            _accordianPage.SectionsFields(number).Click();

            //Assert
            _accordianPage.AssertMessageDisplayed(_accordianPage.Message);
         }
    }
}
