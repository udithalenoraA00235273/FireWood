using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FireWoodIntegrationTest
{
    [TestClass]
    public class ProductTypesTest : TestBase
    {
        [TestMethod]
        public void ToTestWeatherUserGoingToSaveNullProductTypes()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Admin/ProductTypes/Create");
            _webDriver.FindElement(By.Id("ProductType")).SendKeys("");
            _webDriver.FindElement(By.CssSelector(".btn-primary")).Click();

            var output = _webDriver.FindElement(By.XPath("//span[@class='text-danger field-validation-error']"));

            Assert.AreEqual("The Product Type field is required.", output.Text);
        }
        [TestMethod]
        public void ToTestWeatherTheNewProductTypeSaved()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Admin/ProductTypes/Create");
            _webDriver.FindElement(By.Id("ProductType")).SendKeys("Small Products");
            _webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            var URL = _webDriver.Url;

            Assert.AreEqual(URL, "https://localhost:44330/Admin/ProductTypes");
        }

        [TestMethod]
        public void ToTestWeatherTheProductTypesCanEdit()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Admin/ProductTypes/Edit/7");
            _webDriver.FindElement(By.Id("ProductType")).SendKeys("Update Product");
            _webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            var URL = _webDriver.Url;

            Assert.AreEqual(URL, "https://localhost:44330/Admin/ProductTypes");
        }
        [TestMethod]
        public void ToTestDetailsProductTypeCanBeAccess()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Admin/ProductTypes");
            _webDriver.FindElement(By.ClassName("btn-group"));
            _webDriver.FindElement(By.CssSelector(".btn-success")).Click();

            var URL = _webDriver.Url;

            Assert.AreEqual(URL, "https://localhost:44330/Admin/ProductTypes/Details/7");


        }
        [TestMethod]
        public void ToTestWeatherProductTypeDeleteOptionWorks()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Admin/ProductTypes/Delete/11");
            _webDriver.FindElement(By.CssSelector(".btn-danger")).Click();
            var URL = _webDriver.Url;

            Assert.AreEqual(URL, "https://localhost:44330/Admin/ProductTypes");
        }
    }
}
