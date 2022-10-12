using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contour_project
{
    [TestClass]
  public class testsignup : baseclass

    {
      [TestMethod]
        public void signup()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.max();
            ImplicitWait();
            baseclass.OpenUrl("https://www.mariab.pk/");

            SignUp sign = new SignUp();
            sign.signup1("Rehman", "rehmanmani247@gmail.com", "Rehman1122@", "Rehman1122@", "");
        }
    
    [TestMethod]
        public void invalidSignup()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.max();
            ImplicitWait();
            baseclass.OpenUrl("https://www.mariab.pk/");

            invalidSignup sign = new invalidSignup();
            sign.invalidSignup1("Rehman", "rehmanmani247gmail.com", "Rehman1122", "Rehman1122@", "");
        }
    }
}
