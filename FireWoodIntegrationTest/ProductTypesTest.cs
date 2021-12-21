using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FireWoodIntegrationTest
{
    [TestClass]
    public class ProductTypesTest
    {

        public IWebDriver _webDriver;
        [TestInitialize]
        public void StartUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
        }
        [TestMethod]
        public void ToTestCreateProductType()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Admin/ProductTypes/Create");
            _webDriver.FindElement(By.ClassName("col-5"));            
        }
        [TestMethod]
        public void ToTestEditProductType()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Admin/ProductTypes/Edit");
           

        }
        [TestMethod]
        public void ToTestDetailsProductType()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Admin/ProductTypes/Details");
           

        }
        [TestMethod]
        public void ToTestDeleteProductType()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Admin/ProductTypes/Delete");
       

        }


        [TestCleanup]
        public void ShutDown()
        {
            _webDriver.Quit();
        }
    }
}
