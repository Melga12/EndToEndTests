using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace EndToEndTests
{
    class BajerTests
    {
        public string DriverUrl = "http://127.0.0.1:4723/";
        public WindowsDriver<WindowsElement> DesktopSession;
        [SetUp]
        public void Setup()
        {
            if (DesktopSession == null)
            {
                AppiumOptions appiumOptions = new AppiumOptions();
                appiumOptions.AddAdditionalCapability("app", @"E:\Testy\ApiumTestsProject\ApiumTestsProject\ApiumTestsProject\bin\Debug\ApiumTestsProject.exe");
                appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");
                DesktopSession = new WindowsDriver<WindowsElement>(new Uri(DriverUrl), appiumOptions);
            }
            Assert.IsNotNull(DesktopSession);
        }
        [Test]
        public void CheckWelcome()
        {
            WindowsElement field = DesktopSession.FindElementByAccessibilityId("tbName");
            field.Clear();
            field.SendKeys("Gosia");
            var button = DesktopSession.FindElementByAccessibilityId("btnHello");
            button.Click();
            Thread.Sleep(1000);
            var info = DesktopSession.FindElementByAccessibilityId("lblHello");
            Assert.IsTrue(info.Text.Contains("Cześć"));
            Assert.Pass();
        }

        [Test]
        public void CheckWelcomeWithBajerForWoman()
        {
            WindowsElement field = DesktopSession.FindElementByAccessibilityId("tbName");
            field.Clear();
            field.SendKeys("Gosia");
            var bajer = DesktopSession.FindElementByAccessibilityId("chbBajer");
            bajer.Click();
            var button = DesktopSession.FindElementByAccessibilityId("btnHello");
            button.Click();
            Thread.Sleep(1000);
            var info = DesktopSession.FindElementByAccessibilityId("lblHello");
            Assert.IsTrue(info.Text.Contains("Cześć") && info.Text.Contains("laska"));
            Assert.Pass();
        }

        [Test]
        public void CheckWelcomeWithBajerForMan()
        {
            WindowsElement field = DesktopSession.FindElementByAccessibilityId("tbName");
            field.Clear();
            field.SendKeys("Kamil");
            var bajer = DesktopSession.FindElementByAccessibilityId("chbBajer");
            bajer.Click();
            var button = DesktopSession.FindElementByAccessibilityId("btnHello");
            button.Click();
            Thread.Sleep(1000);
            var info = DesktopSession.FindElementByAccessibilityId("lblHello");
            Assert.IsTrue(info.Text.Contains("Cześć") && info.Text.Contains("men"));
            Assert.Pass();
        }
    }
}
