using System;
using OpenQA.Selenium;
using SpecflowDemoMac.Drivers;
using TechTalk.SpecFlow;

namespace SpecflowDemoAndroid.Hooks
{
    [Binding]
    public class Hooks: BaseAndroid
    {
        [BeforeFeature]
        public static void OpenApplication()
        {
           var androidD =  LaunchAndroidApplication();
            androidD.FindElement(By.XPath("//*[@text='Continue']")).Click();
            
        }

        [AfterFeature]
        public static void CleanSession()
        {
           killAndroidSession();
        }
    }
}

