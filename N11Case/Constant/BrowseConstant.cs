using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N11Case.Constant
{
    class BrowseConstant
    {
        public static By RESULT_TEXT = By.CssSelector("div.resultText");
        public static By PAGINATION = By.CssSelector("div.pagination");

        public static By GetPageElement(int pageNumber)
        {
            return By.CssSelector("div.pagination > a:nth-child(" + pageNumber + ")");
        }

        public static By GetProductElement(int productNumber)
        {
            return By.CssSelector("div#view > ul > li:nth-child(" + productNumber + ")");
        }
    }
}
