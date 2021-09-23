using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumPOMWalkthrough.lib.pages;
using SeleniumPOMWalkthrough.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough.lib.pages
{
    public class AP_CheckoutStepOnePage
    {
        private IWebDriver _seleniumDriver;
        private string _checkoutonepage_url = AppConfigReader.CheckoutOnePageURL;

        private IWebElement _cancelButton => _seleniumDriver.FindElement(By.Id("cancel"));
        private IWebElement _continueButton => _seleniumDriver.FindElement(By.Id("continue"));
        private IWebElement _firstNameField => _seleniumDriver.FindElement(By.Id("first-name"));
        private IWebElement _lastNameField => _seleniumDriver.FindElement(By.Id("last-name"));
        private IWebElement _postalCodeField => _seleniumDriver.FindElement(By.Id("postal-code"));
        private IWebElement _errorMessage => _seleniumDriver.FindElement(By.Id("checkout_info_container"));
        private IWebElement _header => _seleniumDriver.FindElement(By.Id("header_container"));

        public AP_CheckoutStepOnePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public void ClickCancelButton() => _cancelButton.Click();
        public void ClickContinueButton() => _continueButton.Click();
        public void InputCheckoutInformation(CheckoutInformation checkoutInformation)
        {
            _firstNameField.SendKeys(checkoutInformation.FirstName);
            _lastNameField.SendKeys(checkoutInformation.LastName);
            _postalCodeField.SendKeys(checkoutInformation.PostalCode);
        }
        public string GetErrorMessage() => _errorMessage.Text;
        public string GetHeaderText() => _header.Text;
    }
}
