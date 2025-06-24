using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PetterMascotasAutomationProj.Actions
{
    public class Accept
    {
        public static bool Alert(IWebDriver driver)
        {
            try
            {
                driver.SwitchTo().Alert().Accept();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
    }
}
