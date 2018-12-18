using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace UnitTestProject.Selenium
{
    [TestClass]
    public class TestViewNews
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

        public void ClickNewsFromHome()
        {
            int headlineNewsIndex = 36;

            driver.Navigate().GoToUrl(appURL);

            string url = driver.FindElements(By.CssSelector(".LabelLinkweb-g6i50g-0.cujMCf"))[headlineNewsIndex].GetAttribute("href");

            driver.Navigate().GoToUrl(url);

            Thread.Sleep(3000);

        }

        [TestMethod]
        [TestCategory("Chrome")]

        public void ClickNewsFromTrending()
        {
            int indexTrending = 1;
            int headlineNewsIndex = 30;

            driver.Navigate().GoToUrl(appURL);

            Thread.Sleep(3000);

            string trendingURL = driver.FindElements(By.CssSelector(".ListItemweb__Item-sc-1x1jqof-0.ezBswX.LabelLinkweb-g6i50g-0"))[indexTrending].GetAttribute("href");
            driver.Navigate().GoToUrl(trendingURL);

            Thread.Sleep(3000);

            string url = driver.FindElements(By.CssSelector(".LabelLinkweb-g6i50g-0.cujMCf"))[headlineNewsIndex].GetAttribute("href");

            driver.Navigate().GoToUrl(url);

            Thread.Sleep(3000);

        }

        [TestMethod]
        [TestCategory("Chrome")]

        public void ClickNewsFromVideo()
        {
            int indexTrending = 2;
            int headlineNewsIndex = 30;

            driver.Navigate().GoToUrl(appURL);

            Thread.Sleep(3000);

            string trendingURL = driver.FindElements(By.CssSelector(".ListItemweb__Item-sc-1x1jqof-0.ezBswX.LabelLinkweb-g6i50g-0"))[indexTrending].GetAttribute("href");
            driver.Navigate().GoToUrl(trendingURL);

            Thread.Sleep(3000);

            string url = driver.FindElements(By.CssSelector(".LabelLinkweb-g6i50g-0.cujMCf"))[headlineNewsIndex].GetAttribute("href");

            driver.Navigate().GoToUrl(url);

            Thread.Sleep(3000);

        }

        [TestMethod]
        [TestCategory("Chrome")]

        public void ClickNewsFromLiputanKhusus()
        {
            int indexTrending = 3;
            int headlineNewsIndex = 30;

            driver.Navigate().GoToUrl(appURL);

            Thread.Sleep(3000);

            string trendingURL = driver.FindElements(By.CssSelector(".ListItemweb__Item-sc-1x1jqof-0.ezBswX.LabelLinkweb-g6i50g-0"))[indexTrending].GetAttribute("href");
            driver.Navigate().GoToUrl(trendingURL);

            Thread.Sleep(3000);

            string url = driver.FindElements(By.CssSelector(".LabelLinkweb-g6i50g-0.cujMCf"))[headlineNewsIndex].GetAttribute("href");

            driver.Navigate().GoToUrl(url);

            Thread.Sleep(3000);

        }

        [TestMethod]
        [TestCategory("Chrome")]

        public void ClickNewsFromKontenSpesial()
        {
            int indexTrending = 4;
            int headlineNewsIndex = 30;

            driver.Navigate().GoToUrl(appURL);

            Thread.Sleep(3000);

            string trendingURL = driver.FindElements(By.CssSelector(".ListItemweb__Item-sc-1x1jqof-0.ezBswX.LabelLinkweb-g6i50g-0"))[indexTrending].GetAttribute("href");
            driver.Navigate().GoToUrl(trendingURL);

            Thread.Sleep(3000);

            string url = driver.FindElements(By.CssSelector(".LabelLinkweb-g6i50g-0.cujMCf"))[headlineNewsIndex].GetAttribute("href");

            driver.Navigate().GoToUrl(url);

            Thread.Sleep(3000);

        }

        [TestMethod]
        [TestCategory("Chrome")]

        public void ClickNewsFromGaleriFoto()
        {
            int indexTrending = 5;
            int headlineNewsIndex = 30;

            driver.Navigate().GoToUrl(appURL);

            Thread.Sleep(3000);

            string trendingURL = driver.FindElements(By.CssSelector(".ListItemweb__Item-sc-1x1jqof-0.ezBswX.LabelLinkweb-g6i50g-0"))[indexTrending].GetAttribute("href");
            driver.Navigate().GoToUrl(trendingURL);

            Thread.Sleep(3000);

            string url = driver.FindElements(By.CssSelector(".LabelLinkweb-g6i50g-0.cujMCf"))[headlineNewsIndex].GetAttribute("href");

            driver.Navigate().GoToUrl(url);

            Thread.Sleep(3000);

        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}