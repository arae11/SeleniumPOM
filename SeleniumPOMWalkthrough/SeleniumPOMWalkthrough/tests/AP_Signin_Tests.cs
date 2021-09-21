//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using SeleniumPOMWalkthrough.lib.pages;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SeleniumPOMWalkthrough.tests
//{
//    public class AP_Signin_Tests
//    {
//        /* Instantiate our pages in our tests
//        These classes will include the functions for the page.
//        Notice - NO USING STATEMENTS!*/

//        public AP_Website<ChromeDriver> AP_Website = new AP_Website<ChromeDriver>();

//        [Test]
//        public void GivenIAmOnTheHomePage_WhenISigninWithValidCredentials_ThenIShouldAppearInTheCustomerPortal()
//        {
//            // Navigate to the AP home page
//            AP_Website.AP_HomePage.VisitHomePage();
//            AP_Website.AP_HomePage.InputUsername("standard_user");
//            AP_Website.AP_HomePage.InputPassword("secret_sauce");
//            AP_Website.AP_HomePage.ClickLoginButton();
//            Assert.That(AP_Website.SeleniumDriver.Url, Does.Contain("inventory"));
//        }

//        [Test]
//        public void GivenIAmOnTheHomePage_WhenISigninWithValidUsernameButNoPassword_ThenIShouldGetTheCorrectErrorMessage()
//        {
//            // Navigate to the AP home page
//            AP_Website.AP_HomePage.VisitHomePage();
//            AP_Website.AP_HomePage.InputUsername("standard_user");
//            AP_Website.AP_HomePage.InputPassword("");
//            AP_Website.AP_HomePage.ClickLoginButton();
//            Assert.That(AP_Website.AP_HomePage.GetErrorMessage(), Is.EqualTo("Epic sadface: Password is required"));
//        }

//        [Test]
//        public void GivenIAmOnTheHomePage_WhenISigninWithInvalidPasswordButValidUsername_ThenIShouldGetTheCorrectErrorMessage()
//        {
//            // Navigate to the AP home page
//            AP_Website.AP_HomePage.VisitHomePage();
//            AP_Website.AP_HomePage.InputUsername("standard_user");
//            AP_Website.AP_HomePage.InputPassword("hello");
//            AP_Website.AP_HomePage.ClickLoginButton();
//            Assert.That(AP_Website.AP_HomePage.GetErrorMessage(), Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
//        }

//        [Test]
//        public void GivenIAmOnTheHomePage_WhenISigninWithNoCredentials_ThenIShouldGetTheCorrectErrorMessage()
//        {
//            // Navigate to the AP home page
//            AP_Website.AP_HomePage.VisitHomePage();
//            AP_Website.AP_HomePage.InputUsername("");
//            AP_Website.AP_HomePage.InputPassword("");
//            AP_Website.AP_HomePage.ClickLoginButton();
//            Assert.That(AP_Website.AP_HomePage.GetErrorMessage(), Is.EqualTo("Epic sadface: Username is required"));
//        }

//        [OneTimeTearDown]
//        public void CleanUp()
//        {
//            // Quits the driver and closes every associated window
//            AP_Website.SeleniumDriver.Quit();
//            // Release and manage resources
//            AP_Website.SeleniumDriver.Dispose();
//        }
//    }
//}
