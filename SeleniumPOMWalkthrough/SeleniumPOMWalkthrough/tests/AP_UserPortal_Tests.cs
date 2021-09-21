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
//    public class AP_UserPortal_Tests
//    {
//        public AP_Website<ChromeDriver> AP_Website = new AP_Website<ChromeDriver>();

//        [Test]
//        public void WhenIAmOnTheInventoryPage_WhenIClickTheBasketIcon_ThenIShouldBeAbleToViewMyCart()
//        {
//            AP_Website.AP_HomePage.VisitHomePage();
//            AP_Website.AP_HomePage.InputUsername("standard_user");
//            AP_Website.AP_HomePage.InputPassword("secret_sauce");
//            AP_Website.AP_HomePage.ClickLoginButton();
//            AP_Website.AP_InventoryPage.ClickShoppingCartButton();
//            var result = AP_Website.AP_InventoryPage.GetHeaderText();
//            Assert.That(result, Does.Contain("YOUR CART"));
//        }

//        [Test]
//        public void WhenIAmOnTheInventoryPage_WhenIClickAddToCart_ThenTheNumberOfItemsInTheCartIsUpdated()
//        {
//            AP_Website.AP_HomePage.VisitHomePage();
//            AP_Website.AP_HomePage.InputUsername("standard_user");
//            AP_Website.AP_HomePage.InputPassword("secret_sauce");
//            AP_Website.AP_HomePage.ClickLoginButton();

//            AP_Website.AP_InventoryPage.ClickAddToCartBackpack();
//            Assert.That(AP_Website.AP_InventoryPage.ShoppingCartNumber, Is.EqualTo("1"));
//        }

//        [Test]
//        public void WhenIAmOnTheInventoryPage_WhenIClickAddToCartTwice_ThenTheNumberOfItemsInTheCartIsUpdated()
//        {
//            AP_Website.AP_HomePage.VisitHomePage();
//            AP_Website.AP_HomePage.InputUsername("standard_user");
//            AP_Website.AP_HomePage.InputPassword("secret_sauce");
//            AP_Website.AP_HomePage.ClickLoginButton();

//            AP_Website.AP_InventoryPage.ClickAddToCartBackpack();
//            AP_Website.AP_InventoryPage.ClickAddToCartBike();
//            Assert.That(AP_Website.AP_InventoryPage.ShoppingCartNumber, Is.EqualTo("2"));
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
