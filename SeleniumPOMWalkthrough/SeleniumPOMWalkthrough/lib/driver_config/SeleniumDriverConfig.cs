using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumPOMWalkthrough.lib.driver_config
{
    public class SeleniumDriverConfig<T> where T : IWebDriver, new()
    {
        public IWebDriver Driver { get; set; }

        // Constructor which calls a method to set up the driver depending on the browser we want
        public SeleniumDriverConfig(int pageLoadInSecs, int implicitWaitInSec)
        {
            Driver = new T();
            DriverSetUp(pageLoadInSecs, implicitWaitInSec);
        }

        public void DriverSetUp(int pageLoadInSecs, int implicitWaitInSec)
        {
            // This is the time the driver will wait fort the page to load
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInSecs);

            // This is the time the driver waits for the element before the test fails
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSec);
        }

        public void SetHeadlessChromeBrowser()
        {
            Driver = new T();
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("headless");
        }
    }
}
