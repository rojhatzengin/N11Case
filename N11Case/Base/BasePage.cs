using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace N11Case.Base
{
    class BasePage
    {
        IWebDriver driver;
        public BasePage(IWebDriver _driver)
        {
            this.driver = _driver;
        }

        // Tüm sayfalara Click(Tiklama) eklemek icin
        public void Click(By element)
        {
            FindElement(element).Click();
        }

        // Tüm sayfalara SendKeys(Yazi Girme) eklemek icin
        public void SendKeys(By element, string text)
        {
            FindElement(element).SendKeys(text);
        }

        // Tum sayfalarda FindElement(Elamani Bulma) fonksiyonunu ekler
        public IWebElement FindElement(By element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            return wait.Until(ExpectedConditions.ElementIsVisible(element));
        }

        // Tum sayfalara HoverElement(Fareyi elemanin ustune goturme) fonksiyonunu ekler
        public void HoverElement(By by)
        {
            IWebElement element = FindElement(by);

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public void HoverElement(IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }
    }
}
