using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace testMBA.selenium
{
    /// <summary>
    /// Description résumée pour Selenium
    /// </summary>
    [TestClass]
    public class Selenium
    {
        IWebDriver driver = new FirefoxDriver();
        [TestMethod]
        public void instantiateSelenium()
        {
            driver.Url = "http://localhost/compteBancaire";

        }

        [TestMethod]
        public void toolsQA()
        {
            driver.Url = "localhost/compteBancaire";
            IWebElement creationPageTitle = driver.FindElement(By.CssSelector("h1"));
            IWebElement CreationPageButton = driver.FindElement(By.Id("creationPageButton"));
            IWebElement CreditPageButton = driver.FindElement(By.Id("creditPageButton"));
            IWebElement DebitPageButton = driver.FindElement(By.Id("debitPageButton"));

            Assert.AreEqual("Page de création", creationPageTitle);
            driver.Quit();


        }

     
    }
}
