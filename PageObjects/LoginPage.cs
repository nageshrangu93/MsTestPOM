using MsTestPOM.BaseClasses;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace MsTestPOM.PageObjects
{
    public class LoginPage : TestBase
    {
        public LoginPage()
        {
            PageFactory.InitElements(_driver, this);
        }
        [FindsBy(How = How.Id, Using = "user-name")]
        public IWebElement txtUserName;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement txtPassword;

        [FindsBy(How = How.Id, Using = "login-button")]
        public IWebElement btnLogin;

        public void enterUserName(String userName)
        {
            txtUserName.SendKeys(userName);
        }

        public void enterPassWord(String passWord)
        {
            txtPassword.SendKeys(passWord);
        }

        public void clickLogin ()
        {
            btnLogin.Click();
        }
    }
}
