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
    class AccountPage : BasePage
    {
        public AccountPage(IWebDriver _driver) : base(_driver)
        {
        }

        public void NavigateToFavoriteList()
        {
            Click(AccountConstant.FAVORITES);
        }

        public void CheckProductExistOnFavorites(string productId)
        {
            IWebElement product = FindElement(By.Id(productId));
            Assert.IsTrue(product.GetAttribute("id").Equals(productId));
        }

        public void RemoveFromFavorites(string productId)
        {
            IWebElement product = FindElement(By.Id(productId));
            IWebElement deleteFromFavorites = product.FindElement(By.ClassName("deleteProFromFavorites"));
            deleteFromFavorites.Click();

            IWebElement message = FindElement(By.CssSelector(".lightBox .message"));
            Assert.AreEqual(message.Text, "Ürününüz listeden silindi.");
        }
    }
}
