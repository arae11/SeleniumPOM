using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumPOMWalkthrough.lib.pages;
using TechTalk.SpecFlow;

namespace SeleniumPOMWalkthrough.BDD
{
    [Binding]
    [Scope(Feature = "AP_Inventory")]
    public class AP_InventorySteps : AP_SharedSteps
    {
        [Given(@"that I have logged in with the following credentials")]
        public void GivenThatIHaveLoggedInWithTheFollowingCredentials(Table table)
        {
            base.GivenIAmOnTheHomepage();
            base.GivenIEnterTheFollowingCredentials(table);
            base.WhenIEnterTheseCredentials();
            base.WhenIClickTheLoginButton();
            base.ThenIShouldBeLoggedInAndSentToTheInventoryPage();
        }

        [When(@"I click add to cart on the backpack")]
        public void WhenIClickAddToCartOnTheBackpack()
        {
            AP_Website.AP_InventoryPage.ClickAddToCartBackpack();
        }

        [Then(@"the shopping cart number increases")]
        public void ThenTheShoppingCartNumberIncreases()
        {
            Assert.That(AP_Website.AP_InventoryPage.ShoppingCartNumber, Is.EqualTo("1")); 
        }

        [Then(@"I am taken to my cart")]
        public void ThenIAmTakenToMyCart()
        {
            var result = AP_Website.AP_InventoryPage.GetHeaderText();
            Assert.That(result, Does.Contain("YOUR CART"));
        }
    }
}