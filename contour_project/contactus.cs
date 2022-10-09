using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contour_project
{
    public class contactus : baseclass
    {
        By contact = By.XPath("//a[text()='Contact Us']");
        By name = By.Id("name");
        By email = By.Id("email");
        By phone = By.Id("telephone");
        By comment = By.Id("comment");
        By submit = By.XPath("//button[@title='Submit']");



        public void contactus1(string name1, string email1, string phone1, string comment1)
        {
            scroll();
            scroll();
            Click(contact);
            scroll();
            Click(name);
            Write(name, name1);
            Click(email);
            Write(email, email1);
            Click(phone);
            Write(phone, phone1);
            Click(comment);
            Write(comment, comment1);
            Click(submit);

        }
    }
}
