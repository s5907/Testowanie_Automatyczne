using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumTest
{
    internal class SeleniuCaminoAddProd
    {
        public SeleniuCaminoAddProd()
        {
            var Driver = GetChromeDriver();

            Driver.Navigate().GoToUrl("https://www.camino.pl/");

            //Driver.FindElement(By.XPath("//*[@span='akcesoria do notebooków']"));
            Driver.FindElement(By.XPath("//span[contains(.,'huby USB')]")).Click();
            Driver.FindElement(By.XPath("//div[2]/div[5]/div/div[5]/div/form/p/input[2]")).Click();

            Driver.FindElement(By.ClassName("logo"));
            Driver.Navigate().GoToUrl("https://www.camino.pl/");

            //a[contains(@href, 'koszyk.html')]
            Driver.FindElement(By.XPath("//span[contains(.,'głośniki')]")).Click();
            Driver.FindElement(By.XPath("//div[2]/div[5]/div/div[5]/div/form/p/input[2]")).Click();
            Driver.Navigate().GoToUrl("https://www.camino.pl/");
            Driver.FindElement(By.XPath("//span[contains(.,'głośniki')]")).Click();
            Driver.FindElement(By.XPath("//div[2]/div[5]/div/div[5]/div/form/p/input[2]")).Click();
            Driver.Navigate().GoToUrl("https://www.camino.pl/");
            Driver.FindElement(By.XPath("//span[contains(.,'głośniki')]")).Click();
            Driver.FindElement(By.XPath("//div[5]/div[3]/form/p/input[2]")).Click();

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
            Driver.FindElement(By.XPath("//a[contains(@href, 'koszyk.html')]")).Click();

            Driver.Navigate().GoToUrl("https://www.camino.pl/");


            Driver.FindElement(By.ClassName("columnlink")).Click();
            Driver.FindElement(By.ClassName("columnlink")).Click();
            Driver.FindElement(By.ClassName("do_koszyka")).Click();
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
            Driver.Close();

        }

        public static IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }
    }
