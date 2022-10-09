using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace contour_project
{
    public class storelocation : baseclass
    {
        By loc = By.XPath("//a[text()='Store Locator']");
        By city = By.Id("city");
        By lahore = By.XPath("//option[@value='Lahore']");



        public void store()
        {
            scroll();
            scroll();
            Click(loc);
            //Click(city);
            //Click(lahore);
            dropDownItemSelect(city, "Lahore");
        }
    }
}
