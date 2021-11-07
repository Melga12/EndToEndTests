using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace EndToEndTests
{
    class CalculatorTests
    {
        public string DriverUrl = "http://127.0.0.1:4723/";
        public WindowsDriver<WindowsElement> DesktopSession;
        [SetUp]
        public void Setup()
        {
            if (DesktopSession == null)

            {
                AppiumOptions appiumOptions = new AppiumOptions();
                
                appiumOptions.AddAdditionalCapability("app", @"Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
                appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");
                DesktopSession = new WindowsDriver<WindowsElement>(new Uri(DriverUrl), appiumOptions);
            }

            Assert.IsNotNull(DesktopSession);
        }

        [Test]
        public void CheckAdd()

        {
            WindowsElement button1 = DesktopSession.FindElementByAccessibilityId("num7Button");
            button1.Click();
            WindowsElement button2 = DesktopSession.FindElementByAccessibilityId("plusButton");
            button2.Click();
            WindowsElement button3 = DesktopSession.FindElementByAccessibilityId("num1Button");
            button3.Click();
            WindowsElement button4 = DesktopSession.FindElementByAccessibilityId("equalButton");
            button4.Click();
            var field = DesktopSession.FindElementByAccessibilityId("CalculatorResults");
            Assert.IsTrue(field.Text.Contains("8"));
            Assert.Pass();

        }
    }

}

