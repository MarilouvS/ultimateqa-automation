using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ultimateqa_automation.MenuBarConstants;

namespace ultimateqa_automation
{
    internal class Navigation : Base
    {
        public Navigation(IWebDriver driver) : base(driver) { }
        public IWebElement LearningTab => Driver.FindElement(By.XPath(MenuBarLearningTabXPath));
        public IWebElement AutomationExcercisesTab => Driver.FindElement(By.XPath(MenuBarAutomationExcercisesTabXPath));
        public IWebElement SimpleElementInteractionsLink => Driver.FindElement(By.XPath(InteractionsWithSimpleElementsLinkXPath));


        public void MoveToLearningTab()
        {
            Actions.MoveToElement(LearningTab).Perform();
        }

    }

    sealed class MenuBarConstants
    {
        public static readonly string MenuBarLearningTabXPath = "//ul[@id='menu-home-page-menu']//a[@href='https://ultimateqa.com/learning/']";
        public static readonly string MenuBarAutomationExcercisesTabXPath = "//ul[@id='menu-home-page-menu']//a[@href='https://ultimateqa.com/automation/']";
        public static readonly string InteractionsWithSimpleElementsLinkXPath = "//a[@href='../simple-html-elements-for-automation/']";
    }

}
