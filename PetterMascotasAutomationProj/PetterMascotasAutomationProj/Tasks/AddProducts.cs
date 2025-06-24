using OpenQA.Selenium;
using PetterMascotasAutomationProj.Actions;
using PetterMascotasAutomationProj.UI;
using NUnit.Framework;



namespace PetterMascotasAutomationProj.Tasks
{
    // This class contains the functionality to add the three products and register the sale

    public class AddProducts
    {
        public static void LoadProductsData(IWebDriver driver)            
        {
            Click.On(driver, SalePage.btnSale);
            WaitUntil.ElementIsPresent(driver, PetterMPage.btnSave);

           
            var cedUserRnd = AddCliente.cedGlobal;
            Enter.Text(driver, SalePage.txtSearchId, cedUserRnd);

           
            var NamUserRnd = AddCliente.nomnbreGlobal;

            Click.On(driver, SalePage.btnConsult);                        
            Click.On(driver, SalePage.btnActSearchProduct1);
            System.Threading.Thread.Sleep(3000);
            WaitUntil.ElementIsPresent(driver, SalePage.txtsearchProduct);
            Enter.Text(driver, SalePage.txtsearchProduct, "shi");            
            Enter.Text(driver, SalePage.txtsearchProduct, Keys.Down);
            Enter.Text(driver, SalePage.txtsearchProduct, Keys.Enter);

            Enter.Text(driver, SalePage.txtQuantProduct1, "2");
            System.Threading.Thread.Sleep(3000);

            Click.On(driver, SalePage.btnActSearchProduct2);
            System.Threading.Thread.Sleep(3000);
            WaitUntil.ElementIsPresent(driver, SalePage.txtsearchProduct);
            Enter.Text(driver, SalePage.txtsearchProduct, "bor");            
            Enter.Text(driver, SalePage.txtsearchProduct, Keys.Down);
            Enter.Text(driver, SalePage.txtsearchProduct, Keys.Enter);
            Enter.Text(driver, SalePage.txtQuantProduct2, "3");
            System.Threading.Thread.Sleep(1000);


            WaitUntil.ElementIsPresent(driver, SalePage.btnActSearchProduct3);
            Click.On(driver, SalePage.btnActSearchProduct3);            
            WaitUntil.ElementIsPresent(driver, SalePage.txtsearchProduct);
            Enter.Text(driver, SalePage.txtsearchProduct, "pom");            
            Enter.Text(driver, SalePage.txtsearchProduct, Keys.Down);
            Enter.Text(driver, SalePage.txtsearchProduct, Keys.Enter);
            Enter.Text(driver, SalePage.txtQuantProduct3, "1");                        
           

            WaitUntil.ElementIsPresent(driver, SalePage.btnSaveSale);
            Scroll.ScrollAuto(driver, SalePage.btnSaveSale);
            System.Threading.Thread.Sleep(1000);

            Click.On(driver, SalePage.btnSaveSale);

            WaitUntil.ElementIsPresent(driver, SalePage.msgSaleok);
            Assert.IsTrue(IsPresentelocator.validation(driver, SalePage.msgSaleok));
        }
    }
}
