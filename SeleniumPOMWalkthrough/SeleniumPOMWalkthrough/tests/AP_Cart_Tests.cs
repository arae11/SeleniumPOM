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
//    public class AP_Cart_Tests
//    {
//        public AP_Website<ChromeDriver> AP_Website = new AP_Website<ChromeDriver>();

//        [Test]
//        public void WhenIAmOnTheCartPage_WhenIClickContinueShopping_ThenIAmTakenBackToTheInventoryPage()
//        {
//            AP_Website.AP_HomePage.VisitHomePage();
//            AP_Website.AP_HomePage.InputUsername("standard_user");
//            AP_Website.AP_HomePage.InputPassword("secret_sauce");
//            AP_Website.AP_HomePage.ClickLoginButton();

//            AP_Website.AP_InventoryPage.ClickAddToCartBackpack();
//            AP_Website.AP_InventoryPage.ClickShoppingCartButton();

//            AP_Website.AP_CartPage.ClickContinueShopping();
//            Assert.That(AP_Website.SeleniumDriver.Url, Does.Contain("inventory"));
//        }     
        
//        [Test]
//        public void WhenIAmOnTheCartPage_WhenIClickCheckout_ThenIAmTakenToTheCheckoutPage()
//        {
//            AP_Website.AP_HomePage.VisitHomePage();
//            AP_Website.AP_HomePage.InputUsername("standard_user");
//            AP_Website.AP_HomePage.InputPassword("secret_sauce");
//            AP_Website.AP_HomePage.ClickLoginButton();

//            AP_Website.AP_InventoryPage.ClickAddToCartBackpack();
//            AP_Website.AP_InventoryPage.ClickShoppingCartButton();

//            AP_Website.AP_CartPage.ClickCheckout();
//            Assert.That(AP_Website.SeleniumDriver.Url, Does.Contain("checkout-step-one"));
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
