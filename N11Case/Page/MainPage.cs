using N11Case.Base;
using N11Case.Constant;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N11Case.Page
{
    class MainPage : BasePage
    {
        public MainPage(IWebDriver _driver) : base(_driver)
        {
        }

        public void NavigateToLogIn()
        {
            Click(MainConstant.LOGIN_BUTTON);
        }

        public void SearchData(string searchText)
        {
            SendKeys(MainConstant.SEARCH_INPUT, searchText);
            Click(MainConstant.SEARCH_BUTTON);
        }

        public void NavigateToFavorites()
        {
            HoverElement(MainConstant.MY_ACCOUNT);
            Click(MainConstant.MY_ACCOUNT_MENU_FAVORITES);
        }
    }
}
