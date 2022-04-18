using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace HT_1
{
    class HT_1
    {
        [Test]
        public void FirstTest()
        {
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.google.com.ua/imghp");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

            var searchBox = driver.FindElement(By.Name("q"));
            var searchButton = driver.FindElement(By.ClassName("Tg7LZd"));

            searchBox.SendKeys("cheese");
            searchButton.Click();
            Assert.IsTrue(driver.FindElement(By.Id("islrg")).Displayed);
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Test.png", ScreenshotImageFormat.Png);

            driver.Quit();
        }
    }
}