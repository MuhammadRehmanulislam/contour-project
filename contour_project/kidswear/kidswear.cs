using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contour_project
{
    public class kidsWear : baseclass
    {
        By hower = By.XPath("(//span[text()='Kids'])[1]");
        By kidd = By.XPath("(//span[text()='Kids'])[2]");
        By suit = By.Id("product-collection-image-39880");
        By size = By.Id("swatch46");
        By addcart = By.XPath("//button[@title='Add to Bag']");


        public void kids()
        {
            hover(hower);
            Click(kidd);
            scroll();
            Click(suit);
            Click(size);
            scroll();
            Click(addcart);
        }
    }
}
