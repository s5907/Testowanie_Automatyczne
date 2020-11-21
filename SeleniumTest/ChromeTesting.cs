using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumTest
{
    internal class ChromeTesting
    {
        public ChromeTesting()
        { 
             var ChromeDriverLocation = @"C:\driver\chromedriver";
            //var ChromeDriverLocation = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // ChromeDriver(outPutDirectory);

            var driver = new ChromeDriver(ChromeDriverLocation);

            // 1. Powieksz okno
            driver.Manage().Window.Maximize();

            // 2. Przejdz do  "Google" 
            driver.Navigate().GoToUrl("http://www.google.com");

            // 3. znajdz element



          var searchBox = driver.FindElementByName("q");
            // 4. wpisz tekst wysukiwania
            searchBox.SendKeys("Selenium web"+ Keys.Enter);

            // 5. znajdz przycisk
            //var searchButton = driver.FindElementByName("btnK");
            //var searchButton = driver.FindElementByClassName("gNO89b");

            // 6. zatwiedz wyszukiwanie
            //  searchButton.Submit();

            // 7. znajdz element 
            //var searchResults = driver.FindElementById("resultStats");
            driver.Close();
        }
    }
}