using FacebookProject.BaseClass;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FacebookProject.Pages
{
    class LoginPage : Baseclass
    {
        IWebDriver driver;
        [FindsBy(How = How.Id, Using = "email")]
        IWebElement Email;
        [FindsBy(How = How.Id, Using = "pass")]
        IWebElement Password;
        [FindsBy(How = How.XPath, Using = ".//*[@value='Log In']")]
        IWebElement Submit;

        [Obsolete]
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Login(string username,string password)
        {
            //login page with valid credentials
            Email.SendKeys(username);
            Password.SendKeys(password);
            Submit.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);
        }
        public void InvalidLogin(string username,string password)
        {
            Email.SendKeys(username);
            Password.SendKeys(password);
            Submit.Click();
            IWebElement Alert=driver.FindElement(By.XPath(".//*[@role='alert']"));
            Assert.AreEqual(Alert, "The email or phone number you’ve entered doesn’t match any account.Sign up for an account.");
        }

     


    }
}
