using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FireWoodIntegrationTest
{
    [TestClass]
    public class UserRegisterTest : TestBase
    {
        [TestMethod]
        public void ToTestPassowrdContainsMinimumCharacters()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Identity/Account/Register");
            _webDriver.FindElement(By.Id("Input_Email")).SendKeys("uditha_a@live.com");
            _webDriver.FindElement(By.Id("Input_Password")).SendKeys("AAAA");
            _webDriver.FindElement(By.CssSelector(".btn-primary")).Click();

            var output = _webDriver.FindElement(By.Id("Input_Password-error"));

            Assert.AreEqual("The Password must be at least 6 and at max 100 characters long.", output.Text);

        }

        [TestMethod]
        public void ToTestConfirmPasswordMatchesTheInitialPassword()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:44330/Identity/Account/Register");
            _webDriver.FindElement(By.Id("Input_Email")).SendKeys("uditha_a@live.com");
            _webDriver.FindElement(By.Id("Input_Password")).SendKeys("AaBNMKASJDSAD");
            _webDriver.FindElement(By.Id("Input_Password")).SendKeys("AASdsdasca");
            _webDriver.FindElement(By.CssSelector(".btn-primary")).Click();


            var output = _webDriver.FindElement(By.Id("Input_ConfirmPassword-error"));

            Assert.AreEqual("The password and confirmation password do not match.", output.Text);
        }
    }
}
