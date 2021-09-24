using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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

        private IWebElement _filterItems => _seleniumDriver.FindElement(By.ClassName("product_sort_container"));
        private IWebElement _addToCart => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        private IWebElement _addToCart2 => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        private IWebElement _addToCart3 => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        private IWebElement _addToCart4 => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket"));
        private IWebElement _addToCart5 => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-onesie"));
        private IWebElement _addToCart6 => _seleniumDriver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)"));
        private IWebElement _shoppingCartButton => _seleniumDriver.FindElement(By.Id("shopping_cart_container"));
        private IWebElement _header => _seleniumDriver.FindElement(By.Id("header_container"));


        public AP_InventoryPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public void GoToUserPage() => _seleniumDriver.Navigate().GoToUrl(_inventoryPageUrl);
        public void ClickShoppingCartButton() => _shoppingCartButton.Click();
        public string ShoppingCartNumber() => _shoppingCartButton.Text;
        public void ClickAddToCartBackpack() => _addToCart.Click();
        public void ClickAddToCartBike() => _addToCart2.Click();
        public void ClickAddToCartTShirt() => _addToCart3.Click();
        public void ClickAddToCartFleece() => _addToCart4.Click();
        public void ClickAddToCartOnesie() => _addToCart5.Click();
        public void ClickAddToCartTShirtRed() => _addToCart6.Click();
        public void AddAllItems()
        {
            _addToCart.Click();
            _addToCart2.Click();
            _addToCart3.Click();
            _addToCart4.Click();
            _addToCart5.Click();
            _addToCart6.Click();
        }
        public void SortByPriceAscending()
        {
            _filterItems.FindElement(By.XPath("//*[@id=\"header_container\"]/div[2]/div[2]/span/select/option[3]")).Click();
        }
        public string GetHeaderText() => _header.Text;
    }
}
