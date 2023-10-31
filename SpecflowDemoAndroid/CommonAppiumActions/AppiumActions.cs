using System;
using OpenQA.Selenium;

namespace SpecflowDemoMac.CommonSeleniumActions
{
    public class SeActions
    {
        public void ClickOnElement(IWebElement element)
        {
            element.Click();
        }

        public void TypeValue(IWebElement element, string data)
        {
            element.SendKeys(data);
        }
    }
}

