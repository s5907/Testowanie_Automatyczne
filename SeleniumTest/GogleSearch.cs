using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
using Framework;
using OpenQA.Selenium.Firefox;

namespace SeleniumTest
{
    internal class GogleSearch
    {
        
        public GogleSearch()
        {
             var Driver = GetChromeDriver();
           // var Driver = GetFirefoxDriver();
           //var Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("https://google.pl");

           //IWebDriver Driver = new FirefoxDriver();
            //Driver.Manage().Window.Maximize();
            //Driver.Navigate().GoToUrl("https://google.pl");



            Driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
            var link = Driver.FindElement(By.Name("q"));
            link.SendKeys("testing with selenium"+ Keys.Enter);
            
        }

        public static IWebDriver GetFirefoxDriver()
        {
            return new FirefoxDriver();
        }

        public static IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }
}