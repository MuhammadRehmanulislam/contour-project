using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contour_project
{
    public class Checkout : baseclass
    {
        By cart = By.XPath("//a[@class='skip-link skip-cart  no-count']");
        By outt = By.XPath("//a[@class='button checkout-button']");
        By email1 = By.Id("email");
        By pass1 = By.Id("pass");
        By btn = By.Id("send2");



        public void checkout1(string searcch, string email, string pass)
        {
            Click(cart);
            Click(outt);
            Click(email1);
            Write(email1, email);
            Click(pass1);
            Write(pass1, pass);
            Click(btn);
            
        }
    }
}
