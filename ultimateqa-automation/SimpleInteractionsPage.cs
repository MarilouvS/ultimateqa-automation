using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ultimateqa_automation.SimpleInteractionsPageConstants;

namespace ultimateqa_automation
{
    internal class SimpleInteractionsPage : Base
    {
        public SimpleInteractionsPage(IWebDriver driver) : base(driver) { }

        public IWebElement SimpleInteractionsPageHeader => Driver.FindElement(By.XPath(SimpleInteractionsPageHeaderXPath));
    }
    sealed class SimpleInteractionsPageConstants
    {
        public static readonly string SimpleInteractionsPageHeaderXPath = "//*[@id='post-909']//h3";
    }
}
