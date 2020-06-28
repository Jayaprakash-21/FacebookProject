using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FacebookProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FacebookProject
{
    class Program
    {
        IWebDriver driver;

        [Obsolete]
        static void Main(string[] args)
        {
            //Launch the browser
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            Console.WriteLine("ChromeDriver started successfully");

            LoginPage loginpageObj = new LoginPage(driver);
            loginpageObj.Login();

            ProfilePage profilepageObj = new ProfilePage(driver);
            profilepageObj.profile();

            SearchPage searchpageObj = new SearchPage(driver);
            searchpageObj.search();

            HomePage homepageObj = new HomePage(driver);
            homepageObj.Home();



            driver.Quit();











        }
    }
}
