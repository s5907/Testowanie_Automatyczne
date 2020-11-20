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
        public FacebookLogIn()
        {
            var driver = GetChromeDriver();

              driver.Url = "https://www.facebook.com/";
              driver.Manage().Window.Maximize();

               var element = driver.FindElement(By.Id("email"));
               element.SendKeys("adamn88888@gmail.com");

               element = driver.FindElement(By.Id("pass"));
               element.SendKeys("P@ssw0rD" + Keys.Enter);

        }

        public static IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }
}