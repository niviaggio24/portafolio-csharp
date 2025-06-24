using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace PrimerPrograna
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();  //Instancio el objeto de tipo chrome driver            
            var nave = driver.Navigate();              //    
            nave.GoToUrl("https://qa-freyn1/GloriaCase/");
            Thread.Sleep(4000);
            var max = driver.Manage().Window;
            max.Maximize();

            var username = driver.FindElementByXPath("//*[@name='username']");
            username.Click();
            username.SendKeys("JKeller");
            Thread.Sleep(4000);
            driver.Close();            
        }
    }
}
