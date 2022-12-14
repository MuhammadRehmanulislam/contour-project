using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contour_project
{
    public class Addtocart : baseclass
    {
        
        By hower = By.XPath("(//span[text()='Ready To Wear'])[1]");
        By casual = By.Id("Casuals");
        By suit = By.Id("product-collection-image-39768");
        By small = By.Id("swatch30");
        By addcart = By.XPath("//button[@title='Add to Bag']");


        public void addtoCart()
        {
            hover(hower);
            Click(casual);
            scroll();
            Click(suit);
            Click(small);
            scroll();
            Click(addcart);

        }
    }
}
