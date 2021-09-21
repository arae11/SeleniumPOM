using System;
using System.Configuration;

namespace SeleniumPOMWalkthrough
{
    // This class is created to be a global reader for the app.congif attributes
    public static class AppConfigReader
    {
        public static readonly string BaseURL = ConfigurationManager.AppSettings["base_url"];
        public static readonly string InventoryPageURL = ConfigurationManager.AppSettings["inventorypage_url"];
        public static readonly string CartPageURL = ConfigurationManager.AppSettings["cartpage_url"];
        public static readonly string CheckoutOnePageURL = ConfigurationManager.AppSettings["checkoutonepage_url"];
    }
}
