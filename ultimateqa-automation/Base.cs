using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimateqa_automation
{
    internal class Base
    {
        protected IWebDriver Driver { get; set;  }
        protected WebDriverWait Wait { get; set; }
        public Base(IWebDriver driver) 
        {
            Driver = driver;
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

    }
}
