using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumPOMWalkthrough.lib;
using TechTalk.SpecFlow.Assist;
using SeleniumPOMWalkthrough.lib.pages;
using SeleniumPOMWalkthrough.utils;

namespace SeleniumPOMWalkthrough.BDD
{
    [Binding]
    public class AP_InventorySteps
    {
        public AP_Website<ChromeDriver> AP_Website { get; } = new AP_Website<ChromeDriver>();
        private Credentials _credentials;

        [Given(@"I enter these credentials")]
        public void GivenIEnterTheseCredentials()
        {
            AP_Website.AP_HomePage.InputSigninCredentials(_credentials);
        }
        
        [Given(@"I click the login button")]
        public void GivenIClickTheLoginButton()
        {
            AP_Website.AP_HomePage.ClickLoginButton();
        }
        
        [When(@"I click add to basket")]
        public void WhenIClickAddToBasket()
        {
            AP_Website.AP_InventoryPage.ClickAddToCartBackpack();
        }
        
        [Then(@"the shopping cart number increases by (.*)")]
        public void ThenTheShoppingCartNumberIncreasesBy(int p0)
        {
            Assert.That(AP_Website.AP_InventoryPage.ShoppingCartNumber, Is.EqualTo("1"));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
