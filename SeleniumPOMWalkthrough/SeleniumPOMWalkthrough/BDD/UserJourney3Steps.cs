using System;
using TechTalk.SpecFlow;

namespace SeleniumPOMWalkthrough.BDD
{
    [Binding]
    [Scope(Feature = "UserJourney3")]
    public class UserJourney3Steps : AP_SharedSteps
    {        
        [When(@"I click remove on the backpack")]
        public void WhenIClickRemoveOnTheBackpack()
        {
            AP_Website.AP_CartPage.RemoveItemBackpack();
        }
    }
}
