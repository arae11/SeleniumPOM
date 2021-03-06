using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumPOMWalkthrough.lib.driver_config;

namespace SeleniumPOMWalkthrough.lib.pages
{
    // Super class - essentially a service object for all pages
    public class AP_Website<T> where T : IWebDriver, new()
    {
        #region
        // Properties - accessing POs and Selenium driver
        public IWebDriver SeleniumDriver { get; set; }
        public AP_HomePage AP_HomePage { get; set; }
        public AP_InventoryPage AP_InventoryPage { get; set; }
        public AP_CartPage AP_CartPage { get; set; }
        public AP_CheckoutStepOnePage AP_CheckoutStepOnePage { get; set; }
        public AP_CheckoutStepTwoPage AP_CheckoutStepTwoPage { get; set; }
        public AP_CheckoutCompletePage AP_CheckoutCompletePage { get; set; }
        #endregion

        // Constructor for driver and config for the service
        public AP_Website(int pageLoadInSecs = 10, int implicitWaitInSecs = 10)
        {
            // Instantiate the driver
            SeleniumDriver = new SeleniumDriverConfig<T>(pageLoadInSecs, implicitWaitInSecs).Driver;

            // Instantiate our PO with the selenium driver
            AP_HomePage = new AP_HomePage(SeleniumDriver);
            AP_InventoryPage = new AP_InventoryPage(SeleniumDriver);
            AP_CartPage = new AP_CartPage(SeleniumDriver);
            AP_CheckoutStepOnePage = new AP_CheckoutStepOnePage(SeleniumDriver);
            AP_CheckoutStepTwoPage = new AP_CheckoutStepTwoPage(SeleniumDriver);
            AP_CheckoutCompletePage = new AP_CheckoutCompletePage(SeleniumDriver);
        }

        // Delete cookies
        public void DeleteCookies() => SeleniumDriver.Manage().Cookies.DeleteAllCookies();
    }
}
