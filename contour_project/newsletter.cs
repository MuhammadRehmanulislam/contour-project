using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contour_project
{
   public class newsletter : baseclass
    {
        By news = By.Id("newsletter");
        By subs = By.Id("submit");



        public void newsletter1(string email)
        {
            scroll();
            scroll();
            Click(news);
            Write(news, email);
            Click(subs);
        }
    }
}
