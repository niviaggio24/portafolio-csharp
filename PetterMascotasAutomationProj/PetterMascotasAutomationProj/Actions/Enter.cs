using OpenQA.Selenium;

//Esta clase permite escribir un campo de texto, el texto que pasen por paramentro

namespace PetterMascotasAutomationProj.Actions
{
    public class Enter
    {
        public static void Text(IWebDriver driver, By locator, string text)
        {
            driver.FindElement(locator).SendKeys(text);
        }
    }
}
