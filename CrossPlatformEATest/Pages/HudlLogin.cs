using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using EAAutoFramework.Base;
using EAAutoFramework.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;

namespace CrossPlatformEATest.Pages
{
    public class HudlLogin :BasePage
    {
        public HudlLogin(ParallelConfig parallelConfig) : base(parallelConfig)
        {

        }

        IWebElement UserNameElement => _parallelConfig.Driver.FindElementByXPath("//*[@id=\"email\"]");

        IWebElement PasswordElement => _parallelConfig.Driver.FindElementByXPath("//*[@id=\"password\"]");
        IWebElement LoginButton =>
            _parallelConfig.Driver.FindElementByXPath("//*[@id=\"logIn\"]");

        IWebElement tabTexts => _parallelConfig.Driver.FindElementByCssSelector(".text-wrapper .explore-tab-text");


        public void EnterUserName()
        {
            UserNameElement.SendKeys("singh.gagan22@yahoo.co.uk");

        }

        public void EnterPassword()
        {
            PasswordElement.SendKeys("Rohannirola@123");

        }

        public void ClickOnLoginButton()
        {
           
            LoginButton.Click();
            Thread.Sleep(5000);
        }

        public void UserIsLoggedInSuccessfully()
        {
            Assert.False(!tabTexts.Text.Contains("Feed"), "User is not logged In");
        }

    }
}
