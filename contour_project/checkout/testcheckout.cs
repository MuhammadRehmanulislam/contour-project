﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace contour_project.checkout
{
    
    [TestClass]
    public class testcheckout : baseclass
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
        public void checkout()
        {
            SeleniumInit("Chrome");
            max();
            ImplicitWait();
            OpenUrl();

            Addtocart cart = new Addtocart();
            cart.addtoCart();

            Checkout chk = new Checkout();
            chk.checkout1("winter", "rehmanmani247@gmail.com", "Rehman1122@");
        }
    }
}
