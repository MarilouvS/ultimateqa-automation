using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ultimateqa_automation
{
    [TestClass]
    [TestCategory("MenuBarNavigation")]
    public class NavigationTests : BaseTest
    {
        HomePage startingPoint;
        Navigation menuBar;
        SimpleInteractionsPage simpleInteractionsPageInstance;

        [Description("Using the Menu Bar To Navigate")]
        [TestMethod]
        public void UsingLearningMenuTabToNavigateToComplicatedPage()
        {
            startingPoint = new HomePage(Driver);
            startingPoint.GoToHomePage();
            menuBar = new Navigation(Driver);
            menuBar.MoveToLearningTab();
            menuBar.AutomationExcercisesTab.Click();
            menuBar.SimpleElementInteractionsLink.Click();
            simpleInteractionsPageInstance = new SimpleInteractionsPage(Driver);
            Assert.AreEqual("This section has really simple HTML elements so that you can understand their basic nature. Feel free to practice your test automation on these elements.", simpleInteractionsPageInstance.SimpleInteractionsPageHeader.Text);

        }
    }
}
