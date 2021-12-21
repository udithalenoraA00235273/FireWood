using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FireWoodIntegrationTest
{
    [TestClass]
    public class TitleCheck
    {
        private IWebDriver _webDriver;

        [TestInitialize]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
        }
        [TestMethod]
        public void TitleShouldEqualFireWood()
        {
           
        }

        [TestCleanup]
        public void Teardown()
        {
            _webDriver.Quit();
        }
    }
}
