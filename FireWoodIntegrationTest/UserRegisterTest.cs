using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FireWoodIntegrationTest
{
    [TestClass]
    public class UserRegisterTest
    {

        public IWebDriver _webDriver;
        [TestInitialize]
        public void StartUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
        }
        [TestMethod]
        public void ToTestRegisterUser()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Identity/Account/Register");
    
        }
        

        [TestCleanup]
        public void ShutDown()
        {
            _webDriver.Quit();
        }
    }
}
