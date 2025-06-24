using OpenQA.Selenium;
using PetterMascotasAutomationProj.Actions;
using PetterMascotasAutomationProj.UI;
using NUnit.Framework;




namespace PetterMascotasAutomationProj.Tasks
{
    
    public class AddCliente
    {
        // Global variables

        public static string cedGlobal { get; set; }
        public static string nomnbreGlobal { get; set; }

        public static void WithTheData(IWebDriver driver)
        {
            WaitUntil.ElementIsPresent(driver, PetterMPage.btnclient);
            Click.On(driver, PetterMPage.btnclient);
            WaitUntil.ElementIsPresent(driver, PetterMPage.btnNewClient);
            Click.On(driver, PetterMPage.btnNewClient);

            //Se guarda en una var global el documento y el nombre para validar la asercion

            cedGlobal = genCed();
            nomnbreGlobal = genName();


            Enter.Text(driver, PetterMPage.txtIdentifiCard, cedGlobal);            
            Enter.Text(driver, PetterMPage.txtNames, nomnbreGlobal);
            Enter.Text(driver, PetterMPage.txtAddress, RandomCustumers.addressRandom());
            Enter.Text(driver, PetterMPage.txtPhone, RandomCustumers.phoneRandom().ToString());
            Enter.Text(driver, PetterMPage.txtEmail, RandomCustumers.emailRandom());            
            
            WaitUntil.ElementIsPresent(driver, PetterMPage.btnSave);
            Click.On(driver, PetterMPage.btnSave);
            System.Threading.Thread.Sleep(3000);
        }

        // Method that retrieves the random document
        public static string genCed()
        {
            return RandomCustumers.IdsRandom().ToString();
        }

        // Method that retrieves the random name
        public static string genName()
        {
            return RandomCustumers.namesRandom();
        }
    }
}