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
    public class AP_CheckoutStepTwoPage
    {
        private IWebDriver _seleniumDriver;
        private string _checkouttwopage_url = AppConfigReader.CheckoutTwoPageURL;

        private IWebElement _cancelButton => _seleniumDriver.FindElement(By.Id("cancel"));
        private IWebElement _finishButton => _seleniumDriver.FindElement(By.Id("finish"));
        private IWebElement _header => _seleniumDriver.FindElement(By.Id("header_container"));

        public AP_CheckoutStepTwoPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public void ClickCancelButton() => _cancelButton.Click();
        public void ClickFinishButton() => _finishButton.Click();
        public string GetHeaderText() => _header.Text;

        //Checkout: Overview
    }
}
