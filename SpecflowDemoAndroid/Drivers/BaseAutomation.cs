using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Chrome;

namespace SpecflowDemoMac.Drivers
{
	public class BaseAndroid
	{
        public static AndroidDriver androidDriver;

        public static AndroidDriver LaunchAndroidApplication()
		{
            var appiumOptions = new AppiumOptions();
            appiumOptions.AutomationName = "UiAutomator2";
            appiumOptions.DeviceName = "emulator";
            appiumOptions.App = "/Users/shiva/Documents/SpecflowDemoAndroid/NoBroker.apk";
            appiumOptions.PlatformName = "Android";
            appiumOptions.PlatformVersion = "12.0";

            appiumOptions.AddAdditionalAppiumOption("appWaitActivity", "com.nobroker.app.*");

            androidDriver = new AndroidDriver(new Uri("http://127.0.0.1:4723"), appiumOptions);
            return androidDriver;
        }

		public static void killAndroidSession()
		{
            androidDriver.Quit();
        }
       
	}
}

