using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace contour_project.contactus
{
    
    [TestClass]
    public class testcontactus : baseclass
    {
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "proj#", "proj.csv", DataAccessMethod.Sequential)]
        public void contactus()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.max();
            //  wait();
            baseclass.OpenUrl("https://www.mariab.pk/");
            ImplicitWait();

            string name = TestContext.DataRow["name"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string phone = TestContext.DataRow["phone"].ToString();
            string comment = TestContext.DataRow["comment"].ToString();

            contactUs cont = new contactUs();
            cont.contactus1(name, email, phone, comment);

        }
    }
}
