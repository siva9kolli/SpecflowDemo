using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using SeleniumExtras.PageObjects;
using SpecflowDemoMac.CommonSeleniumActions;

namespace SpecflowDemoMac.Pages
{
    public class NaukriHomePage
    {
        public SeActions actions;

        public NaukriHomePage(AndroidDriver androidDriver)
        {
            PageFactory.InitElements(androidDriver, this);
            actions = new SeActions();
        }

        [FindsBy(How = How.XPath, Using = "//*[@text='Only this time']")]
        private IWebElement ProductsTitle;

      

 
        public Boolean IsProductsTilteDisplayed()
        {
            return ProductsTitle.Displayed;
        }
    }
}

