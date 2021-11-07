using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace EndToEndTests
{
    class SportTests
    {
        IWebDriver driver;
        [SetUp]
        public void Initilaize()
        {
            driver = new ChromeDriver();
            driver.Url = "https://lamp.ii.us.edu.pl/~mtdyd/zawody/";
            Assert.IsTrue(driver.WindowHandles.Count == 1);
        }
        #region Adult
        [Test]
        public void CheckAddToAdultToMinimumAge()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Gosia");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Herzog");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2002");
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Dorosly"));
        }

        [Test]
        public void CheckAddToAdultToMaximumAge()
        {
            var firstName = driver.FindElement(By.Id("inputEmail3"));
            firstName.Clear();
            firstName.SendKeys("Gosia");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Herzog");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("03-11-1956");
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Dorosly"));
        }
        #endregion
        #region Senior
        [Test]
        public void CheckAddToSeniorToMinimumAge()
        {
            var firstName = driver.FindElement(By.Id("inputEmail3"));
            firstName.Clear();
            firstName.SendKeys("Kasia");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Senior");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("31-12-1955");
            var doctorAgree = driver.FindElement(By.Id("lekarz"));
            doctorAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Senior"));
        }

        [Test]
        public void CheckAddToSeniorToMinimumAgeWithoutDoctorAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Kasia");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Senior");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("31-12-1955");
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }
        #endregion
        #region Junior
        [Test]
        public void CheckAddToJuniorToMinimumAge()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Magda");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Junior");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2006");
            var parentsAgree = driver.FindElement(By.Id("rodzice"));
            parentsAgree.Click();
            var doctorAgree = driver.FindElement(By.Id("lekarz"));
            doctorAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Junior"));
        }

        [Test]
        public void CheckAddToJuniorToMaximumAge()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Magda");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Junior");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2003");
            var parentsAgree = driver.FindElement(By.Id("rodzice"));
            parentsAgree.Click();
            var doctorAgree = driver.FindElement(By.Id("lekarz"));
            doctorAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Junior"));
        }

        [Test]
        public void CheckAddToJuniorToMinimumAgeWithoutParentsAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Magda");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Junior");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2006");
            var doctorAgree = driver.FindElement(By.Id("lekarz"));
            doctorAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }

        [Test]
        public void CheckAddToJuniorToMinimumAgeWithoutDoctorAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Magda");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Junior");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2006");
            var parentsAgree = driver.FindElement(By.Id("rodzice"));
            parentsAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }

        [Test]
        public void CheckAddToJuniorToMaximumAgeWithoutDoctorAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Magda");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Junior");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2003");
            var parentsAgree = driver.FindElement(By.Id("rodzice"));
            parentsAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }

        [Test]
        public void CheckAddToJuniorToMaximumAgeWithoutParentsAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Magda");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Junior");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2003");
            var doctorAgree = driver.FindElement(By.Id("lekarz"));
            doctorAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }

        [Test]
        public void CheckAddToJuniorToMinimumAgeWithoutParentsAndDoctorAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Magda");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Junior");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2006");
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }

        [Test]
        public void CheckAddToJuniorToMaximumAgeWithoutParentsAndDoctorAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Magda");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Junior");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2003");
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }
        #endregion
        #region Colt
        [Test]
        public void CheckAddToColtToMinimumAge()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Kamil");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Młody");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2008");
            var parentsAgree = driver.FindElement(By.Id("rodzice"));
            parentsAgree.Click();
            var doctorAgree = driver.FindElement(By.Id("lekarz"));
            doctorAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Mlodzik"));
        }

        [Test]
        public void CheckAddToColtToMaximumAge()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Kamil");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Młody");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2007");
            var parentsAgree = driver.FindElement(By.Id("rodzice"));
            parentsAgree.Click();
            var doctorAgree = driver.FindElement(By.Id("lekarz"));
            doctorAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Mlodzik"));
        }

        [Test]
        public void CheckAddToColtToMinimumAgeWithoutParentsAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Kamil");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Młody");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2008");
            var doctorAgree = driver.FindElement(By.Id("lekarz"));
            doctorAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }

        [Test]
        public void CheckAddToColtToMinimumAgeWithoutDoctorAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Kamil");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Młody");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2008");
            var parentsAgree = driver.FindElement(By.Id("rodzice"));
            parentsAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }

        [Test]
        public void CheckAddToColtToMaximumAgeWithoutDoctorAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Kamil");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Młody");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2007");
            var parentsAgree = driver.FindElement(By.Id("rodzice"));
            parentsAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }

        [Test]
        public void CheckAddToColtToMaximumAgeWithoutParentsAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Kamil");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Młody");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2007");
            var doctorAgree = driver.FindElement(By.Id("lekarz"));
            doctorAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }

        [Test]
        public void CheckAddToColtToMinimumAgeWithoutParentsAndDoctorAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Kamil");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Młody");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2008");
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }

        [Test]
        public void CheckAddToColtToMaximumAgeWithoutParentsAndDoctorAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Kamil");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Młody");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2007");
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }
        #endregion
        #region Pixie
        [Test]
        public void CheckAddToPixieToMinimumAge()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Maciek");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Skrzat");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2010");
            var parentsAgree = driver.FindElement(By.Id("rodzice"));
            parentsAgree.Click();
            var doctorAgree = driver.FindElement(By.Id("lekarz"));
            doctorAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Skrzat"));
        }

        [Test]
        public void CheckAddToPixieToMaximumAge()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Maciek");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Skrzat");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2009");
            var parentsAgree = driver.FindElement(By.Id("rodzice"));
            parentsAgree.Click();
            var doctorAgree = driver.FindElement(By.Id("lekarz"));
            doctorAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Skrzat"));
        }

        [Test]
        public void CheckAddToPixieToMinimumAgeWithoutParentsAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Maciek");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Skrzat");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2010");
            var doctorAgree = driver.FindElement(By.Id("lekarz"));
            doctorAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }

        [Test]
        public void CheckAddToColtToPixieMinimumAgeAgeWithoutDoctorAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Maciek");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Skrzat");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2010");
            var parentsAgree = driver.FindElement(By.Id("rodzice"));
            parentsAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }

        [Test]
        public void CheckAddToPixieToMaximumAgeWithoutDoctorAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Maciek");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Skrzat");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2009");
            var parentsAgree = driver.FindElement(By.Id("rodzice"));
            parentsAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }

        [Test]
        public void CheckAddToPixieToMaximumAgeWithoutParentsAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Maciek");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Skrzat");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2009");
            var doctorAgree = driver.FindElement(By.Id("lekarz"));
            doctorAgree.Click();
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }

        [Test]
        public void CheckAddToPixieToMinimumAgeWithoutParentsAndDoctorAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Maciek");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Skrzat");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2010");
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }

        [Test]
        public void CheckAddToPixieToMaximumAgeWithoutParentsAndDoctorAgreement()
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys("Maciek");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Skrzat");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-2009");
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var info = driver.FindElement(By.Id("returnSt"));
            Assert.IsTrue(info.Text.Contains("Blad danych"));
        }
        #endregion
        [Test]
        public void CheckAddWithoutDateOfBirth()
        {
            var firstName = driver.FindElement(By.Id("inputEmail3"));
            firstName.Clear();
            firstName.SendKeys("Gosia");
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Herzog");
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            Assert.IsTrue(driver.SwitchTo().Alert().Text.Contains("Data urodzenia nie moze byc pusta"));
            driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void CheckAddWithoutName()
        {
            var firstName = driver.FindElement(By.Id("inputEmail3"));
            firstName.Clear();
            firstName.SendKeys("Gosia");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-1965");
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            Assert.IsTrue(driver.SwitchTo().Alert().Text.Contains("Nazwisko musi byc wypelnione"));
            driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void CheckAddWithoutFirstName()
        {
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys("Herzog");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("29-11-1965");
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            button.Click();
            Assert.IsTrue(driver.SwitchTo().Alert().Text.Contains("First name must be filled out"));
            driver.SwitchTo().Alert().Accept();
        }

        [TearDown]
        public void CloseWindow()
        {
            driver.Close();
        }
    }
}
