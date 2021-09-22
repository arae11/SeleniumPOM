using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumPOMWalkthrough.lib.pages;
using TechTalk.SpecFlow;

namespace SeleniumPOMWalkthrough.BDD
{
    [Binding]
    [Scope(Feature = "AP_CheckoutOne")]
    public class AP_CheckoutOneSteps : AP_SharedSteps
    {
        [Given(@"I am on the first checkout page")]
        public void GivenIAmOnTheFirstCheckoutPage(Table table)
        {
            base.GivenIAmOnTheHomepage();
            base.GivenIEnterTheFollowingCredentials(table);
            base.WhenIEnterTheseCredentials();
            base.WhenIClickTheLoginButton();
            base.WhenIClickTheShoppingCartButton();
            base.WhenIClickCheckout();
        }
        
        [When(@"I click the continue button")]
        public void WhenIClickTheContinueButton()
        {
            AP_Website.AP_CheckoutStepOnePage.ClickContinueButton();
        }
        
        
    }
}
