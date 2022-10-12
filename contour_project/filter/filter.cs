using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contour_project
{
    internal class Filter : baseclass
    {
        By hower = By.XPath("(//span[text()='Ready To Wear'])[1]");
        By casual = By.Id("Casuals");
        By price = By.XPath("//label[text()='Price']");
        By secprice = By.XPath("(//span[text()='PKR 10,000'])[1]");
        By color = By.XPath("//div[@class='select-filter Color']");
        By clrslct = By.XPath("//a[text()='Blue']");
        By size = By.XPath("//div[@class='select-filter Size']");
        By sizee = By.XPath("//li[@class='s size30']");
        By select = By.Id("product-collection-image-35783");
        By small = By.Id("swatch30");
        By addtocart = By.XPath("//button[@title='Add to Bag']");



        public void filters()
        {
            hover(hower);
            Click(casual);
            Click(price);
            Click(secprice);
            ImplicitWait();
            Click(color);
            Click(clrslct);
            ImplicitWait();
            Click(size);
            Click(sizee);
            Click(select);
            scroll();
            Click(small);
            Click(addtocart);



        }
    }
}
