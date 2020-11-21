using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Firefox;
using NLog;


namespace SeleniumTest
{
    internal class GogleSearch
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public GogleSearch()
        {
             var Driver = GetChromeDriver();
            // new Browser();
            //var Driver = GetFirefoxDriver();
            //var Driver = new FirefoxDriver();
            var info = "Test wyszukiwanie stron google  ";
            // var Driver = GetFirefoxDriver();
            //var Driver = new FirefoxDriver();
            logger.Info(Environment.NewLine + info);
            Driver.Navigate().GoToUrl("https://google.pl");
            logger.Info(DateTime.Now + Environment.NewLine + "Web Driver wszedł na strone: " + Driver.Url);


            //IWebDriver Driver = new FirefoxDriver();
            //Driver.Manage().Window.Maximize();
            //Driver.Navigate().GoToUrl("https://google.pl");



            Driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
            logger.Info("znalezienie pola wyszukiwania " + DateTime.Now + Environment.NewLine);

            var link = Driver.FindElement(By.Name("q"));
            link.SendKeys("testing with selenium"+ Keys.Enter);
            logger.Info("wpisanie wyszukiwanego tekstu" + DateTime.Now + Environment.NewLine);
            logger.Info("KONIC Testu " + info + DateTime.Now + Environment.NewLine);
            Driver.Close();
        }

       // public static IWebDriver GetFirefoxDriver()
       // {
       //     return new FirefoxDriver();
       // }

        public static IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }
}