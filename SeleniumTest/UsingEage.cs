using OpenQA.Selenium.Edge;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
   internal  class UsingEage
    {

        string edgeDriverLocation = @"C:\driver\eage";
        // string edgeDriverLocation = @"..\..\..\SeleniumTest\Drivers;

        public void Shoud_Search_Using_EdgeBrowser()
        {
            
            using (var driver = new EdgeDriver(edgeDriverLocation))
            {
               
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
}
