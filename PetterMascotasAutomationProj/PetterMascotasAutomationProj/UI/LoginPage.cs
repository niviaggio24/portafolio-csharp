
using OpenQA.Selenium;

namespace PetterMascotasAutomationProj.UI

    // In this class the elements are parameterized by id of the page authentication
{   // Aca se encuentran los atributos localizadores de la pagina de autenticacion 
    public class LoginPage 
    {
         
        public static By ImputUser = By.Id("username");
        public static By ImputPassword = By.Id("password");
        public static By btnStartSesion = By.Id("submitButton");
    }
}