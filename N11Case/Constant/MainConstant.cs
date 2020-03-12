using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N11Case.Constant
{
    class MainConstant
    {
        public static By LOGIN_BUTTON = By.CssSelector("a.btnSignIn");
        public static By SEARCH_INPUT = By.Id("searchData");
        public static By SEARCH_BUTTON = By.CssSelector("a.searchBtn");
        public static By MY_ACCOUNT = By.ClassName("myAccount");
        public static By MY_ACCOUNT_MENU_FAVORITES = By.CssSelector(".myAccountMenu a:nth-child(2)");
    }
}
