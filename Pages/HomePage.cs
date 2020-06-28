using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookProject.Pages
{
    class HomePage
    {
        IWebDriver driver;
        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='Home']/span")]
        IWebElement HomeBtn;

        [Obsolete]
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Home()
        {
            HomeBtn.Click();
        }
    }
}
