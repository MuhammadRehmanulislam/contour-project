using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace contour_project.newsletter
{
    
    [TestClass]
    public class testnewsletter : baseclass
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

        [TestMethod]
        public void newsletter()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.max();
            //  wait();
            baseclass.OpenUrl("https://www.mariab.pk/");
            ImplicitWait();

            newsLetter news = new newsLetter();
            news.newsletter1("rehmanmani247@gmail.com");

        }
    }
}
