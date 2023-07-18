using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsTestPOM.BaseClasses;
using MsTestPOM.PageObjects;
using System;
using System.Configuration;
[assembly: Parallelize(Workers = 4, Scope = ExecutionScope.ClassLevel)]

namespace MsTestPOM.Tests
{
    [TestClass]
     public class LoginTest : TestBase
    {
         [TestMethod]
         [Priority(1)]
        public void Login()
        {           
            LoginPage loginPage = new LoginPage();
            loginPage.enterUserName("standard_user");
            loginPage.enterPassWord("secret_sauce");
            loginPage.clickLogin();
            Assert.AreEqual(_driver.Title, "Swag Labs");
        }

        [TestMethod]
        [Priority(2)]
        public void LoginFailure()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.enterUserName("problem_user");
            loginPage.enterPassWord("secret_sauce");
            loginPage.clickLogin();
            Assert.AreEqual(_driver.Title, "Swag Labs");
        }
    }
}
