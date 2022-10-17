using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using static contour_project.ExtentReport;

namespace contour_project.login
{
    
    [TestClass]
    public class testlogin : baseclass
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {

        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {

        }

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            ExtentReport.LogReport("TestReport");
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            ExtentReport.extentReports.Flush();
        }

        [TestInitialize()]
        public void TestInit()
        {

            ExtentReport.LogReport(TestContext.TestName);
            
        }

        [TestCleanup()]
        public void TestCleanUp()
        {
            baseclass.CloseDriver();
        }

        [TestMethod]
            public void login()
            {
                SeleniumInit("Chrome");
                max();
                ImplicitWait();
                OpenUrl();

            LogIn log = new LogIn();

            ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest(TestContext.TestName);
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Login");

            string expe = "Log Out";
            log.login1("rehmanmani247@gmail.com", "Rehman1122@");

            string actualtext = driver.FindElement(By.XPath("//a[text()='Log Out']")).Text;
            Assert.AreEqual(expe, actualtext);
        }
        [TestMethod]
        public void invalidlogin()
        {
            SeleniumInit("Chrome");
            max();
            ImplicitWait();
            OpenUrl();

            LogIn log = new LogIn();

            ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest(TestContext.TestName);
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("INLogin");

            log.login1("rehmanmani247@gmail.com", "Rehman1122");

        }
    }
}