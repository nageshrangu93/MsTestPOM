using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
namespace MsTestPOM.BaseClasses
{

    public class TestBase
    {
        public static IWebDriver _driver;
        string AppURL = ConfigurationManager.AppSettings["url"];
        string Browser = ConfigurationManager.AppSettings["browser"].ToLower();
        [TestInitialize]
        public void Intialize()
        {
            if (Browser.Equals("chrome"))
            {
                _driver = new ChromeDriver();
            }
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(AppURL);
        }

        [TestCleanup]
        public void CloseDriver()
        {
            _driver.Quit();
        }
    }
}
