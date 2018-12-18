using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Threading;

namespace UnitTestProject.Selenium
{
    [TestClass]
    public class TestAddComment
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

        public void CommentWithLogin()
        {
            int headlineNewsIndex = 36;

            driver.Navigate().GoToUrl(appURL);

            driver.FindElements(By.CssSelector(".Buttonweb__ButtonWrapper-sc-1tj31rk-0.gIAhCv"))[1].Click();

            driver.SwitchTo().Window(driver.WindowHandles.Last());

            var inputEmail = driver.FindElement(By.Id("identifierId"));
            inputEmail.SendKeys("tyasamirasih28@gmail.com");

            driver.FindElement(By.Id("identifierNext")).Click();

            Thread.Sleep(3000);

            var inputPassword = driver.FindElements(By.CssSelector(".whsOnd.zHQkBf"))[0];
            inputPassword.SendKeys("Tyas12345!");

            driver.FindElement(By.Id("passwordNext")).Click();

            Thread.Sleep(3000);

            driver.SwitchTo().Window(driver.WindowHandles.First());

            Thread.Sleep(3000);

            driver.FindElements(By.ClassName("LabelLinkweb-g6i50g-0"))[headlineNewsIndex].Click();

            Thread.Sleep(3000);

            var inputComment = driver.FindElement(By.CssSelector(".notranslate.public-DraftEditor-content"));
            inputComment.SendKeys("Test Automation");

            driver.FindElement(By.CssSelector(".Commentweb__SubmitButton-sc-1dsz7gr-1.khUWGb")).Click();

            Thread.Sleep(3000);


        }

        [TestMethod]
        [TestCategory("Chrome")]

        public void CommentWithoutLogin()
        {
            int headlineNewsIndex = 36;

            driver.Navigate().GoToUrl(appURL);
            
            driver.FindElements(By.ClassName("LabelLinkweb-g6i50g-0"))[headlineNewsIndex].Click();

            Thread.Sleep(3000);

            var inputComment = driver.FindElement(By.CssSelector(".notranslate.public-DraftEditor-content"));
            inputComment.SendKeys("Test Automation");

            Thread.Sleep(3000);

            driver.FindElement(By.CssSelector(".Commentweb__SubmitButton-sc-1dsz7gr-1.khUWGb")).Click();

            Thread.Sleep(3000);

            string daftar = driver.FindElements(By.CssSelector(".Textweb__StyledText-sc-2upo8d-0.kJwucG"))[0].Text;

            string expectedTitle = "Masuk atau Daftar sekarang untuk";
            Assert.IsTrue(daftar.Contains(expectedTitle), daftar);

        }


        [TestCleanup]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}