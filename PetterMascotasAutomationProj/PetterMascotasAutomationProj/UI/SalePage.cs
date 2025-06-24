using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PetterMascotasAutomationProj.UI
{
    public class SalePage
    {
        //In this class the elements of the sales module are parameterized

        public static By btnSale = By.XPath("(//*[@class='btn btn-outline-success m-2 sidebutton'])[3]");
        public static By txtSearchId = By.XPath("(//*[@class='form-group row']//*[@id='inputCedula'])[1]");
        public static By txtFindClient = By.XPath("(//*[@class='form-group row']//*[@id='inputCedula'])[2]");
        public static By btnConsult = By.XPath("(//*[@class='form-group row']//button)[1]");        
        public static By btnActSearchProduct1 = By.XPath("(//*[@class='p-dropdown-trigger-icon p-clickable pi pi-chevron-down'])[1]");        
        public static By txtsearchProduct = By.XPath("//*[@class='p-dropdown-filter-container']//input");
        public static By txtQuantProduct1 = By.XPath("//*[@class='col-3 contenedorProdControles']//input");
        public static By btnActSearchProduct2 = By.XPath("(//*[@class='p-dropdown-trigger-icon p-clickable pi pi-chevron-down'])[2]");
        public static By txtQuantProduct2 = By.XPath("(//*[@class='col-3  contenedorProdControles']//input)[1]");        
        public static By btnActSearchProduct3 = By.XPath("(//*[@class='p-dropdown-trigger-icon p-clickable pi pi-chevron-down'])[3]");
        public static By txtQuantProduct3 = By.XPath("(//*[@class='col-3  contenedorProdControles']//input)[2]");        
        public static By lblTotalVat = By.XPath("(//*[@class='form-group row m-2 text-center'])[8]//input");
        public static By txtTotalSale = By.XPath("(//*[@class='col-4 ']//*[@class='form-control'])[1]");
        public static By btnSaveSale = By.XPath("//*[@class='col-4 offset-2 botonInferior']//button");
        public static By msgSaleok = By.XPath("//*[@class='p-toast-message-text']//*[contains(text(),'Se guardó el registro correctamente')]");
        public static By parascrollo = By.XPath("//*[@class='col-4 offset-2 botonInferior']");
    }
}