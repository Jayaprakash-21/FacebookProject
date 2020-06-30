using FacebookProject.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;


namespace FacebookProject.BaseClass
{
    class Baseclass
    {
        IWebDriver driver;
        public LoginPage loginpageObj;
        public ProfilePage profilepageObj;
        public SearchPage searchpageObj;
        public HomePage homepageObj;
        public static ExtentReports extent;
        public static ExtentTest test;

        [SetUp]
        [Obsolete]
        public void SetUp()
        {
            //Append the html report file to current project path

            string reportPath = "C:\\Users\\Jay\\source\\repos\\FacebookProject\\Reports\\TestRunReport.html";
            //Boolean value for replacing exisisting report
            extent = new ExtentReports(reportPath, true);
            //Add QA system info to html report
            extent.AddSystemInfo("Host Name", "YourHostName")
                .AddSystemInfo("Environment", "YourQAEnvironment")
                .AddSystemInfo("Username", "YourUserName");
            //Adding config.xml file
            extent.LoadConfig( "Extent-config.xml"); //Get the config.xml file from http://extentreports.com


            //Launch the browser
            driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            Console.WriteLine("ChromeDriver started successfully");
            loginpageObj = new LoginPage(driver);
            profilepageObj = new ProfilePage(driver);
            searchpageObj = new SearchPage(driver);
            homepageObj = new HomePage(driver);
        }

        [TearDown]

        public void AfterClass()
        {
            //StackTrace details for failed Testcases
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "" + TestContext.CurrentContext.Result.StackTrace + "";
            var errorMessage = TestContext.CurrentContext.Result.Message;
            if (status == TestStatus.Failed)
            {
                string currentDate = DateTime.Now.ToString("HH:mm:ss");
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\Jay\\source\\repos\\FacebookProject\\ScreenShot\\" + currentDate+".Png",ScreenshotImageFormat.Png);
                test.Log(LogStatus.Fail, status + errorMessage);
            }
            //End test report
            extent.EndTest(test);
            //driver.Quit();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            //End Report
            extent.Flush();
            extent.Close();
        }

    }
}
