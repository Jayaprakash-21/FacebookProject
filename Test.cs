using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FacebookProject.BaseClass;
using FacebookProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;

namespace FacebookProject
{
    class Test : Baseclass
    {
        [Test]
        public void Test1()
        {
            //Start Report
            test = extent.StartTest("Test1");
            loginpageObj.Login("jayaprakash778@gmail.com","J1a2y3@4$");            
            profilepageObj.profile();            
            searchpageObj.search();           
            homepageObj.Home();
            test.Log(LogStatus.Pass, "Test Passed for valid credentials");
        }
        [Test]
        public void InvalidLoginPageTest()
        {
            //Start Report
            test = extent.StartTest("InvalidLoginPageTest");
            loginpageObj.InvalidLogin("jayaprakash@gmail.com", "");
            test.Log(LogStatus.Pass, "Test Failed for Invalid credentials");
        }

        static void Main(string[] args)
        {

        }
    }
}
