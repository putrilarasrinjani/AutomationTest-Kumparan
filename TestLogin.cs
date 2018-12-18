using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Threading;

namespace UnitTestProject.Selenium
{
    [TestClass]
    public class TestLogin
    {

        private string appURL = "http://www.kumparan.com/";
        private IWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        [TestCategory("Chrome")]

        public void LoginSuccess()
        {
            driver.Navigate().GoToUrl(appURL);

            driver.FindElements(By.CssSelector(".Buttonweb__ButtonWrapper-sc-1tj31rk-0.gIAhCv"))[1].Click();

            string newWindowHandle = driver.WindowHandles.Last();
            var newWindow = driver.SwitchTo().Window(newWindowHandle);

            string expectedNewWindowTitle = "Masuk - Akun Google";
            Assert.AreEqual(expectedNewWindowTitle, newWindow.Title);

            var inputEmail = driver.FindElement(By.Id("identifierId"));
            inputEmail.SendKeys("tyasamirasih28@gmail.com");

            driver.FindElement(By.Id("identifierNext")).Click();

            Thread.Sleep(3000);

            var inputPassword = driver.FindElements(By.CssSelector(".whsOnd.zHQkBf"))[0];
            inputPassword.SendKeys("Tyas12345!");

            driver.FindElement(By.Id("passwordNext")).Click();

            driver.SwitchTo().Window(driver.WindowHandles.First());

            Thread.Sleep(3000);


        }

        [TestMethod]
        [TestCategory("Chrome")]

        public void LoginWithoutEmail()
        {
            driver.Navigate().GoToUrl(appURL);

            driver.FindElements(By.CssSelector(".Buttonweb__ButtonWrapper-sc-1tj31rk-0.gIAhCv"))[1].Click();

            string newWindowHandle = driver.WindowHandles.Last();
            var newWindow = driver.SwitchTo().Window(newWindowHandle);

            string expectedNewWindowTitle = "Masuk - Akun Google";
            Assert.AreEqual(expectedNewWindowTitle, newWindow.Title);

            driver.FindElement(By.Id("identifierNext")).Click();

            string validation = driver.FindElements(By.CssSelector(".dEOOab.RxsGPe"))[0].Text;

            string expectedTitle = "Masukkan email atau nomor telepon";
            Assert.IsTrue(validation.Contains(expectedTitle), validation);

            Thread.Sleep(3000);


        }


        [TestMethod]
        [TestCategory("Chrome")]

        public void LoginWithoutPassword()
        {
            driver.Navigate().GoToUrl(appURL);

            driver.FindElements(By.CssSelector(".Buttonweb__ButtonWrapper-sc-1tj31rk-0.gIAhCv"))[1].Click();

            string newWindowHandle = driver.WindowHandles.Last();
            var newWindow = driver.SwitchTo().Window(newWindowHandle);

            string expectedNewWindowTitle = "Masuk - Akun Google";
            Assert.AreEqual(expectedNewWindowTitle, newWindow.Title);

            var inputEmail = driver.FindElement(By.Id("identifierId"));
            inputEmail.SendKeys("tyasamirasih28@gmail.com");

            driver.FindElement(By.Id("identifierNext")).Click();

            Thread.Sleep(3000);

            driver.FindElement(By.Id("passwordNext")).Click();

            string validation = driver.FindElements(By.CssSelector(".dEOOab.RxsGPe"))[0].Text;

            string expectedTitle = "Masukkan sebuah password";
            Assert.IsTrue(validation.Contains(expectedTitle), validation);

            Thread.Sleep(3000);


        }

        [TestMethod]
        [TestCategory("Chrome")]

