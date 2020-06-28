using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookProject.Pages
{
    class LoginPage
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

        public void Login()
        {
            //login page with valid credentials
            Email.SendKeys("jayaprakash778@gmail.com");
            Password.SendKeys("J1a2y3@4$");
            Submit.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);
        }

    }
}
