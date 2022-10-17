using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace contour_project.outofstock
{
    [TestClass]
    public class testoutofstock : baseclass
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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "proj1#", "proj1.csv", DataAccessMethod.Sequential)]
        public void outofstock()
        {
            SeleniumInit("Chrome");
            max();
            OpenUrl();
            ImplicitWait();

            Search srch = new Search();
            srch.searchh("winter");

            string name = TestContext.DataRow["name"].ToString();
            string phone = TestContext.DataRow["phone"].ToString();
            string email = TestContext.DataRow["email"].ToString();

            outofStock stock = new outofStock();
            stock.stockout(name, phone, email);
        }
    }
}
