using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookProject.Pages
{
    class ProfilePage
    {
        IWebDriver driver;
        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='Account']/i")]
        IWebElement MyAccount;
        [FindsBy(How = How.XPath, Using = ".//*[contains(text(), 'See your profile')]")]
        IWebElement CheckProfile;
        [FindsBy(How = How.XPath, Using = ".//*[contains(text(), 'See your profile')]")]
        IWebElement ViewProfile;

        [Obsolete]
        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void profile()
        {
            //to check the profile page
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);
            MyAccount.Click();
            IWebElement Profile = CheckProfile;
            String ProfilePage = Profile.Text;
            ViewProfile.Click();
            Console.WriteLine(driver.Url);
            Console.WriteLine(ProfilePage);

        }
    }
}
