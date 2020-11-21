using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumTest
{
    internal class FacebookLogIn
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public FacebookLogIn()
        {

            var info = "Test dodawanie produktow przez zalogowanego klienta ";

            try
            { 
            var driver = GetChromeDriver();
                logger.Info(Environment.NewLine + info);
                driver.Url = "https://www.facebook.com/";
              driver.Manage().Window.Maximize();
                logger.Info(DateTime.Now + Environment.NewLine + "Web Driver wszedł na strone: " + driver.Url);
                
                var element = driver.FindElement(By.Id("email"));
                logger.Info("zmalezienie pola email " + DateTime.Now + Environment.NewLine);

                logger.Info(DateTime.Now + Environment.NewLine + "Web Driver wszedł na strone: " + driver.Url);

               element.SendKeys("adamn88888@gmail.com");
                logger.Info("wpisanie email " + DateTime.Now + Environment.NewLine);

                element = driver.FindElement(By.Id("pass"));
                logger.Info(" wpisanie hasla " + DateTime.Now + Environment.NewLine);

                element.SendKeys("P@ssw0rD" + Keys.Enter);
                logger.Info("znalezienie pola haslo " + DateTime.Now + Environment.NewLine);

                logger.Info("KONIC Testu " + info + DateTime.Now + Environment.NewLine);


                driver.Close();
            }
           catch (Exception e)
            {
                logger.Error("Bład logowania" + DateTime.Now + Environment.NewLine + e);

            }
        }

        public static IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }
}