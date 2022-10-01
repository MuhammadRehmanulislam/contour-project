using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contour_project
{
    public class addtocart : baseclass
    {
        By hover = By.XPath("(//span[text()='Ready To Wear'])[1]");
        By casual = By.Id("Casuals");

        


        public void addtoCart()
        {
            
            Click(casual);


        }
    }
}
