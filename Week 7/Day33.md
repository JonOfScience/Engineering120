# Day 33 - 10/08/2022 - Mobile & Web Testing

[TOC]

## Manual Mobile & Web Testing

How do we Test a Web App?
- Visual
- Cross-Browser and Device Testing (Device Fragmentation)

Usability testing
- Visual testing - Manual testing

Web and Device Fragmentation
- Different Platform
- Different OS
- Different browsers

63,000 possible combinations at this time.

How do we decide what to test? 
- Based on requirementes
- Depends on our userbase

Traffic Distribution
- 52% - Mobile
- 44% - Desktop
- 4% - Tablet

Distribution data used to decide testing

Mobile device vendors
- Top 6 cover 77% of the market

Browsers
- Chrome - 63.72%
- Safari
- Firefox

Exhaustive Testing is impossible!!!

Responsiveness
: How a website or app renders on different displays and screen sizes. Does it adjusts layout to reflect this.

Responsiveness Tests
Google Mobile Tester

Websites need to be optimised for smaller devices
60% - of searches are on mobile
Responsiveness feeds into Google Rankings

Functional Testing - Requirements Based Testing - Black Box Testing

Things to look out for
- Form fields - GOLDILOCKS
- Character limits and checks - 
- Broken Links - 
- Broken Buttons - 
- Error Messages & Notices - 
- Data Integrity - 

Google Dorking

## Web Automated Testing (Selenium)

Automation Pyramid - Automated GUI Tests - Brittle
- Tests become more brittle as they are more complex (longer)
- More stuff between the input and the output

POM Framework
BDD
SpecFlow

- Once all the test scripts for a requirement have passed we can say the requirement is satisfied

### Why automate?

- We don't to have to keep testing a function every time we make any changes to our code.
- Free up time for manual tests to do exploratory testing and create new tests
- Can run health checks after deplots
- Automated tests can be set up to run after hours

### Drawbacks of Automation Testing
- Time consuming to build and run
- Expensive to maintain
- Can be complex
- Tests can be "flakey"
- This applies to application GUIs and even more so to Web Interfaces

### What to automate

- Can't cover all scenarios 
- Concentrate on the important paths
    - Where users spend the most time
    - Test the paths that add (the most) value to the business (e.g. sign in to checkout)
    - ...

### Cost of Web Automation Testing

Cost of creation
- ...

Cost of running
- ...

### Automation can make testers' lives easier BUT...

### Record & Playback Testing Tools

Selenium
: Something we speak to in our language to make the browser do something

#### Selenium IDE
*"Easy, anyone can use it"* - Nish
Records actions

#### Selenium Web-Driver API

Allows our C# code (via language bindings) to tell the WebDriver what to do

https://www.automatetheplanet.com/wp-content/uploads/2017/02/MostCompleteWebDriverCSharpCheetSheet.pdf

==Can use the SELENIUM IDE to capture Targets for WebDriverAPI testing==

http://automationpractice.com/index.php


Install:
Selenium.WebDriver                  All
Selenium.WebDriver.ChromeDrive      Chrome
Selenium.WebDriver.GeckoDriver      Firefox

###### 1. Add to `usings.cs`
```csharp
global using OpenQA.Selenium;
global using OpenQA.Selenium.Chrome;
global using OpenQA.Selenium.Firefox;
```

###### 2a. Set up the resource (with `IDisposable`) for Chrome
```csharp
[Test]
public void GivenIAmOnTheHomePage_WhenIClickTheSignInLink_ThenILandOnTheSignInPage()
{
    using (IWebDriver driver = new ChromeDriver())
    {
    }
}
```

###### 2b. Set up the resource (with `IDisposable`) for Firefox
```csharp
[Test]
public void GivenIAmOnTheHomePage_WhenIClickTheSignInLink_ThenILandOnTheSignInPage()
{
    using (IWebDriver driver = new FirefoxDriver())
    {
    }
}
```

##### 3. Maximise the browser so it is full screen
```csharp
driver.Manage().Window.Maximize();
```

