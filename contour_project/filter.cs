using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contour_project
{
    internal class filter : baseclass
    {
        By hower = By.XPath("(//span[text()='Ready To Wear'])[1]");
        By casual = By.Id("Casuals");
        By price = By.XPath("//label[text()='Price']");
        By secprice = By.XPath("(//span[text()='PKR 10,000'])[1]");
        By color = By.XPath("//div[@class='select-filter Color']");
        By clrslct = By.XPath("//a[text()='Blue']");
        By size = By.XPath("//div[@class='select-filter Size']");
        By sizee = By.XPath("//li[@class='s size30']");
        By select = By.Id("product-collection-image-37601");
        By small = By.Id("swatch30");
        By addtocart = By.XPath("//button[@title='Add to Bag']");



        public void filters()
        {
            hover(hower);
            Click(casual);
            Click(price);
            Click(secprice);
            wait(30);
            Click(color);
            Click(clrslct);
            wait(30);
            Click(size);
            Click(sizee);
            Click(select);
            scroll();
            Click(small);
            Click(addtocart);



        }
    }
}
