using NUnit.Framework;
using PetterMascotasAutomationProj.Tasks;
using PetterMascotasAutomationProj.Actions;
using System;

namespace PetterMascotasAutomationProj.Test

// This Class that contains the login test case
// Este test utiliza la clase tarea login pasando el usuario y la contraseña y despues se valida si se muestra la pantalla donde cliente despues de haberce logueado
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        [Test]
        public void SuccesfulLoginTest()
        {
            Login.As(Driver, "adminbog", "123");
            //Assert.IsTrue(IsPresentelocator.Validation(Driver));
        }        
    }
}
