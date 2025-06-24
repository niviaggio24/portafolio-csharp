using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProyectoAutomatiza1
{
    class Practica1
    {
        IWebDriver driver;
        
        [TestMethod]

        public void Initialize()
        {

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://qa-freyn/PracticaSelenium/");
            System.Threading.Thread.Sleep(5000);
        }
    }
}
