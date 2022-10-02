using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contour_project
{
    internal class checkout : baseclass
    {
        By cart = By.XPath("//a[@class='skip-link skip-cart']");
        By outt = By.XPath("//a[@class='button checkout-button']");



        public void checkout1(string email, string pass, string searcch)
        {
            Click(cart);
            Click(outt);
            
        }
    }
}
