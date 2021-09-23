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
    [Scope(Feature = "AP_CheckoutComplete")]
    public class AP_CheckoutCompleteSteps : AP_SharedSteps
    {
        [Given(@"I click finish")]
        public void GivenIClickFinish()
        {
            AP_Website.AP_CheckoutStepTwoPage.ClickFinishButton();
        }

        [When(@"I click the back home button")]
        public void WhenIClickTheBackHomeButton()
        {
            AP_Website.AP_CheckoutCompletePage.ClickHomeButton();
        }
    }
}
