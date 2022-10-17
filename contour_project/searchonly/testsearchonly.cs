using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace contour_project.searchonly
{
    
    [TestClass]
    public class testsearchonly : baseclass
    {
        

        [TestMethod]
        public void searchOnly()
        {
            SeleniumInit("Chrome");
            max();
            ImplicitWait();
            OpenUrl();

            searchOnly srch = new searchOnly();
            srch.searchonly1("winter");// change 
        }
    }
}
