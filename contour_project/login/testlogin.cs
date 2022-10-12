using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace contour_project.login
{
    
    [TestClass]
    public class testlogin : baseclass
    {   [TestMethod]
           
            public void login()
            {
                baseclass.SeleniumInit("Chrome");
                baseclass.max();
                ImplicitWait();
                baseclass.OpenUrl("https://www.mariab.pk/");

                LogIn log = new LogIn();
                log.login1("rehmanmani247@gmail.com", "Rehman1122@", " ");
            
        }
        [TestMethod]
        public void invalidlogin()
        {
            baseclass.SeleniumInit("Chrome");
            baseclass.max();
            ImplicitWait();
            baseclass.OpenUrl("https://www.mariab.pk/");

            LogIn log = new LogIn();
            log.login1("rehmanmani247@gmail.com", "Rehman1122", " ");

        }

    }
}
