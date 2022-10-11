using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace contour_project
{
    public class LogIn : baseclass
    {

        By account = By.XPath("//span[text()='Account']");
        By login = By.XPath("//a[@title='Log In']");
        By emailid = By.Id("email");
        By password = By.Id("pass");
        By captcha = By.Id("captcha_user_login");
        By signin = By.Id("send2");
        By assrt = By.XPath("//h1[text()='Checkout']");
        By home = By.XPath("//img[@class='large']");


        public void login1(string email, string pass, string capt)
        {
            Click(account);
            Click(login);
            Write(emailid, email);
            Write(password, pass);
            Click(captcha);
            Write(captcha, capt);
            PlaybackWait(20000);
            scroll();
            Click(signin);
           // Click(home);
            //if (captcha != null)
            //{
            //    assert(assrt);
            //    Console.WriteLine("Login Successful");
            //}
            //else
            //{
            //    Console.WriteLine("Login Failed");
            //}
            
        }

        //IWebDriver driver1;

        //By account = By.XPath("//span[text()='Account']");
        //By emaill = By.Id("email_address");
        //By passs = By.Id("password");
        //// By captcha = By.Id("captcha_user_create");
        ////By loginn = By.Id("send2");


        //public LogIn(IWebDriver driver)
        //{
        //    driver1 = driver;
        //}

        //public void url()
        //{
        //    driver1.FindElement(account).Click();
        //    driver1.FindElement(emaill).Click();
        //    driver1.FindElement(passs).Click();
        //}

        //public void login(string email, string password)
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.FindElement(emaill).SendKeys(email);
        //    // wait(3000);
        //    driver.FindElement(passs).SendKeys(password);
        //    // driver.FindElement(loginn).Click();
        //}
    }
}