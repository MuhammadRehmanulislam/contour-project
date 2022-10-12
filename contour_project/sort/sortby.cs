using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace contour_project
{
    internal class sortby : baseclass
    {
        By newarrival = By.XPath("(//span[text()='New Arrivals'])[1]");
        By sort = By.XPath("//div[@class='sort-btn']");
        By name = By.XPath("//a[text()='Name']");
        By price = By.XPath("//a[text()='Price']");





        public void sortt()
        {
            Click(newarrival);
            Thread.Sleep(10000);
            Click(sort);
            //Click(name);
            Click(price);
        }
    }
}