        public void LoginSuccessFacebook()
        {
            driver.Navigate().GoToUrl(appURL);

            driver.FindElements(By.CssSelector(".Buttonweb__ButtonWrapper-sc-1tj31rk-0.gIAhCv"))[0].Click();

            string newWindowHandle = driver.WindowHandles.Last();
            var newWindow = driver.SwitchTo().Window(newWindowHandle);

            string expectedNewWindowTitle = "Facebook";
            Assert.AreEqual(expectedNewWindowTitle, newWindow.Title);

            var inputEmail = driver.FindElement(By.Id("email"));
            inputEmail.SendKeys("tyasamirasih28@gmail.com");

            var inputPassword = driver.FindElement(By.Id("pass"));
            inputPassword.SendKeys("Tyas12345!");


            driver.FindElement(By.Id("u_0_0")).Click();

            Thread.Sleep(3000);

            driver.SwitchTo().Window(driver.WindowHandles.First());

        }

        [TestMethod]
        [TestCategory("Chrome")]

        public void LoginWithoutPasswordFacebook()
        {
            driver.Navigate().GoToUrl(appURL);

            driver.FindElements(By.CssSelector(".Buttonweb__ButtonWrapper-sc-1tj31rk-0.gIAhCv"))[0].Click();

            string newWindowHandle = driver.WindowHandles.Last();
            var newWindow = driver.SwitchTo().Window(newWindowHandle);

            string expectedNewWindowTitle = "Facebook";
            Assert.AreEqual(expectedNewWindowTitle, newWindow.Title);

            var inputEmail = driver.FindElement(By.Id("email"));
            inputEmail.SendKeys("tyasamirasih28@gmail.com");

            driver.FindElement(By.Id("u_0_0")).Click();

            Thread.Sleep(2000);

            string validate = driver.FindElement(By.Id("error_box")).FindElement(By.CssSelector(".fsl.fwb.fcb")).Text;

            string expectedTitle = "Silakan masukkan kembali sandi Anda";
            Assert.IsTrue(validate.Contains(expectedTitle), validate);

            Thread.Sleep(3000);

            driver.SwitchTo().Window(driver.WindowHandles.First());

        }

        [TestMethod]
        [TestCategory("Chrome")]

        public void LoginWithoutEmailFacebook()
        {

            driver.Navigate().GoToUrl(appURL);

            driver.FindElements(By.CssSelector(".Buttonweb__ButtonWrapper-sc-1tj31rk-0.gIAhCv"))[0].Click();

            string newWindowHandle = driver.WindowHandles.Last();
            var newWindow = driver.SwitchTo().Window(newWindowHandle);

            string expectedNewWindowTitle = "Facebook";
            Assert.AreEqual(expectedNewWindowTitle, newWindow.Title);

            var inputPassword = driver.FindElement(By.Id("pass"));
            inputPassword.SendKeys("Tyas12345!");

            driver.FindElement(By.Id("u_0_0")).Click();

            Thread.Sleep(2000);

            string validate = driver.FindElement(By.Id("error_box")).FindElement(By.CssSelector(".fsl.fwb.fcb")).Text;


            string expectedTitle = "Email atau nomor telepon salah";
            Assert.IsTrue(validate.Contains(expectedTitle), validate);

            Thread.Sleep(3000);

            driver.SwitchTo().Window(driver.WindowHandles.First());

        }

        [TestMethod]
        [TestCategory("Chrome")]

        public void LoginWithoutEmailPasswordFacebook()
        {
            driver.Navigate().GoToUrl(appURL);

            driver.FindElements(By.CssSelector(".Buttonweb__ButtonWrapper-sc-1tj31rk-0.gIAhCv"))[0].Click();

            string newWindowHandle = driver.WindowHandles.Last();
            var newWindow = driver.SwitchTo().Window(newWindowHandle);

            string expectedNewWindowTitle = "Facebook";
            Assert.AreEqual(expectedNewWindowTitle, newWindow.Title);

            driver.FindElement(By.Id("u_0_0")).Click();

            Thread.Sleep(2000);

            string validate = driver.FindElement(By.Id("error_box")).FindElement(By.CssSelector(".fsl.fwb.fcb")).Text;

            string expectedTitle = "Email atau nomor telepon salah";
            Assert.IsTrue(validate.Contains(expectedTitle), validate);

            Thread.Sleep(3000);

            driver.SwitchTo().Window(driver.WindowHandles.First());

        }


        [TestCleanup]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }

    }
}