using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumPOMWalkthrough.utils;

namespace SeleniumPOMWalkthrough.lib.pages
{
    public class AP_HomePage
    {
        #region Properties
        private IWebDriver _seleniumDriver;
        // Set the homepageurl
        private string _homePageUrl = AppConfigReader.BaseURL;
        // Create a private property that models the sign in link
        private IWebElement _loginButton => _seleniumDriver.FindElement(By.Id("login-button"));
        private IWebElement _passwordField => _seleniumDriver.FindElement(By.Id("password"));
        private IWebElement _usernameField => _seleniumDriver.FindElement(By.Id("user-name"));

        private IWebElement _errorMessage => _seleniumDriver.FindElement(By.Id("login_button_container"));
        #endregion

        // Constructor that sets the driver to be the driver from the config
        public AP_HomePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        // Methods to interact with the web element
        public void VisitHomePage() => _seleniumDriver.Navigate().GoToUrl(_homePageUrl);
        public void ClickLoginButton() => _loginButton.Click();

        public void InputUsername(string username) => _usernameField.SendKeys(username);
        public void InputPassword(string password) => _passwordField.SendKeys(password);
        public void InputSigninCredentials(Credentials credentials)
        {
            _usernameField.SendKeys(credentials.Username);
            _passwordField.SendKeys(credentials.Password);
        }
        public string GetErrorMessage() => _errorMessage.Text;
    }
}
