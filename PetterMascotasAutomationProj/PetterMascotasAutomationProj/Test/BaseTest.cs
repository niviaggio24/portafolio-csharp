
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PetterMascotasAutomationProj.Test
{

    // This class allows to initialize and close the browser with the related url which it then maximizes.
    // From here most of the subclasses inherit this configuration.  

    public class BaseTest
    {
        protected IWebDriver Driver;
        protected string Url = "http://petter.eastus2.cloudapp.azure.com/";

        [SetUp]
        public void SetUpBase()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(Url);
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDownBase()
        {
            if (Driver != null)
                Driver.Quit();
        }
    }
}