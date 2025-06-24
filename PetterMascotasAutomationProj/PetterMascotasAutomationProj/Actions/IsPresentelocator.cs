using OpenQA.Selenium;
using System;

namespace PetterMascotasAutomationProj.Actions
{

    /// esta podria ser una tarea pero la incliu en acciones ya que nos va a chekiar o validar si encontro el elemento.
    ///  
    /// </summary>
    public class IsPresentelocator
    {
        public static bool validation(IWebDriver driver, By locator)
        {
            return WaitUntil.ElementIsPresent(driver, locator);
        }

    }
}