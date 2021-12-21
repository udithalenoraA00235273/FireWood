using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FireWoodIntegrationTest
{
    [TestClass]
    public class UserLoginTest : TestBase
    {

        [TestMethod]
        public void ToValidateTheEmailAddressIsTrue()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Identity/Account/Login");
            _webDriver.FindElement(By.Id("Input_Email")).SendKeys("Testing");
            _webDriver.FindElement(By.CssSelector(".btn-primary")).Click();

            var output = _webDriver.FindElement(By.Id("Input_Email-error"));

            Assert.AreEqual("The Email field is not a valid e-mail address.", output.Text);

        } 
    }
}
