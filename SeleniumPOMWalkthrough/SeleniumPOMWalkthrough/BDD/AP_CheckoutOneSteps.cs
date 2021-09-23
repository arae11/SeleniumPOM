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
        [When(@"I click the cancel button")]
        public void WhenIClickTheCancelButton()
        {
            AP_Website.AP_CheckoutStepOnePage.ClickCancelButton();
        }

        [Then(@"I should see an alert containing the error message ""(.*)""")]
        public void ThenIShouldSeeAnAlertContainingTheErrorMessage(string expected)
        {
            Assert.That(AP_Website.AP_CheckoutStepOnePage.GetErrorMessage(), Does.Contain(expected));
        }

        [Then(@"I am taken to the checkout step two page")]
        public void ThenIAmTakenToTheCheckoutStepTwoPage()
        {
            Assert.That(AP_Website.AP_CheckoutStepTwoPage.GetHeaderText(), Does.Contain("CHECKOUT: OVERVIEW"));
        }
    }
}
