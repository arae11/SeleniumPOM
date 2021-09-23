using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough.lib.pages
{
    public class AP_CartPage
    {
        private IWebDriver _seleniumDriver;

        private IWebElement _continueShoppingButton => _seleniumDriver.FindElement(By.Id("continue-shopping"));
        private IWebElement _removeBackpack => _seleniumDriver.FindElement(By.Id("remove-sauce-labs-backpack"));
        private IWebElement _checkoutButton => _seleniumDriver.FindElement(By.Id("checkout"));
        private IWebElement _header => _seleniumDriver.FindElement(By.Id("header_container"));

        public AP_CartPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public string GetHeaderText() => _header.Text;
        public void ClickContinueShopping() => _continueShoppingButton.Click();
        public string RemoveItemBackpack() => _removeBackpack.Text;
        public void ClickCheckout() => _checkoutButton.Click();
    }
}
