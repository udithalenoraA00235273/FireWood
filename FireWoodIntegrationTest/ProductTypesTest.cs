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

            var output = _webDriver.FindElement(By.XPath("//span[@class='text-danger field-validation-error']"));

            Assert.AreEqual("The Product Type field is required.", output.);
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
    }
}
