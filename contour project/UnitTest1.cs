using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace contour_project
{
    [TestClass]
    public class UnitTest1 : SignUp
    {
        [TestMethod]
        public void TestMethod1()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.OpenUrl("https://www.mariab.pk/");

            SignUp sign = new SignUp();
            sign.login("rehman", "usmanamjad1020@gmail.com", "usmna");

        }
    }
}
