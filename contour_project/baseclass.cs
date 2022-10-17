using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
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
          private static readonly log4net.ILog log =
          log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public static IWebDriver driver;

        public static void SeleniumInit(string browser)

        {
            log.Info("Application is working");
            driver = new ChromeDriver();

        }

        public static void CloseDriver()

        {

            driver.Close();

        }

        //public void Write(By by, string value)

        //{

        //    driver.FindElement(by).SendKeys(value);

        //}

        //public  void Click(By by)

        //{

        //    driver.FindElement(by).Click();

        //}

        public static void max()

        {

            driver.Manage().Window.Maximize();

        }
        public static void ImplicitWait()

        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }
        ///
        //public void Clear(By by)

        //{

        //    driver.FindElement(by).Clear();

        //}
        public static void OpenUrl()

        {

            driver.Url = "https://www.mariab.pk/";

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
            js.ExecuteScript("window.scrollBy(0,500);");
        }

        public static void ScrollBy(int value, int value1)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollBy({0},{1};", value, value1);
        }

        public void scrolltoelement(By by)
        {

            var element = driver.FindElement(by);
            //var element = driver.FindElement(By.XPath("(//li[@class='item product product-item'])[2]"));

            //Scroll To Element

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);

        }

        public void assert(By by)
        {
            IWebElement element = driver.FindElement(By.XPath(" //h2[text()='All Products']"));
            bool status = element.Displayed;
            Assert.AreEqual(status, true);
            
        }

        public void dropDownItemSelect(By by, string value)
        {
            IWebElement drpDown = driver.FindElement(by);
            SelectElement dropDownMenu = new SelectElement(drpDown);
            dropDownMenu.SelectByValue(value);
        }

        public static void PlaybackWait(int miliSeconds)
        {

            Thread.Sleep(miliSeconds);

        }
        public static void TakeScreenshot(string stepDetail)
        {
            string path = @"C:\Users\MRehm\source\repos\contour-project\contour_project\screenshot\" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);
            ExtentReport.exChildTest.Log(Status.Pass, stepDetail, MediaEntityBuilder.CreateScreenCaptureFromPath(path + ".png").Build());
        }

        public static void TakeScreenshot(Status status, string stepDetail)
        {
            string path = @"C:\Users\MRehm\source\repos\contour-project\contour_project\screenshot\" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);
            ExtentReport.exChildTest.Log(status, stepDetail, MediaEntityBuilder
                .CreateScreenCaptureFromPath(path + ".png").Build());
        }
        public void Write(By by, string value)
        {
            try
            {
                driver.FindElement(by).SendKeys(value);
                TakeScreenshot(Status.Pass, "Enter Text");
            }
            catch (Exception ex)
            {

                TakeScreenshot(Status.Fail, "Enter Text: " + ex.ToString());
            }
        }

        public void Click(By by)
        {
            try
            {
                driver.FindElement(by).Click();
                TakeScreenshot("Click Element");
            }
            catch (Exception ex)
            {
                TakeScreenshot(Status.Fail, "Click Element: " + ex.ToString());
            }
        }
    }
}
