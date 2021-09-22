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
    public class AP_SharedSteps
    {
        public AP_Website<ChromeDriver> AP_Website { get; } = new AP_Website<ChromeDriver>();
        private Credentials _credentials;
        private CheckoutInformation _checkoutInfo;

        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            AP_Website.AP_HomePage.VisitHomePage();
        }

        [Given(@"I enter the following credentials")]
        public void GivenIEnterTheFollowingCredentials(Table table)
        {
            _credentials = table.CreateInstance<Credentials>();
        }

        [When(@"I enter valid checkout information")]
        public void WhenIEnterValidCheckoutInformation(Table table)
        {
            _checkoutInfo = table.CreateInstance<CheckoutInformation>();
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            AP_Website.AP_HomePage.ClickLoginButton();
        }

        [When(@"I click checkout")]
        public void WhenIClickCheckout()
        {
            AP_Website.AP_CartPage.ClickCheckout();
        }

        [When(@"I enter these credentials")]
        public void WhenIEnterTheseCredentials()
        {
            AP_Website.AP_HomePage.InputSigninCredentials(_credentials);
        }

        [When(@"I click the shopping cart button")]
        public void WhenIClickTheShoppingCartButton()
        {
            AP_Website.AP_InventoryPage.ClickShoppingCartButton();
        }

        [Then(@"I should be logged in and sent to the inventory page")]
        public void ThenIShouldBeLoggedInAndSentToTheInventoryPage()
        {
            Assert.That(AP_Website.SeleniumDriver.Url, Does.Contain("inventory"));
        }

        [Then(@"I should be taken to the checkout step two page")]
        public void ThenIShouldBeTakenToTheCheckoutStepTwoPage()
        {
            Assert.That(AP_Website.AP_CheckoutStepOnePage.GetHeaderText(), Does.Contain("CHECKOUT: YOUR INFORMATION"));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
