using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contour_project
{
    public class baseclass
    {
        public static ChromeDriver driver;

        public static void SeleniumInit(string browser)

        {

            driver = new ChromeDriver();

        }

        //public static void CloseDriver()

        //{

        //    driver.Close();

        //}

        public void Write(By by, string value)

        {

            driver.FindElement(by).SendKeys(value);

        }

        public  void Click(By by)

        {

            driver.FindElement(by).Click();

        }

        //public void Clear(By by)

        //{

        //    driver.FindElement(by).Clear();

        //}
        public static void OpenUrl(string url)

        {

            driver.Url = url;

        }

    }
}
