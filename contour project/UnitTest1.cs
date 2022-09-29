using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace contour_project
{
    [TestClass]
    public class UnitTest1 : SignUp
    {
        

        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "datalog.xml", "Login", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.max();
            wait();
            //baseclass.OpenUrl("https://www.mariab.pk/");

            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();


          //  SignUp sign = new SignUp();
            //  sign.signup1("Rehman", "rehmanmani247@gmail.com", "Rehman1122@", "Rehman1122@", "");

            LogIn log = new LogIn();
            log.login1(user,pass);

            //   log.login1("rehmanmani247@gmail.com", "Rehman1122@", "");

            //Search srch = new Search();
            //srch.searchh("winter");




        }
    }
}