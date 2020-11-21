using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;



namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {

            new SeleniuCaminoLog();

            new SeleniuCaminoAddProd();

            new SeleniuCaminoAddProdLogClient();

            new GogleSearch();

            new FacebookLogIn();

            //uzycie przegladarek
            //new FireFoxTesting();
            new ChromeTesting();
            //new EageTesting();
           




        }




        //        public static IWebDriver GetChromeDriver()
        //        {
        //            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        //            return new ChromeDriver(outPutDirectory);
        //        }
    }
}
