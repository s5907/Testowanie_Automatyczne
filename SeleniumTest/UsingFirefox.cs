using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class UsingFirefox
    {
        
        public void Shoud_Search_Using_Firefox()
        {
            
            using (var driver = new FirefoxDriver())
            {
                
                driver.Manage().Window.Maximize();

                
                driver.Navigate().GoToUrl("http://www.google.com");

                
                var searchBox = driver.FindElementById("lst-ib");

               
                searchBox.SendKeys("Selenium web");

               
                var searchButton = driver.FindElementByName("btnK");

                
                searchButton.Submit();

                
                var searchResults = driver.FindElementById("resultStats");
            }
        }
    }
}
