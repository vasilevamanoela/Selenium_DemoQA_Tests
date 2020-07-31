using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace ExamPreparation.SeleniumTests.Pages._01Tooltips
{
    public partial class TooltipsPage
    {
        public WebElement InputField => Driver.FindElement(By.Id("toolTipTextField"));

        public WebElement ToolTipDiv => Driver.FindElement(By.Id("textFieldToolTip"));

        public WebElement FirstInputField => Driver.FindElement(By.Id("toolTipButton"));

        public WebElement HoveredButton => Driver.FindElement(By.Id("buttonToolTip"));

    }
}
