using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace SeleniumExamPrep.PagesDemoQA._03WidgetsSection.Slider
{
    public partial class SliderPage
    {
        public WebElement SliderDot => Driver.FindElement(By.XPath("//input[@class='range-slider range-slider--primary']"));

        public WebElement SliderValue => Driver.FindElement(By.Id("sliderValue"));
    }
}
