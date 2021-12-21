using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FireWoodIntegrationTest
{
    [TestClass]
    public class ProductsTest
    {

        public IWebDriver _webDriver;
        [TestInitialize]
        public void StartUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
        }
        [TestMethod]
        public void ToTestCreateProducts()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Admin/Products/Create");
            _webDriver.FindElement(By.ClassName("col-5"));
        }
        [TestMethod]
        public void ToTestEditProducts()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Admin/Products/Edit");


        }
        [TestMethod]
        public void ToTestDetailsProducts()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Admin/Products/Details");


        }
        [TestMethod]
        public void ToTestDeleteProducts()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Admin/Products/Delete");


        }


        [TestCleanup]
        public void ShutDown()
        {
            _webDriver.Quit();
        }
    }
}
