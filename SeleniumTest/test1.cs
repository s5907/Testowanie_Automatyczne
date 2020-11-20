using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
    class test1
    {
        

        public void SeleniuCaminoLog()
        {
            var Driver = GetChromeDriver();

            Driver.Navigate().GoToUrl("https://www.camino.pl/");
            Driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
            var logUser = Driver.FindElement(By.Name("login[knt_email]"));
            logUser.SendKeys("email");


            var logPass = Driver.FindElement(By.Name("login[knt_haslo]"));
            logPass.SendKeys("email");
            var log = Driver.FindElement(By.XPath("//*[@alt='Zaloguj']"));
            //var log= Driver.FindElements(By.ClassName("button" )[1]); ;
            log.Click();
        }

        public static IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }
}
