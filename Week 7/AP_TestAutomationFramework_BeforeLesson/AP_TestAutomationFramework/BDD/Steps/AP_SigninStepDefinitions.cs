using System;
using TechTalk.SpecFlow;
using AP_TestAutomationFramework.lib;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using AP_TestAutomationFramework.Utils;
using TechTalk.SpecFlow.Assist;

namespace AP_TestAutomationFramework.BDD.Steps
{
    [Binding]
    public class AP_SigninStepDefinitions
    {
        public AP_Website<ChromeDriver> AP_Website { get; } = new AP_Website<ChromeDriver>();
        private Credentials _credentials;

        // Scoping based on tag
        [BeforeScenario("@SadPath")]
        public void SadPath_BeforeScenario()
        {
            AP_Website.SeleniumDriver.Navigate().GoToUrl(@"https://c.tenor.com/TGU9Y4QljOMAAAAi/wontae-hamster.gif");
        }

        [Given(@"I am on the signin page")]
        public void GivenIAmOnTheSigninPage()
        {
            AP_Website.AP_SigninPage.VisitSignInPage();
        }

        [Given(@"I have entered the email ""([^""]*)""")]
        public void GivenIHaveEnteredTheEmail(string email)
        {
            AP_Website.AP_SigninPage.InputEmailLogin(email);
        }

        [Given(@"I have entered the password ""([^""]*)""")]
        public void GivenIHaveEnteredThePassword(string password)
        {
            AP_Website.AP_SigninPage.InputPasswordLogin(password);
        }

        [Given(@"I have the following credentials:")]
        public void GivenIHaveTheFollowingCredentials(Table table)
        {
            _credentials = table.CreateInstance<Credentials>();
        }

        [When(@"enter these credentials")]
        public void WhenEnterTheseCredentials()
        {
            AP_Website.AP_SigninPage.InputSigninCredentials(_credentials);
        }


        [When(@"I click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            AP_Website.AP_SigninPage.ClickSignin();
        }

        [When(@"I click on the forgot your password\? link")]
        public void WhenIClickOnTheForgotYourPasswordLink()
        {
            AP_Website.AP_SigninPage.ClickForgotPasswordLink();
        }

        [Then(@"I will got to a form to reset mhy password")]
        public void ThenIWillGotToAFormToResetMhyPassword()
        {
            Assert.That(AP_Website.GetPageTitle(), Is.EqualTo("Forgot your password - My Store").IgnoreCase);
        }


        [Then(@"I should see an alert containing the error message ""([^""]*)""")]
        public void ThenIShouldSeeAnAlertContainingTheErrorMessage(string expected)
        {
            Assert.That(AP_Website.AP_SigninPage.GetAlertTextSignin(), Does.Contain(expected));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            // AP_Website.SeleniumDriver.Dispose(); Not needed .Quit() and .Dispose() do the same job
        }
    }
}
