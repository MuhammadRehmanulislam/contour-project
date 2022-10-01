using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace contour_project
{
    [TestClass]
    public class UnitTest1 : baseclass
    {
        public Action ChromeDriverdriver { get; private set; }


        //public TestContext instance;
        //public TestContext TestContext
        //{
        //    set { instance = value; }
        //    get { return instance; }
        //}
        [TestMethod]
       // [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "datalog.xml", "Login", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.max();
            wait();
            baseclass.OpenUrl("https://www.mariab.pk/");

            //string url = TestContext.DataRow["url"].ToString();
            //string user = TestContext.DataRow["username"].ToString();
            //string pass = TestContext.DataRow["password"].ToString();

            // LogIn log = new LogIn();
            // log.login1(user, pass);


            //  SignUp sign = new SignUp();
            //  sign.signup1("Rehman", "rehmanmani247@gmail.com", "Rehman1122@", "Rehman1122@", "");

            //invalidSignup sign = new invalidSignup();
            //sign.invalidSignup1("Rehman", "rehmanmani247gmail.com", "Rehman1122", "Rehman1122@", "");


            //log.login1("rehmanmani247@gmail.com", "Rehman1122@", "");

            //invalidLogin invlogin = new invalidLogin();
            //invlogin.invalidlogin1("rehmanmani247@gmail.com", "Rehman1122", "");

            //Search srch = new Search();
            //srch.searchh("winter");

            //searchOnly srch = new searchOnly();
            //srch.searchonly1("winter");

            //checkout chk = new checkout();
            //chk.checkout1("rehmanmani247@gmail.com", "Rehman1122@", "winter");

            // IWebDriver driver;

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.mariab.pk/";
            //addtocart cart = new addtocart();
            //Action a = new Action(driver);
            //a.MoveToElement(driver.FindElement(By.XPath("(//span[text()='Ready To Wear'])[1]"))).Build().Perform();
            //driver.FindElement(By.Id("Casuals")).Click();
            //cart.addtoCart();

            Thread.Sleep(10000);
            IWebElement mainMenu = driver.FindElement(By.XPath("(//span[text()='Ready To Wear'])[1]"));
            Thread.Sleep(10000);

            Actions actions = new Actions(driver);

            actions.MoveToElement(mainMenu);

           // IWebElement subMenu = driver.FindElement(By.XPath("//div/ul[@id='nav']/li[2]/ul/li[3]/a"));
            actions.Click().Build().Perform();
            Thread.Sleep(10000);




        }
    }
}