using FacebookProject.BaseClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookProject.Pages
{
    class SearchPage : Baseclass
    {
        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='Search Profile']")]
        IWebElement SearchTab;
        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='Close']/i")]
        IWebElement CloseSearch;

        [Obsolete]
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void search()
        {
            // to verify the search page
            Console.WriteLine(driver.Url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3000);
          //  SearchTab.Click();
            Console.WriteLine("Search page with credential");
         

            
        }
    }
}
