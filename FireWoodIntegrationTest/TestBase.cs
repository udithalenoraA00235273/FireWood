using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FireWoodIntegrationTest
{
    // I Use this class to avoid duplication and it's easy to make a change for the web browser
    public class TestBase
    {
        protected IWebDriver _webDriver;
        [TestInitialize]
        public void StartUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
        }

        [TestCleanup]
        public void ShutDown()
        {
            _webDriver.Quit();
        }
    }
}
