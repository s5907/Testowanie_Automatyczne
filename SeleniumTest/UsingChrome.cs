using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    internal class UsingChrome
    {
                 // ChromeDriver(outPutDirectory);
        public void Shoud_Search_Using_Chrome()
        {
            string ChromeDriverLocation = @"C:\driver\chromedriver";
           // var outPutDirectory = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
          
            // ChromeDriver(outPutDirectory);

            using (var driver = new ChromeDriver(ChromeDriverLocation))
            {
                // 1. Powieksz okno
                driver.Manage().Window.Maximize();

                // 2. Przejdz do  "Google" 
                driver.Navigate().GoToUrl("http: //www.google.com");

                // 3. znajdz element

                var searchBox = driver.FindElementById("lst - ib");
                // 4. wpisz tekst wysukiwania
                searchBox.SendKeys("Selenium web");

                // 5. znajdz przycisk
                var searchButton = driver.FindElementByName("btnK");

                // 6. zatwiedz wyszukiwanie
                searchButton.Submit();

                // 7. znajdz element 
                var searchResults = driver.FindElementById("resultStats");
            }

            
        }
    }
}
