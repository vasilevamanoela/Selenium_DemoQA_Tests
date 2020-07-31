using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.Buttons
{
    public partial class ButtonsPage
    {
        public WebElement ClickMeButton => Driver.FindElement(By.XPath("//button[text()='Click Me']"));

        public WebElement DoubleClickMeButton => Driver.FindElement(By.Id("doubleClickBtn"));

        public WebElement RightClickMeButton => Driver.FindElement(By.Id("rightClickBtn"));

        public WebElement ClickMeMessage => Driver.FindElement(By.Id("dynamicClickMessage"));

        public WebElement DoubleClickMessage => Driver.FindElement(By.Id("doubleClickMessage"));

        public WebElement RightClickMessage => Driver.FindElement(By.Id("rightClickMessage"));
    }
}
