using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static ultimateqa_automation.FormPageConstants;

namespace ultimateqa_automation
{
    internal class FormPage : Base
    {
        public FormPage(IWebDriver driver) : base(driver) { }

        public void GoToFormPage() => Driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");

        public IWebElement NameInput => Driver.FindElement(By.Id(NameInputId));
        public IWebElement MessageInput => Driver.FindElement(By.Id(MessageInputId));
        public IWebElement CaptchaSubmitButton => Driver.FindElement(By.XPath(CaptchaSubmitButtonXPath));
        public IWebElement CaptchaInput => Driver.FindElement(By.XPath(CaptchaInputXPath));

        public IWebElement SuccessMessageCaptchaForm => Wait.Until(webDriver => {
            var element = webDriver.FindElement(By.XPath(SuccessMessageXPath));

            if (string.IsNullOrEmpty(element.Text))
                return null;

            return element;
        });

        private string SolveCaptcha()
        {
            var capchaMath = Convert.ToInt32(CaptchaInput.GetAttribute(FirstCaptchaDigitAttributeName)) + Convert.ToInt32(CaptchaInput.GetAttribute(SecondCaptchaDigitAttributeName));
            return capchaMath.ToString();
        }

        public void SolveAndCompleteCaptcha()
        {
            CaptchaInput.SendKeys(SolveCaptcha());
            Thread.Sleep(1000);
        }
    }

    sealed class FormPageConstants
    {
        public static readonly string NameInputId = "et_pb_contact_name_1";
        public static readonly string MessageInputId = "et_pb_contact_message_1";
        public static readonly string CaptchaSubmitButtonXPath = "//*[@id='et_pb_contact_form_1']//button";
        public static readonly string CaptchaInputXPath = "//input[@class= 'input et_pb_contact_captcha']";
        public static readonly string SuccessMessageXPath = "//*[@id='et_pb_contact_form_1']//p";
        public static readonly string FirstCaptchaDigitAttributeName = "data-first_digit";
        public static readonly string SecondCaptchaDigitAttributeName = "data-second_digit";
    }
}
