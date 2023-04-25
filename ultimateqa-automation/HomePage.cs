using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimateqa_automation
{
    internal class HomePage : Base
    {
        public HomePage(IWebDriver driver) : base(driver) { }
        public void GoToHomePage() => Driver.Navigate().GoToUrl("https://ultimateqa.com/");
    }
}
