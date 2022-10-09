using contour_project;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace contour_project
{
    public class SignUp : baseclass
    {
        By account = By.XPath("//span[text()='Account']");
        By registe = By.XPath("//a[@title='Register']");
        By name = By.Id("customer_fullname");
        By email = By.Id("email_address");
        By pass = By.Id("password");
        By cpass = By.Id("confirmation");
        By captcha = By.Id("captcha_user_create");
        //  By newsleter = By.XPath("//label[text()='Sign Up for Newsletter']");
        By signup = By.XPath("//span[text()='Sign up']");


        public void signup1(string fname, string email1, string password, string capass, string cap)
        {
            Click(account);
            Click(registe);
            Write(name, fname);
            Write(email, email1);
            Write(pass, password);
            Write(cpass, capass);
            Thread.Sleep(15000);
            Write(captcha, cap);
            //Thread.Sleep(15000);
            //Click(newsleter);
            // Write(newsleter, newsl);
            Click(signup);

        }
    }
}