using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace PracticaInterfaces
{
    class ConstantesDOM
    {

        public const string TxtIduser = "//*[@id='user']";
        public const string TxtPasswo = "//*[@id='password']";
        public const string Btn = "//*[@id='btn-login']";
        public const string IconbtnMenuListNew = "//*[@id='menuListNew']";
        public const string IMenuCastLis = "//*[@id='casesList']";
        public const string Mcategories = "//*[@id='categories']//*[contains(text(),'FN_OperacionesMAt')]";
        public const string Edatarenimp1 = "//*[@data-render-xpath='FN_OperacionesMAt.valor1']//input";
        public const string Edatarenimp2 = "//*[@data-render-xpath='FN_OperacionesMAt.valor2']//input";
        public const string Edatarenbtn = "//*[@class='ui-bizagi-render ui-corner-all ui-widget-content ui-bizagi-render-display-value ']//input";
        public const string Edatarenrtd = "//*[@data-render-xpath='FN_OperacionesMAt.resultad']//input";


        //public string metodox(string DATARENDER) => $"//*[@data-render-xpath='{DATARENDER}']//input";
            






    }
}
