using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace FireWoodIntegrationTest
{
    [TestClass]
    public class CustomerUiTest : TestBase
    {
        [TestMethod]
        public void ToTestWeatherUserCanAccessProductMoreInfoPage()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/");
            _webDriver.FindElement(By.CssSelector(".btn-light")).Click();
            var URL = _webDriver.Url;

            Assert.AreEqual(URL, "https://localhost:44330/Customer/Home/Detail/6");
        }
    }
}
