using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumPOMWalkthrough.lib;
using TechTalk.SpecFlow.Assist;
using SeleniumPOMWalkthrough.lib.pages;
using SeleniumPOMWalkthrough.utils;

[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(8)]

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

        [Given(@"that I have logged in")]
        public void GivenThatIHaveLoggedIn(Table table)
        {
            GivenIAmOnTheHomepage();
            GivenIEnterTheFollowingCredentials(table);
            WhenIEnterTheseCredentials();
            WhenIClickTheLoginButton();
        }

        [Given(@"I am on the first checkout page")]
        public void GivenIAmOnTheFirstCheckoutPage(Table table)
        {
            GivenThatIHaveLoggedIn(table);
            WhenIClickTheShoppingCartButton();
            WhenIClickCheckout();
        }

        [Given(@"I am on the second checkout page")]
        public void GivenIAmOnTheSecondCheckoutPage(Table table)
        {
            GivenIAmOnTheFirstCheckoutPage(table);
        }

        [Given(@"I am on the checkout complete page")]
        public void GivenIAmOnTheCheckoutCompletePage(Table table)
        {
            GivenIAmOnTheFirstCheckoutPage(table);
        }

        [Given(@"I input this checkout information")]
        public void GivenIInputThisCheckoutInformation(Table table)
        {
            _checkoutInfo = table.CreateInstance<CheckoutInformation>();
            AP_Website.AP_CheckoutStepOnePage.InputCheckoutInformation(_checkoutInfo);
            WhenIClickTheContinueButton();
        }

        [When(@"I click add to cart on the backpack")]
        public void WhenIClickAddToCartOnTheBackpack()
        {
            AP_Website.AP_InventoryPage.ClickAddToCartBackpack();
        }

        [When(@"I enter the following checkout information")]
        public void WhenIEnterTheFollowingCheckoutInformation(Table table)
        {
            _checkoutInfo = table.CreateInstance<CheckoutInformation>();
            AP_Website.AP_CheckoutStepOnePage.InputCheckoutInformation(_checkoutInfo);
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

        [When(@"I click the continue button")]
        public void WhenIClickTheContinueButton()
        {
            AP_Website.AP_CheckoutStepOnePage.ClickContinueButton();
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

        [When(@"I click finish")]
        public void WhenIClickFinish()
        {
            AP_Website.AP_CheckoutStepTwoPage.ClickFinishButton();
        }

        [Then(@"I am taken to the products page")]
        public void ThenIShouldBeLoggedInAndSentToTheInventoryPage()
        {
            Assert.That(AP_Website.AP_InventoryPage.GetHeaderText(), Does.Contain("PRODUCTS"));
        }

        [Then(@"I am taken to my cart")]
        public void ThenIAmTakenToMyCart()
        {
            Assert.That(AP_Website.AP_CartPage.GetHeaderText(), Does.Contain("YOUR CART"));
        }

        [Then(@"I should be taken to the checkout completed page")]
        public void ThenIShouldBeTakenToTheCheckoutCompletedPage()
        {
            Assert.That(AP_Website.AP_CheckoutCompletePage.GetHeaderText(), Does.Contain("CHECKOUT: COMPLETE!"));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
        }
    }
}
