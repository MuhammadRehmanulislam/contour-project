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
        By account = By.XPath("//span[text()='Account']");
        By login = By.XPath("//a[@title='Log In']");
        By emailid = By.Id("email");
        By password = By.Id("pass");

        By searrch = By.Id("search");
        By btn = By.XPath("(//button[@type='submit'])[1]");
        By item = By.Id("product-collection-image-11192");




        public void checkout1(string email, string pass, string searcch)
        {
            Click(account);
            Click(login);
            Write(emailid, email);
            Write(password, pass);

            Click(searrch);
            Write(searrch, searcch);
            Click(btn);
            Click(item);
        }
    }
}
