using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contour_project
{
    public class Search : baseclass
    {
        By searrch = By.Id("search");
        By btn = By.XPath("(//button[@type='submit'])[1]");
        By item = By.Id("product-collection-image-11192");



        public void searchh(string searcch)
        {
            Click(searrch);
            Write(searrch, searcch);
            Click(btn);
            Click(item);
           // scroll();
           // scrolltoelement(item);

        }

    }
}
