using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaInterfaces
{

    //aca escribe y lee. la clase se llamaria "acciones pagina". select drow dronw  o un doble clic
    class Busqueda_elementos

    {

        public void clicXpath(string elemento, IWebDriver driver)
        {

            var element = driver.FindElement(By.XPath(elemento));
            element.Click();
        }

        public void IngresartextxXpath(string elemento, IWebDriver driver, string textoingres)
        {

            var element = driver.FindElement(By.XPath(elemento));
            element.SendKeys(textoingres);
        }
    }
}

