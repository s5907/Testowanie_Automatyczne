using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
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
    class Program
    {
        static void Main(string[] args)
        {

            // test1 canino = new SeleniuCaminoLog();

            //new SeleniuCaminoLog();

            new GogleSearch();
           // new FacebookLogIn();

            // var Driver = GetChromeDriver();
            //Driver.Navigate().GoToUrl("https://google.pl");
            //driver.Navigate().GoToUrl("https://www.ultimateqa.com/simple-html-elements-for-automation/");

            // Driver.Navigate().GoToUrl("https://www.camino.pl/");
            //Driver.Manage().Window.Maximize();
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));

            //  var logUser = Driver.FindElement(By.Name("login[knt_email]"));
            //logUser.SendKeys("email");


            //var logPass = Driver.FindElement(By.Name("login[knt_haslo]"));
            //logPass.SendKeys("email");
            //var log= Driver.FindElement(By.XPath("//*[@alt='Zaloguj']")); 
            //var log= Driver.FindElements(By.ClassName("button" )[1]); ;
            //log.Click();


            //var elem = Driver.FindElement(By.XPath("/*[@href=''])"));
            // elem.Click();
            //var login = driver.FindElement(By.LinkText("Gmail"));
            //var login = Driver.FindElement(By.XPath("*[@id='gb_70']"));
            //var link = Driver.FindElement(By.Name("q"));
            //link.SendKeys("testing");
            //link.Submit();


            // Driver.SwitchTo().ActiveElement();
            //var elem =  Driver.FindElement(By.Id("gb_70"));
            // var elem = Driver.FindElement(By.ClassName("gb_g"));
            //Driver.FindElement(By.Id("gb_70")).Click();
            // Actions actions = new Actions(Driver);
            // actions.MoveToElement(elem).Click();
            //elem.Click();
            //CdmNIf
            //moveToElement(elem).click().perform();


            //*[@id='gb_70']
            //  login.Submit();
            //login.Click();
            //  login.FindElement(By.LinkText("Zaloguj się")).Click();
            // var link = driver.FindElement(By.Name("q"));
            //link.SendKeys("testing" + Keys.Enter);
            //link.Submit();

            //   driver.Url = "https://www.facebook.com/";
            //   driver.Manage().Window.Maximize();

            //   var element = driver.FindElement(By.Id("email"));
            //   element.SendKeys("adamn88888@gmail.com");

            //   element = driver.FindElement(By.Id("pass"));
            //   element.SendKeys("P@ssw0rD" + Keys.Enter);

            //   var home = driver.FindElement(By.ClassName("a8c37x1j"));
            //   home.Submit();

            //Driver.Navigate().GoToUrl("https://www.ultimateqa.com/simple-html-elements-for-automation/");
            //  Driver.Manage().Window.Maximize();
            // WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
            // Driver.FindElement(By.TagName("select")).Click();
            // Driver.FindElement(By.XPath("//*[@value='audi']")).Click();
            // Driver.FindElement(By.XPath("//li[@class='et_pb_tab_1']")).Click();
            // WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
            //var element = Driver.FindElement(By.TagName("select"));
            //Actions actions = new Actions(Driver);
            //actions.moveToElement(element).click().perform();
            //Driver.maximize_window()
            //Driver.manage().timeouts().implicitlywait(15 TimeUnit.seconds)
            //actions.MoveToElement(element).Click().Perform();
            //var element1  = Driver.FindElement(By.XPath("//*[@value='audi']")
            //actions.MoveToElement(element).Click();
            //Driver.FindElement(By.TagName("select")).Click();
            //Driver.FindElement(By.XPath("//*[@value='audi']")).Click();


        }




        public static IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }
}
