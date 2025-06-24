using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PetterMascotasAutomationProj.Actions
    //It is a JavaScript function that runs in the browser and gets the element
    // fuente : https://stackoverflow.com/questions/28473710/how-to-scroll-to-element-with-selenium-webdriver

{
    public class Scroll
    {
        public static void ScrollAuto(IWebDriver driver, By locator)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement element = driver.FindElement(locator);
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);

        }
    }
}
