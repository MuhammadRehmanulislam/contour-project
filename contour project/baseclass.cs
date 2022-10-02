using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace contour_project
{
    public class baseclass
    {
        public static ChromeDriver driver;

        public static void SeleniumInit(string browser)

        {

            driver = new ChromeDriver();

        }

        //public static void CloseDriver()

        //{

        //    driver.Close();

        //}

        public void Write(By by, string value)

        {

            driver.FindElement(by).SendKeys(value);

        }

        public  void Click(By by)

        {

            driver.FindElement(by).Click();

        }
        ///
        public static void max()

        {

            driver.Manage().Window.Maximize();

        }
        public static void wait()

        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }
        ///
        //public void Clear(By by)

        //{

        //    driver.FindElement(by).Clear();

        //}
        public static void OpenUrl(string url)

        {

            driver.Url = url;

        }



        public static void hover(By by)
        {
           // Thread.Sleep(10000);
           // IWebElement mainMenu = driver.FindElement(By.XPath("(//span[text()='Ready To Wear'])[1]"));
           //// Thread.Sleep(10000);

           // Actions actions = new Actions(driver);
           //// actions.MoveToElement(driver.FindElement(by)).Perform();
           // actions.MoveToElement(mainMenu);

           // // IWebElement subMenu = driver.FindElement(By.XPath("//div/ul[@id='nav']/li[2]/ul/li[3]/a"));
           // actions.Click().Build().Perform();
           // Thread.Sleep(10000);

            Actions a = new Actions(driver);
            a.MoveToElement(driver.FindElement(by)).Build().Perform();
            //driver.FindElement(By.Id("Casuals")).Click();

        }

        public static void scroll()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,600);");
        }

        public void scrolltoelement(By by)
        {

            var element = driver.FindElement(by);
            //var element = driver.FindElement(By.XPath("(//li[@class='item product product-item'])[2]"));

            //Scroll To Element

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);

        }
    }
}
