using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumPOMWalkthrough.lib.pages;
using TechTalk.SpecFlow;

namespace SeleniumPOMWalkthrough.BDD
{
    [Binding]
    [Scope(Feature = "AP_Cart")]
    public class AP_CartSteps : AP_SharedSteps
    {
        [Given(@"I am on the cart page")]
        public void GivenIAmOnTheCartPage(Table table)
        {
            base.GivenIAmOnTheHomepage();
            base.GivenIEnterTheFollowingCredentials(table);
            base.WhenIEnterTheseCredentials();
            base.WhenIClickTheLoginButton();
            base.WhenIClickTheShoppingCartButton();
        }
        
        [Then(@"I am taken to the checkout page")]
        public void ThenIAmTakenToTheCheckoutPage()
        {
            Assert.That(AP_Website.SeleniumDriver.Url, Does.Contain("checkout-step-one"));
        }

        [When(@"I click continue shopping")]
        public void WhenIClickContinueShopping()
        {
            AP_Website.AP_CartPage.ClickContinueShopping();
        }
    }
}
