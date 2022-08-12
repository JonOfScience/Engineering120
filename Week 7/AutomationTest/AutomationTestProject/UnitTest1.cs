namespace AutomationTestProject
{
    public class Tests
    {
        [Ignore("Different site and takes extra time")]
        [Test]
        public void GivenIAmOnTheHomePage_WhenIClickTheSignInLink_ThenILandOnTheSignInPage()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
                IWebElement signinLink = driver.FindElement(By.LinkText("Sign in"));
                signinLink.Click();
                Thread.Sleep(5000);
                Assert.That(driver.Title, Is.EqualTo("Login - My Store"));
            }
        }

        [Test]
        public void GivenIAmOnTheSigninPage_AndIEnterA4DigitPassword_WhenIClickTheSigninButton_ThenIGetErrorMessage()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                // Thread.Sleep(5000);
                IWebElement emailField = driver.FindElement(By.Id("user-name"));
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                emailField.SendKeys("nish@nish.com");
                passwordField.SendKeys("four");
                passwordField.SendKeys(Keys.Enter);
                // Thread.Sleep(5000);
                IWebElement alert = driver.FindElement(By.ClassName("error-message-container"));
                Assert.That(alert.Text, Does.Contain("sadface"));
            }
        }

        [Test]
        public void GivenIAmOnTheSigninPage_AndIEnterNoDetails_WhenIClickTheLoginButton_ThenIGetErrorMessage()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                IWebElement loginButton = driver.FindElement(By.Id("login-button"));
                loginButton.Click();
                IWebElement alert = driver.FindElement(By.ClassName("error-message-container"));
                Assert.That(alert.Text, Does.Contain("Username is required"));
            }
        }

        [Test]
        public void GivenIAmOnTheSigninPage_AndIEnterOnlyAUsername_WhenIClickTheLoginButton_ThenIGetErrorMessage()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                IWebElement emailField = driver.FindElement(By.Id("user-name"));
                emailField.SendKeys("nish@nish.com");
                IWebElement loginButton = driver.FindElement(By.Id("login-button"));
                loginButton.Click();
                IWebElement alert = driver.FindElement(By.ClassName("error-message-container"));
                Assert.That(alert.Text, Does.Contain("Password is required"));
            }
        }

        [Test]
        public void GivenIAmOnTheSigninPage_AndIEnterAValidUsernameAndInvalidPassword_WhenIClickTheLoginButton_ThenIGetErrorMessage()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                IWebElement emailField = driver.FindElement(By.Id("user-name"));
                emailField.SendKeys("standard_user");
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                passwordField.SendKeys("four");
                IWebElement loginButton = driver.FindElement(By.Id("login-button"));
                loginButton.Click();
                IWebElement alert = driver.FindElement(By.ClassName("error-message-container"));
                Assert.That(alert.Text, Does.Contain("Username and password do not match any user"));
            }
        }

        [Test]
        public void GivenIAmOnTheSigninPage_AndIEnterAnInvalidUsernameAndValidPassword_WhenIClickTheLoginButton_ThenIGetErrorMessage()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                IWebElement emailField = driver.FindElement(By.Id("user-name"));
                emailField.SendKeys("nish@nish.com");
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                passwordField.SendKeys("secret_sauce");
                IWebElement loginButton = driver.FindElement(By.Id("login-button"));
                loginButton.Click();
                IWebElement alert = driver.FindElement(By.ClassName("error-message-container"));
                Assert.That(alert.Text, Does.Contain("Username and password do not match any user"));
            }
        }

        [Test]
        public void GivenIAmOnTheSigninPage_AndIEnterValidCredentials_WhenIClickTheLoginButton_ThenILandOnTheProductsPage()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                IWebElement emailField = driver.FindElement(By.Id("user-name"));
                emailField.SendKeys("standard_user");
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                passwordField.SendKeys("secret_sauce");
                IWebElement loginButton = driver.FindElement(By.Id("login-button"));
                loginButton.Click();
                IWebElement secondaryHeader = driver.FindElement(By.ClassName("title"));
                Assert.That(secondaryHeader.Text, Does.Contain("PRODUCTS"));
            }
        }
        
        [Test]
        public void GivenIAmOnTheSigninPage_AndIEnterValidCredentials_WhenIPressEnter_ThenILandOnTheProductsPage()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                IWebElement emailField = driver.FindElement(By.Id("user-name"));
                emailField.SendKeys("standard_user");
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                passwordField.SendKeys("secret_sauce");
                passwordField.SendKeys(Keys.Enter);
                IWebElement secondaryHeader = driver.FindElement(By.ClassName("title"));
                Assert.That(secondaryHeader.Text, Does.Contain("PRODUCTS"));
            }
        }

        [Test]
        public void GivenITryToNavigateToAPageThatNeedsLogin_ThenILandOnTheLoginPage_AndGetAnError()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                driver.Navigate().GoToUrl("https://www.saucedemo.com/inventory.html");                
                Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/"));
                IWebElement alert = driver.FindElement(By.ClassName("error-message-container"));
                Assert.That(alert.Text, Does.Contain("You can only access '/inventory.html' when you are logged in."));
            }
        }

        // GO TO A PAGE THAT DOESN'T EXIST e.g. https://www.saucedemo.com/saucedemon.html
        
        // ADD TO CART
        [Test]
        public void GivenIAmOnTheLoginPage_AndILogIn_WhenIClickOnAddToCart_ItAddsToTheCart()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                // LOGIN
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                IWebElement emailField = driver.FindElement(By.Id("user-name"));
                emailField.SendKeys("standard_user");
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                passwordField.SendKeys("secret_sauce");
                passwordField.SendKeys(Keys.Enter);
                // ON INVENTORY PAGE 
                IWebElement addBackpack = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
                addBackpack.Click();
                IWebElement shoppingCart = driver.FindElement(By.ClassName("shopping_cart_badge"));
                Assert.That(shoppingCart.Text, Is.EqualTo("1"));
            }
        }

        // REMOVE FROM CART

        // GO TO CART WITH 1 ITEM IN THE CART
        [Test]
        public void GivenIAmOnTheLoginPage_AndILogIn_AndIAddAnItem_WhenIClickOnTheCart_ILandOnYourCart()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                // LOGIN
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                IWebElement emailField = driver.FindElement(By.Id("user-name"));
                emailField.SendKeys("standard_user");
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                passwordField.SendKeys("secret_sauce");
                passwordField.SendKeys(Keys.Enter);
                // ON INVENTORY PAGE 
                IWebElement addBackpack = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
                addBackpack.Click();
                IWebElement shoppingCart = driver.FindElement(By.ClassName("shopping_cart_badge"));
                Assert.That(shoppingCart.Text, Is.EqualTo("1"));
                // GO TO CART
                IWebElement yourCart = driver.FindElement(By.ClassName("shopping_cart_link"));
                yourCart.Click();
                Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/cart.html"));
                IWebElement secondaryHeader = driver.FindElement(By.ClassName("title"));
                Assert.That(secondaryHeader.Text, Does.Contain("YOUR CART"));

            }
        }

        // GO TO CHECKOUT WITH 1 ITEM IN THE CART
        [Test]
        public void GivenIAmOnTheLoginPage_AndILogIn_AndIAddAnItem_AndIGoToTheCart_WhenIClickOnCheckout_ILandOnCheckoutStepOne()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                // LOGIN
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                IWebElement emailField = driver.FindElement(By.Id("user-name"));
                emailField.SendKeys("standard_user");
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                passwordField.SendKeys("secret_sauce");
                passwordField.SendKeys(Keys.Enter);
                // ON INVENTORY PAGE 
                IWebElement addBackpack = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
                addBackpack.Click();
                IWebElement shoppingCart = driver.FindElement(By.ClassName("shopping_cart_badge"));
                // GO TO CART
                IWebElement yourCart = driver.FindElement(By.ClassName("shopping_cart_link"));
                yourCart.Click();
                // GO TO CHECKOUT
                IWebElement checkout = driver.FindElement(By.Id("checkout"));
                checkout.Click();
                Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/checkout-step-one.html"));
                IWebElement secondaryHeader = driver.FindElement(By.ClassName("title"));
                Assert.That(secondaryHeader.Text, Does.Contain("CHECKOUT: YOUR INFORMATION"));
            }
        }
    }
}