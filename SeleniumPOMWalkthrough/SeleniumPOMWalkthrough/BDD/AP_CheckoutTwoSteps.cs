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
    [Scope(Feature = "AP_CheckoutTwo")]
    public class AP_CheckoutTwoSteps : AP_SharedSteps
    {
        [When(@"I click the cancel button")]
        public void WhenIClickTheCancelButton()
        {
            AP_Website.AP_CheckoutStepTwoPage.ClickCancelButton();
        }
    }
}
