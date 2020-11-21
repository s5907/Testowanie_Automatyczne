using OpenQA.Selenium.Firefox;

namespace SeleniumTest
{
    internal class FireFoxTesting
    {
        public FireFoxTesting()
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