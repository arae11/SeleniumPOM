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
    public class AP_CheckoutStepOnePage
    {
        private IWebDriver _seleniumDriver;
        private string _checkoutonepage_url = AppConfigReader.CheckoutOnePageURL;

        private IWebElement _cancelButton => _seleniumDriver.FindElement(By.Id("cancel"));
        private IWebElement _continueButton => _seleniumDriver.FindElement(By.Id("continue"));
        private IWebElement _firstNameField => _seleniumDriver.FindElement(By.Id("first-name"));
        private IWebElement _lastNameField => _seleniumDriver.FindElement(By.Id("last-name"));
        private IWebElement _postalCodeField => _seleniumDriver.FindElement(By.Id("postal-code"));
        private IWebElement _errorMessage => _seleniumDriver.FindElement(By.Id("error-message-container error"));
        private IWebElement _header => _seleniumDriver.FindElement(By.Id("header_container"));

        public AP_CheckoutStepOnePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public void ClickCancelButton() => _cancelButton.Click();
        public void ClickContinueButton() => _continueButton.Click();
        public void InputFirstName(string firstName) => _firstNameField.SendKeys(firstName);
        public void InputLastName(string lastName) => _lastNameField.SendKeys(lastName);
        public void InputPostalCode(string postCode) => _postalCodeField.SendKeys(postCode);
        public string GetErrorMessage() => _errorMessage.Text;
        public string GetHeaderText() => _header.Text;

        //Checkout: Your Information
    }
}
