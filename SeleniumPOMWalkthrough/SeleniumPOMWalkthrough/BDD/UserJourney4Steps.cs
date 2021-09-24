using System;
using TechTalk.SpecFlow;

namespace SeleniumPOMWalkthrough.BDD
{
    [Binding]
    [Scope(Feature = "UserJourney4")]
    public class UserJourney4Steps : AP_SharedSteps
    {        
        [When(@"I sort the items by price \(low to high\)")]
        public void WhenISortTheItemsByPriceLowToHigh()
        {
            AP_Website.AP_InventoryPage.SortByPriceAscending();
        }
        
        [When(@"I click add to cart on the cheapest item")]
        public void WhenIClickAddToCartOnTheCheapestItem()
        {
            AP_Website.AP_InventoryPage.ClickAddToCartOnesie();
        }
    }
}
