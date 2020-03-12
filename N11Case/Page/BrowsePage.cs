using N11Case.Base;
using N11Case.Constant;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N11Case.Page
{
    class BrowsePage : BasePage
    {
        public BrowsePage(IWebDriver _driver) : base(_driver)
        {
        }

        public void CheckResultText(string text)
        {
            IWebElement resultText = FindElement(BrowseConstant.RESULT_TEXT);
            Assert.IsTrue(resultText.Text.Contains(text));
        }

        public void SwitchPage(int pageNumber)
        {
            HoverElement(BrowseConstant.PAGINATION);
            Click(BrowseConstant.GetPageElement(pageNumber));
        }

        public string AddFavorites(int productNumber)
        {
            By product = BrowseConstant.GetProductElement(productNumber);
            IWebElement productElement = FindElement(product);
            IWebElement followElement = productElement.FindElement(By.ClassName("followBtn"));

            HoverElement(followElement);
            followElement.Click();

            return productElement.FindElement(By.ClassName("columnContent")).GetAttribute("id");
        }
    }
}
