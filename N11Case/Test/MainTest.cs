using N11Case.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N11Case.Test
{
    public class MainTest
    {
        IWebDriver driver;
        MainPage mainPage;
        LoginPage loginPage;
        BrowsePage browsePage;
        AccountPage accountPage;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("test-type");
            driver = new ChromeDriver(options);
            mainPage = new MainPage(driver);
            loginPage = new LoginPage(driver);
            browsePage = new BrowsePage(driver);
            accountPage = new AccountPage(driver);

            driver.Navigate().GoToUrl("https://www.n11.com");
        }

        [Test]
        public void TestCase()
        {
            mainPage.NavigateToLogIn();
            loginPage.Login("<mail_adresi>", "<parola>");
            mainPage.SearchData("samsung");
            browsePage.CheckResultText("Samsung");
            browsePage.SwitchPage(2);

            string productId = browsePage.AddFavorites(3);

            mainPage.NavigateToFavorites();
            accountPage.NavigateToFavoriteList();
            accountPage.CheckProductExistOnFavorites(productId);
            accountPage.RemoveFromFavorites(productId);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
