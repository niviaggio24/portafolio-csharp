using NUnit.Framework;
using PetterMascotasAutomationProj.Tasks;
using PetterMascotasAutomationProj.Actions;
using PetterMascotasAutomationProj.UI;

// This Class that contains the test case of creating the new customer, adding the 3 products and registering the sale.
//caso de prueba de cliente

namespace PetterMascotasAutomationProj.Test
{
    [TestFixture]
    public class ClientTest : BaseTest
    {
        
        // Aca lo primero que hacemos en loguearnos dentro de la aplicacion.
        [SetUp]
        public void SetUp()
        {
            Login.As(Driver, "adminbog", "123");    
        }

        [Test]
        public void AddClienteTest()
        {
            // aca se llama a la tarea de agregar clietne 
            AddCliente.WithTheData(Driver);
            WaitUntil.ElementIsPresent(Driver, PetterMPage.btnSave);            
            AddProducts.LoadProductsData(Driver);
            //var temp = AddCliente.cedGlobal;

             string totalVenta = GetText.Message(Driver, SalePage.txtTotalSale, "value");
             Assert.AreEqual("1983071081", totalVenta, "Valor total");

             string nombrecliente = GetText.Message(Driver, SalePage.txtFindClient, "value");
             var NamUserRnd = AddCliente.nomnbreGlobal;
             Assert.AreEqual(NamUserRnd, nombrecliente, "Valor total");         
        }
    }
}