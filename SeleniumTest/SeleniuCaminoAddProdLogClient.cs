using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumTest
{
    internal class SeleniuCaminoAddProdLogClient
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public SeleniuCaminoAddProdLogClient()
        {
            var info = "Test dodawanie produktow przez zalogowanego klienta ";
            var Driver = GetChromeDriver();
            logger.Info(Environment.NewLine+ info );
            //logger.Debug(info + Environment.NewLine);
            Driver.Navigate().GoToUrl("https://www.camino.pl/");

            logger.Info(DateTime.Now + Environment.NewLine + "Web Driver wszedł na strone: " + Driver.Url );

            Driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
            logger.Info("Web Driver powiekszyl okno " + Driver.Url + Environment.NewLine + DateTime.Now);

            var logUser = Driver.FindElement(By.Name("login[knt_email]"));
            logUser.SendKeys("adamn88888@gmail.com");
            logger.Info("wpisano login "  + DateTime.Now + Environment.NewLine);

            var logPass = Driver.FindElement(By.Name("login[knt_haslo]"));
            logPass.SendKeys("Haslo");
            logger.Info("wpisano halso " + DateTime.Now + Environment.NewLine);

            var log = Driver.FindElement(By.XPath("//*[@alt='Zaloguj']"));
            ///var log= Driver.FindElements(By.ClassName("button" )[1]); ;
            log.Click();
            logger.Info("zalogowano " + DateTime.Now + Environment.NewLine);

            Driver.Navigate().GoToUrl("https://www.camino.pl/");

            //Driver.FindElement(By.XPath("//*[@span='akcesoria do notebooków']"));
            Driver.FindElement(By.XPath("//span[contains(.,'huby USB')]")).Click();
            logger.Info("wybrano kategoria produktu " + DateTime.Now + Environment.NewLine);

            Driver.FindElement(By.XPath("//div[2]/div[5]/div/div[5]/div/form/p/input[2]")).Click();
            logger.Info("dodano produkt do koszyka " + DateTime.Now + Environment.NewLine);

           // Driver.FindElement(By.ClassName("logo"));
            Driver.Navigate().GoToUrl("https://www.camino.pl/");

            //a[contains(@href, 'koszyk.html')]
            Driver.FindElement(By.XPath("//span[contains(.,'głośniki')]")).Click();
            logger.Info("wybrano kategoria produktu " + DateTime.Now + Environment.NewLine);

            Driver.FindElement(By.XPath("//div[2]/div[5]/div/div[5]/div/form/p/input[2]")).Click();
            logger.Info("dodano produkt do koszyka " + DateTime.Now + Environment.NewLine);

            Driver.Navigate().GoToUrl("https://www.camino.pl/");
            Driver.FindElement(By.XPath("//span[contains(.,'głośniki')]")).Click();
            logger.Info("wybrano kategoria produktu " + DateTime.Now + Environment.NewLine);
            Driver.FindElement(By.XPath("//div[2]/div[5]/div/div[5]/div/form/p/input[2]")).Click();
            logger.Info("dodano produkt do koszyka " + DateTime.Now + Environment.NewLine);

            Driver.Navigate().GoToUrl("https://www.camino.pl/");
            Driver.FindElement(By.XPath("//span[contains(.,'głośniki')]")).Click();
            logger.Info("wybrano kategoria produktu " + DateTime.Now + Environment.NewLine);

            Driver.FindElement(By.XPath("//div[5]/div[3]/form/p/input[2]")).Click();
            logger.Info("dodano produkt do koszyka " + DateTime.Now + Environment.NewLine);

            //span[contains(.,'głośniki')]
            //input[@type='image'])[15]
            //div[2]/div[5]/div/form/p/input[2]
            //div[5]/div[3]/form/p/input[2]
            //div[2]/div[5]/div/div[5]/div/form/p/input[2]

            //Driver.FindElement(By.XPath("//div[2]/div[5]/div[2]/form/p/input[2]")).Click();

            //span[contains(.,'huby USB')]
            //div[2]/div[5]/div/div[5]/div/form/p/input[2]
            //div[2]/div[5]/div[2]/form/p/input[2]

            //div[2]/div[5]/div[2]/form/p/input[2]

            //div[2]/div[5]/div[2]/form/p/input[2]
            // Driver.FindElement(By.XPath("//div[2]/div[5]/div[2]/form/p/input[2]")).Click();

            //div[2]/div/div/a
            Driver.Navigate().GoToUrl("https://www.camino.pl/");
           
            Driver.FindElement(By.XPath("//div[2]/div/div/a")).Click();
            logger.Info("wybrano kategoria produktu " + DateTime.Now + Environment.NewLine);

            Driver.FindElement(By.XPath("//a[contains(@href, 'koszyk.html')]")).Click();
            logger.Info("sprawdzenie produktów w koszyku " + DateTime.Now + Environment.NewLine);

            logger.Info("dodano produkt do koszyka " + DateTime.Now + Environment.NewLine);

            Driver.Navigate().GoToUrl("https://www.camino.pl/");


            Driver.FindElement(By.ClassName("columnlink")).Click();
            logger.Info("wybrano kategoria produktu " + DateTime.Now + Environment.NewLine);

            Driver.FindElement(By.ClassName("columnlink")).Click();
            Driver.FindElement(By.ClassName("do_koszyka")).Click();
            logger.Info("dodano produkt do koszyka " + DateTime.Now + Environment.NewLine);

            logger.Info("dodano produkt do koszyka " + DateTime.Now + Environment.NewLine);
            logger.Info("przejscie do widoku koszyka " + DateTime.Now + Environment.NewLine);
            logger.Info("KONIC Testu " + info + DateTime.Now + Environment.NewLine);

            Driver.FindElement(By.ClassName("cart"));

            // Driver.FindElement(By.XPath("//*[@id='lightboxInner']/div/p[3]/a")).Click();


            // / html / body / div[7] / div / div / p[3] / a


            //Driver.FindElement(By.Id("cart_quan_100299")).Click();
            //Driver.FindElement(By.Name("cart[id]")).SendKeys("100307");
            //Driver.FindElement(By.ClassName("do_koszyka")).Click();
            //Driver.FindElement(By.ClassName("cart"));

            //Driver.FindElement(By.Id("cart_quan_100299")).Click();



            // Driver.FindElement(By.CssSelector("['button:nth-child(4) img']"));

            //Driver.FindElement(By.CssSelector("//*[@onclick='test.close();']"));

            //Driver.FindElement(By.ClassName("button")).Click();



            //Driver.FindElement(By.XPath("//div[@id='lightboxInner']/div/p[3]/a/img")).Click();
            //Driver.FindElement(By.CssSelector("['button:nth-child(4) img']"));
            //Driver.FindElement(By.CssSelector("//*[@onclick='test.close();']"));
            //Driver.FindElement(By.Id("cart_quan_100300")).SendKeys("3");
            // Driver.FindElement(By.CssSelector("[css='.button:nth - child(4) img']"));

            Driver.Navigate().GoToUrl("https://www.camino.pl/koszyk.html");

        }

        public static IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }
}
