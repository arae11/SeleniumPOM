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
    public class AP_SigninSteps
    {
        public AP_Website<ChromeDriver> AP_Website { get; } = new AP_Website<ChromeDriver>();
        private Credentials _credentials;

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
        
        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            AP_Website.AP_HomePage.ClickLoginButton();
        }

        [When(@"I enter these credentials")]
        public void WhenIEnterTheseCredentials()
        {
            AP_Website.AP_HomePage.InputSigninCredentials(_credentials);
        }

        [Then(@"I should see an alert containing the error message ""(.*)""")]
        public void ThenIShouldSeeAnAlertContainingTheErrorMessage(string expected)
        {
            Assert.That(AP_Website.AP_HomePage.GetErrorMessage(), Does.Contain(expected));
        }

        [Then(@"I should be logged in and sent to the inventory page")]
        public void ThenIShouldBeLoggedInAndSentToTheInventoryPage()
        {
            Assert.That(AP_Website.SeleniumDriver.Url, Does.Contain("inventory"));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
