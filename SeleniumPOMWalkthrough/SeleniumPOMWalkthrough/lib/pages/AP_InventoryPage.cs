using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough.lib.pages
{
    public class AP_InventoryPage
    {
        private IWebDriver _seleniumDriver;
        private string _inventoryPageUrl = AppConfigReader.InventoryPageURL;

        private IWebElement _addToCart => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        private IWebElement _addToCart2 => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        private IWebElement _shoppingCartButton => _seleniumDriver.FindElement(By.Id("shopping_cart_container"));
        private IWebElement _header => _seleniumDriver.FindElement(By.Id("header_container"));


        public AP_InventoryPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void GoToUserPage() => _seleniumDriver.Navigate().GoToUrl(_inventoryPageUrl);
        public void ClickShoppingCartButton() => _shoppingCartButton.Click();
        public string ShoppingCartNumber() => _shoppingCartButton.Text;
        public void ClickAddToCartBackpack() => _addToCart.Click();
        public void ClickAddToCartBike() => _addToCart2.Click();
        public string GetHeaderText() => _header.Text;
    }
}
