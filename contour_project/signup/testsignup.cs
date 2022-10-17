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
            SeleniumInit("Chrome");
            max();
            ImplicitWait();
            OpenUrl();

            SignUp sign = new SignUp();
            sign.signup1("Rehman", "rehmanmani247@gmail.com", "Rehman1122@", "Rehman1122@");
        }
    
    [TestMethod]
        public void invalidSignup()
        {
            SeleniumInit("Chrome");
            max();
            ImplicitWait();
            OpenUrl();

            invalidSignup sign = new invalidSignup();
            sign.invalidSignup1("Rehman", "rehmanmani247gmail.com", "Rehman1122", "Rehman1122@");
        }
    }
}
