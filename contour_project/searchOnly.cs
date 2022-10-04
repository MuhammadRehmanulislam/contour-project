using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contour_project
{
    public class searchOnly : baseclass
    {
        By searrch = By.Id("search");
        By btn = By.XPath("(//button[@type='submit'])[1]");
        By item = By.Id("product-collection-image-11192");


        public void searchonly1(string searcch)
        {
            Click(searrch);
            Write(searrch, searcch);
        }
    }
}
