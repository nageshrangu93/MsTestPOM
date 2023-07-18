using MsTestPOM.BaseClasses;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MsTestPOM.PageObjects
{
    public class ProductsPage : TestBase
    {
        public ProductsPage()
        {
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-backpack")]
        public IWebElement btnAddToCart;

        [FindsBy(How = How.ClassName, Using = "shopping_cart_link")]
        public IWebElement btnCart;

        public void SelectDropownVaue(String ddValue)
        {
            IWebElement ele = _driver.FindElement(By.ClassName("product_sort_container"));
            SelectElement se = new SelectElement(ele);
            se.SelectByText(ddValue);
        }

        public String saveProductName()
        {
            IWebElement webElement = _driver.FindElement(By.XPath("(//div[@class='inventory_item_name'])[1]"));
            String productName = webElement.Text;
            return productName;
        }
        public void ClickAddToCart()
        {
            btnAddToCart.Click();
        }

        public void ClickCartIcon()
        {
            btnCart.Click();
        }
    }
}
