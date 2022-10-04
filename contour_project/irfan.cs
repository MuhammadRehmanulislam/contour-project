using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace contour_project
{
    internal class irfan : baseclass
    {
        By men = By.XPath("//span[text()='Men']");
        By kameez = By.XPath("//span[text()='Caps']");

        By viewas = By.ClassName("modes");

        By list = By.XPath("//a[title()='List']");

        By grid = By.XPath(("(//strong[@class='modes-mode active mode-grid'])[1]"));


        public void view()
        {
            hover(men);
            Click(kameez);
            Click(viewas);

            Click(list);

            Thread.Sleep(3000);
            Click(grid);

        }
    }
}