##### 4. Navigate to the AP site
```csharp
driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
```

##### 5. Grab the sign in link
```csharp
IWebElement signinLink = driver.FindElement(By.LinkText("Sign in"));
signinLink.Click();
```
Can use class names, CSS selectors, ids, link text, name, partial link text, tag name (`htmltag[attribute_name]='attribute_value'`), and xpath.

xpath
: Based on the structure of the website. Very brittle. Don't use.

##### 6. Wait to ensure response
```csharp
Thread.Sleep(5000);
```
[Not aware of any asynchronous functions in Selenium so probably can't use `await`]
[Navigating is a synchronous path]

##### 7. Assert - that we have arrived on the sign in page
```csharp
Assert.That(driver.Title, Is.EqualTo("Login - My Store"));
```

##### COMPLETE TEST HAPPY PATH
```csharp
[Test]
public void GivenIAmOnTheHomePage_WhenIClickTheSignInLink_ThenILandOnTheSignInPage()
{
    using (IWebDriver driver = new ChromeDriver())
    {
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        IWebElement signinLink = driver.FindElement(By.LinkText("Sign in"));
        signinLink.Click();
        Thread.Sleep(5000);
        Assert.That(driver.Title, Is.EqualTo("Login - My Store"));
    }
}
```

##### COMPLETE TEST HAPPY PATH (Changed server due to server issues)
```csharp
[Test]
public void GivenIAmOnTheSigninPage_AndIEnterA4DigitPassword_WhenIClickTheSigninButton_ThenIGetErrorMessage()
{
    using (IWebDriver driver = new ChromeDriver())
    {
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
        
        Thread.Sleep(5000);
        
        IWebElement emailField = driver.FindElement(By.Id("email"));
        IWebElement passwordField = driver.FindElement(By.Id("passwd"));
        emailField.SendKeys("nish@nish.com");
        passwordField.SendKeys("four");
        // passwordField.SendKeys(Keys.Enter)
        // OR
        IWebElement signinButton = driver.FindElement(By.Id("SubmitLogin"));
        signinButton.Click();
        
        Thread.Sleep(5000); // Give time for the alert message to populate
        
        IWebElement alert = driver.FindElement(By.ClassName("alert"));
        Assert.That(alert.Text.Contains("Invalid password."));
    }
}
```

#### Headless Browser

- Run Driver headlessly - Doesn't invoke the UI
- It is faster
- Can run tests if the browser isn't installed
Downsides
- No visualisation (visual feedback)

##### Headless For Chrome
```csharp
var options = new ChromeOptions();
options.AddArguments("headless");
using (IWebDriver driver = new ChromeDriver(options))
```

##### Headless For Firefox
```csharp
var options = new FirefoxOptions();
options.AddArguments("--headless");
using (IWebDriver driver = new FirefoxDriver(options))
```

##### TASK
Saucedemo- create some more tests 

Create tests for
http://the-internet.herokuapp.com/


##### Web Scraper Using Selenium
```csharp
static void Main(string[] args)
{
    IReadOnlyCollection<IWebElement> results;
    using (var driver = new ChromeDriver())
    {
        driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        driver.Manage().Cookies.DeleteAllCookies();
        var search = driver.FindElement(By.Id("search_query_top"));
        search.SendKeys("Dress");
        search.SendKeys(Keys.Enter);
        results = driver.FindElements(By.ClassName("ajax_block_product"));
        using (StreamWriter sw = File.CreateText("results.csv"))
        {
            sw.WriteLine("item,price,in_stock");
            foreach (var item in results)
            {

                Console.WriteLine(item.Text);
                string result = "";
                string[] lines = item.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (var line in lines)
                {
                    result += line + ",";
                }
                sw.WriteLine(result);

            }
        }
    }
}
```

### Page Object (POM)

https://martinfowler.com/bliki/PageObject.html

![POM](https://www.guru99.com/images/AdvanceSelenium/071514_0722_PageObjectM2.png)

