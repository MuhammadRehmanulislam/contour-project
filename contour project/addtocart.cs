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
        By casual = By.Id("Casuals");
        By hower = By.XPath("(//span[text()='Ready To Wear'])[1]");
        By suit = By.Id("product-collection-image-38768");
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
