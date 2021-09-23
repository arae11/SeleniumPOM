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
        [Then(@"the shopping cart number increases")]
        public void ThenTheShoppingCartNumberIncreases()
        {
            Assert.That(AP_Website.AP_InventoryPage.ShoppingCartNumber, Is.EqualTo("1")); 
        }
    }
}