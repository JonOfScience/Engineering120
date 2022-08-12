using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_TestAutomationFramework.lib.pages
{
    // FOURTH
    public class AP_SigninPage
    {
        #region Properties and fields
        private IWebDriver _seleniumDriver;
        private string _signinPageUrl = AppConfigReader.SignInPageUrl;
        private IWebElement _emailField => _seleniumDriver.FindElement(By.Id("email"));
        private IWebElement _passwordField => _seleniumDriver.FindElement(By.Id("passwd"));
        private IWebElement _signInLink => _seleniumDriver.FindElement(By.CssSelector("#SubmitLogin"));
        #endregion
        public AP_SigninPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        #region Methods
        public void VisitSignInPage() => _seleniumDriver.Navigate().GoToUrl(_signinPageUrl);
        public void PopulateEmail(string emailAddress) => _emailField.SendKeys(emailAddress);
        public void PopulatePassword(string password) => _passwordField.SendKeys(password);
        public void ClickSignIn() => _signInLink.Click();

        #endregion
    }
}

