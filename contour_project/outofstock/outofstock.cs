using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contour_project
{
    public class outofStock : baseclass
    {

        By name = By.Id("notify-full-name");
        By phone = By.Id("notify-contact-number");
        By email = By.Id("notify-email");
        By btn = By.Id("subscribe");



        public void stockout(string name1, string phone1, string email1)
        {


            Click(name);
            Write(name, name1);
            Click(phone);
            Write(phone, phone1);
            Click(email);
            Write(email, email1);
            scroll();
            Click(btn);

        }
    }
}
