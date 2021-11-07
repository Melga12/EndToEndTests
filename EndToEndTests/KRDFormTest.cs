using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace EndToEndTests
{
    class KRDFormTest
    {
        IWebDriver driver;
        [SetUp]
        public void Initilaize()
        {
            driver = new ChromeDriver();
            driver.Url = "https://zgloszenie.krd.pl/lead?lid=10000&source=https://krd.pl/oferta/sprawdzanie-siebie#_ga=2.156764281.352479351.1636031345-1463240092.1636031345";
            Assert.IsTrue(driver.WindowHandles.Count == 1);
        }

        [Test]
        public void ChceckToFormSubmission()
        {
            var yourCompanyName = driver.FindElement(By.Id("field-01"));
            yourCompanyName.Clear();
            yourCompanyName.SendKeys("test");
            var yourCompanyNip = driver.FindElement(By.Id("field-04"));
            yourCompanyNip.Clear();
            yourCompanyNip.SendKeys("5840352123");
            var yourPhoneNumber = driver.FindElement(By.Id("field-02"));
            yourPhoneNumber.Clear();
            yourPhoneNumber.SendKeys("696296453");
            var yourEmail = driver.FindElement(By.Id("field-03"));
            yourEmail.Clear();
            yourEmail.SendKeys("test@gmail.com");
            var checkbox1 = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[1]/fieldset[2]/div/div[1]/label"));
            checkbox1.Click();
            var checkbox2 = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[1]/fieldset[2]/div/div[2]/label"));
            checkbox2.Click();
            var button = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[2]/button"));
            button.Click();
            Assert.Pass();
        }

        [Test]
        public void ChceckToFormSubmissionWithoutCompanyName()
        {
            var yourCompanyName = driver.FindElement(By.Id("field-01"));
            yourCompanyName.Clear();
            yourCompanyName.SendKeys("");
            var yourCompanyNip = driver.FindElement(By.Id("field-04"));
            yourCompanyNip.Clear();
            yourCompanyNip.SendKeys("5840352123");
            var yourPhoneNumber = driver.FindElement(By.Id("field-02"));
            yourPhoneNumber.Clear();
            yourPhoneNumber.SendKeys("696296453");
            var yourEmail = driver.FindElement(By.Id("field-03"));
            yourEmail.Clear();
            yourEmail.SendKeys("test@gmail.com");
            var checkbox1 = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[1]/fieldset[2]/div/div[1]/label"));
            checkbox1.Click();
            var checkbox2 = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[1]/fieldset[2]/div/div[2]/label"));
            checkbox2.Click();
            var button = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[2]/button"));
            button.Click();
            Assert.Pass();
        }

        [Test]
        public void ChceckToFormSubmissionWithoutCompanyNip()
        {
            var yourCompanyName = driver.FindElement(By.Id("field-01"));
            yourCompanyName.Clear();
            yourCompanyName.SendKeys("test");
            var yourCompanyNip = driver.FindElement(By.Id("field-04"));
            yourCompanyNip.Clear();
            yourCompanyNip.SendKeys("");
            var yourPhoneNumber = driver.FindElement(By.Id("field-02"));
            yourPhoneNumber.Clear();
            yourPhoneNumber.SendKeys("696296453");
            var yourEmail = driver.FindElement(By.Id("field-03"));
            yourEmail.Clear();
            yourEmail.SendKeys("test@gmail.com");
            var checkbox1 = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[1]/fieldset[2]/div/div[1]/label"));
            checkbox1.Click();
            var checkbox2 = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[1]/fieldset[2]/div/div[2]/label"));
            checkbox2.Click();
            var button = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[2]/button"));
            button.Click();
            Assert.Pass();
        }

        [Test]
        public void ChceckToFormSubmissionWithoutPhoneNumber()
        {
            var yourCompanyName = driver.FindElement(By.Id("field-01"));
            yourCompanyName.Clear();
            yourCompanyName.SendKeys("test");
            var yourCompanyNip = driver.FindElement(By.Id("field-04"));
            yourCompanyNip.Clear();
            yourCompanyNip.SendKeys("5840352123");
            var yourPhoneNumber = driver.FindElement(By.Id("field-02"));
            yourPhoneNumber.Clear();
            yourPhoneNumber.SendKeys("");
            var yourEmail = driver.FindElement(By.Id("field-03"));
            yourEmail.Clear();
            yourEmail.SendKeys("test@gmail.com");
            var checkbox1 = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[1]/fieldset[2]/div/div[1]/label"));
            checkbox1.Click();
            var checkbox2 = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[1]/fieldset[2]/div/div[2]/label"));
            checkbox2.Click();
            var button = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[2]/button"));
            button.Click();
            Assert.Pass();
        }

        [Test]
        public void ChceckToFormSubmissionWithoutEmail()
        {
            var yourCompanyName = driver.FindElement(By.Id("field-01"));
            yourCompanyName.Clear();
            yourCompanyName.SendKeys("test");
            var yourCompanyNip = driver.FindElement(By.Id("field-04"));
            yourCompanyNip.Clear();
            yourCompanyNip.SendKeys("5840352123");
            var yourPhoneNumber = driver.FindElement(By.Id("field-02"));
            yourPhoneNumber.Clear();
            yourPhoneNumber.SendKeys("696296453");
            var yourEmail = driver.FindElement(By.Id("field-03"));
            yourEmail.Clear();
            yourEmail.SendKeys("");
            var checkbox1 = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[1]/fieldset[2]/div/div[1]/label"));
            checkbox1.Click();
            var checkbox2 = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[1]/fieldset[2]/div/div[2]/label"));
            checkbox2.Click();
            var button = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[2]/button"));
            button.Click();
            Assert.Pass();
        }

        [Test]
        public void ChceckToFormSubmissionWithoutCheckBox1()
        {
            var yourCompanyName = driver.FindElement(By.Id("field-01"));
            yourCompanyName.Clear();
            yourCompanyName.SendKeys("test");
            var yourCompanyNip = driver.FindElement(By.Id("field-04"));
            yourCompanyNip.Clear();
            yourCompanyNip.SendKeys("5840352123");
            var yourPhoneNumber = driver.FindElement(By.Id("field-02"));
            yourPhoneNumber.Clear();
            yourPhoneNumber.SendKeys("696296453");
            var yourEmail = driver.FindElement(By.Id("field-03"));
            yourEmail.Clear();
            yourEmail.SendKeys("test@gmail.com");
            var checkbox2 = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[1]/fieldset[2]/div/div[2]/label"));
            checkbox2.Click();
            var button = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[2]/button"));
            button.Click();
            Assert.Pass();
        }

        [Test]
        public void ChceckToFormSubmissionWithoutCheckbox2()
        {
            var yourCompanyName = driver.FindElement(By.Id("field-01"));
            yourCompanyName.Clear();
            yourCompanyName.SendKeys("test");
            var yourCompanyNip = driver.FindElement(By.Id("field-04"));
            yourCompanyNip.Clear();
            yourCompanyNip.SendKeys("5840352123");
            var yourPhoneNumber = driver.FindElement(By.Id("field-02"));
            yourPhoneNumber.Clear();
            yourPhoneNumber.SendKeys("696296453");
            var yourEmail = driver.FindElement(By.Id("field-03"));
            yourEmail.Clear();
            yourEmail.SendKeys("test@gmail.com");
            var checkbox1 = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[1]/fieldset[2]/div/div[1]/label"));
            checkbox1.Click();
            var button = driver.FindElement(By.XPath("/html/body/div[1]/section/div/form/div[2]/button"));
            button.Click();
            Assert.Pass();
        }

        [TearDown]
        public void CloseWindow()
        {
            driver.Close();
        }
    }
}

