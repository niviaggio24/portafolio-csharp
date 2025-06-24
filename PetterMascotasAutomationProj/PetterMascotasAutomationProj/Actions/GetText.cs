using OpenQA.Selenium;


namespace PetterMascotasAutomationProj.Actions
{
    // this class will capture the value of the element to which it is pointing
    public class GetText
    {
        public static string Message(IWebDriver driver, By locator, string property)
        {
            return driver.FindElement(locator).GetAttribute(property);
        }
    }
}