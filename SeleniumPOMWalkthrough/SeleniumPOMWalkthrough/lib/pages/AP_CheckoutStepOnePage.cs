using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumPOMWalkthrough.lib.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough.lib.pages
{
    public class AP_CheckoutStepOnePage
    {
        private IWebDriver _seleniumDriver;

        public AP_CheckoutStepOnePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
    }
}
