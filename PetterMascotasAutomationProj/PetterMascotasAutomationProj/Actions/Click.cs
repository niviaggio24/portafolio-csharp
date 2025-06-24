using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


// Es clase nos permite interactuar con el navegador, tenemos la clase click
// que nos permite dar clic en culaquier elemento (locator) de selenium (Iwebdriver)
namespace PetterMascotasAutomationProj.Actions
{
    public class Click
    {
        public static void On(IWebDriver driver, By locator)
        {
            driver.FindElement(locator).Click();
        }
    }
}
