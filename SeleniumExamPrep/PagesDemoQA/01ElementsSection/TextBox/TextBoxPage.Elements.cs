using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._01ElementsSection.TextBox
{
    public partial class TextBoxPage
    {
        public WebElement UserName => Driver.FindElement(By.Id("userName"));

        public WebElement UserEmail => Driver.FindElement(By.Id("userEmail"));

        public WebElement UserAdress => Driver.FindElement(By.Id("currentAddress"));

        public WebElement OtherAdress => Driver.FindElement(By.Id("permanentAddress"));

        public WebElement SubmitButton => Driver.FindElement(By.Id("submit"));

        public WebElement SubmitedName => Driver.FindElement(By.Id("name"));

        public WebElement SubmitedEmail => Driver.FindElement(By.Id("email"));

        public WebElement SubmitedCurrentAddress => Driver.FindElement(By.XPath("//p[@id='currentAddress']"));

        public WebElement SubmitedPermalentAddress => Driver.FindElement(By.XPath("//p[@id='permanentAddress']"));

        public WebElement Message => Driver.FindElement(By.XPath("//div[@class='border col-md-12 col-sm-12']"));

        public WebElement Output => Driver.FindElement(By.Id("output"));

        public WebElement SectionsFields(string sectionName) =>
            Driver.FindElement(By.XPath($"//div[@id='{sectionName}-wrapper']"));

        public WebElement OuthputField => Driver.FindElement(By.XPath("//p[@class='mb-1']"));
    }
}
