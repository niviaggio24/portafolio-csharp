using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PracticaInterfaces
{

    public class Test
    {
        IMetodos implementMetodos = new Metodos();


        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://qa-freyn/PracticaSelenium/");
            System.Threading.Thread.Sleep(2000);
            driver.Manage().Window.Maximize();
        }


        [Test, Order(1)]
        public void testniviayo()
        {

            //

            Busqueda_elementos darclic = new Busqueda_elementos();
            darclic.clicXpath(ConstantesDOM.TxtIduser, driver);
            darclic.IngresartextxXpath(ConstantesDOM.TxtIduser, driver, "admon");


            
            //

            //IWebElement input = driver.FindElement(By.XPath(ConstantesDOM.TxtIduser));
            //input.Click();
            //input.SendKeys("admon");




            //  
            IWebElement input2 = driver.FindElement(By.XPath(ConstantesDOM.TxtPasswo));
            input2.Click();
            input2.SendKeys("123");

            //IWebElement input3 = driver.FindElement(By.XPath("//*[@id='btn-login']"));
            IWebElement input3 = driver.FindElement(By.XPath(ConstantesDOM.Btn));
            input3.Click();
            System.Threading.Thread.Sleep(3000);

            //IWebElement input4 = driver.FindElement(By.XPath("//*[@id='menuListNew']"));
            IWebElement input4 = driver.FindElement(By.XPath(ConstantesDOM.IconbtnMenuListNew));
            input4.Click();
            System.Threading.Thread.Sleep(3000);

            //IWebElement input5 = driver.FindElement(By.XPath("//*[@id='casesList']"));
            IWebElement input5 = driver.FindElement(By.XPath(ConstantesDOM.IMenuCastLis));
            input5.Click();
            System.Threading.Thread.Sleep(3000);

            //IWebElement input7 = driver.FindElement(By.XPath("//*[@id='categories']//*[contains(text(),'FN_OperacionesMAt')]"));
            IWebElement input7 = driver.FindElement(By.XPath(ConstantesDOM.Mcategories));
            System.Threading.Thread.Sleep(2000);
            input7.Click();
            System.Threading.Thread.Sleep(3000);

            //IWebElement input8 = driver.FindElement(By.XPath("//*[@data-render-xpath='FN_OperacionesMAt.valor1']//input"));
            IWebElement input8 = driver.FindElement(By.XPath(ConstantesDOM.Edatarenimp1));
            input8.SendKeys("524");

            System.Threading.Thread.Sleep(1000);
            //IWebElement input9 = driver.FindElement(By.XPath("//*[@data-render-xpath='FN_OperacionesMAt.valor2']//input"));
            IWebElement input9 = driver.FindElement(By.XPath(ConstantesDOM.Edatarenimp2));
            input9.SendKeys("222");
            System.Threading.Thread.Sleep(1000);

            //IWebElement input10 = driver.FindElement(By.XPath("//*[@class='ui-bizagi-render ui-corner-all ui-widget-content ui-bizagi-render-display-value ']//input"));
            IWebElement input10 = driver.FindElement(By.XPath(ConstantesDOM.Edatarenbtn));
            input10.Click();
            System.Threading.Thread.Sleep(3000);

            //IWebElement input11 = driver.FindElement(By.XPath("//*[@data-render-xpath='FN_OperacionesMAt.resultad']//input"));
            IWebElement input11 = driver.FindElement(By.XPath(ConstantesDOM.Edatarenrtd));


            //la chexkbox
            //IWebElement input1x = driver.FindElement(By.XPath("(//*[@data-render-xpath='FN_OperacionesMAt.elementocheckboX']//label)[2]"));
            //input1x.Click();


            //investigar como obtener el valor del render-
            var value = input11.GetAttribute("value");  // capturo  un resultado de la forma(boton) que implementa la  soap
            System.Threading.Thread.Sleep(1000);

            var result = implementMetodos.suma(524, 222);  ///resultado del metodo suma
            //Assert.Equals(value.ToString(), result.ToString());   // la comparacion de los resultados de forma y el metodo suma
            System.Threading.Thread.Sleep(500);


            IWebElement input12 = driver.FindElement(By.XPath("//*[@data-render-xpath='FN_OperacionesMAt.City.idCountry']//input"));
            input12.Click();
            System.Threading.Thread.Sleep(500);

            IWebElement input13 = driver.FindElement(By.XPath("//*[@data-render-xpath='FN_OperacionesMAt.City.idCountry']//*[text()='Colombia']"));
            input13.Click();
            System.Threading.Thread.Sleep(500);

            IWebElement input14 = driver.FindElement(By.XPath("//*[@data-render-xpath='FN_OperacionesMAt.City']//input"));
            input14.Click();
            System.Threading.Thread.Sleep(3000);

            IWebElement input15 = driver.FindElement(By.XPath("//*[@data-render-xpath='FN_OperacionesMAt.City']//*[text()='BOG       ']"));
            input15.Click();
            System.Threading.Thread.Sleep(2000);


            IWebElement input16 = driver.FindElement(By.XPath(ConstantesDOM.Edatarenimp2));
            input16.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement input17 = driver.FindElement(By.XPath("//*[@class='ui-bizagi-control-wrapper']//*[@class='ui-bizagi-render-search-cell']//button//i"));
            input17.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement input18 = driver.FindElement(By.XPath("//*[@class='ui-bizagi-render-text'][1]"));
            input18.SendKeys("%");
            System.Threading.Thread.Sleep(1000);


            IWebElement input19 = driver.FindElement(By.XPath("//span[text()='Search']"));  // para sacar el search
            input19.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement input20 = driver.FindElement(By.XPath("//*[@class=\"readonly-control\"][1]")); //prguntar al mostro
            input20.Click();
            System.Threading.Thread.Sleep(2000);

            ////Seleccionar la coleccion
            IWebElement input21 = driver.FindElement(By.XPath("//*[@data-render-xpath='FN_OperacionesMAt.ColeccionEntradas']//*[@class='ui-icon ui-icon-plus']"));
            System.Threading.Thread.Sleep(2000);
            input21.Click();



            /*  //formos
            var posicion = 0;
            IWebElement inputColec;
            for (int j = 1; j <= 5; j++)
            {
                
                
                inputColec = driver.FindElement(By.XPath("//*[@data-render-xpath='FN_OperacionesMAt.ColeccionEntradas']//*[@class='ui-icon ui-icon-plus']"));
                inputColec.Click();


            for (int i = 1; i <= 5; i++)
            {
                    
                string temp = "(//*[@data-render-xpath='FN_OperacionesMAt.ColeccionEntradas']//input)[" + (posicion+ i) + "]";

                switch (i.ToString())
                {

                    case "1":
                        inputColec = driver.FindElement(By.XPath(temp));
                        inputColec.SendKeys("80755369");
                        break;
                    case "2":
                        inputColec = driver.FindElement(By.XPath(temp));
                        inputColec.SendKeys("Frey niviayo");
                        break;
                    case "3":
                        inputColec = driver.FindElement(By.XPath(temp));
                        inputColec.SendKeys("7/29/2020");
                        break;

                    case "4":
                        inputColec = driver.FindElement(By.XPath(temp));
                        inputColec.SendKeys("52401");
                        break;
                }
                if (i == 5)
                {

                    inputColec = driver.FindElement(By.XPath("(//*[@data-render-xpath='FN_OperacionesMAt.ColeccionEntradas']//label[text()=' Yes '])[1]"));
                    inputColec.Click();


                    //cadena
                    inputColec = driver.FindElement(By.XPath("(//*[@data-render-xpath='FN_OperacionesMAt.ColeccionEntradas']//input)[7]"));
                    inputColec.Click();
                    inputColec.SendKeys("Pruebas selenum frey");

                }


            }
                System.Threading.Thread.Sleep(2000);

                posicion += 5;  //posicion = posicion +5;

            }


            */        //formos

            /*
            for (int i = 0; i < 2; i++)
            {
                input21.Click();
            }
            */





            ////identificacion
            IWebElement input22 = driver.FindElement(By.XPath("(//*[@data-render-xpath='FN_OperacionesMAt.ColeccionEntradas']//input)[1]"));
            input22.Click();
            input22.SendKeys("80755369");

            ////Nombres
            IWebElement input23 = driver.FindElement(By.XPath("(//*[@data-render-xpath='FN_OperacionesMAt.ColeccionEntradas']//input)[2]"));
            input23.Click();
            input23.SendKeys("Frey niviayo");

            ////fecha
            IWebElement input24 = driver.FindElement(By.XPath("(//*[@data-render-xpath='FN_OperacionesMAt.ColeccionEntradas']//input)[3]"));
            input24.Click();
            input24.SendKeys("7/29/2020");

            ////Modena
            IWebElement input25 = driver.FindElement(By.XPath("(//*[@data-render-xpath='FN_OperacionesMAt.ColeccionEntradas']//input)[4]"));
            input25.Click();
            input25.SendKeys("52401");

            ////boleano
            IWebElement input26 = driver.FindElement(By.XPath("(//*[@data-render-xpath='FN_OperacionesMAt.ColeccionEntradas']//label[text()=' Yes '])[1]"));
            input26.Click();           


            ////cadena
            IWebElement input27 = driver.FindElement(By.XPath("(//*[@data-render-xpath='FN_OperacionesMAt.ColeccionEntradas']//input)[7]"));
            input27.Click();
            input27.SendKeys("Pruebas selenum frey");


            //clic en boton guardar
            IWebElement input29 = driver.FindElement(By.XPath("//*[@id='formButton0']"));
            input29.Click();
            System.Threading.Thread.Sleep(5000);


            //clic en boton siguinte
            IWebElement input30 = driver.FindElement(By.XPath("//*[@id='formButton1']"));
            input30.Click();
            System.Threading.Thread.Sleep(5000);


            //metodo

            IWebElement colox = driver.FindElement(By.XPath("//label[@style='background-color: rgb(146, 208, 80) !important; font-weight: bold;']"));
            Assert.AreEqual("rgba(53, 53, 53, 1)", colox.GetCssValue("color"));
            System.Threading.Thread.Sleep(500);


            //clic en boton avanzar





            // asersion para validar color


            //fecha 
            //*[@class='ui-bizagi-grid-body']//*[@class='ui-bizagi-render-numeric'][1]


            //moneda



            //no existia por que aun no estaba creados los checks
            //IWebElement input22 = driver.FindElement(By.XPath("(//*[@class='ui-radio'])[1]"));
            //input22.Click();
            //System.Threading.Thread.Sleep(3000);






            //IWebElement input8 = driver.FindElement(By.XPath("//*[@data-render-xpath='ArrayBoleano.BoleanoIn']//*[@class='ui-icon ui-icon-plus']"));
            //input8.Click();
            //IWebElement input8 = driver.FindElement(By.XPath("//*[@data-render-xpath='ArrayBoleano.BoleanoIn']//*[@class='ui-icon ui-icon-plus']"));




            //*[@class='ui-button-text'][1]
            //"//*[@class='ui-button-text'[]";

            //            IWebElement input18 = driver.FindElement(By.XPath("//*[@class='ui-bizagi-control-wrapper']//*[@class='ui-bizagi-render-search-cell']//button//i']"));
            //           input18.Click();
            //         System.Threading.Thread.Sleep(2000);











            /*
            //IWebElement input8 = driver.FindElement(By.XPath("//*[@data-render-xpath='ArrayBoleano.BoleanoIn']//*[@class='ui-icon ui-icon-plus']"));
            //input8.Click();
            IWebElement input8 = driver.FindElement(By.XPath("//*[@data-render-xpath='ArrayBoleano.BoleanoIn']//*[@class='ui-icon ui-icon-plus']"));




            for (int i = 0; i < 5; i++)
            {
                input8.Click();
            }

            //no existia por que aun no estaba creados los checks
            IWebElement input9 = driver.FindElement(By.XPath("(//*[@class='ui-radio'])[1]"));
            input9.Click();
            System.Threading.Thread.Sleep(3000);


            //Asserts.*/

        }


        [Test, Order(2)]
        public void hola()
        {
        }


        [TearDown]
        public void EndOfTest()
        {

            driver.Quit();
            //driver.Close();

        }

        #region metodos

        //metod buscarlos elementos
        public void holanivi()
        {
           

 

        }




        #endregion


    }
}
