using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumPOMWalkthrough.lib.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough.lib.pages
{
    public class AP_CheckoutCompletePage
    {
        private IWebDriver _seleniumDriver;
        private string _checkoutcompletepage_url = AppConfigReader.CheckoutCompletePageURL;

        private IWebElement _homeButton => _seleniumDriver.FindElement(By.Id("back-to-products"));
        private IWebElement _header => _seleniumDriver.FindElement(By.Id("header_container"));

        public AP_CheckoutCompletePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public void ClickHomeButton() => _homeButton.Click();
        public string GetHeaderText() => _header.Text;

        //Checkout: Complete!
    }
}
