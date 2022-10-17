using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace contour_project
{
    
    public class invalidLogin : baseclass
    {
        By account = By.XPath("//span[text()='Account']");
        By login = By.XPath("//a[@title='Log In']");
        By emailid = By.Id("email");
        By password = By.Id("pass");
        By captcha = By.Id("captcha_user_login");
        By signin = By.Id("send2");

        
        public void invalidlogin1(string email, string pass, string cap)
        {
            Click(account);
            Click(login);
            Write(emailid, email);
            Write(password, pass);
            Write(captcha, cap);
            PlaybackWait(20000);
            scroll();
            Click(signin);
        }

    }
}
