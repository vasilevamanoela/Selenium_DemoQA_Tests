using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._02Forms
{
    public partial class PracticeFormPage
    {
        public WebElement FirstName => Driver.FindElement(By.Id("firstName"));

        public WebElement LastName => Driver.FindElement(By.Id("lastName"));

        public WebElement UserEmail => Driver.FindElement(By.Id("userEmail"));

        public WebElement MaleGender => Driver.FindElement(By.XPath("//div[@id='genterWrapper']//label[text()='Male']"));
        public WebElement Gender(string lebelText) =>
            Driver.FindElement(By.XPath($"//div[@id='genterWrapper']//label[text()='{lebelText}']"));

        public WebElement UserNumber => Driver.FindElement(By.Id("userNumber"));

        public WebElement SportsHobby => Driver.FindElement(By.XPath($"//div[@id='hobbiesWrapper']//label[text()='Sports']"));
        public WebElement HobbiesButtons(string labelText) =>
            Driver.FindElement(By.XPath($"//div[@id='hobbiesWrapper']//label[text()='{labelText}']"));

        public WebElement SubmitButton => Driver.FindElement(By.Id("submit"));

        public WebElement ThanksMessage => Driver.FindElement(By.Id("example-modal-sizes-title-lg"));

        public WebElement SectionAftreSubmition(string text) =>
            Driver.FindElement(By.XPath($"//td[text()='{text}']"));
    }
}
