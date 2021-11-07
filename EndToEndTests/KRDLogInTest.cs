using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace EndToEndTests
{
    class KRDLogInTest
    {

        IWebDriver driver;
        [SetUp]
        public void Initilaize()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www3.krd.pl/Client2.0/Authentication/Login?ReturnUrl=%2fClient2.0%2f#_ga=2.66379182.1414453411.1631708766-1391755914.1581948976";
            Assert.IsTrue(driver.WindowHandles.Count == 1);
        }

        [Test]
        public void ChceckToLogIn()
        {
            var eMail = driver.FindElement(By.Id("LoginName"));
            eMail.Clear();
            eMail.SendKeys("m12345@gmail.com");
            var pass = driver.FindElement(By.Id("Password"));
            pass.Clear();
            pass.SendKeys("Meg1234!");
            var button = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/form/div[2]/div[2]/div/span/span[2]"));
            button.Click();
            Assert.Pass();
        }

        [Test]
        public void ChceckToLogInWithoutEmail()
        {
            var eMail = driver.FindElement(By.Id("LoginName"));
            eMail.Clear();
            eMail.SendKeys("");
            var pass = driver.FindElement(By.Id("Password"));
            pass.Clear();
            pass.SendKeys("Meg1234!");
            var button = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/form/div[2]/div[2]/div/span/span[2]"));
            button.Click();
            Assert.Pass();
        }

        [Test]
        public void ChceckToLogInWithoutInvalidEmail()
        {
            var eMail = driver.FindElement(By.Id("LoginName"));
            eMail.Clear();
            eMail.SendKeys("m12345@gmail");
            var pass = driver.FindElement(By.Id("Password"));
            pass.Clear();
            pass.SendKeys("Meg1234!");
            var button = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/form/div[2]/div[2]/div/span/span[2]"));
            button.Click();
            Assert.Pass();
        }

        [Test]
        public void ChceckToLogInWithoutPassword()
        {
            var eMail = driver.FindElement(By.Id("LoginName"));
            eMail.Clear();
            eMail.SendKeys("m12345@gmail.com");
            var pass = driver.FindElement(By.Id("Password"));
            pass.Clear();
            pass.SendKeys("");
            var button = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/form/div[2]/div[2]/div/span/span[2]"));
            button.Click();
            Assert.Pass();
        }

        [Test]
        public void ChceckToLogInWithInvalidPassword()
        {
            var eMail = driver.FindElement(By.Id("LoginName"));
            eMail.Clear();
            eMail.SendKeys("m12345@gmail.com");
            var pass = driver.FindElement(By.Id("Password"));
            pass.Clear();
            pass.SendKeys("meg123");
            var button = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/form/div[2]/div[2]/div/span/span[2]"));
            button.Click();
            Assert.Pass();
        }

        [Test]
        public void ChceckToLogInWhenACustomerForgetsHisPassword()
        {
            var eMail = driver.FindElement(By.Id("LoginName"));
            eMail.Clear();
            eMail.SendKeys("m12345@gmail.com");
            var pass = driver.FindElement(By.Id("Password"));
            pass.Clear();
            pass.SendKeys("");
            var forgetPassword = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/form/div[1]/div/a"));
            forgetPassword.Click();
            var login = driver.FindElement(By.Id("LoginName"));
            login.Clear();
            login.SendKeys("meg5");
            var phoneNumber = driver.FindElement(By.Id("TrustedPhone"));
            phoneNumber.Clear();
            phoneNumber.SendKeys("696296453");
            var button = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/form/div[3]/div[2]/span/span[2]"));
            button.Click();
            Assert.Pass();
        }

        [Test]
        public void ChceckToLogInWhenACustomerForgetsHisPasswordWithoutLoginName()
        {
            var eMail = driver.FindElement(By.Id("LoginName"));
            eMail.Clear();
            eMail.SendKeys("m12345@gmail.com");
            var pass = driver.FindElement(By.Id("Password"));
            pass.Clear();
            pass.SendKeys("");
            var forgetPassword = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/form/div[1]/div/a"));
            forgetPassword.Click();
            var login = driver.FindElement(By.Id("LoginName"));
            login.Clear();
            login.SendKeys("");
            var phoneNumber = driver.FindElement(By.Id("TrustedPhone"));
            phoneNumber.Clear();
            phoneNumber.SendKeys("696296453");
            var button = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/form/div[3]/div[2]/span/span[2]"));
            button.Click();
            Assert.Pass();
        }

        [Test]
        public void ChceckToLogInWhenACustomerForgetsHisPasswordWithoutTrustedPhone()
        {
            var eMail = driver.FindElement(By.Id("LoginName"));
            eMail.Clear();
            eMail.SendKeys("m12345@gmail.com");
            var pass = driver.FindElement(By.Id("Password"));
            pass.Clear();
            pass.SendKeys("");
            var forgetPassword = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/form/div[1]/div/a"));
            forgetPassword.Click();
            var login = driver.FindElement(By.Id("LoginName"));
            login.Clear();
            login.SendKeys("meg5");
            var phoneNumber = driver.FindElement(By.Id("TrustedPhone"));
            phoneNumber.Clear();
            phoneNumber.SendKeys("");
            var button = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/form/div[3]/div[1]/span/span[2]"));
            button.Click();
            Assert.Pass();
        }

        [Test]
        public void ChceckToLogInWhenACustomerForgetsHisPasswordWithoutLoginNameAndTrustedPhone()
        {
            var eMail = driver.FindElement(By.Id("LoginName"));
            eMail.Clear();
            eMail.SendKeys("m12345@gmail.com");
            var pass = driver.FindElement(By.Id("Password"));
            pass.Clear();
            pass.SendKeys("");
            var forgetPassword = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/form/div[1]/div/a"));
            forgetPassword.Click();
            var login = driver.FindElement(By.Id("LoginName"));
            login.Clear();
            login.SendKeys("");
            var phoneNumber = driver.FindElement(By.Id("TrustedPhone"));
            phoneNumber.Clear();
            phoneNumber.SendKeys("");
            var button = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/form/div[3]/div[1]/span/span[2]"));
            button.Click();
            Assert.Pass();
        }

        [Test]
        public void ChceckToLogInWhenACustomerForgetsHisPasswordCancellationOfCommand()
        {
            var eMail = driver.FindElement(By.Id("LoginName"));
            eMail.Clear();
            eMail.SendKeys("m12345@gmail.com");
            var pass = driver.FindElement(By.Id("Password"));
            pass.Clear();
            pass.SendKeys("");
            var forgetPassword = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/form/div[1]/div/a"));
            forgetPassword.Click();
            var button = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/form/div[3]/div[1]/span/span[2]"));
            button.Click();
            Assert.Pass();
        }

        [Test]
        public void ChceckToLogInWhenACustomerForgetsHisPasswordWithConsultantAssistance()
        {
            var eMail = driver.FindElement(By.Id("LoginName"));
            eMail.Clear();
            eMail.SendKeys("m12345@gmail.com");
            var pass = driver.FindElement(By.Id("Password"));
            pass.Clear();
            pass.SendKeys("");
            var forgetPassword = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/form/div[1]/div/a"));
            forgetPassword.Click();
            var button1 = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/a"));
            button1.Click();
            Assert.Pass();
        }

        [TearDown]
        public void CloseWindow()
        {
            driver.Close();
        }
    }
}
