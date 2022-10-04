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


            

            


            //log.login1("rehmanmani247@gmail.com", "Rehman1122@", "");

            

            //Search srch = new Search();
            //srch.searchh("winter");

            

            

            // IWebDriver driver;

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.mariab.pk/";
            //addtocart cart = new addtocart();
            //Action a = new Action(driver);
            //a.MoveToElement(driver.FindElement(By.XPath("(//span[text()='Ready To Wear'])[1]"))).Build().Perform();
            //driver.FindElement(By.Id("Casuals")).Click();
            //cart.addtoCart();

            


        }

        [TestMethod]
        public void signup()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.max();
            wait();
            baseclass.OpenUrl("https://www.mariab.pk/");

            SignUp sign = new SignUp();
            sign.signup1("Rehman", "rehmanmani247@gmail.com", "Rehman1122@", "Rehman1122@", "");
        }

        [TestMethod]
        public void invalidSignup()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.max();
            wait();
            baseclass.OpenUrl("https://www.mariab.pk/");

            invalidSignup sign = new invalidSignup();
            sign.invalidSignup1("Rehman", "rehmanmani247gmail.com", "Rehman1122", "Rehman1122@", "");
        }

        [TestMethod]
        public void login()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.max();
            wait();
            baseclass.OpenUrl("https://www.mariab.pk/");

             LogIn log = new LogIn();
             log.login1("rehmanmani247@gmail.com", "Rehman1122@");
        }

        [TestMethod]
        public void invalidLogin()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.max();
            wait();
            baseclass.OpenUrl("https://www.mariab.pk/");

            invalidLogin invlogin = new invalidLogin();
            invlogin.invalidlogin1("rehmanmani247@gmail.com", "Rehman1122", "");
        }

        [TestMethod]
        public void search()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.max();
            wait();
            baseclass.OpenUrl("https://www.mariab.pk/");

            Search srch = new Search();
            srch.searchh("winter");
        }

        [TestMethod]
        public void searchOnly()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.max();
            wait();
            baseclass.OpenUrl("https://www.mariab.pk/");

            searchOnly srch = new searchOnly();
            srch.searchonly1("winter");// change 
        }

        [TestMethod]
        public void addtocart()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.max();
            wait();
            baseclass.OpenUrl("https://www.mariab.pk/");

            addtocart cart = new addtocart();
            cart.addtoCart();
        }

        [TestMethod]
        public void checkout()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.max();
            wait();
            baseclass.OpenUrl("https://www.mariab.pk/");

            checkout chk = new checkout();
            chk.checkout1("rehmanmani247@gmail.com", "Rehman1122@", "winter");
        }

        [TestMethod]
        public void filter()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.max();
            wait();
            baseclass.OpenUrl("https://www.mariab.pk/");

            filter fltr = new filter();
            fltr.filters();
        }

        //[TestMethod]
        //public void rabia()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/admin/viewSystemUsers";

        //    Thread.Sleep(30000);

        //    driver.FindElement(By.Id("(//div[@class='oxd-select-text--after'])[1]")).Click();
        //    driver.FindElement(By.Id("(//div[text()='ESS'])[1]")).Click();

        //}

        //[TestMethod]
        //public void irfan()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Url = "https://www.junaidjamshed.com/";

        //    irfan grid1 = new irfan();
        //    grid1.view();

        //}

        [TestMethod]
        public void loginaddtocart()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.max();
            wait();
            baseclass.OpenUrl("https://www.mariab.pk/");

            LogIn log = new LogIn();
            log.login1("rehmanmani247@gmail.com", "Rehman1122@");

            addtocart cart = new addtocart();
            cart.addtoCart();
        }

        [TestMethod]
        public void sortt1()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.max();
          //  wait();
            baseclass.OpenUrl("https://www.mariab.pk/");

            wait();
            sortby sort = new sortby();
            sort.sortt();
        }
    }
}