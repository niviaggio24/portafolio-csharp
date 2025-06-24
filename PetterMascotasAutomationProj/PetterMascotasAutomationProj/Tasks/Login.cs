using System;
using OpenQA.Selenium;
using PetterMascotasAutomationProj.Actions;
using PetterMascotasAutomationProj.UI;


// esta tarea de loguearse que llama a la clase Enter de Acciones nos permite usar el localizar del usuario passwor y el boton
// Usar el localizador del usuario.
// 
// 

namespace PetterMascotasAutomationProj.Tasks
{

    public class Login
    {
        public static void As(IWebDriver driver, string user, string passWord)
        {
            Enter.Text(driver, LoginPage.ImputUser, user);
            Enter.Text(driver, LoginPage.ImputPassword, passWord);
            Click.On(driver, LoginPage.btnStartSesion);
        }
    }
}
