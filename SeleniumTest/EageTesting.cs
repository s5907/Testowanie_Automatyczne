using OpenQA.Selenium.Edge;
using System;
using System.Reflection;

namespace SeleniumTest
{
    internal class EageTesting
    {

      //  string edgeDriverLocation = @"C:\driver\eage";
        // string edgeDriverLocation = @"..\..\..\SeleniumTest\Drivers;
       
        public EageTesting()
        {
            var edgeDriverLocation = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var driver = new EdgeDriver(edgeDriverLocation);
            

                driver.Manage().Window.Maximize();


                driver.Navigate().GoToUrl("http://www.google.com");


                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                var searchBox = driver.FindElementById("lst-ib");


                searchBox.SendKeys("Selenium web");


                var searchButton = driver.FindElementByName("btnK");


                searchButton.Submit();


                var searchResults = driver.FindElementById("resultStats");
            
        }
    }
}