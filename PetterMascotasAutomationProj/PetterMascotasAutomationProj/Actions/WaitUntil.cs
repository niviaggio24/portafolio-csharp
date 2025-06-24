using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


// Esta accion de wait util lo que hace es esperar por un elemento

namespace PetterMascotasAutomationProj.Actions
{
    public class WaitUntil
    {
        public static bool ElementIsPresent(IWebDriver driver, By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                wait.Until(drv => drv.FindElement(locator));
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
