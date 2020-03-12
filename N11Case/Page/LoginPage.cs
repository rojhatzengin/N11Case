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
    class LoginPage : BasePage
    {
        public LoginPage(IWebDriver _driver) : base(_driver)
        {
        }

        public void Login(string email, string password)
        {
            SendKeys(LoginConstant.EMAIL_INPUT, email);
            SendKeys(LoginConstant.PASSWORD_INPUT, password);
            Click(LoginConstant.LOGIN_BUTTON);
        }
    }
}
