using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace ultimateqa_automation
{
    [TestClass]
    [TestCategory("FillingInFormsTests")]
    public class FormTests : BaseTest
    {
        FormPage formPageInstance;

        [TestInitialize]
        public void SetupBeforeFormTest() 
        {
            formPageInstance = new FormPage(Driver);
            formPageInstance.GoToFormPage();
        }

        [Description("Filling in the form with the captcha on UltimateQA website")]
        [TestMethod]
        public void FormWithCaptcha()
        {         
            formPageInstance.NameInput.SendKeys("Awesome Tester");
            formPageInstance.MessageInput.SendKeys("Louis: suig my tollie");
            formPageInstance.SolveAndCompleteCaptcha();
            formPageInstance.CaptchaSubmitButton.Click();
            Assert.AreEqual("Thanks for contacting us", formPageInstance.SuccessMessageCaptchaForm.Text);
        }
    }
}
