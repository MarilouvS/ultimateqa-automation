using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace ultimateqa_automation
{
    [TestClass]
    public class BaseTest
    {
        public IWebDriver Driver { get; set; }

        [TestInitialize]
        public void SetupBeforeEveryTest()
        {
            Driver = new ChromeDriver();
        }
    }
}
