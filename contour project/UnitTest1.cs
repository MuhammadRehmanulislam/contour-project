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
            baseclass.max();
            wait();
            baseclass.OpenUrl("https://www.mariab.pk/");


            SignUp sign = new SignUp();
            LogIn log = new LogIn();

            log.login1("rehmanmani247@gmail.com", "Rehman1122@", "");

          //  sign.signup1("Rehman", "rehmanmani247@gmail.com", "Rehman1122@", "Rehman1122@", "");

        }
    }
}