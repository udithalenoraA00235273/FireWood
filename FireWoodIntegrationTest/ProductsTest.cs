using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FireWoodIntegrationTest
{
    [TestClass]
    public class ProductsTest : TestBase
    {
        [TestMethod]
        public void ToTestCreateProducts()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Admin/Products/Create");
            
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
    }
}
