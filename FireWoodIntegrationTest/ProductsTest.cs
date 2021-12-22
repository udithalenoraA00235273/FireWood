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
        public void ToTestWeatherUserGoingToSaveNullProducts()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Admin/Products/Create");
            _webDriver.FindElement(By.Id("Name")).SendKeys("");
            _webDriver.FindElement(By.CssSelector(".btn-primary")).Click();

            var output = _webDriver.FindElement(By.XPath("//span[@class='text-danger field-validation-error']"));

            Assert.AreEqual("The Name field is required.", output.Text);
        }

        [TestMethod]           
        public void ToTestWeatherTheProductDetailsCanEdit()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Admin/Products/Edit/6");
            _webDriver.FindElement(By.Id("Name")).SendKeys("Update Name");
            _webDriver.FindElement(By.CssSelector(".btn-primary")).Click();
            var URL = _webDriver.Url;

            Assert.AreEqual(URL, "https://localhost:44330/Admin/Products");


        }
       
        // This test isn't working because for some reason my file paths are not configured accordingly for products controller
        // I will be really greatful if you can assist me with that file path thing.
       [TestMethod]
        public void ToTestDeleteProducts()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Admin/Products/Delete/10");
            _webDriver.FindElement(By.CssSelector(".btn-danger")).Click();
            var URL = _webDriver.Url;

            Assert.AreEqual(URL, "https://localhost:44330/Admin/Products");

        }
    }
}
