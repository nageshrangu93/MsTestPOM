using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsTestPOM.BaseClasses;
using MsTestPOM.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MsTestPOM.Tests
{
     [TestClass]
    public class Products : TestBase
    {
        [TestMethod]
        [Priority(1)]
        public void ProductFilter()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.enterUserName("standard_user");
            loginPage.enterPassWord("secret_sauce");
            loginPage.clickLogin();
            ProductsPage productsPage = new ProductsPage();
            productsPage.SelectDropownVaue("Name (Z to A)");
        }

        [TestMethod]
        [Priority(2)]
        public void AddToCart()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.enterUserName("standard_user");
            loginPage.enterPassWord("secret_sauce");
            loginPage.clickLogin();
            ProductsPage productsPage = new ProductsPage();
            String productName = productsPage.saveProductName();
            productsPage.ClickAddToCart();
            productsPage.ClickCartIcon();
            String savedProductName = productsPage.saveProductName();
            Assert.AreEqual(productName, savedProductName);
        }


    }
}
