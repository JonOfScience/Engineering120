using AP_TestAutomationFramework.lib;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AP_TestAutomationFramework.tests
{
    public class Tests
    {
        // How would I redo my TESTS for different browsers - Use inheritance
        private AP_Website<ChromeDriver> AP_Website = new();

        [Test]
        public void GivenIAmOnTheHomePage_WhenIClickTheSigninButton_ThenIShouldLandOnTheSignInPage()
        {
            AP_Website.AP_HomePage.VisitHomePage();
            Thread.Sleep(5000);
            AP_Website.AP_HomePage.VisitSignInPage();
            Thread.Sleep(5000);
            Assert.That(AP_Website.SeleniumDriver.Title, Does.Contain("Login - My Store"));
        }

        [Test]
        public void GivenImOnTheSignInPage_AndINoCredentials_WhenIClickTheSignInButton_ThenIGetAnErrorMessage()
        {
            AP_Website.AP_SigninPage.VisitSignInPage();
            Thread.Sleep(5000);
            AP_Website.AP_SigninPage.ClickSignIn();
            Thread.Sleep(5000);
            IWebElement alert = AP_Website.SeleniumDriver.FindElement(By.ClassName("alert"));
            Assert.That(alert.Text, Does.Contain("email address required"));
        }

        [Test]
        public void GivenImOnTheSignInPage_AndIEnterA4DigitPassword_WhenIClickTheSignInButton_ThenIGetAnErrorMessage()
        {
            AP_Website.AP_SigninPage.VisitSignInPage();
            Thread.Sleep(5000);
            AP_Website.AP_SigninPage.PopulatePassword("four");
            AP_Website.AP_SigninPage.ClickSignIn();
            Thread.Sleep(5000);
            IWebElement alert = AP_Website.SeleniumDriver.FindElement(By.ClassName("alert"));
            Assert.That(alert.Text, Does.Contain("email address required"));
        }

        [Test]
        public void GivenImOnTheSignInPage_AndIEnterAnEmailAddressAndA4DigitPassword_WhenIClickTheSignInButton_ThenIGetAnErrorMessage()
        {
            AP_Website.AP_SigninPage.VisitSignInPage();
            Thread.Sleep(5000);
            AP_Website.AP_SigninPage.PopulateEmail("jon@gmail.com");
            AP_Website.AP_SigninPage.PopulatePassword("four");
            AP_Website.AP_SigninPage.ClickSignIn();
            Thread.Sleep(5000);
            IWebElement alert = AP_Website.SeleniumDriver.FindElement(By.ClassName("alert"));
            Assert.That(alert.Text, Does.Contain("Invalid password"));
        }

        [Test]
        public void GivenImOnTheSignInPage_AndIEnterAnInvalidlyFormattedEmailAddressAndAPassword_WhenIClickTheSignInButton_ThenIGetAnErrorMessage()
        {
            AP_Website.AP_SigninPage.VisitSignInPage();
            Thread.Sleep(5000);
            AP_Website.AP_SigninPage.PopulateEmail("jongmail.com");
            AP_Website.AP_SigninPage.PopulatePassword("password");
            AP_Website.AP_SigninPage.ClickSignIn();
            Thread.Sleep(5000);
            IWebElement alert = AP_Website.SeleniumDriver.FindElement(By.ClassName("alert"));
            Assert.That(alert.Text, Does.Contain("Invalid email address"));
        }

        [Test]
        public void GivenImOnTheSignInPage_AndIEnterInvalidCredentials_WhenIClickTheSignInButton_ThenIGetAnErrorMessage()
        {
            AP_Website.AP_SigninPage.VisitSignInPage();
            Thread.Sleep(5000);
            AP_Website.AP_SigninPage.PopulateEmail("jon@gmail.com");
            AP_Website.AP_SigninPage.PopulatePassword("password");
            AP_Website.AP_SigninPage.ClickSignIn();
            Thread.Sleep(5000);
            IWebElement alert = AP_Website.SeleniumDriver.FindElement(By.ClassName("alert"));
            Assert.That(alert.Text, Does.Contain("Authentication failed"));
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}