
using OpenQA.Selenium;

namespace PetterMascotasAutomationProj.UI

    // In this class the elements that store a new client are parameterized
{
    public class PetterMPage
    {
        public static By btnclient = By.XPath("(//*[@class='btn btn-outline-success m-2 sidebutton'])[2]");
        public static By btnNewClient = By.XPath("(//*[@class='p-menuitem-text'])[1]");
        public static By txtIdentifiCard = By.Id("id"); 
        public static By txtNames = By.Id("username");
        public static By txtAddress = By.Id("address");
        public static By txtPhone = By.Id("phone");
        public static By txtEmail = By.Id("email");
        public static By btnSave = By.XPath("(//*[@class='p-button-label p-c'])[2]");        
    }
}
